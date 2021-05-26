using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ToolBarDcad.DesignCad;
using ToolBarDcad.Paths;
using ToolBarDcad.Tools;
using Microsoft.VisualBasic;
using System.Text;
using System.Windows.Media.Imaging;
using Rectangle = System.Drawing.Rectangle;
using Application = DesignCAD.Application;
using System.Runtime.InteropServices;
using System.Drawing;

namespace ToolBarDcad
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Application App;
        public string Model;
        public string Material;
        public Dictionary<string, int> ModelsDict;
        public Dictionary<string, int> MaterialsDict;
        public Dictionary<string, string> MacroDict;
        private int _appPid;
        private bool _isShown;
        private DocumentsManager DocsManager { get; set; }
        private readonly string _pathLocalApp;
        private readonly string _pathServApp;
        private readonly string _fileNameApp;
        private readonly string _dirNameApp;
        private bool _stopRead;
        private Pallet _palletForm;
        private double _posX = 0.649;
        private double _posY = 0.032;
        private bool _ondrag = false;
        private double _scale = 1;

        // ============ Constructor =============

        public MainWindow()
        {
            InitializeComponent();

            PreviewKeyDown += HandleEsc;
            MouseDown += OnMouseLeftButtonDown;
            Loaded += MainWindow_Loaded;
            Closing += MainWindow_Closing;
            Closed += MainWindow_Closed;
            Activated += MainWindow_Activated;
            Deactivated += MainWindow_Deactivated;

            _scale = getScalingFactor() / 96;
            _palletForm = new Pallet(_scale);
            _palletForm.MouseEnter += (sender, args) => Mouse.OverrideCursor = Cursors.Hand;
            _palletForm.MouseLeave += (sender, args) => Mouse.OverrideCursor = Cursors.Arrow;

            _fileNameApp = ConfigurationManager.AppSettings["FileNameApp"];
            _dirNameApp = ConfigurationManager.AppSettings["DirNameApp"];
            _pathServApp = ConfigurationManager.AppSettings["pathServApp"];
            _pathLocalApp = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + _dirNameApp);

            InitDictionaries();

            ModelComboBox.SelectionChanged += ModelComboBox_SelectionChanged;
            MaterialComboBox.SelectionChanged += MaterialComboBox_SelectionChanged;
            _stopRead = false;
        }
        // ============ BackgroundWorkers =============

        /// <summary>
        /// Handles the end of the Worker thread, when DesignCAD instance is found. It will create a new <see cref="DocumentsManager"/>, will display the Main Window with the <see cref="Pallet"/>,
        /// and will start 2 new background workers.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DocsManager = new DocumentsManager(App);
            _palletForm.DocManager = DocsManager;
            DocsManager.RaiseDialogBoxEvent += DocsManager_RaiseDialogBoxEvent;
            DocsManager.RaiseLaunchMacrosEvent += DocsManager_RaiseLaunchMacrosEvent;
            Dispatcher.Invoke((Action)(() => DocsManager.SetActiveDoc()));

            Dispatcher.BeginInvoke((Action)(() => DocTitle.Content = DocsManager.ActiveDoc.Name));

            _appPid = App.ProcessId;

            ReadFile(@"C:\KalysseDesignCAD\model_config.txt");
            Dispatcher.BeginInvoke((Action)ToggleIcons);
            Dispatcher.BeginInvoke((Action)ChangeProperties);

            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += Worker_DoWaitWork;
            worker.RunWorkerCompleted += Worker_WaitRunWorkerCompleted;
            worker.RunWorkerAsync();

            BackgroundWorker docWorker = new BackgroundWorker();
            docWorker.WorkerReportsProgress = true;
            docWorker.DoWork += DocWorker_DoWork;
            docWorker.RunWorkerCompleted += DocWorker_RunWorkerCompleted;
            docWorker.RunWorkerAsync();

            Dispatcher.BeginInvoke((Action)Show);
            Dispatcher.BeginInvoke((Action)_palletForm.Show);
            _isShown = true;
            Debug.WriteLine("Run worker completed");
        }

        /// <summary>
        /// Loops until a DesignCAD instance is found.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            bool isFound = false;

            while (App == null)
            {
                Thread.Sleep(1000);
                if (!ProcessTools.CheckProcByName("DcP10")) continue;
                try
                {
                    App = (Application)Interaction.GetObject(null, "DesignCAD.Application.26"); // Gets app instance
                    App.BringToTop();
                    while (isFound == false)
                    {
                        Thread.Sleep(500);
                        if (App.ActiveDocument == null) continue;
                        isFound = true;
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message + Environment.NewLine + ex.StackTrace);
                }
            }
        }

        /// <summary>
        /// Handles the end of the WaitWorker thread, when DesignCAD is closed. It will hide the Main Window with the <see cref="Pallet"/>, and start a BackgroundWorker.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Worker_WaitRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Dispatcher.BeginInvoke((Action)Hide);
            Dispatcher.BeginInvoke((Action)_palletForm.Hide);
            _isShown = false;
            DocsManager = null;
            App = null;

            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            worker.RunWorkerAsync();

            Debug.WriteLine("WaitRunWorker completed");
        }

        /// <summary>
        /// Loops until DesignCAD is closed. Sets the menu position in relation with DesignCAD position.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Worker_DoWaitWork(object sender, DoWorkEventArgs e)
        {
            while (ProcessTools.CheckProcWithPid(_appPid))
            {
                Thread.Sleep(500);
                if (App == null) break;

                Dispatcher.BeginInvoke((Action)(() =>
                {
                    bool isActive = WindowTools.IsActive(GetWindow(this));
                    bool isPalletActive = WindowTools.IsActive(GetWindow(_palletForm));
                    if (WindowTools.IsDesignCADActive(App) || isActive || isPalletActive)
                    {
                        if (_isShown == false)
                        {
                            try
                            {
                                Show();
                                _palletForm.Show();
                            }
                            catch
                            {
                                return;
                            }
                        }

                        _isShown = true;
                    }
                    else if (WindowTools.IsDesignCADActive(App) == false)
                    {
                        if (_isShown)
                        {
                            try
                            {
                                Hide();
                                _palletForm.Hide();
                            }
                            catch
                            {
                                return;
                            }
                        }

                        _isShown = false;
                    }
                }));

                if (App == null) break;
                Rectangle r = WindowTools.GetWindowRect("DcP10");

                if (_ondrag == _palletForm._ondrag)
                {
                    Dispatcher.BeginInvoke((Action)(() =>
                    {
                        Left = (_posX * r.Width + r.Left) / _scale;
                        Top = (_posY * r.Height + r.Top) / _scale;
                    }));

                    Dispatcher.BeginInvoke((Action)(() =>
                    {
                        _palletForm.Left = (_palletForm._posX * r.Width + r.Left) / _scale;
                        _palletForm.Top = (_palletForm._posY * r.Height + r.Top) / _scale;
                    }));
                }

                if (_stopRead == false)
                {
                    ReadFile(@"C:\KalysseDesignCAD\model_config.txt");
                    Dispatcher.BeginInvoke((Action)ToggleIcons);
                    Dispatcher.BeginInvoke((Action)ChangeProperties);
                }
            }
        }

        /*
         * 
         * La fonction getScalingFactor() return la mise à l'echelle de l'écran (à diviser par 96 pour avoir le ratio)
         * Exemple : 96 -> 1.00 (100%) ou 120 -> 1.25 (125%)
         * Pour plus d'informations sur l'enum DeviceCap : http://pinvoke.net/default.aspx/gdi32/GetDeviceCaps.html
         *
         * 
         */

        [DllImport("gdi32.dll")]

        static extern int GetDeviceCaps(IntPtr hdc, int nIndex);

        public enum DeviceCap
        {
            VERTSIZE = 6,
            VERTRES = 10,
            LOGPIXELSX = 88,
            LOGPIXELSY = 90,
            SCALINGFACTORX = 114,
            DESKTOPVERTRES = 117,
        }


        private float getScalingFactor()
        {
            Graphics g = Graphics.FromHwnd(IntPtr.Zero);
            IntPtr desktop = g.GetHdc();
            int LogicalScreenHeight = GetDeviceCaps(desktop, (int)DeviceCap.VERTRES);
            int PhysicalScreenHeight = GetDeviceCaps(desktop, (int)DeviceCap.DESKTOPVERTRES);

            float ScreenScalingFactor = (float)(GetDeviceCaps(Graphics.FromHwnd(IntPtr.Zero).GetHdc(), (int)DeviceCap.LOGPIXELSX));

            return ScreenScalingFactor;
        }



        /// <summary>
        /// Handles the end of the DocWorker thread.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void DocWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Debug.WriteLine("DocWorker completed.");
        }

        /// <summary>
        /// Loops until DesignCAD is closed. Looks constantly for a new document to be opened.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void DocWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (ProcessTools.CheckProcWithPid(_appPid))
            {
                Thread.Sleep(500);
                if (App == null) break;
                if (!WindowTools.IsDesignCADActive(App)) continue;
                try
                {
                    Dispatcher.BeginInvoke((Action)(() =>
                    {
                        if (App.ActiveDocument == null)
                        {
                            DocTitle.Content = "no document";
                        }

                        if (App.ActiveDocument != DocsManager.ActiveDoc)
                        {
                            DocsManager.SetActiveDoc();
                        }
                    }));
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message + Environment.NewLine + ex.StackTrace);
                    return;
                }
            }
        }

        // ============ Class methods =============

        /// <summary>
        /// Looks if the software needs to be updated thanks to the .exe version.
        /// </summary>
        /// <returns></returns>

        private bool NeedUpdate()
        {
            if (!File.Exists(System.IO.Path.Combine(_pathLocalApp, _fileNameApp)))
                return true;
            if (!File.Exists(System.IO.Path.Combine(_pathServApp, _fileNameApp)))
                return false;
            var VersionServ = FileVersionInfo.GetVersionInfo(System.IO.Path.Combine(_pathServApp, _fileNameApp));
            var VersionLocal = FileVersionInfo.GetVersionInfo(System.IO.Path.Combine(_pathLocalApp, _fileNameApp));

            int MajorServ = VersionServ.ProductMajorPart;
            int MinorServ = VersionServ.ProductMinorPart;
            int BuildServ = VersionServ.ProductBuildPart;
            int RevServ = VersionServ.ProductPrivatePart;

            int MajorLocal = VersionLocal.ProductMajorPart;
            int MinorLocal = VersionLocal.ProductMinorPart;
            int BuildLocal = VersionLocal.ProductBuildPart;
            int RevLocal = VersionLocal.ProductPrivatePart;

            if (MajorServ > MajorLocal)
            {
                return true;
            }
            if (MajorServ == MajorLocal && MinorServ > MinorLocal)
            {
                return true;
            }
            if (MajorServ == MajorLocal && MinorServ == MinorLocal && BuildServ > BuildLocal)
            {
                return true;
            }
            if (MajorServ == MajorLocal && MinorServ == MinorLocal && BuildServ == BuildLocal && RevServ > RevLocal)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Initialize the dictionnaries used to launch the macros.
        /// </summary>

        private void InitDictionaries()
        {
            ModelsDict = new Dictionary<string, int>()
            {
                {"primo", 0},
                {"primo exel", 1},
                {"duo", 2},
                {"duo exel", 3},
                {"brio", 4},
                {"brio exel", 5},
                {"hauzeo", 6},
                {"bambino", 7},
                {"exeleo", 8}
            };

            MaterialsDict = new Dictionary<string, int>()
            {
                {"nylon", 0},
                {"alu", 1},
                {"inox", 2}
            };

            MacroDict = InitializeMenu.InitMacroDict();
        }

        /// <summary>
        /// Read the 2 first lines of a file with the specified path. Stores its value in <see cref="Model" /> and <see cref="Material" />.
        /// </summary>
        /// <param name="path"></param>

        private void ReadFile(string path)
        {
            try
            {
                string[] lines = File.ReadAllLines(path);

                if (lines.Length != 2)
                {
                    Model = "corrupted";
                    Material = "file";
                }
                else
                {
                    Model = lines[0];
                    Material = lines[1];
                }
            }
            catch (FileNotFoundException e)
            {
                Debug.WriteLine(e);
                Model = "error";
                Material = "no config file";
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message + Environment.NewLine + e.StackTrace);
            }
        }

        /// <summary>
        /// Changes icons depending on which model or material is selected.
        /// </summary>

        public void ToggleIcons()
        {
            if (Model == "primo exel" || Model == "duo exel" || Model == "exeleo")
                ChapButton.ToolTip = new ToolTip { Content = "Kit 4 chapes" };
            else if (Model == "brio")
                ChapButton.ToolTip = new ToolTip { Content = "Repère 50" };
            else if (Model == "brio exel")
                ChapButton.ToolTip = new ToolTip { Content = "Repère 60" };
            else if (Model == "hauzeo")
                ChapButton.ToolTip = new ToolTip { Content = "Repère 70" };
            else
                ChapButton.ToolTip = new ToolTip { Content = "Kit 3 chapes" };
            if (Model == "bambino")
                ChapIcon.Source = new BitmapImage(new Uri(@"/Icones/Chape_bambino.ico", UriKind.Relative));
            else
                ChapIcon.Source = new BitmapImage(new Uri(@"/Icones/Chape.ico", UriKind.Relative));

            FootButton.ToolTip = new ToolTip { Content = "Pied " + Material };

            ChangeRefendButtons(Model);
            ChangeProfileButtons(Model);
        }

        /// <summary>
        /// Changes the profile button's texts according to the model selected.
        /// </summary>
        /// <param name="model"></param>

        public void ChangeProfileButtons(string model)
        {
            switch (model)
            {
                case "primo":
                    Repere0.Content = "10";
                    Repere2.Content = "12";
                    Repere2P.Content = "12P";
                    Repere4.Content = "14";
                    break;
                case "primo exel":
                    Repere0.Content = "20";
                    Repere2.Content = "22";
                    Repere2P.Content = "22P";
                    Repere4.Content = "24";
                    break;
                case "duo":
                    Repere0.Content = "30";
                    Repere2.Content = "32";
                    Repere2P.Content = "32P";
                    Repere4.Content = "34";
                    break;
                case "duo exel":
                    Repere0.Content = "40";
                    Repere2.Content = "42";
                    Repere2P.Content = "42P";
                    Repere4.Content = "44";
                    break;
                case "brio":
                    Repere0.Content = "50";
                    Repere2.Content = "52";
                    Repere2P.Content = "52P";
                    Repere4.Content = "54";
                    break;
                case "brio exel":
                    Repere0.Content = "60";
                    Repere2.Content = "62";
                    Repere2P.Content = "62P";
                    Repere4.Content = "64";
                    break;
                case "hauzeo":
                    Repere0.Content = "70";
                    Repere2.Content = "72";
                    Repere2P.Content = "72P";
                    Repere4.Content = "74";
                    break;
                case "exeleo":
                    Repere0.Content = "80";
                    Repere2.Content = "82";
                    Repere2P.Content = "82P";
                    Repere4.Content = "84";
                    break;
                case "bambino":
                    Repere0.Content = "90";
                    Repere2.Content = "92";
                    Repere2P.Content = "92P";
                    Repere4.Content = "94";
                    break;
            }
        }

        /// <summary>
        /// Changes refend's icons path if exeleo model is selected.
        /// </summary>
        /// <param name="model"></param>

        public void ChangeRefendButtons(string model)
        {
            if (model == "exeleo")
            {
                RcIcon.Source = new BitmapImage(new Uri(@"/Icones/Feuillures ext.ico", UriKind.Relative));
                RagButton.ToolTip = new ToolTip { Content = "Feuillure intérieure gauche" };
                RadButton.ToolTip = new ToolTip { Content = "Feuillure intérieure droite" };
                RbButton.ToolTip = new ToolTip { Content = "Feuillures intérieures" };
                RcgButton.ToolTip = new ToolTip { Content = "Feuillure extérieure gauche" };
                RcdButton.ToolTip = new ToolTip { Content = "Feuillure extérieure droite" };
                RcButton.ToolTip = new ToolTip { Content = "Feuillures extérieures" };
            }
            else
            {
                RcIcon.Source = new BitmapImage(new Uri(@"/Icones/RC.ico", UriKind.Relative));
                RagButton.ToolTip = new ToolTip { Content = "Refend A Gauche" };
                RadButton.ToolTip = new ToolTip { Content = "Refend A Droit" };
                RbButton.ToolTip = new ToolTip { Content = "Refend B" };
                RcgButton.ToolTip = new ToolTip { Content = "Refend C Gauche" };
                RcdButton.ToolTip = new ToolTip { Content = "Refend C Droit" };
                RcButton.ToolTip = new ToolTip { Content = "Refend C" };
            }
        }

        /// <summary>
        /// Changes the selected model and material in the <see cref="ModelComboBox"/> and the <see cref="MaterialComboBox"/> according to the <see cref="Model"/>
        /// and <see cref="Material"/> properties.
        /// </summary>

        private void ChangeProperties()
        {
            try
            {
                ModelComboBox.SelectionChanged -= ModelComboBox_SelectionChanged;
                MaterialComboBox.SelectionChanged -= MaterialComboBox_SelectionChanged;
                ModelComboBox.SelectedIndex = ModelsDict[Model];
                MaterialComboBox.SelectedIndex = MaterialsDict[Material];
            }
            catch
            {
                //unused
            }
            finally
            {
                ModelComboBox.SelectionChanged += ModelComboBox_SelectionChanged;
                MaterialComboBox.SelectionChanged += MaterialComboBox_SelectionChanged;
            }
        }

        /// <summary>
        /// This method will try to run a macro in the current document. If it fails, display error messages based on the <see cref="DocumentsManager.RunMacroOnActiveDoc"/> return value.
        /// </summary>
        /// <param name="macroName"></param>

        private void LaunchMacro(string macroName)
        {
            int result = DocsManager.RunMacroOnActiveDoc(MacroDict[macroName], macroName);

            switch (result)
            {
                case 1:
                    DocTitle.Content = DocsManager.ActiveDoc.Name;
                    break;
                case 2:
                    DocTitle.Content = "no document";
                    MessageBox.Show("Pas de document actif.", "Toolbar info", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                    break;
                case 3:
                    MessageBox.Show("Macro non trouvée.", "Toolbar info", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                    break;
            }
        }

        /// <summary>
        /// Recursivity of <see cref="FindMenuItem"/> method.
        /// </summary>
        /// <param name="menu"></param>
        /// <param name="header"></param>
        /// <returns></returns>

        private MenuItem FindSubMenu(MenuItem menu, string header)
        {
            if (menu.Items.Count < 1)
                return (null);
            foreach (var item in menu.Items)
            {
                if (header == ((MenuItem)item).Header.ToString())
                    return ((MenuItem)item);

                var result = FindSubMenu((MenuItem)item, header);
                if (result != null)
                    return (result);
            }
            return (null);
        }

        /// <summary>
        /// Finds specific MenunItem from <see cref="MacroMenu"/> corresponding at <see cref="header"/> value.
        /// </summary>
        /// <param name="header"></param>
        /// <returns></returns>

        private MenuItem FindMenuItem(string header)
        {
            foreach (var item in MacroMenu.Items)
            {
                if (header == ((MenuItem)item).Header.ToString())
                    return ((MenuItem)item);
                var result = FindSubMenu((MenuItem)item, header);
                if (result != null)
                    return (result);
            }
            return (null);
        }

        // ============ Events handlers =============

        // Controls

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            WindowTools.HideFromProgramSwitcher(this);
            Hide();

            _isShown = false;

            ModelComboBox.SelectionChanged -= ModelComboBox_SelectionChanged;
            MaterialComboBox.SelectionChanged -= MaterialComboBox_SelectionChanged;
            ModelComboBox.SelectedIndex = ModelsDict["primo"];
            MaterialComboBox.SelectedIndex = MaterialsDict["nylon"];
            ModelComboBox.SelectionChanged += ModelComboBox_SelectionChanged;
            MaterialComboBox.SelectionChanged += MaterialComboBox_SelectionChanged;

            if (ProcessTools.CheckProcByName("ToolBarDcad"))
                ProcessTools.KillAllProcWithName("ToolBarDcad");

            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            worker.RunWorkerAsync();
        }

        private void MainWindow_Activated(object sender, EventArgs e)
        {
            _stopRead = true;

            if (NeedUpdate() == false)
            {
                UpdateImage.Visibility = Visibility.Hidden;
            }
            else if (NeedUpdate())
                UpdateImage.Visibility = Visibility.Visible;
        }

        private void MainWindow_Deactivated(object sender, EventArgs e)
        {
            _stopRead = false;
        }

        private void MainWindow_Closing(object sender, CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Voulez vous vraiment quitter ?", "Quitter ?",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);
            if (result == MessageBoxResult.No)
                e.Cancel = true;
        }

        private void MainWindow_Closed(object sender, EventArgs e)
        {
            _palletForm.Close();
        }

        private void ModelComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) => LaunchMacro((e.AddedItems[0] as ComboBoxItem)?.Content.ToString());

        private void MaterialComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) => LaunchMacro((e.AddedItems[0] as ComboBoxItem)?.Content.ToString());

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                Arguments = "/C " + @"\\serv-kalysse\EDatas\Logiciels\ToolBarUpdater\ToolBarUpdater.exe",
                FileName = "cmd",
                WindowStyle = ProcessWindowStyle.Hidden
            });
        }

        // All

        public void HandleEsc(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Escape) return;
            Close();
        }
        private void OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _ondrag = true;
            base.OnMouseLeftButtonDown(e);
            this.DragMove();

            Rectangle r = WindowTools.GetWindowRect("DcP10");
            _posX = (Left - r.Left) / (r.Width / _scale);
            _posY = (Top - r.Top) / (r.Height / _scale);
            _ondrag = false;
        }

        private void DocsManager_RaiseDialogBoxEvent(object sender, EventArgs e)
        {
            NewDoc newDoc = new NewDoc();
            newDoc.ShowDialog();
            DocsManager.RefreshDocList(newDoc.CabinModel, newDoc.MaterialType);
            DocsManager_RaiseLaunchMacrosEvent(newDoc, new LaunchMacroEventArgs(MacroTools.ToCabin(newDoc.CabinModel),
                MacroTools.ToMaterial(newDoc.MaterialType)));
            newDoc.Close();
        }

        private void DocsManager_RaiseLaunchMacrosEvent(object sender, LaunchMacroEventArgs e)
        {
            if (e.Model != CabinModel.NullModel)
                LaunchMacro(MacroTools.CabinToString(e.Model));
            if (e.Type != MaterialType.NullMaterial)
                LaunchMacro(MacroTools.MaterialToString(e.Type));
        }

        private void RenoOptionCheckBox_OnChecked(object sender, RoutedEventArgs e)
        {
            if (RenoOptionCheckBox.IsChecked == true)
            {
                PNPCOptionCheckBox.IsChecked = false;
                MacroDict["ReperageFacade"] = @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\reperage_flasque.d3m";

                MenuItem item = FindMenuItem("Repérage façade");
                if (item == null) return;
                item.Header = "";
                item.Header = new StringBuilder("Repérage façade reno");

                MenuItem cabinItem = FindMenuItem("Cabine");
                MenuItem flsk = new MenuItem { Header = new StringBuilder("Poser façade reno") };

                flsk.Click += PoserFlasqueMenuItem_Click;
                if (cabinItem == null) return;
                cabinItem.Items.Insert(5, flsk);
            }
            else
            {
                MacroDict["ReperageFacade"] = @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\Nouveau_reperage\reperage_facade.d3m";

                MenuItem item = FindMenuItem("Repérage façade reno");
                if (item == null) return;
                item.Header = "";
                item.Header = new StringBuilder("Repérage façade");

                MenuItem cabinItem = FindMenuItem("Cabine");
                MenuItem flsk = FindMenuItem("Poser façade reno");

                if (cabinItem == null) return;
                cabinItem.Items.Remove(flsk);
            }
        }

        private void PNPCOptionCheckBox_OnChecked(object sender, RoutedEventArgs e)
        {
            if (PNPCOptionCheckBox.IsChecked == true)
            {
                RenoOptionCheckBox.IsChecked = false;
                MacroDict["FacadeK"] = @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\facade_depart_k_pnpc.d3m";
                MacroDict["FacadeL"] = @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\facade_depart_l_pnpc.d3m";

                MenuItem pnpcItem = FindMenuItem("PNPC");

                pnpcItem.Visibility = Visibility.Visible;
            }
            else
            {
                MacroDict["FacadeK"] = @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\facade_depart_k.d3m";
                MacroDict["FacadeL"] = @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\facade_depart_l.d3m";

                MenuItem pnpcItem = FindMenuItem("PNPC");

                pnpcItem.Visibility = Visibility.Collapsed;

            }
        }

        // Macro launchers

        private void CartoucheMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("CartoucheK");
        private void CasierBBMenuItem_Click(object sender, EventArgs e) => LaunchMacro("CasierHBanc");
        private void CasierDiploHMenuItem_Click(object sender, EventArgs e) => LaunchMacro("CasierHDiplo");
        private void CasierDiploZMenuItem_Click(object sender, EventArgs e) => LaunchMacro("CasierZDiplo");
        private void CasierBCMenuItem_Click(object sender, EventArgs e) => LaunchMacro("CasiersBancCompact");
        private void SerieC50MenuItem_Click(object sender, EventArgs e) => LaunchMacro("BancCompact50");
        private void SerieC1MenuItem_Click(object sender, EventArgs e) => LaunchMacro("BancCompact1");
        private void SerieC100MenuItem_Click(object sender, EventArgs e) => LaunchMacro("Lisse100");
        private void SerieC500MenuItem_Click(object sender, EventArgs e) => LaunchMacro("BancCompact500");
        private void SerieC550MenuItem_Click(object sender, EventArgs e) => LaunchMacro("BancCompact550");
        private void SerieC700MenuItem_Click(object sender, EventArgs e) => LaunchMacro("BancCompact700");
        private void SerieC600MenuItem_Click(object sender, EventArgs e) => LaunchMacro("BancCompact600");
        private void SerieB1MenuItem_Click(object sender, EventArgs e) => LaunchMacro("BancBoisB1");
        private void SerieB50MenuItem_Click(object sender, EventArgs e) => LaunchMacro("BancBoisB50");
        private void SerieB100MenuItem_Click(object sender, EventArgs e) => LaunchMacro("LissePatereB100");
        private void SerieB450MenuItem_Click(object sender, EventArgs e) => LaunchMacro("BancBoisB450");
        private void SerieB500MenuItem_Click(object sender, EventArgs e) => LaunchMacro("BancBoisB500");
        private void SerieB750MenuItem_Click(object sender, EventArgs e) => LaunchMacro("BancBoisB750");
        private void RepererFacadeMenuItem_Click(object sender, EventArgs e) => LaunchMacro("ReperageFacade");
        private void FacadeKMenuItem_Click(object sender, EventArgs e) => LaunchMacro("FacadeK");
        private void FacadeDMenuItem_Click(object sender, EventArgs e) => LaunchMacro("FacadeD");
        private void FacadeLMenuItem_Click(object sender, EventArgs e) => LaunchMacro("FacadeL");
        private void RepererRefendMenuItem_Click(object sender, EventArgs e) => LaunchMacro("ReperageRefend");
        private void AjusterRefendMenuItem_Click(object sender, EventArgs e) => LaunchMacro("AjusterRefend");
        private void AjusterFacadeMenuItem_Click(object sender, EventArgs e) => LaunchMacro("AjusterFacade");
        private void CotationFacadeMenuItem_Click(object sender, EventArgs e) => LaunchMacro("CotationF");
        private void CotationBandeauMenuItem_Click(object sender, EventArgs e) => LaunchMacro("CotationB");
        private void CotationAxeMenuItem_Click(object sender, EventArgs e) => LaunchMacro("CotationA");
        private void EclaterSelectionMenuItem_Click(object sender, EventArgs e) => LaunchMacro("EclaterSelection");
        private void OutilCoucheMenuItem_Click(object sender, EventArgs e) => LaunchMacro("OutilCouche");
        private void AfficherAttrMenuItem_Click(object sender, EventArgs e) => LaunchMacro("AfficherAttr");
        private void MasquerAttrMenuItem_Click(object sender, EventArgs e) => LaunchMacro("MasquerAttr");
        private void PoserAttrMenuItem_Click(object sender, EventArgs e) => LaunchMacro("AjouterAttr");
        private void ChangerAttrMenuItem_Click(object sender, EventArgs e) => LaunchMacro("ChangerAttr");
        private void ChercherAttrMenuItem_Click(object sender, EventArgs e) => LaunchMacro("ChercherAttr");
        private void MultiplierAttrMenuItem_Click(object sender, EventArgs e) => LaunchMacro("MultiplierAttr");
        private void SupprimerAttrMenuItem_Click(object sender, EventArgs e) => LaunchMacro("SupprimerAttr");
        private void ChangerMatMenuItem_Click(object sender, EventArgs e) => LaunchMacro("ChangerMateriau");
        private void SerieC20MenuItem_Click(object sender, EventArgs e) => LaunchMacro("BancCompact20");
        private void SerieC60MenuItem_Click(object sender, EventArgs e) => LaunchMacro("BancCompact60");
        private void SerieC750MenuItem_Click(object sender, EventArgs e) => LaunchMacro("BancCompact750");
        private void PareDoucheSimpleMenuItem_Click(object sender, EventArgs e) => LaunchMacro("PareDoucheSimple");
        private void PareDoucheDosADosMenuItem_Click(object sender, EventArgs e) => LaunchMacro("PareDoucheDosADos");
        private void SerieC150MenuItem_Click(object sender, EventArgs e) => LaunchMacro("LisseCompactC150");
        private void PoserPied_Click(object sender, EventArgs e) => LaunchMacro("PoserPied");
        private void PoserChape_Click(object sender, EventArgs e) => LaunchMacro("PoserChape");
        private void Repere10_Click(object sender, EventArgs e) => LaunchMacro("Repere10");
        private void Repere12_Click(object sender, EventArgs e) => LaunchMacro("Repere12");
        private void Repere12P_Click(object sender, EventArgs e) => LaunchMacro("Repere12P");
        private void Repere14_Click(object sender, EventArgs e) => LaunchMacro("Repere14");
        private void PoseLongeronsCollectifMenuItem_Click(object sender, EventArgs e) => LaunchMacro("LongeronsCollectifs");
        private void Serr001MenuItem_Click(object sender, EventArgs e) => LaunchMacro("PoseSerr001");
        private void Serr006MenuItem_Click(object sender, EventArgs e) => LaunchMacro("PoseSerr006");
        private void Serr015MenuItem_Click(object sender, EventArgs e) => LaunchMacro("PoseSerr015");
        private void BarrePenderieMenuItem_Click(object sender, EventArgs e) => LaunchMacro("BarrePenderie");
        private void BpC17ScMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("BpC17Sc");
        private void BpC17C18AcMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("BpC17C18Ac");
        private void BpC13MenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("BpC13");
        private void BpBbMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("BpBb");
        private void BpVevMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("BpVev");
        private void BpcMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("Bpc");
        private void PoseSerrurePistonMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("PoseSerrurePiston");
        private void PaterePx10MenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("PaterePx10");
        private void PaterePx13MenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("PaterePx13");
        private void PatereMurMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("PatereMur");
        private void PM300Px10MenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("PM300Px10");
        private void PM300Px13MenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("PM300Px13");
        private void PM300MurMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("PM300Mur");
        private void P300MurMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("P300Mur");
        private void P300PanneauMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("P300Panneau");
        private void PM400Px10MenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("PM400Px10");
        private void PM400Px13MenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("PM400Px13");
        private void PM400MurMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("PM400Mur");
        private void PM500Px10MenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("PM500Px10");
        private void PM500Px13MenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("PM500Px13");
        private void PM500MurMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("PM500Mur");
        private void PM600Px10MenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("PM600Px10");
        private void PM600Px13MenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("PM600Px13");
        private void PM600MurMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("PM600Mur");
        private void PPmr135Px10MenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("PPmr135Px10");
        private void PPmr135Px13MenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("PPmr135Px13");
        private void PPmr135MurMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("PPmr135Mur");
        private void PrL850Px10MenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("PrL850Px10");
        private void PrL850Px13MenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("PrL850Px13");
        private void PrL850MurMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("PrL850Mur");
        private void SiegePx10MenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("SiegePx10");
        private void SiegePx13MenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("SiegePx13");
        private void SiegeMurMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("SiegeMur");
        private void MiroirPx10MenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("MiroirPx10");
        private void MiroirPx13MenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("MiroirPx13");
        private void MiroirMurMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("MiroirMur");
        private void Miroir600Px10MenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("Miroir600Px10");
        private void Miroir600Px13MenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("Miroir600Px13");
        private void Miroir600MurMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("Miroir600Mur");
        private void Miroir400Px10MenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("Miroir400Px10");
        private void Miroir400Px13MenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("Miroir400Px13");
        private void Miroir400MurMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("Miroir400Mur");
        private void PorteSavonCompactMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("PorteSavonCompact");
        private void PorteSavonPx10MenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("PorteSavonPx10");
        private void PorteSavonPx13MenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("PorteSavonPx13");
        private void PorteSavonMurMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("PorteSavonMur");
        private void DistributeurPQPx10MenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("DistribPQPx10");
        private void DistributeurPQPx13MenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("DistribPQPx13");
        private void DistributeurPQMurMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("DistribPQMur");
        private void MitigeurColCygneMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("MitigeurColCygne");
        private void MitigeurMecaniqueMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("MitigeurMecanique");
        private void MitigeurLavaboMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("MitigeurLavabo");
        private void RobinetLavaboMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("RobinetLavabo");
        private void RobinetDelabieMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("RobinetDelabie");
        private void PoteauBambinoMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("BambinoP");
        private void PcRef221310MenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("BambinoPc");
        private void PlRef221314MenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("BambinoPl");
        private void PoRef221313MenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("BambinoPo");
        private void PrRef221311MenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("BambinoPr");
        private void PtRef221312MenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("BambinoPt");
        private void DispositifAntiMistralMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("DispositifAntiMistral");
        private void GacheC33MurMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("GacheC33Mur");
        private void BancCabinePreMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("BancCabinePre");
        private void BancCabinePostMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("BancCabinePost");
        private void EcranMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("Ecran");
        private void PtSimpleMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("PtSimple");
        private void PtCollectifMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("PtCollectif");
        private void PlanVaisselleMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("PlanVaisselle");
        private void PtLingeMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("PtLinge");
        private void PtBaignoireMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("PtBaignoire");
        private void PtQuartDeCercleMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("PQuartDeCercle");
        private void RaccordPlan600MenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("RaccordPlan600");
        private void FixationMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("FixationPlan");
        private void JouePlanMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("JouePlan");
        private void EcranUrinoirMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("EcranUrinoir");
        private void PanneauDoucheCentrauxMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("PanneauDoucheCentraux");
        private void PanneauDouchePDIMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("PanneauDouchePDI");
        private void HabillageMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("Habillage");
        private void BandeauCacheLuminaireMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("BandeauCacheLuminaire");
        private void RobinetDoucheMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("RobinetDouche");
        private void TrappePoubelleMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("TrappePoubelle");
        private void FondAjusterRefendMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("FondAjusterRefend");
        private void AjoutFondCabineMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("AjoutFondCabine");
        private void AjoutFondAngleMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("AjoutFondAngle");
        private void FondRepererRefendMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("FondRepererRefend");
        private void LogoAccesPriveMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("LogoAccesPrive");
        private void LogoBebeMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("LogoBebe");
        private void LogoDoucheMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("LogoDouche");
        private void LogoEnfantMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("LogoEnfant");
        private void LogoFamilleMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("LogoFamille");
        private void LogoFemmeMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("LogoFemme");
        private void LogoHommeMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("LogoHomme");
        private void LogoLavaboMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("LogoLavabo");
        private void LogoLaverieMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("LogoLaverie");
        private void LogoLocalTechMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("LogoLocalTech");
        private void LogoPmrMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("LogoPmr");
        private void LogoPoubelleMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("LogoPoubelle");
        private void LogoUrinoirMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("LogoUrinoir");
        private void LogoVestiaireMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("LogoVestiaire");
        private void LogoVidoirMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("LogoVidoir");
        private void LogoWCMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("LogoWC");
        private void FacadeBambinoMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("FacadeBambino");
        private void PorteBambinoMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("PorteBambino");
        private void PoserPorteMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("PoserPorte");
        private void AjusterPorteMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("AjusterPorte");
        private void ProfilAuSolMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("ProfilAuSol");
        private void PoserFlasqueMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("PoserFlasque");
        private void PoserPNPCMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("PoserCabinePNPC");
        private void AjusterPNPCMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("AjusterCabinePNPC");
        private void RepererPNPCMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("RepererCabinePNPC");
        private void ComposeLocker_Click(object sender, RoutedEventArgs e) => LaunchMacro("ComposeLocker");
        private void CotationAxeCasMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("CotationAxeCasier");
        private void CotationFacadeCasMenuItem_Click(object sender, RoutedEventArgs e) => LaunchMacro("CotationFacadeCasier");

        private void RagButton_Click(object sender, EventArgs e) => LaunchMacro(Model == "exeleo" ? "PoserRcfig" : "PoserRag");
        private void RadButton_Click(object sender, EventArgs e) => LaunchMacro(Model == "exeleo" ? "PoserRcfid" : "PoserRad");
        private void RbButton_Click(object sender, EventArgs e) => LaunchMacro(Model == "exeleo" ? "PoserRcfi" : "PoserRb");
        private void RcgButton_Click(object sender, EventArgs e) => LaunchMacro(Model == "exeleo" ? "PoserRcfeg" : "PoserRcg");
        private void RcdButton_Click(object sender, EventArgs e) => LaunchMacro(Model == "exeleo" ? "PoserRcfed" : "PoserRcd");
        private void RcButton_Click(object sender, EventArgs e) => LaunchMacro(Model == "exeleo" ? "PoserRcfe" : "PoserRc");


        private void AC12CL900MenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllLines(@"\\serv-kalysse\EDatas\Dev\Datas\Casiers\armoires_config.txt", new List<string> { "resultat:", "12CL900" });
            LaunchMacro("ArmoiresCollectives");
        }

        private void AC16CL1200MenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllLines(@"\\serv-kalysse\EDatas\Dev\Datas\Casiers\armoires_config.txt", new List<string> { "resultat:", "16CL1200" });
            LaunchMacro("ArmoiresCollectives");
        }

        private void AC20CL1500MenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllLines(@"\\serv-kalysse\EDatas\Dev\Datas\Casiers\armoires_config.txt", new List<string> { "resultat:", "20CL1500" });
            LaunchMacro("ArmoiresCollectives");
        }

        private void AC15CL900MenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllLines(@"\\serv-kalysse\EDatas\Dev\Datas\Casiers\armoires_config.txt", new List<string> { "resultat:", "15CL900" });
            LaunchMacro("ArmoiresCollectives");
        }

        private void AC20CL1200MenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllLines(@"\\serv-kalysse\EDatas\Dev\Datas\Casiers\armoires_config.txt", new List<string> { "resultat:", "20CL1200" });
            LaunchMacro("ArmoiresCollectives");
        }

        private void AC25FiveCL1500MenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllLines(@"\\serv-kalysse\EDatas\Dev\Datas\Casiers\armoires_config.txt", new List<string> { "resultat:", "25CL1500" });
            LaunchMacro("ArmoiresCollectives");
        }
    }
}

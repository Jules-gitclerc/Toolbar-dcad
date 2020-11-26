using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Shapes;
using ToolBarDcad.DesignCad;
using ToolBarDcad.Paths;
using ToolBarDcad.Tools;
using Microsoft.VisualBasic;
using System.Drawing;
using Rectangle = System.Drawing.Rectangle;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;
using Application = DesignCAD.Application;

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

        // ============ Constructor =============

        public MainWindow()
        {
            InitializeComponent();

            PreviewKeyDown += HandleEsc;
            Loaded += MainWindow_Loaded;
            Closing += MainWindow_Closing;
            Closed += MainWindow_Closed;
            Activated += MainWindow_Activated;
            Deactivated += MainWindow_Deactivated;

            _palletForm = new Pallet();

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
            ChangeProperties();

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
                Point location = new Point(r.Left + r.Width / 2 + r.Width / 5 - 40, r.Top + 8);

                Dispatcher.BeginInvoke((Action)(() =>
                {
                    Top = location.Y;
                    Left = location.X;
                }));

                Dispatcher.BeginInvoke((Action)(() =>
                {
                    Point palletLocation = new Point((int)(r.Right - _palletForm.Width - 10), (int)(r.Bottom - _palletForm.Height - 50));
                    _palletForm.Top = palletLocation.Y;
                    _palletForm.Left = palletLocation.X;
                }));

                if (_stopRead == false)
                {
                    ReadFile(@"C:\KalysseDesignCAD\model_config.txt");
                    Dispatcher.BeginInvoke((Action)ChangeProperties);
                }
            }
        }

        private void DocWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Debug.WriteLine("DocWorker completed.");
        }

        private void DocWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (ProcessTools.CheckProcWithPid(_appPid))
            {
                Thread.Sleep(500);
                if (App == null) break;
                if (!WindowTools.IsDesignCADActive(App)) continue;
                try
                {
                    Dispatcher.BeginInvoke((Action) (() =>
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
        private void SerieB450MenuItem_Click(object sender, EventArgs e) => LaunchMacro("BancBoisB450");
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
        private void RagButton_Click(object sender, EventArgs e) => LaunchMacro("PoserRag");
        private void RadButton_Click(object sender, EventArgs e) => LaunchMacro("PoserRad");
        private void RbButton_Click(object sender, EventArgs e) => LaunchMacro("PoserRb");
        private void RcgButton_Click(object sender, EventArgs e) => LaunchMacro("PoserRcg");
        private void RcdButton_Click(object sender, EventArgs e) => LaunchMacro("PoserRcd");
        private void RcButton_Click(object sender, EventArgs e) => LaunchMacro("PoserRc");
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
    }
}

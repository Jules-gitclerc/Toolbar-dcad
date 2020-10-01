using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using DesignCAD;
using Microsoft.VisualBasic;
using Application = DesignCAD.Application;
using File = System.IO.File;

namespace DcadToolBar
{
    public partial class ToolBarForm : Form
    {
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();
        private Application App;
        public string Model;
        public string Material;
        private System.Timers.Timer aTimer;
        public Dictionary<string, int> ModelsDict;
        public Dictionary<string, int> MaterialsDict;
        public Dictionary<string, int> BambinoDict;
        public Dictionary<string, string> MacroDict;
        private int _appPid;
        private Thread _thread;
        private Thread _threadClosing;
        private Thread _docChangeThread;
        private bool _isShown;
        private DocumentsManager DocsManager { get; set; }
        private string _pathLocalApp;
        private string _pathServApp;
        private string _fileNameApp;
        private string _dirNameApp;

        public ToolBarForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Load += ToolBarForm_Load;
            Closed += ToolBarForm_Closed;
            FormClosing += ToolBarForm_FormClosing;
            Activated += ToolBarForm_Activated;

            _fileNameApp = ConfigurationManager.AppSettings["FileNameApp"];
            _dirNameApp = ConfigurationManager.AppSettings["DirNameApp"];
            _pathServApp = ConfigurationManager.AppSettings["pathServApp"];
            _pathLocalApp = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + _dirNameApp);

            InitDictionaries();

            ModelComboBox.GotFocus += ModelComboBox_GotFocus;
            ModelComboBox.LostFocus += ModelComboBox_LostFocus;
            MaterialComboBox.GotFocus += MaterialComboBox_GotFocus;
            MaterialComboBox.LostFocus += MaterialComboBox_LostFocus;
            ModelComboBox.SelectedIndexChanged += ModelComboBox_SelectedIndexChanged;
            MaterialComboBox.SelectedIndexChanged += MaterialComboBox_SelectedIndexChanged;
            _thread?.Abort();
            _thread = new Thread(WaitForDesignCAD);
            _threadClosing?.Abort();
            _threadClosing = new Thread(WaitForClosing);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData != Keys.Escape) return base.ProcessCmdKey(ref msg, keyData);
            Close();
            return true;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x80;
                return cp;
            }
        }

        // ============ Events handlers =============

        private void ToolBarForm_Activated(object sender, EventArgs e)
        {
            if (MousePosition.X > macroMenuStrip.PointToScreen(Point.Empty).X && MousePosition.X < macroMenuStrip.PointToScreen(Point.Empty).X + CloakRoomToolStripMenuItem.Size.Width &&
                MousePosition.Y > macroMenuStrip.PointToScreen(Point.Empty).Y && MousePosition.Y < macroMenuStrip.PointToScreen(Point.Empty).Y + CloakRoomToolStripMenuItem.Size.Height)
                CloakRoomToolStripMenuItem.ShowDropDown();
            if (NeedUpdate() == false && updatePictureBox.Visible == false)
                updatePictureBox.Visible = false;
            else if (NeedUpdate() && updatePictureBox.Visible)
                updatePictureBox.Visible = true;
        }

        private void ToolBarForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.TaskManagerClosing) return;
            DialogResult dialog = MessageBox.Show("Voulez vous vraiment quitter ?", "Quitter ?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialog == DialogResult.No)
                e.Cancel = true;
        }

        private void ToolBarForm_Closed(object sender, EventArgs e)
        {
            _thread?.Abort();
            _threadClosing?.Abort();
            _docChangeThread?.Abort();
        }

        private void DocsManager_RaiseDialogBoxEvent(object sender, EventArgs e)
        {
            NewDocForm newDocForm = new NewDocForm();
            newDocForm.ShowDialog(this);
            DocsManager.RefreshDocList(newDocForm.CabinModel, newDocForm.MaterialType);
            DocsManager_RaiseLaunchMacrosEvent(newDocForm, new LaunchMacroEventArgs(MacroTools.ToCabin(newDocForm.CabinModel), 
                MacroTools.ToMaterial(newDocForm.MaterialType)));
            newDocForm.Dispose();
        }

        private void DocsManager_RaiseLaunchMacrosEvent(object sender, LaunchMacroEventArgs e)
        {
            if (e.Model != CabinModel.NullModel)
                LaunchMacro(MacroTools.CabinToString(e.Model));
            if (e.Type != MaterialType.NullMaterial)
                LaunchMacro(MacroTools.MaterialToString(e.Type));
        }

        private void ToolBarForm_Load(object sender, EventArgs e)
        {
            Hide();
            _isShown = false;
            ModelComboBox.SelectedIndexChanged -= ModelComboBox_SelectedIndexChanged;
            MaterialComboBox.SelectedIndexChanged -= MaterialComboBox_SelectedIndexChanged;
            ModelComboBox.SelectedItem = "Primo";
            MaterialComboBox.SelectedItem = "Nylon";
            ModelComboBox.SelectedIndexChanged += ModelComboBox_SelectedIndexChanged;
            MaterialComboBox.SelectedIndexChanged += MaterialComboBox_SelectedIndexChanged;

            FormBorderStyle = FormBorderStyle.None;
            ShowInTaskbar = false;
            ShowIcon = false;
            if (ProcessTools.CheckProcByName("DcadToolBar"))
                ProcessTools.KillAllProcWithName("DcadToolBar");
            SetTimer();
            _thread.Start();
        }

        public void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            ReadFile(@"C:\KalysseDesignCAD\model_config.txt");
            ModelComboBox.SelectedIndexChanged -= ModelComboBox_SelectedIndexChanged;
            MaterialComboBox.SelectedIndexChanged -= MaterialComboBox_SelectedIndexChanged;
            ChangeProperties();
            ModelComboBox.SelectedIndexChanged += ModelComboBox_SelectedIndexChanged;
            MaterialComboBox.SelectedIndexChanged += MaterialComboBox_SelectedIndexChanged;
        }

        // ============ Class methods =============

        private bool IsDesignCADActive()
        {
            IntPtr hWnd = GetForegroundWindow();

            try
            {
                int i = hWnd.ToInt32();
                return i == App.HWnd;
            }
            catch (OverflowException e)
            {
                Debug.WriteLine(e);
                long l = hWnd.ToInt64();
                return l == App.HWnd;
            }
            catch
            {
                //unused
            }

            return false;
        }

        /// <summary>
        /// This function should be used only with a new thread.
        /// Thread which will look for a DesignCad instance constantly if not opened.
        /// </summary>

        private void WaitForDesignCAD()
        {
            bool isFound = false;

            while (App == null)
            {
                Thread.Sleep(1000);
                if (!ProcessTools.CheckProcByName("DcP10")) continue;
                try
                {
                    App = (Application) Interaction.GetObject(null, "DesignCAD.Application.26"); // Gets app instance
                    App.BringToTop();
                    while (isFound == false)
                    {
                        if (App.ActiveDocument == null) continue;
                        isFound = true;
                        DocsManager = new DocumentsManager(App);
                        DocsManager.RaiseDialogBoxEvent += DocsManager_RaiseDialogBoxEvent;
                        DocsManager.RaiseLaunchMacrosEvent += DocsManager_RaiseLaunchMacrosEvent;
                        DocsManager.SetActiveDoc();
                        DocTitle.Text = DocsManager.ActiveDoc.Name;
                        _appPid = App.ProcessId;
                        ToggleControls();
                        aTimer.Enabled = true;
                        aTimer.Start();
                        _threadClosing?.Abort();
                        _threadClosing = new Thread(WaitForClosing);
                        _threadClosing.Start();
                        _docChangeThread?.Abort();
                        _docChangeThread = new Thread(ActiveDocChangesWatcher);
                        _docChangeThread.Start();
                        Show();
                        _isShown = true;
                    }
                }
                catch
                {
                    //unused
                }
            }
        }

        /// <summary>
        /// This function should be used only with a new thread.
        /// Thread which will look if designCAD is opened. And if not, call the other thread.
        /// </summary>

        private void WaitForClosing()
        {
            while (ProcessTools.CheckProcWithPid(_appPid))                 // TODO Add something which detects if window is minimized or not
            {
                Thread.Sleep(500);
                if (IsDesignCADActive() || ActiveForm == this)
                {
                    if (_isShown == false)
                        Show();
                    _isShown = true;
                }

                else if (IsDesignCADActive() == false)
                {
                    if (_isShown)
                        Hide();
                    _isShown = false;
                }
            }
            Hide();
            _isShown = false;
            DocsManager = null;
            App = null;
            ToggleControls();
            _thread?.Abort();
            _thread = new Thread(WaitForDesignCAD);
            _thread.Start();
        }

        private void ActiveDocChangesWatcher()
        {
            while (ProcessTools.CheckProcWithPid(_appPid))
            {
                Thread.Sleep(500);
                if (!IsDesignCADActive()) continue;
                if (App.ActiveDocument == null)
                {
                    DocTitle.Text = "no document";
                }
                if (App.ActiveDocument != DocsManager.ActiveDoc)
                {
                    DocsManager.SetActiveDoc();
                }
            }
        }

        private bool NeedUpdate()
        {
            if (!File.Exists(Path.Combine(_pathLocalApp, _fileNameApp)))
                return true;
            if (!File.Exists(Path.Combine(_pathServApp, _fileNameApp)))
                return false;
            var VersionServ = FileVersionInfo.GetVersionInfo(Path.Combine(_pathServApp, _fileNameApp));
            var VersionLocal = FileVersionInfo.GetVersionInfo(Path.Combine(_pathLocalApp, _fileNameApp));

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
        /// Disable / Enable all controls in the menu
        /// </summary>

        private void ToggleControls()
        {
            try
            {
                foreach (var control in Controls)
                {
                    if (control.GetType() != typeof(ComboBox)) continue;
                    var comboBox = (ComboBox) control;
                    comboBox.Enabled = !comboBox.Enabled;
                }
            }
            catch
            {
                //unused
            }
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

            BambinoDict = new Dictionary<string, int>()
            {
                {"poteau bambino", 0},
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
                string[] lines = System.IO.File.ReadAllLines(path);

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
                Debug.WriteLine(e);
            }
        }

        private void ChangeProperties()
        {
            try
            {
                ModelComboBox.SelectedIndex = ModelsDict[Model];
                MaterialComboBox.SelectedIndex = MaterialsDict[Material];
            }
            catch
            {
                //unused
            }
        }

        private void SetTimer()
        {
            aTimer = new System.Timers.Timer(200);

            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
        }

        private void LaunchMacro(string macroName)
        {
            int result = DocsManager.RunMacroOnActiveDoc(MacroDict[macroName], macroName);

            switch (result)
            {
                case 1:
                    DocTitle.Text = DocsManager.ActiveDoc.Name;
                    break;
                case 2:
                    DocTitle.Text = "no document";
                    MessageBox.Show("Pas de document actif.", "Toolbar info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;
                case 3:
                    MessageBox.Show("Macro non trouvée.", "Toolbar info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;
            }
        }

        // ============ Controls event handlers =============

        private void ModelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine(ModelComboBox.SelectedItem.ToString());
            LaunchMacro(ModelComboBox.SelectedItem.ToString());
        }

        private void MaterialComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LaunchMacro(MaterialComboBox.SelectedItem.ToString());
        }

        private void MaterialComboBox_LostFocus(object sender, EventArgs e)
        {
            aTimer.Start();
        }

        private void MaterialComboBox_GotFocus(object sender, EventArgs e)
        {
            aTimer.Stop();
        }

        private void ModelComboBox_LostFocus(object sender, EventArgs e)
        {
            aTimer.Start();
        }

        private void ModelComboBox_GotFocus(object sender, EventArgs e)
        {
            aTimer.Stop();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                Arguments = "/C " + @"\\serv-kalysse\EDatas\Logiciels\ToolBarUpdater\ToolBarUpdater.exe",
                FileName = "cmd",
                WindowStyle = ProcessWindowStyle.Hidden
            });
        }

        private void CasiersBancsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaunchMacro("CasierHBanc");
        }

        private void CasierhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaunchMacro("CasierHDiplo");
        }

        private void CasierZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaunchMacro("CasierZDiplo");
        }

        private void CasiersBancCompactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaunchMacro("CasiersBancCompact");
        }

        private void SérieC50ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaunchMacro("BancCompact50");
        }

        private void sérieC1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaunchMacro("BancCompact1");
        }
    }
}

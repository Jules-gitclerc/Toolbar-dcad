using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace ToolBarUpdater
{
    public partial class CheckUpdateForm : Form
    {
        private string _pathLocalApp;
        private string _pathServApp;
        private string _fileNameApp;
        private string _dirNameApp;

        public CheckUpdateForm()
        {
            InitializeComponent();
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

        private bool UpdateApp()
        {
            if (!File.Exists(Path.Combine(_pathLocalApp, _fileNameApp)))
                label1.Text = "Installation de l'application...";
            else
                label1.Text = "Mise à jour de l'application...";
            Application.DoEvents();
            foreach (string dirPath in Directory.GetDirectories(_pathServApp, "*",
                SearchOption.AllDirectories))
            {
                try
                {
                    Directory.CreateDirectory(dirPath.Replace(_pathServApp, _pathLocalApp));
                }
                catch
                {
                    return false;
                }
            }

            int nb_files = Directory.GetFiles(_pathServApp, "*.*", SearchOption.AllDirectories).Length;
            progressBar1.Maximum = nb_files;
            foreach (string newPath in Directory.GetFiles(_pathServApp, "*.*",
                SearchOption.AllDirectories))
            {
                try
                {
                    File.Copy(newPath, newPath.Replace(_pathServApp, _pathLocalApp), true);
                }
                catch
                {
                    return false;
                }
                progressBar1.Value++;
            }
            return true;
        }

        private int GetAppId()
        {
            var allProcesses = Process.GetProcesses();

            if (allProcesses.Any(process => process.ProcessName == "DcadToolBar"))
                return allProcesses.FirstOrDefault(process => process.ProcessName == "DcadToolBar").Id;
            return -1;
        }

        private void CheckUpdateForm_Load(object sender, EventArgs e)
        {
            _fileNameApp = ConfigurationManager.AppSettings["FileNameApp"];
            _dirNameApp = ConfigurationManager.AppSettings["DirNameApp"];
            _pathServApp = ConfigurationManager.AppSettings["pathServApp"];
            _pathLocalApp = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + _dirNameApp);
            WindowState = FormWindowState.Minimized;

            if (!Directory.Exists(_pathLocalApp))
            {
                if (!Directory.Exists(_pathServApp) || !File.Exists(Path.Combine(_pathServApp, _fileNameApp)))
                {
                    MessageBox.Show(
                        "Impossible de trouver l'application DcadToolBar, contactez un Administrateur.");
                    Close();
                    return;
                }

                try
                {
                    Directory.CreateDirectory(_pathLocalApp);
                    if (!Directory.Exists(_pathLocalApp))
                    {
                        MessageBox.Show("Impossible d'installer DcadToolBar, contactez un Administrateur.");
                        Close();
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Impossible d'installer DcadToolBar, contactez un Administrateur.");
                    Close();
                    return;
                }
            }
            if (NeedUpdate())
            {
                WindowState = FormWindowState.Normal;
                Application.DoEvents();
                int id = GetAppId();

                if (id != -1)
                {
                    Process p = Process.GetProcessById(id);

                    p.Kill();
                    Thread.Sleep(4000);
                }
                if (UpdateApp() == false)
                {
                    WindowState = FormWindowState.Minimized;
                    MessageBox.Show("Erreur lors de la mise à jour, vérifiez que l'application n'est pas déjà ouverte, sinon contactez un Administrateur.");
                    Close();
                    return;
                }
                label1.Text = "Démarrage de l'application...";
                Process proc = Process.Start(new ProcessStartInfo
                {
                    Arguments = "/C " + Path.Combine(_pathLocalApp, _fileNameApp),
                    FileName = "cmd",
                    WindowStyle = ProcessWindowStyle.Hidden
                });
                Thread.Sleep(3000);
                Close();
            }
            else
            {
                WindowState = FormWindowState.Normal;
                MessageBox.Show("Aucune mise à jour necessaire.");
                Close();
            }
        }
    }
}

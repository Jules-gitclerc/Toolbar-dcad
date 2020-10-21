using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using DesignCAD;
using Application = DesignCAD.Application;

namespace DcadToolBar
{
    public partial class Palet : Form
    {
        public DocumentsManager DocManager { get; set; }
        private ToolTip _infoLayerTip;
        private System.Timers.Timer _aTimer;

        public Palet()
        {
            InitializeComponent();
            _infoLayerTip = new ToolTip();
            SetTimer();
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

        private void LaunchMacro(string macroPath)
        {
            int result = DocManager.RunMacroOnActiveDoc(macroPath, "PalletMacro");

            switch (result)
            {
                case 1:
                    break;
                case 2:
                    MessageBox.Show("Pas de document actif.", "Toolbar info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;
                case 3:
                    MessageBox.Show("Macro non trouvée.", "Toolbar info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;
            }
        }

        private void SetTimer()
        {
            _aTimer = new System.Timers.Timer(1500);

            _aTimer.Elapsed += OnTimedEvent;
            _aTimer.AutoReset = true;
        }

        public void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            colorRed.MouseEnter += ColorRed_MouseEnter;
            ColorMaroon.MouseEnter += ColorMaroon_MouseEnter;
            ColorBlue.MouseEnter += ColorBlue_MouseEnter;
            ColorLightBlue.MouseEnter += ColorLightBlue_MouseEnter;
            ColorGreen.MouseEnter += ColorGreen_MouseEnter;
            ColorBlack.MouseEnter += ColorBlack_MouseEnter;
            _aTimer.Stop();
        }

        private void LaunchTimer()
        {
            colorRed.MouseEnter -= ColorRed_MouseEnter;
            ColorMaroon.MouseEnter -= ColorMaroon_MouseEnter;
            ColorBlue.MouseEnter -= ColorBlue_MouseEnter;
            ColorLightBlue.MouseEnter -= ColorLightBlue_MouseEnter;
            ColorGreen.MouseEnter -= ColorGreen_MouseEnter;
            ColorBlack.MouseEnter -= ColorBlack_MouseEnter;
            _aTimer.Start();
        }

        private void Palet_Load(object sender, EventArgs e)
        {
            Size = new Size(22, 163);
            ColorMaroon.BackColor = Color.FromArgb(170, 0, 0);
            ColorLightBlue.BackColor = Color.FromArgb(170, 170, 255);
        }

        private void ColorRed_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllLines(@"C:\KalysseDesignCAD\palet_config.txt", new List<string>
            {
                "resultats :",
                "255",
                "0",
                "0",
                "12"
            });
            LaunchMacro(@"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Menu et boite a outils\palet.d3m");
            LaunchTimer();
        }

        private void ColorMaroon_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllLines(@"C:\KalysseDesignCAD\palet_config.txt", new List<string>
            {
                "resultats :",
                "255",
                "0",
                "0",
                "13"
            });
            LaunchMacro(@"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Menu et boite a outils\palet.d3m");
            LaunchTimer();
        }

        private void ColorBlue_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllLines(@"C:\KalysseDesignCAD\palet_config.txt", new List<string>
            {
                "resultats :",
                "0",
                "0",
                "255",
                "10"
            });
            LaunchMacro(@"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Menu et boite a outils\palet.d3m");
            LaunchTimer();
        }

        private void ColorLightBlue_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllLines(@"C:\KalysseDesignCAD\palet_config.txt", new List<string>
            {
                "resultats :",
                "0",
                "0",
                "255",
                "11"
            });
            LaunchMacro(@"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Menu et boite a outils\palet.d3m");
            LaunchTimer();
        }

        private void ColorGreen_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllLines(@"C:\KalysseDesignCAD\palet_config.txt", new List<string>
            {
                "resultats :",
                "0",
                "255",
                "0",
                "14"
            });
            LaunchMacro(@"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Menu et boite a outils\palet.d3m");
            LaunchTimer();
        }

        private void ColorBlack_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllLines(@"C:\KalysseDesignCAD\palet_config.txt", new List<string>
            {
                "resultats :",
                "0",
                "0",
                "0",
                "1"
            });
            LaunchMacro(@"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Menu et boite a outils\palet.d3m");
            LaunchTimer();
        }

        private void ColorRed_MouseEnter(object sender, EventArgs e)
        {
            Activate();
            _infoLayerTip.Show("12", this, new Point(colorRed.Location.X - colorRed.Size.Width, colorRed.Location.Y - colorRed.Size.Height));
        }

        private void ColorRed_MouseLeave(object sender, EventArgs e) => _infoLayerTip.Hide(this);
        

        private void ColorMaroon_MouseEnter(object sender, EventArgs e)
        {
            Activate();
            _infoLayerTip.Show("13", this, new Point(ColorMaroon.Location.X - ColorMaroon.Size.Width, ColorMaroon.Location.Y - ColorMaroon.Size.Height));
        }

        private void ColorMaroon_MouseLeave(object sender, EventArgs e) => _infoLayerTip.Hide(this);

        private void ColorBlue_MouseEnter(object sender, EventArgs e)
        {
            Activate();
            _infoLayerTip.Show("10", this, new Point(ColorBlue.Location.X - ColorBlue.Size.Width, ColorBlue.Location.Y - ColorBlue.Size.Height));
        }

        private void ColorBlue_MouseLeave(object sender, EventArgs e) => _infoLayerTip.Hide(this);

        private void ColorLightBlue_MouseEnter(object sender, EventArgs e)
        {
            Activate();
            _infoLayerTip.Show("11", this, new Point(ColorLightBlue.Location.X - ColorLightBlue.Size.Width, ColorLightBlue.Location.Y - ColorLightBlue.Size.Height));
        }

        private void ColorLightBlue_MouseLeave(object sender, EventArgs e) => _infoLayerTip.Hide(this);

        private void ColorGreen_MouseEnter(object sender, EventArgs e)
        {
            Activate();
            _infoLayerTip.Show("14", this, new Point(ColorGreen.Location.X - ColorGreen.Size.Width, ColorGreen.Location.Y - ColorGreen.Size.Height));
        }

        private void ColorGreen_MouseLeave(object sender, EventArgs e) => _infoLayerTip.Hide(this);

        private void ColorBlack_MouseEnter(object sender, EventArgs e)
        {
            Activate();
            _infoLayerTip.Show("1", this, new Point(ColorBlack.Location.X - ColorBlack.Size.Width, ColorBlack.Location.Y - ColorBlack.Size.Height));
        }

        private void ColorBlack_MouseLeave(object sender, EventArgs e) => _infoLayerTip.Hide(this);

        private void PalletButton_Click(object sender, EventArgs e)
        {
            ChooseColor chooseForm = new ChooseColor();

            DialogResult dr = chooseForm.ShowDialog();

            if (dr == DialogResult.Cancel) return;
            if (dr != DialogResult.OK) return;
            System.IO.File.WriteAllLines(@"C:\KalysseDesignCAD\palet_config.txt", new List<string>
            {
                "resultats :",
                chooseForm.ValueR.ToString(),
                chooseForm.ValueG.ToString(),
                chooseForm.ValueB.ToString(),
                chooseForm.LayerVal.ToString()
            });
            LaunchMacro(@"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Menu et boite a outils\palet.d3m");
            LaunchTimer();
        }
    }
}

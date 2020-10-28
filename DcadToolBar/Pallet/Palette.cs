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
        private int _currentThickness;
        private readonly Color _greenColor;
        private readonly Color _redColor;
        private readonly Color _enabledColor;
        private readonly Color _disabledColor;

        public int CurrentThickness
        {
            get
            {
                return _currentThickness;
            }
            set
            {
                _currentThickness = value;
                if (value == 10)
                {
                    Ep10Button.Enabled = false;
                    Ep10Button.FlatAppearance.BorderColor = _greenColor;
                    Ep10Button.BackColor = _disabledColor;
                    Ep10Button.FlatAppearance.BorderSize = 3;
                    Ep13Button.Enabled = true;
                    Ep13Button.FlatAppearance.BorderColor = _redColor;
                    Ep13Button.BackColor = _enabledColor;
                    Ep13Button.FlatAppearance.BorderSize = 1;
                    colorRed.Visible = true;
                    ColorBlue.Visible = true;
                    ColorBlueHole.Visible = true;
                    ColorPeach.Visible = true;
                    ColorMaroon.Visible = false;
                    ColorLightBlue.Visible = false;
                    ColorGray.Visible = false;
                    ColorLightGray.Visible = false;
                }

                if (value == 13)
                {
                    Ep10Button.Enabled = true;
                    Ep10Button.FlatAppearance.BorderColor = _redColor;
                    Ep10Button.BackColor = _enabledColor;
                    Ep10Button.FlatAppearance.BorderSize = 1;
                    Ep13Button.Enabled = false;
                    Ep13Button.FlatAppearance.BorderColor = _greenColor;
                    Ep13Button.BackColor = _disabledColor;
                    Ep13Button.FlatAppearance.BorderSize = 3;
                    colorRed.Visible = false;
                    ColorBlue.Visible = false;
                    ColorBlueHole.Visible = false;
                    ColorPeach.Visible = false;
                    ColorMaroon.Visible = true;
                    ColorLightBlue.Visible = true;
                    ColorGray.Visible = true;
                    ColorLightGray.Visible = true;
                }
            }
        }

        // ============ Constructor =============

        public Palet()
        {
            InitializeComponent();
            _greenColor = Ep10Button.FlatAppearance.BorderColor;
            _redColor = Ep13Button.FlatAppearance.BorderColor;
            _enabledColor = Ep13Button.BackColor;
            _disabledColor = Ep10Button.BackColor;
            _infoLayerTip = new ToolTip();
            CurrentThickness = 10;
            SetTimer();
        }

        // ============ Class methods =============

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
            ColorBlueHole.MouseEnter += ColorBlueHole_MouseEnter;
            ColorPeach.MouseEnter += ColorPeach_MouseEnter;
            ColorGray.MouseEnter += ColorGray_MouseEnter;
            ColorLightGray.MouseEnter += ColorLightGray_MouseEnter;
            Lay15Green.MouseEnter += Lay15Green_MouseEnter;
            Lay16Green.MouseEnter += Lay16Green_MouseEnter;
            Lay17Purple.MouseEnter += Lay17Purple_MouseEnter;
            Lay18Purple.MouseEnter += Lay18Purple_MouseEnter;
            Lay19Green.MouseEnter += Lay19Green_MouseEnter;
            Lay20Green.MouseEnter += Lay20Green_MouseEnter;
            Lay21Green.MouseEnter += Lay21Green_MouseEnter;
            Lay22Tomato.MouseEnter += Lay22Tomato_MouseEnter;
            Ep10Button.MouseEnter += Ep10Button_MouseEnter;
            Ep13Button.MouseEnter += Ep13Button_MouseEnter;
            palletButton.MouseEnter += PalletButton_MouseEnter;
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
            ColorBlueHole.MouseEnter -= ColorBlueHole_MouseEnter;
            ColorPeach.MouseEnter -= ColorPeach_MouseEnter;
            ColorGray.MouseEnter -= ColorGray_MouseEnter;
            ColorLightGray.MouseEnter -= ColorLightGray_MouseEnter;
            Lay15Green.MouseEnter -= Lay15Green_MouseEnter;
            Lay16Green.MouseEnter -= Lay16Green_MouseEnter;
            Lay17Purple.MouseEnter -= Lay17Purple_MouseEnter;
            Lay18Purple.MouseEnter -= Lay18Purple_MouseEnter;
            Lay19Green.MouseEnter -= Lay19Green_MouseEnter;
            Lay20Green.MouseEnter -= Lay20Green_MouseEnter;
            Lay21Green.MouseEnter -= Lay21Green_MouseEnter;
            Lay22Tomato.MouseEnter -= Lay22Tomato_MouseEnter;
            Ep10Button.MouseEnter -= Ep10Button_MouseEnter;
            Ep13Button.MouseEnter -= Ep13Button_MouseEnter;
            palletButton.MouseEnter -= PalletButton_MouseEnter;
            _aTimer.Start();
        }

        private void ChangeColorAndLayer(int rVal, int gVal, int bVal, int layer)
        {
            System.IO.File.WriteAllLines(@"C:\KalysseDesignCAD\palet_config.txt", new List<string>
            {
                "resultats :",
                rVal.ToString(),
                gVal.ToString(),
                bVal.ToString(),
                layer.ToString()
            });
            LaunchMacro(@"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Menu et boite a outils\palet.d3m");
            LaunchTimer();
        }

        // ============ Events handlers =============

        private void Palet_Load(object sender, EventArgs e)
        {
            Size = new Size(22, 438);
            ColorMaroon.BackColor = Color.FromArgb(170, 0, 0);
            ColorLightBlue.BackColor = Color.FromArgb(170, 170, 255);
            ColorPeach.BackColor = Color.FromArgb(255, 197, 138);
            ColorGray.BackColor = Color.FromArgb(99, 132, 154);
            ColorLightGray.BackColor = Color.FromArgb(159, 180, 193);
        }

        private void ColorRed_Click(object sender, EventArgs e) => ChangeColorAndLayer(255, 0, 0, 12);
        

        private void ColorMaroon_Click(object sender, EventArgs e) => ChangeColorAndLayer(255, 0, 0, 13);
        

        private void ColorBlue_Click(object sender, EventArgs e) => ChangeColorAndLayer(0, 0, 255, 10);
        

        private void ColorLightBlue_Click(object sender, EventArgs e) => ChangeColorAndLayer(0, 0, 255, 11);
        

        private void ColorGreen_Click(object sender, EventArgs e) => ChangeColorAndLayer(0, 255, 0, 14);
        

        private void ColorBlack_Click(object sender, EventArgs e) => ChangeColorAndLayer(0, 0, 0, 1);
        

        private void ColorBlueHole_Click(object sender, EventArgs e) => ChangeColorAndLayer(0, 0, 255, 24);
        

        private void ColorPeach_Click(object sender, EventArgs e) => ChangeColorAndLayer(0, 0, 255, 25);
        

        private void ColorGray_Click(object sender, EventArgs e) => ChangeColorAndLayer(0, 0, 255, 26);
        

        private void ColorLightGray_Click(object sender, EventArgs e) => ChangeColorAndLayer(0, 0, 255, 27);

        private void Lay15Green_Click(object sender, EventArgs e) => ChangeColorAndLayer(0, 255, 0, 15);

        private void Lay16Green_Click(object sender, EventArgs e) => ChangeColorAndLayer(0, 255, 0, 16);

        private void Lay17Purple_Click(object sender, EventArgs e) => ChangeColorAndLayer(170, 0, 170, 17);

        private void Lay18Purple_Click(object sender, EventArgs e) => ChangeColorAndLayer(255, 43, 255, 18);

        private void Lay19Green_Click(object sender, EventArgs e) => ChangeColorAndLayer(0, 255, 0, 19);

        private void Lay20Green_Click(object sender, EventArgs e) => ChangeColorAndLayer(0, 255, 0, 20);

        private void Lay21Green_Click(object sender, EventArgs e) => ChangeColorAndLayer(0, 255, 0, 21);

        private void Lay22Tomato_Click(object sender, EventArgs e) => ChangeColorAndLayer(255, 100, 100, 22);

        private void ColorButton_MouseLeave(object sender, EventArgs e) => _infoLayerTip.Hide(this);

        private void ColorRed_MouseEnter(object sender, EventArgs e)
        {
            Activate();
            _infoLayerTip.Show("12", this, new Point(colorRed.Location.X - colorRed.Size.Width, colorRed.Location.Y - colorRed.Size.Height));
        }

        private void ColorMaroon_MouseEnter(object sender, EventArgs e)
        {
            Activate();
            _infoLayerTip.Show("13", this, new Point(ColorMaroon.Location.X - ColorMaroon.Size.Width, ColorMaroon.Location.Y - ColorMaroon.Size.Height));
        }

        private void ColorBlue_MouseEnter(object sender, EventArgs e)
        {
            Activate();
            _infoLayerTip.Show("10", this, new Point(ColorBlue.Location.X - ColorBlue.Size.Width, ColorBlue.Location.Y - ColorBlue.Size.Height));
        }

        private void ColorLightBlue_MouseEnter(object sender, EventArgs e)
        {
            Activate();
            _infoLayerTip.Show("11", this, new Point(ColorLightBlue.Location.X - ColorLightBlue.Size.Width, ColorLightBlue.Location.Y - ColorLightBlue.Size.Height));
        }

        private void ColorGreen_MouseEnter(object sender, EventArgs e)
        {
            Activate();
            _infoLayerTip.Show("14", this, new Point(ColorGreen.Location.X - ColorGreen.Size.Width, ColorGreen.Location.Y - ColorGreen.Size.Height));
        }

        private void ColorBlack_MouseEnter(object sender, EventArgs e)
        {
            Activate();
            _infoLayerTip.Show("1", this, new Point(ColorBlack.Location.X - ColorBlack.Size.Width, ColorBlack.Location.Y - ColorBlack.Size.Height));
        }

        private void Ep10Button_MouseEnter(object sender, EventArgs e)
        {
            Activate();
            _infoLayerTip.Show("Ep. 10mm", this, new Point(Ep10Button.Location.X - Ep10Button.Size.Width, Ep10Button.Location.Y - Ep10Button.Size.Height));
        }

        private void Ep13Button_MouseEnter(object sender, EventArgs e)
        {
            Activate();
            _infoLayerTip.Show("Ep. 13mm", this, new Point(Ep13Button.Location.X - Ep13Button.Size.Width, Ep13Button.Location.Y - Ep13Button.Size.Height));
        }

        private void ColorBlueHole_MouseEnter(object sender, EventArgs e)
        {
            Activate();
            _infoLayerTip.Show("24", this, new Point(ColorBlueHole.Location.X - ColorBlueHole.Size.Width, ColorBlueHole.Location.Y - ColorBlueHole.Size.Height));
        }

        private void ColorPeach_MouseEnter(object sender, EventArgs e)
        {
            Activate();
            _infoLayerTip.Show("25", this, new Point(ColorPeach.Location.X - ColorPeach.Size.Width, ColorPeach.Location.Y - ColorPeach.Size.Height));
        }

        private void ColorGray_MouseEnter(object sender, EventArgs e)
        {
            Activate();
            _infoLayerTip.Show("26", this, new Point(ColorGray.Location.X - ColorGray.Size.Width, ColorGray.Location.Y - ColorGray.Size.Height));
        }

        private void ColorLightGray_MouseEnter(object sender, EventArgs e)
        {
            Activate();
            _infoLayerTip.Show("27", this, new Point(ColorLightGray.Location.X - ColorLightGray.Size.Width, ColorLightGray.Location.Y - ColorLightGray.Size.Height));
        }

        private void Lay15Green_MouseEnter(object sender, EventArgs e)
        {
            Activate();
            _infoLayerTip.Show("15", this, new Point(Lay15Green.Location.X - Lay15Green.Size.Width, Lay15Green.Location.Y - Lay15Green.Size.Height));
        }

        private void Lay16Green_MouseEnter(object sender, EventArgs e)
        {
            Activate();
            _infoLayerTip.Show("16", this, new Point(Lay16Green.Location.X - Lay16Green.Size.Width, Lay16Green.Location.Y - Lay16Green.Size.Height));
        }

        private void Lay17Purple_MouseEnter(object sender, EventArgs e)
        {
            Activate();
            _infoLayerTip.Show("17", this, new Point(Lay17Purple.Location.X - Lay17Purple.Size.Width, Lay17Purple.Location.Y - Lay17Purple.Size.Height));
        }

        private void Lay18Purple_MouseEnter(object sender, EventArgs e)
        {
            Activate();
            _infoLayerTip.Show("18", this, new Point(Lay18Purple.Location.X - Lay18Purple.Size.Width, Lay18Purple.Location.Y - Lay18Purple.Size.Height));
        }

        private void Lay19Green_MouseEnter(object sender, EventArgs e)
        {
            Activate();
            _infoLayerTip.Show("19", this, new Point(Lay19Green.Location.X - Lay19Green.Size.Width, Lay19Green.Location.Y - Lay19Green.Size.Height));
        }

        private void Lay20Green_MouseEnter(object sender, EventArgs e)
        {
            Activate();
            _infoLayerTip.Show("20", this, new Point(Lay20Green.Location.X - Lay20Green.Size.Width, Lay20Green.Location.Y - Lay20Green.Size.Height));
        }

        private void Lay21Green_MouseEnter(object sender, EventArgs e)
        {
            Activate();
            _infoLayerTip.Show("21", this, new Point(Lay21Green.Location.X - Lay21Green.Size.Width, Lay21Green.Location.Y - Lay21Green.Size.Height));
        }

        private void Lay22Tomato_MouseEnter(object sender, EventArgs e)
        {
            Activate();
            _infoLayerTip.Show("22", this, new Point(Lay22Tomato.Location.X - Lay22Tomato.Size.Width, Lay22Tomato.Location.Y - Lay22Tomato.Size.Height));
        }

        private void PalletButton_Click(object sender, EventArgs e)
        {
            ChooseColor chooseForm = new ChooseColor();

            DialogResult dr = chooseForm.ShowDialog();

            if (dr == DialogResult.Cancel) return;
            if (dr != DialogResult.OK) return;
            ChangeColorAndLayer(chooseForm.ValueR, chooseForm.ValueG, chooseForm.ValueB, chooseForm.LayerVal);
        }

        private void Ep10Button_Click(object sender, EventArgs e)
        {
            CurrentThickness = 10;
        }

        private void Ep13Button_Click(object sender, EventArgs e)
        {
            CurrentThickness = 13;
        }

        private void PalletButton_MouseEnter(object sender, EventArgs e)
        {
            Activate();
            _infoLayerTip.Show("Couleur personnalisée", this, new Point(palletButton.Location.X - palletButton.Size.Width, palletButton.Location.Y - palletButton.Size.Height));
        }
    }
}

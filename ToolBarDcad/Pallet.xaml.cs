using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ToolBarDcad.DesignCad;
using ToolBarDcad.Tools;

namespace ToolBarDcad
{
    /// <summary>
    /// Logique d'interaction pour Pallet.xaml
    /// </summary>
    public partial class Pallet : Window
    {
        public DocumentsManager DocManager { get; set; }
        private int _currentThickness;
        private readonly Brush _enabledColor;
        private readonly Brush _disabledColor;

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
                    Ep10Button.IsEnabled = false;
                    Ep10Button.Background = _disabledColor;
                    Ep13Button.IsEnabled = true;
                    Ep13Button.Background = _enabledColor;
                    ColorRed.Visibility = Visibility.Visible;
                    ColorBlue.Visibility = Visibility.Visible;
                    ColorBlueHole.Visibility = Visibility.Visible;
                    ColorPeach.Visibility = Visibility.Visible;
                    ColorMaroon.Visibility = Visibility.Hidden;
                    ColorLightBlue.Visibility = Visibility.Hidden;
                    ColorGray.Visibility = Visibility.Hidden;
                    ColorLightGray.Visibility = Visibility.Hidden;
                }

                if (value == 13)
                {
                    Ep10Button.IsEnabled = true;
                    Ep10Button.Background = _enabledColor;
                    Ep13Button.IsEnabled = false;
                    Ep13Button.Background = _disabledColor;
                    ColorRed.Visibility = Visibility.Hidden;
                    ColorBlue.Visibility = Visibility.Hidden;
                    ColorBlueHole.Visibility = Visibility.Hidden;
                    ColorPeach.Visibility = Visibility.Hidden;
                    ColorMaroon.Visibility = Visibility.Visible;
                    ColorLightBlue.Visibility = Visibility.Visible;
                    ColorGray.Visibility = Visibility.Visible;
                    ColorLightGray.Visibility = Visibility.Visible;
                }
            }
        }

        // ============ Constructor =============

        public Pallet()
        {
            InitializeComponent();

            PreviewKeyDown += HandleEsc;
            Loaded += Pallet_Loaded;

            _enabledColor = Ep13Button.Background;
            _disabledColor = Ep10Button.Background;
            CurrentThickness = 10;
        }

        // ============ Class methods =============

        private void LaunchMacro(string macroPath)
        {
            int result = DocManager.RunMacroOnActiveDoc(macroPath, "PalletMacro");

            switch (result)
            {
                case 1:
                    break;
                case 2:
                    MessageBox.Show("Pas de document actif.", "Toolbar info", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                    break;
                case 3:
                    MessageBox.Show("Macro non trouvée.", "Toolbar info", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                    break;
            }
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
        }

        //// ============ Events handlers =============

        private void Pallet_Loaded(object sender, RoutedEventArgs e)
        {
            WindowTools.HideFromProgramSwitcher(this);
            Ep10Button.Click += Ep10Button_Click;
            Ep13Button.Click += Ep13Button_Click;
            ColorRed.Click += ColorRed_Click;
            ColorBlue.Click += ColorBlue_Click;
            ColorBlueHole.Click += ColorBlueHole_Click;
            ColorPeach.Click += ColorPeach_Click;
            ColorLightBlue.Click += ColorLightBlue_Click;
            ColorMaroon.Click += ColorMaroon_Click;
            ColorGray.Click += ColorGray_Click;
            ColorLightGray.Click += ColorLightGray_Click;
            ColorBlack.Click += ColorBlack_Click;
            ColorGreen.Click += ColorGreen_Click;
            Lay15Green.Click += Lay15Green_Click;
            Lay16Green.Click += Lay16Green_Click;
            Lay17Purple.Click += Lay17Purple_Click;
            Lay18Purple.Click += Lay18Purple_Click;
            Lay19Green.Click += Lay19Green_Click;
            Lay20Green.Click += Lay20Green_Click;
            Lay21Green.Click += Lay21Green_Click;
            Lay22Tomato.Click += Lay22Tomato_Click;
            PalletButton.Click += PalletButton_Click;
        }

        public void HandleEsc(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Escape) return;
            Close();
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

        private void PalletButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bouton en cours de construction...");
        }

        private void Ep10Button_Click(object sender, EventArgs e)
        {
            CurrentThickness = 10;
        }

        private void Ep13Button_Click(object sender, EventArgs e)
        {
            CurrentThickness = 13;
        }
    }
}

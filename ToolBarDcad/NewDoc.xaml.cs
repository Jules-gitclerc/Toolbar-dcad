using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ToolBarDcad
{
    /// <summary>
    /// Logique d'interaction pour NewDoc.xaml
    /// </summary>
    public partial class NewDoc : Window
    {
        public string CabinModel { get; set; }
        public string MaterialType { get; set; }

        public NewDoc()
        {
            InitializeComponent();

            PreviewKeyDown += HandleEsc;
            Loaded += NewDoc_Loaded;
            CabinCombo.SelectionChanged += CabinCombo_SelectionChanged;
            MaterialCombo.SelectionChanged += MaterialCombo_SelectionChanged;
            OkButton.Click += OkButton_Click;

            CabinModel = "Primo";
            MaterialType = "Nylon";
        }

        public void HandleEsc(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Escape) return;
            Close();
        }

        private void NewDoc_Loaded(object sender, RoutedEventArgs e)
        {
            CabinCombo.SelectedIndex = 0;
            MaterialCombo.SelectedIndex = 0;
            Activate();
            Focus();
        }

        private void CabinCombo_SelectionChanged(object sender, SelectionChangedEventArgs e) => CabinModel = (e.AddedItems[0] as ComboBoxItem)?.Content.ToString();

        private void MaterialCombo_SelectionChanged(object sender, SelectionChangedEventArgs e) => MaterialType = (e.AddedItems[0] as ComboBoxItem)?.Content.ToString();

        private void OkButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

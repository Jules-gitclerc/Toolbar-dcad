using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DcadToolBar
{
    public partial class ChooseColor : Form
    {
        public int ValueR { get; set; }
        public int ValueG { get; set; }
        public int ValueB { get; set; }
        public int LayerVal { get; set; }

        public ChooseColor()
        {
            InitializeComponent();
            ValueR = 0;
            ValueG = 0;
            ValueB = 0;
            LayerVal = 0;
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            colorDialog.FullOpen = false;
            DialogResult dr = colorDialog.ShowDialog();

            if (dr != DialogResult.OK) return;
            ValueR = colorDialog.Color.R;
            ValueG = colorDialog.Color.G;
            ValueB = colorDialog.Color.B;
            ColorButton.BackColor = colorDialog.Color;
        }

        private void ValidateFormButton_Click(object sender, EventArgs e)
        {
            LayerVal = (int) LayerNumericUpDown.Value;
            Close();
        }

        private void CancelFormButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

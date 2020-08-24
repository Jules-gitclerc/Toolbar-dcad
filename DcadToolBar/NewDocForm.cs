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
    public partial class NewDocForm : Form
    {
        public string CabinModel { get; set; }

        public string MaterialType { get; set; }

        public NewDocForm()
        {
            InitializeComponent();
            CabinModel = "Primo";
            MaterialType = "Nylon";
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData != Keys.Escape) return base.ProcessCmdKey(ref msg, keyData);
            Close();
            return true;
        }

        private void NewDocForm_Load(object sender, EventArgs e)
        {
            CabinCombo.SelectedIndex = 0;
            MaterialCombo.SelectedIndex = 0;
            Activate();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CabinCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CabinModel = CabinCombo.Text;
        }

        private void MaterialCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaterialType = MaterialCombo.Text;
        }
    }
}

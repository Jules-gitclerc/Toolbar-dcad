using System.Drawing;

namespace DcadToolBar
{
    partial class ToolBarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ModelComboBox = new System.Windows.Forms.ComboBox();
            this.MaterialComboBox = new System.Windows.Forms.ComboBox();
            this.DocTitle = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.bambinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PoignéeCarréeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PoignéeLuneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PoignéeOvaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PoignéeRondeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PoignéeTriangleRéfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poteauToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.poignée1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.poignée2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.test3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.test4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test3ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ModelComboBox
            // 
            this.ModelComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ModelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModelComboBox.Enabled = false;
            this.ModelComboBox.FormattingEnabled = true;
            this.ModelComboBox.Items.AddRange(new object[] {
            "Primo",
            "Primo exel",
            "Duo",
            "Duo exel",
            "Brio",
            "Brio exel",
            "Hauzeo",
            "Bambino",
            "Exéléo"});
            this.ModelComboBox.Location = new System.Drawing.Point(169, 36);
            this.ModelComboBox.Name = "ModelComboBox";
            this.ModelComboBox.Size = new System.Drawing.Size(121, 24);
            this.ModelComboBox.TabIndex = 4;
            // 
            // MaterialComboBox
            // 
            this.MaterialComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MaterialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaterialComboBox.Enabled = false;
            this.MaterialComboBox.FormattingEnabled = true;
            this.MaterialComboBox.Items.AddRange(new object[] {
            "Nylon",
            "Aluminium",
            "Inox"});
            this.MaterialComboBox.Location = new System.Drawing.Point(40, 36);
            this.MaterialComboBox.Name = "MaterialComboBox";
            this.MaterialComboBox.Size = new System.Drawing.Size(121, 24);
            this.MaterialComboBox.TabIndex = 5;
            // 
            // DocTitle
            // 
            this.DocTitle.AutoSize = true;
            this.DocTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocTitle.Location = new System.Drawing.Point(12, 9);
            this.DocTitle.Name = "DocTitle";
            this.DocTitle.Size = new System.Drawing.Size(69, 13);
            this.DocTitle.TabIndex = 6;
            this.DocTitle.Text = "no document";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateButton.Image = global::DcadToolBar.Properties.Resources.green_refresh;
            this.UpdateButton.Location = new System.Drawing.Point(264, 2);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(24, 23);
            this.UpdateButton.TabIndex = 7;
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bambinoToolStripMenuItem,
            this.poignée1ToolStripMenuItem,
            this.poignée2ToolStripMenuItem,
            this.test3ToolStripMenuItem,
            this.test4ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 80);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip2.Size = new System.Drawing.Size(387, 24);
            this.menuStrip2.TabIndex = 9;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // bambinoToolStripMenuItem
            // 
            this.bambinoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PoignéeCarréeToolStripMenuItem,
            this.PoignéeLuneToolStripMenuItem,
            this.PoignéeOvaleToolStripMenuItem,
            this.PoignéeRondeToolStripMenuItem1,
            this.PoignéeTriangleRéfToolStripMenuItem,
            this.poteauToolStripMenuItem1});
            this.bambinoToolStripMenuItem.Name = "bambinoToolStripMenuItem";
            this.bambinoToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.bambinoToolStripMenuItem.Text = "Bambino";
            // 
            // PoignéeCarréeToolStripMenuItem
            // 
            this.PoignéeCarréeToolStripMenuItem.Name = "PoignéeCarréeToolStripMenuItem";
            this.PoignéeCarréeToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.PoignéeCarréeToolStripMenuItem.Text = "Poignée Carrée Réf.221.310";
            this.PoignéeCarréeToolStripMenuItem.Click += new System.EventHandler(this.PoignéeCarréeToolStripMenuItem_Click);
            // 
            // PoignéeLuneToolStripMenuItem
            // 
            this.PoignéeLuneToolStripMenuItem.Name = "PoignéeLuneToolStripMenuItem";
            this.PoignéeLuneToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.PoignéeLuneToolStripMenuItem.Text = "Poignée Lune Réf.221.314";
            this.PoignéeLuneToolStripMenuItem.Click += new System.EventHandler(this.PoignéeLuneToolStripMenuItem_Click);
            // 
            // PoignéeOvaleToolStripMenuItem
            // 
            this.PoignéeOvaleToolStripMenuItem.Name = "PoignéeOvaleToolStripMenuItem";
            this.PoignéeOvaleToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.PoignéeOvaleToolStripMenuItem.Text = "Poignée Ovale Réf.221.313";
            this.PoignéeOvaleToolStripMenuItem.Click += new System.EventHandler(this.PoignéeOvaleToolStripMenuItem_Click);
            // 
            // PoignéeRondeToolStripMenuItem1
            // 
            this.PoignéeRondeToolStripMenuItem1.Name = "PoignéeRondeToolStripMenuItem1";
            this.PoignéeRondeToolStripMenuItem1.Size = new System.Drawing.Size(223, 22);
            this.PoignéeRondeToolStripMenuItem1.Text = "Poignée Ronde Réf.221.311";
            this.PoignéeRondeToolStripMenuItem1.Click += new System.EventHandler(this.PoignéeRondeToolStripMenuItem1_Click);
            // 
            // PoignéeTriangleRéfToolStripMenuItem
            // 
            this.PoignéeTriangleRéfToolStripMenuItem.Name = "PoignéeTriangleRéfToolStripMenuItem";
            this.PoignéeTriangleRéfToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.PoignéeTriangleRéfToolStripMenuItem.Text = "Poignée Triangle Réf.221.312";
            this.PoignéeTriangleRéfToolStripMenuItem.Click += new System.EventHandler(this.PoignéeTriangleRéfToolStripMenuItem_Click);
            // 
            // poteauToolStripMenuItem1
            // 
            this.poteauToolStripMenuItem1.Name = "poteauToolStripMenuItem1";
            this.poteauToolStripMenuItem1.Size = new System.Drawing.Size(223, 22);
            this.poteauToolStripMenuItem1.Text = "Poteau";
            this.poteauToolStripMenuItem1.Click += new System.EventHandler(this.poteauToolStripMenuItem1_Click);
            // 
            // poignée1ToolStripMenuItem
            // 
            this.poignée1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.poignée1ToolStripMenuItem.Name = "poignée1ToolStripMenuItem";
            this.poignée1ToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.poignée1ToolStripMenuItem.Text = "Test 1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "pt collectif";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "Test 2";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem4.Text = "Test 3";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem5.Text = "Test 4";
            // 
            // poignée2ToolStripMenuItem
            // 
            this.poignée2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9});
            this.poignée2ToolStripMenuItem.Name = "poignée2ToolStripMenuItem";
            this.poignée2ToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.poignée2ToolStripMenuItem.Text = "Test 2";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItem6.Text = "Test 1";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItem7.Text = "Test 2";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItem8.Text = "Test 3";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItem9.Text = "Test 4";
            // 
            // test3ToolStripMenuItem
            // 
            this.test3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem10,
            this.toolStripMenuItem11,
            this.toolStripMenuItem12});
            this.test3ToolStripMenuItem.Name = "test3ToolStripMenuItem";
            this.test3ToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.test3ToolStripMenuItem.Text = "Test 3";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItem10.Text = "Test 1";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItem11.Text = "Test 2";
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItem12.Text = "Test 3";
            // 
            // test4ToolStripMenuItem
            // 
            this.test4ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.test1ToolStripMenuItem,
            this.test2ToolStripMenuItem,
            this.test3ToolStripMenuItem1});
            this.test4ToolStripMenuItem.Name = "test4ToolStripMenuItem";
            this.test4ToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.test4ToolStripMenuItem.Text = "Test 4";
            // 
            // test1ToolStripMenuItem
            // 
            this.test1ToolStripMenuItem.Name = "test1ToolStripMenuItem";
            this.test1ToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.test1ToolStripMenuItem.Text = "Test 1";
            // 
            // test2ToolStripMenuItem
            // 
            this.test2ToolStripMenuItem.Name = "test2ToolStripMenuItem";
            this.test2ToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.test2ToolStripMenuItem.Text = "Test 2";
            // 
            // test3ToolStripMenuItem1
            // 
            this.test3ToolStripMenuItem1.Name = "test3ToolStripMenuItem1";
            this.test3ToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.test3ToolStripMenuItem1.Text = "Test 3";
            // 
            // menuStrip3
            // 
            this.menuStrip3.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip3.Location = new System.Drawing.Point(0, 80);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(299, 24);
            this.menuStrip3.TabIndex = 10;
            this.menuStrip3.Text = "menuStrip3";
            this.menuStrip3.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip3_ItemClicked);
            // 
            // ToolBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 104);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DocTitle);
            this.Controls.Add(this.MaterialComboBox);
            this.Controls.Add(this.ModelComboBox);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1470, 0);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ToolBarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Informations";
            this.TopMost = true;
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ModelComboBox;
        private System.Windows.Forms.ComboBox MaterialComboBox;
        private System.Windows.Forms.Label DocTitle;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem bambinoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PoignéeCarréeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PoignéeLuneToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem poignée1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem poignée2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem test3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem test4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem test1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem test2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem test3ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem PoignéeOvaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PoignéeRondeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem poteauToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem PoignéeTriangleRéfToolStripMenuItem;
    }
}
namespace DcadToolBar
{
    partial class NewDocForm
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
            this.CabinCombo = new System.Windows.Forms.ComboBox();
            this.MaterialCombo = new System.Windows.Forms.ComboBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CabinCombo
            // 
            this.CabinCombo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CabinCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CabinCombo.FormattingEnabled = true;
            this.CabinCombo.Items.AddRange(new object[] {
            "Primo",
            "Primo exel",
            "Duo",
            "Duo exel",
            "Brio",
            "Brio exel",
            "Hauzeo",
            "Bambino",
            "Exéléo"});
            this.CabinCombo.Location = new System.Drawing.Point(30, 19);
            this.CabinCombo.Name = "CabinCombo";
            this.CabinCombo.Size = new System.Drawing.Size(121, 24);
            this.CabinCombo.TabIndex = 0;
            this.CabinCombo.SelectedIndexChanged += new System.EventHandler(this.CabinCombo_SelectedIndexChanged);
            // 
            // MaterialCombo
            // 
            this.MaterialCombo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.MaterialCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaterialCombo.FormattingEnabled = true;
            this.MaterialCombo.Items.AddRange(new object[] {
            "Nylon",
            "Aluminium",
            "Inox"});
            this.MaterialCombo.Location = new System.Drawing.Point(30, 59);
            this.MaterialCombo.Name = "MaterialCombo";
            this.MaterialCombo.Size = new System.Drawing.Size(121, 24);
            this.MaterialCombo.TabIndex = 1;
            this.MaterialCombo.SelectedIndexChanged += new System.EventHandler(this.MaterialCombo_SelectedIndexChanged);
            // 
            // OkButton
            // 
            this.OkButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.OkButton.Location = new System.Drawing.Point(71, 95);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(42, 23);
            this.OkButton.TabIndex = 3;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // NewDocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 130);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.MaterialCombo);
            this.Controls.Add(this.CabinCombo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewDocForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nouveau document";
            this.Load += new System.EventHandler(this.NewDocForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CabinCombo;
        private System.Windows.Forms.ComboBox MaterialCombo;
        private System.Windows.Forms.Button OkButton;
    }
}
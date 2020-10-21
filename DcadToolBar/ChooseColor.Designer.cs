namespace DcadToolBar
{
    partial class ChooseColor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseColor));
            this.LayerNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ColorButton = new System.Windows.Forms.Button();
            this.LayerLabel = new System.Windows.Forms.Label();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.CancelFormButton = new System.Windows.Forms.Button();
            this.ValidateFormButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LayerNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // LayerNumericUpDown
            // 
            this.LayerNumericUpDown.Location = new System.Drawing.Point(24, 45);
            this.LayerNumericUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.LayerNumericUpDown.Name = "LayerNumericUpDown";
            this.LayerNumericUpDown.Size = new System.Drawing.Size(79, 20);
            this.LayerNumericUpDown.TabIndex = 0;
            // 
            // ColorButton
            // 
            this.ColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorButton.BackColor = System.Drawing.Color.White;
            this.ColorButton.Location = new System.Drawing.Point(141, 43);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(75, 23);
            this.ColorButton.TabIndex = 1;
            this.ColorButton.UseVisualStyleBackColor = false;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // LayerLabel
            // 
            this.LayerLabel.AutoSize = true;
            this.LayerLabel.Location = new System.Drawing.Point(40, 22);
            this.LayerLabel.Name = "LayerLabel";
            this.LayerLabel.Size = new System.Drawing.Size(50, 13);
            this.LayerLabel.TabIndex = 4;
            this.LayerLabel.Text = "Couche :";
            // 
            // ColorLabel
            // 
            this.ColorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(153, 22);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(49, 13);
            this.ColorLabel.TabIndex = 5;
            this.ColorLabel.Text = "Couleur :";
            // 
            // CancelFormButton
            // 
            this.CancelFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelFormButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelFormButton.Location = new System.Drawing.Point(12, 77);
            this.CancelFormButton.Name = "CancelFormButton";
            this.CancelFormButton.Size = new System.Drawing.Size(75, 23);
            this.CancelFormButton.TabIndex = 3;
            this.CancelFormButton.Text = "Annuler";
            this.CancelFormButton.UseVisualStyleBackColor = true;
            this.CancelFormButton.Click += new System.EventHandler(this.CancelFormButton_Click);
            // 
            // ValidateFormButton
            // 
            this.ValidateFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ValidateFormButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ValidateFormButton.Location = new System.Drawing.Point(152, 77);
            this.ValidateFormButton.Name = "ValidateFormButton";
            this.ValidateFormButton.Size = new System.Drawing.Size(75, 23);
            this.ValidateFormButton.TabIndex = 2;
            this.ValidateFormButton.Text = "Valider";
            this.ValidateFormButton.UseVisualStyleBackColor = true;
            this.ValidateFormButton.Click += new System.EventHandler(this.ValidateFormButton_Click);
            // 
            // ChooseColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 109);
            this.Controls.Add(this.ValidateFormButton);
            this.Controls.Add(this.CancelFormButton);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.LayerLabel);
            this.Controls.Add(this.ColorButton);
            this.Controls.Add(this.LayerNumericUpDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseColor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choisir couleur";
            ((System.ComponentModel.ISupportInitialize)(this.LayerNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown LayerNumericUpDown;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.Label LayerLabel;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Button CancelFormButton;
        private System.Windows.Forms.Button ValidateFormButton;
    }
}
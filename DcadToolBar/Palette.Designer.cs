namespace DcadToolBar
{
    partial class Palet
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorRed = new System.Windows.Forms.Button();
            this.ColorBlue = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ColorBlack = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // colorRed
            // 
            this.colorRed.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.colorRed.BackColor = System.Drawing.Color.Red;
            this.colorRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorRed.Location = new System.Drawing.Point(2, 94);
            this.colorRed.Name = "colorRed";
            this.colorRed.Size = new System.Drawing.Size(18, 18);
            this.colorRed.TabIndex = 0;
            this.colorRed.UseVisualStyleBackColor = false;
            // 
            // ColorBlue
            // 
            this.ColorBlue.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ColorBlue.BackColor = System.Drawing.Color.Blue;
            this.ColorBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorBlue.Location = new System.Drawing.Point(2, 72);
            this.ColorBlue.Name = "ColorBlue";
            this.ColorBlue.Size = new System.Drawing.Size(18, 18);
            this.ColorBlue.TabIndex = 1;
            this.ColorBlue.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(2, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(18, 18);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ColorBlack
            // 
            this.ColorBlack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ColorBlack.BackColor = System.Drawing.Color.Black;
            this.ColorBlack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorBlack.Location = new System.Drawing.Point(2, 28);
            this.ColorBlack.Name = "ColorBlack";
            this.ColorBlack.Size = new System.Drawing.Size(18, 18);
            this.ColorBlack.TabIndex = 3;
            this.ColorBlack.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::DcadToolBar.Properties.Resources.paletcolor;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(2, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(18, 18);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Palet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(22, 118);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ColorBlack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ColorBlue);
            this.Controls.Add(this.colorRed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(-10000, -10000);
            this.Name = "Palet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Palette";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Palet_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button colorRed;
        private System.Windows.Forms.Button ColorBlue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ColorBlack;
        private System.Windows.Forms.Button button2;
    }
}
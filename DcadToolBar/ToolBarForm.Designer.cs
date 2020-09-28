﻿using System.Drawing;

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
            this.macroMenuStrip = new System.Windows.Forms.MenuStrip();
            this.CloakRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CasiersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.casierDiploToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.casierhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.casierZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.casiersBancsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.casiersAgroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.casierZToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.casierHToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.casierMétalliquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.armoiresCollectivesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CasiersInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BancsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BancsBoisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BancsCompactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sérieC50ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.casiersBancCompactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.macroMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ModelComboBox
            // 
            this.ModelComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.ModelComboBox.Location = new System.Drawing.Point(168, 28);
            this.ModelComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ModelComboBox.Name = "ModelComboBox";
            this.ModelComboBox.Size = new System.Drawing.Size(121, 24);
            this.ModelComboBox.TabIndex = 4;
            // 
            // MaterialComboBox
            // 
            this.MaterialComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaterialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaterialComboBox.Enabled = false;
            this.MaterialComboBox.FormattingEnabled = true;
            this.MaterialComboBox.Items.AddRange(new object[] {
            "Nylon",
            "Aluminium",
            "Inox"});
            this.MaterialComboBox.Location = new System.Drawing.Point(168, 59);
            this.MaterialComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaterialComboBox.Name = "MaterialComboBox";
            this.MaterialComboBox.Size = new System.Drawing.Size(121, 24);
            this.MaterialComboBox.TabIndex = 5;
            // 
            // DocTitle
            // 
            this.DocTitle.AutoSize = true;
            this.DocTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocTitle.Location = new System.Drawing.Point(12, 5);
            this.DocTitle.Name = "DocTitle";
            this.DocTitle.Size = new System.Drawing.Size(69, 13);
            this.DocTitle.TabIndex = 6;
            this.DocTitle.Text = "no document";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateButton.Image = global::DcadToolBar.Properties.Resources.green_refresh;
            this.UpdateButton.Location = new System.Drawing.Point(275, 1);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(24, 23);
            this.UpdateButton.TabIndex = 7;
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // macroMenuStrip
            // 
            this.macroMenuStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.macroMenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.macroMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloakRoomToolStripMenuItem});
            this.macroMenuStrip.Location = new System.Drawing.Point(9, 28);
            this.macroMenuStrip.Name = "macroMenuStrip";
            this.macroMenuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.macroMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.macroMenuStrip.Size = new System.Drawing.Size(189, 24);
            this.macroMenuStrip.TabIndex = 9;
            this.macroMenuStrip.Text = "menuStrip2";
            // 
            // CloakRoomToolStripMenuItem
            // 
            this.CloakRoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CasiersToolStripMenuItem,
            this.CasiersInfoToolStripMenuItem,
            this.BancsToolStripMenuItem});
            this.CloakRoomToolStripMenuItem.Name = "CloakRoomToolStripMenuItem";
            this.CloakRoomToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.CloakRoomToolStripMenuItem.Text = "Vestiaire";
            // 
            // CasiersToolStripMenuItem
            // 
            this.CasiersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.casierDiploToolStripMenuItem,
            this.casiersBancsToolStripMenuItem,
            this.casiersBancCompactToolStripMenuItem,
            this.casiersAgroToolStripMenuItem,
            this.casierMétalliquesToolStripMenuItem,
            this.armoiresCollectivesToolStripMenuItem});
            this.CasiersToolStripMenuItem.Name = "CasiersToolStripMenuItem";
            this.CasiersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CasiersToolStripMenuItem.Text = "Casiers";
            // 
            // casierDiploToolStripMenuItem
            // 
            this.casierDiploToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.casierhToolStripMenuItem,
            this.casierZToolStripMenuItem});
            this.casierDiploToolStripMenuItem.Name = "casierDiploToolStripMenuItem";
            this.casierDiploToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.casierDiploToolStripMenuItem.Text = "Casiers Diplo";
            // 
            // casierhToolStripMenuItem
            // 
            this.casierhToolStripMenuItem.Name = "casierhToolStripMenuItem";
            this.casierhToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.casierhToolStripMenuItem.Text = "Casier h";
            this.casierhToolStripMenuItem.Click += new System.EventHandler(this.CasierhToolStripMenuItem_Click);
            // 
            // casierZToolStripMenuItem
            // 
            this.casierZToolStripMenuItem.Name = "casierZToolStripMenuItem";
            this.casierZToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.casierZToolStripMenuItem.Text = "Casier z";
            this.casierZToolStripMenuItem.Click += new System.EventHandler(this.CasierZToolStripMenuItem_Click);
            // 
            // casiersBancsToolStripMenuItem
            // 
            this.casiersBancsToolStripMenuItem.Name = "casiersBancsToolStripMenuItem";
            this.casiersBancsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.casiersBancsToolStripMenuItem.Text = "Casiers Bancs";
            this.casiersBancsToolStripMenuItem.Click += new System.EventHandler(this.CasiersBancsToolStripMenuItem_Click);
            // 
            // casiersAgroToolStripMenuItem
            // 
            this.casiersAgroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.casierZToolStripMenuItem1,
            this.casierHToolStripMenuItem1});
            this.casiersAgroToolStripMenuItem.Name = "casiersAgroToolStripMenuItem";
            this.casiersAgroToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.casiersAgroToolStripMenuItem.Text = "Casiers Agro";
            // 
            // casierZToolStripMenuItem1
            // 
            this.casierZToolStripMenuItem1.Name = "casierZToolStripMenuItem1";
            this.casierZToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.casierZToolStripMenuItem1.Text = "Casier z";
            // 
            // casierHToolStripMenuItem1
            // 
            this.casierHToolStripMenuItem1.Name = "casierHToolStripMenuItem1";
            this.casierHToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.casierHToolStripMenuItem1.Text = "Casier h";
            // 
            // casierMétalliquesToolStripMenuItem
            // 
            this.casierMétalliquesToolStripMenuItem.Name = "casierMétalliquesToolStripMenuItem";
            this.casierMétalliquesToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.casierMétalliquesToolStripMenuItem.Text = "Casiers Métalliques";
            // 
            // armoiresCollectivesToolStripMenuItem
            // 
            this.armoiresCollectivesToolStripMenuItem.Name = "armoiresCollectivesToolStripMenuItem";
            this.armoiresCollectivesToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.armoiresCollectivesToolStripMenuItem.Text = "Armoires Collectives";
            // 
            // CasiersInfoToolStripMenuItem
            // 
            this.CasiersInfoToolStripMenuItem.Name = "CasiersInfoToolStripMenuItem";
            this.CasiersInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CasiersInfoToolStripMenuItem.Text = "Casiers informatisé";
            // 
            // BancsToolStripMenuItem
            // 
            this.BancsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BancsBoisToolStripMenuItem,
            this.BancsCompactToolStripMenuItem});
            this.BancsToolStripMenuItem.Name = "BancsToolStripMenuItem";
            this.BancsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.BancsToolStripMenuItem.Text = "Bancs";
            // 
            // BancsBoisToolStripMenuItem
            // 
            this.BancsBoisToolStripMenuItem.Name = "BancsBoisToolStripMenuItem";
            this.BancsBoisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.BancsBoisToolStripMenuItem.Text = "Bancs Bois";
            // 
            // BancsCompactToolStripMenuItem
            // 
            this.BancsCompactToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sérieC50ToolStripMenuItem});
            this.BancsCompactToolStripMenuItem.Name = "BancsCompactToolStripMenuItem";
            this.BancsCompactToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.BancsCompactToolStripMenuItem.Text = "Bancs Compact";
            // 
            // sérieC50ToolStripMenuItem
            // 
            this.sérieC50ToolStripMenuItem.Name = "sérieC50ToolStripMenuItem";
            this.sérieC50ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sérieC50ToolStripMenuItem.Text = "Série C50";
            this.sérieC50ToolStripMenuItem.Click += new System.EventHandler(this.sérieC50ToolStripMenuItem_Click);
            // 
            // casiersBancCompactToolStripMenuItem
            // 
            this.casiersBancCompactToolStripMenuItem.Name = "casiersBancCompactToolStripMenuItem";
            this.casiersBancCompactToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.casiersBancCompactToolStripMenuItem.Text = "Casiers Banc Compact";
            this.casiersBancCompactToolStripMenuItem.Click += new System.EventHandler(this.casiersBancCompactToolStripMenuItem_Click);
            // 
            // ToolBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 91);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DocTitle);
            this.Controls.Add(this.MaterialComboBox);
            this.Controls.Add(this.ModelComboBox);
            this.Controls.Add(this.macroMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1430, 0);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ToolBarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Informations";
            this.TopMost = true;
            this.macroMenuStrip.ResumeLayout(false);
            this.macroMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ModelComboBox;
        private System.Windows.Forms.ComboBox MaterialComboBox;
        private System.Windows.Forms.Label DocTitle;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.MenuStrip macroMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem CloakRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CasiersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BancsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CasiersInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem casierDiploToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem casierhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem casierZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem casiersAgroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem casierZToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem casierHToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem casierMétalliquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem armoiresCollectivesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BancsBoisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BancsCompactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sérieC50ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem casiersBancsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem casiersBancCompactToolStripMenuItem;
    }
}
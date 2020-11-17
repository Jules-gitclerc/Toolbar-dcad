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
            this.macroMenuStrip = new System.Windows.Forms.MenuStrip();
            this.CloakRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CasiersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.casierDiploToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.casierhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.casierZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.casiersBancsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.casiersBancCompactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.casiersAgroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.casierZToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.casierHToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.casierMétalliquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.armoiresCollectivesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CasiersInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BancsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BancsBoisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sérieB1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sérieB50ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sérieB450ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BancsCompactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sérieC1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sérieC20ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sérieC50ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sérieC60ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sérieC500ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sérieC550ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sérieC700ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sérieC600ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LisseCompactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lisseC100ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cabineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FaçadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facadeKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facadeDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facadeLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reperageFaçadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reperageRefendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajusterRefendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePictureBox = new System.Windows.Forms.PictureBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.macroMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updatePictureBox)).BeginInit();
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
            // macroMenuStrip
            // 
            this.macroMenuStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.macroMenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.macroMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloakRoomToolStripMenuItem,
            this.cabineToolStripMenuItem});
            this.macroMenuStrip.Location = new System.Drawing.Point(9, 28);
            this.macroMenuStrip.Name = "macroMenuStrip";
            this.macroMenuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.macroMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.macroMenuStrip.Size = new System.Drawing.Size(245, 24);
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
            this.casiersBancsToolStripMenuItem.Text = "Casiers Bancs Bois";
            this.casiersBancsToolStripMenuItem.Click += new System.EventHandler(this.CasiersBancsToolStripMenuItem_Click);
            // 
            // casiersBancCompactToolStripMenuItem
            // 
            this.casiersBancCompactToolStripMenuItem.Name = "casiersBancCompactToolStripMenuItem";
            this.casiersBancCompactToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.casiersBancCompactToolStripMenuItem.Text = "Casiers Banc Compact";
            this.casiersBancCompactToolStripMenuItem.Click += new System.EventHandler(this.CasiersBancCompactToolStripMenuItem_Click);
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
            this.BancsCompactToolStripMenuItem,
            this.LisseCompactToolStripMenuItem});
            this.BancsToolStripMenuItem.Name = "BancsToolStripMenuItem";
            this.BancsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.BancsToolStripMenuItem.Text = "Bancs et Lisses";
            // 
            // BancsBoisToolStripMenuItem
            // 
            this.BancsBoisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sérieB1ToolStripMenuItem,
            this.sérieB50ToolStripMenuItem,
            this.sérieB450ToolStripMenuItem});
            this.BancsBoisToolStripMenuItem.Name = "BancsBoisToolStripMenuItem";
            this.BancsBoisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.BancsBoisToolStripMenuItem.Text = "Bancs Bois";
            // 
            // sérieB1ToolStripMenuItem
            // 
            this.sérieB1ToolStripMenuItem.Name = "sérieB1ToolStripMenuItem";
            this.sérieB1ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.sérieB1ToolStripMenuItem.Text = "Série B1";
            this.sérieB1ToolStripMenuItem.Click += new System.EventHandler(this.sérieB1ToolStripMenuItem_Click);
            // 
            // sérieB50ToolStripMenuItem
            // 
            this.sérieB50ToolStripMenuItem.Name = "sérieB50ToolStripMenuItem";
            this.sérieB50ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.sérieB50ToolStripMenuItem.Text = "Série B50";
            this.sérieB50ToolStripMenuItem.Click += new System.EventHandler(this.sérieB50ToolStripMenuItem_Click);
            // 
            // sérieB450ToolStripMenuItem
            // 
            this.sérieB450ToolStripMenuItem.Name = "sérieB450ToolStripMenuItem";
            this.sérieB450ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.sérieB450ToolStripMenuItem.Text = "Série B450";
            this.sérieB450ToolStripMenuItem.Click += new System.EventHandler(this.sérieB450ToolStripMenuItem_Click);
            // 
            // BancsCompactToolStripMenuItem
            // 
            this.BancsCompactToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sérieC1ToolStripMenuItem,
            this.sérieC20ToolStripMenuItem,
            this.sérieC50ToolStripMenuItem,
            this.sérieC60ToolStripMenuItem,
            this.sérieC500ToolStripMenuItem,
            this.sérieC550ToolStripMenuItem,
            this.sérieC700ToolStripMenuItem,
            this.sérieC600ToolStripMenuItem});
            this.BancsCompactToolStripMenuItem.Name = "BancsCompactToolStripMenuItem";
            this.BancsCompactToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.BancsCompactToolStripMenuItem.Text = "Bancs Compact";
            // 
            // sérieC1ToolStripMenuItem
            // 
            this.sérieC1ToolStripMenuItem.Name = "sérieC1ToolStripMenuItem";
            this.sérieC1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sérieC1ToolStripMenuItem.Text = "Série C1";
            this.sérieC1ToolStripMenuItem.Click += new System.EventHandler(this.sérieC1ToolStripMenuItem_Click);
            // 
            // sérieC20ToolStripMenuItem
            // 
            this.sérieC20ToolStripMenuItem.Name = "sérieC20ToolStripMenuItem";
            this.sérieC20ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sérieC20ToolStripMenuItem.Text = "Série C20";
            this.sérieC20ToolStripMenuItem.Click += new System.EventHandler(this.sérieC20ToolStripMenuItem_Click);
            // 
            // sérieC50ToolStripMenuItem
            // 
            this.sérieC50ToolStripMenuItem.Name = "sérieC50ToolStripMenuItem";
            this.sérieC50ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sérieC50ToolStripMenuItem.Text = "Série C50";
            this.sérieC50ToolStripMenuItem.Click += new System.EventHandler(this.SérieC50ToolStripMenuItem_Click);
            // 
            // sérieC60ToolStripMenuItem
            // 
            this.sérieC60ToolStripMenuItem.Name = "sérieC60ToolStripMenuItem";
            this.sérieC60ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sérieC60ToolStripMenuItem.Text = "Série C60";
            this.sérieC60ToolStripMenuItem.Click += new System.EventHandler(this.sérieC60ToolStripMenuItem_Click);
            // 
            // sérieC500ToolStripMenuItem
            // 
            this.sérieC500ToolStripMenuItem.Name = "sérieC500ToolStripMenuItem";
            this.sérieC500ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sérieC500ToolStripMenuItem.Text = "Série C500";
            this.sérieC500ToolStripMenuItem.Click += new System.EventHandler(this.sérieC500ToolStripMenuItem_Click);
            // 
            // sérieC550ToolStripMenuItem
            // 
            this.sérieC550ToolStripMenuItem.Name = "sérieC550ToolStripMenuItem";
            this.sérieC550ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sérieC550ToolStripMenuItem.Text = "Série C550";
            this.sérieC550ToolStripMenuItem.Click += new System.EventHandler(this.sérieC550ToolStripMenuItem_Click);
            // 
            // sérieC700ToolStripMenuItem
            // 
            this.sérieC700ToolStripMenuItem.Name = "sérieC700ToolStripMenuItem";
            this.sérieC700ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sérieC700ToolStripMenuItem.Text = "Série C700";
            this.sérieC700ToolStripMenuItem.Click += new System.EventHandler(this.sérieC700ToolStripMenuItem_Click);
            // 
            // sérieC600ToolStripMenuItem
            // 
            this.sérieC600ToolStripMenuItem.Name = "sérieC600ToolStripMenuItem";
            this.sérieC600ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sérieC600ToolStripMenuItem.Text = "Série C600";
            this.sérieC600ToolStripMenuItem.Click += new System.EventHandler(this.sérieC600ToolStripMenuItem_Click);
            // 
            // LisseCompactToolStripMenuItem
            // 
            this.LisseCompactToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lisseC100ToolStripMenuItem});
            this.LisseCompactToolStripMenuItem.Name = "LisseCompactToolStripMenuItem";
            this.LisseCompactToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.LisseCompactToolStripMenuItem.Text = "Lisse Compact";
            // 
            // lisseC100ToolStripMenuItem
            // 
            this.lisseC100ToolStripMenuItem.Name = "lisseC100ToolStripMenuItem";
            this.lisseC100ToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.lisseC100ToolStripMenuItem.Text = "Lisse série C100";
            this.lisseC100ToolStripMenuItem.Click += new System.EventHandler(this.lisseC100ToolStripMenuItem_Click);
            // 
            // cabineToolStripMenuItem
            // 
            this.cabineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FaçadeToolStripMenuItem,
            this.refendToolStripMenuItem});
            this.cabineToolStripMenuItem.Name = "cabineToolStripMenuItem";
            this.cabineToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.cabineToolStripMenuItem.Text = "Cabine";
            // 
            // FaçadeToolStripMenuItem
            // 
            this.FaçadeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facadeKToolStripMenuItem,
            this.facadeDToolStripMenuItem,
            this.facadeLToolStripMenuItem,
            this.reperageFaçadeToolStripMenuItem});
            this.FaçadeToolStripMenuItem.Name = "FaçadeToolStripMenuItem";
            this.FaçadeToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.FaçadeToolStripMenuItem.Text = "Façade";
            // 
            // facadeKToolStripMenuItem
            // 
            this.facadeKToolStripMenuItem.Name = "facadeKToolStripMenuItem";
            this.facadeKToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.facadeKToolStripMenuItem.Text = "Façade K";
            this.facadeKToolStripMenuItem.Click += new System.EventHandler(this.facadeKToolStripMenuItem_Click);
            // 
            // facadeDToolStripMenuItem
            // 
            this.facadeDToolStripMenuItem.Name = "facadeDToolStripMenuItem";
            this.facadeDToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.facadeDToolStripMenuItem.Text = "Façade D";
            this.facadeDToolStripMenuItem.Click += new System.EventHandler(this.facadeDToolStripMenuItem_Click);
            // 
            // facadeLToolStripMenuItem
            // 
            this.facadeLToolStripMenuItem.Name = "facadeLToolStripMenuItem";
            this.facadeLToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.facadeLToolStripMenuItem.Text = "Façade L";
            this.facadeLToolStripMenuItem.Click += new System.EventHandler(this.facadeLToolStripMenuItem_Click);
            // 
            // reperageFaçadeToolStripMenuItem
            // 
            this.reperageFaçadeToolStripMenuItem.Name = "reperageFaçadeToolStripMenuItem";
            this.reperageFaçadeToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.reperageFaçadeToolStripMenuItem.Text = "Repérage façade";
            this.reperageFaçadeToolStripMenuItem.Click += new System.EventHandler(this.reperageFaçadeToolStripMenuItem_Click);
            // 
            // refendToolStripMenuItem
            // 
            this.refendToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reperageRefendToolStripMenuItem,
            this.ajusterRefendToolStripMenuItem});
            this.refendToolStripMenuItem.Name = "refendToolStripMenuItem";
            this.refendToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.refendToolStripMenuItem.Text = "Refend";
            // 
            // reperageRefendToolStripMenuItem
            // 
            this.reperageRefendToolStripMenuItem.Name = "reperageRefendToolStripMenuItem";
            this.reperageRefendToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.reperageRefendToolStripMenuItem.Text = "Repérage refend";
            this.reperageRefendToolStripMenuItem.Click += new System.EventHandler(this.reperageRefendToolStripMenuItem_Click);
            // 
            // ajusterRefendToolStripMenuItem
            // 
            this.ajusterRefendToolStripMenuItem.Name = "ajusterRefendToolStripMenuItem";
            this.ajusterRefendToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.ajusterRefendToolStripMenuItem.Text = "Ajuster refend";
            this.ajusterRefendToolStripMenuItem.Click += new System.EventHandler(this.ajusterRefendToolStripMenuItem_Click);
            // 
            // updatePictureBox
            // 
            this.updatePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updatePictureBox.Image = global::DcadToolBar.Properties.Resources.Red_Circle_small__svg;
            this.updatePictureBox.Location = new System.Drawing.Point(291, 0);
            this.updatePictureBox.Name = "updatePictureBox";
            this.updatePictureBox.Size = new System.Drawing.Size(10, 10);
            this.updatePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.updatePictureBox.TabIndex = 10;
            this.updatePictureBox.TabStop = false;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateButton.Image = global::DcadToolBar.Properties.Resources.green_refresh;
            this.UpdateButton.Location = new System.Drawing.Point(273, 3);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(24, 23);
            this.UpdateButton.TabIndex = 7;
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ToolBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 91);
            this.Controls.Add(this.updatePictureBox);
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
            ((System.ComponentModel.ISupportInitialize)(this.updatePictureBox)).EndInit();
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
        private System.Windows.Forms.PictureBox updatePictureBox;
        private System.Windows.Forms.ToolStripMenuItem sérieC1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LisseCompactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lisseC100ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sérieC20ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sérieC60ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sérieC500ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sérieC550ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sérieC700ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sérieC600ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sérieB1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sérieB50ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sérieB450ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cabineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FaçadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facadeKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facadeDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facadeLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reperageFaçadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reperageRefendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajusterRefendToolStripMenuItem;
    }
}
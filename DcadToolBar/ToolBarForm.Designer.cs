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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolBarForm));
            this.ModelComboBox = new System.Windows.Forms.ComboBox();
            this.MaterialComboBox = new System.Windows.Forms.ComboBox();
            this.DocTitle = new System.Windows.Forms.Label();
            this.macroMenuStrip = new System.Windows.Forms.MenuStrip();
            this.outilsKalysseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cartoucheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cotationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.façadeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bandeauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.axeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eclaterSélectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outilCoucheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attributsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherLesAttributsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masquerLesAttributsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poserAttributToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changerAttributsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chercherUnAttributToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplierUnAttributToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerAttributsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.lisseC100ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sérieC500ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sérieC550ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sérieC600ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sérieC700ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sérieC750ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cabineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FaçadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facadeKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facadeDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facadeLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reperageFaçadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reperageRefendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajusterRefendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RcButton = new System.Windows.Forms.Button();
            this.RbButton = new System.Windows.Forms.Button();
            this.RcdButton = new System.Windows.Forms.Button();
            this.RcgButton = new System.Windows.Forms.Button();
            this.RadButton = new System.Windows.Forms.Button();
            this.RagButton = new System.Windows.Forms.Button();
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
            this.ModelComboBox.Location = new System.Drawing.Point(256, 28);
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
            this.MaterialComboBox.Location = new System.Drawing.Point(256, 59);
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
            this.outilsKalysseToolStripMenuItem,
            this.CloakRoomToolStripMenuItem,
            this.cabineToolStripMenuItem});
            this.macroMenuStrip.Location = new System.Drawing.Point(9, 28);
            this.macroMenuStrip.Name = "macroMenuStrip";
            this.macroMenuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.macroMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.macroMenuStrip.Size = new System.Drawing.Size(216, 24);
            this.macroMenuStrip.TabIndex = 9;
            this.macroMenuStrip.Text = "menuStrip2";
            // 
            // outilsKalysseToolStripMenuItem
            // 
            this.outilsKalysseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cartoucheToolStripMenuItem,
            this.cotationToolStripMenuItem,
            this.eclaterSélectionToolStripMenuItem,
            this.outilCoucheToolStripMenuItem,
            this.attributsToolStripMenuItem});
            this.outilsKalysseToolStripMenuItem.Name = "outilsKalysseToolStripMenuItem";
            this.outilsKalysseToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.outilsKalysseToolStripMenuItem.Text = "Outils Kalysse";
            this.outilsKalysseToolStripMenuItem.Click += new System.EventHandler(this.outilsKalysseToolStripMenuItem_Click);
            // 
            // cartoucheToolStripMenuItem
            // 
            this.cartoucheToolStripMenuItem.Name = "cartoucheToolStripMenuItem";
            this.cartoucheToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.cartoucheToolStripMenuItem.Text = "Cartouche";
            this.cartoucheToolStripMenuItem.Click += new System.EventHandler(this.cartoucheToolStripMenuItem_Click);
            // 
            // cotationToolStripMenuItem
            // 
            this.cotationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.façadeToolStripMenuItem1,
            this.bandeauToolStripMenuItem,
            this.axeToolStripMenuItem});
            this.cotationToolStripMenuItem.Name = "cotationToolStripMenuItem";
            this.cotationToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.cotationToolStripMenuItem.Text = "Cotation";
            // 
            // façadeToolStripMenuItem1
            // 
            this.façadeToolStripMenuItem1.Name = "façadeToolStripMenuItem1";
            this.façadeToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.façadeToolStripMenuItem1.Text = "Façade";
            this.façadeToolStripMenuItem1.Click += new System.EventHandler(this.façadeToolStripMenuItem1_Click);
            // 
            // bandeauToolStripMenuItem
            // 
            this.bandeauToolStripMenuItem.Name = "bandeauToolStripMenuItem";
            this.bandeauToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.bandeauToolStripMenuItem.Text = "Bandeau";
            this.bandeauToolStripMenuItem.Click += new System.EventHandler(this.bandeauToolStripMenuItem_Click);
            // 
            // axeToolStripMenuItem
            // 
            this.axeToolStripMenuItem.Name = "axeToolStripMenuItem";
            this.axeToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.axeToolStripMenuItem.Text = "Axe";
            this.axeToolStripMenuItem.Click += new System.EventHandler(this.axeToolStripMenuItem_Click);
            // 
            // eclaterSélectionToolStripMenuItem
            // 
            this.eclaterSélectionToolStripMenuItem.Name = "eclaterSélectionToolStripMenuItem";
            this.eclaterSélectionToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.eclaterSélectionToolStripMenuItem.Text = "Eclater Sélection";
            this.eclaterSélectionToolStripMenuItem.Click += new System.EventHandler(this.eclaterSélectionToolStripMenuItem_Click);
            // 
            // outilCoucheToolStripMenuItem
            // 
            this.outilCoucheToolStripMenuItem.Name = "outilCoucheToolStripMenuItem";
            this.outilCoucheToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.outilCoucheToolStripMenuItem.Text = "Outil Couche";
            this.outilCoucheToolStripMenuItem.Click += new System.EventHandler(this.outilCoucheToolStripMenuItem_Click);
            // 
            // attributsToolStripMenuItem
            // 
            this.attributsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherLesAttributsToolStripMenuItem,
            this.masquerLesAttributsToolStripMenuItem,
            this.poserAttributToolStripMenuItem,
            this.changerAttributsToolStripMenuItem,
            this.chercherUnAttributToolStripMenuItem,
            this.multiplierUnAttributToolStripMenuItem,
            this.supprimerAttributsToolStripMenuItem});
            this.attributsToolStripMenuItem.Name = "attributsToolStripMenuItem";
            this.attributsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.attributsToolStripMenuItem.Text = "Attributs";
            // 
            // afficherLesAttributsToolStripMenuItem
            // 
            this.afficherLesAttributsToolStripMenuItem.Name = "afficherLesAttributsToolStripMenuItem";
            this.afficherLesAttributsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.afficherLesAttributsToolStripMenuItem.Text = "Afficher les attributs";
            this.afficherLesAttributsToolStripMenuItem.Click += new System.EventHandler(this.afficherLesAttributsToolStripMenuItem_Click);
            // 
            // masquerLesAttributsToolStripMenuItem
            // 
            this.masquerLesAttributsToolStripMenuItem.Name = "masquerLesAttributsToolStripMenuItem";
            this.masquerLesAttributsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.masquerLesAttributsToolStripMenuItem.Text = "Masquer les attributs";
            this.masquerLesAttributsToolStripMenuItem.Click += new System.EventHandler(this.masquerLesAttributsToolStripMenuItem_Click);
            // 
            // poserAttributToolStripMenuItem
            // 
            this.poserAttributToolStripMenuItem.Name = "poserAttributToolStripMenuItem";
            this.poserAttributToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.poserAttributToolStripMenuItem.Text = "Poser attribut";
            this.poserAttributToolStripMenuItem.Click += new System.EventHandler(this.poserAttributToolStripMenuItem_Click);
            // 
            // changerAttributsToolStripMenuItem
            // 
            this.changerAttributsToolStripMenuItem.Name = "changerAttributsToolStripMenuItem";
            this.changerAttributsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.changerAttributsToolStripMenuItem.Text = "Changer attributs";
            this.changerAttributsToolStripMenuItem.Click += new System.EventHandler(this.changerAttributsToolStripMenuItem_Click);
            // 
            // chercherUnAttributToolStripMenuItem
            // 
            this.chercherUnAttributToolStripMenuItem.Name = "chercherUnAttributToolStripMenuItem";
            this.chercherUnAttributToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.chercherUnAttributToolStripMenuItem.Text = "Chercher un attribut";
            this.chercherUnAttributToolStripMenuItem.Click += new System.EventHandler(this.chercherUnAttributToolStripMenuItem_Click);
            // 
            // multiplierUnAttributToolStripMenuItem
            // 
            this.multiplierUnAttributToolStripMenuItem.Name = "multiplierUnAttributToolStripMenuItem";
            this.multiplierUnAttributToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.multiplierUnAttributToolStripMenuItem.Text = "Multiplier un attribut";
            this.multiplierUnAttributToolStripMenuItem.Click += new System.EventHandler(this.multiplierUnAttributToolStripMenuItem_Click);
            // 
            // supprimerAttributsToolStripMenuItem
            // 
            this.supprimerAttributsToolStripMenuItem.Name = "supprimerAttributsToolStripMenuItem";
            this.supprimerAttributsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.supprimerAttributsToolStripMenuItem.Text = "Supprimer attributs";
            this.supprimerAttributsToolStripMenuItem.Click += new System.EventHandler(this.supprimerAttributsToolStripMenuItem_Click);
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
            this.CloakRoomToolStripMenuItem.Click += new System.EventHandler(this.CloakRoomToolStripMenuItem_Click);
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
            this.CasiersToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
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
            this.CasiersInfoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.CasiersInfoToolStripMenuItem.Text = "Casiers informatisé";
            // 
            // BancsToolStripMenuItem
            // 
            this.BancsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BancsBoisToolStripMenuItem,
            this.BancsCompactToolStripMenuItem});
            this.BancsToolStripMenuItem.Name = "BancsToolStripMenuItem";
            this.BancsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.BancsToolStripMenuItem.Text = "Bancs et Lisses";
            // 
            // BancsBoisToolStripMenuItem
            // 
            this.BancsBoisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sérieB1ToolStripMenuItem,
            this.sérieB50ToolStripMenuItem,
            this.sérieB450ToolStripMenuItem});
            this.BancsBoisToolStripMenuItem.Name = "BancsBoisToolStripMenuItem";
            this.BancsBoisToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.BancsBoisToolStripMenuItem.Text = "Bois";
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
            this.lisseC100ToolStripMenuItem,
            this.sérieC500ToolStripMenuItem,
            this.sérieC550ToolStripMenuItem,
            this.sérieC600ToolStripMenuItem,
            this.sérieC700ToolStripMenuItem,
            this.sérieC750ToolStripMenuItem});
            this.BancsCompactToolStripMenuItem.Name = "BancsCompactToolStripMenuItem";
            this.BancsCompactToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.BancsCompactToolStripMenuItem.Text = "Compact";
            // 
            // sérieC1ToolStripMenuItem
            // 
            this.sérieC1ToolStripMenuItem.Name = "sérieC1ToolStripMenuItem";
            this.sérieC1ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.sérieC1ToolStripMenuItem.Text = "Série C1";
            this.sérieC1ToolStripMenuItem.Click += new System.EventHandler(this.sérieC1ToolStripMenuItem_Click);
            // 
            // sérieC20ToolStripMenuItem
            // 
            this.sérieC20ToolStripMenuItem.Name = "sérieC20ToolStripMenuItem";
            this.sérieC20ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.sérieC20ToolStripMenuItem.Text = "Série C20";
            this.sérieC20ToolStripMenuItem.Click += new System.EventHandler(this.sérieC20ToolStripMenuItem_Click);
            // 
            // sérieC50ToolStripMenuItem
            // 
            this.sérieC50ToolStripMenuItem.Name = "sérieC50ToolStripMenuItem";
            this.sérieC50ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.sérieC50ToolStripMenuItem.Text = "Série C50";
            this.sérieC50ToolStripMenuItem.Click += new System.EventHandler(this.SérieC50ToolStripMenuItem_Click);
            // 
            // sérieC60ToolStripMenuItem
            // 
            this.sérieC60ToolStripMenuItem.Name = "sérieC60ToolStripMenuItem";
            this.sérieC60ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.sérieC60ToolStripMenuItem.Text = "Série C60";
            this.sérieC60ToolStripMenuItem.Click += new System.EventHandler(this.sérieC60ToolStripMenuItem_Click);
            // 
            // lisseC100ToolStripMenuItem
            // 
            this.lisseC100ToolStripMenuItem.Name = "lisseC100ToolStripMenuItem";
            this.lisseC100ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.lisseC100ToolStripMenuItem.Text = "Série C100";
            this.lisseC100ToolStripMenuItem.Click += new System.EventHandler(this.lisseC100ToolStripMenuItem_Click);
            // 
            // sérieC500ToolStripMenuItem
            // 
            this.sérieC500ToolStripMenuItem.Name = "sérieC500ToolStripMenuItem";
            this.sérieC500ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.sérieC500ToolStripMenuItem.Text = "Série C500";
            this.sérieC500ToolStripMenuItem.Click += new System.EventHandler(this.sérieC500ToolStripMenuItem_Click);
            // 
            // sérieC550ToolStripMenuItem
            // 
            this.sérieC550ToolStripMenuItem.Name = "sérieC550ToolStripMenuItem";
            this.sérieC550ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.sérieC550ToolStripMenuItem.Text = "Série C550";
            this.sérieC550ToolStripMenuItem.Click += new System.EventHandler(this.sérieC550ToolStripMenuItem_Click);
            // 
            // sérieC600ToolStripMenuItem
            // 
            this.sérieC600ToolStripMenuItem.Name = "sérieC600ToolStripMenuItem";
            this.sérieC600ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.sérieC600ToolStripMenuItem.Text = "Série C600";
            this.sérieC600ToolStripMenuItem.Click += new System.EventHandler(this.sérieC600ToolStripMenuItem_Click);
            // 
            // sérieC700ToolStripMenuItem
            // 
            this.sérieC700ToolStripMenuItem.Name = "sérieC700ToolStripMenuItem";
            this.sérieC700ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.sérieC700ToolStripMenuItem.Text = "Série C700";
            this.sérieC700ToolStripMenuItem.Click += new System.EventHandler(this.sérieC700ToolStripMenuItem_Click);
            // 
            // sérieC750ToolStripMenuItem
            // 
            this.sérieC750ToolStripMenuItem.Name = "sérieC750ToolStripMenuItem";
            this.sérieC750ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.sérieC750ToolStripMenuItem.Text = "Série C750";
            this.sérieC750ToolStripMenuItem.Click += new System.EventHandler(this.sérieC750ToolStripMenuItem_Click);
            // 
            // cabineToolStripMenuItem
            // 
            this.cabineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FaçadeToolStripMenuItem,
            this.refendToolStripMenuItem});
            this.cabineToolStripMenuItem.Name = "cabineToolStripMenuItem";
            this.cabineToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.cabineToolStripMenuItem.Text = "Cabine";
            this.cabineToolStripMenuItem.Click += new System.EventHandler(this.cabineToolStripMenuItem_Click);
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
            // RcButton
            // 
            this.RcButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RcButton.BackColor = System.Drawing.Color.Black;
            this.RcButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RcButton.BackgroundImage")));
            this.RcButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RcButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RcButton.Location = new System.Drawing.Point(189, 59);
            this.RcButton.Name = "RcButton";
            this.RcButton.Size = new System.Drawing.Size(30, 30);
            this.RcButton.TabIndex = 16;
            this.RcButton.UseVisualStyleBackColor = false;
            this.RcButton.Click += new System.EventHandler(this.RcButton_Click);
            this.RcButton.MouseEnter += new System.EventHandler(this.RcButton_MouseEnter);
            this.RcButton.MouseLeave += new System.EventHandler(this.RefendButton_MouseLeave);
            // 
            // RbButton
            // 
            this.RbButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RbButton.BackColor = System.Drawing.Color.Black;
            this.RbButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RbButton.BackgroundImage")));
            this.RbButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RbButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RbButton.Location = new System.Drawing.Point(81, 59);
            this.RbButton.Name = "RbButton";
            this.RbButton.Size = new System.Drawing.Size(30, 30);
            this.RbButton.TabIndex = 15;
            this.RbButton.UseVisualStyleBackColor = false;
            this.RbButton.Click += new System.EventHandler(this.RbButton_Click);
            this.RbButton.MouseEnter += new System.EventHandler(this.RbButton_MouseEnter);
            this.RbButton.MouseLeave += new System.EventHandler(this.RefendButton_MouseLeave);
            // 
            // RcdButton
            // 
            this.RcdButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RcdButton.BackColor = System.Drawing.Color.Black;
            this.RcdButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RcdButton.BackgroundImage")));
            this.RcdButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RcdButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RcdButton.Location = new System.Drawing.Point(153, 59);
            this.RcdButton.Name = "RcdButton";
            this.RcdButton.Size = new System.Drawing.Size(30, 30);
            this.RcdButton.TabIndex = 14;
            this.RcdButton.UseVisualStyleBackColor = false;
            this.RcdButton.Click += new System.EventHandler(this.RcdButton_Click);
            this.RcdButton.MouseEnter += new System.EventHandler(this.RcdButton_MouseEnter);
            this.RcdButton.MouseLeave += new System.EventHandler(this.RefendButton_MouseLeave);
            // 
            // RcgButton
            // 
            this.RcgButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RcgButton.BackColor = System.Drawing.Color.Black;
            this.RcgButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RcgButton.BackgroundImage")));
            this.RcgButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RcgButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RcgButton.Location = new System.Drawing.Point(117, 59);
            this.RcgButton.Name = "RcgButton";
            this.RcgButton.Size = new System.Drawing.Size(30, 30);
            this.RcgButton.TabIndex = 13;
            this.RcgButton.UseVisualStyleBackColor = false;
            this.RcgButton.Click += new System.EventHandler(this.RcgButton_Click);
            this.RcgButton.MouseEnter += new System.EventHandler(this.RcgButton_MouseEnter);
            this.RcgButton.MouseLeave += new System.EventHandler(this.RefendButton_MouseLeave);
            // 
            // RadButton
            // 
            this.RadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RadButton.BackColor = System.Drawing.Color.Black;
            this.RadButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RadButton.BackgroundImage")));
            this.RadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RadButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RadButton.Location = new System.Drawing.Point(45, 59);
            this.RadButton.Name = "RadButton";
            this.RadButton.Size = new System.Drawing.Size(30, 30);
            this.RadButton.TabIndex = 12;
            this.RadButton.UseVisualStyleBackColor = false;
            this.RadButton.Click += new System.EventHandler(this.RadButton_Click);
            this.RadButton.MouseEnter += new System.EventHandler(this.RadButton_MouseEnter);
            this.RadButton.MouseLeave += new System.EventHandler(this.RefendButton_MouseLeave);
            // 
            // RagButton
            // 
            this.RagButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RagButton.BackColor = System.Drawing.Color.Black;
            this.RagButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RagButton.BackgroundImage")));
            this.RagButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RagButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RagButton.Location = new System.Drawing.Point(9, 59);
            this.RagButton.Name = "RagButton";
            this.RagButton.Size = new System.Drawing.Size(30, 30);
            this.RagButton.TabIndex = 11;
            this.RagButton.UseVisualStyleBackColor = false;
            this.RagButton.Click += new System.EventHandler(this.RagButton_Click);
            this.RagButton.MouseEnter += new System.EventHandler(this.RagButton_MouseEnter);
            this.RagButton.MouseLeave += new System.EventHandler(this.RefendButton_MouseLeave);
            // 
            // updatePictureBox
            // 
            this.updatePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updatePictureBox.Image = global::DcadToolBar.Properties.Resources.Red_Circle_small__svg;
            this.updatePictureBox.Location = new System.Drawing.Point(379, 0);
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
            this.UpdateButton.Location = new System.Drawing.Point(361, 3);
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
            this.ClientSize = new System.Drawing.Size(390, 97);
            this.Controls.Add(this.RcButton);
            this.Controls.Add(this.RbButton);
            this.Controls.Add(this.RcdButton);
            this.Controls.Add(this.RcgButton);
            this.Controls.Add(this.RadButton);
            this.Controls.Add(this.RagButton);
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
        private System.Windows.Forms.ToolStripMenuItem outilsKalysseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cartoucheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cotationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem façadeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bandeauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem axeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eclaterSélectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outilCoucheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attributsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherLesAttributsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masquerLesAttributsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poserAttributToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changerAttributsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chercherUnAttributToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplierUnAttributToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerAttributsToolStripMenuItem;
        private System.Windows.Forms.Button RagButton;
        private System.Windows.Forms.Button RadButton;
        private System.Windows.Forms.Button RcgButton;
        private System.Windows.Forms.Button RcdButton;
        private System.Windows.Forms.Button RbButton;
        private System.Windows.Forms.Button RcButton;
        private System.Windows.Forms.ToolStripMenuItem sérieC750ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lisseC100ToolStripMenuItem;
    }
}
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
            this.sérieB100ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sérieB150ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sérieB200ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sérieB250ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sérieB300ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sérieB350ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sérieB400ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sérieB450ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sérieB500ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sérieB550ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sérieB600ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sérieB650ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sérieB700ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sérieB750ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BancsCompactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sérieC1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sérieC20ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sérieC50ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sérieC60ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sérieC100ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sérieC125ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sérieC150ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sérieC500ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sérieC550ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.série600ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.série700ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.série750ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.BarreDePenderieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.CloakRoomToolStripMenuItem});
            this.macroMenuStrip.Location = new System.Drawing.Point(9, 28);
            this.macroMenuStrip.Name = "macroMenuStrip";
            this.macroMenuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.macroMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.macroMenuStrip.Size = new System.Drawing.Size(69, 24);
            this.macroMenuStrip.TabIndex = 9;
            this.macroMenuStrip.Text = "menuStrip2";
            // 
            // CloakRoomToolStripMenuItem
            // 
            this.CloakRoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CasiersToolStripMenuItem,
            this.CasiersInfoToolStripMenuItem,
            this.BancsToolStripMenuItem,
            this.BarreDePenderieToolStripMenuItem});
            this.CloakRoomToolStripMenuItem.Name = "CloakRoomToolStripMenuItem";
            this.CloakRoomToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.CloakRoomToolStripMenuItem.Text = "Vestiaire";
            // 
            // CasiersToolStripMenuItem
            // 
            this.CasiersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.casierDiploToolStripMenuItem,
            this.casiersBancsToolStripMenuItem,
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
            this.casierDiploToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
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
            this.casiersBancsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.casiersBancsToolStripMenuItem.Text = "Casiers Bancs";
            this.casiersBancsToolStripMenuItem.Click += new System.EventHandler(this.CasiersBancsToolStripMenuItem_Click);
            // 
            // casiersAgroToolStripMenuItem
            // 
            this.casiersAgroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.casierZToolStripMenuItem1,
            this.casierHToolStripMenuItem1});
            this.casiersAgroToolStripMenuItem.Name = "casiersAgroToolStripMenuItem";
            this.casiersAgroToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
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
            this.casierMétalliquesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.casierMétalliquesToolStripMenuItem.Text = "Casiers Métalliques";
            // 
            // armoiresCollectivesToolStripMenuItem
            // 
            this.armoiresCollectivesToolStripMenuItem.Name = "armoiresCollectivesToolStripMenuItem";
            this.armoiresCollectivesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
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
            this.BancsToolStripMenuItem.Text = "Bancs";
            // 
            // BancsBoisToolStripMenuItem
            // 
            this.BancsBoisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sérieB1ToolStripMenuItem,
            this.sérieB50ToolStripMenuItem,
            this.sérieB100ToolStripMenuItem,
            this.sérieB150ToolStripMenuItem,
            this.sérieB200ToolStripMenuItem,
            this.sérieB250ToolStripMenuItem,
            this.sérieB300ToolStripMenuItem,
            this.sérieB350ToolStripMenuItem,
            this.sérieB400ToolStripMenuItem,
            this.sérieB450ToolStripMenuItem,
            this.sérieB500ToolStripMenuItem,
            this.sérieB550ToolStripMenuItem,
            this.sérieB600ToolStripMenuItem,
            this.sérieB650ToolStripMenuItem,
            this.sérieB700ToolStripMenuItem,
            this.sérieB750ToolStripMenuItem});
            this.BancsBoisToolStripMenuItem.Name = "BancsBoisToolStripMenuItem";
            this.BancsBoisToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.BancsBoisToolStripMenuItem.Text = "Bancs Bois";
            // 
            // sérieB1ToolStripMenuItem
            // 
            this.sérieB1ToolStripMenuItem.Name = "sérieB1ToolStripMenuItem";
            this.sérieB1ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.sérieB1ToolStripMenuItem.Text = "Série B1";
            // 
            // sérieB50ToolStripMenuItem
            // 
            this.sérieB50ToolStripMenuItem.Name = "sérieB50ToolStripMenuItem";
            this.sérieB50ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.sérieB50ToolStripMenuItem.Text = "Série B50";
            // 
            // sérieB100ToolStripMenuItem
            // 
            this.sérieB100ToolStripMenuItem.Name = "sérieB100ToolStripMenuItem";
            this.sérieB100ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.sérieB100ToolStripMenuItem.Text = "Série B100";
            // 
            // sérieB150ToolStripMenuItem
            // 
            this.sérieB150ToolStripMenuItem.Name = "sérieB150ToolStripMenuItem";
            this.sérieB150ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.sérieB150ToolStripMenuItem.Text = "Série B150";
            // 
            // sérieB200ToolStripMenuItem
            // 
            this.sérieB200ToolStripMenuItem.Name = "sérieB200ToolStripMenuItem";
            this.sérieB200ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.sérieB200ToolStripMenuItem.Text = "Série B200";
            // 
            // sérieB250ToolStripMenuItem
            // 
            this.sérieB250ToolStripMenuItem.Name = "sérieB250ToolStripMenuItem";
            this.sérieB250ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.sérieB250ToolStripMenuItem.Text = "Série B250";
            // 
            // sérieB300ToolStripMenuItem
            // 
            this.sérieB300ToolStripMenuItem.Name = "sérieB300ToolStripMenuItem";
            this.sérieB300ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.sérieB300ToolStripMenuItem.Text = "Série B300";
            // 
            // sérieB350ToolStripMenuItem
            // 
            this.sérieB350ToolStripMenuItem.Name = "sérieB350ToolStripMenuItem";
            this.sérieB350ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.sérieB350ToolStripMenuItem.Text = "Série B350";
            // 
            // sérieB400ToolStripMenuItem
            // 
            this.sérieB400ToolStripMenuItem.Name = "sérieB400ToolStripMenuItem";
            this.sérieB400ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.sérieB400ToolStripMenuItem.Text = "Série B400";
            // 
            // sérieB450ToolStripMenuItem
            // 
            this.sérieB450ToolStripMenuItem.Name = "sérieB450ToolStripMenuItem";
            this.sérieB450ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.sérieB450ToolStripMenuItem.Text = "Série B450";
            // 
            // sérieB500ToolStripMenuItem
            // 
            this.sérieB500ToolStripMenuItem.Name = "sérieB500ToolStripMenuItem";
            this.sérieB500ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.sérieB500ToolStripMenuItem.Text = "Série B500";
            // 
            // sérieB550ToolStripMenuItem
            // 
            this.sérieB550ToolStripMenuItem.Name = "sérieB550ToolStripMenuItem";
            this.sérieB550ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.sérieB550ToolStripMenuItem.Text = "Série B550";
            // 
            // sérieB600ToolStripMenuItem
            // 
            this.sérieB600ToolStripMenuItem.Name = "sérieB600ToolStripMenuItem";
            this.sérieB600ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.sérieB600ToolStripMenuItem.Text = "Série B600";
            // 
            // sérieB650ToolStripMenuItem
            // 
            this.sérieB650ToolStripMenuItem.Name = "sérieB650ToolStripMenuItem";
            this.sérieB650ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.sérieB650ToolStripMenuItem.Text = "Série B650";
            // 
            // sérieB700ToolStripMenuItem
            // 
            this.sérieB700ToolStripMenuItem.Name = "sérieB700ToolStripMenuItem";
            this.sérieB700ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.sérieB700ToolStripMenuItem.Text = "Série B700";
            // 
            // sérieB750ToolStripMenuItem
            // 
            this.sérieB750ToolStripMenuItem.Name = "sérieB750ToolStripMenuItem";
            this.sérieB750ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.sérieB750ToolStripMenuItem.Text = "Série B750";
            // 
            // BancsCompactToolStripMenuItem
            // 
            this.BancsCompactToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sérieC1ToolStripMenuItem,
            this.sérieC20ToolStripMenuItem,
            this.sérieC50ToolStripMenuItem,
            this.sérieC60ToolStripMenuItem,
            this.sérieC100ToolStripMenuItem,
            this.sérieC125ToolStripMenuItem,
            this.sérieC150ToolStripMenuItem,
            this.sérieC500ToolStripMenuItem,
            this.sérieC550ToolStripMenuItem,
            this.série600ToolStripMenuItem2,
            this.série700ToolStripMenuItem2,
            this.série750ToolStripMenuItem1});
            this.BancsCompactToolStripMenuItem.Name = "BancsCompactToolStripMenuItem";
            this.BancsCompactToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.BancsCompactToolStripMenuItem.Text = "Bancs Compact";
            // 
            // sérieC1ToolStripMenuItem
            // 
            this.sérieC1ToolStripMenuItem.Name = "sérieC1ToolStripMenuItem";
            this.sérieC1ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.sérieC1ToolStripMenuItem.Text = "Série C1";
            // 
            // sérieC20ToolStripMenuItem
            // 
            this.sérieC20ToolStripMenuItem.Name = "sérieC20ToolStripMenuItem";
            this.sérieC20ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.sérieC20ToolStripMenuItem.Text = "Série C20";
            // 
            // sérieC50ToolStripMenuItem
            // 
            this.sérieC50ToolStripMenuItem.Name = "sérieC50ToolStripMenuItem";
            this.sérieC50ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.sérieC50ToolStripMenuItem.Text = "Série C50";
            // 
            // sérieC60ToolStripMenuItem
            // 
            this.sérieC60ToolStripMenuItem.Name = "sérieC60ToolStripMenuItem";
            this.sérieC60ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.sérieC60ToolStripMenuItem.Text = "Série C60";
            // 
            // sérieC100ToolStripMenuItem
            // 
            this.sérieC100ToolStripMenuItem.Name = "sérieC100ToolStripMenuItem";
            this.sérieC100ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.sérieC100ToolStripMenuItem.Text = "Série C100";
            // 
            // sérieC125ToolStripMenuItem
            // 
            this.sérieC125ToolStripMenuItem.Name = "sérieC125ToolStripMenuItem";
            this.sérieC125ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.sérieC125ToolStripMenuItem.Text = "Série C125";
            // 
            // sérieC150ToolStripMenuItem
            // 
            this.sérieC150ToolStripMenuItem.Name = "sérieC150ToolStripMenuItem";
            this.sérieC150ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.sérieC150ToolStripMenuItem.Text = "Série C150";
            // 
            // sérieC500ToolStripMenuItem
            // 
            this.sérieC500ToolStripMenuItem.Name = "sérieC500ToolStripMenuItem";
            this.sérieC500ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.sérieC500ToolStripMenuItem.Text = "Série C500";
            // 
            // sérieC550ToolStripMenuItem
            // 
            this.sérieC550ToolStripMenuItem.Name = "sérieC550ToolStripMenuItem";
            this.sérieC550ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.sérieC550ToolStripMenuItem.Text = "Série C550";
            // 
            // série600ToolStripMenuItem2
            // 
            this.série600ToolStripMenuItem2.Name = "série600ToolStripMenuItem2";
            this.série600ToolStripMenuItem2.Size = new System.Drawing.Size(128, 22);
            this.série600ToolStripMenuItem2.Text = "Série C600";
            // 
            // série700ToolStripMenuItem2
            // 
            this.série700ToolStripMenuItem2.Name = "série700ToolStripMenuItem2";
            this.série700ToolStripMenuItem2.Size = new System.Drawing.Size(128, 22);
            this.série700ToolStripMenuItem2.Text = "Série C700";
            // 
            // série750ToolStripMenuItem1
            // 
            this.série750ToolStripMenuItem1.Name = "série750ToolStripMenuItem1";
            this.série750ToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.série750ToolStripMenuItem1.Text = "Série C750";
            // 
            // BarreDePenderieToolStripMenuItem
            // 
            this.BarreDePenderieToolStripMenuItem.Name = "BarreDePenderieToolStripMenuItem";
            this.BarreDePenderieToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.BarreDePenderieToolStripMenuItem.Text = "Barre de Penderie";
            // 
            // updatePictureBox
            // 
            this.updatePictureBox.Image = global::DcadToolBar.Properties.Resources.Red_Circle_small__svg;
            this.updatePictureBox.Location = new System.Drawing.Point(289, 1);
            this.updatePictureBox.Name = "updatePictureBox";
            this.updatePictureBox.Size = new System.Drawing.Size(10, 10);
            this.updatePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.updatePictureBox.TabIndex = 10;
            this.updatePictureBox.TabStop = false;
            this.updatePictureBox.Visible = false;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateButton.Image = global::DcadToolBar.Properties.Resources.green_refresh;
            this.UpdateButton.Location = new System.Drawing.Point(272, 4);
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
        private System.Windows.Forms.ToolStripMenuItem sérieB1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sérieB50ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sérieB100ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sérieB150ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sérieB200ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sérieB250ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sérieB300ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sérieB350ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sérieB400ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sérieB450ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sérieB500ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sérieB550ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sérieB600ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sérieB650ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sérieB700ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sérieB750ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BancsCompactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sérieC1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sérieC20ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sérieC50ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sérieC60ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sérieC125ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sérieC500ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sérieC550ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem série600ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem série700ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem série750ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sérieC100ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sérieC150ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BarreDePenderieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem casiersBancsToolStripMenuItem;
        private System.Windows.Forms.PictureBox updatePictureBox;
    }
}
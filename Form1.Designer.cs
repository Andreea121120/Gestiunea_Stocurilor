
namespace Gestiunea_stocurilor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.produseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaProduseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaProduseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiuneProduseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depoziteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repartizareProduseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receptieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avizExpeditieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bonTransferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bonConusmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parteneriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapoarteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balantaStocurilorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intrariIesiriProdusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.fisaDeMagazieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produseToolStripMenuItem,
            this.gestiuneProduseToolStripMenuItem,
            this.documenteToolStripMenuItem,
            this.parteneriToolStripMenuItem,
            this.rapoarteToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1212, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // produseToolStripMenuItem
            // 
            this.produseToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.produseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaProduseToolStripMenuItem,
            this.listaProduseToolStripMenuItem});
            this.produseToolStripMenuItem.Name = "produseToolStripMenuItem";
            this.produseToolStripMenuItem.Size = new System.Drawing.Size(98, 26);
            this.produseToolStripMenuItem.Text = "Produse";
            // 
            // adaugaProduseToolStripMenuItem
            // 
            this.adaugaProduseToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.adaugaProduseToolStripMenuItem.Name = "adaugaProduseToolStripMenuItem";
            this.adaugaProduseToolStripMenuItem.Size = new System.Drawing.Size(255, 34);
            this.adaugaProduseToolStripMenuItem.Text = "Adauga produse";
            this.adaugaProduseToolStripMenuItem.Click += new System.EventHandler(this.adaugaProduseToolStripMenuItem_Click);
            // 
            // listaProduseToolStripMenuItem
            // 
            this.listaProduseToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listaProduseToolStripMenuItem.Name = "listaProduseToolStripMenuItem";
            this.listaProduseToolStripMenuItem.Size = new System.Drawing.Size(255, 34);
            this.listaProduseToolStripMenuItem.Text = "Lista produse";
            this.listaProduseToolStripMenuItem.Click += new System.EventHandler(this.listaProduseToolStripMenuItem_Click);
            // 
            // gestiuneProduseToolStripMenuItem
            // 
            this.gestiuneProduseToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.gestiuneProduseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarToolStripMenuItem,
            this.depoziteToolStripMenuItem,
            this.receptieToolStripMenuItem});
            this.gestiuneProduseToolStripMenuItem.Name = "gestiuneProduseToolStripMenuItem";
            this.gestiuneProduseToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.gestiuneProduseToolStripMenuItem.Text = "Gestiune stocuri";
            this.gestiuneProduseToolStripMenuItem.Click += new System.EventHandler(this.gestiuneProduseToolStripMenuItem_Click);
            // 
            // gestionarToolStripMenuItem
            // 
            this.gestionarToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.gestionarToolStripMenuItem.Name = "gestionarToolStripMenuItem";
            this.gestionarToolStripMenuItem.Size = new System.Drawing.Size(197, 34);
            this.gestionarToolStripMenuItem.Text = "Gestionar";
            this.gestionarToolStripMenuItem.Click += new System.EventHandler(this.gestionarToolStripMenuItem_Click);
            // 
            // depoziteToolStripMenuItem
            // 
            this.depoziteToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.depoziteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repartizareProduseToolStripMenuItem});
            this.depoziteToolStripMenuItem.Name = "depoziteToolStripMenuItem";
            this.depoziteToolStripMenuItem.Size = new System.Drawing.Size(197, 34);
            this.depoziteToolStripMenuItem.Text = "Depozite";
            this.depoziteToolStripMenuItem.Click += new System.EventHandler(this.depoziteToolStripMenuItem_Click);
            // 
            // repartizareProduseToolStripMenuItem
            // 
            this.repartizareProduseToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.repartizareProduseToolStripMenuItem.Name = "repartizareProduseToolStripMenuItem";
            this.repartizareProduseToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            this.repartizareProduseToolStripMenuItem.Text = "Repartizare produs";
            this.repartizareProduseToolStripMenuItem.Click += new System.EventHandler(this.repartizareProduseToolStripMenuItem_Click);
            // 
            // receptieToolStripMenuItem
            // 
            this.receptieToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.receptieToolStripMenuItem.Name = "receptieToolStripMenuItem";
            this.receptieToolStripMenuItem.Size = new System.Drawing.Size(197, 34);
            this.receptieToolStripMenuItem.Text = "Receptie";
            this.receptieToolStripMenuItem.Click += new System.EventHandler(this.receptieToolStripMenuItem_Click);
            // 
            // documenteToolStripMenuItem
            // 
            this.documenteToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.documenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avizExpeditieToolStripMenuItem,
            this.bonTransferToolStripMenuItem,
            this.bonConusmToolStripMenuItem,
            this.facturaToolStripMenuItem});
            this.documenteToolStripMenuItem.Name = "documenteToolStripMenuItem";
            this.documenteToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.documenteToolStripMenuItem.Text = "Documente";
            // 
            // avizExpeditieToolStripMenuItem
            // 
            this.avizExpeditieToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.avizExpeditieToolStripMenuItem.Name = "avizExpeditieToolStripMenuItem";
            this.avizExpeditieToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.avizExpeditieToolStripMenuItem.Text = "Aviz expeditie";
            this.avizExpeditieToolStripMenuItem.Click += new System.EventHandler(this.avizExpeditieToolStripMenuItem_Click);
            // 
            // bonTransferToolStripMenuItem
            // 
            this.bonTransferToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.bonTransferToolStripMenuItem.Name = "bonTransferToolStripMenuItem";
            this.bonTransferToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.bonTransferToolStripMenuItem.Text = "Bon transfer";
            this.bonTransferToolStripMenuItem.Click += new System.EventHandler(this.bonTransferToolStripMenuItem_Click);
            // 
            // bonConusmToolStripMenuItem
            // 
            this.bonConusmToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.bonConusmToolStripMenuItem.Name = "bonConusmToolStripMenuItem";
            this.bonConusmToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.bonConusmToolStripMenuItem.Text = "Bon conusm";
            this.bonConusmToolStripMenuItem.Click += new System.EventHandler(this.bonConusmToolStripMenuItem_Click);
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.facturaToolStripMenuItem.Text = "Factura";
            this.facturaToolStripMenuItem.Click += new System.EventHandler(this.facturaToolStripMenuItem_Click);
            // 
            // parteneriToolStripMenuItem
            // 
            this.parteneriToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.parteneriToolStripMenuItem.Name = "parteneriToolStripMenuItem";
            this.parteneriToolStripMenuItem.Size = new System.Drawing.Size(109, 26);
            this.parteneriToolStripMenuItem.Text = "Parteneri";
            this.parteneriToolStripMenuItem.Click += new System.EventHandler(this.parteneriToolStripMenuItem_Click);
            // 
            // rapoarteToolStripMenuItem
            // 
            this.rapoarteToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.rapoarteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.balantaStocurilorToolStripMenuItem,
            this.cMPToolStripMenuItem,
            this.intrariIesiriProdusToolStripMenuItem,
            this.fisaDeMagazieToolStripMenuItem});
            this.rapoarteToolStripMenuItem.Name = "rapoarteToolStripMenuItem";
            this.rapoarteToolStripMenuItem.Size = new System.Drawing.Size(109, 26);
            this.rapoarteToolStripMenuItem.Text = "Rapoarte";
            // 
            // balantaStocurilorToolStripMenuItem
            // 
            this.balantaStocurilorToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.balantaStocurilorToolStripMenuItem.Name = "balantaStocurilorToolStripMenuItem";
            this.balantaStocurilorToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.balantaStocurilorToolStripMenuItem.Text = "Balanta stocurilor";
            this.balantaStocurilorToolStripMenuItem.Click += new System.EventHandler(this.balantaStocurilorToolStripMenuItem_Click);
            // 
            // cMPToolStripMenuItem
            // 
            this.cMPToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cMPToolStripMenuItem.Name = "cMPToolStripMenuItem";
            this.cMPToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.cMPToolStripMenuItem.Text = "Stoc curent";
            this.cMPToolStripMenuItem.Click += new System.EventHandler(this.cMPToolStripMenuItem_Click);
            // 
            // intrariIesiriProdusToolStripMenuItem
            // 
            this.intrariIesiriProdusToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.intrariIesiriProdusToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.intrariIesiriProdusToolStripMenuItem.Name = "intrariIesiriProdusToolStripMenuItem";
            this.intrariIesiriProdusToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.intrariIesiriProdusToolStripMenuItem.Text = "Miscari produs";
            this.intrariIesiriProdusToolStripMenuItem.Click += new System.EventHandler(this.intrariIesiriProdusToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(319, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(643, 61);
            this.label1.TabIndex = 2;
            this.label1.Text = "| GESTIUNEA STOCURILOR";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(143, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 160);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fisaDeMagazieToolStripMenuItem
            // 
            this.fisaDeMagazieToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.fisaDeMagazieToolStripMenuItem.Name = "fisaDeMagazieToolStripMenuItem";
            this.fisaDeMagazieToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.fisaDeMagazieToolStripMenuItem.Text = "Fisa de magazie";
            this.fisaDeMagazieToolStripMenuItem.Click += new System.EventHandler(this.fisaDeMagazieToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1212, 590);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Pagina principala";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem produseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaProduseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaProduseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiuneProduseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depoziteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receptieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avizExpeditieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bonTransferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bonConusmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parteneriToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem rapoarteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balantaStocurilorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cMPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repartizareProduseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intrariIesiriProdusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fisaDeMagazieToolStripMenuItem;
    }
}


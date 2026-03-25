
namespace Gestiunea_stocurilor
{
    partial class frmDepozit
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codLabel;
            System.Windows.Forms.Label denumireLabel;
            System.Windows.Forms.Label adresaLabel;
            System.Windows.Forms.Label idGestionarLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepozit));
            this.depozitBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.depozitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.depozitBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codTextBox = new System.Windows.Forms.TextBox();
            this.denumireTextBox = new System.Windows.Forms.TextBox();
            this.adresaTextBox = new System.Windows.Forms.TextBox();
            this.idGestionarComboBox = new System.Windows.Forms.ComboBox();
            this.gestionarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            codLabel = new System.Windows.Forms.Label();
            denumireLabel = new System.Windows.Forms.Label();
            adresaLabel = new System.Windows.Forms.Label();
            idGestionarLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.depozitBindingNavigator)).BeginInit();
            this.depozitBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depozitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codLabel
            // 
            codLabel.AutoSize = true;
            codLabel.Font = new System.Drawing.Font("Verdana", 8F);
            codLabel.Location = new System.Drawing.Point(69, 101);
            codLabel.Name = "codLabel";
            codLabel.Size = new System.Drawing.Size(46, 18);
            codLabel.TabIndex = 1;
            codLabel.Text = "Cod:";
            // 
            // denumireLabel
            // 
            denumireLabel.AutoSize = true;
            denumireLabel.Font = new System.Drawing.Font("Verdana", 8F);
            denumireLabel.Location = new System.Drawing.Point(69, 169);
            denumireLabel.Name = "denumireLabel";
            denumireLabel.Size = new System.Drawing.Size(93, 18);
            denumireLabel.TabIndex = 3;
            denumireLabel.Text = "Denumire:";
            // 
            // adresaLabel
            // 
            adresaLabel.AutoSize = true;
            adresaLabel.Font = new System.Drawing.Font("Verdana", 8F);
            adresaLabel.Location = new System.Drawing.Point(69, 227);
            adresaLabel.Name = "adresaLabel";
            adresaLabel.Size = new System.Drawing.Size(71, 18);
            adresaLabel.TabIndex = 5;
            adresaLabel.Text = "Adresa:";
            // 
            // idGestionarLabel
            // 
            idGestionarLabel.AutoSize = true;
            idGestionarLabel.Font = new System.Drawing.Font("Verdana", 8F);
            idGestionarLabel.Location = new System.Drawing.Point(69, 297);
            idGestionarLabel.Name = "idGestionarLabel";
            idGestionarLabel.Size = new System.Drawing.Size(194, 18);
            idGestionarLabel.TabIndex = 7;
            idGestionarLabel.Text = "Gestionar responsabil:";
            // 
            // depozitBindingNavigator
            // 
            this.depozitBindingNavigator.AddNewItem = null;
            this.depozitBindingNavigator.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.depozitBindingNavigator.BindingSource = this.depozitBindingSource;
            this.depozitBindingNavigator.CountItem = null;
            this.depozitBindingNavigator.DeleteItem = null;
            this.depozitBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.depozitBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.depozitBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.newToolStripButton,
            this.toolStripButton2,
            this.depozitBindingNavigatorSaveItem});
            this.depozitBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.depozitBindingNavigator.MoveFirstItem = null;
            this.depozitBindingNavigator.MoveLastItem = null;
            this.depozitBindingNavigator.MoveNextItem = null;
            this.depozitBindingNavigator.MovePreviousItem = null;
            this.depozitBindingNavigator.Name = "depozitBindingNavigator";
            this.depozitBindingNavigator.PositionItem = null;
            this.depozitBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.depozitBindingNavigator.Size = new System.Drawing.Size(766, 33);
            this.depozitBindingNavigator.TabIndex = 0;
            this.depozitBindingNavigator.Text = "bindingNavigator1";
            // 
            // depozitBindingSource
            // 
            this.depozitBindingSource.DataSource = typeof(Gestiunea_stocurilor.Depozit);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton1.Text = "Adauga produs gestiune";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(34, 28);
            this.newToolStripButton.Text = "Lista depozite";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton2.Text = "Editeaza depozit";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // depozitBindingNavigatorSaveItem
            // 
            this.depozitBindingNavigatorSaveItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.depozitBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.depozitBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("depozitBindingNavigatorSaveItem.Image")));
            this.depozitBindingNavigatorSaveItem.Name = "depozitBindingNavigatorSaveItem";
            this.depozitBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.depozitBindingNavigatorSaveItem.Text = "Salvare";
            this.depozitBindingNavigatorSaveItem.Click += new System.EventHandler(this.depozitBindingNavigatorSaveItem_Click);
            // 
            // codTextBox
            // 
            this.codTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.depozitBindingSource, "Cod", true));
            this.codTextBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.codTextBox.Location = new System.Drawing.Point(288, 101);
            this.codTextBox.Name = "codTextBox";
            this.codTextBox.Size = new System.Drawing.Size(384, 27);
            this.codTextBox.TabIndex = 2;
            // 
            // denumireTextBox
            // 
            this.denumireTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.depozitBindingSource, "Denumire", true));
            this.denumireTextBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.denumireTextBox.Location = new System.Drawing.Point(288, 163);
            this.denumireTextBox.Name = "denumireTextBox";
            this.denumireTextBox.Size = new System.Drawing.Size(384, 27);
            this.denumireTextBox.TabIndex = 4;
            // 
            // adresaTextBox
            // 
            this.adresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.depozitBindingSource, "Adresa", true));
            this.adresaTextBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.adresaTextBox.Location = new System.Drawing.Point(288, 221);
            this.adresaTextBox.Name = "adresaTextBox";
            this.adresaTextBox.Size = new System.Drawing.Size(384, 27);
            this.adresaTextBox.TabIndex = 6;
            // 
            // idGestionarComboBox
            // 
            this.idGestionarComboBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.idGestionarComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.depozitBindingSource, "IdGestionar", true));
            this.idGestionarComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.depozitBindingSource, "IdGestionar", true));
            this.idGestionarComboBox.DataSource = this.gestionarBindingSource;
            this.idGestionarComboBox.DisplayMember = "Nume";
            this.idGestionarComboBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.idGestionarComboBox.FormattingEnabled = true;
            this.idGestionarComboBox.Location = new System.Drawing.Point(288, 289);
            this.idGestionarComboBox.Name = "idGestionarComboBox";
            this.idGestionarComboBox.Size = new System.Drawing.Size(390, 26);
            this.idGestionarComboBox.TabIndex = 8;
            this.idGestionarComboBox.ValueMember = "Id";
            // 
            // gestionarBindingSource
            // 
            this.gestionarBindingSource.DataSource = typeof(Gestiunea_stocurilor.Gestionar);
            // 
            // frmDepozit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(766, 415);
            this.Controls.Add(idGestionarLabel);
            this.Controls.Add(this.idGestionarComboBox);
            this.Controls.Add(adresaLabel);
            this.Controls.Add(this.adresaTextBox);
            this.Controls.Add(denumireLabel);
            this.Controls.Add(this.denumireTextBox);
            this.Controls.Add(codLabel);
            this.Controls.Add(this.codTextBox);
            this.Controls.Add(this.depozitBindingNavigator);
            this.Name = "frmDepozit";
            this.Text = "Depozit";
            this.Load += new System.EventHandler(this.frmDepozit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.depozitBindingNavigator)).EndInit();
            this.depozitBindingNavigator.ResumeLayout(false);
            this.depozitBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depozitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource depozitBindingSource;
        private System.Windows.Forms.BindingNavigator depozitBindingNavigator;
        private System.Windows.Forms.ToolStripButton depozitBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox codTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.TextBox denumireTextBox;
        private System.Windows.Forms.TextBox adresaTextBox;
        private System.Windows.Forms.ComboBox idGestionarComboBox;
        private System.Windows.Forms.BindingSource gestionarBindingSource;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}
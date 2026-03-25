
namespace Gestiunea_stocurilor
{
    partial class frmAvizExped
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
            System.Windows.Forms.Label idDepozitLabel;
            System.Windows.Forms.Label numarLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label idFacturaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAvizExped));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.avizExpeditieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avizExpeditieBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.avizExpeditieBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idDepozitComboBox = new System.Windows.Forms.ComboBox();
            this.depozitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numarTextBox = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.produsExpeditieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produsExpeditieDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.produsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Cantitate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFacturaComboBox = new System.Windows.Forms.ComboBox();
            this.facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            idDepozitLabel = new System.Windows.Forms.Label();
            numarLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            idFacturaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.avizExpeditieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avizExpeditieBindingNavigator)).BeginInit();
            this.avizExpeditieBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depozitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsExpeditieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsExpeditieDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idDepozitLabel
            // 
            idDepozitLabel.AutoSize = true;
            idDepozitLabel.Font = new System.Drawing.Font("Verdana", 8F);
            idDepozitLabel.Location = new System.Drawing.Point(550, 89);
            idDepozitLabel.Name = "idDepozitLabel";
            idDepozitLabel.Size = new System.Drawing.Size(78, 18);
            idDepozitLabel.TabIndex = 1;
            idDepozitLabel.Text = "Depozit:";
            // 
            // numarLabel
            // 
            numarLabel.AutoSize = true;
            numarLabel.Font = new System.Drawing.Font("Verdana", 8F);
            numarLabel.Location = new System.Drawing.Point(45, 89);
            numarLabel.Name = "numarLabel";
            numarLabel.Size = new System.Drawing.Size(68, 18);
            numarLabel.TabIndex = 3;
            numarLabel.Text = "Numar:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Font = new System.Drawing.Font("Verdana", 8F);
            dataLabel.Location = new System.Drawing.Point(45, 170);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(54, 18);
            dataLabel.TabIndex = 5;
            dataLabel.Text = "Data:";
            // 
            // idFacturaLabel
            // 
            idFacturaLabel.AutoSize = true;
            idFacturaLabel.Font = new System.Drawing.Font("Verdana", 8F);
            idFacturaLabel.Location = new System.Drawing.Point(550, 170);
            idFacturaLabel.Name = "idFacturaLabel";
            idFacturaLabel.Size = new System.Drawing.Size(74, 18);
            idFacturaLabel.TabIndex = 9;
            idFacturaLabel.Text = "Factura:";
            // 
            // avizExpeditieBindingSource
            // 
            this.avizExpeditieBindingSource.DataSource = typeof(Gestiunea_stocurilor.AvizExpeditie);
            // 
            // avizExpeditieBindingNavigator
            // 
            this.avizExpeditieBindingNavigator.AddNewItem = null;
            this.avizExpeditieBindingNavigator.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.avizExpeditieBindingNavigator.BindingSource = this.avizExpeditieBindingSource;
            this.avizExpeditieBindingNavigator.CountItem = null;
            this.avizExpeditieBindingNavigator.DeleteItem = null;
            this.avizExpeditieBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.avizExpeditieBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.avizExpeditieBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton2,
            this.newToolStripButton,
            this.toolStripButton1,
            this.avizExpeditieBindingNavigatorSaveItem});
            this.avizExpeditieBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.avizExpeditieBindingNavigator.MoveFirstItem = null;
            this.avizExpeditieBindingNavigator.MoveLastItem = null;
            this.avizExpeditieBindingNavigator.MoveNextItem = null;
            this.avizExpeditieBindingNavigator.MovePreviousItem = null;
            this.avizExpeditieBindingNavigator.Name = "avizExpeditieBindingNavigator";
            this.avizExpeditieBindingNavigator.PositionItem = null;
            this.avizExpeditieBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.avizExpeditieBindingNavigator.Size = new System.Drawing.Size(1088, 33);
            this.avizExpeditieBindingNavigator.TabIndex = 0;
            this.avizExpeditieBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton3.Text = "Stoc produs";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton2.Text = "Facturi";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(34, 28);
            this.newToolStripButton.Text = "Lista Avize Expeditie";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton1.Text = "Editeaza aviz";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // avizExpeditieBindingNavigatorSaveItem
            // 
            this.avizExpeditieBindingNavigatorSaveItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.avizExpeditieBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.avizExpeditieBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("avizExpeditieBindingNavigatorSaveItem.Image")));
            this.avizExpeditieBindingNavigatorSaveItem.Name = "avizExpeditieBindingNavigatorSaveItem";
            this.avizExpeditieBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.avizExpeditieBindingNavigatorSaveItem.Text = "Salveaza";
            this.avizExpeditieBindingNavigatorSaveItem.Click += new System.EventHandler(this.avizExpeditieBindingNavigatorSaveItem_Click);
            // 
            // idDepozitComboBox
            // 
            this.idDepozitComboBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.idDepozitComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avizExpeditieBindingSource, "IdDepozit", true));
            this.idDepozitComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.avizExpeditieBindingSource, "IdDepozit", true));
            this.idDepozitComboBox.DataSource = this.depozitBindingSource;
            this.idDepozitComboBox.DisplayMember = "Denumire";
            this.idDepozitComboBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.idDepozitComboBox.FormattingEnabled = true;
            this.idDepozitComboBox.Location = new System.Drawing.Point(662, 81);
            this.idDepozitComboBox.Name = "idDepozitComboBox";
            this.idDepozitComboBox.Size = new System.Drawing.Size(349, 26);
            this.idDepozitComboBox.TabIndex = 2;
            this.idDepozitComboBox.ValueMember = "Id";
            this.idDepozitComboBox.SelectedIndexChanged += new System.EventHandler(this.idDepozitComboBox_SelectedIndexChanged);
            // 
            // depozitBindingSource
            // 
            this.depozitBindingSource.DataSource = typeof(Gestiunea_stocurilor.Depozit);
            // 
            // numarTextBox
            // 
            this.numarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avizExpeditieBindingSource, "Numar", true));
            this.numarTextBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.numarTextBox.Location = new System.Drawing.Point(157, 86);
            this.numarTextBox.Name = "numarTextBox";
            this.numarTextBox.Size = new System.Drawing.Size(327, 27);
            this.numarTextBox.TabIndex = 4;
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.avizExpeditieBindingSource, "Data", true));
            this.dataDateTimePicker.Font = new System.Drawing.Font("Verdana", 8F);
            this.dataDateTimePicker.Location = new System.Drawing.Point(157, 165);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(327, 27);
            this.dataDateTimePicker.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(45, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Continut aviz:";
            // 
            // produsExpeditieBindingSource
            // 
            this.produsExpeditieBindingSource.DataSource = typeof(Gestiunea_stocurilor.ProdusExpeditie);
            // 
            // produsExpeditieDataGridView
            // 
            this.produsExpeditieDataGridView.AutoGenerateColumns = false;
            this.produsExpeditieDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.produsExpeditieDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.produsExpeditieDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.produsExpeditieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produsExpeditieDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Cantitate});
            this.produsExpeditieDataGridView.DataSource = this.produsExpeditieBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.produsExpeditieDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.produsExpeditieDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.produsExpeditieDataGridView.Location = new System.Drawing.Point(49, 346);
            this.produsExpeditieDataGridView.Name = "produsExpeditieDataGridView";
            this.produsExpeditieDataGridView.RowHeadersWidth = 62;
            this.produsExpeditieDataGridView.RowTemplate.Height = 28;
            this.produsExpeditieDataGridView.Size = new System.Drawing.Size(962, 220);
            this.produsExpeditieDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdAvizExpeditie";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdAvizExpeditie";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdProdus";
            this.dataGridViewTextBoxColumn3.DataSource = this.produsBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Denumire";
            this.dataGridViewTextBoxColumn3.DisplayStyleForCurrentCellOnly = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Produs";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "Id";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // produsBindingSource
            // 
            this.produsBindingSource.DataSource = typeof(Gestiunea_stocurilor.Produs);
            // 
            // Cantitate
            // 
            this.Cantitate.DataPropertyName = "Cantitate";
            this.Cantitate.HeaderText = "Cantitate";
            this.Cantitate.MinimumWidth = 8;
            this.Cantitate.Name = "Cantitate";
            this.Cantitate.Width = 150;
            // 
            // idFacturaComboBox
            // 
            this.idFacturaComboBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.idFacturaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avizExpeditieBindingSource, "IdFactura", true));
            this.idFacturaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.avizExpeditieBindingSource, "IdFactura", true));
            this.idFacturaComboBox.DataSource = this.facturaBindingSource;
            this.idFacturaComboBox.DisplayMember = "Numar";
            this.idFacturaComboBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.idFacturaComboBox.FormattingEnabled = true;
            this.idFacturaComboBox.Location = new System.Drawing.Point(662, 162);
            this.idFacturaComboBox.Name = "idFacturaComboBox";
            this.idFacturaComboBox.Size = new System.Drawing.Size(349, 26);
            this.idFacturaComboBox.TabIndex = 10;
            this.idFacturaComboBox.ValueMember = "Id";
            this.idFacturaComboBox.SelectedIndexChanged += new System.EventHandler(this.idFacturaComboBox_SelectedIndexChanged);
            // 
            // facturaBindingSource
            // 
            this.facturaBindingSource.DataSource = typeof(Gestiunea_stocurilor.Factura);
            // 
            // frmAvizExped
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1088, 639);
            this.Controls.Add(idFacturaLabel);
            this.Controls.Add(this.idFacturaComboBox);
            this.Controls.Add(this.produsExpeditieDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(numarLabel);
            this.Controls.Add(this.numarTextBox);
            this.Controls.Add(idDepozitLabel);
            this.Controls.Add(this.idDepozitComboBox);
            this.Controls.Add(this.avizExpeditieBindingNavigator);
            this.Name = "frmAvizExped";
            this.Text = "Aviz expediere";
            this.Load += new System.EventHandler(this.frmAvizExped_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avizExpeditieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avizExpeditieBindingNavigator)).EndInit();
            this.avizExpeditieBindingNavigator.ResumeLayout(false);
            this.avizExpeditieBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depozitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsExpeditieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsExpeditieDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource avizExpeditieBindingSource;
        private System.Windows.Forms.BindingNavigator avizExpeditieBindingNavigator;
        private System.Windows.Forms.ToolStripButton avizExpeditieBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox idDepozitComboBox;
        private System.Windows.Forms.TextBox numarTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource produsExpeditieBindingSource;
        private System.Windows.Forms.DataGridView produsExpeditieDataGridView;
        private System.Windows.Forms.BindingSource produsBindingSource;
        private System.Windows.Forms.BindingSource depozitBindingSource;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ComboBox idFacturaComboBox;
        private System.Windows.Forms.BindingSource facturaBindingSource;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantitate;
    }
}
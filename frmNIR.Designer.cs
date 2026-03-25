
namespace Gestiunea_stocurilor
{
    partial class frmNIR
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
            System.Windows.Forms.Label idFacturaLabel;
            System.Windows.Forms.Label numarLabel;
            System.Windows.Forms.Label dataLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNIR));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nIRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nIRBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.nIRBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idDepozitComboBox = new System.Windows.Forms.ComboBox();
            this.depozitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idFacturaComboBox = new System.Windows.Forms.ComboBox();
            this.facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numarTextBox = new System.Windows.Forms.TextBox();
            this.continutNIRDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.produsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Cantitate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.continutNIRBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            idDepozitLabel = new System.Windows.Forms.Label();
            idFacturaLabel = new System.Windows.Forms.Label();
            numarLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nIRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIRBindingNavigator)).BeginInit();
            this.nIRBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depozitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.continutNIRDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.continutNIRBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // idDepozitLabel
            // 
            idDepozitLabel.AutoSize = true;
            idDepozitLabel.Font = new System.Drawing.Font("Verdana", 8F);
            idDepozitLabel.Location = new System.Drawing.Point(628, 98);
            idDepozitLabel.Name = "idDepozitLabel";
            idDepozitLabel.Size = new System.Drawing.Size(78, 18);
            idDepozitLabel.TabIndex = 1;
            idDepozitLabel.Text = "Depozit:";
            // 
            // idFacturaLabel
            // 
            idFacturaLabel.AutoSize = true;
            idFacturaLabel.Font = new System.Drawing.Font("Verdana", 8F);
            idFacturaLabel.Location = new System.Drawing.Point(628, 183);
            idFacturaLabel.Name = "idFacturaLabel";
            idFacturaLabel.Size = new System.Drawing.Size(74, 18);
            idFacturaLabel.TabIndex = 3;
            idFacturaLabel.Text = "Factura:";
            // 
            // numarLabel
            // 
            numarLabel.AutoSize = true;
            numarLabel.Font = new System.Drawing.Font("Verdana", 8F);
            numarLabel.Location = new System.Drawing.Point(45, 98);
            numarLabel.Name = "numarLabel";
            numarLabel.Size = new System.Drawing.Size(68, 18);
            numarLabel.TabIndex = 5;
            numarLabel.Text = "Numar:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Font = new System.Drawing.Font("Verdana", 8F);
            dataLabel.Location = new System.Drawing.Point(45, 183);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(54, 18);
            dataLabel.TabIndex = 12;
            dataLabel.Text = "Data:";
            // 
            // nIRBindingSource
            // 
            this.nIRBindingSource.DataSource = typeof(Gestiunea_stocurilor.NIR);
            // 
            // nIRBindingNavigator
            // 
            this.nIRBindingNavigator.AddNewItem = null;
            this.nIRBindingNavigator.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nIRBindingNavigator.BindingSource = this.nIRBindingSource;
            this.nIRBindingNavigator.CountItem = null;
            this.nIRBindingNavigator.DeleteItem = null;
            this.nIRBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.nIRBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.nIRBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripButton,
            this.toolStripButton3,
            this.toolStripButton1,
            this.newToolStripButton,
            this.toolStripButton2,
            this.nIRBindingNavigatorSaveItem});
            this.nIRBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.nIRBindingNavigator.MoveFirstItem = null;
            this.nIRBindingNavigator.MoveLastItem = null;
            this.nIRBindingNavigator.MoveNextItem = null;
            this.nIRBindingNavigator.MovePreviousItem = null;
            this.nIRBindingNavigator.Name = "nIRBindingNavigator";
            this.nIRBindingNavigator.PositionItem = null;
            this.nIRBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.nIRBindingNavigator.Size = new System.Drawing.Size(1212, 33);
            this.nIRBindingNavigator.TabIndex = 0;
            this.nIRBindingNavigator.Text = "bindingNavigator1";
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(34, 28);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton3.Text = "Facturi";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton1.Text = "Adauga produs";
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
            this.newToolStripButton.Text = "Lista NIR";
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
            this.toolStripButton2.Text = "Editare NIR";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // nIRBindingNavigatorSaveItem
            // 
            this.nIRBindingNavigatorSaveItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.nIRBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nIRBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("nIRBindingNavigatorSaveItem.Image")));
            this.nIRBindingNavigatorSaveItem.Name = "nIRBindingNavigatorSaveItem";
            this.nIRBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.nIRBindingNavigatorSaveItem.Text = "Salveaza";
            this.nIRBindingNavigatorSaveItem.Click += new System.EventHandler(this.nIRBindingNavigatorSaveItem_Click);
            // 
            // idDepozitComboBox
            // 
            this.idDepozitComboBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.idDepozitComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nIRBindingSource, "IdDepozit", true));
            this.idDepozitComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.nIRBindingSource, "IdDepozit", true));
            this.idDepozitComboBox.DataSource = this.depozitBindingSource;
            this.idDepozitComboBox.DisplayMember = "Denumire";
            this.idDepozitComboBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.idDepozitComboBox.FormattingEnabled = true;
            this.idDepozitComboBox.Location = new System.Drawing.Point(804, 95);
            this.idDepozitComboBox.Name = "idDepozitComboBox";
            this.idDepozitComboBox.Size = new System.Drawing.Size(335, 26);
            this.idDepozitComboBox.TabIndex = 2;
            this.idDepozitComboBox.ValueMember = "Id";
            this.idDepozitComboBox.SelectedIndexChanged += new System.EventHandler(this.idDepozitComboBox_SelectedIndexChanged);
            // 
            // depozitBindingSource
            // 
            this.depozitBindingSource.DataSource = typeof(Gestiunea_stocurilor.Depozit);
            // 
            // idFacturaComboBox
            // 
            this.idFacturaComboBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.idFacturaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nIRBindingSource, "IdFactura", true));
            this.idFacturaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.nIRBindingSource, "IdFactura", true));
            this.idFacturaComboBox.DataSource = this.facturaBindingSource;
            this.idFacturaComboBox.DisplayMember = "Numar";
            this.idFacturaComboBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.idFacturaComboBox.FormattingEnabled = true;
            this.idFacturaComboBox.Location = new System.Drawing.Point(804, 180);
            this.idFacturaComboBox.Name = "idFacturaComboBox";
            this.idFacturaComboBox.Size = new System.Drawing.Size(335, 26);
            this.idFacturaComboBox.TabIndex = 4;
            this.idFacturaComboBox.ValueMember = "Id";
            this.idFacturaComboBox.SelectedIndexChanged += new System.EventHandler(this.idFacturaComboBox_SelectedIndexChanged);
            // 
            // facturaBindingSource
            // 
            this.facturaBindingSource.DataSource = typeof(Gestiunea_stocurilor.Factura);
            // 
            // numarTextBox
            // 
            this.numarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nIRBindingSource, "Numar", true));
            this.numarTextBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.numarTextBox.Location = new System.Drawing.Point(221, 95);
            this.numarTextBox.Name = "numarTextBox";
            this.numarTextBox.Size = new System.Drawing.Size(335, 27);
            this.numarTextBox.TabIndex = 6;
            // 
            // continutNIRDataGridView
            // 
            this.continutNIRDataGridView.AutoGenerateColumns = false;
            this.continutNIRDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.continutNIRDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.continutNIRDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.continutNIRDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.continutNIRDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Cantitate});
            this.continutNIRDataGridView.DataSource = this.continutNIRBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.continutNIRDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.continutNIRDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.continutNIRDataGridView.Location = new System.Drawing.Point(49, 335);
            this.continutNIRDataGridView.Name = "continutNIRDataGridView";
            this.continutNIRDataGridView.RowHeadersWidth = 62;
            this.continutNIRDataGridView.RowTemplate.Height = 28;
            this.continutNIRDataGridView.Size = new System.Drawing.Size(1120, 313);
            this.continutNIRDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdNIR";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdNIR";
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
            // continutNIRBindingSource1
            // 
            this.continutNIRBindingSource1.DataSource = typeof(Gestiunea_stocurilor.ContinutNIR);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(49, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Continut NIR:";
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.nIRBindingSource, "Data", true));
            this.dataDateTimePicker.Font = new System.Drawing.Font("Verdana", 8F);
            this.dataDateTimePicker.Location = new System.Drawing.Point(221, 180);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(335, 27);
            this.dataDateTimePicker.TabIndex = 13;
            // 
            // frmNIR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1212, 717);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.continutNIRDataGridView);
            this.Controls.Add(numarLabel);
            this.Controls.Add(this.numarTextBox);
            this.Controls.Add(idFacturaLabel);
            this.Controls.Add(this.idFacturaComboBox);
            this.Controls.Add(idDepozitLabel);
            this.Controls.Add(this.idDepozitComboBox);
            this.Controls.Add(this.nIRBindingNavigator);
            this.Name = "frmNIR";
            this.Text = "NIR";
            this.Load += new System.EventHandler(this.frmNIR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nIRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIRBindingNavigator)).EndInit();
            this.nIRBindingNavigator.ResumeLayout(false);
            this.nIRBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depozitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.continutNIRDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.continutNIRBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource nIRBindingSource;
        private System.Windows.Forms.BindingNavigator nIRBindingNavigator;
        private System.Windows.Forms.ToolStripButton nIRBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox idDepozitComboBox;
        private System.Windows.Forms.ComboBox idFacturaComboBox;
        private System.Windows.Forms.TextBox numarTextBox;
        private System.Windows.Forms.BindingSource depozitBindingSource;
        private System.Windows.Forms.BindingSource facturaBindingSource;
        private System.Windows.Forms.DataGridView continutNIRDataGridView;
        private System.Windows.Forms.BindingSource produsBindingSource;
        private System.Windows.Forms.BindingSource continutNIRBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantitate;
    }
}
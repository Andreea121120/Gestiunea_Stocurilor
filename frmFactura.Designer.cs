
namespace Gestiunea_stocurilor
{
    partial class frmFactura
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
            System.Windows.Forms.Label numarLabel;
            System.Windows.Forms.Label serieLabel;
            System.Windows.Forms.Label explicatiiLabel;
            System.Windows.Forms.Label dataLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFactura));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.facturaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.facturaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.numarTextBox = new System.Windows.Forms.TextBox();
            this.serieTextBox = new System.Windows.Forms.TextBox();
            this.explicatiiTextBox = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.continutFacturaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.produsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valoare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.continutFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.idPartenerClientComboBox = new System.Windows.Forms.ComboBox();
            this.partenerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idPartenerFurnizorComboBox = new System.Windows.Forms.ComboBox();
            this.partenerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rbClient = new System.Windows.Forms.RadioButton();
            this.rbFurnizor = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            numarLabel = new System.Windows.Forms.Label();
            serieLabel = new System.Windows.Forms.Label();
            explicatiiLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingNavigator)).BeginInit();
            this.facturaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.continutFacturaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.continutFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partenerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partenerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // numarLabel
            // 
            numarLabel.AutoSize = true;
            numarLabel.Font = new System.Drawing.Font("Verdana", 8F);
            numarLabel.Location = new System.Drawing.Point(69, 97);
            numarLabel.Name = "numarLabel";
            numarLabel.Size = new System.Drawing.Size(68, 18);
            numarLabel.TabIndex = 1;
            numarLabel.Text = "Numar:";
            // 
            // serieLabel
            // 
            serieLabel.AutoSize = true;
            serieLabel.Font = new System.Drawing.Font("Verdana", 8F);
            serieLabel.Location = new System.Drawing.Point(69, 166);
            serieLabel.Name = "serieLabel";
            serieLabel.Size = new System.Drawing.Size(56, 18);
            serieLabel.TabIndex = 3;
            serieLabel.Text = "Serie:";
            // 
            // explicatiiLabel
            // 
            explicatiiLabel.AutoSize = true;
            explicatiiLabel.Font = new System.Drawing.Font("Verdana", 8F);
            explicatiiLabel.Location = new System.Drawing.Point(69, 314);
            explicatiiLabel.Name = "explicatiiLabel";
            explicatiiLabel.Size = new System.Drawing.Size(89, 18);
            explicatiiLabel.TabIndex = 7;
            explicatiiLabel.Text = "Explicatii:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Font = new System.Drawing.Font("Verdana", 8F);
            dataLabel.Location = new System.Drawing.Point(69, 235);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(54, 18);
            dataLabel.TabIndex = 9;
            dataLabel.Text = "Data:";
            // 
            // facturaBindingNavigator
            // 
            this.facturaBindingNavigator.AddNewItem = null;
            this.facturaBindingNavigator.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.facturaBindingNavigator.BindingSource = this.facturaBindingSource;
            this.facturaBindingNavigator.CountItem = null;
            this.facturaBindingNavigator.DeleteItem = null;
            this.facturaBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.facturaBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.facturaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripButton,
            this.toolStripButton2,
            this.newToolStripButton,
            this.toolStripButton1,
            this.facturaBindingNavigatorSaveItem});
            this.facturaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.facturaBindingNavigator.MoveFirstItem = null;
            this.facturaBindingNavigator.MoveLastItem = null;
            this.facturaBindingNavigator.MoveNextItem = null;
            this.facturaBindingNavigator.MovePreviousItem = null;
            this.facturaBindingNavigator.Name = "facturaBindingNavigator";
            this.facturaBindingNavigator.PositionItem = null;
            this.facturaBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.facturaBindingNavigator.Size = new System.Drawing.Size(1103, 33);
            this.facturaBindingNavigator.TabIndex = 0;
            this.facturaBindingNavigator.Text = "bindingNavigator1";
            // 
            // facturaBindingSource
            // 
            this.facturaBindingSource.DataSource = typeof(Gestiunea_stocurilor.Factura);
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
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton2.Text = "Stoc produs";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click_1);
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(34, 28);
            this.newToolStripButton.Text = "Lista facturi";
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
            this.toolStripButton1.Text = "Editeaza factura";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // facturaBindingNavigatorSaveItem
            // 
            this.facturaBindingNavigatorSaveItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.facturaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.facturaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("facturaBindingNavigatorSaveItem.Image")));
            this.facturaBindingNavigatorSaveItem.Name = "facturaBindingNavigatorSaveItem";
            this.facturaBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.facturaBindingNavigatorSaveItem.Text = "Salveaza";
            this.facturaBindingNavigatorSaveItem.Click += new System.EventHandler(this.facturaBindingNavigatorSaveItem_Click);
            // 
            // numarTextBox
            // 
            this.numarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturaBindingSource, "Numar", true));
            this.numarTextBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.numarTextBox.Location = new System.Drawing.Point(198, 91);
            this.numarTextBox.Name = "numarTextBox";
            this.numarTextBox.Size = new System.Drawing.Size(305, 27);
            this.numarTextBox.TabIndex = 2;
            // 
            // serieTextBox
            // 
            this.serieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturaBindingSource, "Serie", true));
            this.serieTextBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.serieTextBox.Location = new System.Drawing.Point(198, 163);
            this.serieTextBox.Name = "serieTextBox";
            this.serieTextBox.Size = new System.Drawing.Size(305, 27);
            this.serieTextBox.TabIndex = 4;
            // 
            // explicatiiTextBox
            // 
            this.explicatiiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturaBindingSource, "Explicatii", true));
            this.explicatiiTextBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.explicatiiTextBox.Location = new System.Drawing.Point(198, 311);
            this.explicatiiTextBox.Multiline = true;
            this.explicatiiTextBox.Name = "explicatiiTextBox";
            this.explicatiiTextBox.Size = new System.Drawing.Size(786, 145);
            this.explicatiiTextBox.TabIndex = 8;
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.facturaBindingSource, "Data", true));
            this.dataDateTimePicker.Font = new System.Drawing.Font("Verdana", 8F);
            this.dataDateTimePicker.Location = new System.Drawing.Point(198, 230);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(305, 27);
            this.dataDateTimePicker.TabIndex = 10;
            // 
            // continutFacturaDataGridView
            // 
            this.continutFacturaDataGridView.AutoGenerateColumns = false;
            this.continutFacturaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.continutFacturaDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.continutFacturaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.continutFacturaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.continutFacturaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.continutFacturaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4,
            this.Valoare,
            this.Column1});
            this.continutFacturaDataGridView.DataSource = this.continutFacturaBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.continutFacturaDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.continutFacturaDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.continutFacturaDataGridView.Location = new System.Drawing.Point(73, 623);
            this.continutFacturaDataGridView.Name = "continutFacturaDataGridView";
            this.continutFacturaDataGridView.RowHeadersWidth = 62;
            this.continutFacturaDataGridView.RowTemplate.Height = 28;
            this.continutFacturaDataGridView.Size = new System.Drawing.Size(911, 387);
            this.continutFacturaDataGridView.TabIndex = 11;
            this.continutFacturaDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.continutFacturaDataGridView_CellValueChanged);
            this.continutFacturaDataGridView.CurrentCellDirtyStateChanged += new System.EventHandler(this.continutFacturaDataGridView_CurrentCellDirtyStateChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdFactura";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdFactura";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
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
            // 
            // produsBindingSource
            // 
            this.produsBindingSource.DataSource = typeof(Gestiunea_stocurilor.Produs);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Cantitate";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cantitate";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Pret";
            this.dataGridViewTextBoxColumn4.HeaderText = "Pret";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Valoare
            // 
            this.Valoare.DataPropertyName = "Valoare";
            this.Valoare.HeaderText = "Valoare";
            this.Valoare.MinimumWidth = 8;
            this.Valoare.Name = "Valoare";
            this.Valoare.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.FalseValue = "false";
            this.Column1.HeaderText = "Selecteaza";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.TrueValue = "true";
            // 
            // continutFacturaBindingSource
            // 
            this.continutFacturaBindingSource.DataSource = typeof(Gestiunea_stocurilor.ContinutFactura);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(69, 572);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Continut factura:";
            // 
            // idPartenerClientComboBox
            // 
            this.idPartenerClientComboBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.idPartenerClientComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturaBindingSource, "IdPartenerClient", true));
            this.idPartenerClientComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.facturaBindingSource, "IdPartenerClient", true));
            this.idPartenerClientComboBox.DataSource = this.partenerBindingSource;
            this.idPartenerClientComboBox.DisplayMember = "Denumire";
            this.idPartenerClientComboBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.idPartenerClientComboBox.FormattingEnabled = true;
            this.idPartenerClientComboBox.Location = new System.Drawing.Point(736, 153);
            this.idPartenerClientComboBox.Name = "idPartenerClientComboBox";
            this.idPartenerClientComboBox.Size = new System.Drawing.Size(248, 26);
            this.idPartenerClientComboBox.TabIndex = 13;
            this.idPartenerClientComboBox.ValueMember = "Id";
            // 
            // partenerBindingSource
            // 
            this.partenerBindingSource.DataSource = typeof(Gestiunea_stocurilor.Partener);
            // 
            // idPartenerFurnizorComboBox
            // 
            this.idPartenerFurnizorComboBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.idPartenerFurnizorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturaBindingSource, "IdPartenerFurnizor", true));
            this.idPartenerFurnizorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.facturaBindingSource, "IdPartenerFurnizor", true));
            this.idPartenerFurnizorComboBox.DataSource = this.partenerBindingSource1;
            this.idPartenerFurnizorComboBox.DisplayMember = "Denumire";
            this.idPartenerFurnizorComboBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.idPartenerFurnizorComboBox.FormattingEnabled = true;
            this.idPartenerFurnizorComboBox.Location = new System.Drawing.Point(736, 153);
            this.idPartenerFurnizorComboBox.Name = "idPartenerFurnizorComboBox";
            this.idPartenerFurnizorComboBox.Size = new System.Drawing.Size(248, 26);
            this.idPartenerFurnizorComboBox.TabIndex = 14;
            this.idPartenerFurnizorComboBox.ValueMember = "Id";
            // 
            // partenerBindingSource1
            // 
            this.partenerBindingSource1.DataSource = typeof(Gestiunea_stocurilor.Partener);
            // 
            // rbClient
            // 
            this.rbClient.AutoSize = true;
            this.rbClient.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbClient.Font = new System.Drawing.Font("Verdana", 8F);
            this.rbClient.Location = new System.Drawing.Point(736, 95);
            this.rbClient.Name = "rbClient";
            this.rbClient.Size = new System.Drawing.Size(81, 22);
            this.rbClient.TabIndex = 15;
            this.rbClient.TabStop = true;
            this.rbClient.Text = "Client";
            this.rbClient.UseVisualStyleBackColor = false;
            this.rbClient.CheckedChanged += new System.EventHandler(this.rbClient_CheckedChanged);
            // 
            // rbFurnizor
            // 
            this.rbFurnizor.AutoSize = true;
            this.rbFurnizor.Font = new System.Drawing.Font("Verdana", 8F);
            this.rbFurnizor.Location = new System.Drawing.Point(892, 97);
            this.rbFurnizor.Name = "rbFurnizor";
            this.rbFurnizor.Size = new System.Drawing.Size(98, 22);
            this.rbFurnizor.TabIndex = 16;
            this.rbFurnizor.TabStop = true;
            this.rbFurnizor.Text = "Furnizor";
            this.rbFurnizor.UseVisualStyleBackColor = true;
            this.rbFurnizor.CheckedChanged += new System.EventHandler(this.rbFurnizor_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8F);
            this.label2.Location = new System.Drawing.Point(579, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tip partener:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8F);
            this.label3.Location = new System.Drawing.Point(579, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Partener:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 481);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtTotal.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTotal.Location = new System.Drawing.Point(198, 479);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(310, 27);
            this.txtTotal.TabIndex = 20;
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1103, 1050);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbFurnizor);
            this.Controls.Add(this.rbClient);
            this.Controls.Add(this.idPartenerFurnizorComboBox);
            this.Controls.Add(this.idPartenerClientComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.continutFacturaDataGridView);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(explicatiiLabel);
            this.Controls.Add(this.explicatiiTextBox);
            this.Controls.Add(serieLabel);
            this.Controls.Add(this.serieTextBox);
            this.Controls.Add(numarLabel);
            this.Controls.Add(this.numarTextBox);
            this.Controls.Add(this.facturaBindingNavigator);
            this.Name = "frmFactura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingNavigator)).EndInit();
            this.facturaBindingNavigator.ResumeLayout(false);
            this.facturaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.continutFacturaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.continutFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partenerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partenerBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource facturaBindingSource;
        private System.Windows.Forms.BindingNavigator facturaBindingNavigator;
        private System.Windows.Forms.ToolStripButton facturaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox numarTextBox;
        private System.Windows.Forms.TextBox serieTextBox;
        private System.Windows.Forms.TextBox explicatiiTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.BindingSource continutFacturaBindingSource;
        private System.Windows.Forms.DataGridView continutFacturaDataGridView;
        private System.Windows.Forms.BindingSource produsBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ComboBox idPartenerClientComboBox;
        private System.Windows.Forms.BindingSource partenerBindingSource;
        private System.Windows.Forms.ComboBox idPartenerFurnizorComboBox;
        private System.Windows.Forms.RadioButton rbClient;
        private System.Windows.Forms.RadioButton rbFurnizor;
        private System.Windows.Forms.BindingSource partenerBindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valoare;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
    }
}
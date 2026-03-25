
namespace Gestiunea_stocurilor
{
    partial class frmListaFacturi
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label explicatiiLabel;
            System.Windows.Forms.Label serieLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.idComboBox = new System.Windows.Forms.ComboBox();
            this.facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.continutFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.explicatiiTextBox = new System.Windows.Forms.TextBox();
            this.serieTextBox = new System.Windows.Forms.TextBox();
            this.continutFacturaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.produsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valoare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.partenerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblClient = new System.Windows.Forms.Label();
            this.lblFurnizor = new System.Windows.Forms.Label();
            this.furnizorTextBox = new System.Windows.Forms.TextBox();
            this.clientTextBox = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            explicatiiLabel = new System.Windows.Forms.Label();
            serieLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.continutFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.continutFacturaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partenerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Verdana", 8F);
            idLabel.Location = new System.Drawing.Point(75, 56);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(68, 18);
            idLabel.TabIndex = 1;
            idLabel.Text = "Numar:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Font = new System.Drawing.Font("Verdana", 8F);
            dataLabel.Location = new System.Drawing.Point(75, 130);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(54, 18);
            dataLabel.TabIndex = 5;
            dataLabel.Text = "Data:";
            // 
            // explicatiiLabel
            // 
            explicatiiLabel.AutoSize = true;
            explicatiiLabel.Font = new System.Drawing.Font("Verdana", 8F);
            explicatiiLabel.Location = new System.Drawing.Point(75, 235);
            explicatiiLabel.Name = "explicatiiLabel";
            explicatiiLabel.Size = new System.Drawing.Size(89, 18);
            explicatiiLabel.TabIndex = 7;
            explicatiiLabel.Text = "Explicatii:";
            // 
            // serieLabel
            // 
            serieLabel.AutoSize = true;
            serieLabel.Font = new System.Drawing.Font("Verdana", 8F);
            serieLabel.Location = new System.Drawing.Point(646, 56);
            serieLabel.Name = "serieLabel";
            serieLabel.Size = new System.Drawing.Size(56, 18);
            serieLabel.TabIndex = 9;
            serieLabel.Text = "Serie:";
            // 
            // idComboBox
            // 
            this.idComboBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.idComboBox.DataSource = this.facturaBindingSource;
            this.idComboBox.DisplayMember = "Numar";
            this.idComboBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.idComboBox.FormattingEnabled = true;
            this.idComboBox.Location = new System.Drawing.Point(228, 53);
            this.idComboBox.Name = "idComboBox";
            this.idComboBox.Size = new System.Drawing.Size(293, 26);
            this.idComboBox.TabIndex = 2;
            this.idComboBox.ValueMember = "Id";
            this.idComboBox.SelectedIndexChanged += new System.EventHandler(this.idComboBox_SelectedIndexChanged);
            // 
            // facturaBindingSource
            // 
            this.facturaBindingSource.DataSource = typeof(Gestiunea_stocurilor.Factura);
            // 
            // continutFacturaBindingSource
            // 
            this.continutFacturaBindingSource.DataSource = typeof(Gestiunea_stocurilor.ContinutFactura);
            // 
            // dataTextBox
            // 
            this.dataTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.dataTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturaBindingSource, "Data", true));
            this.dataTextBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.dataTextBox.Location = new System.Drawing.Point(228, 127);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.ReadOnly = true;
            this.dataTextBox.Size = new System.Drawing.Size(293, 27);
            this.dataTextBox.TabIndex = 6;
            // 
            // explicatiiTextBox
            // 
            this.explicatiiTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.explicatiiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturaBindingSource, "Explicatii", true));
            this.explicatiiTextBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.explicatiiTextBox.Location = new System.Drawing.Point(228, 229);
            this.explicatiiTextBox.Multiline = true;
            this.explicatiiTextBox.Name = "explicatiiTextBox";
            this.explicatiiTextBox.ReadOnly = true;
            this.explicatiiTextBox.Size = new System.Drawing.Size(813, 163);
            this.explicatiiTextBox.TabIndex = 8;
            // 
            // serieTextBox
            // 
            this.serieTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.serieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturaBindingSource, "Serie", true));
            this.serieTextBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.serieTextBox.Location = new System.Drawing.Point(781, 53);
            this.serieTextBox.Name = "serieTextBox";
            this.serieTextBox.ReadOnly = true;
            this.serieTextBox.Size = new System.Drawing.Size(260, 27);
            this.serieTextBox.TabIndex = 10;
            // 
            // continutFacturaDataGridView
            // 
            this.continutFacturaDataGridView.AllowUserToAddRows = false;
            this.continutFacturaDataGridView.AllowUserToDeleteRows = false;
            this.continutFacturaDataGridView.AutoGenerateColumns = false;
            this.continutFacturaDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.continutFacturaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.continutFacturaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.continutFacturaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.continutFacturaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4,
            this.Valoare});
            this.continutFacturaDataGridView.DataSource = this.continutFacturaBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.continutFacturaDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.continutFacturaDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.continutFacturaDataGridView.Location = new System.Drawing.Point(79, 539);
            this.continutFacturaDataGridView.Name = "continutFacturaDataGridView";
            this.continutFacturaDataGridView.ReadOnly = true;
            this.continutFacturaDataGridView.RowHeadersWidth = 62;
            this.continutFacturaDataGridView.RowTemplate.Height = 28;
            this.continutFacturaDataGridView.Size = new System.Drawing.Size(987, 451);
            this.continutFacturaDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdFactura";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdFactura";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdProdus";
            this.dataGridViewTextBoxColumn3.DataSource = this.produsBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Denumire";
            this.dataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn3.DisplayStyleForCurrentCellOnly = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Produs";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "Id";
            this.dataGridViewTextBoxColumn3.Width = 99;
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
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 121;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Pret";
            this.dataGridViewTextBoxColumn4.HeaderText = "Pret";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 77;
            // 
            // Valoare
            // 
            this.Valoare.DataPropertyName = "Valoare";
            this.Valoare.HeaderText = "Valoare";
            this.Valoare.MinimumWidth = 8;
            this.Valoare.Name = "Valoare";
            this.Valoare.ReadOnly = true;
            this.Valoare.Width = 105;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(75, 493);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Continut factura:";
            // 
            // partenerBindingSource
            // 
            this.partenerBindingSource.DataSource = typeof(Gestiunea_stocurilor.Partener);
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Verdana", 8F);
            this.lblClient.Location = new System.Drawing.Point(646, 133);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(63, 18);
            this.lblClient.TabIndex = 15;
            this.lblClient.Text = "Client:";
            // 
            // lblFurnizor
            // 
            this.lblFurnizor.AutoSize = true;
            this.lblFurnizor.Font = new System.Drawing.Font("Verdana", 8F);
            this.lblFurnizor.Location = new System.Drawing.Point(646, 133);
            this.lblFurnizor.Name = "lblFurnizor";
            this.lblFurnizor.Size = new System.Drawing.Size(80, 18);
            this.lblFurnizor.TabIndex = 17;
            this.lblFurnizor.Text = "Furnizor:";
            // 
            // furnizorTextBox
            // 
            this.furnizorTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.furnizorTextBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.furnizorTextBox.Location = new System.Drawing.Point(781, 130);
            this.furnizorTextBox.Name = "furnizorTextBox";
            this.furnizorTextBox.ReadOnly = true;
            this.furnizorTextBox.Size = new System.Drawing.Size(260, 27);
            this.furnizorTextBox.TabIndex = 16;
            // 
            // clientTextBox
            // 
            this.clientTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clientTextBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.clientTextBox.Location = new System.Drawing.Point(781, 130);
            this.clientTextBox.Name = "clientTextBox";
            this.clientTextBox.ReadOnly = true;
            this.clientTextBox.Size = new System.Drawing.Size(260, 27);
            this.clientTextBox.TabIndex = 14;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtTotal.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTotal.Location = new System.Drawing.Point(228, 427);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(310, 27);
            this.txtTotal.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Total:";
            // 
            // frmListaFacturi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1143, 1050);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblFurnizor);
            this.Controls.Add(this.furnizorTextBox);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.clientTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.continutFacturaDataGridView);
            this.Controls.Add(serieLabel);
            this.Controls.Add(this.serieTextBox);
            this.Controls.Add(explicatiiLabel);
            this.Controls.Add(this.explicatiiTextBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idComboBox);
            this.Name = "frmListaFacturi";
            this.Text = "Lista facturi";
            this.Load += new System.EventHandler(this.frmListaFacturi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.continutFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.continutFacturaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partenerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource facturaBindingSource;
        private System.Windows.Forms.ComboBox idComboBox;
        private System.Windows.Forms.BindingSource continutFacturaBindingSource;
        private System.Windows.Forms.TextBox dataTextBox;
        private System.Windows.Forms.TextBox explicatiiTextBox;
        private System.Windows.Forms.TextBox serieTextBox;
        private System.Windows.Forms.DataGridView continutFacturaDataGridView;
        private System.Windows.Forms.BindingSource produsBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource partenerBindingSource;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblFurnizor;
        private System.Windows.Forms.TextBox furnizorTextBox;
        private System.Windows.Forms.TextBox clientTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valoare;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label2;
    }
}
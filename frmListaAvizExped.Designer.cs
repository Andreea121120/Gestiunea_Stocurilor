
namespace Gestiunea_stocurilor
{
    partial class frmListaAvizExped
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
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label idFacturaLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.avizExpeditieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDepozitTextBox = new System.Windows.Forms.TextBox();
            this.depozitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.produsExpeditieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produsExpeditieDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.produsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idFacturaTextBox = new System.Windows.Forms.TextBox();
            idDepozitLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            idFacturaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.avizExpeditieBindingSource)).BeginInit();
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
            idDepozitLabel.Location = new System.Drawing.Point(53, 147);
            idDepozitLabel.Name = "idDepozitLabel";
            idDepozitLabel.Size = new System.Drawing.Size(78, 18);
            idDepozitLabel.TabIndex = 3;
            idDepozitLabel.Text = "Depozit:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Font = new System.Drawing.Font("Verdana", 8F);
            dataLabel.Location = new System.Drawing.Point(543, 74);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(54, 18);
            dataLabel.TabIndex = 5;
            dataLabel.Text = "Data:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Verdana", 8F);
            idLabel.Location = new System.Drawing.Point(53, 74);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(68, 18);
            idLabel.TabIndex = 7;
            idLabel.Text = "Numar:";
            // 
            // idFacturaLabel
            // 
            idFacturaLabel.AutoSize = true;
            idFacturaLabel.Font = new System.Drawing.Font("Verdana", 8F);
            idFacturaLabel.Location = new System.Drawing.Point(543, 147);
            idFacturaLabel.Name = "idFacturaLabel";
            idFacturaLabel.Size = new System.Drawing.Size(74, 18);
            idFacturaLabel.TabIndex = 9;
            idFacturaLabel.Text = "Factura:";
            // 
            // avizExpeditieBindingSource
            // 
            this.avizExpeditieBindingSource.DataSource = typeof(Gestiunea_stocurilor.AvizExpeditie);
            // 
            // idDepozitTextBox
            // 
            this.idDepozitTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.idDepozitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.depozitBindingSource, "Denumire", true));
            this.idDepozitTextBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.idDepozitTextBox.Location = new System.Drawing.Point(209, 141);
            this.idDepozitTextBox.Name = "idDepozitTextBox";
            this.idDepozitTextBox.ReadOnly = true;
            this.idDepozitTextBox.Size = new System.Drawing.Size(245, 27);
            this.idDepozitTextBox.TabIndex = 4;
            // 
            // depozitBindingSource
            // 
            this.depozitBindingSource.DataSource = typeof(Gestiunea_stocurilor.Depozit);
            // 
            // dataTextBox
            // 
            this.dataTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.dataTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avizExpeditieBindingSource, "Data", true));
            this.dataTextBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.dataTextBox.Location = new System.Drawing.Point(639, 71);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.ReadOnly = true;
            this.dataTextBox.Size = new System.Drawing.Size(245, 27);
            this.dataTextBox.TabIndex = 6;
            // 
            // produsExpeditieBindingSource
            // 
            this.produsExpeditieBindingSource.DataSource = typeof(Gestiunea_stocurilor.ProdusExpeditie);
            // 
            // produsExpeditieDataGridView
            // 
            this.produsExpeditieDataGridView.AllowUserToAddRows = false;
            this.produsExpeditieDataGridView.AllowUserToDeleteRows = false;
            this.produsExpeditieDataGridView.AutoGenerateColumns = false;
            this.produsExpeditieDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.produsExpeditieDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8F);
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
            this.dataGridViewTextBoxColumn4});
            this.produsExpeditieDataGridView.DataSource = this.produsExpeditieBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.produsExpeditieDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.produsExpeditieDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.produsExpeditieDataGridView.Location = new System.Drawing.Point(57, 283);
            this.produsExpeditieDataGridView.Name = "produsExpeditieDataGridView";
            this.produsExpeditieDataGridView.ReadOnly = true;
            this.produsExpeditieDataGridView.RowHeadersWidth = 62;
            this.produsExpeditieDataGridView.RowTemplate.Height = 28;
            this.produsExpeditieDataGridView.Size = new System.Drawing.Size(827, 332);
            this.produsExpeditieDataGridView.TabIndex = 7;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdAvizExpeditie";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdAvizExpeditie";
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
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // produsBindingSource
            // 
            this.produsBindingSource.DataSource = typeof(Gestiunea_stocurilor.Produs);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cantitate";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cantitate";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // idComboBox
            // 
            this.idComboBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.idComboBox.DataSource = this.avizExpeditieBindingSource;
            this.idComboBox.DisplayMember = "Numar";
            this.idComboBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.idComboBox.FormattingEnabled = true;
            this.idComboBox.Location = new System.Drawing.Point(209, 71);
            this.idComboBox.Name = "idComboBox";
            this.idComboBox.Size = new System.Drawing.Size(245, 26);
            this.idComboBox.TabIndex = 8;
            this.idComboBox.ValueMember = "Id";
            this.idComboBox.SelectedIndexChanged += new System.EventHandler(this.idComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(57, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Produs expeditie:";
            // 
            // facturaBindingSource
            // 
            this.facturaBindingSource.DataSource = typeof(Gestiunea_stocurilor.Factura);
            // 
            // idFacturaTextBox
            // 
            this.idFacturaTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.idFacturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturaBindingSource, "Numar", true));
            this.idFacturaTextBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.idFacturaTextBox.Location = new System.Drawing.Point(639, 140);
            this.idFacturaTextBox.Name = "idFacturaTextBox";
            this.idFacturaTextBox.ReadOnly = true;
            this.idFacturaTextBox.Size = new System.Drawing.Size(245, 27);
            this.idFacturaTextBox.TabIndex = 10;
            // 
            // frmListaAvizExped
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1033, 670);
            this.Controls.Add(this.idFacturaTextBox);
            this.Controls.Add(idFacturaLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idComboBox);
            this.Controls.Add(this.produsExpeditieDataGridView);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(idDepozitLabel);
            this.Controls.Add(this.idDepozitTextBox);
            this.Name = "frmListaAvizExped";
            this.Text = "Lista avize expeditie";
            this.Load += new System.EventHandler(this.frmListaAvizExped_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avizExpeditieBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox idDepozitTextBox;
        private System.Windows.Forms.TextBox dataTextBox;
        private System.Windows.Forms.BindingSource produsExpeditieBindingSource;
        private System.Windows.Forms.DataGridView produsExpeditieDataGridView;
        private System.Windows.Forms.BindingSource produsBindingSource;
        private System.Windows.Forms.BindingSource depozitBindingSource;
        private System.Windows.Forms.ComboBox idComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource facturaBindingSource;
        private System.Windows.Forms.TextBox idFacturaTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

namespace Gestiunea_stocurilor
{
    partial class frmListaBonTransf
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
            System.Windows.Forms.Label idDepozitPredatorLabel;
            System.Windows.Forms.Label idDepozitPrimitorLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bonTransferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idComboBox = new System.Windows.Forms.ComboBox();
            this.produsTransferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.idDepozitPredatorTextBox = new System.Windows.Forms.TextBox();
            this.depozitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDepozitPrimitorTextBox = new System.Windows.Forms.TextBox();
            this.produsTransferDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.produsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            idDepozitPredatorLabel = new System.Windows.Forms.Label();
            idDepozitPrimitorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bonTransferBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsTransferBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depozitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsTransferDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Verdana", 8F);
            idLabel.Location = new System.Drawing.Point(46, 64);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(68, 18);
            idLabel.TabIndex = 1;
            idLabel.Text = "Numar:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Font = new System.Drawing.Font("Verdana", 8F);
            dataLabel.Location = new System.Drawing.Point(46, 131);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(54, 18);
            dataLabel.TabIndex = 3;
            dataLabel.Text = "Data:";
            // 
            // idDepozitPredatorLabel
            // 
            idDepozitPredatorLabel.AutoSize = true;
            idDepozitPredatorLabel.Font = new System.Drawing.Font("Verdana", 8F);
            idDepozitPredatorLabel.Location = new System.Drawing.Point(548, 64);
            idDepozitPredatorLabel.Name = "idDepozitPredatorLabel";
            idDepozitPredatorLabel.Size = new System.Drawing.Size(153, 18);
            idDepozitPredatorLabel.TabIndex = 5;
            idDepozitPredatorLabel.Text = "Depozit predator:";
            // 
            // idDepozitPrimitorLabel
            // 
            idDepozitPrimitorLabel.AutoSize = true;
            idDepozitPrimitorLabel.Font = new System.Drawing.Font("Verdana", 8F);
            idDepozitPrimitorLabel.Location = new System.Drawing.Point(548, 131);
            idDepozitPrimitorLabel.Name = "idDepozitPrimitorLabel";
            idDepozitPrimitorLabel.Size = new System.Drawing.Size(148, 18);
            idDepozitPrimitorLabel.TabIndex = 7;
            idDepozitPrimitorLabel.Text = "Depozit primitor:";
            // 
            // bonTransferBindingSource
            // 
            this.bonTransferBindingSource.DataSource = typeof(Gestiunea_stocurilor.BonTransfer);
            // 
            // idComboBox
            // 
            this.idComboBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.idComboBox.DataSource = this.bonTransferBindingSource;
            this.idComboBox.DisplayMember = "Numar";
            this.idComboBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.idComboBox.FormattingEnabled = true;
            this.idComboBox.Location = new System.Drawing.Point(186, 61);
            this.idComboBox.Name = "idComboBox";
            this.idComboBox.Size = new System.Drawing.Size(282, 26);
            this.idComboBox.TabIndex = 2;
            this.idComboBox.ValueMember = "Id";
            this.idComboBox.SelectedIndexChanged += new System.EventHandler(this.idComboBox_SelectedIndexChanged);
            // 
            // produsTransferBindingSource
            // 
            this.produsTransferBindingSource.DataSource = typeof(Gestiunea_stocurilor.ProdusTransfer);
            // 
            // dataTextBox
            // 
            this.dataTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.dataTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bonTransferBindingSource, "Data", true));
            this.dataTextBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.dataTextBox.Location = new System.Drawing.Point(186, 128);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.ReadOnly = true;
            this.dataTextBox.Size = new System.Drawing.Size(282, 27);
            this.dataTextBox.TabIndex = 4;
            // 
            // idDepozitPredatorTextBox
            // 
            this.idDepozitPredatorTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.idDepozitPredatorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.depozitBindingSource, "Denumire", true));
            this.idDepozitPredatorTextBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.idDepozitPredatorTextBox.Location = new System.Drawing.Point(770, 61);
            this.idDepozitPredatorTextBox.Name = "idDepozitPredatorTextBox";
            this.idDepozitPredatorTextBox.ReadOnly = true;
            this.idDepozitPredatorTextBox.Size = new System.Drawing.Size(253, 27);
            this.idDepozitPredatorTextBox.TabIndex = 6;
            // 
            // depozitBindingSource
            // 
            this.depozitBindingSource.DataSource = typeof(Gestiunea_stocurilor.Depozit);
            // 
            // idDepozitPrimitorTextBox
            // 
            this.idDepozitPrimitorTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.idDepozitPrimitorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.depozitBindingSource, "Denumire", true));
            this.idDepozitPrimitorTextBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.idDepozitPrimitorTextBox.Location = new System.Drawing.Point(770, 128);
            this.idDepozitPrimitorTextBox.Name = "idDepozitPrimitorTextBox";
            this.idDepozitPrimitorTextBox.ReadOnly = true;
            this.idDepozitPrimitorTextBox.Size = new System.Drawing.Size(253, 27);
            this.idDepozitPrimitorTextBox.TabIndex = 8;
            // 
            // produsTransferDataGridView
            // 
            this.produsTransferDataGridView.AllowUserToAddRows = false;
            this.produsTransferDataGridView.AllowUserToDeleteRows = false;
            this.produsTransferDataGridView.AutoGenerateColumns = false;
            this.produsTransferDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.produsTransferDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.produsTransferDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.produsTransferDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produsTransferDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.produsTransferDataGridView.DataSource = this.produsTransferBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.produsTransferDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.produsTransferDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.produsTransferDataGridView.Location = new System.Drawing.Point(50, 276);
            this.produsTransferDataGridView.Name = "produsTransferDataGridView";
            this.produsTransferDataGridView.ReadOnly = true;
            this.produsTransferDataGridView.RowHeadersWidth = 62;
            this.produsTransferDataGridView.RowTemplate.Height = 28;
            this.produsTransferDataGridView.Size = new System.Drawing.Size(1017, 337);
            this.produsTransferDataGridView.TabIndex = 9;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdBonTransfer";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdBonTransfer";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(46, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Produse transfer:";
            // 
            // frmListaBonTransf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1174, 653);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.produsTransferDataGridView);
            this.Controls.Add(idDepozitPrimitorLabel);
            this.Controls.Add(this.idDepozitPrimitorTextBox);
            this.Controls.Add(idDepozitPredatorLabel);
            this.Controls.Add(this.idDepozitPredatorTextBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idComboBox);
            this.Name = "frmListaBonTransf";
            this.Text = "Lista bonuri transfer";
            this.Load += new System.EventHandler(this.frmListaBonTransf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bonTransferBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsTransferBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depozitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsTransferDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bonTransferBindingSource;
        private System.Windows.Forms.ComboBox idComboBox;
        private System.Windows.Forms.BindingSource produsTransferBindingSource;
        private System.Windows.Forms.TextBox dataTextBox;
        private System.Windows.Forms.TextBox idDepozitPredatorTextBox;
        private System.Windows.Forms.TextBox idDepozitPrimitorTextBox;
        private System.Windows.Forms.DataGridView produsTransferDataGridView;
        private System.Windows.Forms.BindingSource depozitBindingSource;
        private System.Windows.Forms.BindingSource produsBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

namespace Gestiunea_stocurilor
{
    partial class frmListaBonConsum
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
            System.Windows.Forms.Label idDepozitLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.idComboBox = new System.Windows.Forms.ComboBox();
            this.bonConsumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produsConsumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDepozitTextBox = new System.Windows.Forms.TextBox();
            this.depozitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.produsConsumDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.produsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            idDepozitLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bonConsumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsConsumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depozitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsConsumDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Verdana", 8F);
            idLabel.Location = new System.Drawing.Point(72, 70);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(68, 18);
            idLabel.TabIndex = 1;
            idLabel.Text = "Numar:";
            // 
            // idDepozitLabel
            // 
            idDepozitLabel.AutoSize = true;
            idDepozitLabel.Font = new System.Drawing.Font("Verdana", 8F);
            idDepozitLabel.Location = new System.Drawing.Point(72, 143);
            idDepozitLabel.Name = "idDepozitLabel";
            idDepozitLabel.Size = new System.Drawing.Size(78, 18);
            idDepozitLabel.TabIndex = 3;
            idDepozitLabel.Text = "Depozit:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Font = new System.Drawing.Font("Verdana", 8F);
            dataLabel.Location = new System.Drawing.Point(581, 70);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(54, 18);
            dataLabel.TabIndex = 5;
            dataLabel.Text = "Data:";
            // 
            // idComboBox
            // 
            this.idComboBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.idComboBox.DataSource = this.bonConsumBindingSource;
            this.idComboBox.DisplayMember = "Numar";
            this.idComboBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.idComboBox.FormattingEnabled = true;
            this.idComboBox.Location = new System.Drawing.Point(207, 67);
            this.idComboBox.Name = "idComboBox";
            this.idComboBox.Size = new System.Drawing.Size(267, 26);
            this.idComboBox.TabIndex = 2;
            this.idComboBox.ValueMember = "Id";
            this.idComboBox.SelectedIndexChanged += new System.EventHandler(this.idComboBox_SelectedIndexChanged);
            // 
            // bonConsumBindingSource
            // 
            this.bonConsumBindingSource.DataSource = typeof(Gestiunea_stocurilor.BonConsum);
            // 
            // produsConsumBindingSource
            // 
            this.produsConsumBindingSource.DataSource = typeof(Gestiunea_stocurilor.ProdusConsum);
            // 
            // idDepozitTextBox
            // 
            this.idDepozitTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.idDepozitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.depozitBindingSource, "Denumire", true));
            this.idDepozitTextBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.idDepozitTextBox.Location = new System.Drawing.Point(207, 137);
            this.idDepozitTextBox.Name = "idDepozitTextBox";
            this.idDepozitTextBox.ReadOnly = true;
            this.idDepozitTextBox.Size = new System.Drawing.Size(267, 27);
            this.idDepozitTextBox.TabIndex = 4;
            // 
            // depozitBindingSource
            // 
            this.depozitBindingSource.DataSource = typeof(Gestiunea_stocurilor.Depozit);
            // 
            // dataTextBox
            // 
            this.dataTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.dataTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bonConsumBindingSource, "Data", true));
            this.dataTextBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.dataTextBox.Location = new System.Drawing.Point(705, 67);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.ReadOnly = true;
            this.dataTextBox.Size = new System.Drawing.Size(221, 27);
            this.dataTextBox.TabIndex = 6;
            // 
            // produsConsumDataGridView
            // 
            this.produsConsumDataGridView.AllowUserToAddRows = false;
            this.produsConsumDataGridView.AllowUserToDeleteRows = false;
            this.produsConsumDataGridView.AutoGenerateColumns = false;
            this.produsConsumDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.produsConsumDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.produsConsumDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.produsConsumDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produsConsumDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.produsConsumDataGridView.DataSource = this.produsConsumBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.produsConsumDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.produsConsumDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.produsConsumDataGridView.Location = new System.Drawing.Point(77, 282);
            this.produsConsumDataGridView.Name = "produsConsumDataGridView";
            this.produsConsumDataGridView.ReadOnly = true;
            this.produsConsumDataGridView.RowHeadersWidth = 62;
            this.produsConsumDataGridView.RowTemplate.Height = 28;
            this.produsConsumDataGridView.Size = new System.Drawing.Size(849, 342);
            this.produsConsumDataGridView.TabIndex = 7;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdBonConsum";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdBonConsum";
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
            this.label1.Location = new System.Drawing.Point(72, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Produse consum:";
            // 
            // frmListaBonConsum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1116, 647);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.produsConsumDataGridView);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(idDepozitLabel);
            this.Controls.Add(this.idDepozitTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idComboBox);
            this.Name = "frmListaBonConsum";
            this.Text = "Lista bonuri consum";
            this.Load += new System.EventHandler(this.frmListaBonConsum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bonConsumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsConsumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depozitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsConsumDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bonConsumBindingSource;
        private System.Windows.Forms.ComboBox idComboBox;
        private System.Windows.Forms.BindingSource produsConsumBindingSource;
        private System.Windows.Forms.TextBox idDepozitTextBox;
        private System.Windows.Forms.TextBox dataTextBox;
        private System.Windows.Forms.DataGridView produsConsumDataGridView;
        private System.Windows.Forms.BindingSource depozitBindingSource;
        private System.Windows.Forms.BindingSource produsBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
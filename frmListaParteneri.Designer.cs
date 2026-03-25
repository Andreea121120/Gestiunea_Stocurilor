
namespace Gestiunea_stocurilor
{
    partial class frmListaParteneri
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.partenerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partenerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rbTp = new System.Windows.Forms.RadioButton();
            this.rbFz = new System.Windows.Forms.RadioButton();
            this.rbCl = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partenerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partenerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.partenerDataGridView);
            this.panel1.Controls.Add(this.rbTp);
            this.panel1.Controls.Add(this.rbFz);
            this.panel1.Controls.Add(this.rbCl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1848, 698);
            this.panel1.TabIndex = 5;
            // 
            // partenerDataGridView
            // 
            this.partenerDataGridView.AllowUserToAddRows = false;
            this.partenerDataGridView.AllowUserToDeleteRows = false;
            this.partenerDataGridView.AutoGenerateColumns = false;
            this.partenerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.partenerDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.partenerDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.partenerDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.partenerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partenerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.partenerDataGridView.DataSource = this.partenerBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.partenerDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.partenerDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.partenerDataGridView.Location = new System.Drawing.Point(36, 110);
            this.partenerDataGridView.Name = "partenerDataGridView";
            this.partenerDataGridView.ReadOnly = true;
            this.partenerDataGridView.RowHeadersWidth = 62;
            this.partenerDataGridView.RowTemplate.Height = 28;
            this.partenerDataGridView.Size = new System.Drawing.Size(1776, 534);
            this.partenerDataGridView.TabIndex = 8;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CUI";
            this.dataGridViewTextBoxColumn2.HeaderText = "CUI/ CIF";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 81;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TipPartener";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tip partener";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 133;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Denumire";
            this.dataGridViewTextBoxColumn4.HeaderText = "Denumire";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 122;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Localitate";
            this.dataGridViewTextBoxColumn5.HeaderText = "Localitate";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Adresa";
            this.dataGridViewTextBoxColumn6.HeaderText = "Adresa";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ContBancar";
            this.dataGridViewTextBoxColumn7.HeaderText = "ContBancar";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 137;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Telefon";
            this.dataGridViewTextBoxColumn8.HeaderText = "Telefon";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 103;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Mail";
            this.dataGridViewTextBoxColumn9.HeaderText = "Mail";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 77;
            // 
            // partenerBindingSource
            // 
            this.partenerBindingSource.DataSource = typeof(Gestiunea_stocurilor.Partener);
            // 
            // rbTp
            // 
            this.rbTp.AutoSize = true;
            this.rbTp.Font = new System.Drawing.Font("Verdana", 8F);
            this.rbTp.Location = new System.Drawing.Point(272, 54);
            this.rbTp.Name = "rbTp";
            this.rbTp.Size = new System.Drawing.Size(63, 22);
            this.rbTp.TabIndex = 7;
            this.rbTp.TabStop = true;
            this.rbTp.Text = "Toti";
            this.rbTp.UseVisualStyleBackColor = true;
            this.rbTp.CheckedChanged += new System.EventHandler(this.rbTp_CheckedChanged);
            // 
            // rbFz
            // 
            this.rbFz.AutoSize = true;
            this.rbFz.Font = new System.Drawing.Font("Verdana", 8F);
            this.rbFz.Location = new System.Drawing.Point(145, 54);
            this.rbFz.Name = "rbFz";
            this.rbFz.Size = new System.Drawing.Size(103, 22);
            this.rbFz.TabIndex = 6;
            this.rbFz.TabStop = true;
            this.rbFz.Text = "Furnizori";
            this.rbFz.UseVisualStyleBackColor = true;
            this.rbFz.CheckedChanged += new System.EventHandler(this.rbFz_CheckedChanged);
            // 
            // rbCl
            // 
            this.rbCl.AutoSize = true;
            this.rbCl.Font = new System.Drawing.Font("Verdana", 8F);
            this.rbCl.Location = new System.Drawing.Point(36, 54);
            this.rbCl.Name = "rbCl";
            this.rbCl.Size = new System.Drawing.Size(86, 22);
            this.rbCl.TabIndex = 5;
            this.rbCl.TabStop = true;
            this.rbCl.Text = "Clienti";
            this.rbCl.UseVisualStyleBackColor = true;
            this.rbCl.CheckedChanged += new System.EventHandler(this.rbCl_CheckedChanged);
            // 
            // frmListaParteneri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1848, 698);
            this.Controls.Add(this.panel1);
            this.Name = "frmListaParteneri";
            this.Text = "Lista parteneri";
            this.Load += new System.EventHandler(this.frmListaParteneri_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partenerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partenerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource partenerBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView partenerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.RadioButton rbTp;
        private System.Windows.Forms.RadioButton rbFz;
        private System.Windows.Forms.RadioButton rbCl;
    }
}

namespace Gestiunea_stocurilor
{
    partial class frmModifPartener
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModifPartener));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.partenerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.partenerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.partenerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.partenerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbTp = new System.Windows.Forms.RadioButton();
            this.rbFz = new System.Windows.Forms.RadioButton();
            this.rbCl = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.partenerBindingNavigator)).BeginInit();
            this.partenerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partenerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partenerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // partenerBindingNavigator
            // 
            this.partenerBindingNavigator.AddNewItem = null;
            this.partenerBindingNavigator.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.partenerBindingNavigator.BindingSource = this.partenerBindingSource;
            this.partenerBindingNavigator.CountItem = null;
            this.partenerBindingNavigator.DeleteItem = null;
            this.partenerBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.partenerBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.partenerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.partenerBindingNavigatorSaveItem});
            this.partenerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.partenerBindingNavigator.MoveFirstItem = null;
            this.partenerBindingNavigator.MoveLastItem = null;
            this.partenerBindingNavigator.MoveNextItem = null;
            this.partenerBindingNavigator.MovePreviousItem = null;
            this.partenerBindingNavigator.Name = "partenerBindingNavigator";
            this.partenerBindingNavigator.PositionItem = null;
            this.partenerBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.partenerBindingNavigator.Size = new System.Drawing.Size(1824, 33);
            this.partenerBindingNavigator.TabIndex = 6;
            this.partenerBindingNavigator.Text = "bindingNavigator1";
            // 
            // partenerBindingSource
            // 
            this.partenerBindingSource.DataSource = typeof(Gestiunea_stocurilor.Partener);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // partenerBindingNavigatorSaveItem
            // 
            this.partenerBindingNavigatorSaveItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.partenerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.partenerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("partenerBindingNavigatorSaveItem.Image")));
            this.partenerBindingNavigatorSaveItem.Name = "partenerBindingNavigatorSaveItem";
            this.partenerBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.partenerBindingNavigatorSaveItem.Text = "Salveaza";
            this.partenerBindingNavigatorSaveItem.Click += new System.EventHandler(this.partenerBindingNavigatorSaveItem_Click);
            // 
            // partenerDataGridView
            // 
            this.partenerDataGridView.AllowUserToAddRows = false;
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
            this.partenerDataGridView.Location = new System.Drawing.Point(46, 142);
            this.partenerDataGridView.Name = "partenerDataGridView";
            this.partenerDataGridView.RowHeadersWidth = 62;
            this.partenerDataGridView.RowTemplate.Height = 28;
            this.partenerDataGridView.Size = new System.Drawing.Size(1732, 457);
            this.partenerDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 61;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CUI";
            this.dataGridViewTextBoxColumn2.HeaderText = "CUI/ CIF";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 81;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TipPartener";
            this.dataGridViewTextBoxColumn3.DisplayStyleForCurrentCellOnly = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Tip partener";
            this.dataGridViewTextBoxColumn3.Items.AddRange(new object[] {
            "Client",
            "Furnizor"});
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.Width = 133;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Denumire";
            this.dataGridViewTextBoxColumn4.HeaderText = "Denumire";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 122;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Localitate";
            this.dataGridViewTextBoxColumn5.HeaderText = "Localitate";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Adresa";
            this.dataGridViewTextBoxColumn6.HeaderText = "Adresa";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ContBancar";
            this.dataGridViewTextBoxColumn7.HeaderText = "Cont bancar";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 131;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Telefon";
            this.dataGridViewTextBoxColumn8.HeaderText = "Telefon";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 103;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Mail";
            this.dataGridViewTextBoxColumn9.HeaderText = "Mail";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 77;
            // 
            // rbTp
            // 
            this.rbTp.AutoSize = true;
            this.rbTp.Font = new System.Drawing.Font("Verdana", 8F);
            this.rbTp.Location = new System.Drawing.Point(282, 58);
            this.rbTp.Name = "rbTp";
            this.rbTp.Size = new System.Drawing.Size(63, 22);
            this.rbTp.TabIndex = 13;
            this.rbTp.TabStop = true;
            this.rbTp.Text = "Toti";
            this.rbTp.UseVisualStyleBackColor = true;
            this.rbTp.CheckedChanged += new System.EventHandler(this.rbTp_CheckedChanged);
            // 
            // rbFz
            // 
            this.rbFz.AutoSize = true;
            this.rbFz.Font = new System.Drawing.Font("Verdana", 8F);
            this.rbFz.Location = new System.Drawing.Point(155, 58);
            this.rbFz.Name = "rbFz";
            this.rbFz.Size = new System.Drawing.Size(103, 22);
            this.rbFz.TabIndex = 12;
            this.rbFz.TabStop = true;
            this.rbFz.Text = "Furnizori";
            this.rbFz.UseVisualStyleBackColor = true;
            this.rbFz.CheckedChanged += new System.EventHandler(this.rbFz_CheckedChanged);
            // 
            // rbCl
            // 
            this.rbCl.AutoSize = true;
            this.rbCl.Font = new System.Drawing.Font("Verdana", 8F);
            this.rbCl.Location = new System.Drawing.Point(46, 58);
            this.rbCl.Name = "rbCl";
            this.rbCl.Size = new System.Drawing.Size(86, 22);
            this.rbCl.TabIndex = 11;
            this.rbCl.TabStop = true;
            this.rbCl.Text = "Clienti";
            this.rbCl.UseVisualStyleBackColor = true;
            this.rbCl.CheckedChanged += new System.EventHandler(this.rbCl_CheckedChanged);
            // 
            // frmModifPartener
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1824, 656);
            this.Controls.Add(this.partenerDataGridView);
            this.Controls.Add(this.rbTp);
            this.Controls.Add(this.rbFz);
            this.Controls.Add(this.rbCl);
            this.Controls.Add(this.partenerBindingNavigator);
            this.Name = "frmModifPartener";
            this.Text = "Editare partener";
            this.Load += new System.EventHandler(this.frmModifPartener_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partenerBindingNavigator)).EndInit();
            this.partenerBindingNavigator.ResumeLayout(false);
            this.partenerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partenerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partenerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource partenerBindingSource;
        private System.Windows.Forms.BindingNavigator partenerBindingNavigator;
        private System.Windows.Forms.ToolStripButton partenerBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView partenerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.RadioButton rbTp;
        private System.Windows.Forms.RadioButton rbFz;
        private System.Windows.Forms.RadioButton rbCl;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

namespace Gestiunea_stocurilor
{
    partial class frmModifPF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModifPF));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.produsFinitBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.produsFinitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.produsFinitBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.produsFinitDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProdus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.produsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.produsFinitBindingNavigator)).BeginInit();
            this.produsFinitBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produsFinitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsFinitDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // produsFinitBindingNavigator
            // 
            this.produsFinitBindingNavigator.AddNewItem = null;
            this.produsFinitBindingNavigator.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.produsFinitBindingNavigator.BindingSource = this.produsFinitBindingSource;
            this.produsFinitBindingNavigator.CountItem = null;
            this.produsFinitBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.produsFinitBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.produsFinitBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.produsFinitBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorDeleteItem,
            this.produsFinitBindingNavigatorSaveItem});
            this.produsFinitBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.produsFinitBindingNavigator.MoveFirstItem = null;
            this.produsFinitBindingNavigator.MoveLastItem = null;
            this.produsFinitBindingNavigator.MoveNextItem = null;
            this.produsFinitBindingNavigator.MovePreviousItem = null;
            this.produsFinitBindingNavigator.Name = "produsFinitBindingNavigator";
            this.produsFinitBindingNavigator.PositionItem = null;
            this.produsFinitBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.produsFinitBindingNavigator.Size = new System.Drawing.Size(523, 33);
            this.produsFinitBindingNavigator.TabIndex = 0;
            this.produsFinitBindingNavigator.Text = "bindingNavigator1";
            // 
            // produsFinitBindingSource
            // 
            this.produsFinitBindingSource.DataSource = typeof(Gestiunea_stocurilor.ProdusFinit);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Sterge";
            // 
            // produsFinitBindingNavigatorSaveItem
            // 
            this.produsFinitBindingNavigatorSaveItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.produsFinitBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.produsFinitBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("produsFinitBindingNavigatorSaveItem.Image")));
            this.produsFinitBindingNavigatorSaveItem.Name = "produsFinitBindingNavigatorSaveItem";
            this.produsFinitBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.produsFinitBindingNavigatorSaveItem.Text = "Salveaza";
            this.produsFinitBindingNavigatorSaveItem.Click += new System.EventHandler(this.produsFinitBindingNavigatorSaveItem_Click);
            // 
            // produsFinitDataGridView
            // 
            this.produsFinitDataGridView.AllowUserToAddRows = false;
            this.produsFinitDataGridView.AutoGenerateColumns = false;
            this.produsFinitDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.produsFinitDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.produsFinitDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.produsFinitDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.produsFinitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produsFinitDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.IdProdus,
            this.dataGridViewComboBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.produsFinitDataGridView.DataSource = this.produsFinitBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.produsFinitDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.produsFinitDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.produsFinitDataGridView.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.produsFinitDataGridView.Location = new System.Drawing.Point(0, 33);
            this.produsFinitDataGridView.Name = "produsFinitDataGridView";
            this.produsFinitDataGridView.RowHeadersWidth = 62;
            this.produsFinitDataGridView.RowTemplate.Height = 28;
            this.produsFinitDataGridView.Size = new System.Drawing.Size(523, 219);
            this.produsFinitDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdProdus";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdProdus";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // IdProdus
            // 
            this.IdProdus.DataPropertyName = "IdProdus";
            this.IdProdus.DataSource = this.produsBindingSource;
            this.IdProdus.DisplayMember = "Cod";
            this.IdProdus.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.IdProdus.DisplayStyleForCurrentCellOnly = true;
            this.IdProdus.HeaderText = "Cod";
            this.IdProdus.MinimumWidth = 8;
            this.IdProdus.Name = "IdProdus";
            this.IdProdus.ReadOnly = true;
            this.IdProdus.ValueMember = "Id";
            this.IdProdus.Width = 45;
            // 
            // produsBindingSource
            // 
            this.produsBindingSource.DataSource = typeof(Gestiunea_stocurilor.Produs);
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.DataPropertyName = "IdProdus";
            this.dataGridViewComboBoxColumn1.DataSource = this.produsBindingSource;
            this.dataGridViewComboBoxColumn1.DisplayMember = "Denumire";
            this.dataGridViewComboBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewComboBoxColumn1.DisplayStyleForCurrentCellOnly = true;
            this.dataGridViewComboBoxColumn1.HeaderText = "Denumire";
            this.dataGridViewComboBoxColumn1.MinimumWidth = 8;
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.ReadOnly = true;
            this.dataGridViewComboBoxColumn1.ValueMember = "Id";
            this.dataGridViewComboBoxColumn1.Width = 92;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CostStandard";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cost standard";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 146;
            // 
            // frmModifPF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(523, 252);
            this.Controls.Add(this.produsFinitDataGridView);
            this.Controls.Add(this.produsFinitBindingNavigator);
            this.Name = "frmModifPF";
            this.Text = "Editare produs finit";
            this.Load += new System.EventHandler(this.frmModifPF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produsFinitBindingNavigator)).EndInit();
            this.produsFinitBindingNavigator.ResumeLayout(false);
            this.produsFinitBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produsFinitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsFinitDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource produsFinitBindingSource;
        private System.Windows.Forms.BindingNavigator produsFinitBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton produsFinitBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView produsFinitDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn IdProdus;
        private System.Windows.Forms.BindingSource produsBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}
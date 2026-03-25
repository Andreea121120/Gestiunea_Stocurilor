
namespace Gestiunea_stocurilor
{
    partial class frmModifMP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModifMP));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materiePrimaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.materiePrimaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.materiePrimaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.materiePrimaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProdus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.produsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.materiePrimaBindingNavigator)).BeginInit();
            this.materiePrimaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materiePrimaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiePrimaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // materiePrimaBindingNavigator
            // 
            this.materiePrimaBindingNavigator.AddNewItem = null;
            this.materiePrimaBindingNavigator.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materiePrimaBindingNavigator.BindingSource = this.materiePrimaBindingSource;
            this.materiePrimaBindingNavigator.CountItem = null;
            this.materiePrimaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.materiePrimaBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.materiePrimaBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.materiePrimaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorDeleteItem,
            this.materiePrimaBindingNavigatorSaveItem});
            this.materiePrimaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.materiePrimaBindingNavigator.MoveFirstItem = null;
            this.materiePrimaBindingNavigator.MoveLastItem = null;
            this.materiePrimaBindingNavigator.MoveNextItem = null;
            this.materiePrimaBindingNavigator.MovePreviousItem = null;
            this.materiePrimaBindingNavigator.Name = "materiePrimaBindingNavigator";
            this.materiePrimaBindingNavigator.PositionItem = null;
            this.materiePrimaBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.materiePrimaBindingNavigator.Size = new System.Drawing.Size(523, 33);
            this.materiePrimaBindingNavigator.TabIndex = 0;
            this.materiePrimaBindingNavigator.Text = "bindingNavigator1";
            // 
            // materiePrimaBindingSource
            // 
            this.materiePrimaBindingSource.DataSource = typeof(Gestiunea_stocurilor.MateriePrima);
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
            // materiePrimaBindingNavigatorSaveItem
            // 
            this.materiePrimaBindingNavigatorSaveItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.materiePrimaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.materiePrimaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("materiePrimaBindingNavigatorSaveItem.Image")));
            this.materiePrimaBindingNavigatorSaveItem.Name = "materiePrimaBindingNavigatorSaveItem";
            this.materiePrimaBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.materiePrimaBindingNavigatorSaveItem.Text = "Salveaza";
            this.materiePrimaBindingNavigatorSaveItem.Click += new System.EventHandler(this.materiePrimaBindingNavigatorSaveItem_Click);
            // 
            // materiePrimaDataGridView
            // 
            this.materiePrimaDataGridView.AllowUserToAddRows = false;
            this.materiePrimaDataGridView.AutoGenerateColumns = false;
            this.materiePrimaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.materiePrimaDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materiePrimaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.materiePrimaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.materiePrimaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materiePrimaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.IdProdus,
            this.dataGridViewComboBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.materiePrimaDataGridView.DataSource = this.materiePrimaBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.materiePrimaDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.materiePrimaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materiePrimaDataGridView.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materiePrimaDataGridView.Location = new System.Drawing.Point(0, 33);
            this.materiePrimaDataGridView.Name = "materiePrimaDataGridView";
            this.materiePrimaDataGridView.RowHeadersWidth = 62;
            this.materiePrimaDataGridView.RowTemplate.Height = 28;
            this.materiePrimaDataGridView.Size = new System.Drawing.Size(523, 255);
            this.materiePrimaDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PretEstimatMP";
            this.dataGridViewTextBoxColumn2.HeaderText = "Pret estimat";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 134;
            // 
            // frmModifMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(523, 288);
            this.Controls.Add(this.materiePrimaDataGridView);
            this.Controls.Add(this.materiePrimaBindingNavigator);
            this.Name = "frmModifMP";
            this.Text = "Editare materie prima";
            this.Load += new System.EventHandler(this.frmModifMP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materiePrimaBindingNavigator)).EndInit();
            this.materiePrimaBindingNavigator.ResumeLayout(false);
            this.materiePrimaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materiePrimaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiePrimaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource materiePrimaBindingSource;
        private System.Windows.Forms.BindingNavigator materiePrimaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton materiePrimaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView materiePrimaDataGridView;
        private System.Windows.Forms.BindingSource produsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn IdProdus;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}
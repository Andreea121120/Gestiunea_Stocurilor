
namespace Gestiunea_stocurilor
{
    partial class frmModifProdRep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModifProdRep));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.produsGestionatBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.produsGestionatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.produsGestionatBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.produsGestionatDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.produsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.depozitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.produsGestionatBindingNavigator)).BeginInit();
            this.produsGestionatBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produsGestionatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsGestionatDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depozitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // produsGestionatBindingNavigator
            // 
            this.produsGestionatBindingNavigator.AddNewItem = null;
            this.produsGestionatBindingNavigator.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.produsGestionatBindingNavigator.BindingSource = this.produsGestionatBindingSource;
            this.produsGestionatBindingNavigator.CountItem = null;
            this.produsGestionatBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.produsGestionatBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.produsGestionatBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.produsGestionatBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorDeleteItem,
            this.produsGestionatBindingNavigatorSaveItem});
            this.produsGestionatBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.produsGestionatBindingNavigator.MoveFirstItem = null;
            this.produsGestionatBindingNavigator.MoveLastItem = null;
            this.produsGestionatBindingNavigator.MoveNextItem = null;
            this.produsGestionatBindingNavigator.MovePreviousItem = null;
            this.produsGestionatBindingNavigator.Name = "produsGestionatBindingNavigator";
            this.produsGestionatBindingNavigator.PositionItem = null;
            this.produsGestionatBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.produsGestionatBindingNavigator.Size = new System.Drawing.Size(1244, 33);
            this.produsGestionatBindingNavigator.TabIndex = 0;
            this.produsGestionatBindingNavigator.Text = "bindingNavigator1";
            // 
            // produsGestionatBindingSource
            // 
            this.produsGestionatBindingSource.DataSource = typeof(Gestiunea_stocurilor.ProdusGestionat);
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
            // produsGestionatBindingNavigatorSaveItem
            // 
            this.produsGestionatBindingNavigatorSaveItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.produsGestionatBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.produsGestionatBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("produsGestionatBindingNavigatorSaveItem.Image")));
            this.produsGestionatBindingNavigatorSaveItem.Name = "produsGestionatBindingNavigatorSaveItem";
            this.produsGestionatBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.produsGestionatBindingNavigatorSaveItem.Text = "Salveaza";
            this.produsGestionatBindingNavigatorSaveItem.Click += new System.EventHandler(this.produsGestionatBindingNavigatorSaveItem_Click);
            // 
            // produsGestionatDataGridView
            // 
            this.produsGestionatDataGridView.AllowUserToAddRows = false;
            this.produsGestionatDataGridView.AutoGenerateColumns = false;
            this.produsGestionatDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.produsGestionatDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.produsGestionatDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.produsGestionatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produsGestionatDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.Pret});
            this.produsGestionatDataGridView.DataSource = this.produsGestionatBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.produsGestionatDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.produsGestionatDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.produsGestionatDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.produsGestionatDataGridView.Location = new System.Drawing.Point(0, 33);
            this.produsGestionatDataGridView.Name = "produsGestionatDataGridView";
            this.produsGestionatDataGridView.RowHeadersWidth = 62;
            this.produsGestionatDataGridView.RowTemplate.Height = 28;
            this.produsGestionatDataGridView.Size = new System.Drawing.Size(1244, 586);
            this.produsGestionatDataGridView.TabIndex = 1;
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
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdDepozit";
            this.dataGridViewTextBoxColumn2.DataSource = this.depozitBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Denumire";
            this.dataGridViewTextBoxColumn2.DisplayStyleForCurrentCellOnly = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Depozit";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "Id";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // depozitBindingSource
            // 
            this.depozitBindingSource.DataSource = typeof(Gestiunea_stocurilor.Depozit);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "StocInitial";
            this.dataGridViewTextBoxColumn4.HeaderText = "Stoc initial";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // Pret
            // 
            this.Pret.DataPropertyName = "Pret";
            this.Pret.HeaderText = "Pret";
            this.Pret.MinimumWidth = 8;
            this.Pret.Name = "Pret";
            this.Pret.Width = 150;
            // 
            // frmModifProdRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1244, 619);
            this.Controls.Add(this.produsGestionatDataGridView);
            this.Controls.Add(this.produsGestionatBindingNavigator);
            this.Name = "frmModifProdRep";
            this.Text = "Editare produs repartizat";
            this.Load += new System.EventHandler(this.frmModifProdRep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produsGestionatBindingNavigator)).EndInit();
            this.produsGestionatBindingNavigator.ResumeLayout(false);
            this.produsGestionatBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produsGestionatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsGestionatDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depozitBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource produsGestionatBindingSource;
        private System.Windows.Forms.BindingNavigator produsGestionatBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton produsGestionatBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView produsGestionatDataGridView;
        private System.Windows.Forms.BindingSource depozitBindingSource;
        private System.Windows.Forms.BindingSource produsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pret;
    }
}
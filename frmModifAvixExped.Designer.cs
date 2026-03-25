
namespace Gestiunea_stocurilor
{
    partial class frmModifAvixExped
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModifAvixExped));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.avizExpeditieBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.avizExpeditieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.avizExpeditieBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.avizExpeditieDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdFactura = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.depozitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.avizExpeditieBindingNavigator)).BeginInit();
            this.avizExpeditieBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avizExpeditieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avizExpeditieDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depozitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // avizExpeditieBindingNavigator
            // 
            this.avizExpeditieBindingNavigator.AddNewItem = null;
            this.avizExpeditieBindingNavigator.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.avizExpeditieBindingNavigator.BindingSource = this.avizExpeditieBindingSource;
            this.avizExpeditieBindingNavigator.CountItem = null;
            this.avizExpeditieBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.avizExpeditieBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.avizExpeditieBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.avizExpeditieBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorDeleteItem,
            this.avizExpeditieBindingNavigatorSaveItem});
            this.avizExpeditieBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.avizExpeditieBindingNavigator.MoveFirstItem = null;
            this.avizExpeditieBindingNavigator.MoveLastItem = null;
            this.avizExpeditieBindingNavigator.MoveNextItem = null;
            this.avizExpeditieBindingNavigator.MovePreviousItem = null;
            this.avizExpeditieBindingNavigator.Name = "avizExpeditieBindingNavigator";
            this.avizExpeditieBindingNavigator.PositionItem = null;
            this.avizExpeditieBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.avizExpeditieBindingNavigator.Size = new System.Drawing.Size(1106, 33);
            this.avizExpeditieBindingNavigator.TabIndex = 0;
            this.avizExpeditieBindingNavigator.Text = "bindingNavigator1";
            // 
            // avizExpeditieBindingSource
            // 
            this.avizExpeditieBindingSource.DataSource = typeof(Gestiunea_stocurilor.AvizExpeditie);
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
            // avizExpeditieBindingNavigatorSaveItem
            // 
            this.avizExpeditieBindingNavigatorSaveItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.avizExpeditieBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.avizExpeditieBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("avizExpeditieBindingNavigatorSaveItem.Image")));
            this.avizExpeditieBindingNavigatorSaveItem.Name = "avizExpeditieBindingNavigatorSaveItem";
            this.avizExpeditieBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.avizExpeditieBindingNavigatorSaveItem.Text = "Salveaza";
            this.avizExpeditieBindingNavigatorSaveItem.Click += new System.EventHandler(this.avizExpeditieBindingNavigatorSaveItem_Click);
            // 
            // avizExpeditieDataGridView
            // 
            this.avizExpeditieDataGridView.AllowUserToAddRows = false;
            this.avizExpeditieDataGridView.AutoGenerateColumns = false;
            this.avizExpeditieDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.avizExpeditieDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.avizExpeditieDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.avizExpeditieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.avizExpeditieDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.IdFactura,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            this.avizExpeditieDataGridView.DataSource = this.avizExpeditieBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.avizExpeditieDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.avizExpeditieDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avizExpeditieDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.avizExpeditieDataGridView.Location = new System.Drawing.Point(0, 33);
            this.avizExpeditieDataGridView.Name = "avizExpeditieDataGridView";
            this.avizExpeditieDataGridView.RowHeadersWidth = 62;
            this.avizExpeditieDataGridView.RowTemplate.Height = 28;
            this.avizExpeditieDataGridView.Size = new System.Drawing.Size(1106, 417);
            this.avizExpeditieDataGridView.TabIndex = 1;
            this.avizExpeditieDataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.avizExpeditieDataGridView_RowValidating);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Numar";
            this.dataGridViewTextBoxColumn3.HeaderText = "Numar";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // IdFactura
            // 
            this.IdFactura.DataPropertyName = "IdFactura";
            this.IdFactura.DataSource = this.facturaBindingSource;
            this.IdFactura.DisplayMember = "Numar";
            this.IdFactura.DisplayStyleForCurrentCellOnly = true;
            this.IdFactura.HeaderText = "Factura";
            this.IdFactura.MinimumWidth = 8;
            this.IdFactura.Name = "IdFactura";
            this.IdFactura.ValueMember = "Id";
            this.IdFactura.Width = 150;
            // 
            // facturaBindingSource
            // 
            this.facturaBindingSource.DataSource = typeof(Gestiunea_stocurilor.Factura);
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn4.HeaderText = "Data";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // frmModifAvixExped
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1106, 450);
            this.Controls.Add(this.avizExpeditieDataGridView);
            this.Controls.Add(this.avizExpeditieBindingNavigator);
            this.Name = "frmModifAvixExped";
            this.Text = "Editare aviz expediere";
            this.Load += new System.EventHandler(this.frmModifAvixExped_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avizExpeditieBindingNavigator)).EndInit();
            this.avizExpeditieBindingNavigator.ResumeLayout(false);
            this.avizExpeditieBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avizExpeditieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avizExpeditieDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depozitBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource avizExpeditieBindingSource;
        private System.Windows.Forms.BindingNavigator avizExpeditieBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton avizExpeditieBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView avizExpeditieDataGridView;
        private System.Windows.Forms.BindingSource depozitBindingSource;
        private System.Windows.Forms.BindingSource facturaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn IdFactura;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
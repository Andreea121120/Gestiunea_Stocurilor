
namespace Gestiunea_stocurilor
{
    partial class frmModifNIR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModifNIR));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nIRBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.nIRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.nIRBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nIRDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.depozitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nIRBindingNavigator)).BeginInit();
            this.nIRBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nIRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIRDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depozitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nIRBindingNavigator
            // 
            this.nIRBindingNavigator.AddNewItem = null;
            this.nIRBindingNavigator.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nIRBindingNavigator.BindingSource = this.nIRBindingSource;
            this.nIRBindingNavigator.CountItem = null;
            this.nIRBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.nIRBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.nIRBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.nIRBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorDeleteItem,
            this.nIRBindingNavigatorSaveItem});
            this.nIRBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.nIRBindingNavigator.MoveFirstItem = null;
            this.nIRBindingNavigator.MoveLastItem = null;
            this.nIRBindingNavigator.MoveNextItem = null;
            this.nIRBindingNavigator.MovePreviousItem = null;
            this.nIRBindingNavigator.Name = "nIRBindingNavigator";
            this.nIRBindingNavigator.PositionItem = null;
            this.nIRBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.nIRBindingNavigator.Size = new System.Drawing.Size(1217, 33);
            this.nIRBindingNavigator.TabIndex = 0;
            this.nIRBindingNavigator.Text = "bindingNavigator1";
            // 
            // nIRBindingSource
            // 
            this.nIRBindingSource.DataSource = typeof(Gestiunea_stocurilor.NIR);
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
            // nIRBindingNavigatorSaveItem
            // 
            this.nIRBindingNavigatorSaveItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.nIRBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nIRBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("nIRBindingNavigatorSaveItem.Image")));
            this.nIRBindingNavigatorSaveItem.Name = "nIRBindingNavigatorSaveItem";
            this.nIRBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.nIRBindingNavigatorSaveItem.Text = "Salvare";
            this.nIRBindingNavigatorSaveItem.Click += new System.EventHandler(this.nIRBindingNavigatorSaveItem_Click);
            // 
            // nIRDataGridView
            // 
            this.nIRDataGridView.AllowUserToAddRows = false;
            this.nIRDataGridView.AutoGenerateColumns = false;
            this.nIRDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nIRDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nIRDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.nIRDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nIRDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.nIRDataGridView.DataSource = this.nIRBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.nIRDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.nIRDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nIRDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.nIRDataGridView.Location = new System.Drawing.Point(0, 33);
            this.nIRDataGridView.Name = "nIRDataGridView";
            this.nIRDataGridView.RowHeadersWidth = 62;
            this.nIRDataGridView.RowTemplate.Height = 28;
            this.nIRDataGridView.Size = new System.Drawing.Size(1217, 656);
            this.nIRDataGridView.TabIndex = 1;
            this.nIRDataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.nIRDataGridView_RowValidating);
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
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Numar";
            this.dataGridViewTextBoxColumn4.HeaderText = "Numar";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
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
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdFactura";
            this.dataGridViewTextBoxColumn3.DataSource = this.facturaBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Numar";
            this.dataGridViewTextBoxColumn3.DisplayStyleForCurrentCellOnly = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Factura";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "Id";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // facturaBindingSource
            // 
            this.facturaBindingSource.DataSource = typeof(Gestiunea_stocurilor.Factura);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn5.HeaderText = "Data";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // frmModifNIR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1217, 689);
            this.Controls.Add(this.nIRDataGridView);
            this.Controls.Add(this.nIRBindingNavigator);
            this.Name = "frmModifNIR";
            this.Text = "Editare NIR";
            this.Load += new System.EventHandler(this.frmModifNIR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nIRBindingNavigator)).EndInit();
            this.nIRBindingNavigator.ResumeLayout(false);
            this.nIRBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nIRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIRDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depozitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource nIRBindingSource;
        private System.Windows.Forms.BindingNavigator nIRBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton nIRBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView nIRDataGridView;
        private System.Windows.Forms.BindingSource depozitBindingSource;
        private System.Windows.Forms.BindingSource facturaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}
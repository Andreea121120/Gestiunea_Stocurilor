
namespace Gestiunea_stocurilor
{
    partial class frmModifFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModifFactura));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.facturaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.facturaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.facturaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPartenerFurnizor = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.partenerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IdPartenerClient = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.partenerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingNavigator)).BeginInit();
            this.facturaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partenerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partenerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // facturaBindingNavigator
            // 
            this.facturaBindingNavigator.AddNewItem = null;
            this.facturaBindingNavigator.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.facturaBindingNavigator.BindingSource = this.facturaBindingSource;
            this.facturaBindingNavigator.CountItem = null;
            this.facturaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.facturaBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.facturaBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.facturaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorDeleteItem,
            this.facturaBindingNavigatorSaveItem});
            this.facturaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.facturaBindingNavigator.MoveFirstItem = null;
            this.facturaBindingNavigator.MoveLastItem = null;
            this.facturaBindingNavigator.MoveNextItem = null;
            this.facturaBindingNavigator.MovePreviousItem = null;
            this.facturaBindingNavigator.Name = "facturaBindingNavigator";
            this.facturaBindingNavigator.PositionItem = null;
            this.facturaBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.facturaBindingNavigator.Size = new System.Drawing.Size(1642, 33);
            this.facturaBindingNavigator.TabIndex = 0;
            this.facturaBindingNavigator.Text = "bindingNavigator1";
            // 
            // facturaBindingSource
            // 
            this.facturaBindingSource.DataSource = typeof(Gestiunea_stocurilor.Factura);
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
            // facturaBindingNavigatorSaveItem
            // 
            this.facturaBindingNavigatorSaveItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.facturaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.facturaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("facturaBindingNavigatorSaveItem.Image")));
            this.facturaBindingNavigatorSaveItem.Name = "facturaBindingNavigatorSaveItem";
            this.facturaBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.facturaBindingNavigatorSaveItem.Text = "Salveaza";
            this.facturaBindingNavigatorSaveItem.Click += new System.EventHandler(this.facturaBindingNavigatorSaveItem_Click);
            // 
            // facturaDataGridView
            // 
            this.facturaDataGridView.AllowUserToAddRows = false;
            this.facturaDataGridView.AutoGenerateColumns = false;
            this.facturaDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.facturaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.facturaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.facturaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facturaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.IdPartenerFurnizor,
            this.IdPartenerClient,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.facturaDataGridView.DataSource = this.facturaBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.facturaDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.facturaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.facturaDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.facturaDataGridView.Location = new System.Drawing.Point(0, 33);
            this.facturaDataGridView.Name = "facturaDataGridView";
            this.facturaDataGridView.RowHeadersWidth = 62;
            this.facturaDataGridView.RowTemplate.Height = 28;
            this.facturaDataGridView.Size = new System.Drawing.Size(1642, 649);
            this.facturaDataGridView.TabIndex = 1;
            this.facturaDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.facturaDataGridView_CellValueChanged);
            this.facturaDataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.facturaDataGridView_RowValidating);
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
            // IdPartenerFurnizor
            // 
            this.IdPartenerFurnizor.DataPropertyName = "IdPartenerFurnizor";
            this.IdPartenerFurnizor.DataSource = this.partenerBindingSource;
            this.IdPartenerFurnizor.DisplayMember = "Denumire";
            this.IdPartenerFurnizor.DisplayStyleForCurrentCellOnly = true;
            this.IdPartenerFurnizor.HeaderText = "Furnizor";
            this.IdPartenerFurnizor.MinimumWidth = 8;
            this.IdPartenerFurnizor.Name = "IdPartenerFurnizor";
            this.IdPartenerFurnizor.ValueMember = "Id";
            this.IdPartenerFurnizor.Width = 150;
            // 
            // partenerBindingSource
            // 
            this.partenerBindingSource.DataSource = typeof(Gestiunea_stocurilor.Partener);
            // 
            // IdPartenerClient
            // 
            this.IdPartenerClient.DataPropertyName = "IdPartenerClient";
            this.IdPartenerClient.DataSource = this.partenerBindingSource1;
            this.IdPartenerClient.DisplayMember = "Denumire";
            this.IdPartenerClient.DisplayStyleForCurrentCellOnly = true;
            this.IdPartenerClient.HeaderText = "Client";
            this.IdPartenerClient.MinimumWidth = 8;
            this.IdPartenerClient.Name = "IdPartenerClient";
            this.IdPartenerClient.ValueMember = "Id";
            this.IdPartenerClient.Width = 150;
            // 
            // partenerBindingSource1
            // 
            this.partenerBindingSource1.DataSource = typeof(Gestiunea_stocurilor.Partener);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Serie";
            this.dataGridViewTextBoxColumn4.HeaderText = "Serie";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn5.HeaderText = "Data";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Explicatii";
            this.dataGridViewTextBoxColumn6.HeaderText = "Explicatii";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // frmModifFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1642, 682);
            this.Controls.Add(this.facturaDataGridView);
            this.Controls.Add(this.facturaBindingNavigator);
            this.Name = "frmModifFactura";
            this.Text = "Editare factura";
            this.Load += new System.EventHandler(this.frmModifFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingNavigator)).EndInit();
            this.facturaBindingNavigator.ResumeLayout(false);
            this.facturaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partenerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partenerBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource facturaBindingSource;
        private System.Windows.Forms.BindingNavigator facturaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton facturaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView facturaDataGridView;
        private System.Windows.Forms.BindingSource partenerBindingSource;
        private System.Windows.Forms.BindingSource partenerBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn IdPartenerFurnizor;
        private System.Windows.Forms.DataGridViewComboBoxColumn IdPartenerClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}
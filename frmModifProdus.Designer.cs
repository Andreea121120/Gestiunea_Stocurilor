
namespace Gestiunea_stocurilor
{
    partial class frmModifProdus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModifProdus));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.produsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.produsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.produsDataGridView = new System.Windows.Forms.DataGridView();
            this.Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipProdus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitateDeMasura = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingNavigator)).BeginInit();
            this.produsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // produsBindingNavigator
            // 
            this.produsBindingNavigator.AddNewItem = null;
            this.produsBindingNavigator.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.produsBindingNavigator.BindingSource = this.produsBindingSource;
            this.produsBindingNavigator.CountItem = null;
            this.produsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.produsBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.produsBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.produsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton1,
            this.bindingNavigatorDeleteItem,
            this.produsBindingNavigatorSaveItem});
            this.produsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.produsBindingNavigator.MoveFirstItem = null;
            this.produsBindingNavigator.MoveLastItem = null;
            this.produsBindingNavigator.MoveNextItem = null;
            this.produsBindingNavigator.MovePreviousItem = null;
            this.produsBindingNavigator.Name = "produsBindingNavigator";
            this.produsBindingNavigator.PositionItem = null;
            this.produsBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.produsBindingNavigator.Size = new System.Drawing.Size(965, 33);
            this.produsBindingNavigator.TabIndex = 0;
            this.produsBindingNavigator.Text = "bindingNavigator1";
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
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton2.Text = "Stoc produs";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton1.Text = "Seteaza categorie";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // produsBindingNavigatorSaveItem
            // 
            this.produsBindingNavigatorSaveItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.produsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.produsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("produsBindingNavigatorSaveItem.Image")));
            this.produsBindingNavigatorSaveItem.Name = "produsBindingNavigatorSaveItem";
            this.produsBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.produsBindingNavigatorSaveItem.Text = "Salvare";
            this.produsBindingNavigatorSaveItem.Click += new System.EventHandler(this.produsBindingNavigatorSaveItem_Click);
            // 
            // produsDataGridView
            // 
            this.produsDataGridView.AllowUserToAddRows = false;
            this.produsDataGridView.AutoGenerateColumns = false;
            this.produsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.produsDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.produsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.produsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.produsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9,
            this.Cod,
            this.dataGridViewTextBoxColumn10,
            this.TipProdus,
            this.UnitateDeMasura});
            this.produsDataGridView.DataSource = this.produsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.produsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.produsDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.produsDataGridView.Location = new System.Drawing.Point(51, 146);
            this.produsDataGridView.Name = "produsDataGridView";
            this.produsDataGridView.RowHeadersWidth = 62;
            this.produsDataGridView.RowTemplate.Height = 28;
            this.produsDataGridView.Size = new System.Drawing.Size(937, 399);
            this.produsDataGridView.TabIndex = 9;
            this.produsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.produsDataGridView_CellContentClick);
            this.produsDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.produsDataGridView_CellFormatting);
            // 
            // Cod
            // 
            this.Cod.DataPropertyName = "Cod";
            this.Cod.HeaderText = "Cod";
            this.Cod.MinimumWidth = 8;
            this.Cod.Name = "Cod";
            this.Cod.Width = 75;
            // 
            // TipProdus
            // 
            this.TipProdus.HeaderText = "Tip produs";
            this.TipProdus.MinimumWidth = 8;
            this.TipProdus.Name = "TipProdus";
            this.TipProdus.ReadOnly = true;
            this.TipProdus.Width = 120;
            // 
            // UnitateDeMasura
            // 
            this.UnitateDeMasura.DataPropertyName = "UnitateDeMasura";
            this.UnitateDeMasura.DisplayStyleForCurrentCellOnly = true;
            this.UnitateDeMasura.HeaderText = "UnitateDeMasura";
            this.UnitateDeMasura.Items.AddRange(new object[] {
            "buc",
            "g",
            "kg",
            "L",
            "m"});
            this.UnitateDeMasura.MinimumWidth = 7;
            this.UnitateDeMasura.Name = "UnitateDeMasura";
            this.UnitateDeMasura.Width = 155;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8F);
            this.label1.Location = new System.Drawing.Point(47, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cod:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 8F);
            this.textBox1.Location = new System.Drawing.Point(158, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 27);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn7.HeaderText = "Id produs";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            this.dataGridViewTextBoxColumn7.Width = 122;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Cod";
            this.dataGridViewTextBoxColumn9.HeaderText = "Aceeseaza tip produs";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn9.Width = 152;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Denumire";
            this.dataGridViewTextBoxColumn10.HeaderText = "Denumire";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 122;
            // 
            // produsBindingSource
            // 
            this.produsBindingSource.DataSource = typeof(Gestiunea_stocurilor.Produs);
            this.produsBindingSource.CurrentChanged += new System.EventHandler(this.produsBindingSource_CurrentChanged);
            // 
            // frmModifProdus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(965, 585);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.produsDataGridView);
            this.Controls.Add(this.produsBindingNavigator);
            this.Name = "frmModifProdus";
            this.Text = "Editare produs";
            this.Load += new System.EventHandler(this.frmModifProdus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingNavigator)).EndInit();
            this.produsBindingNavigator.ResumeLayout(false);
            this.produsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource produsBindingSource;
        private System.Windows.Forms.BindingNavigator produsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton produsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView produsDataGridView;
        private System.Windows.Forms.Label label1;
      
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipProdus;
        private System.Windows.Forms.DataGridViewComboBoxColumn UnitateDeMasura;
    }
}
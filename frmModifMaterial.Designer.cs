
namespace Gestiunea_stocurilor
{
    partial class frmModifMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModifMaterial));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.materialBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.materialDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProdus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.produsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingNavigator)).BeginInit();
            this.materialBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // materialBindingNavigator
            // 
            this.materialBindingNavigator.AddNewItem = null;
            this.materialBindingNavigator.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialBindingNavigator.BindingSource = this.materialBindingSource;
            this.materialBindingNavigator.CountItem = null;
            this.materialBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.materialBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.materialBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.materialBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorDeleteItem,
            this.materialBindingNavigatorSaveItem});
            this.materialBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.materialBindingNavigator.MoveFirstItem = null;
            this.materialBindingNavigator.MoveLastItem = null;
            this.materialBindingNavigator.MoveNextItem = null;
            this.materialBindingNavigator.MovePreviousItem = null;
            this.materialBindingNavigator.Name = "materialBindingNavigator";
            this.materialBindingNavigator.PositionItem = null;
            this.materialBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.materialBindingNavigator.Size = new System.Drawing.Size(540, 33);
            this.materialBindingNavigator.TabIndex = 0;
            this.materialBindingNavigator.Text = "bindingNavigator1";
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataSource = typeof(Gestiunea_stocurilor.Material);
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
            // materialBindingNavigatorSaveItem
            // 
            this.materialBindingNavigatorSaveItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.materialBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.materialBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("materialBindingNavigatorSaveItem.Image")));
            this.materialBindingNavigatorSaveItem.Name = "materialBindingNavigatorSaveItem";
            this.materialBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.materialBindingNavigatorSaveItem.Text = "Salveaza";
            this.materialBindingNavigatorSaveItem.Click += new System.EventHandler(this.materialBindingNavigatorSaveItem_Click);
            // 
            // materialDataGridView
            // 
            this.materialDataGridView.AllowUserToAddRows = false;
            this.materialDataGridView.AutoGenerateColumns = false;
            this.materialDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.materialDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.materialDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.materialDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.IdProdus,
            this.dataGridViewComboBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.materialDataGridView.DataSource = this.materialBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.materialDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.materialDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialDataGridView.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialDataGridView.Location = new System.Drawing.Point(0, 33);
            this.materialDataGridView.Name = "materialDataGridView";
            this.materialDataGridView.RowHeadersWidth = 62;
            this.materialDataGridView.RowTemplate.Height = 28;
            this.materialDataGridView.Size = new System.Drawing.Size(540, 224);
            this.materialDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PretEstimatMat";
            this.dataGridViewTextBoxColumn2.HeaderText = "Pret estimat";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 146;
            // 
            // frmModifMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(540, 257);
            this.Controls.Add(this.materialDataGridView);
            this.Controls.Add(this.materialBindingNavigator);
            this.Name = "frmModifMaterial";
            this.Text = "Editare material";
            this.Load += new System.EventHandler(this.frmModifMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingNavigator)).EndInit();
            this.materialBindingNavigator.ResumeLayout(false);
            this.materialBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource materialBindingSource;
        private System.Windows.Forms.BindingNavigator materialBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton materialBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView materialDataGridView;
        private System.Windows.Forms.BindingSource produsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn IdProdus;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}
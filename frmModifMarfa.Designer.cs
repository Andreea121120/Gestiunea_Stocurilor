
namespace Gestiunea_stocurilor
{
    partial class frmModifMarfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModifMarfa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.marfaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.marfaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.marfaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.marfaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProdus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.produsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.marfaBindingNavigator)).BeginInit();
            this.marfaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marfaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marfaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // marfaBindingNavigator
            // 
            this.marfaBindingNavigator.AddNewItem = null;
            this.marfaBindingNavigator.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.marfaBindingNavigator.BindingSource = this.marfaBindingSource;
            this.marfaBindingNavigator.CountItem = null;
            this.marfaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.marfaBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.marfaBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.marfaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorDeleteItem,
            this.marfaBindingNavigatorSaveItem});
            this.marfaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.marfaBindingNavigator.MoveFirstItem = null;
            this.marfaBindingNavigator.MoveLastItem = null;
            this.marfaBindingNavigator.MoveNextItem = null;
            this.marfaBindingNavigator.MovePreviousItem = null;
            this.marfaBindingNavigator.Name = "marfaBindingNavigator";
            this.marfaBindingNavigator.PositionItem = null;
            this.marfaBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.marfaBindingNavigator.Size = new System.Drawing.Size(557, 33);
            this.marfaBindingNavigator.TabIndex = 0;
            this.marfaBindingNavigator.Text = "bindingNavigator1";
            // 
            // marfaBindingSource
            // 
            this.marfaBindingSource.DataSource = typeof(Gestiunea_stocurilor.Marfa);
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
            // marfaBindingNavigatorSaveItem
            // 
            this.marfaBindingNavigatorSaveItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.marfaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.marfaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("marfaBindingNavigatorSaveItem.Image")));
            this.marfaBindingNavigatorSaveItem.Name = "marfaBindingNavigatorSaveItem";
            this.marfaBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.marfaBindingNavigatorSaveItem.Text = "Salveaza";
            this.marfaBindingNavigatorSaveItem.Click += new System.EventHandler(this.marfaBindingNavigatorSaveItem_Click);
            // 
            // marfaDataGridView
            // 
            this.marfaDataGridView.AllowUserToAddRows = false;
            this.marfaDataGridView.AutoGenerateColumns = false;
            this.marfaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.marfaDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.marfaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.marfaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.marfaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.marfaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.IdProdus,
            this.dataGridViewComboBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.marfaDataGridView.DataSource = this.marfaBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.marfaDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.marfaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.marfaDataGridView.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.marfaDataGridView.Location = new System.Drawing.Point(0, 33);
            this.marfaDataGridView.Name = "marfaDataGridView";
            this.marfaDataGridView.RowHeadersWidth = 62;
            this.marfaDataGridView.RowTemplate.Height = 28;
            this.marfaDataGridView.Size = new System.Drawing.Size(557, 231);
            this.marfaDataGridView.TabIndex = 1;
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
            this.IdProdus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdProdus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IdProdus.ValueMember = "Id";
            this.IdProdus.Width = 75;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PretStandardMf";
            this.dataGridViewTextBoxColumn2.HeaderText = "Pret standard";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 143;
            // 
            // frmModifMarfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(557, 264);
            this.Controls.Add(this.marfaDataGridView);
            this.Controls.Add(this.marfaBindingNavigator);
            this.Name = "frmModifMarfa";
            this.Text = "Editare marfa";
            this.Load += new System.EventHandler(this.frmModifMarfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marfaBindingNavigator)).EndInit();
            this.marfaBindingNavigator.ResumeLayout(false);
            this.marfaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marfaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marfaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource marfaBindingSource;
        private System.Windows.Forms.BindingNavigator marfaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton marfaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView marfaDataGridView;
        private System.Windows.Forms.BindingSource produsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn IdProdus;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}
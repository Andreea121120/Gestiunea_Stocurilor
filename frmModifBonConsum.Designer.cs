
namespace Gestiunea_stocurilor
{
    partial class frmModifBonConsum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModifBonConsum));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bonConsumBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bonConsumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bonConsumBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bonConsumDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.depozitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bonConsumBindingNavigator)).BeginInit();
            this.bonConsumBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bonConsumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonConsumDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depozitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bonConsumBindingNavigator
            // 
            this.bonConsumBindingNavigator.AddNewItem = null;
            this.bonConsumBindingNavigator.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bonConsumBindingNavigator.BindingSource = this.bonConsumBindingSource;
            this.bonConsumBindingNavigator.CountItem = null;
            this.bonConsumBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bonConsumBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bonConsumBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bonConsumBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorDeleteItem,
            this.bonConsumBindingNavigatorSaveItem});
            this.bonConsumBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bonConsumBindingNavigator.MoveFirstItem = null;
            this.bonConsumBindingNavigator.MoveLastItem = null;
            this.bonConsumBindingNavigator.MoveNextItem = null;
            this.bonConsumBindingNavigator.MovePreviousItem = null;
            this.bonConsumBindingNavigator.Name = "bonConsumBindingNavigator";
            this.bonConsumBindingNavigator.PositionItem = null;
            this.bonConsumBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bonConsumBindingNavigator.Size = new System.Drawing.Size(1096, 33);
            this.bonConsumBindingNavigator.TabIndex = 0;
            this.bonConsumBindingNavigator.Text = "bindingNavigator1";
            // 
            // bonConsumBindingSource
            // 
            this.bonConsumBindingSource.DataSource = typeof(Gestiunea_stocurilor.BonConsum);
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
            // bonConsumBindingNavigatorSaveItem
            // 
            this.bonConsumBindingNavigatorSaveItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bonConsumBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bonConsumBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bonConsumBindingNavigatorSaveItem.Image")));
            this.bonConsumBindingNavigatorSaveItem.Name = "bonConsumBindingNavigatorSaveItem";
            this.bonConsumBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.bonConsumBindingNavigatorSaveItem.Text = "Salveaza";
            this.bonConsumBindingNavigatorSaveItem.Click += new System.EventHandler(this.bonConsumBindingNavigatorSaveItem_Click);
            // 
            // bonConsumDataGridView
            // 
            this.bonConsumDataGridView.AllowUserToAddRows = false;
            this.bonConsumDataGridView.AutoGenerateColumns = false;
            this.bonConsumDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bonConsumDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bonConsumDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.bonConsumDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bonConsumDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.bonConsumDataGridView.DataSource = this.bonConsumBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bonConsumDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.bonConsumDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bonConsumDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.bonConsumDataGridView.Location = new System.Drawing.Point(0, 33);
            this.bonConsumDataGridView.Name = "bonConsumDataGridView";
            this.bonConsumDataGridView.RowHeadersWidth = 62;
            this.bonConsumDataGridView.RowTemplate.Height = 28;
            this.bonConsumDataGridView.Size = new System.Drawing.Size(1096, 600);
            this.bonConsumDataGridView.TabIndex = 1;
            this.bonConsumDataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.bonConsumDataGridView_RowValidating);
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdProdus";
            this.dataGridViewTextBoxColumn3.HeaderText = "IdProdus";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn5.HeaderText = "Data";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // frmModifBonConsum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1096, 633);
            this.Controls.Add(this.bonConsumDataGridView);
            this.Controls.Add(this.bonConsumBindingNavigator);
            this.Name = "frmModifBonConsum";
            this.Text = "Editare bon consum";
            this.Load += new System.EventHandler(this.frmModifBonConsum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bonConsumBindingNavigator)).EndInit();
            this.bonConsumBindingNavigator.ResumeLayout(false);
            this.bonConsumBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bonConsumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonConsumDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depozitBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bonConsumBindingSource;
        private System.Windows.Forms.BindingNavigator bonConsumBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bonConsumBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView bonConsumDataGridView;
        private System.Windows.Forms.BindingSource depozitBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}
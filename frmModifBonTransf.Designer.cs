
namespace Gestiunea_stocurilor
{
    partial class frmModifBonTransf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModifBonTransf));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bonTransferBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bonTransferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bonTransferBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bonTransferDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.depozitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bonTransferBindingNavigator)).BeginInit();
            this.bonTransferBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bonTransferBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonTransferDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depozitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bonTransferBindingNavigator
            // 
            this.bonTransferBindingNavigator.AddNewItem = null;
            this.bonTransferBindingNavigator.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bonTransferBindingNavigator.BindingSource = this.bonTransferBindingSource;
            this.bonTransferBindingNavigator.CountItem = null;
            this.bonTransferBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bonTransferBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bonTransferBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bonTransferBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorDeleteItem,
            this.bonTransferBindingNavigatorSaveItem});
            this.bonTransferBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bonTransferBindingNavigator.MoveFirstItem = null;
            this.bonTransferBindingNavigator.MoveLastItem = null;
            this.bonTransferBindingNavigator.MoveNextItem = null;
            this.bonTransferBindingNavigator.MovePreviousItem = null;
            this.bonTransferBindingNavigator.Name = "bonTransferBindingNavigator";
            this.bonTransferBindingNavigator.PositionItem = null;
            this.bonTransferBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bonTransferBindingNavigator.Size = new System.Drawing.Size(1107, 33);
            this.bonTransferBindingNavigator.TabIndex = 0;
            this.bonTransferBindingNavigator.Text = "bindingNavigator1";
            // 
            // bonTransferBindingSource
            // 
            this.bonTransferBindingSource.DataSource = typeof(Gestiunea_stocurilor.BonTransfer);
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
            // bonTransferBindingNavigatorSaveItem
            // 
            this.bonTransferBindingNavigatorSaveItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bonTransferBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bonTransferBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bonTransferBindingNavigatorSaveItem.Image")));
            this.bonTransferBindingNavigatorSaveItem.Name = "bonTransferBindingNavigatorSaveItem";
            this.bonTransferBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.bonTransferBindingNavigatorSaveItem.Text = "Salveaza";
            this.bonTransferBindingNavigatorSaveItem.Click += new System.EventHandler(this.bonTransferBindingNavigatorSaveItem_Click);
            // 
            // bonTransferDataGridView
            // 
            this.bonTransferDataGridView.AllowUserToAddRows = false;
            this.bonTransferDataGridView.AutoGenerateColumns = false;
            this.bonTransferDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bonTransferDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bonTransferDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.bonTransferDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bonTransferDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4});
            this.bonTransferDataGridView.DataSource = this.bonTransferBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bonTransferDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.bonTransferDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bonTransferDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.bonTransferDataGridView.Location = new System.Drawing.Point(0, 33);
            this.bonTransferDataGridView.Name = "bonTransferDataGridView";
            this.bonTransferDataGridView.RowHeadersWidth = 62;
            this.bonTransferDataGridView.RowTemplate.Height = 28;
            this.bonTransferDataGridView.Size = new System.Drawing.Size(1107, 590);
            this.bonTransferDataGridView.TabIndex = 1;
            this.bonTransferDataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.bonTransferDataGridView_RowValidating);
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
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdDepozitPredator";
            this.dataGridViewTextBoxColumn2.DataSource = this.depozitBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Denumire";
            this.dataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn2.DisplayStyleForCurrentCellOnly = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Depozit predator";
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
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IdDepozitPrimitor";
            this.dataGridViewTextBoxColumn5.DataSource = this.depozitBindingSource;
            this.dataGridViewTextBoxColumn5.DisplayMember = "Denumire";
            this.dataGridViewTextBoxColumn5.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn5.DisplayStyleForCurrentCellOnly = true;
            this.dataGridViewTextBoxColumn5.HeaderText = "Depozit primitor";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.ValueMember = "Id";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn4.HeaderText = "Data";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // frmModifBonTransf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1107, 623);
            this.Controls.Add(this.bonTransferDataGridView);
            this.Controls.Add(this.bonTransferBindingNavigator);
            this.Name = "frmModifBonTransf";
            this.Text = "Editare bon transfer";
            this.Load += new System.EventHandler(this.frmModifBonTransf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bonTransferBindingNavigator)).EndInit();
            this.bonTransferBindingNavigator.ResumeLayout(false);
            this.bonTransferBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bonTransferBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonTransferDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depozitBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bonTransferBindingSource;
        private System.Windows.Forms.BindingNavigator bonTransferBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bonTransferBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView bonTransferDataGridView;
        private System.Windows.Forms.BindingSource depozitBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
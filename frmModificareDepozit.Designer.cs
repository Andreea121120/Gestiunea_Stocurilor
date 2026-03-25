
namespace Gestiunea_stocurilor
{
    partial class frmModificareDepozit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificareDepozit));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.depozitBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.depozitBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.depozitDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.gestionarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depozitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.depozitBindingNavigator)).BeginInit();
            this.depozitBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depozitDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depozitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // depozitBindingNavigator
            // 
            this.depozitBindingNavigator.AddNewItem = null;
            this.depozitBindingNavigator.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.depozitBindingNavigator.BindingSource = this.depozitBindingSource;
            this.depozitBindingNavigator.CountItem = null;
            this.depozitBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.depozitBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.depozitBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.depozitBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorDeleteItem,
            this.depozitBindingNavigatorSaveItem});
            this.depozitBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.depozitBindingNavigator.MoveFirstItem = null;
            this.depozitBindingNavigator.MoveLastItem = null;
            this.depozitBindingNavigator.MoveNextItem = null;
            this.depozitBindingNavigator.MovePreviousItem = null;
            this.depozitBindingNavigator.Name = "depozitBindingNavigator";
            this.depozitBindingNavigator.PositionItem = null;
            this.depozitBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.depozitBindingNavigator.Size = new System.Drawing.Size(1407, 38);
            this.depozitBindingNavigator.TabIndex = 0;
            this.depozitBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorDeleteItem.Text = "Sterge";
            // 
            // depozitBindingNavigatorSaveItem
            // 
            this.depozitBindingNavigatorSaveItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.depozitBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.depozitBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("depozitBindingNavigatorSaveItem.Image")));
            this.depozitBindingNavigatorSaveItem.Name = "depozitBindingNavigatorSaveItem";
            this.depozitBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 33);
            this.depozitBindingNavigatorSaveItem.Text = "Salvare";
            this.depozitBindingNavigatorSaveItem.Click += new System.EventHandler(this.depozitBindingNavigatorSaveItem_Click);
            // 
            // depozitDataGridView
            // 
            this.depozitDataGridView.AllowUserToAddRows = false;
            this.depozitDataGridView.AutoGenerateColumns = false;
            this.depozitDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.depozitDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.depozitDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.depozitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.depozitDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.depozitDataGridView.DataSource = this.depozitBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.depozitDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.depozitDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.depozitDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.depozitDataGridView.Location = new System.Drawing.Point(0, 38);
            this.depozitDataGridView.Name = "depozitDataGridView";
            this.depozitDataGridView.RowHeadersWidth = 62;
            this.depozitDataGridView.RowTemplate.Height = 28;
            this.depozitDataGridView.Size = new System.Drawing.Size(1407, 571);
            this.depozitDataGridView.TabIndex = 1;
            this.depozitDataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.depozitDataGridView_RowValidating);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 61;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Cod";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cod";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdGestionar";
            this.dataGridViewTextBoxColumn2.DataSource = this.gestionarBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Nume";
            this.dataGridViewTextBoxColumn2.DisplayStyleForCurrentCellOnly = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Gestionarul repsonsabil";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "Id";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // gestionarBindingSource
            // 
            this.gestionarBindingSource.DataSource = typeof(Gestiunea_stocurilor.Gestionar);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Denumire";
            this.dataGridViewTextBoxColumn4.HeaderText = "Denumire";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Adresa";
            this.dataGridViewTextBoxColumn5.HeaderText = "Adresa";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // depozitBindingSource
            // 
            this.depozitBindingSource.DataSource = typeof(Gestiunea_stocurilor.Depozit);
            // 
            // frmModificareDepozit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1407, 609);
            this.Controls.Add(this.depozitDataGridView);
            this.Controls.Add(this.depozitBindingNavigator);
            this.Name = "frmModificareDepozit";
            this.Text = "Editare depozit";
            this.Load += new System.EventHandler(this.frmModificareDepozit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.depozitBindingNavigator)).EndInit();
            this.depozitBindingNavigator.ResumeLayout(false);
            this.depozitBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depozitDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depozitBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource depozitBindingSource;
        private System.Windows.Forms.BindingNavigator depozitBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton depozitBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView depozitDataGridView;
        private System.Windows.Forms.BindingSource gestionarBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}
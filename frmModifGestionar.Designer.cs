
namespace Gestiunea_stocurilor
{
    partial class frmModifGestionar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModifGestionar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gestionarBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.gestionarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.gestionarBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.gestionarDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gestionarBindingNavigator)).BeginInit();
            this.gestionarBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestionarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gestionarBindingNavigator
            // 
            this.gestionarBindingNavigator.AddNewItem = null;
            this.gestionarBindingNavigator.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gestionarBindingNavigator.BindingSource = this.gestionarBindingSource;
            this.gestionarBindingNavigator.CountItem = null;
            this.gestionarBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.gestionarBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.gestionarBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.gestionarBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorDeleteItem,
            this.gestionarBindingNavigatorSaveItem});
            this.gestionarBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.gestionarBindingNavigator.MoveFirstItem = null;
            this.gestionarBindingNavigator.MoveLastItem = null;
            this.gestionarBindingNavigator.MoveNextItem = null;
            this.gestionarBindingNavigator.MovePreviousItem = null;
            this.gestionarBindingNavigator.Name = "gestionarBindingNavigator";
            this.gestionarBindingNavigator.PositionItem = null;
            this.gestionarBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.gestionarBindingNavigator.Size = new System.Drawing.Size(1059, 33);
            this.gestionarBindingNavigator.TabIndex = 0;
            this.gestionarBindingNavigator.Text = "bindingNavigator1";
            // 
            // gestionarBindingSource
            // 
            this.gestionarBindingSource.DataSource = typeof(Gestiunea_stocurilor.Gestionar);
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
            // gestionarBindingNavigatorSaveItem
            // 
            this.gestionarBindingNavigatorSaveItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.gestionarBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gestionarBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("gestionarBindingNavigatorSaveItem.Image")));
            this.gestionarBindingNavigatorSaveItem.Name = "gestionarBindingNavigatorSaveItem";
            this.gestionarBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.gestionarBindingNavigatorSaveItem.Text = "Salvare";
            this.gestionarBindingNavigatorSaveItem.Click += new System.EventHandler(this.gestionarBindingNavigatorSaveItem_Click);
            // 
            // gestionarDataGridView
            // 
            this.gestionarDataGridView.AllowUserToAddRows = false;
            this.gestionarDataGridView.AutoGenerateColumns = false;
            this.gestionarDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gestionarDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gestionarDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gestionarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gestionarDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.gestionarDataGridView.DataSource = this.gestionarBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gestionarDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.gestionarDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gestionarDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.gestionarDataGridView.Location = new System.Drawing.Point(0, 33);
            this.gestionarDataGridView.Name = "gestionarDataGridView";
            this.gestionarDataGridView.RowHeadersWidth = 62;
            this.gestionarDataGridView.RowTemplate.Height = 28;
            this.gestionarDataGridView.Size = new System.Drawing.Size(1059, 523);
            this.gestionarDataGridView.TabIndex = 1;
            this.gestionarDataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.gestionarDataGridView_RowValidating);
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
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CNP";
            this.dataGridViewTextBoxColumn2.HeaderText = "CNP";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nume";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nume";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Prenume";
            this.dataGridViewTextBoxColumn4.HeaderText = "Prenume";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // frmModifGestionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1059, 556);
            this.Controls.Add(this.gestionarDataGridView);
            this.Controls.Add(this.gestionarBindingNavigator);
            this.Name = "frmModifGestionar";
            this.Text = "Editare gestionar";
            this.Load += new System.EventHandler(this.frmModifGestionar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestionarBindingNavigator)).EndInit();
            this.gestionarBindingNavigator.ResumeLayout(false);
            this.gestionarBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestionarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionarDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource gestionarBindingSource;
        private System.Windows.Forms.BindingNavigator gestionarBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton gestionarBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView gestionarDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
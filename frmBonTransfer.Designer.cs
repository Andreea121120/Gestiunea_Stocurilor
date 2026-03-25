
namespace Gestiunea_stocurilor
{
    partial class frmBonTransfer
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
            System.Windows.Forms.Label idDepozitPredatorLabel;
            System.Windows.Forms.Label idDepozitPrimitorLabel;
            System.Windows.Forms.Label numarLabel;
            System.Windows.Forms.Label dataLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBonTransfer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bonTransferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bonTransferBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.bonTransferBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idDepozitPredatorComboBox = new System.Windows.Forms.ComboBox();
            this.depozitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDepozitPrimitorComboBox = new System.Windows.Forms.ComboBox();
            this.depozitBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.numarTextBox = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.produsTransferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produsTransferDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.produsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            idDepozitPredatorLabel = new System.Windows.Forms.Label();
            idDepozitPrimitorLabel = new System.Windows.Forms.Label();
            numarLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bonTransferBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonTransferBindingNavigator)).BeginInit();
            this.bonTransferBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depozitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depozitBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsTransferBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsTransferDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idDepozitPredatorLabel
            // 
            idDepozitPredatorLabel.AutoSize = true;
            idDepozitPredatorLabel.Font = new System.Drawing.Font("Verdana", 8F);
            idDepozitPredatorLabel.Location = new System.Drawing.Point(600, 89);
            idDepozitPredatorLabel.Name = "idDepozitPredatorLabel";
            idDepozitPredatorLabel.Size = new System.Drawing.Size(153, 18);
            idDepozitPredatorLabel.TabIndex = 1;
            idDepozitPredatorLabel.Text = "Depozit predator:";
            // 
            // idDepozitPrimitorLabel
            // 
            idDepozitPrimitorLabel.AutoSize = true;
            idDepozitPrimitorLabel.Font = new System.Drawing.Font("Verdana", 8F);
            idDepozitPrimitorLabel.Location = new System.Drawing.Point(600, 160);
            idDepozitPrimitorLabel.Name = "idDepozitPrimitorLabel";
            idDepozitPrimitorLabel.Size = new System.Drawing.Size(148, 18);
            idDepozitPrimitorLabel.TabIndex = 3;
            idDepozitPrimitorLabel.Text = "Depozit primitor:";
            // 
            // numarLabel
            // 
            numarLabel.AutoSize = true;
            numarLabel.Font = new System.Drawing.Font("Verdana", 8F);
            numarLabel.Location = new System.Drawing.Point(56, 89);
            numarLabel.Name = "numarLabel";
            numarLabel.Size = new System.Drawing.Size(68, 18);
            numarLabel.TabIndex = 5;
            numarLabel.Text = "Numar:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Font = new System.Drawing.Font("Verdana", 8F);
            dataLabel.Location = new System.Drawing.Point(56, 160);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(54, 18);
            dataLabel.TabIndex = 7;
            dataLabel.Text = "Data:";
            // 
            // bonTransferBindingSource
            // 
            this.bonTransferBindingSource.DataSource = typeof(Gestiunea_stocurilor.BonTransfer);
            // 
            // bonTransferBindingNavigator
            // 
            this.bonTransferBindingNavigator.AddNewItem = null;
            this.bonTransferBindingNavigator.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bonTransferBindingNavigator.BindingSource = this.bonTransferBindingSource;
            this.bonTransferBindingNavigator.CountItem = null;
            this.bonTransferBindingNavigator.DeleteItem = null;
            this.bonTransferBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bonTransferBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bonTransferBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.newToolStripButton,
            this.toolStripButton1,
            this.bonTransferBindingNavigatorSaveItem});
            this.bonTransferBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bonTransferBindingNavigator.MoveFirstItem = null;
            this.bonTransferBindingNavigator.MoveLastItem = null;
            this.bonTransferBindingNavigator.MoveNextItem = null;
            this.bonTransferBindingNavigator.MovePreviousItem = null;
            this.bonTransferBindingNavigator.Name = "bonTransferBindingNavigator";
            this.bonTransferBindingNavigator.PositionItem = null;
            this.bonTransferBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bonTransferBindingNavigator.Size = new System.Drawing.Size(1164, 33);
            this.bonTransferBindingNavigator.TabIndex = 0;
            this.bonTransferBindingNavigator.Text = "bindingNavigator1";
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
            // newToolStripButton
            // 
            this.newToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(34, 28);
            this.newToolStripButton.Text = "Lista bonuri transfer";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton1.Text = "Editeaza bon";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
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
            // idDepozitPredatorComboBox
            // 
            this.idDepozitPredatorComboBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.idDepozitPredatorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bonTransferBindingSource, "IdDepozitPredator", true));
            this.idDepozitPredatorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bonTransferBindingSource, "IdDepozitPredator", true));
            this.idDepozitPredatorComboBox.DataSource = this.depozitBindingSource;
            this.idDepozitPredatorComboBox.DisplayMember = "Denumire";
            this.idDepozitPredatorComboBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.idDepozitPredatorComboBox.FormattingEnabled = true;
            this.idDepozitPredatorComboBox.Location = new System.Drawing.Point(821, 86);
            this.idDepozitPredatorComboBox.Name = "idDepozitPredatorComboBox";
            this.idDepozitPredatorComboBox.Size = new System.Drawing.Size(272, 26);
            this.idDepozitPredatorComboBox.TabIndex = 2;
            this.idDepozitPredatorComboBox.ValueMember = "Id";
            this.idDepozitPredatorComboBox.SelectedIndexChanged += new System.EventHandler(this.idDepozitPredatorComboBox_SelectedIndexChanged);
            // 
            // depozitBindingSource
            // 
            this.depozitBindingSource.DataSource = typeof(Gestiunea_stocurilor.Depozit);
            // 
            // idDepozitPrimitorComboBox
            // 
            this.idDepozitPrimitorComboBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.idDepozitPrimitorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bonTransferBindingSource, "IdDepozitPrimitor", true));
            this.idDepozitPrimitorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bonTransferBindingSource, "IdDepozitPrimitor", true));
            this.idDepozitPrimitorComboBox.DataSource = this.depozitBindingSource1;
            this.idDepozitPrimitorComboBox.DisplayMember = "Denumire";
            this.idDepozitPrimitorComboBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.idDepozitPrimitorComboBox.FormattingEnabled = true;
            this.idDepozitPrimitorComboBox.Location = new System.Drawing.Point(821, 157);
            this.idDepozitPrimitorComboBox.Name = "idDepozitPrimitorComboBox";
            this.idDepozitPrimitorComboBox.Size = new System.Drawing.Size(272, 26);
            this.idDepozitPrimitorComboBox.TabIndex = 4;
            this.idDepozitPrimitorComboBox.ValueMember = "Id";
            // 
            // depozitBindingSource1
            // 
            this.depozitBindingSource1.DataSource = typeof(Gestiunea_stocurilor.Depozit);
            // 
            // numarTextBox
            // 
            this.numarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bonTransferBindingSource, "Numar", true));
            this.numarTextBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.numarTextBox.Location = new System.Drawing.Point(191, 86);
            this.numarTextBox.Name = "numarTextBox";
            this.numarTextBox.Size = new System.Drawing.Size(322, 27);
            this.numarTextBox.TabIndex = 6;
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bonTransferBindingSource, "Data", true));
            this.dataDateTimePicker.Font = new System.Drawing.Font("Verdana", 8F);
            this.dataDateTimePicker.Location = new System.Drawing.Point(191, 155);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(322, 27);
            this.dataDateTimePicker.TabIndex = 8;
            // 
            // produsTransferBindingSource
            // 
            this.produsTransferBindingSource.DataSource = typeof(Gestiunea_stocurilor.ProdusTransfer);
            // 
            // produsTransferDataGridView
            // 
            this.produsTransferDataGridView.AutoGenerateColumns = false;
            this.produsTransferDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.produsTransferDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.produsTransferDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.produsTransferDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produsTransferDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.produsTransferDataGridView.DataSource = this.produsTransferBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.produsTransferDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.produsTransferDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.produsTransferDataGridView.Location = new System.Drawing.Point(60, 289);
            this.produsTransferDataGridView.Name = "produsTransferDataGridView";
            this.produsTransferDataGridView.RowHeadersWidth = 62;
            this.produsTransferDataGridView.RowTemplate.Height = 28;
            this.produsTransferDataGridView.Size = new System.Drawing.Size(950, 340);
            this.produsTransferDataGridView.TabIndex = 9;
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
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdBonTransfer";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdBonTransfer";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdProdus";
            this.dataGridViewTextBoxColumn3.DataSource = this.produsBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Denumire";
            this.dataGridViewTextBoxColumn3.DisplayStyleForCurrentCellOnly = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Produs";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "Id";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // produsBindingSource
            // 
            this.produsBindingSource.DataSource = typeof(Gestiunea_stocurilor.Produs);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cantitate";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cantitate";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(60, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Produse transfer:";
            // 
            // frmBonTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1164, 723);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.produsTransferDataGridView);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(numarLabel);
            this.Controls.Add(this.numarTextBox);
            this.Controls.Add(idDepozitPrimitorLabel);
            this.Controls.Add(this.idDepozitPrimitorComboBox);
            this.Controls.Add(idDepozitPredatorLabel);
            this.Controls.Add(this.idDepozitPredatorComboBox);
            this.Controls.Add(this.bonTransferBindingNavigator);
            this.Name = "frmBonTransfer";
            this.Text = "Bon transfer";
            this.Load += new System.EventHandler(this.frmBonTransfer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bonTransferBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonTransferBindingNavigator)).EndInit();
            this.bonTransferBindingNavigator.ResumeLayout(false);
            this.bonTransferBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depozitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depozitBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsTransferBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsTransferDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bonTransferBindingSource;
        private System.Windows.Forms.BindingNavigator bonTransferBindingNavigator;
        private System.Windows.Forms.ToolStripButton bonTransferBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox idDepozitPredatorComboBox;
        private System.Windows.Forms.BindingSource depozitBindingSource;
        private System.Windows.Forms.ComboBox idDepozitPrimitorComboBox;
        private System.Windows.Forms.TextBox numarTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.BindingSource produsTransferBindingSource;
        private System.Windows.Forms.DataGridView produsTransferDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.BindingSource produsBindingSource;
        private System.Windows.Forms.BindingSource depozitBindingSource1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

namespace Gestiunea_stocurilor
{
    partial class frmBonConsum
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
            System.Windows.Forms.Label numarLabel;
            System.Windows.Forms.Label idDepozitLabel;
            System.Windows.Forms.Label dataLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBonConsum));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bonConsumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bonConsumBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.bonConsumBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.numarTextBox = new System.Windows.Forms.TextBox();
            this.idDepozitComboBox = new System.Windows.Forms.ComboBox();
            this.depozitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.produsConsumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produsConsumDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.produsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            numarLabel = new System.Windows.Forms.Label();
            idDepozitLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bonConsumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonConsumBindingNavigator)).BeginInit();
            this.bonConsumBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depozitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsConsumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsConsumDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // numarLabel
            // 
            numarLabel.AutoSize = true;
            numarLabel.Font = new System.Drawing.Font("Verdana", 8F);
            numarLabel.Location = new System.Drawing.Point(64, 84);
            numarLabel.Name = "numarLabel";
            numarLabel.Size = new System.Drawing.Size(68, 18);
            numarLabel.TabIndex = 1;
            numarLabel.Text = "Numar:";
            // 
            // idDepozitLabel
            // 
            idDepozitLabel.AutoSize = true;
            idDepozitLabel.Font = new System.Drawing.Font("Verdana", 8F);
            idDepozitLabel.Location = new System.Drawing.Point(602, 84);
            idDepozitLabel.Name = "idDepozitLabel";
            idDepozitLabel.Size = new System.Drawing.Size(78, 18);
            idDepozitLabel.TabIndex = 3;
            idDepozitLabel.Text = "Depozit:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Font = new System.Drawing.Font("Verdana", 8F);
            dataLabel.Location = new System.Drawing.Point(64, 160);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(54, 18);
            dataLabel.TabIndex = 5;
            dataLabel.Text = "Data:";
            // 
            // bonConsumBindingSource
            // 
            this.bonConsumBindingSource.DataSource = typeof(Gestiunea_stocurilor.BonConsum);
            // 
            // bonConsumBindingNavigator
            // 
            this.bonConsumBindingNavigator.AddNewItem = null;
            this.bonConsumBindingNavigator.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bonConsumBindingNavigator.BindingSource = this.bonConsumBindingSource;
            this.bonConsumBindingNavigator.CountItem = null;
            this.bonConsumBindingNavigator.DeleteItem = null;
            this.bonConsumBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bonConsumBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bonConsumBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripButton,
            this.toolStripButton2,
            this.newToolStripButton,
            this.toolStripButton1,
            this.bonConsumBindingNavigatorSaveItem});
            this.bonConsumBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bonConsumBindingNavigator.MoveFirstItem = null;
            this.bonConsumBindingNavigator.MoveLastItem = null;
            this.bonConsumBindingNavigator.MoveNextItem = null;
            this.bonConsumBindingNavigator.MovePreviousItem = null;
            this.bonConsumBindingNavigator.Name = "bonConsumBindingNavigator";
            this.bonConsumBindingNavigator.PositionItem = null;
            this.bonConsumBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bonConsumBindingNavigator.Size = new System.Drawing.Size(1128, 33);
            this.bonConsumBindingNavigator.TabIndex = 0;
            this.bonConsumBindingNavigator.Text = "bindingNavigator1";
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(34, 28);
            this.helpToolStripButton.Text = "He&lp";
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
            this.newToolStripButton.Text = "Lista bonuri consum";
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
            // bonConsumBindingNavigatorSaveItem
            // 
            this.bonConsumBindingNavigatorSaveItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bonConsumBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bonConsumBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bonConsumBindingNavigatorSaveItem.Image")));
            this.bonConsumBindingNavigatorSaveItem.Name = "bonConsumBindingNavigatorSaveItem";
            this.bonConsumBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.bonConsumBindingNavigatorSaveItem.Text = "Salvare";
            this.bonConsumBindingNavigatorSaveItem.Click += new System.EventHandler(this.bonConsumBindingNavigatorSaveItem_Click);
            // 
            // numarTextBox
            // 
            this.numarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bonConsumBindingSource, "Numar", true));
            this.numarTextBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.numarTextBox.Location = new System.Drawing.Point(193, 81);
            this.numarTextBox.Name = "numarTextBox";
            this.numarTextBox.Size = new System.Drawing.Size(313, 27);
            this.numarTextBox.TabIndex = 2;
            // 
            // idDepozitComboBox
            // 
            this.idDepozitComboBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.idDepozitComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bonConsumBindingSource, "IdDepozit", true));
            this.idDepozitComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bonConsumBindingSource, "IdDepozit", true));
            this.idDepozitComboBox.DataSource = this.depozitBindingSource;
            this.idDepozitComboBox.DisplayMember = "Denumire";
            this.idDepozitComboBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.idDepozitComboBox.FormattingEnabled = true;
            this.idDepozitComboBox.Location = new System.Drawing.Point(751, 81);
            this.idDepozitComboBox.Name = "idDepozitComboBox";
            this.idDepozitComboBox.Size = new System.Drawing.Size(247, 26);
            this.idDepozitComboBox.TabIndex = 4;
            this.idDepozitComboBox.ValueMember = "Id";
            this.idDepozitComboBox.SelectedIndexChanged += new System.EventHandler(this.idDepozitComboBox_SelectedIndexChanged);
            // 
            // depozitBindingSource
            // 
            this.depozitBindingSource.DataSource = typeof(Gestiunea_stocurilor.Depozit);
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bonConsumBindingSource, "Data", true));
            this.dataDateTimePicker.Font = new System.Drawing.Font("Verdana", 8F);
            this.dataDateTimePicker.Location = new System.Drawing.Point(193, 154);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(313, 27);
            this.dataDateTimePicker.TabIndex = 6;
            // 
            // produsConsumBindingSource
            // 
            this.produsConsumBindingSource.DataSource = typeof(Gestiunea_stocurilor.ProdusConsum);
            // 
            // produsConsumDataGridView
            // 
            this.produsConsumDataGridView.AutoGenerateColumns = false;
            this.produsConsumDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.produsConsumDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.produsConsumDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.produsConsumDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produsConsumDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.produsConsumDataGridView.DataSource = this.produsConsumBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.produsConsumDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.produsConsumDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.produsConsumDataGridView.Location = new System.Drawing.Point(68, 295);
            this.produsConsumDataGridView.Name = "produsConsumDataGridView";
            this.produsConsumDataGridView.RowHeadersWidth = 62;
            this.produsConsumDataGridView.RowTemplate.Height = 28;
            this.produsConsumDataGridView.Size = new System.Drawing.Size(738, 357);
            this.produsConsumDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdBonConsum";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn2.HeaderText = "IdBonConsum";
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
            this.label1.Location = new System.Drawing.Point(68, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Produse consum:";
            // 
            // frmBonConsum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1128, 789);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.produsConsumDataGridView);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(idDepozitLabel);
            this.Controls.Add(this.idDepozitComboBox);
            this.Controls.Add(numarLabel);
            this.Controls.Add(this.numarTextBox);
            this.Controls.Add(this.bonConsumBindingNavigator);
            this.Name = "frmBonConsum";
            this.Text = "Bon consum";
            this.Load += new System.EventHandler(this.frmBonConsum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bonConsumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonConsumBindingNavigator)).EndInit();
            this.bonConsumBindingNavigator.ResumeLayout(false);
            this.bonConsumBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depozitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsConsumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsConsumDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bonConsumBindingSource;
        private System.Windows.Forms.BindingNavigator bonConsumBindingNavigator;
        private System.Windows.Forms.ToolStripButton bonConsumBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.TextBox numarTextBox;
        private System.Windows.Forms.ComboBox idDepozitComboBox;
        private System.Windows.Forms.BindingSource depozitBindingSource;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.BindingSource produsConsumBindingSource;
        private System.Windows.Forms.DataGridView produsConsumDataGridView;
        private System.Windows.Forms.BindingSource produsBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
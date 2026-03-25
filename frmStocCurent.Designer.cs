
namespace Gestiunea_stocurilor
{
    partial class frmStocCurent
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label idLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStocCurent));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stocCurentTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.produsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idComboBox = new System.Windows.Forms.ComboBox();
            this.depozitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idComboBox1 = new System.Windows.Forms.ComboBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            idLabel = new System.Windows.Forms.Label();
            idLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depozitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Verdana", 8F);
            idLabel.Location = new System.Drawing.Point(84, 76);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(70, 18);
            idLabel.TabIndex = 9;
            idLabel.Text = "Produs:";
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Font = new System.Drawing.Font("Verdana", 8F);
            idLabel1.Location = new System.Drawing.Point(84, 134);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(78, 18);
            idLabel1.TabIndex = 10;
            idLabel1.Text = "Depozit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8F);
            this.label3.Location = new System.Drawing.Point(84, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8F);
            this.label4.Location = new System.Drawing.Point(84, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Stoc curent:";
            // 
            // stocCurentTextBox
            // 
            this.stocCurentTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.stocCurentTextBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.stocCurentTextBox.Location = new System.Drawing.Point(219, 275);
            this.stocCurentTextBox.Name = "stocCurentTextBox";
            this.stocCurentTextBox.ReadOnly = true;
            this.stocCurentTextBox.Size = new System.Drawing.Size(349, 27);
            this.stocCurentTextBox.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Verdana", 8F);
            this.dateTimePicker1.Location = new System.Drawing.Point(219, 188);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(349, 27);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // produsBindingSource
            // 
            this.produsBindingSource.DataSource = typeof(Gestiunea_stocurilor.Produs);
            // 
            // idComboBox
            // 
            this.idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produsBindingSource, "Id", true));
            this.idComboBox.DataSource = this.produsBindingSource;
            this.idComboBox.DisplayMember = "Denumire";
            this.idComboBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.idComboBox.FormattingEnabled = true;
            this.idComboBox.Location = new System.Drawing.Point(219, 73);
            this.idComboBox.Name = "idComboBox";
            this.idComboBox.Size = new System.Drawing.Size(349, 26);
            this.idComboBox.TabIndex = 10;
            this.idComboBox.ValueMember = "Id";
            // 
            // depozitBindingSource
            // 
            this.depozitBindingSource.DataSource = typeof(Gestiunea_stocurilor.Depozit);
            // 
            // idComboBox1
            // 
            this.idComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.depozitBindingSource, "Id", true));
            this.idComboBox1.DataSource = this.depozitBindingSource;
            this.idComboBox1.DisplayMember = "Denumire";
            this.idComboBox1.Font = new System.Drawing.Font("Verdana", 8F);
            this.idComboBox1.FormattingEnabled = true;
            this.idComboBox1.Location = new System.Drawing.Point(219, 131);
            this.idComboBox1.Name = "idComboBox1";
            this.idComboBox1.Size = new System.Drawing.Size(349, 26);
            this.idComboBox1.TabIndex = 11;
            this.idComboBox1.ValueMember = "Id";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bindingNavigator1.Size = new System.Drawing.Size(681, 33);
            this.bindingNavigator1.TabIndex = 12;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton2.Text = "Actualizare stoc initial si pret";
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
            this.toolStripButton1.Text = "Verificare stoc";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // frmStocCurent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(681, 374);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(idLabel1);
            this.Controls.Add(this.idComboBox1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idComboBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.stocCurentTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "frmStocCurent";
            this.Text = "Stoc curent produs";
            this.Load += new System.EventHandler(this.frmStocCurent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depozitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox stocCurentTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource produsBindingSource;
        private System.Windows.Forms.ComboBox idComboBox;
        private System.Windows.Forms.BindingSource depozitBindingSource;
        private System.Windows.Forms.ComboBox idComboBox1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}
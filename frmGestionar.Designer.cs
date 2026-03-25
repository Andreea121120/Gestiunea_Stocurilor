
namespace Gestiunea_stocurilor
{
    partial class frmGestionar
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
            System.Windows.Forms.Label cNPLabel;
            System.Windows.Forms.Label numeLabel;
            System.Windows.Forms.Label prenumeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionar));
            this.gestionarBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.gestionarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.gestionarBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cNPTextBox = new System.Windows.Forms.TextBox();
            this.numeTextBox = new System.Windows.Forms.TextBox();
            this.prenumeTextBox = new System.Windows.Forms.TextBox();
            cNPLabel = new System.Windows.Forms.Label();
            numeLabel = new System.Windows.Forms.Label();
            prenumeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gestionarBindingNavigator)).BeginInit();
            this.gestionarBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestionarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cNPLabel
            // 
            cNPLabel.AutoSize = true;
            cNPLabel.Font = new System.Drawing.Font("Verdana", 8F);
            cNPLabel.Location = new System.Drawing.Point(78, 109);
            cNPLabel.Name = "cNPLabel";
            cNPLabel.Size = new System.Drawing.Size(48, 18);
            cNPLabel.TabIndex = 1;
            cNPLabel.Text = "CNP:";
            // 
            // numeLabel
            // 
            numeLabel.AutoSize = true;
            numeLabel.Font = new System.Drawing.Font("Verdana", 8F);
            numeLabel.Location = new System.Drawing.Point(78, 179);
            numeLabel.Name = "numeLabel";
            numeLabel.Size = new System.Drawing.Size(62, 18);
            numeLabel.TabIndex = 3;
            numeLabel.Text = "Nume:";
            // 
            // prenumeLabel
            // 
            prenumeLabel.AutoSize = true;
            prenumeLabel.Font = new System.Drawing.Font("Verdana", 8F);
            prenumeLabel.Location = new System.Drawing.Point(78, 244);
            prenumeLabel.Name = "prenumeLabel";
            prenumeLabel.Size = new System.Drawing.Size(86, 18);
            prenumeLabel.TabIndex = 5;
            prenumeLabel.Text = "Prenume:";
            // 
            // gestionarBindingNavigator
            // 
            this.gestionarBindingNavigator.AddNewItem = null;
            this.gestionarBindingNavigator.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gestionarBindingNavigator.BindingSource = this.gestionarBindingSource;
            this.gestionarBindingNavigator.CountItem = null;
            this.gestionarBindingNavigator.DeleteItem = null;
            this.gestionarBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.gestionarBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.gestionarBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.toolStripButton1,
            this.gestionarBindingNavigatorSaveItem});
            this.gestionarBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.gestionarBindingNavigator.MoveFirstItem = null;
            this.gestionarBindingNavigator.MoveLastItem = null;
            this.gestionarBindingNavigator.MoveNextItem = null;
            this.gestionarBindingNavigator.MovePreviousItem = null;
            this.gestionarBindingNavigator.Name = "gestionarBindingNavigator";
            this.gestionarBindingNavigator.PositionItem = null;
            this.gestionarBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.gestionarBindingNavigator.Size = new System.Drawing.Size(648, 38);
            this.gestionarBindingNavigator.TabIndex = 0;
            this.gestionarBindingNavigator.Text = "Lista gestionari";
            // 
            // gestionarBindingSource
            // 
            this.gestionarBindingSource.DataSource = typeof(Gestiunea_stocurilor.Gestionar);
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(34, 33);
            this.newToolStripButton.Text = "Lista gestionari";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 33);
            this.toolStripButton1.Text = "Editeaza gestionar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // gestionarBindingNavigatorSaveItem
            // 
            this.gestionarBindingNavigatorSaveItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.gestionarBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gestionarBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("gestionarBindingNavigatorSaveItem.Image")));
            this.gestionarBindingNavigatorSaveItem.Name = "gestionarBindingNavigatorSaveItem";
            this.gestionarBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 33);
            this.gestionarBindingNavigatorSaveItem.Text = "Salvare";
            this.gestionarBindingNavigatorSaveItem.Click += new System.EventHandler(this.gestionarBindingNavigatorSaveItem_Click);
            // 
            // cNPTextBox
            // 
            this.cNPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gestionarBindingSource, "CNP", true));
            this.cNPTextBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.cNPTextBox.Location = new System.Drawing.Point(243, 106);
            this.cNPTextBox.Name = "cNPTextBox";
            this.cNPTextBox.Size = new System.Drawing.Size(294, 27);
            this.cNPTextBox.TabIndex = 2;
            // 
            // numeTextBox
            // 
            this.numeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gestionarBindingSource, "Nume", true));
            this.numeTextBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.numeTextBox.Location = new System.Drawing.Point(243, 176);
            this.numeTextBox.Name = "numeTextBox";
            this.numeTextBox.Size = new System.Drawing.Size(294, 27);
            this.numeTextBox.TabIndex = 4;
            // 
            // prenumeTextBox
            // 
            this.prenumeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gestionarBindingSource, "Prenume", true));
            this.prenumeTextBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.prenumeTextBox.Location = new System.Drawing.Point(243, 241);
            this.prenumeTextBox.Name = "prenumeTextBox";
            this.prenumeTextBox.Size = new System.Drawing.Size(294, 27);
            this.prenumeTextBox.TabIndex = 6;
            // 
            // frmGestionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(648, 356);
            this.Controls.Add(prenumeLabel);
            this.Controls.Add(this.prenumeTextBox);
            this.Controls.Add(numeLabel);
            this.Controls.Add(this.numeTextBox);
            this.Controls.Add(cNPLabel);
            this.Controls.Add(this.cNPTextBox);
            this.Controls.Add(this.gestionarBindingNavigator);
            this.Name = "frmGestionar";
            this.Text = "Gestionar";
            this.Load += new System.EventHandler(this.frmGestionar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestionarBindingNavigator)).EndInit();
            this.gestionarBindingNavigator.ResumeLayout(false);
            this.gestionarBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestionarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource gestionarBindingSource;
        private System.Windows.Forms.BindingNavigator gestionarBindingNavigator;
        private System.Windows.Forms.ToolStripButton gestionarBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cNPTextBox;
        private System.Windows.Forms.TextBox numeTextBox;
        private System.Windows.Forms.TextBox prenumeTextBox;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}
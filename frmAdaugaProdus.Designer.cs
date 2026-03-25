
namespace Gestiunea_stocurilor
{
    partial class frmAdaugaProdus
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
            System.Windows.Forms.Label codLabel;
            System.Windows.Forms.Label denumireLabel;
            System.Windows.Forms.Label unitateDeMasuraLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdaugaProdus));
            this.produsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.produsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codTextBox = new System.Windows.Forms.TextBox();
            this.denumireTextBox = new System.Windows.Forms.TextBox();
            this.lblPretEstimMat = new System.Windows.Forms.Label();
            this.lblPretEstimMP = new System.Windows.Forms.Label();
            this.lblPretStMf = new System.Windows.Forms.Label();
            this.lblCostStPF = new System.Windows.Forms.Label();
            this.ckMaterial = new System.Windows.Forms.CheckBox();
            this.ckMP = new System.Windows.Forms.CheckBox();
            this.ckMarfa = new System.Windows.Forms.CheckBox();
            this.ckPF = new System.Windows.Forms.CheckBox();
            this.pretEstimatMatTextBox = new System.Windows.Forms.TextBox();
            this.pretEstimatMPTextBox = new System.Windows.Forms.TextBox();
            this.pretStandardMfTextBox = new System.Windows.Forms.TextBox();
            this.costStandardTextBox = new System.Windows.Forms.TextBox();
            this.unitateDeMasuraComboBox = new System.Windows.Forms.ComboBox();
            this.produsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materiePrimaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marfaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produsFinitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            codLabel = new System.Windows.Forms.Label();
            denumireLabel = new System.Windows.Forms.Label();
            unitateDeMasuraLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingNavigator)).BeginInit();
            this.produsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiePrimaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marfaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsFinitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codLabel
            // 
            codLabel.AutoSize = true;
            codLabel.Font = new System.Drawing.Font("Verdana", 8F);
            codLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            codLabel.Location = new System.Drawing.Point(89, 81);
            codLabel.Name = "codLabel";
            codLabel.Size = new System.Drawing.Size(46, 18);
            codLabel.TabIndex = 1;
            codLabel.Text = "Cod:";
            // 
            // denumireLabel
            // 
            denumireLabel.AutoSize = true;
            denumireLabel.Font = new System.Drawing.Font("Verdana", 8F);
            denumireLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            denumireLabel.Location = new System.Drawing.Point(89, 147);
            denumireLabel.Name = "denumireLabel";
            denumireLabel.Size = new System.Drawing.Size(93, 18);
            denumireLabel.TabIndex = 3;
            denumireLabel.Text = "Denumire:";
            // 
            // unitateDeMasuraLabel
            // 
            unitateDeMasuraLabel.AutoSize = true;
            unitateDeMasuraLabel.Font = new System.Drawing.Font("Verdana", 8F);
            unitateDeMasuraLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            unitateDeMasuraLabel.Location = new System.Drawing.Point(89, 211);
            unitateDeMasuraLabel.Name = "unitateDeMasuraLabel";
            unitateDeMasuraLabel.Size = new System.Drawing.Size(168, 18);
            unitateDeMasuraLabel.TabIndex = 5;
            unitateDeMasuraLabel.Text = "Unitate de masura:";
            // 
            // produsBindingNavigator
            // 
            this.produsBindingNavigator.AddNewItem = null;
            this.produsBindingNavigator.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.produsBindingNavigator.BindingSource = this.produsBindingSource;
            this.produsBindingNavigator.CountItem = null;
            this.produsBindingNavigator.DeleteItem = null;
            this.produsBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.produsBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.produsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripButton,
            this.toolStripButton1,
            this.produsBindingNavigatorSaveItem});
            this.produsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.produsBindingNavigator.MoveFirstItem = null;
            this.produsBindingNavigator.MoveLastItem = null;
            this.produsBindingNavigator.MoveNextItem = null;
            this.produsBindingNavigator.MovePreviousItem = null;
            this.produsBindingNavigator.Name = "produsBindingNavigator";
            this.produsBindingNavigator.PositionItem = null;
            this.produsBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.produsBindingNavigator.Size = new System.Drawing.Size(819, 33);
            this.produsBindingNavigator.TabIndex = 0;
            this.produsBindingNavigator.Text = "bindingNavigator1";
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(34, 28);
            this.helpToolStripButton.Text = "Ajutor";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton1.Text = "Editeaza/ Vizualizeaza produs";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // produsBindingNavigatorSaveItem
            // 
            this.produsBindingNavigatorSaveItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.produsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.produsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("produsBindingNavigatorSaveItem.Image")));
            this.produsBindingNavigatorSaveItem.Name = "produsBindingNavigatorSaveItem";
            this.produsBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.produsBindingNavigatorSaveItem.Text = "Salvare";
            this.produsBindingNavigatorSaveItem.Click += new System.EventHandler(this.produsBindingNavigatorSaveItem_Click);
            // 
            // codTextBox
            // 
            this.codTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produsBindingSource, "Cod", true));
            this.codTextBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.codTextBox.Location = new System.Drawing.Point(314, 78);
            this.codTextBox.Name = "codTextBox";
            this.codTextBox.Size = new System.Drawing.Size(386, 27);
            this.codTextBox.TabIndex = 2;
            // 
            // denumireTextBox
            // 
            this.denumireTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produsBindingSource, "Denumire", true));
            this.denumireTextBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.denumireTextBox.Location = new System.Drawing.Point(314, 141);
            this.denumireTextBox.Name = "denumireTextBox";
            this.denumireTextBox.Size = new System.Drawing.Size(386, 27);
            this.denumireTextBox.TabIndex = 4;
            // 
            // lblPretEstimMat
            // 
            this.lblPretEstimMat.AutoSize = true;
            this.lblPretEstimMat.Font = new System.Drawing.Font("Verdana", 8F);
            this.lblPretEstimMat.Location = new System.Drawing.Point(273, 288);
            this.lblPretEstimMat.Name = "lblPretEstimMat";
            this.lblPretEstimMat.Size = new System.Drawing.Size(117, 18);
            this.lblPretEstimMat.TabIndex = 23;
            this.lblPretEstimMat.Text = "Pret estimat:";
            // 
            // lblPretEstimMP
            // 
            this.lblPretEstimMP.AutoSize = true;
            this.lblPretEstimMP.Font = new System.Drawing.Font("Verdana", 8F);
            this.lblPretEstimMP.Location = new System.Drawing.Point(273, 340);
            this.lblPretEstimMP.Name = "lblPretEstimMP";
            this.lblPretEstimMP.Size = new System.Drawing.Size(117, 18);
            this.lblPretEstimMP.TabIndex = 24;
            this.lblPretEstimMP.Text = "Pret estimat:";
            // 
            // lblPretStMf
            // 
            this.lblPretStMf.AutoSize = true;
            this.lblPretStMf.Font = new System.Drawing.Font("Verdana", 8F);
            this.lblPretStMf.Location = new System.Drawing.Point(273, 391);
            this.lblPretStMf.Name = "lblPretStMf";
            this.lblPretStMf.Size = new System.Drawing.Size(126, 18);
            this.lblPretStMf.TabIndex = 25;
            this.lblPretStMf.Text = "Pret standard:";
            // 
            // lblCostStPF
            // 
            this.lblCostStPF.AutoSize = true;
            this.lblCostStPF.Font = new System.Drawing.Font("Verdana", 8F);
            this.lblCostStPF.Location = new System.Drawing.Point(273, 441);
            this.lblCostStPF.Name = "lblCostStPF";
            this.lblCostStPF.Size = new System.Drawing.Size(130, 18);
            this.lblCostStPF.TabIndex = 26;
            this.lblCostStPF.Text = "Cost standard:";
            // 
            // ckMaterial
            // 
            this.ckMaterial.AutoSize = true;
            this.ckMaterial.Font = new System.Drawing.Font("Verdana", 8F);
            this.ckMaterial.Location = new System.Drawing.Point(93, 288);
            this.ckMaterial.Name = "ckMaterial";
            this.ckMaterial.Size = new System.Drawing.Size(100, 22);
            this.ckMaterial.TabIndex = 31;
            this.ckMaterial.Text = "Material";
            this.ckMaterial.UseVisualStyleBackColor = true;
            this.ckMaterial.CheckedChanged += new System.EventHandler(this.ckMaterial_CheckedChanged_1);
            // 
            // ckMP
            // 
            this.ckMP.AutoSize = true;
            this.ckMP.Font = new System.Drawing.Font("Verdana", 8F);
            this.ckMP.Location = new System.Drawing.Point(93, 340);
            this.ckMP.Name = "ckMP";
            this.ckMP.Size = new System.Drawing.Size(147, 22);
            this.ckMP.TabIndex = 32;
            this.ckMP.Text = "Materie prima";
            this.ckMP.UseVisualStyleBackColor = true;
            this.ckMP.CheckedChanged += new System.EventHandler(this.ckMP_CheckedChanged);
            // 
            // ckMarfa
            // 
            this.ckMarfa.AutoSize = true;
            this.ckMarfa.Font = new System.Drawing.Font("Verdana", 8F);
            this.ckMarfa.Location = new System.Drawing.Point(93, 391);
            this.ckMarfa.Name = "ckMarfa";
            this.ckMarfa.Size = new System.Drawing.Size(79, 22);
            this.ckMarfa.TabIndex = 33;
            this.ckMarfa.Text = "Marfa";
            this.ckMarfa.UseVisualStyleBackColor = true;
            this.ckMarfa.CheckedChanged += new System.EventHandler(this.ckMarfa_CheckedChanged);
            // 
            // ckPF
            // 
            this.ckPF.AutoSize = true;
            this.ckPF.Font = new System.Drawing.Font("Verdana", 8F);
            this.ckPF.Location = new System.Drawing.Point(93, 441);
            this.ckPF.Name = "ckPF";
            this.ckPF.Size = new System.Drawing.Size(128, 22);
            this.ckPF.TabIndex = 34;
            this.ckPF.Text = "Produs finit";
            this.ckPF.UseVisualStyleBackColor = true;
            this.ckPF.CheckedChanged += new System.EventHandler(this.ckPF_CheckedChanged);
            // 
            // pretEstimatMatTextBox
            // 
            this.pretEstimatMatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "PretEstimatMat", true));
            this.pretEstimatMatTextBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.pretEstimatMatTextBox.Location = new System.Drawing.Point(445, 281);
            this.pretEstimatMatTextBox.Name = "pretEstimatMatTextBox";
            this.pretEstimatMatTextBox.Size = new System.Drawing.Size(255, 27);
            this.pretEstimatMatTextBox.TabIndex = 35;
            // 
            // pretEstimatMPTextBox
            // 
            this.pretEstimatMPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materiePrimaBindingSource, "PretEstimatMP", true));
            this.pretEstimatMPTextBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.pretEstimatMPTextBox.Location = new System.Drawing.Point(445, 334);
            this.pretEstimatMPTextBox.Name = "pretEstimatMPTextBox";
            this.pretEstimatMPTextBox.Size = new System.Drawing.Size(255, 27);
            this.pretEstimatMPTextBox.TabIndex = 36;
            // 
            // pretStandardMfTextBox
            // 
            this.pretStandardMfTextBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.pretStandardMfTextBox.Location = new System.Drawing.Point(445, 385);
            this.pretStandardMfTextBox.Name = "pretStandardMfTextBox";
            this.pretStandardMfTextBox.Size = new System.Drawing.Size(255, 27);
            this.pretStandardMfTextBox.TabIndex = 37;
            // 
            // costStandardTextBox
            // 
            this.costStandardTextBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.costStandardTextBox.Location = new System.Drawing.Point(445, 434);
            this.costStandardTextBox.Name = "costStandardTextBox";
            this.costStandardTextBox.Size = new System.Drawing.Size(255, 27);
            this.costStandardTextBox.TabIndex = 38;
            // 
            // unitateDeMasuraComboBox
            // 
            this.unitateDeMasuraComboBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.unitateDeMasuraComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produsBindingSource, "UnitateDeMasura", true));
            this.unitateDeMasuraComboBox.FormattingEnabled = true;
            this.unitateDeMasuraComboBox.Items.AddRange(new object[] {
            "buc",
            "g",
            "kg",
            "L",
            "m"});
            this.unitateDeMasuraComboBox.Location = new System.Drawing.Point(314, 207);
            this.unitateDeMasuraComboBox.Name = "unitateDeMasuraComboBox";
            this.unitateDeMasuraComboBox.Size = new System.Drawing.Size(386, 28);
            this.unitateDeMasuraComboBox.TabIndex = 39;
            // 
            // produsBindingSource
            // 
            this.produsBindingSource.DataSource = typeof(Gestiunea_stocurilor.Produs);
            // 
            // materiePrimaBindingSource
            // 
            this.materiePrimaBindingSource.DataSource = typeof(Gestiunea_stocurilor.MateriePrima);
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataSource = typeof(Gestiunea_stocurilor.Material);
            // 
            // marfaBindingSource
            // 
            this.marfaBindingSource.DataSource = typeof(Gestiunea_stocurilor.Marfa);
            // 
            // produsFinitBindingSource
            // 
            this.produsFinitBindingSource.DataSource = typeof(Gestiunea_stocurilor.ProdusFinit);
            // 
            // frmAdaugaProdus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(819, 523);
            this.Controls.Add(this.unitateDeMasuraComboBox);
            this.Controls.Add(this.costStandardTextBox);
            this.Controls.Add(this.pretStandardMfTextBox);
            this.Controls.Add(this.pretEstimatMPTextBox);
            this.Controls.Add(this.pretEstimatMatTextBox);
            this.Controls.Add(this.ckPF);
            this.Controls.Add(this.ckMarfa);
            this.Controls.Add(this.ckMP);
            this.Controls.Add(this.ckMaterial);
            this.Controls.Add(this.lblCostStPF);
            this.Controls.Add(this.lblPretStMf);
            this.Controls.Add(this.lblPretEstimMP);
            this.Controls.Add(this.lblPretEstimMat);
            this.Controls.Add(unitateDeMasuraLabel);
            this.Controls.Add(denumireLabel);
            this.Controls.Add(this.denumireTextBox);
            this.Controls.Add(codLabel);
            this.Controls.Add(this.codTextBox);
            this.Controls.Add(this.produsBindingNavigator);
            this.Name = "frmAdaugaProdus";
            this.Text = "Adaugare produs";
            this.Load += new System.EventHandler(this.frmAdaugaProdus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingNavigator)).EndInit();
            this.produsBindingNavigator.ResumeLayout(false);
            this.produsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiePrimaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marfaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsFinitBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource produsBindingSource;
        private System.Windows.Forms.BindingNavigator produsBindingNavigator;
        private System.Windows.Forms.ToolStripButton produsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox codTextBox;
        private System.Windows.Forms.TextBox denumireTextBox;
        private System.Windows.Forms.Label lblPretEstimMat;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.Label lblPretEstimMP;
        private System.Windows.Forms.Label lblPretStMf;
        private System.Windows.Forms.Label lblCostStPF;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private System.Windows.Forms.BindingSource materiePrimaBindingSource;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.CheckBox ckMaterial;
        private System.Windows.Forms.CheckBox ckMP;
        private System.Windows.Forms.CheckBox ckMarfa;
        private System.Windows.Forms.CheckBox ckPF;
        private System.Windows.Forms.TextBox pretEstimatMatTextBox;
        private System.Windows.Forms.TextBox pretEstimatMPTextBox;
        private System.Windows.Forms.TextBox pretStandardMfTextBox;
        private System.Windows.Forms.TextBox costStandardTextBox;
        private System.Windows.Forms.BindingSource marfaBindingSource;
        private System.Windows.Forms.BindingSource produsFinitBindingSource;
        private System.Windows.Forms.ComboBox unitateDeMasuraComboBox;
    }
}
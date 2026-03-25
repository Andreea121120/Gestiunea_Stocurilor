
namespace Gestiunea_stocurilor
{
    partial class frmAdaugaProdusCategorie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdaugaProdusCategorie));
            this.produsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.produsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ckPF = new System.Windows.Forms.CheckBox();
            this.ckMarfa = new System.Windows.Forms.CheckBox();
            this.ckMP = new System.Windows.Forms.CheckBox();
            this.ckMaterial = new System.Windows.Forms.CheckBox();
            this.lblCostStPF = new System.Windows.Forms.Label();
            this.lblPretStMf = new System.Windows.Forms.Label();
            this.lblPretEstimMP = new System.Windows.Forms.Label();
            this.lblPretEstimMat = new System.Windows.Forms.Label();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pretEstimatMatTextBox = new System.Windows.Forms.TextBox();
            this.materiePrimaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pretEstimatMPTextBox = new System.Windows.Forms.TextBox();
            this.marfaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pretStandardMfTextBox = new System.Windows.Forms.TextBox();
            this.produsFinitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.costStandardTextBox = new System.Windows.Forms.TextBox();
            this.idComboBox = new System.Windows.Forms.ComboBox();
            codLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingNavigator)).BeginInit();
            this.produsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiePrimaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marfaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsFinitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codLabel
            // 
            codLabel.AutoSize = true;
            codLabel.Font = new System.Drawing.Font("Verdana", 8F);
            codLabel.Location = new System.Drawing.Point(52, 67);
            codLabel.Name = "codLabel";
            codLabel.Size = new System.Drawing.Size(46, 18);
            codLabel.TabIndex = 1;
            codLabel.Text = "Cod:";
            // 
            // produsBindingSource
            // 
            this.produsBindingSource.DataSource = typeof(Gestiunea_stocurilor.Produs);
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
            this.produsBindingNavigatorSaveItem});
            this.produsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.produsBindingNavigator.MoveFirstItem = null;
            this.produsBindingNavigator.MoveLastItem = null;
            this.produsBindingNavigator.MoveNextItem = null;
            this.produsBindingNavigator.MovePreviousItem = null;
            this.produsBindingNavigator.Name = "produsBindingNavigator";
            this.produsBindingNavigator.PositionItem = null;
            this.produsBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.produsBindingNavigator.Size = new System.Drawing.Size(621, 33);
            this.produsBindingNavigator.TabIndex = 0;
            this.produsBindingNavigator.Text = "bindingNavigator1";
            // 
            // produsBindingNavigatorSaveItem
            // 
            this.produsBindingNavigatorSaveItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.produsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.produsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("produsBindingNavigatorSaveItem.Image")));
            this.produsBindingNavigatorSaveItem.Name = "produsBindingNavigatorSaveItem";
            this.produsBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.produsBindingNavigatorSaveItem.Text = "Salveaza";
            this.produsBindingNavigatorSaveItem.Click += new System.EventHandler(this.produsBindingNavigatorSaveItem_Click);
            // 
            // ckPF
            // 
            this.ckPF.AutoSize = true;
            this.ckPF.Font = new System.Drawing.Font("Verdana", 8F);
            this.ckPF.Location = new System.Drawing.Point(56, 224);
            this.ckPF.Name = "ckPF";
            this.ckPF.Size = new System.Drawing.Size(128, 22);
            this.ckPF.TabIndex = 46;
            this.ckPF.Text = "Produs finit";
            this.ckPF.UseVisualStyleBackColor = true;
            this.ckPF.CheckedChanged += new System.EventHandler(this.ckPF_CheckedChanged);
            // 
            // ckMarfa
            // 
            this.ckMarfa.AutoSize = true;
            this.ckMarfa.Font = new System.Drawing.Font("Verdana", 8F);
            this.ckMarfa.Location = new System.Drawing.Point(56, 188);
            this.ckMarfa.Name = "ckMarfa";
            this.ckMarfa.Size = new System.Drawing.Size(79, 22);
            this.ckMarfa.TabIndex = 45;
            this.ckMarfa.Text = "Marfa";
            this.ckMarfa.UseVisualStyleBackColor = true;
            this.ckMarfa.CheckedChanged += new System.EventHandler(this.ckMarfa_CheckedChanged);
            // 
            // ckMP
            // 
            this.ckMP.AutoSize = true;
            this.ckMP.Font = new System.Drawing.Font("Verdana", 8F);
            this.ckMP.Location = new System.Drawing.Point(56, 154);
            this.ckMP.Name = "ckMP";
            this.ckMP.Size = new System.Drawing.Size(147, 22);
            this.ckMP.TabIndex = 44;
            this.ckMP.Text = "Materie prima";
            this.ckMP.UseVisualStyleBackColor = true;
            this.ckMP.CheckedChanged += new System.EventHandler(this.ckMP_CheckedChanged);
            // 
            // ckMaterial
            // 
            this.ckMaterial.AutoSize = true;
            this.ckMaterial.Font = new System.Drawing.Font("Verdana", 8F);
            this.ckMaterial.Location = new System.Drawing.Point(56, 120);
            this.ckMaterial.Name = "ckMaterial";
            this.ckMaterial.Size = new System.Drawing.Size(100, 22);
            this.ckMaterial.TabIndex = 43;
            this.ckMaterial.Text = "Material";
            this.ckMaterial.UseVisualStyleBackColor = true;
            this.ckMaterial.CheckedChanged += new System.EventHandler(this.ckMaterial_CheckedChanged);
            // 
            // lblCostStPF
            // 
            this.lblCostStPF.AutoSize = true;
            this.lblCostStPF.Font = new System.Drawing.Font("Verdana", 8F);
            this.lblCostStPF.Location = new System.Drawing.Point(236, 224);
            this.lblCostStPF.Name = "lblCostStPF";
            this.lblCostStPF.Size = new System.Drawing.Size(130, 18);
            this.lblCostStPF.TabIndex = 42;
            this.lblCostStPF.Text = "Cost standard:";
            // 
            // lblPretStMf
            // 
            this.lblPretStMf.AutoSize = true;
            this.lblPretStMf.Font = new System.Drawing.Font("Verdana", 8F);
            this.lblPretStMf.Location = new System.Drawing.Point(236, 188);
            this.lblPretStMf.Name = "lblPretStMf";
            this.lblPretStMf.Size = new System.Drawing.Size(126, 18);
            this.lblPretStMf.TabIndex = 41;
            this.lblPretStMf.Text = "Pret standard:";
            // 
            // lblPretEstimMP
            // 
            this.lblPretEstimMP.AutoSize = true;
            this.lblPretEstimMP.Font = new System.Drawing.Font("Verdana", 8F);
            this.lblPretEstimMP.Location = new System.Drawing.Point(236, 154);
            this.lblPretEstimMP.Name = "lblPretEstimMP";
            this.lblPretEstimMP.Size = new System.Drawing.Size(117, 18);
            this.lblPretEstimMP.TabIndex = 40;
            this.lblPretEstimMP.Text = "Pret estimat:";
            // 
            // lblPretEstimMat
            // 
            this.lblPretEstimMat.AutoSize = true;
            this.lblPretEstimMat.Font = new System.Drawing.Font("Verdana", 8F);
            this.lblPretEstimMat.Location = new System.Drawing.Point(236, 120);
            this.lblPretEstimMat.Name = "lblPretEstimMat";
            this.lblPretEstimMat.Size = new System.Drawing.Size(117, 18);
            this.lblPretEstimMat.TabIndex = 39;
            this.lblPretEstimMat.Text = "Pret estimat:";
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataSource = typeof(Gestiunea_stocurilor.Material);
            // 
            // pretEstimatMatTextBox
            // 
            this.pretEstimatMatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "PretEstimatMat", true));
            this.pretEstimatMatTextBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.pretEstimatMatTextBox.Location = new System.Drawing.Point(400, 117);
            this.pretEstimatMatTextBox.Name = "pretEstimatMatTextBox";
            this.pretEstimatMatTextBox.Size = new System.Drawing.Size(163, 27);
            this.pretEstimatMatTextBox.TabIndex = 47;
            // 
            // materiePrimaBindingSource
            // 
            this.materiePrimaBindingSource.DataSource = typeof(Gestiunea_stocurilor.MateriePrima);
            // 
            // pretEstimatMPTextBox
            // 
            this.pretEstimatMPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materiePrimaBindingSource, "PretEstimatMP", true));
            this.pretEstimatMPTextBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.pretEstimatMPTextBox.Location = new System.Drawing.Point(400, 151);
            this.pretEstimatMPTextBox.Name = "pretEstimatMPTextBox";
            this.pretEstimatMPTextBox.Size = new System.Drawing.Size(163, 27);
            this.pretEstimatMPTextBox.TabIndex = 48;
            // 
            // marfaBindingSource
            // 
            this.marfaBindingSource.DataSource = typeof(Gestiunea_stocurilor.Marfa);
            // 
            // pretStandardMfTextBox
            // 
            this.pretStandardMfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.marfaBindingSource, "PretStandardMf", true));
            this.pretStandardMfTextBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.pretStandardMfTextBox.Location = new System.Drawing.Point(400, 186);
            this.pretStandardMfTextBox.Name = "pretStandardMfTextBox";
            this.pretStandardMfTextBox.Size = new System.Drawing.Size(163, 27);
            this.pretStandardMfTextBox.TabIndex = 49;
            // 
            // produsFinitBindingSource
            // 
            this.produsFinitBindingSource.DataSource = typeof(Gestiunea_stocurilor.ProdusFinit);
            // 
            // costStandardTextBox
            // 
            this.costStandardTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produsFinitBindingSource, "CostStandard", true));
            this.costStandardTextBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.costStandardTextBox.Location = new System.Drawing.Point(400, 222);
            this.costStandardTextBox.Name = "costStandardTextBox";
            this.costStandardTextBox.Size = new System.Drawing.Size(163, 27);
            this.costStandardTextBox.TabIndex = 50;
            // 
            // idComboBox
            // 
            this.idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produsBindingSource, "Id", true));
            this.idComboBox.DataSource = this.produsBindingSource;
            this.idComboBox.DisplayMember = "Cod";
            this.idComboBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.idComboBox.FormattingEnabled = true;
            this.idComboBox.Location = new System.Drawing.Point(153, 63);
            this.idComboBox.Name = "idComboBox";
            this.idComboBox.Size = new System.Drawing.Size(410, 26);
            this.idComboBox.TabIndex = 51;
            this.idComboBox.ValueMember = "Id";
            // 
            // frmAdaugaProdusCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(621, 265);
            this.Controls.Add(this.idComboBox);
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
            this.Controls.Add(codLabel);
            this.Controls.Add(this.produsBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "frmAdaugaProdusCategorie";
            this.Text = "Adauga produs într-o categorie";
            this.Load += new System.EventHandler(this.frmAdaugaProdusCategorie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingNavigator)).EndInit();
            this.produsBindingNavigator.ResumeLayout(false);
            this.produsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiePrimaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marfaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsFinitBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource produsBindingSource;
        private System.Windows.Forms.BindingNavigator produsBindingNavigator;
        private System.Windows.Forms.ToolStripButton produsBindingNavigatorSaveItem;
        private System.Windows.Forms.CheckBox ckPF;
        private System.Windows.Forms.CheckBox ckMarfa;
        private System.Windows.Forms.CheckBox ckMP;
        private System.Windows.Forms.CheckBox ckMaterial;
        private System.Windows.Forms.Label lblCostStPF;
        private System.Windows.Forms.Label lblPretStMf;
        private System.Windows.Forms.Label lblPretEstimMP;
        private System.Windows.Forms.Label lblPretEstimMat;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private System.Windows.Forms.TextBox pretEstimatMatTextBox;
        private System.Windows.Forms.BindingSource materiePrimaBindingSource;
        private System.Windows.Forms.TextBox pretEstimatMPTextBox;
        private System.Windows.Forms.BindingSource marfaBindingSource;
        private System.Windows.Forms.TextBox pretStandardMfTextBox;
        private System.Windows.Forms.BindingSource produsFinitBindingSource;
        private System.Windows.Forms.TextBox costStandardTextBox;
        private System.Windows.Forms.ComboBox idComboBox;
    }
}
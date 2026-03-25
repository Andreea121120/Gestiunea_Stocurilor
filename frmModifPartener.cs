using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Gestiunea_stocurilor
{
    public partial class frmModifPartener : Form
    {
        BD1Entities1 ctx = new BD1Entities1();

        public frmModifPartener()
        {
            InitializeComponent();

        }

        private void frmModifPartener_Load(object sender, EventArgs e)
        {
            ctx.Partener.Load();

            partenerBindingSource.DataSource = ctx.Partener.Local.ToBindingList();

            rbTp.Checked = true;

        }

        private void FiltreazaParteneri()
        {
            if (rbCl.Checked)
            {
                partenerBindingSource.DataSource = ctx.Partener.Local
                    .Where(p => p.TipPartener == "Client")
                    .ToList();
            }
            else if (rbFz.Checked)
            {
                partenerBindingSource.DataSource = ctx.Partener.Local
                    .Where(p => p.TipPartener == "Furnizor")
                    .ToList();
            }
            else if (rbTp.Checked)
            {
                partenerBindingSource.DataSource = ctx.Partener.Local.ToList();
            }
        }

        private void partenerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                partenerBindingSource.EndEdit();

                bool existaErori = false;

                foreach (DataGridViewRow row in partenerDataGridView.Rows)
                {
                    if (row.IsNewRow) continue;

                    string cui = row.Cells["dataGridViewTextBoxColumn2"].Value?.ToString()?.Trim();
                    string tip = row.Cells["dataGridViewTextBoxColumn3"].Value?.ToString()?.Trim();
                    string denumire = row.Cells["dataGridViewTextBoxColumn4"].Value?.ToString()?.Trim();

                    bool eroare = false;

                    if (string.IsNullOrWhiteSpace(cui) || string.IsNullOrWhiteSpace(tip) || string.IsNullOrWhiteSpace(denumire))
                    {
                        eroare = true;
                    }
                    else
                    {
                        var partenerCurent = row.DataBoundItem as Partener;

                        bool cuiDuplicat = ctx.Partener.Local.Any(p =>
                            p.Id != partenerCurent.Id &&
                            p.CUI.Trim() == cui &&
                            p.TipPartener.Trim() == tip);

                        if (cuiDuplicat)
                        {
                            eroare = true;
                        }
                    }

                    if (eroare)
                    {
                        row.DefaultCellStyle.BackColor = Color.MistyRose;
                        existaErori = true;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                    }
                }

                if (existaErori)
                {
                    MessageBox.Show("Există erori în tabel! Coloanele CUI, Denumire sau Tip partener sunt necompletate, sau CUI deja există pentru acel tip de partener.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validare: CUI identic cu denumiri diferite
                var grupuriCUI = ctx.Partener.Local
                    .GroupBy(p => p.CUI.Trim())
                    .Where(g => g.Select(p => p.TipPartener.Trim()).Distinct().Count() > 1)
                    .ToList();

                foreach (var grup in grupuriCUI)
                {
                    var denumiri = grup.Select(p => p.Denumire?.Trim()).Distinct(StringComparer.OrdinalIgnoreCase).ToList();

                    if (denumiri.Count > 1)
                    {
                        MessageBox.Show(
                            $"Există parteneri cu același CUI ({grup.Key}) dar denumiri diferite: \"{string.Join("\", \"", denumiri)}\".\nPentru partenerii cu același CUI, denumirea trebuie să fie identică.",
                            "Avertizare",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        return;
                    }
                }

                ctx.SaveChanges();
                partenerBindingSource.ResetBindings(false);

                MessageBox.Show("Datele au fost salvate!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show($"Datele nu au fost salvate!\n{ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbCl_CheckedChanged(object sender, EventArgs e)
        {
            FiltreazaParteneri();
        }

        private void rbFz_CheckedChanged(object sender, EventArgs e)
        {
            FiltreazaParteneri();
        }

        private void rbTp_CheckedChanged(object sender, EventArgs e)
        {
            FiltreazaParteneri();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (partenerBindingSource.Current is Partener partener)
            {
                var confirm = MessageBox.Show("Sigur dorești să ștergi acest partener?", "Confirmare ștergere",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        this.Validate();
                        partenerBindingSource.EndEdit();

                        ctx.Partener.Remove(partener);
                        ctx.SaveChanges();
                        partenerBindingSource.RemoveCurrent();
                        MessageBox.Show("Partenerul a fost șters.", "Șters", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Eroare la ștergere: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}

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
    public partial class frmModifProdRep : Form
    {
        BD1Entities1 ctx = new BD1Entities1();
        public frmModifProdRep()
        {
            InitializeComponent();
        }

        private void frmModifProdRep_Load(object sender, EventArgs e)
        {
            ctx.ProdusGestionat.Load();
            ctx.Produs.Load();
            ctx.Depozit.Load();

            produsGestionatBindingSource.DataSource = ctx.ProdusGestionat.Local.ToBindingList();
            produsBindingSource.DataSource = ctx.Produs.Local.ToBindingList();
            depozitBindingSource.DataSource = ctx.Depozit.Local.ToBindingList();
        }

        private void produsGestionatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                produsBindingSource.EndEdit();
                produsGestionatBindingSource.EndEdit();
                depozitBindingSource.EndEdit();

                var listaPG = ctx.ProdusGestionat.Local.ToList();

                bool produsDuplicat = listaPG
                    .GroupBy(pg => new { pg.IdProdus, pg.IdDepozit })
                    .Any(g => g.Count() > 1);

                if (produsDuplicat)
                {
                    MessageBox.Show("Există deja un produs identic în același depozit! Modificarea nu a fost salvată.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                foreach (var pg in listaPG)
                {

                    if (pg.IdProdus == 0 || pg.IdDepozit == 0 || pg.StocInitial == null || pg.Pret == null)
                    {
                        var denumireProdus = ctx.Produs.Find(pg.IdProdus)?.Denumire ?? "(necompletat)";
                        var denumireDepozit = ctx.Depozit.Find(pg.IdDepozit)?.Denumire ?? "(necompletat)";

                        MessageBox.Show($"Toate câmpurile sunt obligatorii!\nVerifică produsul \"{denumireProdus}\" din depozitul \"{denumireDepozit}\".",
                            "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (pg.StocInitial <= 0 || pg.Pret <= 0)
                    {
                        var denumireProdus = ctx.Produs.Find(pg.IdProdus)?.Denumire ?? $"Produs ID {pg.IdProdus}";
                        var denumireDepozit = ctx.Depozit.Find(pg.IdDepozit)?.Denumire ?? $"Depozit ID {pg.IdDepozit}";

                        MessageBox.Show($"Produsul \"{denumireProdus}\" din \"{denumireDepozit}\" are stocul inițial sau prețul mai mic sau egal cu zero!",
                            "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                ctx.SaveChanges();
                produsGestionatBindingSource.ResetBindings(false);

                MessageBox.Show("Datele au fost salvate!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show($"Datele nu au fost salvate!\n{ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

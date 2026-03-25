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
    public partial class frmAvizExped : Form
    {
        BD1Entities1 ctx = new BD1Entities1();
        public frmAvizExped()
        {
            InitializeComponent();
        }

        private void frmAvizExped_Load(object sender, EventArgs e)
        {
            ctx.AvizExpeditie.Load();
            ctx.ProdusExpeditie.Load();
            ctx.Depozit.Load();
            ctx.Factura.Load();
            ctx.Produs.Load();

            depozitBindingSource.DataSource = ctx.Depozit.Local.ToBindingList();
            facturaBindingSource.DataSource = ctx.Factura
              .Local
              .Where(f => f.IdPartenerClient != null)
              .ToList();

            idFacturaComboBox.SelectedIndex = -1;
            idDepozitComboBox.SelectedIndex = -1;

        }

        public int StocCurent(int idProdus, int idDepozit, DateTime data)
        {
            string sql = "SELECT StocCurent FROM dbo.StocCurentTB(@p0, @p1, @p2)";
            return ctx.Database.SqlQuery<int>(sql, idProdus, idDepozit, data).FirstOrDefault();
        }

        private void avizExpeditieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (idDepozitComboBox.SelectedIndex < 0)
                {
                    MessageBox.Show("Selectează un depozit!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(numarTextBox.Text))
                {
                    MessageBox.Show("Introdu un număr Aviz expediție!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string nrAE = numarTextBox.Text.Trim();
                if (ctx.AvizExpeditie.Any(a => a.Numar == nrAE))
                {
                    MessageBox.Show($"Există deja un Aviz de expediție cu numărul \"{nrAE}\"!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                this.Validate();

                avizExpeditieBindingSource.EndEdit();
                produsExpeditieBindingSource.EndEdit();
                depozitBindingSource.EndEdit();
                facturaBindingSource.EndEdit();
                produsBindingSource.EndEdit();

                if (idFacturaComboBox.SelectedValue == null)
                {
                    bool existaRand = false;

                    // Se verifica daca sunt introduse date in toate campurile de pe un rand
                    //Nu se salveaza Aviz expeditie daca nu este introdus nimic in produsExpeditieDataGridView
                    foreach (DataGridViewRow rand in produsExpeditieDataGridView.Rows)
                    {
                        if (rand.IsNewRow) continue;

                        var produs = rand.Cells["dataGridViewTextBoxColumn3"].Value;
                        var cantitate = rand.Cells["Cantitate"].Value;

                        // Verifică dacă produsul și cantitatea sunt completate
                        if (produs == null || produs == DBNull.Value || cantitate == null || cantitate == DBNull.Value)
                        {
                            MessageBox.Show("Cantitatea nu este introdusă!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            if (!decimal.TryParse(cantitate.ToString(), out decimal valCantitate) || valCantitate <= 0)
                            {
                                MessageBox.Show("Cantitatea trebuie să fie mai mare decât zero!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            existaRand = true;
                        }
                    }

                    if (!existaRand)
                    {
                        MessageBox.Show("Completează cel puțin un rând valid în tabelul de produse!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                AvizExpeditie ae = new AvizExpeditie
                {
                    IdDepozit = (int)idDepozitComboBox.SelectedValue,
                    IdFactura = idFacturaComboBox.SelectedValue != null ? (int?)idFacturaComboBox.SelectedValue : null,
                    Numar = numarTextBox.Text,
                    Data = dataDateTimePicker.Value
                };

                 if (idFacturaComboBox.SelectedValue != null)
                 {
                    int idFactura = (int)idFacturaComboBox.SelectedValue;
                    bool facturaDejaFolosita = ctx.AvizExpeditie.Any(a => a.IdFactura == idFactura);

                    if (facturaDejaFolosita)
                    {
                        MessageBox.Show("Deja a fost emis un Aviz de expediție pe acestă factură\n Selectează altă factură", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                 }

                foreach (DataGridViewRow rand in produsExpeditieDataGridView.Rows)
                {
                    if (rand.IsNewRow) continue;

                    var produs = rand.Cells["dataGridViewTextBoxColumn3"].Value;
                    var cantitate = rand.Cells["Cantitate"].Value;

                    if (produs == null || cantitate == null) continue;

                    int idProdus = (int)produs;
                    decimal Cantitate = Convert.ToDecimal(cantitate);


                    int idDepozit = (int)idDepozitComboBox.SelectedValue;
                    DateTime dataNIR = dataDateTimePicker.Value;

                    int stocCurent = StocCurent(idProdus, idDepozit, dataNIR);

                    if (Cantitate > stocCurent)
                    {
                        string denumireProdus = ctx.Produs.Find(idProdus)?.Denumire ?? $"Produs ID {idProdus}";
                        MessageBox.Show(
                            $"Cantitatea introdusă pentru produsul \"{denumireProdus}\" ({cantitate}) depășește stocul curent ({stocCurent}).",
                            "Stoc insuficient",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        return; 
                    }
                }

                ctx.AvizExpeditie.Add(ae);
                ctx.SaveChanges();

                foreach (DataGridViewRow rand in produsExpeditieDataGridView.Rows)
                {
                    if (rand.IsNewRow) continue;

                    var produs = rand.Cells["dataGridViewTextBoxColumn3"].Value;
                    var cantitate = rand.Cells["Cantitate"].Value;
                    

                    if (produs != null && cantitate != null)
                    {
                        ProdusExpeditie pe = new ProdusExpeditie
                        {
                            IdAvizExpeditie = ae.Id, 
                            IdProdus = (int)produs,
                            Cantitate = Convert.ToDecimal(cantitate)
                        };

                        ctx.ProdusExpeditie.Add(pe);
                    }
                }

                ctx.SaveChanges();

                avizExpeditieBindingSource.ResetBindings(false);

                produsExpeditieBindingSource.DataSource = new BindingList<ProdusExpeditie>();
                produsExpeditieBindingSource.ResetBindings(false);

                MessageBox.Show("Datele au fost salvate!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show($"Datele nu au fost salvate!\n{ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            frmListaAvizExped lae = new frmListaAvizExped();
            lae.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmModifAvixExped mae = new frmModifAvixExped();
            mae.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmListaFacturi lf = new frmListaFacturi();
            lf.Show();
        }

        private void idFacturaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Dupa ce se selecteaza un depozit si se selecteaza o factura, se va verifica daca in depozitul selectat se afla produsele din factura
            if (idFacturaComboBox.SelectedIndex >= 0 && idFacturaComboBox.SelectedValue is int idFactura)
            {

                if (idDepozitComboBox.SelectedValue is int idDepozit)
                {
                    var produseInDepozit = (from pg in ctx.ProdusGestionat
                                            where pg.IdDepozit == idDepozit
                                            select pg.Produs.Id).ToList();

                    var continutFactura = ctx.ContinutFactura
                        .Where(cf => cf.IdFactura == idFactura)
                        .Select(cf => new
                        {
                            cf.IdProdus,
                            cf.Cantitate,
                        })
                        .ToList();

                    produsExpeditieBindingSource.Clear();
                    produsExpeditieDataGridView.AllowUserToAddRows = false;
                    produsExpeditieDataGridView.ReadOnly = true;

                    List<int> produseLipsa = new List<int>();

                    foreach (var cf in continutFactura)
                    {
                        if (!produseInDepozit.Contains(cf.IdProdus.Value))
                        {
                            produseLipsa.Add(cf.IdProdus.Value);
                        }
                        else
                        {
                            ProdusExpeditie produsExpeditie = new ProdusExpeditie
                            {
                                IdProdus = cf.IdProdus,
                                Cantitate = cf.Cantitate,
                            };

                            produsExpeditieBindingSource.Add(produsExpeditie);
                        }
                    }

                    produsExpeditieBindingSource.ResetBindings(false);

                    if (produseLipsa.Count > 0)
                    {
                        string mesaj = "Slectează un alt depozit sau adaugă produsul în depozitul selectat! \nUrmătoarele produse din factură nu se găsesc în depozitul selectat:\n";
                        mesaj += string.Join(", ", produseLipsa.Select(id =>
                        {
                            var produs = ctx.Produs.Find(id);
                            return produs != null ? produs.Denumire : $"ID: {id}";
                        }));

                        MessageBox.Show(mesaj, "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Selectează un depozit înainte de a selecta o factură!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    idFacturaComboBox.SelectedIndex = -1;
                }
            }
            else
            {
                produsExpeditieBindingSource.Clear();
                produsExpeditieBindingSource.ResetBindings(false);

                produsExpeditieDataGridView.AllowUserToAddRows = true;
                produsExpeditieDataGridView.ReadOnly = false;
            }
        }

        private void idDepozitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (idDepozitComboBox.SelectedIndex >= 0 && idDepozitComboBox.SelectedValue is int idDepozit)
            {
                var produseDepozit = (from pg in ctx.ProdusGestionat
                                      where pg.IdDepozit == idDepozit
                                      select pg.Produs).ToList();

                produsBindingSource.DataSource = produseDepozit;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmStocCurent sc = new frmStocCurent();
            sc.Show();
        }
    }
    
}

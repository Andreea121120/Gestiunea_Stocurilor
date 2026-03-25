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
    public partial class frmNIR : Form
    {
        BD1Entities1 ctx = new BD1Entities1();
        public frmNIR()
        {
            InitializeComponent();
        }

        private void frmNIR_Load(object sender, EventArgs e)
        {
            ctx.NIR.Load();
            ctx.ContinutNIR.Load();
            ctx.Depozit.Load();
            ctx.Factura.Load();
            ctx.Produs.Load();

            depozitBindingSource.DataSource = ctx.Depozit.Local.ToBindingList();
            facturaBindingSource.DataSource = ctx.Factura
                .Local
                .Where(f => f.IdPartenerFurnizor != null)
                .ToList();

            idFacturaComboBox.SelectedIndex = -1;
            idDepozitComboBox.SelectedIndex = -1;
        }

        private void nIRBindingNavigatorSaveItem_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Introdu un număr NIR!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string nrNIR = numarTextBox.Text.Trim();
                if (ctx.NIR.Any(n => n.Numar == nrNIR))
                {
                    MessageBox.Show($"Există deja un NIR cu numărul \"{nrNIR}\"!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                this.Validate();

                nIRBindingSource.EndEdit();
                continutNIRBindingSource1.EndEdit();
                depozitBindingSource.EndEdit();
                facturaBindingSource.EndEdit();
                produsBindingSource.EndEdit();

                if (idFacturaComboBox.SelectedValue == null)
                {
                    bool existaRand = false;

                    // Se verifica daca sunt introduse date in toate campurile de pe un rand
                    //Nu se salveaza NIR daca nu este introdus nimic in produsExpeditieDataGridView
                    foreach (DataGridViewRow rand in continutNIRDataGridView.Rows)
                    {
                        if (rand.IsNewRow) continue;

                        var produs = rand.Cells["dataGridViewTextBoxColumn3"].Value;
                        var cantitate = rand.Cells["Cantitate"].Value;

                        if (produs == null || produs == DBNull.Value || cantitate == null || cantitate == DBNull.Value)
                        {
                            MessageBox.Show("Produsul sau cantitatea nu este introdusă!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            if (!decimal.TryParse(cantitate.ToString(), out decimal cantitateValida) || cantitateValida <= 0)
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

                NIR nir = new NIR
                {
                    IdDepozit = (int)idDepozitComboBox.SelectedValue,
                    IdFactura = idFacturaComboBox.SelectedValue != null ? (int?)idFacturaComboBox.SelectedValue : null,
                    Numar = numarTextBox.Text,
                    Data = dataDateTimePicker.Value
                };

                //Se verifica daca s-a emis deja un NIR pe factura selectata
                if (idFacturaComboBox.SelectedValue != null)
                {
                    int idFactura = (int)idFacturaComboBox.SelectedValue;
                    bool facturaDejaFolosita = ctx.NIR.Any(n => n.IdFactura == idFactura);

                    if (facturaDejaFolosita)
                    {
                        MessageBox.Show("Deja a fost emis un NIR pe acestă factură\n Selectează altă factură", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                ctx.NIR.Add(nir);
                ctx.SaveChanges();

                foreach (DataGridViewRow rand in continutNIRDataGridView.Rows)
                {
                    if (rand.IsNewRow) continue;

                    var produs = rand.Cells["dataGridViewTextBoxColumn3"].Value;
                    var cantitate = rand.Cells["Cantitate"].Value;

                    if (produs != null && cantitate != null)
                    {
                        ContinutNIR continut = new ContinutNIR
                        {
                            IdNIR = nir.Id,
                            IdProdus = (int)produs,
                            Cantitate = Convert.ToDecimal(cantitate)
                        };

                        ctx.ContinutNIR.Add(continut);
                    }
                }

                ctx.SaveChanges();
                nIRBindingSource.ResetBindings(false);

                continutNIRBindingSource1.DataSource = new BindingList<ContinutNIR>();
                continutNIRBindingSource1.ResetBindings(false);

                MessageBox.Show("Datele au fost salvate!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show($"Datele nu au fost salvate!\n{ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmAdaugaProdus ap = new frmAdaugaProdus();
            ap.Show();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            frmListaNIR ln = new frmListaNIR();
            ln.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmModifNIR mn = new frmModifNIR();
            mn.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmListaFacturi lf = new frmListaFacturi();
            lf.Show();
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
                            cf.Cantitate
                        })
                        .ToList();

                    continutNIRBindingSource1.Clear();
                    continutNIRDataGridView.AllowUserToAddRows = false;
                    continutNIRDataGridView.ReadOnly = true;


                    List<int> produseLipsa = new List<int>();

                    foreach (var cf in continutFactura)
                    {
                        if (!produseInDepozit.Contains(cf.IdProdus.Value))
                        {
                            produseLipsa.Add(cf.IdProdus.Value);
                        }
                        else
                        {
                            ContinutNIR continutNIR = new ContinutNIR
                            {
                                IdProdus = cf.IdProdus,
                                Cantitate = cf.Cantitate
                               
                            };

                            continutNIRBindingSource1.Add(continutNIR);
                        }
                    }

                    continutNIRBindingSource1.ResetBindings(false);

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
                continutNIRBindingSource1.Clear();
                continutNIRBindingSource1.ResetBindings(false);
                continutNIRDataGridView.AllowUserToAddRows = true;
                continutNIRDataGridView.ReadOnly = false;
            }
        }

    }
}

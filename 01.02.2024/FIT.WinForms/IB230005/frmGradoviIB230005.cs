using FIT.Data.IB230005;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.IB230005
{
    public partial class frmGradoviIB230005 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        private DrzaveIB230005 drzaveIB230005;
        List<GradoviIB230005> ListaGradova = new List<GradoviIB230005>();


        public frmGradoviIB230005(DrzaveIB230005 drzaveIB230005 = null)
        {
            InitializeComponent();
            this.Text = "123";
            this.drzaveIB230005 = drzaveIB230005;
            dgvGradovi.AutoGenerateColumns = false;
        }

        private void frmGradoviIB230005_Load(object sender, EventArgs e)
        {
            if (drzaveIB230005 != null)
            {
                pbZastava.Image = drzaveIB230005.Zastava.ToImage();
                lblDrzava.Text = drzaveIB230005.Naziv;
                dgvGradovi.DataSource = null;
                dgvGradovi.DataSource = db.GradoviIB230005.Where(x => x.DrzavaId == drzaveIB230005.Id).ToList();
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (ValidanUnos())
            {
                var novi = new GradoviIB230005
                {
                    Naziv = txtNaziv.Text,
                    Status = true,
                    DrzavaId = drzaveIB230005.Id,
                };
                db.GradoviIB230005.Add(novi);
                db.SaveChanges();
                UcitajGradove();
            }
            else
            {
                MessageBox.Show("Grad postoji");
            }
        }

        private bool ValidanUnos()
        {
            return !string.IsNullOrEmpty(txtNaziv.Text) && !Kompariraj();
        }

        private bool Kompariraj()
        {
            var gradovi = db.GradoviIB230005.Where(x => x.DrzavaId == drzaveIB230005.Id).ToList();
            foreach (var grad in gradovi)
            {

                if (string.Compare(grad.Naziv.ToString().ToLower(), txtNaziv.Text.ToLower()) == 0)
                    return true;
            }
            return false;

        }

        private void UcitajGradove()
        {
            dgvGradovi.DataSource = null;
            dgvGradovi.DataSource = db.GradoviIB230005.Where(x => x.DrzavaId == drzaveIB230005.Id).ToList();
        }

        private void dgvGradovi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                var grad = dgvGradovi.Rows[e.RowIndex].DataBoundItem as GradoviIB230005;
                if (grad != null)
                {
                    grad.Status = !grad.Status;
                    db.GradoviIB230005.Update(grad);
                    db.SaveChanges();
                    UcitajGradove();
                }
            }
        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            int brojac = 0;
            if (ValidirajGenerisanje())
            {
                brojac = int.Parse(txtBrojGradova.Text);
                var status=cbAktivni.Checked;
                await btnDodajG(brojac, status);
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }

        private async Task btnDodajG(int brojac, bool status)
        {
            for (int i = 0; i < brojac; i++)
            {
                var novi = new GradoviIB230005
                {
                    Naziv = txtNaziv.Text,
                    Status = status,
                    DrzavaId = drzaveIB230005.Id,
                };
               await db.GradoviIB230005.AddAsync(novi);
               await  db.SaveChangesAsync();
                txtInfo.Invoke((Action)(() =>
                {
                    txtInfo.Text += $"{DateTime.Now}-> dopdat grad {novi.Naziv} za drzavu {drzaveIB230005.Naziv}{Environment.NewLine}";

                }
                ));
                await Task.Delay(300);
                UcitajGradove();

            }
        }

        private bool ValidirajGenerisanje()
        {
            return !string.IsNullOrEmpty(txtBrojGradova.Text) && cbAktivni.Checked;
        }
    }
}

using DLWMS.Data;
using DLWMS.Data.IB230005;
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.Izvjestaji;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IB230005
{
    public partial class frmUvjerenjaIB230005 : Form
    {
        private Student student;
        List<StudentiUvjerenjaIB230005> ListaUvjerenja = new List<StudentiUvjerenjaIB230005>();
        DLWMSDbContext db = new DLWMSDbContext();


        public frmUvjerenjaIB230005(Student student)
        {
            InitializeComponent();
            this.student = student;
            dgvStudenti.AutoGenerateColumns = false;
            btnDodaj.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmUvjerenjaIB230005_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
            if (ListaUvjerenja.Count > 0)
            {
                btnDodaj.Enabled = true;
            }

        }

        private void UcitajPodatke()
        {
            ListaUvjerenja = db.StudentiUvjerenjaIB230005.Where(x => x.StudentId == student.Id).ToList();
            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = ListaUvjerenja;
            this.Text = $"Broj uvjerneja -> {ListaUvjerenja.Count()}";

        }

        private void btnNoviZahtjev_Click(object sender, EventArgs e)
        {
            new frmNovoUvjerenjeIB230005(student).ShowDialog();
            UcitajPodatke();
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if (ValidnoGen())
            {
                var vrsta = cmbVrsta.SelectedItem.ToString();

                var svrha = txtSvrha.Text;
                var brojac = int.Parse(txtBroj.Text);

                await DodajAsync(vrsta, svrha, brojac);
            }


        }

        private bool ValidnoGen()
        {
            return Helpers.Validator.ValidirajKontrolu(cmbVrsta, errorProvider1, Kljucevi.ObaveznaVrijednost) &&
                 Helpers.Validator.ValidirajKontrolu(txtSvrha, errorProvider1, Kljucevi.ObaveznaVrijednost) &&
                 Helpers.Validator.ValidirajKontrolu(txtBroj, errorProvider1, Kljucevi.ObaveznaVrijednost);

        }

        private async Task DodajAsync(string vrsta, string svrha, int brojac)
        {
            for (int i = 0; i < brojac; i++)
            {
                var novo = new StudentiUvjerenjaIB230005
                {
                    StudentId = student.Id,
                    Vrijeme = DateTime.Now,
                    Svrha = svrha,
                    Vrsta = vrsta,
                    Uplatnica = ListaUvjerenja[0].Uplatnica,
                    Printano = true,
                };
                db.StudentiUvjerenjaIB230005.Add(novo);
                await db.SaveChangesAsync();

                txtInfo.Invoke((Action)(() =>
                {
                    txtInfo.Text += $"{DateTime.Now}->{vrsta} ({student.BrojIndeksa})-{student.Ime} {student.Prezime} u {svrha} {Environment.NewLine}";
                }
                    ));
                await Task.Delay(300);
                UcitajPodatke();
            }
        }

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var uvjernje = ListaUvjerenja[e.RowIndex];
                MessageBox.Show("Jeste li sigurni da zelite obriasti", "upozorenje", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.Yes)
                {
                    db.StudentiUvjerenjaIB230005.Remove(uvjernje);
                    db.SaveChanges();
                    UcitajPodatke();
                }
                else if (DialogResult == DialogResult.No)
                {
                    Close();
                }
            }
            else if (e.ColumnIndex == 6)
            {
                var odabrano = ListaUvjerenja[e.RowIndex];
                odabrano.Printano = true;
                db.SaveChanges();
                UcitajPodatke();
                new frmIzvjestaji(student, odabrano).ShowDialog();

            }
        }
    }
}

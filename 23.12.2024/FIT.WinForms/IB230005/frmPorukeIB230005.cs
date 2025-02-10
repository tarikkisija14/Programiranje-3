using FIT.Data;
using FIT.Data.IB230005;
using FIT.Infrastructure;
using FIT.WinForms.Izvjestaji;
using Microsoft.EntityFrameworkCore;
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
    public partial class frmPorukeIB230005 : Form
    {
        private Student student;
        DLWMSDbContext db = new DLWMSDbContext();
        List<StudentiPorukeIB230005> ListaPoruka = new List<StudentiPorukeIB230005>();


        public frmPorukeIB230005(Student student = null)
        {
            InitializeComponent();
            this.student = student;
            dgvPoruke.AutoGenerateColumns = false;
            cmbPredmet.DataSource = db.Predmeti.ToList();
        }

        private void frmPorukeIB230005_Load(object sender, EventArgs e)
        {
            UcitajPoruke();
            lblPoruka.Text = $"Poruke studenta@{student.Ime} {student.Prezime}";


        }

        private void UcitajPoruke()
        {
            var lista = db.StudentiPorukeIB230005

                .Where(x => x.StudentId == student.Id && x.Validnost < DateTime.Now).ToList();
            

            this.Text = $"Broj poruka: {ListaPoruka.Count}";

            if (ListaPoruka.Count <= 0)
                btnDodaj.Enabled = false;
            else
                btnDodaj.Enabled = true;

            dgvPoruke.DataSource = null;
            dgvPoruke.DataSource = lista;


        }

        private void btnNovaPoruka_Click(object sender, EventArgs e)
        {
            new frmNovaPorukaIB230005(student).ShowDialog();
            UcitajPoruke();
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if (ValidirajGenerisanje())
            {
                var validan = dtpValidnost.Value;
                var brojac = int.Parse(txtBrojPoruka.Text);
                var predmet = cmbPredmet.SelectedValue as PredmetiIB230005;
                var img = student.Slika;

                await DodajAsync(validan, brojac, predmet, img);
                UcitajPoruke();
            }
        }

        private bool ValidirajGenerisanje()
        {
            return Helpers.Validator.ProvjeriUnos(txtBrojPoruka, err, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(cmbPredmet, err, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(dtpValidnost, err, Kljucevi.ReqiredValue);
        }

        private async Task DodajAsync(DateTime validan, int brojac, PredmetiIB230005? predmet, byte[] img)
        {
            for (int i = 0; i < brojac; i++)
            {
                var nova = new StudentiPorukeIB230005
                {
                    Hitnost = "Srednja",
                    Predmet = predmet,
                    StudentId = student.Id,
                    Slika = img,
                    Sadrzaj = $"Generisana poruka{i}",
                    Validnost = validan,
                };
                db.StudentiPorukeIB230005.Add(nova);
                await db.SaveChangesAsync();
                await Task.Delay(100);

                txtInfo.Invoke((Action)(
               () =>
               {
                   txtInfo.Text += $"{DateTime.Now}->Generisana poruka za {student.Ime} {student.Prezime} za predmet {predmet.Naziv}. {Environment.NewLine}";
                   PomjeriKursor();
               }));

            }
        }

        private void PomjeriKursor()
        {
            txtInfo.SelectionStart = txtInfo.Text.Length;
            txtInfo.ScrollToCaret();
        }

        private void dgvPoruke_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var poruka = MessageBox.Show("Jeste li sigurni da zelite obrissatli poruku ???", "Warning", MessageBoxButtons.YesNo);
                if (poruka == DialogResult.Yes)
                {
                    var brisanje = dgvPoruke.Rows[e.RowIndex].DataBoundItem as StudentiPorukeIB230005;
                    db.StudentiPorukeIB230005.Remove(brisanje);
                    db.SaveChanges();
                    UcitajPoruke();
                }
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
           new frmIzvjestaji(student).ShowDialog();
        }
    }
}

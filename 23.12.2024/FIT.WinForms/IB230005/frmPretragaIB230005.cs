using FIT.Data;
using FIT.Data.IB230005;
using FIT.Infrastructure;
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
    public partial class frmPretragaIB230005 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<Student> ListaStudenata = new List<Student>();
        public frmPretragaIB230005()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
            dtpOd.Value = new DateTime(1999, 1, 1);

        }

        private void frmPretragaIB230005_Load(object sender, EventArgs e)
        {
            cmbSemestar.DataSource = db.Semestri.ToList();
            cmbUloga.DataSource = db.Uloge.ToList();
        }

        private void cmbSemestar_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void cmbUloga_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void dtpOd_ValueChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void dtpDo_ValueChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            if (ValidirajPodatke())
            {
                var datumod = dtpOd.Value;
                var datumdo = dtpDo.Value;
                var semestar = cmbSemestar.SelectedItem as SemestriIB230005;
                var uloga = cmbUloga.SelectedItem as UlogeIB230005;

                ListaStudenata=db.Studenti.Where(x=>x.Semestar==semestar && x.Uloga==uloga &&
                 x.DatumRodjenja <= datumdo && x.DatumRodjenja >= datumod ).ToList();
                

                var tabela = new DataTable();
                tabela.Columns.Add("Indeks");
                tabela.Columns.Add("ImePrezime");
                tabela.Columns.Add("DatumRodjenja");
                tabela.Columns.Add("Prosjek");
                tabela.Columns.Add("Aktivan");
                tabela.Columns.Add("Uloga");

                foreach (var student in ListaStudenata)
                {
                    var red = tabela.NewRow();
                    var ocjena = db.PolozeniPredmeti.Where(x => x.StudentId == student.Id).ToList();

                    red["Indeks"] = student.Indeks;
                    red["ImePrezime"] = student.Ime + " " + student.Prezime;
                    red["DatumRodjenja"] = student.DatumRodjenja;
                    red["Prosjek"] = ocjena.Count() == 0 ? "5" : ocjena.Average(x => x.Ocjena);
                    red["Uloga"] = student.Uloga.Naziv;
                    red["Aktivan"] = student.Aktivan;
                    tabela.Rows.Add(red);

                }
                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = tabela;



            }
        }

        private bool ValidirajPodatke()
        {
            return Helpers.Validator.ProvjeriUnos(cmbSemestar, err, Kljucevi.ReqiredValue) &&
                  Helpers.Validator.ProvjeriUnos(cmbUloga, err, Kljucevi.ReqiredValue) &&
                  Helpers.Validator.ProvjeriUnos(dtpOd, err, Kljucevi.ReqiredValue) &&
                  Helpers.Validator.ProvjeriUnos(dtpDo, err, Kljucevi.ReqiredValue);
        }

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                new frmPorukeIB230005(ListaStudenata[e.RowIndex]).ShowDialog();
            }
        }
    }
}

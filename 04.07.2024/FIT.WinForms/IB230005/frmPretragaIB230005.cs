using FIT.Data;
using FIT.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.Internal;
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
            dgvSTudenti.AutoGenerateColumns = false;
            dtpOd.Value = new DateTime(1990, 1, 1);
        }

        private void frmPretragaIB230005_Load(object sender, EventArgs e)
        {
            cmbSpol.SelectedIndex = 0;
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            if (ValidirajPodatke())
            {
                var spol = cmbSpol.SelectedItem.ToString() ?? "Svi";
                var datumOd = dtpOd.Value;
                var datumDo = dtpDo.Value;


                if (spol == "Svi")
                {
                    ListaStudenata = db.Studenti.Where(x => x.DatumRodjenja > datumOd && x.DatumRodjenja < datumDo).ToList();
                }
                else
                {
                    ListaStudenata = db.Studenti.Where(x => x.Spol == spol && x.DatumRodjenja > datumOd && x.DatumRodjenja < datumDo).ToList();
                }

                var tabela = new DataTable();
                tabela.Columns.Add("BrojIndeksa");
                tabela.Columns.Add("ImePrezime");
                tabela.Columns.Add("Prosjek");
                tabela.Columns.Add("DatumRodjenja");
                tabela.Columns.Add("Aktivan");

                foreach (var student in ListaStudenata)
                {
                    var red = tabela.NewRow();
                    var ocjena = db.PolozeniPredmeti.Where(x => x.StudentId == student.Id).ToList();

                    red["BrojIndeksa"] = student.Indeks.ToString();
                    red["ImePrezime"] = $"{student.Ime} {student.Prezime}";
                    red["Prosjek"] = ocjena.Count() == 0 ? "5" : ocjena.Average(x => x.Ocjena);
                    red["DatumRodjenja"] = student.DatumRodjenja.ToString();
                    red["Aktivan"] = student.Aktivan;
                    tabela.Rows.Add(red);

                }
                dgvSTudenti.DataSource = null;
                dgvSTudenti.DataSource = tabela;


                if (ListaStudenata.Count == 0)
                {
                    MessageBox.Show("PRAZAN TI JE DGV!!!");
                }


            }


        }

        private bool ValidirajPodatke()
        {
            return Helpers.Validator.ProvjeriUnos(cmbSpol, errorProvider1, Kljucevi.ReqiredValue) &&
               Helpers.Validator.ProvjeriUnos(dtpOd, errorProvider1, Kljucevi.ReqiredValue) &&
               Helpers.Validator.ProvjeriUnos(dtpDo, errorProvider1, Kljucevi.ReqiredValue);
        }

        private void cmbSpol_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void dtpOd_ValueChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void dtDo_ValueChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void dgvSTudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                new frmUvjerenjaIB230005(ListaStudenata[e.RowIndex]).ShowDialog();
                UcitajPodatke();

            }
            else
            {
                new frmStudentInfoIB230005(ListaStudenata[e.RowIndex]).ShowDialog();
                UcitajPodatke();
            }
        }
    }
}

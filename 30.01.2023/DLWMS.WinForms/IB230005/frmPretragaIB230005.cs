using DLWMS.Data;
using DLWMS.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IB230005
{
    public partial class frmPretragaIB230005 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<Student> ListaStudenata = new List<Student>();
        public frmPretragaIB230005()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
            dtpOd.Value = new DateTime(1990, 1, 1);
            cmbSpol.DataSource = db.Spolovi.ToList();


        }


        private void frmPretragaIB230005_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {

            if (ValidirajPodatke())
            {
                var datumod = dtpOd.Value;
                var datumdo = dtpDo.Value;
                var spol = cmbSpol.SelectedItem as Spol;


                ListaStudenata = db.Studenti.Where(x => x.Spol == spol && x.DatumRodjenja > datumod && x.DatumRodjenja < datumdo).ToList();


                var tabela = new DataTable();
                tabela.Columns.Add("BrojIndeksa");
                tabela.Columns.Add("ImePrezime");
                tabela.Columns.Add("Prosjek");
                tabela.Columns.Add("DatumRodjenja");
                tabela.Columns.Add("Aktivan");


                foreach (var student in ListaStudenata)
                {
                    var red = tabela.NewRow();
                    var ocjene = db.StudentiPredmeti.Where(x => x.StudentId == student.Id).ToList();

                    red["BrojIndeksa"] = student.BrojIndeksa;
                    red["ImePrezime"] = $"{student.Ime} {student.Prezime}";
                    red["Prosjek"] = ocjene.Count() == 0 ? "5" : ocjene.Average(x => x.Ocjena);
                    red["DatumRodjenja"] = student.DatumRodjenja.ToString();
                    red["Aktivan"] = student.Aktivan;
                    tabela.Rows.Add(red);

                }
                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = tabela;


            }
        }

        private bool ValidirajPodatke()
        {
            return Helpers.Validator.ValidirajKontrolu(cmbSpol, errorProvider1, Kljucevi.ObaveznaVrijednost) &&
                Helpers.Validator.ValidirajKontrolu(dtpOd, errorProvider1, Kljucevi.ObaveznaVrijednost) &&
                Helpers.Validator.ValidirajKontrolu(dtpDo, errorProvider1, Kljucevi.ObaveznaVrijednost);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbSpol_SelectedIndexChanged(object sender, EventArgs e)
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

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
               new frmUvjerenjaIB230005(ListaStudenata[e.RowIndex]).ShowDialog();
            }
            else
            {
                new frmStudentInfoIB230005(ListaStudenata[e.RowIndex]).ShowDialog();
            }
        }
    }
}

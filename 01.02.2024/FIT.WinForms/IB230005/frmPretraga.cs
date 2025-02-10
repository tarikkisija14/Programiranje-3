using FIT.Data;
using FIT.Data.IB230005;
using FIT.Infrastructure;
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
    public partial class frmPretraga : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<Student> ListaStudenta = new List<Student>();
        public frmPretraga()
        {
            InitializeComponent();
            dgvPretraga.AutoGenerateColumns = false;
        }

        private void frmPretraga_Load(object sender, EventArgs e)
        {
            cmbDrzava.DataSource = db.DrzaveIB230005.ToList();
            cmbDrzava.SelectedIndex= 0;

        }

        private void cmbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
            UcitajGradove();
        }

        private void UcitajGradove()
        {
            var drzava = cmbDrzava.SelectedItem as DrzaveIB230005;
            cmbGrad.DataSource=db.GradoviIB230005.Where(x=>x.DrzavaId==drzava.Id).ToList();
            cmbGrad.SelectedIndex=0;
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            if (ValidirajPodatke())
            {
                var drzava = cmbDrzava.SelectedItem as DrzaveIB230005;
                var gradovi = cmbGrad.SelectedItem as GradoviIB230005;

                ListaStudenta = db.Studenti.Where(x => x.GradId == gradovi.Id).ToList();

                var tabela = new DataTable();
                tabela.Columns.Add("Ime");
                tabela.Columns.Add("Prezime");
                tabela.Columns.Add("Grad");
                tabela.Columns.Add("Drzava");
                tabela.Columns.Add("Prosjek");

                foreach (var student in ListaStudenta)
                {
                    var ocjene = db.PolozeniPredmeti.Where(x => x.StudentId == student.Id).ToList();
                    var red = tabela.NewRow();
                    red["Ime"] = student.Ime;
                    red["Prezime"] = student.Prezime;
                    red["Grad"] = student.Grad.Naziv;
                    red["Drzava"] = drzava.Naziv;
                    red["Prosjek"] = ocjene.Count() == 0 ? "5" : ocjene.Average(x => x.Ocjena);
                    tabela.Rows.Add(red);

                }
                dgvPretraga.DataSource = null;
                dgvPretraga.DataSource = tabela;



            }
        }

        private void cmbGrad_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
           
        }

        private bool ValidirajPodatke()
        {
            return Helpers.Validator.ProvjeriUnos(cmbDrzava, errorProvider1, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(cmbGrad, errorProvider1, Kljucevi.ReqiredValue);
        }
    }
}

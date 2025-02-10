using DLWMS.Data;
using DLWMS.Data.IB230005;
using DLWMS.WinForms.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IB230005
{
    public partial class frmPretragaIB230005 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<StudentiPredmetiIB230005> ListaStudenata = new List<StudentiPredmetiIB230005>();

        public frmPretragaIB230005()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
            dtpOd.Value = new DateTime(1999, 2, 17);
           cmbOcjenaOd.SelectedIndex = 0;
            cmbOcjenaDO.SelectedIndex = 3;
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                new frmPorukeIB230005(ListaStudenata[e.RowIndex]).ShowDialog();
            }
        }

        private void frmPretragaIB230005_Load(object sender, EventArgs e)
        {
            UcitajPodatke(); 
        }

        private void UcitajPodatke()
        {
           


            if (ValidniPodaci())
            {
                var ocjenaod = int.Parse(cmbOcjenaOd.SelectedItem.ToString());
                var ocjenado = int.Parse(cmbOcjenaDO.SelectedItem.ToString());


                var datumod = dtpOd.Value;
                var datumdo = dtpDo.Value;


                ListaStudenata = db.StudentiPredmeti.Where(x => x.Ocjena >= ocjenaod && x.Ocjena <= ocjenado &&
                x.Datum >= datumod && x.Datum <= datumdo).ToList();
                

                var tabela = new DataTable();
                tabela.Columns.Add("Indeks");
                tabela.Columns.Add("ImePrezime");
                tabela.Columns.Add("Predmet");
                tabela.Columns.Add("Ocjena");
                tabela.Columns.Add("DatumPolaganja");

               
     

                foreach (var sp in ListaStudenata)
                {
                   

                    ListaStudenata = db.StudentiPredmeti
                     .Where(x => x.Ocjena >= 6 && x.Ocjena <= 10 &&
                                 x.Datum >= datumod && x.Datum <= datumdo)
                     .Include(x => x.Student)
                     .Include(x => x.Predmet)
                     .ToList();


                    var red = tabela.NewRow();
                    red["Indeks"] = sp.Student.BrojIndeksa;
                    red["ImePrezime"] = sp.Student.Ime + " " + sp.Student.Prezime;
                    red["Predmet"] = sp.Predmet.Naziv;
                    red["Ocjena"] = sp.Ocjena;
                    red["DatumPolaganja"] = sp.Datum;
                    tabela.Rows.Add(red);


                }
                if (ListaStudenata.Count > 0)
                {
                    dgvStudenti.DataSource = null;
                    dgvStudenti.DataSource = tabela;
                }
                else
                {
                    MessageBox.Show("Nema ocjena evidentiranih");
                }

            }

        }

        private bool ValidniPodaci()
        {
            return Helpers.Validator.ValidirajKontrolu(cmbOcjenaOd, errorProvider1, Kljucevi.PodaciNisuValidni) &&
                Helpers.Validator.ValidirajKontrolu(cmbOcjenaDO, errorProvider1, Kljucevi.PodaciNisuValidni) &&
                Helpers.Validator.ValidirajKontrolu(dtpOd, errorProvider1, Kljucevi.PodaciNisuValidni) &&
                Helpers.Validator.ValidirajKontrolu(dtpDo, errorProvider1, Kljucevi.PodaciNisuValidni);
        }

        private void CmbOcjenaDO_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void cmbOcjenaOd_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}

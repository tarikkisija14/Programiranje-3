using DLWMS.Data;
using DLWMS.Data.IB230005;
using DLWMS.WinForms.Helpers;
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
    public partial class frmNovaPorukaIB230005 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        private StudentiPredmetiIB230005 studentiPredmetiIB230005;

       

        public frmNovaPorukaIB230005(StudentiPredmetiIB230005 studentiPredmetiIB230005=null)
        {
            InitializeComponent();
            this.studentiPredmetiIB230005 = studentiPredmetiIB230005;
        }

        private void frmNovaPorukaIB230005_Load(object sender, EventArgs e)
        {
            cmbPredmet.DataSource = db.Predmeti.ToList();
        }

        private void btnScauvaj_Click(object sender, EventArgs e)
        {
            if (ValidniPodaci())
            {
                var nova = new StudentiPorukeIB230005
                {
                    Predmet = cmbPredmet.SelectedItem as PredmetiIB230005,
                    StudentId=studentiPredmetiIB230005.StudentId,
                    Validnost = dtpValidnsot.Value,
                    Sadrzaj = txtSadrzaj.Text,
                    Slika = Helpers.ImageHelper.FromImageToByte(pbSlika.Image)

                };
                db.StudentiPorukeIB230005.Add(nova);
                db.SaveChanges();
                Close();

            }
        }

        private bool ValidniPodaci()
        {
            return Helpers.Validator.ValidirajKontrolu(cmbPredmet, errorProvider1, Kljucevi.PodaciNisuValidni) &&
                Helpers.Validator.ValidirajKontrolu(dtpValidnsot, errorProvider1, Kljucevi.PodaciNisuValidni) &&
                Helpers.Validator.ValidirajKontrolu(txtSadrzaj, errorProvider1, Kljucevi.PodaciNisuValidni) &&
                Helpers.Validator.ValidirajKontrolu(pbSlika, errorProvider1, Kljucevi.PodaciNisuValidni);
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

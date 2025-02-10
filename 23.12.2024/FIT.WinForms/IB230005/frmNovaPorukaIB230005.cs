using FIT.Data;
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
    public partial class frmNovaPorukaIB230005 : Form
    {
        private Student student;
        DLWMSDbContext db = new DLWMSDbContext();


        public frmNovaPorukaIB230005(Student student = null)
        {
            InitializeComponent();
            this.student = student;
            cmbHitnost.SelectedIndex = 0;
        }

        private void frmNovaPorukaIB230005_Load(object sender, EventArgs e)
        {
            cmbPredmeti.DataSource = db.Predmeti.ToList();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidirajPodatke())
            {
                var nova = new StudentiPorukeIB230005
                {
                    Predmet = cmbPredmeti.SelectedValue as PredmetiIB230005,
                    StudentId = student.Id,
                    Hitnost = cmbHitnost.SelectedItem.ToString(),
                    Sadrzaj = txtSadrzaj.Text,
                    Slika = Ekstenzije.ToByteArray(pbSlika.Image),
                    Validnost = dtpValidnost.Value,
                };
                db.StudentiPorukeIB230005.Add(nova);
                db.SaveChanges();
                MessageBox.Show("uspjesno ste doodali poruku", "obavijest", MessageBoxButtons.OK);
                Close();
            }
        }

        private bool ValidirajPodatke()
        {
            return Helpers.Validator.ProvjeriUnos(cmbPredmeti, err, Kljucevi.ReqiredValue) &&
               Helpers.Validator.ProvjeriUnos(dtpValidnost, err, Kljucevi.ReqiredValue) &&
               Helpers.Validator.ProvjeriUnos(cmbHitnost, err, Kljucevi.ReqiredValue) &&
               Helpers.Validator.ProvjeriUnos(txtSadrzaj, err, Kljucevi.ReqiredValue) &&
               Helpers.Validator.ProvjeriUnos(pbSlika, err, Kljucevi.ReqiredValue);
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

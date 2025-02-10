using DLWMS.Data;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Helpers;
using DocumentFormat.OpenXml.Office2010.Excel;
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

namespace DLWMS.WinApp.IB230005
{
    public partial class frmStudentiEdit : Form
    {
        private Student student;
        DLWMSContext db = new DLWMSContext();


        public frmStudentiEdit(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidniPodaci())
            {
                student.Slika = Ekstenzije.ToByteArray(pbSlika.Image);

                
                int noviGradId = (int)cmbGrad.SelectedValue;

                if (student.GradId != noviGradId)
                {
                    
                    var prethodniGrad = db.Gradovi.Find(student.GradId);
                    if (prethodniGrad != null)
                    {
                        db.Entry(prethodniGrad).State = EntityState.Detached;
                    }
 
                    student.GradId = noviGradId;
                    db.Entry(student).State = EntityState.Modified;
                }

                
                db.Studenti.Update(student);
                db.SaveChanges();
                Close(); 
            }
        }




        private bool ValidniPodaci()
        {
            return Helpers.Validator.ProvjeriUnos(pbSlika, errorProvider1, Kljucevi.RequiredField) &&
                Helpers.Validator.ProvjeriUnos(cmbDrzava, errorProvider1, Kljucevi.RequiredField) &&
                Helpers.Validator.ProvjeriUnos(cmbGrad, errorProvider1, Kljucevi.RequiredField);
        }

        private void fmrStudentiEdit_Load(object sender, EventArgs e)
        {
            lblImePrezime.Text = $"{student.Ime} {student.Prezime}";
            lblBrojIndeksa.Text = $"{student.BrojIndeksa}";
            cmbDrzava.DataSource = db.Drzave.ToList();
            cmbDrzava.DisplayMember = "Naziv"; 
            cmbDrzava.ValueMember = "Id"; 
            cmbDrzava.SelectedIndex = cmbDrzava.FindStringExact(student.Grad.Drzava.Naziv);
            var drzava = cmbDrzava.SelectedItem as Drzava ?? new Drzava();
            cmbGrad.DataSource = db.Gradovi.Where(x => x.DrzavaId == drzava.Id).AsNoTracking().ToList();
            cmbGrad.DisplayMember = "Naziv"; 
            cmbGrad.ValueMember = "Id"; 
            cmbGrad.SelectedIndex = cmbGrad.FindStringExact(student.Grad.Naziv);
            pbSlika.Image = Ekstenzije.ToImage(student.Slika);
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void cmbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            var drzava = cmbDrzava.SelectedItem as Drzava;
            cmbGrad.DataSource = db.Gradovi.Where(x => x.DrzavaId == drzava.Id).ToList();
            cmbGrad.SelectedIndex = -1;

        }
    }
}

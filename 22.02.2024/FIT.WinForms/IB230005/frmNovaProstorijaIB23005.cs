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
    public partial class frmNovaProstorijaIB23005 : Form
    {
        private ProstorijeIB230005 prostorijeIB230005;
        DLWMSDbContext db = new DLWMSDbContext();


        public frmNovaProstorijaIB23005(ProstorijeIB230005 prostorijeIB230005 = null)
        {
            InitializeComponent();
            this.prostorijeIB230005 = prostorijeIB230005;
        }

        private void frmNovaProstorijaIB23005_Load(object sender, EventArgs e)
        {
            if (prostorijeIB230005 != null)
            {
                pbLogo.Image = prostorijeIB230005.Logo.ToImage();
                txtNaziv.Text = prostorijeIB230005.Naziv;
                txtKapacitet.Text = prostorijeIB230005.Kapacitet;
                txtOznaka.Text = prostorijeIB230005.Oznaka;

            }
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                pbLogo.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidirajPodatke())
            {
                if(prostorijeIB230005 == null)
                {
                    var nova = new ProstorijeIB230005()
                    {
                        Logo=Helpers.Ekstenzije.ToByteArray(pbLogo.Image),
                        Naziv=txtNaziv.Text,
                        Oznaka=txtOznaka.Text,  
                        Kapacitet=txtKapacitet.Text,
                    };
                    db.ProstorijeIB230005.Add(nova);
                    db.SaveChanges();
                    Close();
                }
                else
                {
                    prostorijeIB230005.Logo = Helpers.Ekstenzije.ToByteArray(pbLogo.Image);
                    prostorijeIB230005.Naziv = txtNaziv.Text;
                    prostorijeIB230005.Oznaka = txtOznaka.Text;
                    prostorijeIB230005.Kapacitet = txtKapacitet.Text;
                    db.ProstorijeIB230005.Update(prostorijeIB230005);
                    db.SaveChanges();
                    Close();
                }
            }
        }

        private bool ValidirajPodatke()
        {
            return Helpers.Validator.ProvjeriUnos(pbLogo, errorProvider1, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(txtKapacitet, errorProvider1, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(txtNaziv, errorProvider1, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(txtOznaka, errorProvider1, Kljucevi.ReqiredValue);
        }
    }
}

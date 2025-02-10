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
    public partial class frmNovaDrzavaIB230005 : Form
    {
        private DrzaveIB230005 drzaveIB230005;
        DLWMSDbContext db = new DLWMSDbContext();


        public frmNovaDrzavaIB230005(DrzaveIB230005 drzaveIB230005 = null)
        {
            InitializeComponent();
            this.drzaveIB230005 = drzaveIB230005;
        }

        private void frmNovaDrzavaIB230005_Load(object sender, EventArgs e)
        {
            if (drzaveIB230005 != null)
            {
                pbZastava.Image = drzaveIB230005.Zastava.ToImage();
                txtNaziv.Text = drzaveIB230005.Naziv;
                cbaktivna.Checked = drzaveIB230005.Status;
            }
        }

        private void pbZastava_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbZastava.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidanUnos())
            {
                if(drzaveIB230005 == null)
                {
                    var nova = new DrzaveIB230005
                    {
                        Zastava=pbZastava.Image.ToByteArray(),
                        Naziv=txtNaziv.Text,
                        Status=cbaktivna.Checked,
                    };
                    db.DrzaveIB230005.Add(nova);
                    db.SaveChanges();
                    Close();
                }
                else{

                    drzaveIB230005.Zastava=pbZastava.Image.ToByteArray();
                    drzaveIB230005.Status=cbaktivna.Checked;
                   drzaveIB230005.Naziv=txtNaziv.Text;
                    db.DrzaveIB230005.Update(drzaveIB230005);
                    db.SaveChanges();
                    Close();

                }
            }
        }

        private bool ValidanUnos()
        {
            return Helpers.Validator.ProvjeriUnos(pbZastava, errorProvider1, Kljucevi.ReqiredValue) &&
                  Helpers.Validator.ProvjeriUnos(txtNaziv, errorProvider1, Kljucevi.ReqiredValue) &&
                   Helpers.Validator.ProvjeriUnos(cbaktivna, errorProvider1, Kljucevi.ReqiredValue);
        }
    }
}

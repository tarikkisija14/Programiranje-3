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
    public partial class frmNovoUvjerenjeIB230005 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        private Student student;

        public frmNovoUvjerenjeIB230005()
        {
            
        }

        public frmNovoUvjerenjeIB230005(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void pbUplatnica_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbUplatnica.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void frmNovoUvjerenjeIB230005_Load(object sender, EventArgs e)
        {

        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidniPodaci())
            {
                var novo = new StudentiUvjerenjaIB230005
                {
                    Vrsta = cmbVrsta.SelectedItem.ToString(),
                    Svrha = txtSvrha.Text,
                    Uplatnica = ImageHelper.FromImageToByte(pbUplatnica.Image),
                    Vrijeme = DateTime.Now,
                    StudentId = student.Id,
                    Printano = true

                };
                db.StudentiUvjerenjaIB230005.Add(novo);
                db.SaveChanges();
                Close();
            }
        }

        private bool ValidniPodaci()
        {
            return Helpers.Validator.ValidirajKontrolu(cmbVrsta, errorProvider1, Kljucevi.ObaveznaVrijednost) &&
              Helpers.Validator.ValidirajKontrolu(txtSvrha, errorProvider1, Kljucevi.ObaveznaVrijednost) &&
              Helpers.Validator.ValidirajKontrolu(pbUplatnica, errorProvider1, Kljucevi.ObaveznaVrijednost);
        }
    }
}

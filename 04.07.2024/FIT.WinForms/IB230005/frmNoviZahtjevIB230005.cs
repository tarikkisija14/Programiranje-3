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
    public partial class frmNoviZahtjevIB230005 : Form
    {
        private Student student;
        DLWMSDbContext db = new DLWMSDbContext();



        public frmNoviZahtjevIB230005(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void frmNoviZahtjevIB230005_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidanUnos())
            {
                var novo = new StudentiUvjerenjaIB230005
                {
                    StudentId = student.Id,
                    Vrijeme = DateTime.Now.ToString(),
                    Vrsta = comboBox1.Text,
                    Svrha = textBox1.Text,
                    Uplatnica = Ekstenzije.ToByteArray(pictureBox1.Image),
                    Printano = true
                };
                db.StudentiUvjerenjaIB230005.Add(novo);
                db.SaveChanges();
                Close();
            }
        }

        private bool ValidanUnos()
        {
            return Helpers.Validator.ProvjeriUnos(pictureBox1, errorProvider1, Kljucevi.ReqiredValue) &&
               Helpers.Validator.ProvjeriUnos(textBox1, errorProvider1, Kljucevi.ReqiredValue) &&
               Helpers.Validator.ProvjeriUnos(comboBox1, errorProvider1, Kljucevi.ReqiredValue);
        }
    }
}

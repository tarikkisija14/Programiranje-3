using FIT.Data;
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
    public partial class frmStudentInfoIB230005 : Form
    {
        private Student student;
        DLWMSDbContext db=new DLWMSDbContext();
        

        public frmStudentInfoIB230005(Student student=null)
        {
            InitializeComponent();
            this.student = student;
        }

        private void frmStudentInfoIB230005_Load(object sender, EventArgs e)
        {
            if (student != null)
            {
                this.Text=student.Indeks.ToString();
                pbSlika.Image = student.Slika.ToImage();
                lblIme.Text = student.Ime+" "+student.Prezime;
                var ocjene= db.PolozeniPredmeti.Where(x => x.StudentId == student.Id).ToList();
                var prosjek = ocjene.Count() == 0 ? "5" : ocjene.Average(x => x.Ocjena).ToString();
                lblProsjek.Text = $"Prosjek :{prosjek} ";

            }
        }
    }
}

using DLWMS.Data;
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
    public partial class frmStudentInfoIB230005 : Form
    {
        private Student student;
        DLWMSDbContext db = new DLWMSDbContext();
       

        public frmStudentInfoIB230005(Student student)
        {
            InitializeComponent();
            this.student = student;
            this.Text = student.BrojIndeksa;
        }

        private void frmStudentInfoIB230005_Load(object sender, EventArgs e)
        {
            if (student != null)
            {
                pbSlika.Image=ImageHelper.FromByteToImage(student.Slika);
                lblImePrezime.Text = student.Ime + " " + student.Prezime;
                var ocjene=db.StudentiPredmeti.Where(x=>x.StudentId==student.Id).ToList();
                lblProsjek.Text = ocjene.Count() == 0 ? "5" : ocjene.Average(x => x.Ocjena).ToString();
            }
        }
    }
}

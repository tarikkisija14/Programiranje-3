using DLWMS.Data;
using DLWMS.Data.IB230005;
using DLWMS.Infrastructure;
using DocumentFormat.OpenXml.Office2019.Excel.RichData2;
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
    public partial class frmStudentiAddEdit : Form
    {
        private StudentiStipendije studentiStipendije;
        DLWMSContext db = new DLWMSContext();


        public frmStudentiAddEdit(StudentiStipendije studentiStipendije = null)
        {
            InitializeComponent();
            this.studentiStipendije = studentiStipendije;
        }

        private void frmStudentiAddEdit_Load(object sender, EventArgs e)
        {
            if (studentiStipendije != null)
            {
                cmbStudent.Items.Add($"{studentiStipendije.Student.Ime} {studentiStipendije.Student.Prezime}");
                cmbStudent.SelectedIndex = 0;
                cmbStudent.Enabled = false;

                var godina = db.StipendijeGodine
                  .Where(x => x.StipendijaId == studentiStipendije.StipendijaId)
                  .Select(x => x.Godina)
                  .FirstOrDefault();

                cmbGodina.Items.Add(godina);
                cmbGodina.SelectedIndex = 0;


                cmbStipendija.DataSource = db.Stipendije.ToList();
                cmbStipendija.ValueMember = "Id";
                cmbStipendija.DisplayMember = "Naziv";
                cmbStipendija.SelectedValue = studentiStipendije.StipendijaId;


            }
            else
            {
                cmbStudent.DataSource=db.Studenti.ToList();
                cmbStudent.SelectedIndex = 0;
                cmbStipendija.DataSource=db.Stipendije.ToList();
                cmbStipendija.SelectedIndex = 0;
                cmbGodina.SelectedIndex=0;
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if(studentiStipendije== null)
            {
                var odabrana = cmbStipendija.SelectedItem as Stipendije;
                var odabraniStudent = cmbStudent.SelectedItem as Student;

                var nova = new StudentiStipendije()
                {
                    StudentId = odabraniStudent.Id,
                    StipendijaId = odabrana.Id

                };
                db.StudentiStipendije.Add(nova);
                db.SaveChanges();
                Close();
            }
            else
            {
               int novastipendija=(int)cmbStipendija.SelectedValue;
                if (studentiStipendije.StipendijaId != novastipendija)
                {
                    var prosla = db.Stipendije.Find(studentiStipendije.StipendijaId);
                    if (prosla != null)
                    {
                        db.Entry(prosla).State = EntityState.Detached;
                    }
                    studentiStipendije.StipendijaId = novastipendija;
                    db.Entry(studentiStipendije).State = EntityState.Added;
                }
                db.StudentiStipendije.Update(studentiStipendije);
                db.SaveChanges();
                Close();
              
            }
        }
    }
}

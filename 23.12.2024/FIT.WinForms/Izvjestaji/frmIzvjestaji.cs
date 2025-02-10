using FIT.Data;
using FIT.Data.IB230005;
using FIT.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Reporting.WinForms;
using System.Linq;

namespace FIT.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        
        DLWMSDbContext db = new DLWMSDbContext();
        private Student student;

        

        public frmIzvjestaji(Student student=null)
        {

            InitializeComponent();
            this.student = student;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            if(student!=null)
            {
                var listaPoruka = db.StudentiPorukeIB230005
                    .Include(x=>x.Predmet)
                                   .Where(x => x.StudentId == student.Id)
                                   .ToList();

               
                var rep = new ReportParameterCollection();
                var brojPoruka = listaPoruka.Count.ToString();
                var ukupnoKaraktera = listaPoruka.Sum(p => p.Sadrzaj.Length);
                var prosjekKaraktera = listaPoruka.Any() ? ukupnoKaraktera / listaPoruka.Count : 0;

                string imePrezime = $"{student.Ime} {student.Prezime}";

                rep.Add(new ReportParameter("pImePrezime", imePrezime));
                rep.Add(new ReportParameter("BrojPoruka", brojPoruka));
                rep.Add(new ReportParameter("Prosjek", prosjekKaraktera.ToString()));

                reportViewer1.LocalReport.SetParameters(rep);

                
                var tabela = new dataset.PorukeDataTable();
                for (int i = 0; i < listaPoruka.Count; i++)
                {
                    var poruka = listaPoruka[i];
                    var red = tabela.NewPorukeRow();
                    red.Rb = $"{i + 1}";
                    red.Poruka = poruka.Sadrzaj.ToString();
                    red.Predmet = poruka.Predmet.Naziv.ToString();
                    red.BrojZnakova = poruka.Sadrzaj.Length.ToString();
                    red.Validnost = poruka.Validnost.ToString();

                    tabela.Rows.Add(red);
                }

                
                var ds = new ReportDataSource
                {
                    Name = "DataSet1",
                    Value = tabela
                };
                reportViewer1.LocalReport.DataSources.Add(ds);

                reportViewer1.RefreshReport();
            }
            

           
        }
    }
}

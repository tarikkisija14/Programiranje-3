using FIT.Data;
using FIT.Data.IB230005;
using FIT.Infrastructure;
using Microsoft.Reporting.WinForms;

namespace FIT.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private Student student;
        private StudentiUvjerenjaIB230005 kliknuto;
        DLWMSDbContext db=new DLWMSDbContext();

       

        public frmIzvjestaji(Student student=null, StudentiUvjerenjaIB230005 kliknuto=null)
        {
            InitializeComponent();
            this.student = student;
            this.kliknuto = kliknuto;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            var rpc = new ReportParameterCollection();

            var status = student.Aktivan == true ? "AKTIVAN" : "NEAKTIVAN";
            var brojpolozenih  = db.PolozeniPredmeti.Count(x=>x.StudentId==student.Id).ToString();
            var ocjena= db.PolozeniPredmeti.Where(x=>x.StudentId==student.Id).ToList();
            var prosjek = ocjena.Count() == 0 ? "5" : ocjena.Average(x => x.Ocjena).ToString();

          rpc.Add(new ReportParameter("pAktivan", status));
            rpc.Add(new ReportParameter("pImePrezime", student.Ime + " " + student.Prezime));
            rpc.Add(new ReportParameter("pIndeks", student.Indeks));
            rpc.Add(new ReportParameter("pSvrha",kliknuto.Svrha));   
            rpc.Add(new ReportParameter("brojPolozenih",brojpolozenih));
            rpc.Add(new ReportParameter("pProsjek", prosjek));

            reportViewer1.LocalReport.SetParameters(rpc);   
            reportViewer1.RefreshReport();


           
        }
    }
}

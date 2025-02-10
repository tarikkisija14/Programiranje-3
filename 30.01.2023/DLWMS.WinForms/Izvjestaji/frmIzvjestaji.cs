using DLWMS.Data;
using DLWMS.Data.IB230005;
using Microsoft.Reporting.WinForms;

namespace DLWMS.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private Student student;
        private StudentiUvjerenjaIB230005 odabrano;
        DLWMSDbContext db=new DLWMSDbContext();
        
        public frmIzvjestaji(Student student=null, StudentiUvjerenjaIB230005 odabrano=null)
        {
            InitializeComponent();
            this.student = student;
            this.odabrano = odabrano;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            var rpc = new ReportParameterCollection();

            var imeprezime = student.Ime + " " + student.Prezime;
            var svrha=odabrano.Svrha;
            var indeks=student.BrojIndeksa;

            rpc.Add(new ReportParameter("ImePrezime", imeprezime));
            rpc.Add(new ReportParameter("Svrha", svrha));
            rpc.Add(new ReportParameter("Indeks", indeks));

            reportViewer1.LocalReport.SetParameters (rpc);

            reportViewer1.RefreshReport();
        }
    }
}

    using FIT.Data.IB230005;
using FIT.Infrastructure;
using Microsoft.Reporting.WinForms;

namespace FIT.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private DrzaveIB230005 odabrana;
        DLWMSDbContext db=new DLWMSDbContext();

       

        public frmIzvjestaji(DrzaveIB230005 odabrana=null)
        {
            InitializeComponent();
            this.odabrana = odabrana;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            if (odabrana != null)
            {
                var listagradova=db.GradoviIB230005.Where(x=>x.DrzavaId==odabrana.Id).ToList();
                var rep = new ReportParameterCollection();
                var brojgradova = listagradova.Count().ToString();

                rep.Add(new ReportParameter("BrojGradova",brojgradova));
                reportViewer1.LocalReport.SetParameters(rep);

                var tabela = new DataSet1.GradoviDataTable();

                for (int i = 0; i < listagradova.Count; i++)
                {
                    var status = listagradova[i].Status == true ? "DA" : "NE";
                    var red = tabela.NewGradoviRow();
                    red.Rb = $"{i + 1}";
                    red.Grad = listagradova[i].Naziv;
                    red.Drzava = odabrana.Naziv;
                    red.Aktivan = status;
                    tabela.AddGradoviRow(red);


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

using DLWMS.Data.IB230005;
using DLWMS.Infrastructure;
using DocumentFormat.OpenXml.Drawing;
using Microsoft.Reporting.WinForms;

namespace DLWMS.WinApp.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private List<StipendijeGodine> stipendije;
        DLWMSContext db=new DLWMSContext();
        private int godina;
        private Stipendije? stipendija;
        private List<StudentiStipendije> studenti;

      

        public frmIzvjestaji(List<StipendijeGodine> stipendije = null, int godina = 0, Stipendije? stipendija = null, List<StudentiStipendije> studenti = null) 
        {
            InitializeComponent();
            this.stipendije = stipendije;
            this.godina = godina;
            this.stipendija = stipendija;
            this.studenti = studenti;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {   
            if(stipendije!=null)
            {

               


                var rep = new ReportParameterCollection();
                rep.Add(new ReportParameter("Godina", godina.ToString()));
                rep.Add(new ReportParameter("Stipendija", stipendija.Naziv));

                var ukupno = stipendije.Sum(x => x.Iznos); 
                rep.Add(new ReportParameter("Ukupno", ukupno.ToString()));

                reportViewer1.LocalReport.SetParameters(rep);
                
                var tabela = new dsDLWMS.DataTable1DataTable();
                for (int i = 0; i < studenti.Count; i++)
                {
                    var stip = stipendije[i];
                    var stds = studenti[i];

                    var red = tabela.NewDataTable1Row();
                    red.Rb = $"{i + 1}";
                    red.IIP = $"({stds.Student.BrojIndeksa}) {stds.Student.Ime} {stds.Student.Prezime}";
                    red.Iznos = stip.Iznos.ToString();
                    red.Ukupno = stipendije.Sum(x => x.Iznos).ToString();
                    tabela.AddDataTable1Row(red);
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

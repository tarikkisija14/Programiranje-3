using DLWMS.Data;
using DLWMS.Infrastructure;
using Microsoft.Reporting.WinForms;

namespace DLWMS.WinApp.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private List<Razmjene> razmjene;
        DLWMSContext db = new DLWMSContext();
        private Student student;

        public frmIzvjestaji(List<Razmjene> razmjene=null, Student student=null) 
        {
            InitializeComponent();
            this.razmjene = razmjene;
            this.student = student;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            if (razmjene != null)
            {
                var rep = new ReportParameterCollection();

                rep.Add(new ReportParameter("Ime", student.Ime));
                rep.Add(new ReportParameter("Prezime", student.Prezime));
                rep.Add(new ReportParameter("BrojIndeksa", student.BrojIndeksa));
                var averageEcts = razmjene.Average(x => x.ECTS);
                rep.Add(new ReportParameter("ECTS", averageEcts.ToString()));
                reportViewer1.LocalReport.SetParameters(rep);


                var tabela = new dsDLWMS.DataTable1DataTable();
                for (int i = 0; i < razmjene.Count; i++)
                {
                    var razmjena=razmjene[i];
                    var status = razmjena.Okoncana ? "DA" : "NE";
                    var red = tabela.NewDataTable1Row();
                    red.Rb = $"{i + 1}";
                    red.Univerzitet = razmjena.Univerzitet.Naziv;
                    red.Pocetak=razmjena.Pocetak.ToString();
                    red.Kraj=razmjena.Kraj.ToString();
                    red.ECTS=razmjena.ECTS.ToString();
                    red.Okoncano = status;
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

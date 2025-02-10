using FIT.Data.IB230005;
using FIT.Infrastructure;
using Microsoft.Reporting.WinForms;

namespace FIT.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private ProstorijeIB230005 odabranaProstorija;
        DLWMSDbContext db=new DLWMSDbContext();
        

        public frmIzvjestaji(ProstorijeIB230005 odabranaProstorija=null)
        {
            InitializeComponent();
            this.odabranaProstorija = odabranaProstorija;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            var prostorija = odabranaProstorija.Naziv;
            var ListaPristustvo=db.PrisustvoIB230005.Where(x=>x.NastavaId==db.NastavaIB230005.FirstOrDefault
            (x=>x.ProstorijaId==odabranaProstorija.Id).Id).ToList();

            var rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("Prostorija", prostorija));
            rpc.Add(new ReportParameter("BrojStudenata",ListaPristustvo.Count.ToString()));
            rpc.Add(new ReportParameter("TrenutnoVrijeme",DateTime.Now.ToString("D")));

            var tabela = new DataSet1.dtNastavaDataTable();

            for (int i = 0; i < ListaPristustvo.Count; i++)
            {
                var red=tabela.NewdtNastavaRow();

                var nastava = db.NastavaIB230005.FirstOrDefault(x => x.Id == ListaPristustvo[i].NastavaId);
                var predmet = db.Predmeti.FirstOrDefault(x => x.Id == nastava.PredmetId);
                var student = db.Studenti.FirstOrDefault(x => x.Id == ListaPristustvo[i].StudentId);

                red.Rb = $"{i + 1}";
                red.Predmet = predmet.Naziv;
                red.Vrijeme = nastava.Vrijeme;
                red.BrojIndeksa = student.Indeks;
                red.ImePrezime = $"{student.Ime} {student.Prezime}";

                tabela.Rows.Add(red);
            }
            var rds = new ReportDataSource()
            {
                Name = "DataSet1",
                Value = tabela
            };


            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}

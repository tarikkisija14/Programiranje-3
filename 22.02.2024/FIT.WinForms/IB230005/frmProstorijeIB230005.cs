using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FIT.Data.IB230005;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
using FIT.WinForms.Izvjestaji;

namespace FIT.WinForms.IB230005
{

    public partial class frmProstorijeIB230005 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<ProstorijeIB230005> ListaProstorija = new List<ProstorijeIB230005>();


        public frmProstorijeIB230005()
        {
            InitializeComponent();
            dgvProstorija.AutoGenerateColumns = false;
        }

        private void frmProstorijeIB230005_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {

            ListaProstorija = db.ProstorijeIB230005.ToList();
            var tabela = new DataTable();

            tabela.Columns.Add("Logo", typeof(Image));
            tabela.Columns.Add("Naziv");
            tabela.Columns.Add("Oznaka");
            tabela.Columns.Add("Kapacitet");
            tabela.Columns.Add("BrPredmeta");

            foreach (var prostorija in ListaProstorija)
            {
                var red = tabela.NewRow();
                var listapredmeta = db.NastavaIB230005.Where(x => x.ProstorijaId == prostorija.Id).ToList();

                red["Logo"] = Ekstenzije.ToImage(prostorija.Logo);
                red["Naziv"] = prostorija.Naziv;
                red["Oznaka"] = prostorija.Oznaka;
                red["Kapacitet"] = prostorija.Kapacitet;
                red["BrPredmeta"] = listapredmeta.Count;
                tabela.Rows.Add(red);

            }
            dgvProstorija.DataSource = null;
            dgvProstorija.DataSource = tabela;

        }

        private void dgvProstorija_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                new frmNastavaIB230005(ListaProstorija[e.RowIndex]).ShowDialog();
            }
            else if (e.ColumnIndex == 6)
            {
                new frmPrisustvoIB230005(ListaProstorija[e.RowIndex]).ShowDialog();
            }
            else
            {
                new frmNovaProstorijaIB23005(ListaProstorija[e.RowIndex]).ShowDialog();
                UcitajPodatke();
            }
        }

        private void btnNovaProstorija_Click(object sender, EventArgs e)
        {
            new frmNovaProstorijaIB23005().ShowDialog();
            UcitajPodatke();
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            if (dgvProstorija.SelectedRows.Count > 0)
            {

                var red = dgvProstorija.SelectedRows[0].Cells["Naziv"].Value.ToString();
                var odabranaProstorija = db.ProstorijeIB230005.FirstOrDefault(x => x.Naziv == red);
                if(odabranaProstorija != null )
                {
                    new frmIzvjestaji(odabranaProstorija).ShowDialog();
                }
                else
                {
                    MessageBox.Show("Molimo odaberite prostoriju!");
                }
            }
            else
            {
                MessageBox.Show("Molimo odaberite prostoriju!");
            }
        }
    }
}

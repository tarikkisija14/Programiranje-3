using FIT.Data.IB230005;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
using FIT.WinForms.Izvjestaji;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.IB230005
{
    public partial class frmDrzaveGradoviIB230005 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<DrzaveIB230005> ListaDrzava = new List<DrzaveIB230005>();
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public frmDrzaveGradoviIB230005()
        {
            InitializeComponent();
            dgvDrzave.AutoGenerateColumns = false;
            timer.Interval = 1000;
            timer.Tick += (s, e) => lblVrijeme.Text = $"Trenutno vrijeme {DateTime.Now.ToString("HH:mm:ss")}";
            timer.Start();
        }

        private void frmDrzaveGradoviIB230005_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            var tabela = new DataTable();
            tabela.Columns.Add("Zastava", typeof(Image));
            tabela.Columns.Add("Drzava");
            tabela.Columns.Add("BrojGradova");
            tabela.Columns.Add("Aktivna");

            ListaDrzava = db.DrzaveIB230005.ToList();
            foreach (var drzava in ListaDrzava)
            {
                var red = tabela.NewRow();
                var brojac = db.GradoviIB230005.Where(x => x.DrzavaId == drzava.Id).ToList();

                red["Zastava"] = Ekstenzije.ToImage(drzava.Zastava);
                red["Drzava"] = drzava.Naziv;
                red["BrojGradova"] = brojac.Count().ToString();
                red["Aktivna"] = drzava.Status;
                tabela.Rows.Add(red);
            }
            dgvDrzave.DataSource = null;
            dgvDrzave.DataSource = tabela;

        }

        private void btnNovaDrzava_Click(object sender, EventArgs e)
        {
            new frmNovaDrzavaIB230005().ShowDialog();
            UcitajPodatke();
        }

        private void dgvDrzave_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                new frmGradoviIB230005(ListaDrzava[e.RowIndex]).ShowDialog();
            }
            else
            {
                new frmNovaDrzavaIB230005(ListaDrzava[e.RowIndex]).ShowDialog();
                UcitajPodatke();
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            if (dgvDrzave.SelectedRows.Count > 0)
            {
                var red = dgvDrzave.SelectedRows[0];
                var drzava = red.Cells["Drzava"].Value.ToString();
                var odabrana = ListaDrzava.FirstOrDefault(x => x.Naziv == drzava);
                if (odabrana != null)
                {
                    var lista=db.GradoviIB230005.Where(x=>x.DrzavaId==odabrana.Id).ToList();
                    var report = new frmIzvjestaji(odabrana);
                    report.ShowDialog();
                }
                else
                {
                    MessageBox.Show("failed");
                }
            }
            else
            {
                MessageBox.Show("failed,izaberi drzavu");
            }
        }
    }
}

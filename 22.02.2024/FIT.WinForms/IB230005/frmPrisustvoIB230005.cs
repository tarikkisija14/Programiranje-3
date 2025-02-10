using FIT.Data.IB230005;
using FIT.Infrastructure;
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
    public partial class frmPrisustvoIB230005 : Form
    {
        private ProstorijeIB230005 prostorijeIB230005;
        DLWMSDbContext db = new DLWMSDbContext();
        List<PrisustvoIB230005> ListaPrisustva = new List<PrisustvoIB230005>();


        public frmPrisustvoIB230005(ProstorijeIB230005 prostorijeIB230005 = null)
        {
            InitializeComponent();
            this.prostorijeIB230005 = prostorijeIB230005;
            dgvPrisustva.AutoGenerateColumns = false;
            lblOznaka.Text = $"{prostorijeIB230005.Naziv}-{prostorijeIB230005.Oznaka}";
            lblKapacitet.Text = $"{db.Studenti.Count()}/{prostorijeIB230005.Kapacitet}";
        }

        private void frmPrisustvoIB230005_Load(object sender, EventArgs e)
        {
            cmbNastava.DataSource = db.NastavaIB230005.Where(x => x.ProstorijaId == prostorijeIB230005.Id).ToList();
            cmbStudent.DataSource = db.Studenti.ToList();
            cmbNastava.DisplayMember = "Oznaka";
            cmbNastava.ValueMember = "Id";

            cmbStudent.DisplayMember = "ImePrezime";
            cmbStudent.ValueMember = "Id";

            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            var nastavaId = cmbNastava.SelectedValue as int? ?? -1;
            var studentId = cmbStudent.SelectedValue as int? ?? -1;

            ListaPrisustva = db.PrisustvoIB230005.Where(x => x.NastavaId == nastavaId).ToList();
            var tabela = new DataTable();
            tabela.Columns.Add("PPV");
            tabela.Columns.Add("Student");
            foreach (var prisustvo in ListaPrisustva)
            {
                var red = tabela.NewRow();
                red["PPV"] = db.NastavaIB230005.FirstOrDefault(x => x.Id == prisustvo.NastavaId).Oznaka;
                red["Student"] = db.Studenti.FirstOrDefault(x => x.Id == prisustvo.StudentId).ToString();
                tabela.Rows.Add(red);
            }
            dgvPrisustva.DataSource = null;
            dgvPrisustva.DataSource = tabela;


        }

        private void cmbNastava_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var prisustvo = new PrisustvoIB230005
            {
                NastavaId = (int)cmbNastava.SelectedValue,
                StudentId = (int)cmbStudent.SelectedValue,

            };
            db.PrisustvoIB230005.Add(prisustvo);
            db.SaveChanges();
            UcitajPodatke();
        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            var brojac = 0;
            if (ValidirajGen())
            {
                brojac = int.Parse(txtBrojZapisa.Text);
                await Asinkrona(brojac);
            }
        }

        private async Task Asinkrona(int brojac)
        {
            for (int i = 0; i < brojac; i++)
            {
                var nastavaid = (int)cmbNastava.SelectedValue;
                var studentid= (int)cmbStudent.SelectedValue;
                var nastavatekst=cmbNastava.SelectedItem.ToString();
                var studenttekst=cmbStudent.SelectedItem.ToString();
                var nov = new PrisustvoIB230005
                {
                    NastavaId=nastavaid,
                    StudentId=studentid,
                };
               db.PrisustvoIB230005.Add(nov);
                await db.SaveChangesAsync();
                txtInfo.Invoke((Action)(() =>
                {
                    txtInfo.Text += $" {DateTime.Now.ToString("dd.MM HH:mm:ss")}-> {studenttekst} za {nastavatekst}";
                }));

                await Task.Delay(1000);
                UcitajPodatke();
            }
        }

        private bool ValidirajGen()
        {
            return !string.IsNullOrWhiteSpace(txtBrojZapisa.Text);

        }
    }
}

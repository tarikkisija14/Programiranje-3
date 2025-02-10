using FIT.Data;
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
    public partial class frmNastavaIB230005 : Form
    {
        private ProstorijeIB230005 prostorijeIB230005;
        DLWMSDbContext db = new DLWMSDbContext();
        List<NastavaIB230005> ListaNastava = new List<NastavaIB230005>();


        public frmNastavaIB230005(ProstorijeIB230005 prostorijeIB230005 = null)
        {
            InitializeComponent();
            this.prostorijeIB230005 = prostorijeIB230005;
            dgvNastava.AutoGenerateColumns = false;
        }

        private void frmNastavaIB230005_Load(object sender, EventArgs e)
        {
            lblOznaka.Text = $"{prostorijeIB230005.Naziv}-{prostorijeIB230005.Oznaka}";
            cmbDan.SelectedIndex = 0;
            cmbVrijeme.SelectedIndex = 0;
            cmbPredmet.DataSource = db.Predmeti.ToList();
            cmbPredmet.DisplayMember = "Naziv";
            cmbPredmet.ValueMember = "Id";
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {

            if (ValidirajPodatke())
            {

                var predmet = cmbPredmet.SelectedItem as PredmetiIB230005;
                var dan=cmbDan.SelectedItem.ToString();
                var vrijeme=cmbVrijeme.SelectedItem.ToString();

                
                var ListaNastava = db.NastavaIB230005.Where(x => x.ProstorijaId == prostorijeIB230005.Id &&
                x.Predmet==predmet && x.DanOdrzavanja==dan && x.Vrijeme==vrijeme).ToList();


                var tabela = new DataTable();
                tabela.Columns.Add("Predmet");
                tabela.Columns.Add("Dan");
                tabela.Columns.Add("Vrijeme");


                foreach (var nastava in ListaNastava)
                {
                    var red = tabela.NewRow();
                    red["Predmet"] = db.Predmeti.FirstOrDefault(x => x.Id == nastava.PredmetId);
                    red["Dan"] = nastava.DanOdrzavanja;
                    red["Vrijeme"] = nastava.Vrijeme;
                    tabela.Rows.Add(red);


                }
                dgvNastava.DataSource = null;
                dgvNastava.DataSource = tabela;
            }
        }

        private bool ValidirajPodatke()
        {
            return Helpers.Validator.ProvjeriUnos(cmbDan, errorProvider1, Kljucevi.ReqiredValue) &&
               Helpers.Validator.ProvjeriUnos(cmbPredmet, errorProvider1, Kljucevi.ReqiredValue) &&
               Helpers.Validator.ProvjeriUnos(cmbVrijeme, errorProvider1, Kljucevi.ReqiredValue);

        }

        private void cmbPredmet_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void cmbDan_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void cmbVrijeme_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (ValidirajPodatke())
            {
                var predmetId = (int)cmbPredmet.SelectedValue;
                var dan=cmbDan.SelectedItem.ToString();
                var vrijeme=cmbVrijeme.SelectedItem.ToString();
                var oznaka = $"{db.Predmeti.FirstOrDefault(x => x.Id == predmetId)} :: {dan}::{vrijeme}";
                var nova = new NastavaIB230005
                {
                    ProstorijaId = prostorijeIB230005.Id,
                    PredmetId = predmetId,
                    DanOdrzavanja = dan,
                    Vrijeme = vrijeme,
                    Oznaka =oznaka

                };
                db.NastavaIB230005.Add(nova);
                db.SaveChanges();
                UcitajPodatke();

            }
            else
            {
                MessageBox.Show("Termin već zauzet.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

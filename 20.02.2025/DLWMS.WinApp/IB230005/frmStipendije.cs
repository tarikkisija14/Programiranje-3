using DLWMS.Data;
using DLWMS.Data.IB230005;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Izvjestaji;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinApp.IB230005
{
    public partial class frmStipendije : Form
    {
        DLWMSContext db = new DLWMSContext();
        List<StipendijeGodine> ListaStipendija = new List<StipendijeGodine>();
        public frmStipendije()
        {
            InitializeComponent();
        }

        private void frmStipendije_Load(object sender, EventArgs e)
        {
            cmbGodine.SelectedIndex = 0;
            cmbStipendije.DataSource = db.Stipendije.ToList();
            cmbStipendije.SelectedIndex = 0;
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            var godina = cmbGodine.Text;
            ListaStipendija = db.StipendijeGodine.ToList();
            int trenutna = 2025;

            var tabela = new DataTable();
            tabela.Columns.Add("Godina");
            tabela.Columns.Add("Stipendija");
            tabela.Columns.Add("Aktivna");
            tabela.Columns.Add("Iznos");
            tabela.Columns.Add("Ukupno");
            foreach (var stipendija in ListaStipendija)
            {
                var red = tabela.NewRow();
                red["Godina"] = stipendija.Godina;
                red["Stipendija"] = stipendija.Stipendija.Naziv;
                red["Iznos"] = stipendija.Iznos;
                red["Aktivna"] = stipendija.Aktivna;
                var godine = int.Parse(godina.ToString());
                if (stipendija.Godina == trenutna)
                {
                    red["Ukupno"] = stipendija.Iznos * 2;
                }
                else if (stipendija.Godina == trenutna - 1)
                {
                    red["Ukupno"] = stipendija.Iznos * 12;
                }
                else if (stipendija.Godina == trenutna - 2)
                {
                    red["Ukupno"] = stipendija.Iznos * 24;
                }
                else if (stipendija.Godina == trenutna - 3)
                {
                    red["Ukupno"] = stipendija.Iznos * 36;
                }
                else
                {
                    red["Ukupno"] = stipendija.Iznos;
                }
                tabela.Rows.Add(red);

            }

            dgvStipendije.DataSource = null;
            dgvStipendije.DataSource = tabela;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var godina = cmbGodine.Text;
            var stipendija = cmbStipendije.SelectedItem as Stipendije;
            var iznos = txtIznos.Text;
            var nova = new StipendijeGodine()
            {
                Godina = int.Parse(godina),
                StipendijaId = stipendija.Id,
                Iznos = int.Parse(iznos),
                Aktivna = true


            };
            db.StipendijeGodine.Add(nova);
            db.SaveChanges();
            UcitajPodatke();
        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            var stipendija = cmbStipendije.SelectedItem as Stipendije;
            var studenti = db.Studenti.ToList();
            var iznos = int.Parse(txtIznos.Text);

            await DodajThread(stipendija, studenti, iznos);

        }

        private async Task DodajThread(Stipendije? stipendija, List<Student> studenti, int iznos)
        {
            int redni = 1;
            foreach (var student in studenti)
            {
                var novaStipendija = new StipendijeGodine()
                {
                    Godina = DateTime.Now.Year,
                    StipendijaId = stipendija.Id,
                    Iznos = iznos,
                    Aktivna = true
                };
                db.StipendijeGodine.Add(novaStipendija);
                await db.SaveChangesAsync();
                txtInfo.Invoke((Action)(() =>
                {
                    txtInfo.Text += $"{redni}. {stipendija.Naziv} u iznosu od {iznos}KM dodata {student} {Environment.NewLine}";
                }));
                redni++;
                await Task.Delay(300);
            }
        }

        private void btnPotvrda_Click(object sender, EventArgs e)
        {
            var godina=int.Parse(cmbGodine.Text);
            var stipendija=cmbStipendije.SelectedItem as Stipendije;    

            var stipendije=db.StipendijeGodine.Where(x=>x.Godina==godina && x.StipendijaId==stipendija.Id).ToList();
            var studenti = db.StudentiStipendije
               .Where(x => x.StipendijaId == stipendija.Id)
               .Include(x => x.Student) 
               .ToList();

            if (stipendije.Count > 0)
            {
                new frmIzvjestaji(stipendije,godina,stipendija,studenti).ShowDialog();
            }
            else
            {
                MessageBox.Show("Nema razmjenea za izabranu godinu i stipendiju");
            }

        }
    }
}

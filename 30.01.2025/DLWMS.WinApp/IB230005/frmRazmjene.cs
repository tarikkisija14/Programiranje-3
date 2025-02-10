using DLWMS.Data;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Helpers;
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
    public partial class frmRazmjene : Form
    {
        private Student student;
        DLWMSContext db = new DLWMSContext();
        List<Razmjene> ListaRazmjena = new List<Razmjene>();


        public frmRazmjene(Student student)
        {
            InitializeComponent();
            this.student = student;
            dgvRazmjene.AutoGenerateColumns = false;
        }

        private void frmRazmjene_Load(object sender, EventArgs e)
        {
            this.Text = $"Razmjene studenta :({student.BrojIndeksa}) {student.Ime} {student.Prezime}";
            UcitajPodatke();
            cmbDrzava.DataSource = db.Drzave.ToList();
            cmbUniver.DataSource = db.Univerziteti.ToList();

        }

        private void UcitajPodatke()
        {
            ListaRazmjena = db.Razmjene
             .Where(x => x.StudentId == student.Id)
             .Include(x => x.Univerzitet)
             .ToList();

            var tabela = new DataTable();
            tabela.Columns.Add("Univerzitet");
            tabela.Columns.Add("Pocetak");
            tabela.Columns.Add("Kraj");
            tabela.Columns.Add("ECTS");
            tabela.Columns.Add("Okoncana");

            foreach (var razmjena in ListaRazmjena)
            {
                var red = tabela.NewRow();
                red["Univerzitet"] = razmjena.Univerzitet.Naziv;
                red["Pocetak"] = razmjena.Pocetak.ToString();
                red["Kraj"] = razmjena.Kraj.ToString();
                red["ECTS"] = razmjena.ECTS;
                red["Okoncana"] = razmjena.Okoncana;
                tabela.Rows.Add(red);
            }
            dgvRazmjene.DataSource = null;
            dgvRazmjene.DataSource = tabela;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var uni = cmbUni.SelectedItem as Univerziteti ?? new Univerziteti();
            var ects = int.Parse(txtECTS.Text);
            var pocetak = dtpPocetak.Value;
            var kraj = dtpKraj.Value;

            var nova = new Razmjene
            {
                StudentId = student.Id,
                UniverzitetId = uni.Id,
                Pocetak = pocetak.ToString(),
                Kraj = kraj.ToString(),
                ECTS = ects,
                Okoncana = true

            };
            db.Razmjene.Add(nova);
            db.SaveChanges();
            UcitajPodatke();

        }




        private void cmbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            var drzava = cmbDrzava.SelectedItem as Drzava ?? new Drzava();
            var uni = db.Univerziteti.Where(x => x.DrzavaId == drzava.Id).ToList();
            if (uni.Any())
            {
                cmbUni.DataSource = uni;
                cmbUni.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Nema univerziteta za odabrane drzave", "No Universities", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbUni.SelectedIndex = -1;
            }

        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            var uni = cmbUniver.SelectedItem as Univerziteti ?? new Univerziteti();
            var brojac = int.Parse(txtBrojac.Text);
            var ects = int.Parse(txtBrojKredita.Text);

            await DodajTred(uni, brojac, ects);
        }

        private async Task DodajTred(Univerziteti uni, int brojac, int ects)
        {
            for (int i = 0; i < brojac; i++)
            {
                var nova = new Razmjene
                {
                    StudentId = student.Id,
                    UniverzitetId = uni.Id,
                    Pocetak = new DateTime(2023, 09, 19).ToString(),
                    Kraj = DateTime.Now.ToString(),
                    ECTS = ects,
                    Okoncana = true
                };
                db.Razmjene.Add(nova);
                await db.SaveChangesAsync();
                UcitajPodatke();

                txtInfo.Invoke((Action)(() =>
                {
                    txtInfo.Text += $"{i + 1}.razmjena za {student.BrojIndeksa} {student.Ime} {student.Prezime} na {uni.Naziv} {nova.Pocetak}-{nova.Kraj}{Environment.NewLine}";
                }));
                await Task.Delay(1000);

            }
        }

        private void dgvRazmjene_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var odabranired = e.RowIndex;
                if (odabranired >= 0)
                {
                    var odabranarazmjena = ListaRazmjena[odabranired];

                    var rezultat = MessageBox.Show("Da li ste sigurni da zelite obrisati razmjenu?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (rezultat == DialogResult.Yes)
                    {
                        db.Razmjene.Remove(odabranarazmjena);
                        db.SaveChanges();
                        UcitajPodatke();

                    }
                    else if (rezultat == DialogResult.No)
                    {
                        UcitajPodatke();
                    }
                }
            }
        }

        private void btnPotvrda_Click(object sender, EventArgs e)
        {
            var studentId = student.Id;
            var razmjene = ListaRazmjena.Where(x => x.StudentId == studentId).ToList();

            if (razmjene.Count > 0)
            {
                
                new frmIzvjestaji(razmjene, student).ShowDialog();
            }
            else
            {
                MessageBox.Show("Nema razmjena za ovog studenta.");
            }

        }
    }
}

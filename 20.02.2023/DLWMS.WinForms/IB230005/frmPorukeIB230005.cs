using DLWMS.Data;
using DLWMS.Data.IB230005;
using DLWMS.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IB230005
{
    public partial class frmPorukeIB230005 : Form
    {
        private StudentiPredmetiIB230005 studentiPredmetiIB230005;
        DLWMSDbContext db = new DLWMSDbContext();
        List<StudentiPorukeIB230005> ListaPoruka = new List<StudentiPorukeIB230005>();


        public frmPorukeIB230005(StudentiPredmetiIB230005 studentiPredmetiIB230005)
        {
            InitializeComponent();

            this.studentiPredmetiIB230005 = studentiPredmetiIB230005;
            lblImePoruke.Text = $"Poruke studenta {studentiPredmetiIB230005.Student.Ime}";
            dgvPoruke.AutoGenerateColumns = false;
        }

        private void frmPorukeIB230005_Load(object sender, EventArgs e)
        {
            
            cmbPredmeti.DataSource = db.Predmeti.ToList();
            
        }

        private void UcitajPodatke()
        {

            ListaPoruka = db.StudentiPorukeIB230005.Where(x => x.StudentId == studentiPredmetiIB230005.Student.Id).ToList();
            this.Text = ListaPoruka.Count().ToString();

            dgvPoruke.DataSource = null;
            dgvPoruke.DataSource = ListaPoruka;

        }

        private void dgvPoruke_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)  
            {
              
                var poruka = MessageBox.Show("Jeste li sigurni da zelite obrissatli poruku ???", "Warning", MessageBoxButtons.YesNo);

                if (poruka == DialogResult.Yes)
                {
                   
                    var brisanje = dgvPoruke.Rows[e.RowIndex].DataBoundItem as StudentiPorukeIB230005;
                    //MessageBox.Show($"Found message with ID: {brisanje.Id}");
                    db.StudentiPorukeIB230005.Remove(brisanje);
                    db.SaveChanges();
                    UcitajPodatke();
                }

               
            }
        }


        private void btnNovaPoruka_Click(object sender, EventArgs e)
        {
            new frmNovaPorukaIB230005(studentiPredmetiIB230005).ShowDialog();
            UcitajPodatke();
        }

        private void txtBroj_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            var brojac=int.Parse(txtBroj.Text);
            var predmet = cmbPredmeti.SelectedItem as PredmetiIB230005;
            var validna = dtpValidna.Value;

            await DodajAs(brojac,predmet, validna);
            UcitajPodatke();
        }

        private async Task DodajAs(int brojac, PredmetiIB230005 predmet, DateTime validna)
        {
            for (int i = 0; i <brojac;  i++)
            {
                if (ValidnoGen())
                {
                    var nova = new StudentiPorukeIB230005
                    {
                        Predmet = predmet,
                        StudentId = studentiPredmetiIB230005.StudentId,
                        Validnost = validna,
                        Sadrzaj = $"{i}. Generisana poruka",
                        Slika = ListaPoruka[0].Slika,
                    };
                    db.StudentiPorukeIB230005.Add(nova);
                    await db.SaveChangesAsync();
                    UcitajPodatke();
                    await Task.Delay(300);
                    txtInfo.Invoke((Action)(() =>
                    {
                        txtInfo.Text += $"{DateTime.Now}-> generisana poruka za {studentiPredmetiIB230005.Student.Ime} {studentiPredmetiIB230005.Student.Prezime} na predmetu {predmet}{Environment.NewLine}";

                    }));
                }
               
                

              

            }
        }

        private bool ValidnoGen()
        {
            return Helpers.Validator.ValidirajKontrolu(cmbPredmeti, errorProvider1, Kljucevi.PodaciNisuValidni) &&
               Helpers.Validator.ValidirajKontrolu(txtBroj, errorProvider1, Kljucevi.PodaciNisuValidni) &&
               Helpers.Validator.ValidirajKontrolu(dtpValidna, errorProvider1, Kljucevi.PodaciNisuValidni);

        }
    }
}

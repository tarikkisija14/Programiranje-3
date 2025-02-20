using DLWMS.Data;
using DLWMS.Data.IB230005;
using DLWMS.Infrastructure;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
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
using System.Diagnostics;


namespace DLWMS.WinApp.IB230005
{
    public partial class frmPretraga : Form
    {
        DLWMSContext db = new DLWMSContext();
        List<StudentiStipendije> ListaStudenata = new List<StudentiStipendije>();
        public frmPretraga()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void frmPretraga_Load(object sender, EventArgs e)
        {
            cmbGodina.SelectedIndex = 0;
            this.Text = $"Broj prikazanih studenata: {ListaStudenata.Count}";
            UcitajPodatke();

        }

        private void UcitajPodatke()
        {

            var godina = cmbGodina.Text;
            var stipendija = cmbStipendija.SelectedItem as StipendijeGodine;

            ListaStudenata = db.StudentiStipendije.Include(x => x.Stipendija).Include(x => x.Student)
            .Include(x => x.Stipendija)
            .Where(x => x.StipendijaId == stipendija.Id).ToList();

            if (ListaStudenata.Count == 0)
            {

                MessageBox.Show("Nema rezultata");
            }

            var tabela = new DataTable();
            tabela.Columns.Add("IIP");
            tabela.Columns.Add("Godina");
            tabela.Columns.Add("Stipendija");
            tabela.Columns.Add("Iznos");
            tabela.Columns.Add("Ukupno");
            foreach (var student in ListaStudenata)
            {
                var red = tabela.NewRow();
                red["IIP"] = $"({student.Student.BrojIndeksa}) {student.Student.Ime} {student.Student.Prezime}";
                red["Godina"] = godina.ToString();
                red["Stipendija"] = student.Stipendija.Naziv;
                var stipendijagodina = db.StipendijeGodine.FirstOrDefault(x => x.StipendijaId == stipendija.Id && x.Godina.ToString() == godina);
                red["Iznos"] = stipendijagodina.Iznos;
                var godine = int.Parse(godina.ToString());
                if (stipendijagodina.Godina == godine)
                {
                    red["Ukupno"] = stipendijagodina.Iznos * 12;
                }
                else if (stipendijagodina.Godina == godine)
                {
                    red["Ukupno"] = stipendijagodina.Iznos * 2;
                }
                tabela.Rows.Add(red);
            }
            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = tabela;





        }

        private void cmbGodina_SelectedIndexChanged(object sender, EventArgs e)
        {
            var godina = cmbGodina.Text;
            var stipendije = db.StipendijeGodine.Include(x => x.Stipendija)
                                         .Where(x => x.Godina.ToString() == godina)
                                         .ToList();


            if (stipendije.Count == 0)
            {
                MessageBox.Show("Nema stipendija za izabranu godinu");
            }
            cmbStipendija.DataSource = stipendije;
            UcitajPodatke();
        }

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var odabranired = e.RowIndex;

                if (odabranired >= 0)
                {
                    var odabranastipendija = ListaStudenata[odabranired];
                    var rezultat = MessageBox.Show("Da li ste sigurni da zelite obrisati stipendiju?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (rezultat == DialogResult.Yes)
                    {
                        db.StudentiStipendije.Remove(odabranastipendija);
                        db.SaveChanges();
                        UcitajPodatke();
                    }
                    else if (rezultat == DialogResult.No)
                    {
                        UcitajPodatke();
                    }


                }

            }
            else
            {
                new frmStudentiAddEdit(ListaStudenata[e.RowIndex]).ShowDialog();
                UcitajPodatke();
            }
        }

        private void btnDodajStipendiju_Click(object sender, EventArgs e)
        {
            new frmStudentiAddEdit().ShowDialog();
            UcitajPodatke();
        }

        private void cmbStipendija_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void btnStipendijePoGodinama_Click(object sender, EventArgs e)
        {
            new frmStipendije().ShowDialog();
        }
    }
}

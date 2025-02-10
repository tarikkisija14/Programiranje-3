using DLWMS.Data;
using DLWMS.Infrastructure;
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
    public partial class frmPretraga : Form
    {
        DLWMSContext db = new DLWMSContext();
        List<Student> ListaStudenata = new List<Student>();
        public frmPretraga()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void frmPretraga_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
            cmbDrzava.DataSource = db.Drzave.ToList();
            cmbDrzava.SelectedIndex = 0;
            cmbSpol.DataSource = db.Spol.ToList();
            cmbSpol.SelectedIndex = 0;
        }

        private void UcitajPodatke(List<Student> listaStudenata = null)
        {
            
            if (listaStudenata == null)
            {
                var drzava = cmbDrzava.SelectedItem as Drzava ?? new Drzava();
                var spol = cmbSpol.SelectedItem as Spol ?? new Spol();

                ListaStudenata = db.Studenti
                    .Include(x => x.Grad)
                    .ThenInclude(g => g.Drzava)
                    .Include(x => x.Spol)
                    .Where(x => x.Grad.Drzava == drzava && x.Spol == spol)
                    .ToList();  

            }
            else
            {
                ListaStudenata = listaStudenata; 
            }

            if (ListaStudenata == null)
            {
                MessageBox.Show("Nema studenata za ucitavanje");
            }


            var tabela = new DataTable();
            tabela.Columns.Add("IndeksImePrezime");
            tabela.Columns.Add("Drzava");
            tabela.Columns.Add("Grad");
            tabela.Columns.Add("Spol");
            tabela.Columns.Add("Aktivan");

            foreach (var student in ListaStudenata)
            {
                var red = tabela.NewRow();
                red["IndeksImePrezime"] = $"({student.BrojIndeksa}) {student.Ime} {student.Prezime}";
                red["Drzava"] = student.Grad.Drzava.Naziv;
                red["Grad"] = student.Grad.Naziv;
                red["Spol"] = student.Spol.Naziv;
                red["Aktivan"] = student.Aktivan;
                tabela.Rows.Add(red);
            }

            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = tabela;

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            var filter = txtFilter.Text.ToLower();

            if (string.IsNullOrEmpty(filter))
            {
                UcitajPodatke(); 
            }
            else
            {
                var lista = db.Studenti
                    .Include(x => x.Grad)
                    .ThenInclude(g => g.Drzava)
                    .Include(x => x.Spol)
                    .Where(x => x.Ime.ToLower().Contains(filter) || x.Prezime.ToLower().Contains(filter))
                    .ToList();

                if (lista != null && lista.Count > 0)
                {
                    UcitajPodatke(lista);
                }
                else
                {
                    MessageBox.Show("Nema studenata koji odgovaraju pretrazi.");
                }
            }

        }

        private void cmbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void cmbSpol_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= ListaStudenata.Count) return;
            if (e.ColumnIndex == 5)
            {
                new frmRazmjene(ListaStudenata[e.RowIndex]).ShowDialog();
            }
            else
            {
                new frmStudentiEdit(ListaStudenata[e.RowIndex]).ShowDialog();
                UcitajPodatke();
            }
        }
    }
}

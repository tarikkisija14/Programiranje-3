using FIT.Data;
using FIT.Data.IB230005;
using FIT.Infrastructure;
using FIT.WinForms.Izvjestaji;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.IB230005
{
    public partial class frmUvjerenjaIB230005 : Form
    {
        private Student student;
        DLWMSDbContext db = new DLWMSDbContext();
        List<StudentiUvjerenjaIB230005> Lista = new List<StudentiUvjerenjaIB230005>();


        public frmUvjerenjaIB230005(Student student = null)
        {
            InitializeComponent();
            this.student = student;
            dgvUvjerenja.AutoGenerateColumns = false;
            btnGenerisi.Enabled = false;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var brojac = 0;
            if (ValidnoGen())
            {
                brojac = int.Parse(txtBrojZahtjeva.Text);
                var vrsta = cmbVrsta.Text;
                var svrha=txtSvrha.Text;
                await DodajSleep(brojac, vrsta, svrha);
            }
        }

        private async Task DodajSleep(int brojac, string vrsta, string svrha)
        {
            for (int i = 0; i < brojac; i++)
            {

                var novo = new StudentiUvjerenjaIB230005
                {
                    StudentId = student.Id,
                    Vrijeme = DateTime.Now.ToString(),
                    Vrsta = vrsta,
                    Svrha = svrha,
                    Uplatnica = Lista[0].Uplatnica,
                    Printano = true
                };
                await db.StudentiUvjerenjaIB230005.AddAsync(novo);
                await db.SaveChangesAsync();

                txtInfo.Invoke((Action)(() =>
                {

                    txtInfo.Text += $"{DateTime.Now.ToString("HH:mm:ss")}->{vrsta}{student.ToString()} u svrhu {svrha}\r\n";
                }));
                await Task.Delay(1000);
                UcitajPodatke();

            }
        }

        private bool ValidnoGen()
        {
            return Helpers.Validator.ProvjeriUnos(txtSvrha, err, Kljucevi.ReqiredValue) &&
                    Helpers.Validator.ProvjeriUnos(cmbVrsta, err, Kljucevi.ReqiredValue) &&
                    Helpers.Validator.ProvjeriUnos(txtBrojZahtjeva, err, Kljucevi.ReqiredValue);
        }

        private void frmUvjerenjaIB230005_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            Lista = db.StudentiUvjerenjaIB230005.Where(x => x.StudentId == student.Id).ToList();
            dgvUvjerenja.DataSource = null;
            dgvUvjerenja.DataSource = Lista;
            this.Text = $"Broj uvjerenja-> {Lista.Count()}";
            btnGenerisi.Enabled = Lista.Count > 0;


        }

        private void btnZahtjev_Click(object sender, EventArgs e)
        {
            new frmNoviZahtjevIB230005(student).ShowDialog();
            UcitajPodatke();
        }

        private void dgvUvjerenja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var uvjernje = Lista[e.RowIndex];
                DialogResult odabran = MessageBox.Show("Da li zelite izbrisati ovo uvjernje?", "Warnning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (odabran == DialogResult.Yes)
                {
                    db.StudentiUvjerenjaIB230005.Remove(uvjernje);
                    db.SaveChanges();
                    UcitajPodatke();
                }
                else if (odabran == DialogResult.No)
                {
                    Close();
                }

            }
            else if (e.ColumnIndex == 6)
            {
                var kliknuto=Lista[e.RowIndex];
                kliknuto.Printano = true;
                db.SaveChanges();
                UcitajPodatke();
                var frm=new frmIzvjestaji(student,kliknuto);
                frm.ShowDialog();
            }
        }
    }
}

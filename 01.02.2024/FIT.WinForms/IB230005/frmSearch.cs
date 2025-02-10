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
    public partial class frmSearch : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<DrzaveIB230005> ListaDrzava = new List<DrzaveIB230005>();
        public frmSearch()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke(List<DrzaveIB230005> ListaDrzava=null)
        {
            if (ListaDrzava == null)
            {
                ListaDrzava = db.DrzaveIB230005.ToList();
                dataGridView1.DataSource = null;
            }
           

            dataGridView1.DataSource = ListaDrzava;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var filter=textBox1.Text.ToLower();

            ListaDrzava=db.DrzaveIB230005.Where(x=>x.Naziv.ToLower().Contains(filter)).ToList();
            UcitajPodatke(ListaDrzava);
        }
    }
}

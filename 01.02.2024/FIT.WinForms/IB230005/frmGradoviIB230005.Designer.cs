namespace FIT.WinForms.IB230005
{
    partial class frmGradoviIB230005
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbZastava = new PictureBox();
            lblDrzava = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNaziv = new TextBox();
            txtBrojGradova = new TextBox();
            cbAktivni = new CheckBox();
            btnDodaj = new Button();
            btnGenerisi = new Button();
            txtInfo = new TextBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            dgvGradovi = new DataGridView();
            Naziv = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            PromjeniStatus = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)pbZastava).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGradovi).BeginInit();
            SuspendLayout();
            // 
            // pbZastava
            // 
            pbZastava.Location = new Point(12, 18);
            pbZastava.Name = "pbZastava";
            pbZastava.Size = new Size(132, 73);
            pbZastava.SizeMode = PictureBoxSizeMode.StretchImage;
            pbZastava.TabIndex = 0;
            pbZastava.TabStop = false;
            // 
            // lblDrzava
            // 
            lblDrzava.AutoSize = true;
            lblDrzava.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblDrzava.Location = new Point(150, 57);
            lblDrzava.Name = "lblDrzava";
            lblDrzava.Size = new Size(95, 25);
            lblDrzava.TabIndex = 1;
            lblDrzava.Text = "lblDrzava";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 110);
            label2.Name = "label2";
            label2.Size = new Size(146, 15);
            label2.TabIndex = 2;
            label2.Text = "Unesite naziv novog grada";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 32);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 3;
            label3.Text = "Broj gradova";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(164, 107);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(203, 23);
            txtNaziv.TabIndex = 4;
            // 
            // txtBrojGradova
            // 
            txtBrojGradova.Location = new Point(86, 29);
            txtBrojGradova.Name = "txtBrojGradova";
            txtBrojGradova.Size = new Size(60, 23);
            txtBrojGradova.TabIndex = 5;
            // 
            // cbAktivni
            // 
            cbAktivni.AutoSize = true;
            cbAktivni.Location = new Point(152, 32);
            cbAktivni.Name = "cbAktivni";
            cbAktivni.Size = new Size(63, 19);
            cbAktivni.TabIndex = 6;
            cbAktivni.Text = "Aktivni";
            cbAktivni.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(373, 107);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(75, 23);
            btnDodaj.TabIndex = 7;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(221, 28);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(75, 23);
            btnGenerisi.TabIndex = 8;
            btnGenerisi.Text = "Generisi";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(4, 78);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(426, 86);
            txtInfo.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 59);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 10;
            label4.Text = "Info";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtBrojGradova);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Controls.Add(cbAktivni);
            groupBox1.Controls.Add(btnGenerisi);
            groupBox1.Location = new Point(12, 292);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(436, 170);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator";
            // 
            // dgvGradovi
            // 
            dgvGradovi.AllowUserToAddRows = false;
            dgvGradovi.AllowUserToDeleteRows = false;
            dgvGradovi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGradovi.Columns.AddRange(new DataGridViewColumn[] { Naziv, Aktivan, PromjeniStatus });
            dgvGradovi.Location = new Point(12, 136);
            dgvGradovi.Name = "dgvGradovi";
            dgvGradovi.ReadOnly = true;
            dgvGradovi.RowTemplate.Height = 25;
            dgvGradovi.Size = new Size(436, 150);
            dgvGradovi.TabIndex = 12;
            dgvGradovi.CellContentClick += dgvGradovi_CellContentClick;
            // 
            // Naziv
            // 
            Naziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Naziv.DataPropertyName = "Naziv";
            Naziv.HeaderText = "Naziv grada";
            Naziv.Name = "Naziv";
            Naziv.ReadOnly = true;
            // 
            // Aktivan
            // 
            Aktivan.DataPropertyName = "Status";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            // 
            // PromjeniStatus
            // 
            PromjeniStatus.HeaderText = "";
            PromjeniStatus.Name = "PromjeniStatus";
            PromjeniStatus.ReadOnly = true;
            PromjeniStatus.Text = "Promjeni status";
            PromjeniStatus.UseColumnTextForButtonValue = true;
            // 
            // frmGradoviIB230005
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 475);
            Controls.Add(dgvGradovi);
            Controls.Add(groupBox1);
            Controls.Add(btnDodaj);
            Controls.Add(txtNaziv);
            Controls.Add(label2);
            Controls.Add(lblDrzava);
            Controls.Add(pbZastava);
            Name = "frmGradoviIB230005";
            Text = "frmGradoviIB230005";
            Load += frmGradoviIB230005_Load;
            ((System.ComponentModel.ISupportInitialize)pbZastava).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGradovi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbZastava;
        private Label lblDrzava;
        private Label label2;
        private Label label3;
        private TextBox txtNaziv;
        private TextBox txtBrojGradova;
        private CheckBox cbAktivni;
        private Button btnDodaj;
        private Button btnGenerisi;
        private TextBox txtInfo;
        private Label label4;
        private GroupBox groupBox1;
        private DataGridView dgvGradovi;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn PromjeniStatus;
    }
}
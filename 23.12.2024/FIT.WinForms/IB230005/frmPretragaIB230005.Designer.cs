namespace FIT.WinForms.IB230005
{
    partial class frmPretragaIB230005
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbSemestar = new ComboBox();
            cmbUloga = new ComboBox();
            dtpOd = new DateTimePicker();
            dtpDo = new DateTimePicker();
            dgvStudenti = new DataGridView();
            Indeks = new DataGridViewTextBoxColumn();
            ImePrezime = new DataGridViewTextBoxColumn();
            DatumRodjenja = new DataGridViewTextBoxColumn();
            Prosjek = new DataGridViewTextBoxColumn();
            Uloga = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            Poruke = new DataGridViewButtonColumn();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 25);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Semestar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(216, 22);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "uloga";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(387, 22);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 2;
            label3.Text = "rođen u periodu od";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(708, 22);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 3;
            label4.Text = "do";
            // 
            // cmbSemestar
            // 
            cmbSemestar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSemestar.FormattingEnabled = true;
            cmbSemestar.Location = new Point(89, 19);
            cmbSemestar.Name = "cmbSemestar";
            cmbSemestar.Size = new Size(121, 23);
            cmbSemestar.TabIndex = 4;
            cmbSemestar.SelectedIndexChanged += cmbSemestar_SelectedIndexChanged;
            // 
            // cmbUloga
            // 
            cmbUloga.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUloga.FormattingEnabled = true;
            cmbUloga.Location = new Point(260, 19);
            cmbUloga.Name = "cmbUloga";
            cmbUloga.Size = new Size(121, 23);
            cmbUloga.TabIndex = 5;
            cmbUloga.SelectedIndexChanged += cmbUloga_SelectedIndexChanged;
            // 
            // dtpOd
            // 
            dtpOd.Location = new Point(502, 16);
            dtpOd.Name = "dtpOd";
            dtpOd.Size = new Size(200, 23);
            dtpOd.TabIndex = 6;
            dtpOd.ValueChanged += dtpOd_ValueChanged;
            // 
            // dtpDo
            // 
            dtpDo.Location = new Point(739, 16);
            dtpDo.Name = "dtpDo";
            dtpDo.Size = new Size(200, 23);
            dtpDo.TabIndex = 7;
            dtpDo.ValueChanged += dtpDo_ValueChanged;
            // 
            // dgvStudenti
            // 
            dgvStudenti.AllowUserToAddRows = false;
            dgvStudenti.AllowUserToDeleteRows = false;
            dgvStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudenti.Columns.AddRange(new DataGridViewColumn[] { Indeks, ImePrezime, DatumRodjenja, Prosjek, Uloga, Aktivan, Poruke });
            dgvStudenti.Location = new Point(28, 58);
            dgvStudenti.Name = "dgvStudenti";
            dgvStudenti.ReadOnly = true;
            dgvStudenti.RowTemplate.Height = 25;
            dgvStudenti.Size = new Size(911, 198);
            dgvStudenti.TabIndex = 8;
            dgvStudenti.CellContentClick += dgvStudenti_CellContentClick;
            // 
            // Indeks
            // 
            Indeks.DataPropertyName = "Indeks";
            Indeks.HeaderText = "Indeks";
            Indeks.Name = "Indeks";
            Indeks.ReadOnly = true;
            // 
            // ImePrezime
            // 
            ImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ImePrezime.DataPropertyName = "ImePrezime";
            ImePrezime.HeaderText = "Ime i prezime";
            ImePrezime.Name = "ImePrezime";
            ImePrezime.ReadOnly = true;
            // 
            // DatumRodjenja
            // 
            DatumRodjenja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumRodjenja.DataPropertyName = "DatumRodjenja";
            DatumRodjenja.HeaderText = "Datum rodjenja";
            DatumRodjenja.Name = "DatumRodjenja";
            DatumRodjenja.ReadOnly = true;
            // 
            // Prosjek
            // 
            Prosjek.DataPropertyName = "Prosjek";
            Prosjek.HeaderText = "Prosjecna ocjena";
            Prosjek.Name = "Prosjek";
            Prosjek.ReadOnly = true;
            // 
            // Uloga
            // 
            Uloga.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Uloga.DataPropertyName = "Uloga";
            Uloga.HeaderText = "Uloga";
            Uloga.Name = "Uloga";
            Uloga.ReadOnly = true;
            // 
            // Aktivan
            // 
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            // 
            // Poruke
            // 
            Poruke.HeaderText = "";
            Poruke.Name = "Poruke";
            Poruke.ReadOnly = true;
            Poruke.Text = "Poruke";
            Poruke.UseColumnTextForButtonValue = true;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmPretragaIB230005
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 272);
            Controls.Add(dgvStudenti);
            Controls.Add(dtpDo);
            Controls.Add(dtpOd);
            Controls.Add(cmbUloga);
            Controls.Add(cmbSemestar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPretragaIB230005";
            Text = "Pretraga studenata";
            Load += frmPretragaIB230005_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbSemestar;
        private ComboBox cmbUloga;
        private DateTimePicker dtpOd;
        private DateTimePicker dtpDo;
        private DataGridView dgvStudenti;
        private DataGridViewTextBoxColumn Indeks;
        private DataGridViewTextBoxColumn ImePrezime;
        private DataGridViewTextBoxColumn DatumRodjenja;
        private DataGridViewTextBoxColumn Prosjek;
        private DataGridViewTextBoxColumn Uloga;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn Poruke;
        private ErrorProvider err;
    }
}
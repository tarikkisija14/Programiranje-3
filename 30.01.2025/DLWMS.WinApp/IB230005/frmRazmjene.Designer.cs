namespace DLWMS.WinApp.IB230005
{
    partial class frmRazmjene
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbDrzava = new ComboBox();
            cmbUni = new ComboBox();
            txtECTS = new TextBox();
            dtpPocetak = new DateTimePicker();
            dtpKraj = new DateTimePicker();
            btnSacuvaj = new Button();
            dgvRazmjene = new DataGridView();
            Univerzitet = new DataGridViewTextBoxColumn();
            Pocetak = new DataGridViewTextBoxColumn();
            Kraj = new DataGridViewTextBoxColumn();
            ECTS = new DataGridViewTextBoxColumn();
            Okoncana = new DataGridViewCheckBoxColumn();
            Obrisi = new DataGridViewButtonColumn();
            groupBox1 = new GroupBox();
            txtInfo = new TextBox();
            Info = new Label();
            btnGenerisi = new Button();
            txtBrojKredita = new TextBox();
            txtBrojac = new TextBox();
            cmbUniver = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            btnPotvrda = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRazmjene).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Drzava";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 46);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Univerzitet";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(353, 46);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "Broj kredita";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(468, 44);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 3;
            label4.Text = "Pocetak razmjene";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(675, 44);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 4;
            label5.Text = "Kraj razmjene";
            // 
            // cmbDrzava
            // 
            cmbDrzava.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDrzava.FormattingEnabled = true;
            cmbDrzava.Location = new Point(12, 62);
            cmbDrzava.Name = "cmbDrzava";
            cmbDrzava.Size = new Size(176, 23);
            cmbDrzava.TabIndex = 5;
            cmbDrzava.SelectedIndexChanged += cmbDrzava_SelectedIndexChanged;
            // 
            // cmbUni
            // 
            cmbUni.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUni.FormattingEnabled = true;
            cmbUni.Location = new Point(194, 62);
            cmbUni.Name = "cmbUni";
            cmbUni.Size = new Size(153, 23);
            cmbUni.TabIndex = 6;
            // 
            // txtECTS
            // 
            txtECTS.BorderStyle = BorderStyle.FixedSingle;
            txtECTS.Location = new Point(353, 62);
            txtECTS.Name = "txtECTS";
            txtECTS.Size = new Size(100, 23);
            txtECTS.TabIndex = 7;
            // 
            // dtpPocetak
            // 
            dtpPocetak.Location = new Point(468, 62);
            dtpPocetak.Name = "dtpPocetak";
            dtpPocetak.Size = new Size(200, 23);
            dtpPocetak.TabIndex = 8;
            // 
            // dtpKraj
            // 
            dtpKraj.Location = new Point(675, 62);
            dtpKraj.Name = "dtpKraj";
            dtpKraj.Size = new Size(200, 23);
            dtpKraj.TabIndex = 9;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(881, 60);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(77, 25);
            btnSacuvaj.TabIndex = 10;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // dgvRazmjene
            // 
            dgvRazmjene.AllowUserToAddRows = false;
            dgvRazmjene.AllowUserToDeleteRows = false;
            dgvRazmjene.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRazmjene.Columns.AddRange(new DataGridViewColumn[] { Univerzitet, Pocetak, Kraj, ECTS, Okoncana, Obrisi });
            dgvRazmjene.Location = new Point(12, 102);
            dgvRazmjene.Name = "dgvRazmjene";
            dgvRazmjene.ReadOnly = true;
            dgvRazmjene.Size = new Size(946, 215);
            dgvRazmjene.TabIndex = 11;
            dgvRazmjene.CellContentClick += dgvRazmjene_CellContentClick;
            // 
            // Univerzitet
            // 
            Univerzitet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Univerzitet.DataPropertyName = "Univerzitet";
            Univerzitet.HeaderText = "Univerzitet";
            Univerzitet.Name = "Univerzitet";
            Univerzitet.ReadOnly = true;
            // 
            // Pocetak
            // 
            Pocetak.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Pocetak.DataPropertyName = "Pocetak";
            Pocetak.HeaderText = "Pocetak";
            Pocetak.Name = "Pocetak";
            Pocetak.ReadOnly = true;
            // 
            // Kraj
            // 
            Kraj.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Kraj.DataPropertyName = "Kraj";
            Kraj.HeaderText = "Kraj";
            Kraj.Name = "Kraj";
            Kraj.ReadOnly = true;
            // 
            // ECTS
            // 
            ECTS.DataPropertyName = "ECTS";
            ECTS.HeaderText = "ECTS";
            ECTS.Name = "ECTS";
            ECTS.ReadOnly = true;
            // 
            // Okoncana
            // 
            Okoncana.DataPropertyName = "Okoncana";
            Okoncana.HeaderText = "Okoncana";
            Okoncana.Name = "Okoncana";
            Okoncana.ReadOnly = true;
            // 
            // Obrisi
            // 
            Obrisi.HeaderText = "";
            Obrisi.Name = "Obrisi";
            Obrisi.ReadOnly = true;
            Obrisi.Text = "Obrisi";
            Obrisi.UseColumnTextForButtonValue = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Controls.Add(Info);
            groupBox1.Controls.Add(btnGenerisi);
            groupBox1.Controls.Add(txtBrojKredita);
            groupBox1.Controls.Add(txtBrojac);
            groupBox1.Controls.Add(cmbUniver);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(12, 343);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(946, 201);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator razmjena";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(257, 44);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(683, 129);
            txtInfo.TabIndex = 8;
            // 
            // Info
            // 
            Info.AutoSize = true;
            Info.Location = new Point(253, 22);
            Info.Name = "Info";
            Info.Size = new Size(28, 15);
            Info.TabIndex = 7;
            Info.Text = "Info";
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(6, 141);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(206, 32);
            btnGenerisi.TabIndex = 6;
            btnGenerisi.Text = "Generisi razmjene >>>>>";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // txtBrojKredita
            // 
            txtBrojKredita.Location = new Point(112, 100);
            txtBrojKredita.Name = "txtBrojKredita";
            txtBrojKredita.Size = new Size(100, 23);
            txtBrojKredita.TabIndex = 5;
            // 
            // txtBrojac
            // 
            txtBrojac.Location = new Point(6, 100);
            txtBrojac.Name = "txtBrojac";
            txtBrojac.Size = new Size(100, 23);
            txtBrojac.TabIndex = 4;
            // 
            // cmbUniver
            // 
            cmbUniver.FormattingEnabled = true;
            cmbUniver.Location = new Point(6, 46);
            cmbUniver.Name = "cmbUniver";
            cmbUniver.Size = new Size(206, 23);
            cmbUniver.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(112, 82);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 2;
            label8.Text = "Broj kredita";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 82);
            label7.Name = "label7";
            label7.Size = new Size(79, 15);
            label7.TabIndex = 1;
            label7.Text = "Broj razmjena";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 28);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 0;
            label6.Text = "Univerzitet";
            // 
            // btnPotvrda
            // 
            btnPotvrda.Location = new Point(883, 323);
            btnPotvrda.Name = "btnPotvrda";
            btnPotvrda.Size = new Size(75, 23);
            btnPotvrda.TabIndex = 13;
            btnPotvrda.Text = "Potvrda";
            btnPotvrda.UseVisualStyleBackColor = true;
            btnPotvrda.Click += btnPotvrda_Click;
            // 
            // frmRazmjene
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 543);
            Controls.Add(btnPotvrda);
            Controls.Add(groupBox1);
            Controls.Add(dgvRazmjene);
            Controls.Add(btnSacuvaj);
            Controls.Add(dtpKraj);
            Controls.Add(dtpPocetak);
            Controls.Add(txtECTS);
            Controls.Add(cmbUni);
            Controls.Add(cmbDrzava);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmRazmjene";
            Text = "frmRazmjene";
            Load += frmRazmjene_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRazmjene).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbDrzava;
        private ComboBox cmbUni;
        private TextBox txtECTS;
        private DateTimePicker dtpPocetak;
        private DateTimePicker dtpKraj;
        private Button btnSacuvaj;
        private DataGridView dgvRazmjene;
        private DataGridViewTextBoxColumn Univerzitet;
        private DataGridViewTextBoxColumn Pocetak;
        private DataGridViewTextBoxColumn Kraj;
        private DataGridViewTextBoxColumn ECTS;
        private DataGridViewCheckBoxColumn Okoncana;
        private DataGridViewButtonColumn Obrisi;
        private GroupBox groupBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtInfo;
        private Label Info;
        private Button btnGenerisi;
        private TextBox txtBrojKredita;
        private TextBox txtBrojac;
        private ComboBox cmbUniver;
        private Button btnPotvrda;
    }
}
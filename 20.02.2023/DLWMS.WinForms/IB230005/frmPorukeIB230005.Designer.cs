namespace DLWMS.WinForms.IB230005
{
    partial class frmPorukeIB230005
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
            lblImePoruke = new Label();
            dgvPoruke = new DataGridView();
            Predmet = new DataGridViewTextBoxColumn();
            Sadrzaj = new DataGridViewTextBoxColumn();
            Validnost = new DataGridViewTextBoxColumn();
            Slika = new DataGridViewImageColumn();
            Brisi = new DataGridViewButtonColumn();
            btnNovaPoruka = new Button();
            btnPrintaj = new Button();
            cmbPredmet = new GroupBox();
            txtInfo = new TextBox();
            dtpValidna = new DateTimePicker();
            cmbPredmeti = new ComboBox();
            txtBroj = new TextBox();
            btnDodaj = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvPoruke).BeginInit();
            cmbPredmet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblImePoruke
            // 
            lblImePoruke.AutoSize = true;
            lblImePoruke.Location = new Point(12, 39);
            lblImePoruke.Name = "lblImePoruke";
            lblImePoruke.Size = new Size(38, 15);
            lblImePoruke.TabIndex = 0;
            lblImePoruke.Text = "label1";
            // 
            // dgvPoruke
            // 
            dgvPoruke.AllowUserToAddRows = false;
            dgvPoruke.AllowUserToDeleteRows = false;
            dgvPoruke.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPoruke.Columns.AddRange(new DataGridViewColumn[] { Predmet, Sadrzaj, Validnost, Slika, Brisi });
            dgvPoruke.Location = new Point(12, 57);
            dgvPoruke.Name = "dgvPoruke";
            dgvPoruke.ReadOnly = true;
            dgvPoruke.RowTemplate.Height = 25;
            dgvPoruke.Size = new Size(709, 190);
            dgvPoruke.TabIndex = 1;
            dgvPoruke.CellContentClick += dgvPoruke_CellContentClick;
            // 
            // Predmet
            // 
            Predmet.DataPropertyName = "Predmet";
            Predmet.HeaderText = "Predmet";
            Predmet.Name = "Predmet";
            Predmet.ReadOnly = true;
            // 
            // Sadrzaj
            // 
            Sadrzaj.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Sadrzaj.DataPropertyName = "Sadrzaj";
            Sadrzaj.HeaderText = "Sadrzaj";
            Sadrzaj.Name = "Sadrzaj";
            Sadrzaj.ReadOnly = true;
            // 
            // Validnost
            // 
            Validnost.DataPropertyName = "Validnost";
            Validnost.HeaderText = "Validnost";
            Validnost.Name = "Validnost";
            Validnost.ReadOnly = true;
            // 
            // Slika
            // 
            Slika.DataPropertyName = "Slika";
            Slika.HeaderText = "Slika";
            Slika.Name = "Slika";
            Slika.ReadOnly = true;
            // 
            // Brisi
            // 
            Brisi.DataPropertyName = "Brisi";
            Brisi.HeaderText = "";
            Brisi.Name = "Brisi";
            Brisi.ReadOnly = true;
            Brisi.Text = "Brisi";
            Brisi.UseColumnTextForButtonValue = true;
            // 
            // btnNovaPoruka
            // 
            btnNovaPoruka.Location = new Point(624, 25);
            btnNovaPoruka.Name = "btnNovaPoruka";
            btnNovaPoruka.Size = new Size(99, 27);
            btnNovaPoruka.TabIndex = 2;
            btnNovaPoruka.Text = "NovaPoruka";
            btnNovaPoruka.UseVisualStyleBackColor = true;
            btnNovaPoruka.Click += btnNovaPoruka_Click;
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(624, 253);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(97, 23);
            btnPrintaj.TabIndex = 3;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = true;
            // 
            // cmbPredmet
            // 
            cmbPredmet.Controls.Add(txtInfo);
            cmbPredmet.Controls.Add(dtpValidna);
            cmbPredmet.Controls.Add(cmbPredmeti);
            cmbPredmet.Controls.Add(txtBroj);
            cmbPredmet.Controls.Add(btnDodaj);
            cmbPredmet.Controls.Add(label5);
            cmbPredmet.Controls.Add(label4);
            cmbPredmet.Controls.Add(label3);
            cmbPredmet.Controls.Add(label2);
            cmbPredmet.Location = new Point(12, 282);
            cmbPredmet.Name = "cmbPredmet";
            cmbPredmet.Size = new Size(709, 199);
            cmbPredmet.TabIndex = 4;
            cmbPredmet.TabStop = false;
            cmbPredmet.Text = "groupBox1";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(248, 48);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(455, 133);
            txtInfo.TabIndex = 8;
            // 
            // dtpValidna
            // 
            dtpValidna.Location = new Point(16, 133);
            dtpValidna.Name = "dtpValidna";
            dtpValidna.Size = new Size(200, 23);
            dtpValidna.TabIndex = 7;
            // 
            // cmbPredmeti
            // 
            cmbPredmeti.FormattingEnabled = true;
            cmbPredmeti.Location = new Point(17, 90);
            cmbPredmeti.Name = "cmbPredmeti";
            cmbPredmeti.Size = new Size(199, 23);
            cmbPredmeti.TabIndex = 6;
            // 
            // txtBroj
            // 
            txtBroj.Location = new Point(15, 48);
            txtBroj.Name = "txtBroj";
            txtBroj.Size = new Size(200, 23);
            txtBroj.TabIndex = 5;
            txtBroj.TextChanged += txtBroj_TextChanged;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(15, 170);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(75, 23);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "Dodaj=)>";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 116);
            label5.Name = "label5";
            label5.Size = new Size(114, 15);
            label5.TabIndex = 3;
            label5.Text = "Poruka je validna do";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 74);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 2;
            label4.Text = "Predmet";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(248, 30);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 1;
            label3.Text = "Info";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 30);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 0;
            label2.Text = "BrojPoruka";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmPorukeIB230005
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 487);
            Controls.Add(cmbPredmet);
            Controls.Add(btnPrintaj);
            Controls.Add(btnNovaPoruka);
            Controls.Add(dgvPoruke);
            Controls.Add(lblImePoruke);
            Name = "frmPorukeIB230005";
            Text = "frmPorukeIB230005";
            Load += frmPorukeIB230005_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPoruke).EndInit();
            cmbPredmet.ResumeLayout(false);
            cmbPredmet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblImePoruke;
        private DataGridView dgvPoruke;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Sadrzaj;
        private DataGridViewTextBoxColumn Validnost;
        private DataGridViewImageColumn Slika;
        private DataGridViewButtonColumn Brisi;
        private Button btnNovaPoruka;
        private Button btnPrintaj;
        private GroupBox cmbPredmet;
        private TextBox txtInfo;
        private DateTimePicker dtpValidna;
        private ComboBox cmbPredmeti;
        private TextBox txtBroj;
        private Button btnDodaj;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ErrorProvider errorProvider1;
    }
}
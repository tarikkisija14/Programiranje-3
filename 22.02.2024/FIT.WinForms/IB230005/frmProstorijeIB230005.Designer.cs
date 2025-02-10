namespace FIT.WinForms.IB230005
{
    partial class frmProstorijeIB230005
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
            dgvProstorija = new DataGridView();
            Logo = new DataGridViewImageColumn();
            Naziv = new DataGridViewTextBoxColumn();
            Oznaka = new DataGridViewTextBoxColumn();
            Kapacitet = new DataGridViewTextBoxColumn();
            BrPredmeta = new DataGridViewTextBoxColumn();
            Nastava = new DataGridViewButtonColumn();
            Prisustvo = new DataGridViewButtonColumn();
            btnPrintaj = new Button();
            btnNovaProstorija = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProstorija).BeginInit();
            SuspendLayout();
            // 
            // dgvProstorija
            // 
            dgvProstorija.AllowUserToAddRows = false;
            dgvProstorija.AllowUserToDeleteRows = false;
            dgvProstorija.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProstorija.Columns.AddRange(new DataGridViewColumn[] { Logo, Naziv, Oznaka, Kapacitet, BrPredmeta, Nastava, Prisustvo });
            dgvProstorija.Location = new Point(12, 47);
            dgvProstorija.Name = "dgvProstorija";
            dgvProstorija.ReadOnly = true;
            dgvProstorija.RowTemplate.Height = 25;
            dgvProstorija.Size = new Size(818, 185);
            dgvProstorija.TabIndex = 0;
            dgvProstorija.CellContentClick += dgvProstorija_CellContentClick;
            // 
            // Logo
            // 
            Logo.DataPropertyName = "Logo";
            Logo.HeaderText = "Logo";
            Logo.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Logo.Name = "Logo";
            Logo.ReadOnly = true;
            // 
            // Naziv
            // 
            Naziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Naziv.DataPropertyName = "Naziv";
            Naziv.HeaderText = "Naziv";
            Naziv.Name = "Naziv";
            Naziv.ReadOnly = true;
            // 
            // Oznaka
            // 
            Oznaka.DataPropertyName = "Oznaka";
            Oznaka.HeaderText = "Oznaka";
            Oznaka.Name = "Oznaka";
            Oznaka.ReadOnly = true;
            // 
            // Kapacitet
            // 
            Kapacitet.DataPropertyName = "Kapacitet";
            Kapacitet.HeaderText = "Kapacitet";
            Kapacitet.Name = "Kapacitet";
            Kapacitet.ReadOnly = true;
            // 
            // BrPredmeta
            // 
            BrPredmeta.DataPropertyName = "BrPredmeta";
            BrPredmeta.HeaderText = "Br.Predmeta";
            BrPredmeta.Name = "BrPredmeta";
            BrPredmeta.ReadOnly = true;
            // 
            // Nastava
            // 
            Nastava.HeaderText = "";
            Nastava.Name = "Nastava";
            Nastava.ReadOnly = true;
            Nastava.Text = "Nastava";
            Nastava.UseColumnTextForButtonValue = true;
            // 
            // Prisustvo
            // 
            Prisustvo.HeaderText = "";
            Prisustvo.Name = "Prisustvo";
            Prisustvo.ReadOnly = true;
            Prisustvo.Text = "Prisutvo";
            Prisustvo.UseColumnTextForButtonValue = true;
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(721, 238);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(109, 32);
            btnPrintaj.TabIndex = 2;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = true;
            btnPrintaj.Click += btnPrintaj_Click;
            // 
            // btnNovaProstorija
            // 
            btnNovaProstorija.Location = new Point(704, 12);
            btnNovaProstorija.Name = "btnNovaProstorija";
            btnNovaProstorija.Size = new Size(126, 29);
            btnNovaProstorija.TabIndex = 3;
            btnNovaProstorija.Text = "Nova prostorija";
            btnNovaProstorija.UseVisualStyleBackColor = true;
            btnNovaProstorija.Click += btnNovaProstorija_Click;
            // 
            // frmProstorijeIB230005
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 282);
            Controls.Add(btnNovaProstorija);
            Controls.Add(btnPrintaj);
            Controls.Add(dgvProstorija);
            Name = "frmProstorijeIB230005";
            Text = "frmProstorijeIB230005";
            Load += frmProstorijeIB230005_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProstorija).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProstorija;
        private Button button1;
        private Button btnPrintaj;
        private DataGridViewImageColumn Logo;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewTextBoxColumn Oznaka;
        private DataGridViewTextBoxColumn Kapacitet;
        private DataGridViewTextBoxColumn BrPredmeta;
        private DataGridViewButtonColumn Nastava;
        private DataGridViewButtonColumn Prisustvo;
        private Button btnNovaProstorija;
    }
}
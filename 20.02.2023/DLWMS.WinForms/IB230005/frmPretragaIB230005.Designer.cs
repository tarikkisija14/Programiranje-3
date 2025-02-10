namespace DLWMS.WinForms.IB230005
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
            dgvStudenti = new DataGridView();
            Indeks = new DataGridViewTextBoxColumn();
            ImePrezime = new DataGridViewTextBoxColumn();
            Predmet = new DataGridViewTextBoxColumn();
            Ocjena = new DataGridViewTextBoxColumn();
            DatumPolaganja = new DataGridViewTextBoxColumn();
            Poruke = new DataGridViewButtonColumn();
            cmbOcjenaOd = new ComboBox();
            cmbOcjenaDO = new ComboBox();
            dtpOd = new DateTimePicker();
            dtpDo = new DateTimePicker();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 41);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Ocjena od";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 38);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 1;
            label2.Text = "do";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(233, 36);
            label3.Name = "label3";
            label3.Size = new Size(126, 15);
            label3.TabIndex = 2;
            label3.Text = "polozena u periodu od";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(560, 36);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 3;
            label4.Text = "do";
            // 
            // dgvStudenti
            // 
            dgvStudenti.AllowUserToAddRows = false;
            dgvStudenti.AllowUserToDeleteRows = false;
            dgvStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudenti.Columns.AddRange(new DataGridViewColumn[] { Indeks, ImePrezime, Predmet, Ocjena, DatumPolaganja, Poruke });
            dgvStudenti.Location = new Point(16, 67);
            dgvStudenti.Name = "dgvStudenti";
            dgvStudenti.ReadOnly = true;
            dgvStudenti.RowTemplate.Height = 25;
            dgvStudenti.Size = new Size(771, 205);
            dgvStudenti.TabIndex = 4;
            dgvStudenti.CellContentClick += dataGridView1_CellContentClick;
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
            ImePrezime.HeaderText = "ImePrezime";
            ImePrezime.Name = "ImePrezime";
            ImePrezime.ReadOnly = true;
            // 
            // Predmet
            // 
            Predmet.DataPropertyName = "Predmet";
            Predmet.HeaderText = "Predmet";
            Predmet.Name = "Predmet";
            Predmet.ReadOnly = true;
            // 
            // Ocjena
            // 
            Ocjena.DataPropertyName = "Ocjena";
            Ocjena.HeaderText = "Ocjena";
            Ocjena.Name = "Ocjena";
            Ocjena.ReadOnly = true;
            // 
            // DatumPolaganja
            // 
            DatumPolaganja.DataPropertyName = "DatumPolaganja";
            DatumPolaganja.HeaderText = "Datum polaganja";
            DatumPolaganja.Name = "DatumPolaganja";
            DatumPolaganja.ReadOnly = true;
            // 
            // Poruke
            // 
            Poruke.HeaderText = "";
            Poruke.Name = "Poruke";
            Poruke.ReadOnly = true;
            Poruke.Text = "Poruke";
            Poruke.UseColumnTextForButtonValue = true;
            // 
            // cmbOcjenaOd
            // 
            cmbOcjenaOd.FormattingEnabled = true;
            cmbOcjenaOd.Items.AddRange(new object[] { "6", "7", "8", "9", "10" });
            cmbOcjenaOd.Location = new Point(83, 35);
            cmbOcjenaOd.Name = "cmbOcjenaOd";
            cmbOcjenaOd.Size = new Size(59, 23);
            cmbOcjenaOd.TabIndex = 5;
            cmbOcjenaOd.SelectedIndexChanged += cmbOcjenaOd_SelectedIndexChanged;
            // 
            // cmbOcjenaDO
            // 
            cmbOcjenaDO.FormattingEnabled = true;
            cmbOcjenaDO.Items.AddRange(new object[] { "6", "7", "8", "9", "10\t" });
            cmbOcjenaDO.Location = new Point(175, 35);
            cmbOcjenaDO.Name = "cmbOcjenaDO";
            cmbOcjenaDO.Size = new Size(52, 23);
            cmbOcjenaDO.TabIndex = 6;
            cmbOcjenaDO.SelectedIndexChanged += CmbOcjenaDO_SelectedIndexChanged;
            // 
            // dtpOd
            // 
            dtpOd.Location = new Point(354, 30);
            dtpOd.Name = "dtpOd";
            dtpOd.Size = new Size(200, 23);
            dtpOd.TabIndex = 7;
            dtpOd.ValueChanged += dtpOd_ValueChanged;
            // 
            // dtpDo
            // 
            dtpDo.Location = new Point(587, 29);
            dtpDo.Name = "dtpDo";
            dtpDo.Size = new Size(200, 23);
            dtpDo.TabIndex = 8;
            dtpDo.ValueChanged += dtpDo_ValueChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmPretragaIB230005
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 282);
            Controls.Add(dtpDo);
            Controls.Add(dtpOd);
            Controls.Add(cmbOcjenaDO);
            Controls.Add(cmbOcjenaOd);
            Controls.Add(dgvStudenti);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPretragaIB230005";
            Text = "frmPretragaIB230005";
            Load += frmPretragaIB230005_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dgvStudenti;
        private DataGridViewTextBoxColumn Indeks;
        private DataGridViewTextBoxColumn ImePrezime;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Ocjena;
        private DataGridViewTextBoxColumn DatumPolaganja;
        private DataGridViewButtonColumn Poruke;
        private ComboBox cmbOcjenaOd;
        private ComboBox cmbOcjenaDO;
        private DateTimePicker dtpOd;
        private DateTimePicker dtpDo;
        private ErrorProvider errorProvider1;
    }
}
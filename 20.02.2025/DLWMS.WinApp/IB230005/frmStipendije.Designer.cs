namespace DLWMS.WinApp.IB230005
{
    partial class frmStipendije
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
            cmbGodine = new ComboBox();
            cmbStipendije = new ComboBox();
            txtIznos = new TextBox();
            btnDodaj = new Button();
            dgvStipendije = new DataGridView();
            Godina = new DataGridViewTextBoxColumn();
            Stipendija = new DataGridViewTextBoxColumn();
            Iznos = new DataGridViewTextBoxColumn();
            Ukupno = new DataGridViewTextBoxColumn();
            Aktivna = new DataGridViewCheckBoxColumn();
            btnPotvrda = new Button();
            btnGenerisi = new Button();
            groupBox1 = new GroupBox();
            txtInfo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvStipendije).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 24);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Godine";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 24);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Stipendija";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(270, 24);
            label3.Name = "label3";
            label3.Size = new Size(118, 15);
            label3.TabIndex = 2;
            label3.Text = "Mjesecni iznos(BAM)";
            // 
            // cmbGodine
            // 
            cmbGodine.FormattingEnabled = true;
            cmbGodine.Items.AddRange(new object[] { "2025", "2024", "2023", "2022" });
            cmbGodine.Location = new Point(14, 45);
            cmbGodine.Name = "cmbGodine";
            cmbGodine.Size = new Size(121, 23);
            cmbGodine.TabIndex = 3;
            // 
            // cmbStipendije
            // 
            cmbStipendije.FormattingEnabled = true;
            cmbStipendije.Location = new Point(143, 45);
            cmbStipendije.Name = "cmbStipendije";
            cmbStipendije.Size = new Size(121, 23);
            cmbStipendije.TabIndex = 4;
            // 
            // txtIznos
            // 
            txtIznos.BackColor = SystemColors.Window;
            txtIznos.BorderStyle = BorderStyle.FixedSingle;
            txtIznos.Location = new Point(270, 45);
            txtIznos.Name = "txtIznos";
            txtIznos.Size = new Size(100, 23);
            txtIznos.TabIndex = 5;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(416, 43);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(75, 23);
            btnDodaj.TabIndex = 6;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dgvStipendije
            // 
            dgvStipendije.AllowUserToAddRows = false;
            dgvStipendije.AllowUserToDeleteRows = false;
            dgvStipendije.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStipendije.Columns.AddRange(new DataGridViewColumn[] { Godina, Stipendija, Iznos, Ukupno, Aktivna });
            dgvStipendije.Location = new Point(14, 74);
            dgvStipendije.Name = "dgvStipendije";
            dgvStipendije.ReadOnly = true;
            dgvStipendije.Size = new Size(707, 171);
            dgvStipendije.TabIndex = 7;
            // 
            // Godina
            // 
            Godina.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Godina.DataPropertyName = "Godina";
            Godina.HeaderText = "Godina";
            Godina.Name = "Godina";
            Godina.ReadOnly = true;
            // 
            // Stipendija
            // 
            Stipendija.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Stipendija.DataPropertyName = "Stipendija";
            Stipendija.HeaderText = "Stipendija";
            Stipendija.Name = "Stipendija";
            Stipendija.ReadOnly = true;
            // 
            // Iznos
            // 
            Iznos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Iznos.DataPropertyName = "Iznos";
            Iznos.HeaderText = "Mjesecni iznos";
            Iznos.Name = "Iznos";
            Iznos.ReadOnly = true;
            // 
            // Ukupno
            // 
            Ukupno.DataPropertyName = "Ukupno";
            Ukupno.HeaderText = "Ukupni iznos";
            Ukupno.Name = "Ukupno";
            Ukupno.ReadOnly = true;
            // 
            // Aktivna
            // 
            Aktivna.DataPropertyName = "Aktivna";
            Aktivna.HeaderText = "Aktivna";
            Aktivna.Name = "Aktivna";
            Aktivna.ReadOnly = true;
            // 
            // btnPotvrda
            // 
            btnPotvrda.Location = new Point(646, 251);
            btnPotvrda.Name = "btnPotvrda";
            btnPotvrda.Size = new Size(75, 23);
            btnPotvrda.TabIndex = 8;
            btnPotvrda.Text = "Potvrda";
            btnPotvrda.UseVisualStyleBackColor = true;
            btnPotvrda.Click += btnPotvrda_Click;
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(12, 251);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(190, 23);
            btnGenerisi.TabIndex = 9;
            btnGenerisi.Text = "Generisi stipendije>>>>>>";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Location = new Point(14, 280);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(707, 205);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // txtInfo
            // 
            txtInfo.BorderStyle = BorderStyle.FixedSingle;
            txtInfo.Location = new Point(6, 24);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(695, 175);
            txtInfo.TabIndex = 0;
            // 
            // frmStipendije
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 494);
            Controls.Add(groupBox1);
            Controls.Add(btnGenerisi);
            Controls.Add(btnPotvrda);
            Controls.Add(dgvStipendije);
            Controls.Add(btnDodaj);
            Controls.Add(txtIznos);
            Controls.Add(cmbStipendije);
            Controls.Add(cmbGodine);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmStipendije";
            Text = "Upravljanje stipendijama";
            Load += frmStipendije_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStipendije).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbGodine;
        private ComboBox cmbStipendije;
        private TextBox txtIznos;
        private Button btnDodaj;
        private DataGridView dgvStipendije;
        private Button btnPotvrda;
        private Button btnGenerisi;
        private GroupBox groupBox1;
        private TextBox txtInfo;
        private DataGridViewTextBoxColumn Godina;
        private DataGridViewTextBoxColumn Stipendija;
        private DataGridViewTextBoxColumn Iznos;
        private DataGridViewTextBoxColumn Ukupno;
        private DataGridViewCheckBoxColumn Aktivna;
    }
}
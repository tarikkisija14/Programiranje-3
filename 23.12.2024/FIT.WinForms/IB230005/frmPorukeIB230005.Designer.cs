namespace FIT.WinForms.IB230005
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
            lblPoruka = new Label();
            dgvPoruke = new DataGridView();
            Predmet = new DataGridViewTextBoxColumn();
            Sadrzaj = new DataGridViewTextBoxColumn();
            Slika = new DataGridViewImageColumn();
            Hitnost = new DataGridViewTextBoxColumn();
            Validnost = new DataGridViewTextBoxColumn();
            Brisi = new DataGridViewButtonColumn();
            btnNovaPoruka = new Button();
            btnPrintaj = new Button();
            groupBox1 = new GroupBox();
            btnDodaj = new Button();
            dtpValidnost = new DateTimePicker();
            txtInfo = new TextBox();
            txtBrojPoruka = new TextBox();
            cmbPredmet = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvPoruke).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // lblPoruka
            // 
            lblPoruka.AutoSize = true;
            lblPoruka.Location = new Point(12, 51);
            lblPoruka.Name = "lblPoruka";
            lblPoruka.Size = new Size(38, 15);
            lblPoruka.TabIndex = 0;
            lblPoruka.Text = "label1";
            // 
            // dgvPoruke
            // 
            dgvPoruke.AllowUserToAddRows = false;
            dgvPoruke.AllowUserToDeleteRows = false;
            dgvPoruke.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPoruke.Columns.AddRange(new DataGridViewColumn[] { Predmet, Sadrzaj, Slika, Hitnost, Validnost, Brisi });
            dgvPoruke.Location = new Point(12, 76);
            dgvPoruke.Name = "dgvPoruke";
            dgvPoruke.ReadOnly = true;
            dgvPoruke.RowTemplate.Height = 25;
            dgvPoruke.Size = new Size(775, 204);
            dgvPoruke.TabIndex = 1;
            dgvPoruke.CellContentClick += dgvPoruke_CellContentClick;
            // 
            // Predmet
            // 
            Predmet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            // Slika
            // 
            Slika.DataPropertyName = "Slika";
            Slika.HeaderText = "Slika";
            Slika.Name = "Slika";
            Slika.ReadOnly = true;
            // 
            // Hitnost
            // 
            Hitnost.DataPropertyName = "Hitnost";
            Hitnost.HeaderText = "Hitnost";
            Hitnost.Name = "Hitnost";
            Hitnost.ReadOnly = true;
            // 
            // Validnost
            // 
            Validnost.DataPropertyName = "Validnost";
            Validnost.HeaderText = "Validnost";
            Validnost.Name = "Validnost";
            Validnost.ReadOnly = true;
            // 
            // Brisi
            // 
            Brisi.HeaderText = "";
            Brisi.Name = "Brisi";
            Brisi.ReadOnly = true;
            Brisi.Text = "Brisi";
            Brisi.UseColumnTextForButtonValue = true;
            // 
            // btnNovaPoruka
            // 
            btnNovaPoruka.Location = new Point(697, 37);
            btnNovaPoruka.Name = "btnNovaPoruka";
            btnNovaPoruka.Size = new Size(91, 33);
            btnNovaPoruka.TabIndex = 2;
            btnNovaPoruka.Text = "Nova poruka";
            btnNovaPoruka.UseVisualStyleBackColor = true;
            btnNovaPoruka.Click += btnNovaPoruka_Click;
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(696, 286);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(91, 33);
            btnPrintaj.TabIndex = 3;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = true;
            btnPrintaj.Click += btnPrintaj_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDodaj);
            groupBox1.Controls.Add(dtpValidnost);
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Controls.Add(txtBrojPoruka);
            groupBox1.Controls.Add(cmbPredmet);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(19, 342);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(768, 238);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(13, 165);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(200, 49);
            btnDodaj.TabIndex = 8;
            btnDodaj.Text = "Dodaj=>";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dtpValidnost
            // 
            dtpValidnost.Location = new Point(13, 136);
            dtpValidnost.Name = "dtpValidnost";
            dtpValidnost.Size = new Size(200, 23);
            dtpValidnost.TabIndex = 7;
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(248, 56);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(505, 158);
            txtInfo.TabIndex = 6;
            // 
            // txtBrojPoruka
            // 
            txtBrojPoruka.Location = new Point(13, 48);
            txtBrojPoruka.Name = "txtBrojPoruka";
            txtBrojPoruka.Size = new Size(200, 23);
            txtBrojPoruka.TabIndex = 5;
            // 
            // cmbPredmet
            // 
            cmbPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPredmet.FormattingEnabled = true;
            cmbPredmet.Location = new Point(13, 92);
            cmbPredmet.Name = "cmbPredmet";
            cmbPredmet.Size = new Size(200, 23);
            cmbPredmet.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(245, 34);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 3;
            label5.Text = "Info";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 118);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 2;
            label4.Text = "Poruka je validna do";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 74);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 1;
            label3.Text = "Predmet";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 30);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 0;
            label2.Text = "Broj poruka";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmPorukeIB230005
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 592);
            Controls.Add(groupBox1);
            Controls.Add(btnPrintaj);
            Controls.Add(btnNovaPoruka);
            Controls.Add(dgvPoruke);
            Controls.Add(lblPoruka);
            Name = "frmPorukeIB230005";
            Text = "frmPorukeIB230005";
            Load += frmPorukeIB230005_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPoruke).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPoruka;
        private DataGridView dgvPoruke;
        private Button btnNovaPoruka;
        private Button btnPrintaj;
        private GroupBox groupBox1;
        private Button btnDodaj;
        private DateTimePicker dtpValidnost;
        private TextBox txtInfo;
        private TextBox txtBrojPoruka;
        private ComboBox cmbPredmet;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Sadrzaj;
        private DataGridViewImageColumn Slika;
        private DataGridViewTextBoxColumn Hitnost;
        private DataGridViewTextBoxColumn Validnost;
        private DataGridViewButtonColumn Brisi;
        private ErrorProvider err;
    }
}
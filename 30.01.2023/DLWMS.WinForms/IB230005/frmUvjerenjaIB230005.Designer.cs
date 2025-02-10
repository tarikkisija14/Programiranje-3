namespace DLWMS.WinForms.IB230005
{
    partial class frmUvjerenjaIB230005
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
            dgvStudenti = new DataGridView();
            Datum = new DataGridViewTextBoxColumn();
            Vrsta = new DataGridViewTextBoxColumn();
            Svrha = new DataGridViewTextBoxColumn();
            Uplatnica = new DataGridViewImageColumn();
            Printano = new DataGridViewCheckBoxColumn();
            Brisi = new DataGridViewButtonColumn();
            Printaj = new DataGridViewButtonColumn();
            btnNoviZahtjev = new Button();
            groupBox1 = new GroupBox();
            txtInfo = new TextBox();
            label4 = new Label();
            txtBroj = new TextBox();
            txtSvrha = new TextBox();
            cmbVrsta = new ComboBox();
            btnDodaj = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // dgvStudenti
            // 
            dgvStudenti.AllowUserToAddRows = false;
            dgvStudenti.AllowUserToDeleteRows = false;
            dgvStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudenti.Columns.AddRange(new DataGridViewColumn[] { Datum, Vrsta, Svrha, Uplatnica, Printano, Brisi, Printaj });
            dgvStudenti.Location = new Point(12, 59);
            dgvStudenti.Name = "dgvStudenti";
            dgvStudenti.ReadOnly = true;
            dgvStudenti.RowTemplate.Height = 25;
            dgvStudenti.Size = new Size(685, 181);
            dgvStudenti.TabIndex = 0;
            dgvStudenti.CellContentClick += dgvStudenti_CellContentClick;
            // 
            // Datum
            // 
            Datum.DataPropertyName = "Vrijeme";
            Datum.HeaderText = "Datum";
            Datum.Name = "Datum";
            Datum.ReadOnly = true;
            // 
            // Vrsta
            // 
            Vrsta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Vrsta.DataPropertyName = "Vrsta";
            Vrsta.HeaderText = "Vrsta";
            Vrsta.Name = "Vrsta";
            Vrsta.ReadOnly = true;
            // 
            // Svrha
            // 
            Svrha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Svrha.DataPropertyName = "Svrha";
            Svrha.HeaderText = "Svrha";
            Svrha.Name = "Svrha";
            Svrha.ReadOnly = true;
            // 
            // Uplatnica
            // 
            Uplatnica.DataPropertyName = "Uplatnica";
            Uplatnica.HeaderText = "Uplatnica";
            Uplatnica.Name = "Uplatnica";
            Uplatnica.ReadOnly = true;
            // 
            // Printano
            // 
            Printano.DataPropertyName = "Printano";
            Printano.HeaderText = "Printano";
            Printano.Name = "Printano";
            Printano.ReadOnly = true;
            // 
            // Brisi
            // 
            Brisi.HeaderText = "";
            Brisi.Name = "Brisi";
            Brisi.ReadOnly = true;
            Brisi.Text = "Brisi";
            Brisi.UseColumnTextForButtonValue = true;
            // 
            // Printaj
            // 
            Printaj.HeaderText = "";
            Printaj.Name = "Printaj";
            Printaj.ReadOnly = true;
            Printaj.Text = "Printaj";
            Printaj.UseColumnTextForButtonValue = true;
            // 
            // btnNoviZahtjev
            // 
            btnNoviZahtjev.Location = new Point(605, 27);
            btnNoviZahtjev.Name = "btnNoviZahtjev";
            btnNoviZahtjev.Size = new Size(92, 26);
            btnNoviZahtjev.TabIndex = 1;
            btnNoviZahtjev.Text = "NoviZahtjev";
            btnNoviZahtjev.UseVisualStyleBackColor = true;
            btnNoviZahtjev.Click += btnNoviZahtjev_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtBroj);
            groupBox1.Controls.Add(txtSvrha);
            groupBox1.Controls.Add(cmbVrsta);
            groupBox1.Controls.Add(btnDodaj);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(13, 259);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(684, 229);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodavanje zahetjva za izdavanjem uvjerneja";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(17, 103);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(651, 120);
            txtInfo.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 85);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 7;
            label4.Text = "Info";
            // 
            // txtBroj
            // 
            txtBroj.Location = new Point(406, 51);
            txtBroj.Name = "txtBroj";
            txtBroj.Size = new Size(100, 23);
            txtBroj.TabIndex = 6;
            // 
            // txtSvrha
            // 
            txtSvrha.Location = new Point(223, 51);
            txtSvrha.Name = "txtSvrha";
            txtSvrha.Size = new Size(177, 23);
            txtSvrha.TabIndex = 5;
            // 
            // cmbVrsta
            // 
            cmbVrsta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVrsta.FormattingEnabled = true;
            cmbVrsta.Items.AddRange(new object[] { "Uvjerenje 1", "Uvjerenje 2", "Uvjerenje 3", "Uvjerenje 4", "Uvjerenje 5" });
            cmbVrsta.Location = new Point(17, 52);
            cmbVrsta.Name = "cmbVrsta";
            cmbVrsta.Size = new Size(194, 23);
            cmbVrsta.TabIndex = 4;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(519, 50);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(75, 23);
            btnDodaj.TabIndex = 3;
            btnDodaj.Text = "Dodaj=>";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(406, 33);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 2;
            label3.Text = "BrojZahtjeva";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(220, 33);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Svrha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 33);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Vrsta uvjerneja";
            label1.Click += label1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmUvjerenjaIB230005
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 514);
            Controls.Add(groupBox1);
            Controls.Add(btnNoviZahtjev);
            Controls.Add(dgvStudenti);
            Name = "frmUvjerenjaIB230005";
            Text = "frmUvjerenjaIB230005";
            Load += frmUvjerenjaIB230005_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvStudenti;
        private Button btnNoviZahtjev;
        private GroupBox groupBox1;
        private TextBox txtBroj;
        private TextBox txtSvrha;
        private ComboBox cmbVrsta;
        private Button btnDodaj;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtInfo;
        private Label label4;
        private DataGridViewTextBoxColumn Datum;
        private DataGridViewTextBoxColumn Vrsta;
        private DataGridViewTextBoxColumn Svrha;
        private DataGridViewImageColumn Uplatnica;
        private DataGridViewCheckBoxColumn Printano;
        private DataGridViewButtonColumn Brisi;
        private DataGridViewButtonColumn Printaj;
        private ErrorProvider errorProvider1;
    }
}
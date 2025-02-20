namespace DLWMS.WinApp.IB230005
{
    partial class frmPretraga
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
            cmbGodina = new ComboBox();
            cmbStipendija = new ComboBox();
            btnDodajStipendiju = new Button();
            btnStipendijePoGodinama = new Button();
            dgvStudenti = new DataGridView();
            IIP = new DataGridViewTextBoxColumn();
            Godina = new DataGridViewTextBoxColumn();
            Stipendija = new DataGridViewTextBoxColumn();
            Iznos = new DataGridViewTextBoxColumn();
            Ukupno = new DataGridViewTextBoxColumn();
            Ukloni = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 21);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Godina";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 23);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Stipendija";
            // 
            // cmbGodina
            // 
            cmbGodina.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGodina.FormattingEnabled = true;
            cmbGodina.Items.AddRange(new object[] { "2025", "2024", "2023", "2022" });
            cmbGodina.Location = new Point(24, 39);
            cmbGodina.Name = "cmbGodina";
            cmbGodina.Size = new Size(121, 23);
            cmbGodina.TabIndex = 2;
            cmbGodina.SelectedIndexChanged += cmbGodina_SelectedIndexChanged;
            // 
            // cmbStipendija
            // 
            cmbStipendija.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStipendija.FormattingEnabled = true;
            cmbStipendija.Location = new Point(160, 39);
            cmbStipendija.Name = "cmbStipendija";
            cmbStipendija.Size = new Size(152, 23);
            cmbStipendija.TabIndex = 3;
            cmbStipendija.SelectedIndexChanged += cmbStipendija_SelectedIndexChanged;
            // 
            // btnDodajStipendiju
            // 
            btnDodajStipendiju.Location = new Point(469, 38);
            btnDodajStipendiju.Name = "btnDodajStipendiju";
            btnDodajStipendiju.Size = new Size(119, 23);
            btnDodajStipendiju.TabIndex = 4;
            btnDodajStipendiju.Text = "Dodaj stipendiju";
            btnDodajStipendiju.UseVisualStyleBackColor = true;
            btnDodajStipendiju.Click += btnDodajStipendiju_Click;
            // 
            // btnStipendijePoGodinama
            // 
            btnStipendijePoGodinama.Location = new Point(596, 38);
            btnStipendijePoGodinama.Name = "btnStipendijePoGodinama";
            btnStipendijePoGodinama.Size = new Size(151, 23);
            btnStipendijePoGodinama.TabIndex = 5;
            btnStipendijePoGodinama.Text = "Stipendije po godinama";
            btnStipendijePoGodinama.UseVisualStyleBackColor = true;
            btnStipendijePoGodinama.Click += btnStipendijePoGodinama_Click;
            // 
            // dgvStudenti
            // 
            dgvStudenti.AllowUserToAddRows = false;
            dgvStudenti.AllowUserToDeleteRows = false;
            dgvStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudenti.Columns.AddRange(new DataGridViewColumn[] { IIP, Godina, Stipendija, Iznos, Ukupno, Ukloni });
            dgvStudenti.Location = new Point(24, 68);
            dgvStudenti.Name = "dgvStudenti";
            dgvStudenti.ReadOnly = true;
            dgvStudenti.Size = new Size(723, 175);
            dgvStudenti.TabIndex = 6;
            dgvStudenti.CellContentClick += dgvStudenti_CellContentClick;
            // 
            // IIP
            // 
            IIP.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IIP.DataPropertyName = "IIP";
            IIP.HeaderText = "(Indeks)Ime i prezime";
            IIP.Name = "IIP";
            IIP.ReadOnly = true;
            // 
            // Godina
            // 
            Godina.DataPropertyName = "Godina";
            Godina.HeaderText = "Godina";
            Godina.Name = "Godina";
            Godina.ReadOnly = true;
            // 
            // Stipendija
            // 
            Stipendija.DataPropertyName = "Stipendija";
            Stipendija.HeaderText = "Stipendija";
            Stipendija.Name = "Stipendija";
            Stipendija.ReadOnly = true;
            // 
            // Iznos
            // 
            Iznos.DataPropertyName = "Iznos";
            Iznos.HeaderText = "Mjesecni iznos";
            Iznos.Name = "Iznos";
            Iznos.ReadOnly = true;
            // 
            // Ukupno
            // 
            Ukupno.DataPropertyName = "Ukupno";
            Ukupno.HeaderText = "Ukupno";
            Ukupno.Name = "Ukupno";
            Ukupno.ReadOnly = true;
            // 
            // Ukloni
            // 
            Ukloni.HeaderText = "";
            Ukloni.Name = "Ukloni";
            Ukloni.ReadOnly = true;
            Ukloni.Text = "Ukloni";
            Ukloni.UseColumnTextForButtonValue = true;
            // 
            // frmPretraga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 250);
            Controls.Add(dgvStudenti);
            Controls.Add(btnStipendijePoGodinama);
            Controls.Add(btnDodajStipendiju);
            Controls.Add(cmbStipendija);
            Controls.Add(cmbGodina);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPretraga";
            Text = "frmPretraga";
            Load += frmPretraga_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbGodina;
        private ComboBox cmbStipendija;
        private Button btnDodajStipendiju;
        private Button btnStipendijePoGodinama;
        private DataGridView dgvStudenti;
        private DataGridViewTextBoxColumn IIP;
        private DataGridViewTextBoxColumn Godina;
        private DataGridViewTextBoxColumn Stipendija;
        private DataGridViewTextBoxColumn Iznos;
        private DataGridViewTextBoxColumn Ukupno;
        private DataGridViewButtonColumn Ukloni;
    }
}
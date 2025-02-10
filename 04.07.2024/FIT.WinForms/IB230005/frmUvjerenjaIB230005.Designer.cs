namespace FIT.WinForms.IB230005
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
            btnZahtjev = new Button();
            btnGenerisi = new Button();
            dgvUvjerenja = new DataGridView();
            groupBox1 = new GroupBox();
            txtInfo = new TextBox();
            txtBrojZahtjeva = new TextBox();
            txtSvrha = new TextBox();
            lbl1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbVrsta = new ComboBox();
            err = new ErrorProvider(components);
            Datum = new DataGridViewTextBoxColumn();
            Vrsta = new DataGridViewTextBoxColumn();
            Svrha = new DataGridViewTextBoxColumn();
            Uplatnica = new DataGridViewImageColumn();
            Printano = new DataGridViewCheckBoxColumn();
            Brisi = new DataGridViewButtonColumn();
            Printaj = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvUvjerenja).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // btnZahtjev
            // 
            btnZahtjev.Location = new Point(701, 37);
            btnZahtjev.Name = "btnZahtjev";
            btnZahtjev.Size = new Size(87, 26);
            btnZahtjev.TabIndex = 0;
            btnZahtjev.Text = "Novi Zahtjev";
            btnZahtjev.UseVisualStyleBackColor = true;
            btnZahtjev.Click += btnZahtjev_Click;
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(658, 47);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(99, 23);
            btnGenerisi.TabIndex = 1;
            btnGenerisi.Text = "Dodaj=>";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += button2_Click;
            // 
            // dgvUvjerenja
            // 
            dgvUvjerenja.AllowUserToAddRows = false;
            dgvUvjerenja.AllowUserToDeleteRows = false;
            dgvUvjerenja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUvjerenja.Columns.AddRange(new DataGridViewColumn[] { Datum, Vrsta, Svrha, Uplatnica, Printano, Brisi, Printaj });
            dgvUvjerenja.Location = new Point(8, 69);
            dgvUvjerenja.Name = "dgvUvjerenja";
            dgvUvjerenja.ReadOnly = true;
            dgvUvjerenja.RowTemplate.Height = 25;
            dgvUvjerenja.Size = new Size(780, 150);
            dgvUvjerenja.TabIndex = 2;
            dgvUvjerenja.CellContentClick += dgvUvjerenja_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Controls.Add(txtBrojZahtjeva);
            groupBox1.Controls.Add(txtSvrha);
            groupBox1.Controls.Add(lbl1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbVrsta);
            groupBox1.Controls.Add(btnGenerisi);
            groupBox1.Location = new Point(2, 235);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(786, 338);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodavanje zahtjeva za izdavanjem uvjerneja";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(18, 93);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(762, 239);
            txtInfo.TabIndex = 9;
            // 
            // txtBrojZahtjeva
            // 
            txtBrojZahtjeva.Location = new Point(552, 48);
            txtBrojZahtjeva.Name = "txtBrojZahtjeva";
            txtBrojZahtjeva.Size = new Size(100, 23);
            txtBrojZahtjeva.TabIndex = 8;
            // 
            // txtSvrha
            // 
            txtSvrha.Location = new Point(279, 48);
            txtSvrha.Name = "txtSvrha";
            txtSvrha.Size = new Size(267, 23);
            txtSvrha.TabIndex = 7;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(14, 74);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(28, 15);
            lbl1.TabIndex = 6;
            lbl1.Text = "Info";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(555, 30);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 5;
            label3.Text = "Broj zathejva";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(279, 30);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 4;
            label2.Text = "Svrha izdavanja";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 30);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 3;
            label1.Text = "Vrsta uvjerenja";
            // 
            // cmbVrsta
            // 
            cmbVrsta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVrsta.FormattingEnabled = true;
            cmbVrsta.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "5" });
            cmbVrsta.Location = new Point(14, 48);
            cmbVrsta.Name = "cmbVrsta";
            cmbVrsta.Size = new Size(251, 23);
            cmbVrsta.TabIndex = 2;
            // 
            // err
            // 
            err.ContainerControl = this;
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
            Uplatnica.ImageLayout = DataGridViewImageCellLayout.Stretch;
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
            Printaj.Text = "PRintaj";
            Printaj.UseColumnTextForButtonValue = true;
            // 
            // frmUvjerenjaIB230005
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 585);
            Controls.Add(groupBox1);
            Controls.Add(dgvUvjerenja);
            Controls.Add(btnZahtjev);
            Name = "frmUvjerenjaIB230005";
            Text = "frmUvjerenjaIB230005";
            Load += frmUvjerenjaIB230005_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUvjerenja).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnZahtjev;
        private Button btnGenerisi;
        private DataGridView dgvUvjerenja;
        private GroupBox groupBox1;
        private Label lbl1;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbVrsta;
        private TextBox txtBrojZahtjeva;
        private TextBox txtSvrha;
        private TextBox txtInfo;
        private ErrorProvider err;
        private DataGridViewTextBoxColumn Datum;
        private DataGridViewTextBoxColumn Vrsta;
        private DataGridViewTextBoxColumn Svrha;
        private DataGridViewImageColumn Uplatnica;
        private DataGridViewCheckBoxColumn Printano;
        private DataGridViewButtonColumn Brisi;
        private DataGridViewButtonColumn Printaj;
    }
}
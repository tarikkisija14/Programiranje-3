namespace FIT.WinForms.IB230005
{
    partial class frmNovaPorukaIB230005
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
            Hitnos2t = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbPredmeti = new ComboBox();
            dtpValidnost = new DateTimePicker();
            cmbHitnost = new ComboBox();
            txtSadrzaj = new TextBox();
            pbSlika = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            err = new ErrorProvider(components);
            btnSacuvaj = new Button();
            btnOdustani = new Button();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 27);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 0;
            label1.Text = "odaberite predmet";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 71);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 1;
            label2.Text = "Poruka je validna do";
            // 
            // Hitnos2t
            // 
            Hitnos2t.AutoSize = true;
            Hitnos2t.Location = new Point(33, 115);
            Hitnos2t.Name = "Hitnos2t";
            Hitnos2t.Size = new Size(46, 15);
            Hitnos2t.TabIndex = 2;
            Hitnos2t.Text = "Hitnost";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 159);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 3;
            label4.Text = "Sadrzaj Poruke";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(264, 27);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 4;
            label5.Text = "Slika";
            // 
            // cmbPredmeti
            // 
            cmbPredmeti.FormattingEnabled = true;
            cmbPredmeti.Location = new Point(33, 45);
            cmbPredmeti.Name = "cmbPredmeti";
            cmbPredmeti.Size = new Size(200, 23);
            cmbPredmeti.TabIndex = 5;
            // 
            // dtpValidnost
            // 
            dtpValidnost.Location = new Point(33, 89);
            dtpValidnost.Name = "dtpValidnost";
            dtpValidnost.Size = new Size(200, 23);
            dtpValidnost.TabIndex = 6;
            // 
            // cmbHitnost
            // 
            cmbHitnost.FormattingEnabled = true;
            cmbHitnost.Items.AddRange(new object[] { "Srednja", "Mala", "Velika", "Onako" });
            cmbHitnost.Location = new Point(33, 133);
            cmbHitnost.Name = "cmbHitnost";
            cmbHitnost.Size = new Size(200, 23);
            cmbHitnost.TabIndex = 7;
            // 
            // txtSadrzaj
            // 
            txtSadrzaj.Location = new Point(33, 177);
            txtSadrzaj.Multiline = true;
            txtSadrzaj.Name = "txtSadrzaj";
            txtSadrzaj.Size = new Size(200, 205);
            txtSadrzaj.TabIndex = 8;
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(264, 45);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(390, 337);
            pbSlika.TabIndex = 9;
            pbSlika.TabStop = false;
            pbSlika.Click += pbSlika_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(550, 399);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(104, 36);
            btnSacuvaj.TabIndex = 10;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // btnOdustani
            // 
            btnOdustani.Location = new Point(431, 399);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(104, 36);
            btnOdustani.TabIndex = 11;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // frmNovaPorukaIB230005
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 457);
            Controls.Add(btnOdustani);
            Controls.Add(btnSacuvaj);
            Controls.Add(pbSlika);
            Controls.Add(txtSadrzaj);
            Controls.Add(cmbHitnost);
            Controls.Add(dtpValidnost);
            Controls.Add(cmbPredmeti);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Hitnos2t);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNovaPorukaIB230005";
            Text = "Poruka";
            Load += frmNovaPorukaIB230005_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label Hitnos2t;
        private Label label4;
        private Label label5;
        private ComboBox cmbPredmeti;
        private DateTimePicker dtpValidnost;
        private ComboBox cmbHitnost;
        private TextBox txtSadrzaj;
        private PictureBox pbSlika;
        private OpenFileDialog openFileDialog1;
        private ErrorProvider err;
        private Button btnSacuvaj;
        private Button btnOdustani;
    }
}
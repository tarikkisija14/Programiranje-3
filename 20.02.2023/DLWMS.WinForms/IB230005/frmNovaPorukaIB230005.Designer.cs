namespace DLWMS.WinForms.IB230005
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
            label3 = new Label();
            label4 = new Label();
            cmbPredmet = new ComboBox();
            dtpValidnsot = new DateTimePicker();
            txtSadrzaj = new TextBox();
            pbSlika = new PictureBox();
            btnScauvaj = new Button();
            btnOdustani = new Button();
            errorProvider1 = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 20);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "Odaberite predmet";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 64);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 1;
            label2.Text = "Poruka je validna do";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 108);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 2;
            label3.Text = "SadrzajPoruke";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(236, 20);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 3;
            label4.Text = "SLika";
            // 
            // cmbPredmet
            // 
            cmbPredmet.FormattingEnabled = true;
            cmbPredmet.Location = new Point(11, 38);
            cmbPredmet.Name = "cmbPredmet";
            cmbPredmet.Size = new Size(206, 23);
            cmbPredmet.TabIndex = 4;
            // 
            // dtpValidnsot
            // 
            dtpValidnsot.Location = new Point(12, 82);
            dtpValidnsot.Name = "dtpValidnsot";
            dtpValidnsot.Size = new Size(200, 23);
            dtpValidnsot.TabIndex = 5;
            // 
            // txtSadrzaj
            // 
            txtSadrzaj.Location = new Point(11, 121);
            txtSadrzaj.Multiline = true;
            txtSadrzaj.Name = "txtSadrzaj";
            txtSadrzaj.Size = new Size(201, 115);
            txtSadrzaj.TabIndex = 6;
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(236, 38);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(298, 198);
            pbSlika.TabIndex = 7;
            pbSlika.TabStop = false;
            pbSlika.Click += pbSlika_Click;
            // 
            // btnScauvaj
            // 
            btnScauvaj.Location = new Point(457, 242);
            btnScauvaj.Name = "btnScauvaj";
            btnScauvaj.Size = new Size(75, 23);
            btnScauvaj.TabIndex = 8;
            btnScauvaj.Text = "Scauvaj";
            btnScauvaj.UseVisualStyleBackColor = true;
            btnScauvaj.Click += btnScauvaj_Click;
            // 
            // btnOdustani
            // 
            btnOdustani.Location = new Point(359, 242);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(75, 23);
            btnOdustani.TabIndex = 9;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmNovaPorukaIB230005
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 291);
            Controls.Add(btnOdustani);
            Controls.Add(btnScauvaj);
            Controls.Add(pbSlika);
            Controls.Add(txtSadrzaj);
            Controls.Add(dtpValidnsot);
            Controls.Add(cmbPredmet);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNovaPorukaIB230005";
            Text = "Poruka";
            Load += frmNovaPorukaIB230005_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbPredmet;
        private DateTimePicker dtpValidnsot;
        private TextBox txtSadrzaj;
        private PictureBox pbSlika;
        private Button btnScauvaj;
        private Button btnOdustani;
        private ErrorProvider errorProvider1;
        private OpenFileDialog openFileDialog1;
    }
}
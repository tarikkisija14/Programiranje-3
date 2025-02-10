namespace DLWMS.WinApp.IB230005
{
    partial class frmStudentiEdit
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
            pbSlika = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            errorProvider1 = new ErrorProvider(components);
            btnUcitaj = new Button();
            lblImePrezime = new Label();
            lblBrojIndeksa = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbDrzava = new ComboBox();
            cmbGrad = new ComboBox();
            btnSacuvaj = new Button();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(34, 34);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(233, 206);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 0;
            pbSlika.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnUcitaj
            // 
            btnUcitaj.Location = new Point(33, 254);
            btnUcitaj.Name = "btnUcitaj";
            btnUcitaj.Size = new Size(234, 35);
            btnUcitaj.TabIndex = 1;
            btnUcitaj.Text = "Ucitaj sliku";
            btnUcitaj.UseVisualStyleBackColor = true;
            btnUcitaj.Click += btnUcitaj_Click;
            // 
            // lblImePrezime
            // 
            lblImePrezime.AutoSize = true;
            lblImePrezime.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblImePrezime.Location = new Point(292, 34);
            lblImePrezime.Name = "lblImePrezime";
            lblImePrezime.Size = new Size(96, 37);
            lblImePrezime.TabIndex = 2;
            lblImePrezime.Text = "label1";
            // 
            // lblBrojIndeksa
            // 
            lblBrojIndeksa.AutoSize = true;
            lblBrojIndeksa.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblBrojIndeksa.Location = new Point(292, 88);
            lblBrojIndeksa.Name = "lblBrojIndeksa";
            lblBrojIndeksa.Size = new Size(83, 32);
            lblBrojIndeksa.TabIndex = 3;
            lblBrojIndeksa.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(292, 172);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 4;
            label3.Text = "Drzava";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(294, 206);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 5;
            label4.Text = "Grad";
            // 
            // cmbDrzava
            // 
            cmbDrzava.FormattingEnabled = true;
            cmbDrzava.Location = new Point(340, 164);
            cmbDrzava.Name = "cmbDrzava";
            cmbDrzava.Size = new Size(193, 23);
            cmbDrzava.TabIndex = 6;
            cmbDrzava.SelectedIndexChanged += cmbDrzava_SelectedIndexChanged;
            // 
            // cmbGrad
            // 
            cmbGrad.FormattingEnabled = true;
            cmbGrad.Location = new Point(340, 203);
            cmbGrad.Name = "cmbGrad";
            cmbGrad.Size = new Size(193, 23);
            cmbGrad.TabIndex = 7;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(425, 254);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(108, 35);
            btnSacuvaj.TabIndex = 8;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += button2_Click;
            // 
            // frmStudentiEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 312);
            Controls.Add(btnSacuvaj);
            Controls.Add(cmbGrad);
            Controls.Add(cmbDrzava);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblBrojIndeksa);
            Controls.Add(lblImePrezime);
            Controls.Add(btnUcitaj);
            Controls.Add(pbSlika);
            Name = "frmStudentiEdit";
            Text = "Podaci o studentu";
            Load += fmrStudentiEdit_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbSlika;
        private OpenFileDialog openFileDialog1;
        private ErrorProvider errorProvider1;
        private Button btnSacuvaj;
        private ComboBox cmbGrad;
        private ComboBox cmbDrzava;
        private Label label4;
        private Label label3;
        private Label lblBrojIndeksa;
        private Label lblImePrezime;
        private Button btnUcitaj;
    }
}
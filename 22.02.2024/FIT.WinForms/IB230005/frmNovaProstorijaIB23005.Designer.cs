namespace FIT.WinForms.IB230005
{
    partial class frmNovaProstorijaIB23005
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
            pbLogo = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            errorProvider1 = new ErrorProvider(components);
            btnSacuvaj = new Button();
            txtNaziv = new TextBox();
            txtOznaka = new TextBox();
            txtKapacitet = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "Logo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(215, 64);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Naziv";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(215, 124);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 2;
            label3.Text = "Oznaka";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(348, 124);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 3;
            label4.Text = "Kapacitet";
            // 
            // pbLogo
            // 
            pbLogo.Location = new Point(12, 46);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(196, 159);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 4;
            pbLogo.TabStop = false;
            pbLogo.Click += pbLogo_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(360, 182);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(75, 23);
            btnSacuvaj.TabIndex = 5;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(215, 82);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(232, 23);
            txtNaziv.TabIndex = 6;
            // 
            // txtOznaka
            // 
            txtOznaka.Location = new Point(215, 142);
            txtOznaka.Name = "txtOznaka";
            txtOznaka.Size = new Size(127, 23);
            txtOznaka.TabIndex = 7;
            // 
            // txtKapacitet
            // 
            txtKapacitet.Location = new Point(348, 142);
            txtKapacitet.Name = "txtKapacitet";
            txtKapacitet.Size = new Size(100, 23);
            txtKapacitet.TabIndex = 8;
            // 
            // frmNovaProstorijaIB23005
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 217);
            Controls.Add(txtKapacitet);
            Controls.Add(txtOznaka);
            Controls.Add(txtNaziv);
            Controls.Add(btnSacuvaj);
            Controls.Add(pbLogo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNovaProstorijaIB23005";
            Text = "frmNovaProstorijaIB23005";
            Load += frmNovaProstorijaIB23005_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pbLogo;
        private OpenFileDialog openFileDialog1;
        private ErrorProvider errorProvider1;
        private TextBox txtKapacitet;
        private TextBox txtOznaka;
        private TextBox txtNaziv;
        private Button btnSacuvaj;
    }
}
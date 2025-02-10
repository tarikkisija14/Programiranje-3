namespace FIT.WinForms.IB230005
{
    partial class frmStudentInfoIB230005
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
            pbSlika = new PictureBox();
            lblIme = new Label();
            lblProsjek = new Label();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            SuspendLayout();
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(24, 20);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(213, 174);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 0;
            pbSlika.TabStop = false;
            // 
            // lblIme
            // 
            lblIme.AutoSize = true;
            lblIme.Font = new Font("Segoe UI", 12F);
            lblIme.Location = new Point(86, 197);
            lblIme.Name = "lblIme";
            lblIme.Size = new Size(52, 21);
            lblIme.TabIndex = 1;
            lblIme.Text = "label1";
            // 
            // lblProsjek
            // 
            lblProsjek.AutoSize = true;
            lblProsjek.Location = new Point(86, 237);
            lblProsjek.Name = "lblProsjek";
            lblProsjek.Size = new Size(38, 15);
            lblProsjek.TabIndex = 2;
            lblProsjek.Text = "label2";
            // 
            // frmStudentInfoIB230005
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 261);
            Controls.Add(lblProsjek);
            Controls.Add(lblIme);
            Controls.Add(pbSlika);
            Name = "frmStudentInfoIB230005";
            Text = "frmStudentInfoIB230005";
            Load += frmStudentInfoIB230005_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbSlika;
        private Label lblIme;
        private Label lblProsjek;
    }
}
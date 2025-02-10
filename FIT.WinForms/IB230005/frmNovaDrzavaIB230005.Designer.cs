namespace FIT.WinForms.IB230005
{
    partial class frmNovaDrzavaIB230005
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
            pbZastava = new PictureBox();
            label2 = new Label();
            txtNaziv = new TextBox();
            cbaktivna = new CheckBox();
            btnSacuvaj = new Button();
            openFileDialog1 = new OpenFileDialog();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbZastava).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Zastava";
            // 
            // pbZastava
            // 
            pbZastava.Location = new Point(12, 40);
            pbZastava.Name = "pbZastava";
            pbZastava.Size = new Size(252, 190);
            pbZastava.TabIndex = 1;
            pbZastava.TabStop = false;
            pbZastava.Click += pbZastava_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 236);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "Naziv";
            // 
            // txtNaziv
            // 
            txtNaziv.BorderStyle = BorderStyle.FixedSingle;
            txtNaziv.Location = new Point(12, 254);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(252, 23);
            txtNaziv.TabIndex = 3;
            // 
            // cbaktivna
            // 
            cbaktivna.AutoSize = true;
            cbaktivna.Location = new Point(12, 283);
            cbaktivna.Name = "cbaktivna";
            cbaktivna.Size = new Size(66, 19);
            cbaktivna.TabIndex = 4;
            cbaktivna.Text = "Aktivna";
            cbaktivna.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(189, 303);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(75, 23);
            btnSacuvaj.TabIndex = 5;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmNovaDrzavaIB230005
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 337);
            Controls.Add(btnSacuvaj);
            Controls.Add(cbaktivna);
            Controls.Add(txtNaziv);
            Controls.Add(label2);
            Controls.Add(pbZastava);
            Controls.Add(label1);
            Name = "frmNovaDrzavaIB230005";
            Text = "Podaci o drzavi";
            Load += frmNovaDrzavaIB230005_Load;
            ((System.ComponentModel.ISupportInitialize)pbZastava).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pbZastava;
        private Label label2;
        private TextBox txtNaziv;
        private CheckBox cbaktivna;
        private Button btnSacuvaj;
        private OpenFileDialog openFileDialog1;
        private ErrorProvider errorProvider1;
    }
}
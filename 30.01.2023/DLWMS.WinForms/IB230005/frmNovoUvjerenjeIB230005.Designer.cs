namespace DLWMS.WinForms.IB230005
{
    partial class frmNovoUvjerenjeIB230005
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
            cmbVrsta = new ComboBox();
            txtSvrha = new TextBox();
            pbUplatnica = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            btnSacuvaj = new Button();
            ((System.ComponentModel.ISupportInitialize)pbUplatnica).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Vrsta uvjerenja";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 66);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 1;
            label2.Text = "Svrha izdavanja";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(209, 20);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 2;
            label3.Text = "SkeniranaUplatnica";
            // 
            // cmbVrsta
            // 
            cmbVrsta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVrsta.FormattingEnabled = true;
            cmbVrsta.Items.AddRange(new object[] { "Vrsta 1", "Vrsta 2", "Vrsta 3", "Vrsta 4", "Vrsat 5" });
            cmbVrsta.Location = new Point(22, 40);
            cmbVrsta.Name = "cmbVrsta";
            cmbVrsta.Size = new Size(170, 23);
            cmbVrsta.TabIndex = 3;
            // 
            // txtSvrha
            // 
            txtSvrha.Location = new Point(23, 88);
            txtSvrha.Multiline = true;
            txtSvrha.Name = "txtSvrha";
            txtSvrha.Size = new Size(169, 184);
            txtSvrha.TabIndex = 4;
            // 
            // pbUplatnica
            // 
            pbUplatnica.Location = new Point(209, 38);
            pbUplatnica.Name = "pbUplatnica";
            pbUplatnica.Size = new Size(520, 233);
            pbUplatnica.TabIndex = 5;
            pbUplatnica.TabStop = false;
            pbUplatnica.Click += pbUplatnica_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(645, 277);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(84, 26);
            btnSacuvaj.TabIndex = 6;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // frmNovoUvjerenjeIB230005
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 312);
            Controls.Add(btnSacuvaj);
            Controls.Add(pbUplatnica);
            Controls.Add(txtSvrha);
            Controls.Add(cmbVrsta);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNovoUvjerenjeIB230005";
            Text = "frmNovoUvjerenjeIB230005";
            Load += frmNovoUvjerenjeIB230005_Load;
            ((System.ComponentModel.ISupportInitialize)pbUplatnica).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbVrsta;
        private TextBox txtSvrha;
        private PictureBox pbUplatnica;
        private ErrorProvider errorProvider1;
        private OpenFileDialog openFileDialog1;
        private Button btnSacuvaj;
    }
}
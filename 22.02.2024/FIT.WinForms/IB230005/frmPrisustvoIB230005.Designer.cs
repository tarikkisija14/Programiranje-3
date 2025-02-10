namespace FIT.WinForms.IB230005
{
    partial class frmPrisustvoIB230005
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
            lblOznaka = new Label();
            lblKapacitet = new Label();
            label3 = new Label();
            label4 = new Label();
            btnDodaj = new Button();
            cmbNastava = new ComboBox();
            cmbStudent = new ComboBox();
            dgvPrisustva = new DataGridView();
            PPV = new DataGridViewTextBoxColumn();
            Student = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            lblIfno = new Label();
            txtInfo = new TextBox();
            btnGenerisi = new Button();
            txtBrojZapisa = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPrisustva).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblOznaka
            // 
            lblOznaka.AutoSize = true;
            lblOznaka.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblOznaka.Location = new Point(15, 38);
            lblOznaka.Name = "lblOznaka";
            lblOznaka.Size = new Size(65, 25);
            lblOznaka.TabIndex = 0;
            lblOznaka.Text = "label1";
            // 
            // lblKapacitet
            // 
            lblKapacitet.AutoSize = true;
            lblKapacitet.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblKapacitet.Location = new Point(387, 38);
            lblKapacitet.Name = "lblKapacitet";
            lblKapacitet.Size = new Size(65, 25);
            lblKapacitet.TabIndex = 1;
            lblKapacitet.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 75);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "Nastava";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(197, 75);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 3;
            label4.Text = "Student";
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(377, 93);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(75, 23);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // cmbNastava
            // 
            cmbNastava.FormattingEnabled = true;
            cmbNastava.Location = new Point(15, 93);
            cmbNastava.Name = "cmbNastava";
            cmbNastava.Size = new Size(171, 23);
            cmbNastava.TabIndex = 5;
            cmbNastava.SelectedIndexChanged += cmbNastava_SelectedIndexChanged;
            // 
            // cmbStudent
            // 
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(197, 93);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(174, 23);
            cmbStudent.TabIndex = 6;
            // 
            // dgvPrisustva
            // 
            dgvPrisustva.AllowUserToAddRows = false;
            dgvPrisustva.AllowUserToDeleteRows = false;
            dgvPrisustva.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrisustva.Columns.AddRange(new DataGridViewColumn[] { PPV, Student });
            dgvPrisustva.Location = new Point(12, 122);
            dgvPrisustva.Name = "dgvPrisustva";
            dgvPrisustva.ReadOnly = true;
            dgvPrisustva.RowTemplate.Height = 25;
            dgvPrisustva.Size = new Size(435, 150);
            dgvPrisustva.TabIndex = 7;
            // 
            // PPV
            // 
            PPV.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PPV.DataPropertyName = "PPV";
            PPV.HeaderText = "PPV";
            PPV.Name = "PPV";
            PPV.ReadOnly = true;
            // 
            // Student
            // 
            Student.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Student.DataPropertyName = "Student";
            Student.HeaderText = "Student";
            Student.Name = "Student";
            Student.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblIfno);
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Controls.Add(btnGenerisi);
            groupBox1.Controls.Add(txtBrojZapisa);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(16, 298);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(431, 269);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator";
            // 
            // lblIfno
            // 
            lblIfno.AutoSize = true;
            lblIfno.Location = new Point(22, 68);
            lblIfno.Name = "lblIfno";
            lblIfno.Size = new Size(28, 15);
            lblIfno.TabIndex = 4;
            lblIfno.Text = "Info";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(17, 91);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(408, 154);
            txtInfo.TabIndex = 3;
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(192, 28);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(75, 23);
            btnGenerisi.TabIndex = 2;
            btnGenerisi.Text = "Generisi";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // txtBrojZapisa
            // 
            txtBrojZapisa.Location = new Point(86, 26);
            txtBrojZapisa.Name = "txtBrojZapisa";
            txtBrojZapisa.Size = new Size(100, 23);
            txtBrojZapisa.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 28);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Broj zapisa";
            // 
            // frmPrisustvoIB230005
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 575);
            Controls.Add(groupBox1);
            Controls.Add(dgvPrisustva);
            Controls.Add(cmbStudent);
            Controls.Add(cmbNastava);
            Controls.Add(btnDodaj);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblKapacitet);
            Controls.Add(lblOznaka);
            Name = "frmPrisustvoIB230005";
            Text = "frmPrisustvoIB230005";
            Load += frmPrisustvoIB230005_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPrisustva).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
            
        }

        #endregion

        private Label lblOznaka;
        private Label lblKapacitet;
        private Label label3;
        private Label label4;
        private Button btnDodaj;
        private ComboBox cmbNastava;
        private ComboBox cmbStudent;
        private DataGridView dgvPrisustva;
        private DataGridViewTextBoxColumn PPV;
        private DataGridViewTextBoxColumn Student;
        private GroupBox groupBox1;
        private Label lblIfno;
        private TextBox txtInfo;
        private Button btnGenerisi;
        private TextBox txtBrojZapisa;
        private Label label1;
    }
}
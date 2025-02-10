namespace FIT.WinForms.IB230005
{
    partial class frmNastavaIB230005
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
            lblOznaka = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnDodaj = new Button();
            dgvNastava = new DataGridView();
            Predmet = new DataGridViewTextBoxColumn();
            Dan = new DataGridViewTextBoxColumn();
            Vrijeme = new DataGridViewTextBoxColumn();
            cmbPredmet = new ComboBox();
            cmbDan = new ComboBox();
            cmbVrijeme = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvNastava).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblOznaka
            // 
            lblOznaka.AutoSize = true;
            lblOznaka.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblOznaka.Location = new Point(12, 9);
            lblOznaka.Name = "lblOznaka";
            lblOznaka.Size = new Size(76, 30);
            lblOznaka.TabIndex = 0;
            lblOznaka.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 1;
            label1.Text = "Predmet";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(216, 55);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 2;
            label2.Text = "Dan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(345, 55);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 3;
            label3.Text = "Vrijeme";
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(472, 73);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(75, 23);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dgvNastava
            // 
            dgvNastava.AllowUserToAddRows = false;
            dgvNastava.AllowUserToDeleteRows = false;
            dgvNastava.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNastava.Columns.AddRange(new DataGridViewColumn[] { Predmet, Dan, Vrijeme });
            dgvNastava.Location = new Point(12, 102);
            dgvNastava.Name = "dgvNastava";
            dgvNastava.ReadOnly = true;
            dgvNastava.RowTemplate.Height = 25;
            dgvNastava.Size = new Size(535, 150);
            dgvNastava.TabIndex = 5;
            // 
            // Predmet
            // 
            Predmet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Predmet.DataPropertyName = "Predmet";
            Predmet.HeaderText = "Predmet";
            Predmet.Name = "Predmet";
            Predmet.ReadOnly = true;
            // 
            // Dan
            // 
            Dan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Dan.DataPropertyName = "Dan";
            Dan.HeaderText = "Dan";
            Dan.Name = "Dan";
            Dan.ReadOnly = true;
            // 
            // Vrijeme
            // 
            Vrijeme.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Vrijeme.DataPropertyName = "Vrijeme";
            Vrijeme.HeaderText = "Vrijeme";
            Vrijeme.Name = "Vrijeme";
            Vrijeme.ReadOnly = true;
            // 
            // cmbPredmet
            // 
            cmbPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPredmet.FormattingEnabled = true;
            cmbPredmet.Location = new Point(12, 73);
            cmbPredmet.Name = "cmbPredmet";
            cmbPredmet.Size = new Size(198, 23);
            cmbPredmet.TabIndex = 6;
            cmbPredmet.SelectedIndexChanged += cmbPredmet_SelectedIndexChanged;
            // 
            // cmbDan
            // 
            cmbDan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDan.FormattingEnabled = true;
            cmbDan.Items.AddRange(new object[] { "Ponedjeljak", "Utorak", "Srijeda", "Cetvrtak", "Petak", "Subota" });
            cmbDan.Location = new Point(216, 73);
            cmbDan.Name = "cmbDan";
            cmbDan.Size = new Size(121, 23);
            cmbDan.TabIndex = 7;
            cmbDan.SelectedIndexChanged += cmbDan_SelectedIndexChanged;
            // 
            // cmbVrijeme
            // 
            cmbVrijeme.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVrijeme.FormattingEnabled = true;
            cmbVrijeme.Items.AddRange(new object[] { "08-10", "10-12", "12-14", "14-16" });
            cmbVrijeme.Location = new Point(345, 73);
            cmbVrijeme.Name = "cmbVrijeme";
            cmbVrijeme.Size = new Size(121, 23);
            cmbVrijeme.TabIndex = 8;
            cmbVrijeme.SelectedIndexChanged += cmbVrijeme_SelectedIndexChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmNastavaIB230005
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 265);
            Controls.Add(cmbVrijeme);
            Controls.Add(cmbDan);
            Controls.Add(cmbPredmet);
            Controls.Add(dgvNastava);
            Controls.Add(btnDodaj);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblOznaka);
            Name = "frmNastavaIB230005";
            Text = "frmNastavaIB230005";
            Load += frmNastavaIB230005_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNastava).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
            
        }

        #endregion

        private Label lblOznaka;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnDodaj;
        private DataGridView dgvNastava;
        private ComboBox cmbPredmet;
        private ComboBox cmbDan;
        private ComboBox cmbVrijeme;
        private ErrorProvider errorProvider1;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Dan;
        private DataGridViewTextBoxColumn Vrijeme;
    }
}
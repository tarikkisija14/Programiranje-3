namespace DLWMS.WinApp.IB230005
{
    partial class frmStudentiAddEdit
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbStudent = new ComboBox();
            cmbGodina = new ComboBox();
            cmbStipendija = new ComboBox();
            btnSacuvaj = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "Student";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Godina";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 90);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 2;
            label3.Text = "Stipendija";
            // 
            // cmbStudent
            // 
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(76, 22);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(277, 23);
            cmbStudent.TabIndex = 3;
            // 
            // cmbGodina
            // 
            cmbGodina.FormattingEnabled = true;
            cmbGodina.Items.AddRange(new object[] { "2025", "2024", "2023", "2022" });
            cmbGodina.Location = new Point(76, 54);
            cmbGodina.Name = "cmbGodina";
            cmbGodina.Size = new Size(277, 23);
            cmbGodina.TabIndex = 4;
            // 
            // cmbStipendija
            // 
            cmbStipendija.FormattingEnabled = true;
            cmbStipendija.Location = new Point(76, 87);
            cmbStipendija.Name = "cmbStipendija";
            cmbStipendija.Size = new Size(277, 23);
            cmbStipendija.TabIndex = 5;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(278, 116);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(75, 28);
            btnSacuvaj.TabIndex = 6;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // frmStudentiAddEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 154);
            Controls.Add(btnSacuvaj);
            Controls.Add(cmbStipendija);
            Controls.Add(cmbGodina);
            Controls.Add(cmbStudent);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmStudentiAddEdit";
            Text = "Dodjela stipendije";
            Load += frmStudentiAddEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbStudent;
        private ComboBox cmbGodina;
        private ComboBox cmbStipendija;
        private Button btnSacuvaj;
    }
}
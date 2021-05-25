namespace HMS
{
    partial class DiagnosisForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DiagId = new System.Windows.Forms.TextBox();
            this.PatientIdCb = new System.Windows.Forms.ComboBox();
            this.PatientTb = new System.Windows.Forms.TextBox();
            this.SymptomsTb = new System.Windows.Forms.TextBox();
            this.MedicinesTb = new System.Windows.Forms.TextBox();
            this.DiagnosisTb = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PatientNamelbl = new System.Windows.Forms.Label();
            this.Symptomslbl = new System.Windows.Forms.Label();
            this.Medicineslbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Diagnosislbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DiagnosisGV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 100);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(417, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "DIAGNOSIS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(308, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hospital Management System ";
            // 
            // DiagId
            // 
            this.DiagId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DiagId.Location = new System.Drawing.Point(43, 116);
            this.DiagId.Name = "DiagId";
            this.DiagId.Size = new System.Drawing.Size(148, 22);
            this.DiagId.TabIndex = 5;
            this.DiagId.Text = "DiagnosisID";
            // 
            // PatientIdCb
            // 
            this.PatientIdCb.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.PatientIdCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.PatientIdCb.FormattingEnabled = true;
            this.PatientIdCb.Items.AddRange(new object[] {
            "MALE",
            "FAMALE"});
            this.PatientIdCb.Location = new System.Drawing.Point(43, 153);
            this.PatientIdCb.Name = "PatientIdCb";
            this.PatientIdCb.Size = new System.Drawing.Size(148, 24);
            this.PatientIdCb.TabIndex = 8;
            this.PatientIdCb.Text = "PATIENTID";
            this.PatientIdCb.SelectionChangeCommitted += new System.EventHandler(this.PatientIdCb_SelectionChangeCommitted);
            // 
            // PatientTb
            // 
            this.PatientTb.Enabled = false;
            this.PatientTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.PatientTb.Location = new System.Drawing.Point(43, 196);
            this.PatientTb.Name = "PatientTb";
            this.PatientTb.Size = new System.Drawing.Size(148, 22);
            this.PatientTb.TabIndex = 9;
            this.PatientTb.Text = "Tên Bệnh Nhân";
            // 
            // SymptomsTb
            // 
            this.SymptomsTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SymptomsTb.Location = new System.Drawing.Point(261, 116);
            this.SymptomsTb.Name = "SymptomsTb";
            this.SymptomsTb.Size = new System.Drawing.Size(148, 22);
            this.SymptomsTb.TabIndex = 10;
            this.SymptomsTb.Text = "Triệu Chứng";
            // 
            // MedicinesTb
            // 
            this.MedicinesTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MedicinesTb.Location = new System.Drawing.Point(261, 196);
            this.MedicinesTb.Name = "MedicinesTb";
            this.MedicinesTb.Size = new System.Drawing.Size(148, 22);
            this.MedicinesTb.TabIndex = 11;
            this.MedicinesTb.Text = "Thuốc";
            // 
            // DiagnosisTb
            // 
            this.DiagnosisTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DiagnosisTb.Location = new System.Drawing.Point(261, 155);
            this.DiagnosisTb.Name = "DiagnosisTb";
            this.DiagnosisTb.Size = new System.Drawing.Size(148, 22);
            this.DiagnosisTb.TabIndex = 12;
            this.DiagnosisTb.Text = "Chuẩn Đoán ";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.Location = new System.Drawing.Point(286, 304);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 47);
            this.button4.TabIndex = 19;
            this.button4.Text = "HOME";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(170, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 47);
            this.button2.TabIndex = 18;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(300, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 47);
            this.button1.TabIndex = 17;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Location = new System.Drawing.Point(43, 234);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 47);
            this.button3.TabIndex = 16;
            this.button3.Text = "ADD";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label3.Location = new System.Drawing.Point(7, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Danh Sách Bệnh Nhân";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PatientNamelbl);
            this.panel2.Controls.Add(this.Symptomslbl);
            this.panel2.Controls.Add(this.Medicineslbl);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.Diagnosislbl);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(415, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 241);
            this.panel2.TabIndex = 22;
            // 
            // PatientNamelbl
            // 
            this.PatientNamelbl.AutoSize = true;
            this.PatientNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.PatientNamelbl.Location = new System.Drawing.Point(54, 95);
            this.PatientNamelbl.Name = "PatientNamelbl";
            this.PatientNamelbl.Size = new System.Drawing.Size(114, 16);
            this.PatientNamelbl.TabIndex = 10;
            this.PatientNamelbl.Text = "Tên Bệnh Nhân";
            // 
            // Symptomslbl
            // 
            this.Symptomslbl.AutoSize = true;
            this.Symptomslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Symptomslbl.Location = new System.Drawing.Point(54, 180);
            this.Symptomslbl.Name = "Symptomslbl";
            this.Symptomslbl.Size = new System.Drawing.Size(91, 16);
            this.Symptomslbl.TabIndex = 9;
            this.Symptomslbl.Text = "Triệu Chứng";
            // 
            // Medicineslbl
            // 
            this.Medicineslbl.AutoSize = true;
            this.Medicineslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Medicineslbl.Location = new System.Drawing.Point(306, 180);
            this.Medicineslbl.Name = "Medicineslbl";
            this.Medicineslbl.Size = new System.Drawing.Size(55, 16);
            this.Medicineslbl.TabIndex = 8;
            this.Medicineslbl.Text = "Thuốc ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(429, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "DATE ";
            // 
            // Diagnosislbl
            // 
            this.Diagnosislbl.AutoSize = true;
            this.Diagnosislbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Diagnosislbl.Location = new System.Drawing.Point(306, 89);
            this.Diagnosislbl.Name = "Diagnosislbl";
            this.Diagnosislbl.Size = new System.Drawing.Size(95, 16);
            this.Diagnosislbl.TabIndex = 6;
            this.Diagnosislbl.Text = "Chuẩn Đoán ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(81, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "DIAGNOSIS SUMMARY";
            // 
            // DiagnosisGV
            // 
            this.DiagnosisGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DiagnosisGV.Location = new System.Drawing.Point(12, 354);
            this.DiagnosisGV.Name = "DiagnosisGV";
            this.DiagnosisGV.Size = new System.Drawing.Size(920, 170);
            this.DiagnosisGV.TabIndex = 23;
            this.DiagnosisGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DiagnosisGV_CellContentClick);
            // 
            // DiagnosisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 536);
            this.Controls.Add(this.DiagnosisGV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.DiagnosisTb);
            this.Controls.Add(this.MedicinesTb);
            this.Controls.Add(this.SymptomsTb);
            this.Controls.Add(this.PatientTb);
            this.Controls.Add(this.PatientIdCb);
            this.Controls.Add(this.DiagId);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiagnosisForm";
            this.Text = "DiagnosisForm";
            this.Load += new System.EventHandler(this.DiagnosisForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DiagId;
        private System.Windows.Forms.ComboBox PatientIdCb;
        private System.Windows.Forms.TextBox PatientTb;
        private System.Windows.Forms.TextBox SymptomsTb;
        private System.Windows.Forms.TextBox MedicinesTb;
        private System.Windows.Forms.TextBox DiagnosisTb;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label PatientNamelbl;
        private System.Windows.Forms.Label Symptomslbl;
        private System.Windows.Forms.Label Medicineslbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Diagnosislbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DiagnosisGV;
    }
}
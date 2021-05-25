namespace HMS
{
    partial class PatientForm
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
            this.PatId = new System.Windows.Forms.TextBox();
            this.PatAge = new System.Windows.Forms.TextBox();
            this.PatPhone = new System.Windows.Forms.TextBox();
            this.PatAd = new System.Windows.Forms.TextBox();
            this.PatName = new System.Windows.Forms.TextBox();
            this.GenderCB = new System.Windows.Forms.ComboBox();
            this.BloodCB = new System.Windows.Forms.ComboBox();
            this.Majo = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PatientGV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 100);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(417, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Patient";
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
            // PatId
            // 
            this.PatId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.PatId.Location = new System.Drawing.Point(48, 140);
            this.PatId.Name = "PatId";
            this.PatId.Size = new System.Drawing.Size(148, 22);
            this.PatId.TabIndex = 2;
            this.PatId.Text = "PATIENTID";
            // 
            // PatAge
            // 
            this.PatAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.PatAge.Location = new System.Drawing.Point(48, 302);
            this.PatAge.Name = "PatAge";
            this.PatAge.Size = new System.Drawing.Size(148, 22);
            this.PatAge.TabIndex = 3;
            this.PatAge.Text = "Tuổi";
            this.PatAge.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // PatPhone
            // 
            this.PatPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.PatPhone.Location = new System.Drawing.Point(48, 260);
            this.PatPhone.Name = "PatPhone";
            this.PatPhone.Size = new System.Drawing.Size(148, 22);
            this.PatPhone.TabIndex = 4;
            this.PatPhone.Text = "Số Điện Thoại";
            // 
            // PatAd
            // 
            this.PatAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.PatAd.Location = new System.Drawing.Point(48, 219);
            this.PatAd.Name = "PatAd";
            this.PatAd.Size = new System.Drawing.Size(148, 22);
            this.PatAd.TabIndex = 5;
            this.PatAd.Text = "Địa Chỉ";
            // 
            // PatName
            // 
            this.PatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.PatName.Location = new System.Drawing.Point(48, 178);
            this.PatName.Name = "PatName";
            this.PatName.Size = new System.Drawing.Size(148, 22);
            this.PatName.TabIndex = 6;
            this.PatName.Text = "Tên Bệnh Nhân";
            // 
            // GenderCB
            // 
            this.GenderCB.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.GenderCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.GenderCB.FormattingEnabled = true;
            this.GenderCB.Items.AddRange(new object[] {
            "MALE",
            "FAMALE"});
            this.GenderCB.Location = new System.Drawing.Point(220, 140);
            this.GenderCB.Name = "GenderCB";
            this.GenderCB.Size = new System.Drawing.Size(148, 24);
            this.GenderCB.TabIndex = 7;
            this.GenderCB.Text = "GENDER";
            // 
            // BloodCB
            // 
            this.BloodCB.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BloodCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BloodCB.FormattingEnabled = true;
            this.BloodCB.Items.AddRange(new object[] {
            "A+",
            "O+",
            "B+",
            "AB+",
            "A-",
            "O-",
            "B-",
            "AB-"});
            this.BloodCB.Location = new System.Drawing.Point(220, 178);
            this.BloodCB.Name = "BloodCB";
            this.BloodCB.Size = new System.Drawing.Size(148, 24);
            this.BloodCB.TabIndex = 8;
            this.BloodCB.Text = "BloodGroup";
            // 
            // Majo
            // 
            this.Majo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Majo.Location = new System.Drawing.Point(220, 219);
            this.Majo.Name = "Majo";
            this.Majo.Size = new System.Drawing.Size(148, 22);
            this.Majo.TabIndex = 9;
            this.Majo.Text = "Bệnh";
            this.Majo.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.Location = new System.Drawing.Point(144, 437);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 47);
            this.button4.TabIndex = 15;
            this.button4.Text = "HOME";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(144, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 47);
            this.button2.TabIndex = 14;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(259, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 47);
            this.button1.TabIndex = 13;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Location = new System.Drawing.Point(29, 371);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 47);
            this.button3.TabIndex = 12;
            this.button3.Text = "ADD";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label3.Location = new System.Drawing.Point(612, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "PATIENTS LIST";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // PatientGV
            // 
            this.PatientGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientGV.Location = new System.Drawing.Point(374, 108);
            this.PatientGV.Name = "PatientGV";
            this.PatientGV.Size = new System.Drawing.Size(582, 416);
            this.PatientGV.TabIndex = 17;
            this.PatientGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientGV_CellContentClick);
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 536);
            this.Controls.Add(this.PatientGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Majo);
            this.Controls.Add(this.BloodCB);
            this.Controls.Add(this.GenderCB);
            this.Controls.Add(this.PatName);
            this.Controls.Add(this.PatAd);
            this.Controls.Add(this.PatPhone);
            this.Controls.Add(this.PatAge);
            this.Controls.Add(this.PatId);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientForm";
            this.Text = "PatientForm";
            this.Load += new System.EventHandler(this.PatientForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PatId;
        private System.Windows.Forms.TextBox PatAge;
        private System.Windows.Forms.TextBox PatPhone;
        private System.Windows.Forms.TextBox PatAd;
        private System.Windows.Forms.TextBox PatName;
        private System.Windows.Forms.ComboBox GenderCB;
        private System.Windows.Forms.ComboBox BloodCB;
        private System.Windows.Forms.TextBox Majo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView PatientGV;
    }
}
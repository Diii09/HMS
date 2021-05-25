namespace HMS
{
    partial class DoctorForm
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
            this.DocId = new System.Windows.Forms.TextBox();
            this.DocName = new System.Windows.Forms.TextBox();
            this.DocExp = new System.Windows.Forms.TextBox();
            this.DocPass = new System.Windows.Forms.TextBox();
            this.DoctorGV = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(58, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(417, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Doctor";
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DocId
            // 
            this.DocId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DocId.Location = new System.Drawing.Point(185, 170);
            this.DocId.Name = "DocId";
            this.DocId.Size = new System.Drawing.Size(148, 22);
            this.DocId.TabIndex = 1;
            this.DocId.Text = "DOCTORID";
            this.DocId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DocName
            // 
            this.DocName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DocName.Location = new System.Drawing.Point(185, 209);
            this.DocName.Name = "DocName";
            this.DocName.Size = new System.Drawing.Size(148, 22);
            this.DocName.TabIndex = 2;
            this.DocName.Text = "Tên Bác Sĩ ";
            // 
            // DocExp
            // 
            this.DocExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DocExp.Location = new System.Drawing.Point(185, 255);
            this.DocExp.Name = "DocExp";
            this.DocExp.Size = new System.Drawing.Size(148, 22);
            this.DocExp.TabIndex = 3;
            this.DocExp.Text = "Năm KN";
            // 
            // DocPass
            // 
            this.DocPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DocPass.Location = new System.Drawing.Point(185, 299);
            this.DocPass.Name = "DocPass";
            this.DocPass.Size = new System.Drawing.Size(148, 22);
            this.DocPass.TabIndex = 4;
            this.DocPass.Text = "PASSWORD";
            // 
            // DoctorGV
            // 
            this.DoctorGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoctorGV.Location = new System.Drawing.Point(518, 159);
            this.DoctorGV.Name = "DoctorGV";
            this.DoctorGV.Size = new System.Drawing.Size(481, 336);
            this.DoctorGV.TabIndex = 5;
            this.DoctorGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DoctorGV_CellContentClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Location = new System.Drawing.Point(84, 383);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 47);
            this.button3.TabIndex = 8;
            this.button3.Text = "ADD";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(382, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 47);
            this.button1.TabIndex = 9;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(234, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 47);
            this.button2.TabIndex = 10;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.Location = new System.Drawing.Point(234, 463);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 47);
            this.button4.TabIndex = 11;
            this.button4.Text = "HOME";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 536);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.DoctorGV);
            this.Controls.Add(this.DocPass);
            this.Controls.Add(this.DocExp);
            this.Controls.Add(this.DocName);
            this.Controls.Add(this.DocId);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorForm";
            this.Load += new System.EventHandler(this.DoctorForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DocId;
        private System.Windows.Forms.TextBox DocName;
        private System.Windows.Forms.TextBox DocExp;
        private System.Windows.Forms.TextBox DocPass;
        private System.Windows.Forms.DataGridView DoctorGV;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
    }
}
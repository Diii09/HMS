namespace HMS
{
    partial class Form1
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
            this.HMS = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.DocNameTb = new System.Windows.Forms.TextBox();
            this.PassTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.HMS);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 100);
            this.panel1.TabIndex = 0;
            // 
            // HMS
            // 
            this.HMS.AutoSize = true;
            this.HMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.HMS.Location = new System.Drawing.Point(102, 40);
            this.HMS.Name = "HMS";
            this.HMS.Size = new System.Drawing.Size(59, 25);
            this.HMS.TabIndex = 0;
            this.HMS.Text = "HMS";
            this.HMS.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(51, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 58);
            this.button2.TabIndex = 1;
            this.button2.Text = "LOGIN";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DocNameTb
            // 
            this.DocNameTb.Location = new System.Drawing.Point(75, 134);
            this.DocNameTb.Name = "DocNameTb";
            this.DocNameTb.Size = new System.Drawing.Size(110, 20);
            this.DocNameTb.TabIndex = 2;
            this.DocNameTb.Text = "DR.Name";
            // 
            // PassTb
            // 
            this.PassTb.Location = new System.Drawing.Point(75, 200);
            this.PassTb.Name = "PassTb";
            this.PassTb.Size = new System.Drawing.Size(110, 20);
            this.PassTb.TabIndex = 3;
            this.PassTb.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(96, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Exist ";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 388);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassTb);
            this.Controls.Add(this.DocNameTb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label HMS;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox DocNameTb;
        private System.Windows.Forms.TextBox PassTb;
        private System.Windows.Forms.Label label1;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        int StartPoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            StartPoint += 1;
            Myprogressbar.Value = StartPoint;
            if(Myprogressbar.Value ==100)
            {
                Myprogressbar.Value = 0;
                timer1.Stop();
                Form1 login = new Form1();
                login.Show();
                this.Hide();
            }
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
    }
}

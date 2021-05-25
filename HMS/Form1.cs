using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HMS
{
    public partial class Form1 : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\CHEESE\Documents\HMSdb.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(DocNameTb.Text==""||PassTb.Text=="")
                MessageBox.Show("Enter a userName and Password");
            else {
                Con.Open();
                SqlDataAdapter sda=new SqlDataAdapter("select Count(*) from DocTorTbl where DocName='"+DocNameTb.Text+"' and DocPass='"+PassTb.Text+"'",Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if(dt.Rows[0][0].ToString()=="1")
                {
                    Home H = new Home();
                    H.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong ");
                }
                Con.Close();
            }
            //Home H = new Home();
            //H.Show();
            //this.Hide();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
             
        }
    }
}

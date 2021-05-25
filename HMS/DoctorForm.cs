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
    public partial class DoctorForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\CHEESE\Documents\HMSdb.mdf;Integrated Security=True;Connect Timeout=30");

        public DoctorForm()
        {
            InitializeComponent();
        }

        void populate()
        {
            Con.Open();
            string query = "select * from DocTorTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DoctorGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
                    }

      
        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DocId.Text == "" || DocName.Text == "" || DocPass.Text == "" || DocExp.Text == "")
                MessageBox.Show("No Empty Fill Accepted ");
            else
            {
                Con.Open();
                string query = "insert into DocTorTbl values(" + DocId.Text + ",'" + DocName.Text + "'," + DocExp.Text + ",'" + DocPass.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Added");
                Con.Close();
                populate();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update DotorTbl set DocName= '" + DocName.Text + "',DocExp ='" + DocExp.Text + "',DocPass='" + DocPass.Text + "' where DocId=" + DocId.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully updated ");
            Con.Close();
            populate();
        }
        private void DoctorForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DocId.Text == "")
                MessageBox.Show("Enter the Doctor ID");
            else
            {
                Con.Open();
                string query = "delete from DocTorTbl where DocId=" + DocId.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully delete ");  
                Con.Close();
                populate();
            }
        }

        private void DoctorGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DocId.Text = DoctorGV.SelectedRows[0].Cells[0].Value.ToString();
            DocName.Text = DoctorGV.SelectedRows[0].Cells[1].Value.ToString();
            DocExp.Text = DoctorGV.SelectedRows[0].Cells[2].Value.ToString();
            DocPass.Text = DoctorGV.SelectedRows[0].Cells[3].Value.ToString();

        }
    }
}

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
    public partial class PatientForm : Form
    {
        public PatientForm()
        {
            InitializeComponent();
        }
     
        void populate()
        {
            Con.Open();
            string query = "select * from PatientTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            PatientGV.DataSource = ds.Tables[0];
            Con.Close();
        }
       

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\CHEESE\Documents\HMSdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void button4_Click(object sender, EventArgs e)
        {
        Home h=new Home();
        h.Show();
        this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PatId.Text == "" || PatName.Text == "" || PatAd.Text == "" || PatPhone.Text == "" ||PatAge.Text=="" ||Majo.Text=="")
                MessageBox.Show("No Empty Fill Accepted ");
            else
            {
                Con.Open();
                string query = "insert into PatientTbl values(" + PatId.Text + ",'" +PatName.Text+ "','" +PatAd.Text+ "','" +PatPhone.Text+ "',"+PatAge.Text+",'"+GenderCB.SelectedItem.ToString()+"','"+BloodCB.SelectedItem.ToString()+"','"+Majo.Text+"')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Added");
                Con.Close();
                populate();
            }
        }
        private void PatientForm_Load(object sender ,EventArgs e)
        {
            populate();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PatId.Text == "")
                MessageBox.Show("Enter the Patient ID");
            else
            {
                Con.Open();
                string query = "delete from PatientTbl where PatId=" + PatId.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully delete ");
                Con.Close();
                populate();
            }
        }

        private void PatientGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatId.Text = PatientGV.SelectedRows[0].Cells[0].Value.ToString();
            PatName.Text = PatientGV.SelectedRows[0].Cells[1].Value.ToString();
            PatAd.Text = PatientGV.SelectedRows[0].Cells[2].Value.ToString();
            PatPhone.Text = PatientGV.SelectedRows[0].Cells[3].Value.ToString();
            PatAge.Text = PatientGV.SelectedRows[0].Cells[4].Value.ToString();
            Majo.Text = PatientGV.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update PatientTbl set PatName= '" + PatName.Text + "',PatAddress ='" + PatAd.Text + "',PatPhone ='" + PatPhone.Text + "',PatAge="+PatAge.Text+",PatGender='"+GenderCB.SelectedItem.ToString()+"',PatBlood='"+BloodCB.SelectedItem.ToString()+"' where PatId=" + PatId.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully updated ");
            Con.Close();
            populate();
        }
    }
}

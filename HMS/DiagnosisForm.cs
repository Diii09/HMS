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
    public partial class DiagnosisForm : Form
    {

        public DiagnosisForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\CHEESE\Documents\HMSdb.mdf;Integrated Security=True;Connect Timeout=30");
        void populatecombo()
        {
            string sql = "select * from PatientTbl";
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("PatId", typeof(int));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                PatientIdCb.ValueMember = "PatId";
                PatientIdCb.DataSource = dt;
                Con.Close();

            }
            catch
            {
            }
        }
        string patname;
        void fecthpatientname()
        {
            Con.Open();
            string mysql = "select * from PatientTbl where PatId=" +PatientIdCb.SelectedValue.ToString()+ "";
            SqlCommand cmd = new SqlCommand(mysql, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                patname = dr["PatName"].ToString();
                PatientTb.Text = patname;
            }
        }


        private void button4_Click_1(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }


        void populate()
        {
            Con.Open();
            string query = "select * from DiagnosisTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DiagnosisGV.DataSource = ds.Tables[0];
            Con.Close();
        }


        ///add 
        private void button3_Click(object sender, EventArgs e)
        {
            if (DiagId.Text == "" || MedicinesTb.Text == "" || DiagnosisTb.Text == "" || PatientTb.Text == "" || MedicinesTb.Text == "")
                MessageBox.Show("No Empty Fill Accepted ");
            else
            {
                Con.Open();
                string query = "insert into DiagnosisTbl values(" + DiagId.Text + "," + PatientIdCb.SelectedValue.ToString() + ",'" + PatientTb.Text + "','" + SymptomsTb.Text + "','" + DiagnosisTb.Text + "','" + MedicinesTb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Added");
                Con.Close();
                populate();
            }
        }



        private void DiagnosisGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DiagId.Text = DiagnosisGV.SelectedRows[0].Cells[0].Value.ToString();
            PatientIdCb.SelectedValue = DiagnosisGV.SelectedRows[0].Cells[1].Value.ToString();
            PatientTb.Text = DiagnosisGV.SelectedRows[0].Cells[2].Value.ToString();
            SymptomsTb.Text = DiagnosisGV.SelectedRows[0].Cells[3].Value.ToString();
            DiagnosisTb.Text = DiagnosisGV.SelectedRows[0].Cells[4].Value.ToString();
            MedicinesTb.Text = DiagnosisGV.SelectedRows[0].Cells[7].Value.ToString();
            PatientNamelbl.Text = DiagnosisGV.SelectedRows[0].Cells[2].Value.ToString();
            Diagnosislbl.Text = DiagnosisGV.SelectedRows[0].Cells[4].Value.ToString();
            Symptomslbl.Text = DiagnosisGV.SelectedRows[0].Cells[3].Value.ToString();
            Medicineslbl.Text = DiagnosisGV.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void PatientIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fecthpatientname();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DiagId.Text == "")
                MessageBox.Show("Enter the Diagnosis Id");
            else
            {
                Con.Open();
                string query = "delete from DiagnosisTbl where DiagId=" + DiagId.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnosis successfully delete ");
                Con.Close();
                populate();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update DiagnosisTbl set Patid= '" + PatientIdCb.SelectedValue.ToString() + ",PatName ='" + PatientTb.Text + "',Symptoms='" + SymptomsTb.Text + "',Diagnosis='" + DiagnosisTb.Text + "',Medicines='" + MedicinesTb.Text + "' where DiagId=" + DiagId.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully updated ");
            Con.Close();
            populate();
        }

        private void DiagnosisForm_Load(object sender, EventArgs e)
        {
            populatecombo();
            populate();
        }
    }
}
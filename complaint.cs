using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class complaint : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source = DELL\SQLEXPRESS; Initial Catalog = meter;Integrated Security=True;");

        public complaint()
        {
            InitializeComponent();
        }

        public void display_data()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            // MessageBox.Show("St");
            cmd.CommandText = "select * from Complaint";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //MessageBox.Show("Success");
            conn.Close();
        }

        private void complaint_Load(object sender, EventArgs e)
        {
            display_data();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            //MessageBox.Show("St");
            cmd.CommandText = "select * from Complaint where AccountNo like '" + textBox7.Text + "' ";
            cmd.ExecuteNonQuery();
            // MessageBox.Show("fk");
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            // type.Text = ;
            while (reader.Read())
            {
            cidd.Text=reader["ComplaintID"].ToString();
            account.Text=reader["AccountNo"].ToString();
            complaints.Text=reader["Complaint"].ToString();
            completed.Text=reader["IsCompleted"].ToString();

            };

            //cmd.ExecuteNonQuery();
            //MessageBox.Show("Data inserted");
            //MessageBox.Show("Success");
            conn.Close();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;            // MessageBox.Show("St");

            cmd.CommandText = "INSERT into Complaint (ComplaintID,AccountNo,Complaint,IsCompleted) values('" + cidd.Text + "','" + account.Text + "','" + complaints.Text + "','" + completed.Text + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data inserted");
           
            conn.Close();
            display_data();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cidd.Text = String.Empty;
            account.Text = String.Empty;
            complaints.Text = String.Empty;
            completed.Text = String.Empty;
            textBox7.Text = String.Empty;


        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            //MessageBox.Show("St");
            cmd.CommandText = "Delete  from Complaint where ComplaintID like '" + cidd.Text + "' ";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Complaint deleted");
            conn.Close();
            display_data();

        }
    }
}

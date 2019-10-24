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
    public partial class AddNewAccountControl : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source = DELL\SQLEXPRESS; Initial Catalog = meter;Integrated Security=True;");

        public AddNewAccountControl()
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
            cmd.CommandText = "select * from Account,Consumer where Account.ConsumerNIC=Consumer.NIC";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //MessageBox.Show("Success");
            conn.Close();
        }

        private void AddNewAccountControl_Load(object sender, EventArgs e)
        {
            display_data();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            //MessageBox.Show("St");
            cmd.CommandText = "select * from Account,Consumer where Account.ConsumerNIC=Consumer.NIC and AccountNo like '" + accountno.Text + "' ";
            cmd.ExecuteNonQuery();
            // MessageBox.Show("fk");
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //MessageBox.Show("Success");
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            accountno.Text = String.Empty;
            type.Text = String.Empty;
            contact.Text = String.Empty;
            nic.Text = String.Empty;
            name.Text = String.Empty;
            address.Text = String.Empty;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            //MessageBox.Show("St");
            cmd.CommandText = "select * from Account,Consumer where Account.ConsumerNIC=Consumer.NIC and AccountNo like '" + accountno.Text + "' ";
            cmd.ExecuteNonQuery();
            // MessageBox.Show("fk");
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            // type.Text = ;
            while (reader.Read())
            {
                contact.Text = reader["Contact"].ToString();
                nic.Text = reader["NIC"].ToString();
                type.Text = reader["Type(commercial)"].ToString();
                name.Text = reader["Name"].ToString();
                address.Text = reader["Address"].ToString();
            }


            // dataGridView1.DataSource = dt;
            //MessageBox.Show("Success");
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

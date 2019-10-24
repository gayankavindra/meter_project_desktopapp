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
    public partial class MeterInfoControl : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source = DELL\SQLEXPRESS; Initial Catalog =meter;Integrated Security=True;");

        public MeterInfoControl()
        {
            InitializeComponent();
        }

        public void display_meterdata()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            // MessageBox.Show("St");
            cmd.CommandText = "select * from Reading";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            //MessageBox.Show("Success");
            conn.Close();
        }
        public void display_consumerdata()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            // MessageBox.Show("St");
            cmd.CommandText = "select * from Consumer";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //MessageBox.Show("Success");
            conn.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CheckBillInfoControl_Load(object sender, EventArgs e)
        {
            display_meterdata();
            display_consumerdata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            //MessageBox.Show("St");
            //cmd.CommandText = "select * from Consumer  where accountno like '" + textBox1.Text + "' and ";
            cmd.CommandText = "select * from Consumer inner join Account on Consumer.NIC = Account.ConsumerNIC where AccountNo like '" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            // MessageBox.Show("fk");
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //MessageBox.Show("Success");
            conn.Close();

            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.Connection = conn;

            //MessageBox.Show("St");
            cmd1.CommandText = "select * from Reading where AccountNo like '" + textBox1.Text + "' ";
            cmd1.ExecuteNonQuery();
            // MessageBox.Show("fk");
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;
            //MessageBox.Show("Success");
            conn.Close();



        }
    }
}

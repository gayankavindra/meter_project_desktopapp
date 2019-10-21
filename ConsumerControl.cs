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
    public partial class ConsumerControl : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source = DELL\SQLEXPRESS; Initial Catalog = larameter;Integrated Security=True;");

        public ConsumerControl()
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
            cmd.CommandText = "select * from consumer";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //MessageBox.Show("Success");
            conn.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;            // MessageBox.Show("St");
         
                cmd.CommandText = "INSERT into consumer  values('" + nic.Text + "','" + name.Text + "','" + contact.Text + "','"+ email.Text + "','" + accountno.Text + "','" + address.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data inserted");
          
            conn.Close();
            display_data();
        }

        private void ConsumerControl_Load_1(object sender, EventArgs e)
        {
            //display_data();
        }
    }
}

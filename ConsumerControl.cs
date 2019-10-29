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
        SqlConnection conn = new SqlConnection(@"Data Source = DELL\SQLEXPRESS; Initial Catalog = meter;Integrated Security=True;");

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
            cmd.CommandText = "select * from Consumer";
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
                        
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            //MessageBox.Show("St");
            cmd.CommandText = "select * from Consumer where NIC like '" + nic.Text + "' ";
            cmd.ExecuteNonQuery();
            // MessageBox.Show("fk");
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //MessageBox.Show("Success");
            conn.Close();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;            // MessageBox.Show("St");
         
                cmd.CommandText = "INSERT into Consumer (NIC,Name,Contact,Address) values('" + nic.Text + "','" + name.Text + "','" + contact.Text + "','" + address.Text + "')";
                cmd.ExecuteNonQuery();
                
          
            conn.Close();
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.Connection = conn;            // MessageBox.Show("St");

            cmd1.CommandText = "INSERT into Account (AccountNo,ConsumerNIC,TypeCommercial) values('" + accountno.Text + "','" + nic.Text + "','" + type.Text + "')";
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Data inserted");

            conn.Close();


            display_data();
        }

        private void ConsumerControl_Load_1(object sender, EventArgs e)
        {
            display_data();
            button5.Enabled = false;
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void accountno_TextChanged(object sender, EventArgs e)
        {

        }

        private void contact_TextChanged(object sender, EventArgs e)
        {

        }

        private void nic_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            //MessageBox.Show("St");
            cmd.CommandText = "select * from Account,Consumer where Account.ConsumerNIC=Consumer.NIC and nic like '" + nic.Text + "' ";
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
                type.Text = reader["Typecommercial"].ToString();
                name.Text = reader["Name"].ToString();
                address.Text = reader["Address"].ToString();
                accountno.Text = reader["AccountNo"].ToString();
            }


            // dataGridView1.DataSource = dt;
            //MessageBox.Show("Success");
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            accountno.Text = String.Empty;
            type.Text = String.Empty;
            contact.Text = String.Empty;
            nic.Text = String.Empty;
            name.Text = String.Empty;
            address.Text = String.Empty;


        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (type.Text != "True" && type.Text != "False")
            {
                MessageBox.Show("Use only True or False for Commercial");
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;            // MessageBox.Show("St");

                cmd.CommandText = "Update Account set AccountNo = '" + accountno.Text + "',TypeCommercial = '" + type.Text + "',ConsumerNIC = '" + nic.Text + "' where ConsumerNIC='" + nic.Text + "'";

                cmd.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                SqlCommand cmd1 = new SqlCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.Connection = conn;            // MessageBox.Show("St");

                cmd1.CommandText = "Update Consumer set NIC='" + nic.Text + "',Name='" + name.Text + "',Contact='" + contact.Text + "',Address='" + address.Text + "' where NIC='" + nic.Text + "'";
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Data Updated");

                conn.Close();
                display_data();
            }
        }
    }
}

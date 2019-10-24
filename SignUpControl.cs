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
    public partial class SignUpControl : UserControl
    {

        SqlConnection conn = new SqlConnection(@"Data Source = DELL\SQLEXPRESS; Initial Catalog =meter;Integrated Security=True;");

        public SignUpControl()
        {
            InitializeComponent();
        }

        private void SignUpControl_Load(object sender, EventArgs e)
        {
            display_data();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            nic.Text= String.Empty;
            password1.Text= String.Empty;
            name.Text=String.Empty;
            staffno.Text= String.Empty;
            contact.Text= String.Empty;
            mail.Text= String.Empty;




        }

        private void staffno_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // SqlConnection conn = new SqlConnection(@"Data Source = DELL\SQLEXPRESS; Initial Catalog = larameter;Integrated Security=True;");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            // MessageBox.Show("St");

            if (password1.Text != password2.Text) {
                MessageBox.Show("Entered 2 different passwords");
            }

            else if (radioButton3.Checked)
            {
                cmd.CommandText = "INSERT into Users (NIC,Password,Name,StaffNo,Contact,email,Usertype) values('" + nic.Text + "','" + password1.Text + "','" + name.Text + "','" + staffno.Text + "','" + contact.Text + "','" + mail.Text + "','admin ')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data inserted");
            }
            else if (radioButton4.Checked) {
                cmd.CommandText = "INSERT into Users (NIC,Password,Name,StaffNo,Contact,email,Usertype) values('" + nic.Text + "','" + password1.Text + "','" + name.Text + "','" + staffno.Text + "','" + contact.Text + "','" + mail.Text + "','superadmin ')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data inserted");
            }
            else
                MessageBox.Show("Please select user type");

           
            
            conn.Close();
            display_data();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void display_data()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            // MessageBox.Show("St");
            cmd.CommandText = "select * from Users";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //MessageBox.Show("Success");
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you don't have NIC use Passport Number or Birth Certificate Number");
        }
    }
}

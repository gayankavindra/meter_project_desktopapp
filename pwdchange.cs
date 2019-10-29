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

namespace WindowsFormsApp1
{
    public partial class aform : Form
    {
        public aform()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source = DELL\SQLEXPRESS; Initial Catalog =meter;Integrated Security=True;");

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != textBox3.Text)
            {
                MessageBox.Show("Re-entered password is not matching");
            }
            else{

                SqlDataAdapter sda = new SqlDataAdapter("Select* from Users WHERE NIC = '" + textBox1.Text + "'AND Password = '" + textBox2.Text + "'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    conn.Open();
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.Connection = conn;            // MessageBox.Show("St");

                    cmd1.CommandText = "Update Users set Password='" + textBox5.Text + "' where NIC='" + textBox1.Text + "'";
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Password changed successfully");

                    conn.Close();


                }
                else
                {
                    MessageBox.Show("Incorrect username and password");
                };
                
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

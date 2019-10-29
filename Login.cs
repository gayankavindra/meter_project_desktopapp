using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;
using System.Data.SqlClient;



namespace WindowsFormsApp1
{
    public partial class Login : Form
    {


        public Login()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void aaaaaaaa_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //  SuperAdminDashboard Dashboardobj = new SuperAdminDashboard();
            //    Dashboardobj.Show();




            SqlConnection conn = new SqlConnection(@"Data Source = DELL\SQLEXPRESS; Initial Catalog =meter;Integrated Security=True;");
            //
            conn.Open();


            if (!superadmin.Checked && !admin.Checked)
            {
                MessageBox.Show("Please select user type");

            }
            else if (superadmin.Checked)
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select* from Users WHERE Usertype like 'superadmin' and NIC = '" + textBox1.Text + "'AND Password = '" + password.Text + "'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1 )
                {
                    this.Hide();
                    SuperAdminDashboard Dashboardobj = new SuperAdminDashboard();
                    Dashboardobj.Show();
                  //  MessageBox.Show("P");

                }
                else
                {
                    MessageBox.Show("Please enter valid username and password");
                };
            }
            else if (admin.Checked)
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select* from Users WHERE Usertype like 'admin' and NIC = '" + textBox1.Text + "'AND Password = '" + password.Text + "'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                
                if (dt.Rows.Count == 1 )
                {
                    this.Hide();
                    AdminDashboard Dashboardobj = new AdminDashboard();
                    Dashboardobj.Show();
                }
                else
                {
                    MessageBox.Show("Please enter valid username and password");
                };
            }
           



            //if (superadmin.Checked) {
            //  SuperAdminDashboard Dashboardobj = new SuperAdminDashboard();
            //Dashboardobj.Show();
            //} else if (admin.Checked) {
            //  AdminDashboard Dashboardobj = new AdminDashboard();
            //Dashboardobj.Show();
            ////}



            
            


           







        //  if (radioButton1.Checked)
        //{
        // AdminDashboard Dashboardobj = new AdminDashboard();
        //this.Hide();
        //  Dashboardobj.Show();

        //}
        //else if (radioButton2.Checked)
        // {
        //   SuperAdminDashboard SuperDashboardobj = new SuperAdminDashboard();
        // this.Hide();
        //SuperDashboardobj.Show();

        //}
        //else
        // {
        //    MessageBox.Show("Please select User type");
        // }
    }



    private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            aform obj = new aform();
            
            obj.Show();


        }
    }
}

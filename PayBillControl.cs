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
    public partial class PayBillControl : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source = DELL\SQLEXPRESS; Initial Catalog = meter;Integrated Security=True;");

        public PayBillControl()
        {
            InitializeComponent();
        }

        private void PayBillControl_Load(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            //MessageBox.Show("St");
            cmd.CommandText = "select Bill.BillID,BillPeriod,BillValue,PaidAmount from Bill,Payment where  Bill.AccountNo=Payment.AccountNo and Bill.BillID=Payment.BillID and Bill.AccountNo like  '" + textBox7.Text + "' ";
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
            cmd1.CommandText = "select SUM (BillValue) from Bill,Payment where  Bill.AccountNo=Payment.AccountNo and Bill.BillID=Payment.BillID and Bill.AccountNo like  '" + textBox7.Text + "' ";
            cmd1.ExecuteNonQuery();
            // MessageBox.Show("fk");
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            //MessageBox.Show(dt1.ToString());
            
            label4.Text = dt1.Rows[0][0].ToString();
            //MessageBox.Show("Success");
            conn.Close();

            conn.Open();
            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.Connection = conn;
            //MessageBox.Show("St");
            cmd2.CommandText = "select SUM (PaidAmount) from Bill,Payment where  Bill.AccountNo=Payment.AccountNo and Bill.BillID=Payment.BillID and Bill.AccountNo like  '" + textBox7.Text + "' ";
            cmd2.ExecuteNonQuery();
            // MessageBox.Show("fk");
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            //MessageBox.Show(dt1.ToString());
            label6.Text = dt2.Rows[0][0].ToString();
            //MessageBox.Show("Success");
            conn.Close();

            int x =Int32.Parse(label4.Text);
            int y =Int32.Parse(label4.Text);
            int z = x - y;

            // label7.Text = z.ToString();
            

            





        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

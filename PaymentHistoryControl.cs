﻿using System;
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
    public partial class PaymentHistoryControl : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source = DELL\SQLEXPRESS; Initial Catalog = meter;Integrated Security=True;");

        public PaymentHistoryControl()
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
            cmd.CommandText = "select * from Payment";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //MessageBox.Show("Success");
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            //MessageBox.Show("St");
            cmd.CommandText = "select * from Payment where AccountNo like '" + textBox7.Text + "' ";
            cmd.ExecuteNonQuery();
            // MessageBox.Show("fk");
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //MessageBox.Show("Success");
            conn.Close();

        }

        private void PaymentHistoryControl_Load(object sender, EventArgs e)
        {
            display_data();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.Connection = conn;            // MessageBox.Show("St");

            cmd1.CommandText = "INSERT into Payment (AccountNo,BillID,PaidAmount,Date) values('" + accountno.Text + "','" + billid.Text + "','" + amount.Text + "','"+ dateTimePicker1.Text + "')";
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Data inserted");

            conn.Close();


            display_data();
        }
    }
}

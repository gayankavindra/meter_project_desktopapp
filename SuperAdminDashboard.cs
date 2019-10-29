using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SuperAdminDashboard : Form
    {
        public SuperAdminDashboard()
        {
            InitializeComponent();
            timer1.Start();
            
        }

        private void ogin_Load(object sender, EventArgs e)
        {
           
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            MeterInfoControl checkbillinfoobj = new MeterInfoControl();
            AddNewPanel(checkbillinfoobj);
        }

        private void AddNewPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);


        }

     

        private void Panel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            LabelTim.Text = dt.ToString("dddd,dd MMMM yyyy");
            LabelDat.Text = dt.ToString("hh:mm:ss tt");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ConsumerControl Userobj = new ConsumerControl();
            AddNewPanel(Userobj);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            SignUpControl Signupobj = new SignUpControl();
            AddNewPanel(Signupobj);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            PayBillControl PayBillobj = new PayBillControl();
            AddNewPanel(PayBillobj);
        }

        private void button14_Click(object sender, EventArgs e)
        {

            Login Loginobj = new Login();
            this.Hide();
            Loginobj.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string message = "Are you sure,you want to exit ?";
            string caption = "Warning message";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            BillHistoryControl BillHistoryobj = new BillHistoryControl();
            AddNewPanel(BillHistoryobj);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            PaymentHistoryControl PaymentHistoryobj = new PaymentHistoryControl();
            AddNewPanel(PaymentHistoryobj);

        }

        private void button19_Click(object sender, EventArgs e)
        {
            //label2.Enabled = true;
            AddNewAccountControl AddNewAccountobj = new AddNewAccountControl();
            AddNewPanel(AddNewAccountobj);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            complaint complaintobj = new complaint();
            AddNewPanel(complaintobj);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            ReadingControl Readingobj = new ReadingControl();
            AddNewPanel(Readingobj);
        }
    }
}

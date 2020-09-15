using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace 酒店管理系统
{
    public partial class PayForm : Form
    {
        int a;
        public PayForm()
        {
            InitializeComponent();
        }

        private void button50_Click(object sender, EventArgs e)
        {
            textBox1.Text = ("50");
        }

        private void button100_Click(object sender, EventArgs e)
        {
            textBox1.Text = ("100");
        }

        private void button200_Click(object sender, EventArgs e)
        {
            textBox1.Text = ("200");
        }

        private void button500_Click(object sender, EventArgs e)
        {
            textBox1.Text = ("500");
        }

        private void paybutton_Click(object sender, EventArgs e)
        {
            a= int.Parse(textBox1.Text);
            this.QRcode_panel.Visible = true;
        }

        private void succs_button_Click(object sender, EventArgs e)
        {
            textBox1.Text = ("0");
            this.QRcode_panel.Visible = false;
            User.recharge(a);
            MessageBox.Show("已充值" + a.ToString() + "元");
        }
    }
}

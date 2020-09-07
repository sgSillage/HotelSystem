using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginRegisterFrame;
using HotelmanageSystem;

namespace ReceptionSection
{
    public partial class 查询会员信息 : Form
    {
        public 查询会员信息()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = this.textBox2.Text;
            if (s == "0") MessageBox.Show("查无此用户，请核实", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                会员信息 form4 = new 会员信息();
                User.user_id = this.textBox2.Text;
                form4.ShowDialog();
            }
            
/*
            if (isUser(string <user_id>s))
            {
                会员信息 form4 = new 会员信息();
                User.user_id = this.textBox2.Text;
                form4.ShowDialog();
            }
            else MessageBox.Show("查无此用户，请核实", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void 查询会员信息_Load(object sender, EventArgs e)
        {

        }
    }
}

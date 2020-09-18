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
    public partial class changPasswordForm : Form
    {
        public changPasswordForm()
        {
            InitializeComponent();
        }

        private void button_chang_Click(object sender, EventArgs e)
        {
            if (textBox_password1.Text==textBox_password2.Text)
            {
                if(User.changPassword(User.id.ToString(), textBox_password1.Text))
                {
                    this.Hide();
                    MessageBox.Show("修改成功");
                }
            }
            else
            {
                MessageBox.Show("两次密码不一致请重新输入");
            }
        }
    }
}

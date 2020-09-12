using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegisterFrame
{
    public partial class FindPassword : Form
    {
        public FindPassword()
        {
            InitializeComponent();
        }

        private void FindPassword_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void buttonFindPCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            string account = textBoxAccount.Text;
            string identity = textBoxIdentity.Text;
            string Newpassword = textBoxNewPassword.Text;
            string NewPassword_re = textBoxNewPassword_re.Text;

            if(account == "")
            {
                MessageBox.Show("请输入账号！", "");
                return;
            }
            else if(identity == "")
            {
                MessageBox.Show("请输入身份证号码！", "");
                return;
            }
            else if (Newpassword == "")
            {
                MessageBox.Show("请输入新密码！", "");
                return;
            }
            else if(NewPassword_re == "")
            {
                MessageBox.Show("请输入两次新密码！", "");
                return;
            }
            else if(Newpassword != NewPassword_re)
            {
                MessageBox.Show("两次输入的密码不一样，请重新输入!", "");
                return;
            }
            else if(Newpassword.Length >20 || Newpassword.Length < 9)
            {
                MessageBox.Show("密码长度不正确，请重新输入！", "");
                return;
            }



        }
    }
}

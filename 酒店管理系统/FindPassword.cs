using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;

namespace LoginRegisterFrame
{
    public partial class FindPassword : Skin_Mac
    {
        private DBLogin dbLogin;
        public FindPassword()
        {
            InitializeComponent();
            dbLogin = new DBLogin();
        }

        private void FindPassword_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    

        private void skinButtonSet_Click(object sender, EventArgs e)
        {
            string account = textBoxAccount.Text;
            string identity = textBoxIdentity.Text;
            string Newpassword = textBoxNewPassword.Text;
            string NewPassword_re = textBoxNewPassword_re.Text;
            bool isID = false;
            bool isIdentity = false;

            if (account == "")
            {
                MessageBox.Show("请输入账号！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (identity == "")
            {
                MessageBox.Show("请输入身份证号码！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Newpassword == "")
            {
                MessageBox.Show("请输入新密码！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (NewPassword_re == "")
            {
                MessageBox.Show("请输入两次新密码！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //身份证
            else if (identity == "")
            {
                MessageBox.Show("请输入身份证号码！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (identity.Length != 18)
            {
                MessageBox.Show("身份证号格式不对，请重新输入！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //密码格式
            else if (Newpassword != NewPassword_re)
            {
                MessageBox.Show("两次输入的密码不一样，请重新输入!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Newpassword.Length > 20 || Newpassword.Length < 9)
            {
                MessageBox.Show("密码长度不正确，请重新输入！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //在数据库中查找id和identity并检查是否配对
            switch (dbLogin.FindIdAndIdentity(account, identity))
            {
                case -1: break;
                case 0: isID = true; break;
                case 1: isID = true; isIdentity = true; break;
            }

            if (isID == false)
            {
                MessageBox.Show("无此用户ID,请重试!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (isID == true && isIdentity == false)
            {
                MessageBox.Show("身份证号码错误，请重试!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (isID && isIdentity)
            {
                dbLogin.ResetPassword(account, Newpassword);
                if (MessageBox.Show("是否立即登录？", "修改成功", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.OK)
                {
                    this.Hide();
                    this.Owner.Show();
                }
            }
        }

        private void skinButtonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }
    }
}

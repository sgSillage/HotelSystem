using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelmanageSystem
{
    public partial class ModifyPasswordForm : Form
    {
        private string kind;//记录类型
        public ModifyPasswordForm()
        {
            InitializeComponent();
            this.kind = "";
        }

        private void rdoUser_CheckedChanged(object sender, EventArgs e)//单选按钮，下同
        {
            if (rdoUser.Checked)
            {
                kind = "用户";
                lblID.Text = "用户账号:";
            }
            else
            {
                kind = "";
                lblID.Text = "账号:";
            }
        }

        private void rdoFront_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoFront.Checked)
            {
                kind = "前台";
                lblID.Text = "前台账号:";
            }
            else
            {
                kind = "";
                lblID.Text = "账号:";
            }
        }

        private void rdoManager_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoManager.Checked)
            {
                kind = "管理员";
                lblID.Text = "管理员账号:";
            }
            else
            {
                kind = "";
                lblID.Text = "账号:";
            }
        }

        private void btnOK_Click(object sender, EventArgs e)//确定按钮
        {
            if (!string.IsNullOrEmpty(txtID.Text) && !string.IsNullOrEmpty(txtNewpassword.Text) && !string.IsNullOrEmpty(txtNewpassword1.Text)&&kind!="")
            {
                if (txtNewpassword.Text == txtNewpassword1.Text)//两次密码一致
                {
                    if (kind == "用户")
                    {
                        //if (isExistID(txtID.Text, "用户"))//存在该账号
                        //{
                        //    ModifyPassword(txtID.Text, txtNewpassword.Text, "用户");
                        MessageBox.Show(txtNewpassword.Text + "修改密码成功！");
                        //}
                        //else
                        //{ 
                        //MessageBox.Show("用户不存在！", "出错提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        //}
                    }
                    else if (kind == "前台")
                    {
                        //if (isExistID(txtID.Text, "前台"))//存在该账号
                        //{
                        //    ModifyPassword(txtID.Text, txtNewpassword.Text, "前台");
                        MessageBox.Show(txtNewpassword.Text + "修改密码成功！");
                        //}
                        //else
                        //{ 
                        //MessageBox.Show("用户不存在！", "出错提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        //}
                    }
                    else
                    {
                        //if (isExistID(txtID.Text, "管理员"))//存在该账号
                        //{
                        //    ModifyPassword(txtID.Text, txtNewpassword.Text, "管理员");
                        MessageBox.Show(txtNewpassword.Text + "修改密码成功！");
                        //}
                        //else
                        //{ 
                        //MessageBox.Show("用户不存在！", "出错提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        //}
                    }

                }
                else//密码不一致
                {
                    MessageBox.Show("两次密码不一致!", "出错提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else//信息不完整
            {
                MessageBox.Show("请输入完整的信息!", "出错提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

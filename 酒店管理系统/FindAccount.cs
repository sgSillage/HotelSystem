using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LoginRegisterFrame
{
    public partial class FindAccount : Form
    {
        public FindAccount()
        {
            InitializeComponent();
        }

        private void FindAccount_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void buttonRegisterCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            bool isFind = false;
            string account = "";

            string connString = "server=localhost; database=mydb;uid=root;pwd=nmb15963.";
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (MySqlCommand FindAccount = new MySqlCommand("select * from user", conn))
                    {
                        MySqlDataReader reader = FindAccount.ExecuteReader();
                        while (reader.Read())
                        {
                            if (textBoxIdentity.Text == reader.GetString("user_identity"))
                            {
                                isFind = true;//找到账号
                                account = reader.GetString("user_id");
                                break;
                            }
                        }
                    }
                conn.Close();
            }

            if (isFind)
            {
                if(MessageBox.Show("您的账号为："+account+"\n是否要找回密码？","提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)
                    ==System.Windows.Forms.DialogResult.OK)
                {
                    FindPassword findPassword = new FindPassword();
                    findPassword.Owner = this.Owner;
                    this.Hide();
                    findPassword.Show();
                }
            }
            else
            {
                MessageBox.Show("未找到该身份证对应的账号\n请重新输入身份证号或者进行注册！", "提示");
            }

        }
    }
}

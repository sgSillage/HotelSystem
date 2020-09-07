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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void buttonRegisterCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void buttonRegisterSure_Click(object sender, EventArgs e)
        {
            string password1 = textBoxPassword.Text;
            string passwordSure = textBoxPasswordSure.Text;
            string name = textBoxName.Text;
            string identity = textBoxIdentityNumber.Text;
            string phoneNumber = textBoxPhoneNumber.Text;
            //判断是否有输入为空的textbox
            if(name=="")
            {
                MessageBox.Show("请输入姓名！", "");
                return;
            }
            else if(identity=="")
            {
                MessageBox.Show("请输入身份证号码！", "");
                return;
            }
            else if(phoneNumber=="")
            {
                MessageBox.Show("请输入手机号码！", "");
                return;
            }
            else if(password1=="")
            {
                MessageBox.Show("请输入密码！", "");
                return;
            }
            else if(passwordSure=="")
            {
                MessageBox.Show("请输入确认密码！", "");
                return;
            }

            if(password1!=passwordSure)
            {
                MessageBox.Show("两次输入的密码不同，请重试！", "");
                return;
            }
            if(password1.Length>20||password1.Length<9)
            {
                MessageBox.Show("输入的密码长度不符，请重试！", "");
                return;
            }

            int count = 1;//count of user
            int sex = 0;//sex of user
            if (comboBoxSex.Text == "男")
                sex = 1;

            string connString = "server=localhost; database=mydb;uid=root;pwd=nmb15963.";
            using (MySqlConnection conn = new MySqlConnection(connString))//计数user数量以形成user_id
            {
                conn.Open();
                using (MySqlCommand countUser = new MySqlCommand("select count(user_id) from user", conn))
                {
                    MySqlDataReader reader = countUser.ExecuteReader();
                    while (reader.Read())
                        count++;
                }
                conn.Close();
            }

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (MySqlCommand registerIdentity = new MySqlCommand())//将信息插入至identity_card的表中
                {
                    string sql = "insert into identity_card values('"+identity+"','"+name+"',"+sex+",'"+phoneNumber+"')";
                    registerIdentity.Connection = conn;
                    registerIdentity.CommandText = sql;
                    registerIdentity.ExecuteNonQuery();
                }

                using (MySqlCommand registerUser = new MySqlCommand())//将信息插入至user的表中
                {
                    string sql = "insert into user values("+count+",'"+identity+"','"+password1+"')";
                    registerUser.Connection = conn;
                    registerUser.CommandText = sql;
                    registerUser.ExecuteNonQuery();
                }
                conn.Close();
            }

        }
    }
}

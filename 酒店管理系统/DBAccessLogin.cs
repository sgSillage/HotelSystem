using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace LoginRegisterFrame
{
    interface DBAccessLogin
    {
        //FormMain界面
        int LoginSystem(int category, string id, string password);//登陆函数
        //FormRegister
        int CountUser();//计数用户
        void insertUserInformation(string name, string identity, string password,string phoneNumber, int sex, int count);//插入用户信息函数
        //FindAccount
        string GetAccount(string identity);//根据身份证号码获取用户ID
        //FindPassword
        int FindIdAndIdentity(string id, string identity);//验证用户ID与身份证号码是否匹配
        void ResetPassword(string id, string password);//修改此id的密码
    }

    class DBLogin : DBAccessLogin
    {

        private const string connString = "server=localhost; database=mydb;uid=root;pwd=nmb15963.";
        public int CountUser()
        {
            int count = 1;
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
            return count;
        }
        public int FindIdAndIdentity(string id, string identity)
        {
            bool isID = false;
            bool isIdentity = false;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                    using (MySqlCommand login = new MySqlCommand("select * from user", conn))
                    {
                        MySqlDataReader reader = login.ExecuteReader();
                        while (reader.Read())
                        {
                            if (id == reader.GetString("user_id"))
                            {
                                isID = true;//找到ID
                                if (identity == reader.GetString("user_identity"))
                                {
                                    isIdentity = true;//身份证号码正确
                                }
                                break;
                            }
                        }
                    }
            }
            if (isID == false)
            {
                return -1;
            }
            else if (isID == true && isIdentity == false)
            {
                return 0;
            }
            else if (isID && isIdentity)
            {
                return 1;
            }
            else return -1;
        }
        public string GetAccount(string identity)
        {
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
                        if (identity == reader.GetString("user_identity"))
                        {
                            account = reader.GetString("user_id");
                            break;
                        }
                    }
                }
                conn.Close();
            }
            return account;
        }
        public void insertUserInformation(string name, string identity, string password,string phoneNumber, int sex, int count)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (MySqlCommand registerIdentity = new MySqlCommand())//将信息插入至identity_card的表中
                {
                    string sql = "insert into identity_card values('@identity','@name',@sex,'@phoneNumber')";
                    registerIdentity.Connection = conn;
                    registerIdentity.CommandText = sql;
                    registerIdentity.ExecuteNonQuery();
                }

                using (MySqlCommand registerUser = new MySqlCommand())//将信息插入至user的表中
                {
                    string sql = "insert into user values(@count,'@identity','@password')";
                    registerUser.Connection = conn;
                    registerUser.CommandText = sql;
                    registerUser.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        public int LoginSystem(int category, string id, string password)
        {
            bool isID = false;
            bool isPassword = false;
            using (MySqlConnection conn = new MySqlConnection(connString)) 
            {
                conn.Open();
                if (category == 1)//顾客登录
                    using (MySqlCommand login = new MySqlCommand("select * from user", conn))
                    {
                        MySqlDataReader reader = login.ExecuteReader();
                        while (reader.Read())
                        {
                            if (id == reader.GetString("user_id"))
                            {
                                isID = true;//找到ID
                                if (password == reader.GetString("user_password"))
                                {
                                    isPassword = true;//密码正确
                                }
                                break;
                            }
                        }
                    }
                else if (category ==2)//前台登录
                    using (MySqlCommand login = new MySqlCommand("select * from front", conn))
                    {
                        MySqlDataReader reader = login.ExecuteReader();
                        while (reader.Read())
                        {
                            if (id == reader.GetString("staff_id"))
                            {
                                isID = true;//找到ID
                                if (password == reader.GetString("password"))
                                {
                                    isPassword = true;//密码正确
                                }
                                break;
                            }
                        }
                    }
                else if (category==3)//管理员登录
                    using (MySqlCommand login = new MySqlCommand("select * from administrator", conn))
                    {
                        MySqlDataReader reader = login.ExecuteReader();
                        while (reader.Read())
                        {
                            if (id == reader.GetString("adm_id"))
                            {
                                isID = true;//找到ID
                                if (password == reader.GetString("admin_password"))
                                {
                                    isPassword = true;//密码正确
                                }
                                break;
                            }
                        }
                    }
                conn.Close();
            }

            if (isID == false)
            {
                return -1;
            }
            else if (isID == true && isPassword == false)
            {
                return 0;
            }
            else if (isID && isPassword)
            {
                return 1;
            }
            else return -1;
        }

        public void ResetPassword(string id, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    string sql = "Update user set user_password=@password where user_id=@id";
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

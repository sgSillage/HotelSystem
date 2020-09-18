using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using ReceptionSection;
using HotelmanageSystem;

namespace LoginRegisterFrame
{
    interface DBAccessLogin
    {
        //FormMain界面
        int LoginSystem(int category, string id, string password);//登陆函数
        //FormRegister
        int CountUser();//计数用户
        void insertUserInformation(string name, string identity, string password, string phoneNumber, int sex, int count);//插入用户信息函数
        //FindAccount
        string GetAccount(string identity);//根据身份证号码获取用户ID
        //FindPassword
        int FindIdAndIdentity(string id, string identity);//验证用户ID与身份证号码是否匹配
        void ResetPassword(string id, string password);//修改此id的密码
        //CheckInRecordForm
        List<CheckInRecord> GetCheckInRecords(string st, string en);
        //restRoom
        List<Room> GetRooms(string st_time, string en_time, string type);
    }

    class DBLogin : DBAccessLogin
    {

        private const string connString = "server=localhost; database=mydb;uid=root;pwd=nmb15963.;Allow User Variables=True";
        public int CountUser()
        {
            int count = 1;
            using (MySqlConnection conn = new MySqlConnection(connString))//计数user数量以形成user_id
            {
                conn.Open();
                using (MySqlCommand countUser = new MySqlCommand("select count(user_id) from user", conn))
                {
                    MySqlDataReader reader = countUser.ExecuteReader();
                    reader.Read();
                    count = reader.GetInt32("count(user_id)") + 1;
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

        public List<CheckInRecord> GetCheckInRecords(string st, string en)
        {
            List<CheckInRecord> checkin_list = new List<CheckInRecord>();
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                cmd.Connection = conn;
                string sql = "select* from lodger_check_in natural join identity_card where lodger_time <= @start_time and leave_time >= @end_time";
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@start_time", st));
                cmd.Parameters.Add(new MySqlParameter("@end_time", en));
                MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行读命令的对象,但是还没有执行命令
                while (reader.Read())//按行执行查询，每次循环查询一行
                {
                    string identity = reader.GetString("identity");
                    string room_id = reader.GetString("room_id");
                    string lodger_time = reader.GetString("lodger_time");
                    string leave_time = reader.GetString("leave_time");
                    string name = reader.GetString("name");
                    CheckInRecord checkin = new CheckInRecord(identity, room_id, lodger_time, leave_time, name);
                    checkin_list.Add(checkin);
                }
            }
            conn.Close();
            return checkin_list;
        }

        public List<Room> GetRooms(string st_time, string en_time, string type)
        {
            List<Room> rooms = new List<Room>();
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                cmd.Connection = conn;
                string sql = "select* from room natural left join reserve where room.status=1 and room.type=@type and (start_time is null or(@st_time<=start_time or @en_time>=final_time));";
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@type", type));
                cmd.Parameters.Add(new MySqlParameter("@st_time", st_time));
                cmd.Parameters.Add(new MySqlParameter("@en_time", en_time));
                MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行读命令的对象,但是还没有执行命令
                while (reader.Read())//按行执行查询，每次循环查询一行
                {
                    string id = reader.GetString("room_id");
                    string room_type = reader.GetString("type");
                    string state;
                    if (reader.GetInt16("status") == 1)
                    {
                        state = "Yes";
                    }
                    else state = "No";
                    Room room = new Room(id, type, state);
                    rooms.Add(room);
                }
            }
            conn.Close();
            return rooms;
        }

        public void insertUserInformation(string name, string identity, string password, string phoneNumber, int sex, int count)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                try
                {
                    using (MySqlCommand registerIdentity = new MySqlCommand())//将信息插入至identity_card的表中
                    {
                        string sql = "insert into identity_card(identity, name, gender, phone) values(@identity,@name,@sex,@phoneNumber)";
                        registerIdentity.Connection = conn;
                        registerIdentity.CommandText = sql;
                        registerIdentity.Parameters.Add(new MySqlParameter("@identity", identity));
                        registerIdentity.Parameters.Add(new MySqlParameter("@name", name));
                        registerIdentity.Parameters.Add(new MySqlParameter("@sex", sex));
                        registerIdentity.Parameters.Add(new MySqlParameter("@phoneNumber", phoneNumber));
                        registerIdentity.ExecuteNonQuery();
                    }

                    using (MySqlCommand registerUser = new MySqlCommand())//将信息插入至user的表中
                    {
                        string sql = "insert into user(user_id, user_identity, user_password, balance) values(@phoneNumber,@identity,@password,0)";
                        registerUser.Connection = conn;
                        registerUser.CommandText = sql;
                        registerUser.Parameters.Add(new MySqlParameter("@phoneNumber", phoneNumber));
                        registerUser.Parameters.Add(new MySqlParameter("@identity", identity));
                        registerUser.Parameters.Add(new MySqlParameter("@password", password));
                        registerUser.ExecuteNonQuery();
                    }
                    MessageBox.Show("注册成功，您的账号是：" + phoneNumber + "。请牢记！");
                }
                catch (MySql.Data.MySqlClient.MySqlException exception)
                {
                    MessageBox.Show("注册失败，也许是您的身份证号已经被注册了？", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                else if (category == 2)//前台登录
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
                else if (category == 3)//管理员登录
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
                    cmd.Parameters.Add(new MySqlParameter("@password", password));
                    cmd.Parameters.Add(new MySqlParameter("@id", id));
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

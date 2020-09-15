using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace WindowsFormsApp1
{
    static class User//此处使用了类的静态成员来使得其他页面得以使用User的属性
    {
        public static int id = 110;
        public static string name = "张三";
        public static string gender;
        public static string phone;
        public static string identity;
        public static int viplevel = 0;
        private const string connString = "server=localhost; database=mydb;uid=root;pwd=nmb15963.";

        public static void setPersonalInfo(String ID)
        {
            String Query = "select name, gender, phone, identity\n" +
                           "from user inner join identity_card\n" +
                           "on user.user_identity=identity_card.identity\n" +
                           "where user.user_id=" + ID + ";";
            using (MySqlConnection conn = new MySqlConnection("server=localhost; database=mydb;uid=root;pwd=nmb15963."))
            {
                conn.Open();
                using (MySqlCommand UserInfo = new MySqlCommand(Query, conn))
                {
                    MySqlDataReader reader = UserInfo.ExecuteReader();
                    reader.Read();
                    name = reader.GetString("name");
                    gender = reader.GetUInt16("gender") == 1 ? "男" : "女";
                    phone = reader.GetString("phone");
                    identity = reader.GetString("identity");
                }
                conn.Close();
            }
            int.TryParse(ID, out id);
        }

        public static string GoodForLevel(int lv)//查询某等级的会员的福利
        {
            //***
            //在membership表里查是否有user_id项，有则返回class值，无则返回0
            string s = "没有特权";
            return s;
        }
        public static int CheckVip(int user_id)//检查某位用户是否为会员
        {
            //***
            //在membership表里查是否有user_id项，有则返回class值，无则返回0
            return 5;
        }
        public static void GetVip(int level, int user_id)//将用户升级为会员
        {
            //***
            //在membership表里插入level，user_id
            MessageBox.Show("升级成功！", "办理结果");
        }
        public static void CancleVip()//取消用户的会员
        {
            MessageBox.Show("注销成功！", "办理结果");
        }
        public static int OrderRoom(int type, int beg_time, int end_time)//预定房间
        {
            int room_id;
            room_id = CheckOrder(type, beg_time, end_time);
            if (room_id != 0)
            {
                GetReserve(id, room_id, beg_time, end_time);
                return 1;
            }
            else
                return 0;
        }
        public static int CheckOrder(int type, int beg_time, int end_time)//查找是否有空闲房间
        {
            //***
            //reserve表和room表做连接，找满足type且在beg_time到end_time之间空闲的房间
            //找到返回房间号，找不到则返回0
            int room_id = 0;
            MySqlConnection conn = new MySqlConnection();
            try
            {
                conn.ConnectionString = connString;
                conn.Open();
                String state = conn.State.ToString();//保存状态信息
                MySqlCommand cmd = new MySqlCommand();//新建一个SQL执行对象
                cmd.Connection = conn;
                cmd.CommandText = "select room_id,start_time,final_time from room outer join reverse where type =@type and status=@status";
                cmd.Parameters.Add(new MySqlParameter("@type", type));
                cmd.Parameters.Add(new MySqlParameter("@status", "Y"));
                MySqlDataReader ord = cmd.ExecuteReader(); //执行查询操作
                while (ord.Read())
                {
                    int s = Convert.ToInt32(ord["start_time"].ToString());
                    int f = Convert.ToInt32(ord["final_time"].ToString());
                    if (!(s > end_time || f < beg_time))
                    {
                        room_id = Convert.ToInt32(ord["room_id"].ToString());
                        break;
                    }
                }

            }
            catch (Exception ex)
            {
                String exMessage = ex.Message.ToString();
            }
            finally
            {
                conn.Close();
            }

            return room_id;
        }
        public static void GetReserve(int user_id, int room_id, int beg_time, int end_time)
        {
            //***
            //在reserve表里插入user_id,room_id,beg_time,end_time
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                cmd.Connection = conn;
                string sql = "insert into reserve values(@u_id,@r_id,@b_time,@e_time)";
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@u_id", user_id.ToString()));
                cmd.Parameters.Add(new MySqlParameter("@r_id", room_id.ToString()));
                cmd.Parameters.Add(new MySqlParameter("@b_time", beg_time.ToString()));
                cmd.Parameters.Add(new MySqlParameter("@e_time", end_time.ToString()));
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            conn.Close();
        }
        public static void GetOrder(int room_id)
        {
            //***
            //把order表里room_id项的status改为住人状态

        }
        public static void CheckOut()//给用户退房
        {
            int RoomNum;
            RoomNum = SearchUserRoom(User.id);
            CheckOutRoom(RoomNum);
        }
        public static void CheckOutRoom(int room_id)//把Room表中room_id的项的状态改为空闲
        {
            if (room_id != 0)
            {
                //***

                MessageBox.Show("退房成功。", "退房结果");

                return;
            }
            MessageBox.Show("退房失败。", "退房结果");
            return;
        }
        public static int SearchUserRoom(int uID)//查询ID为uID的用户目前的住房,并返回房间号
        {
            //***
            return 0;
        }
        public static void SearchOrder(int uid)//查询房间订单
        {
            int roomId = -1;
            int beg_time = -1;
            int end_time = -1;
            int Type = 0;
            int Price = -1;
            String[] RoomTypes = { "单人房", "双人房", "总统套房" };

            //***
            //order表和reserve表做连接，查出user_id=uid的一项将相关信息写入上面声明的变量里    
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from order natural join reserve where user_id=@user_id";
                    cmd.Parameters.Add(new MySqlParameter("@user_id", uid));
                    MySqlDataReader ord = cmd.ExecuteReader();
                    if (ord.Read())
                    {
                        roomId = Convert.ToInt32(ord["room_id"].ToString());
                        beg_time = Convert.ToInt32(ord["start_time"].ToString());
                        end_time = Convert.ToInt32(ord["final_time"].ToString());
                        Type = Convert.ToInt32(ord["type"].ToString());
                        Price = Convert.ToInt32(ord["all_price"].ToString());
                    }
                }
            }

            MessageBox.Show(String.Format("房间号：{0}\n", roomId) +
                            String.Format("入住时间：{0}\n", beg_time) +
                            String.Format("退房时间：{0}\n", end_time) +
                            String.Format("房间类型：{0}\n", RoomTypes[Type]) +
                            String.Format("房间价格：{0}", Price));

        }
        public static int SearchRecord()//查询入住记录
        {

            //只需要查lodger_check_in表就可以了 ^w^

            String Query = "select *\n" +
                           "from lodger_check_in\n" +
                           "where identity=" + identity + ";";
            bool HaveRecord = false;
            using (MySqlConnection conn = new MySqlConnection("server=localhost; database=mydb;uid=root;pwd=nmb15963."))
            {
                conn.Open();
                using (MySqlCommand Record = new MySqlCommand(Query, conn))
                {
                    MySqlDataReader reader = Record.ExecuteReader();
                    while (reader.Read())
                    {
                        DateTime lodger_time = reader.GetDateTime("lodger_time");
                        DateTime leave_time = reader.GetDateTime("leave_time");
                        String RoomId = reader.GetString("room_id");
                        MessageBox.Show("入住时间：" + lodger_time.ToString("yyyy-MM-dd") + "\n" +
                                        "退房时间：" + leave_time.ToString("yyyy-MM-dd") + "\n" +
                                        "房间号：" + RoomId);
                        HaveRecord = true;
                    }
                }
                conn.Close();
            }


            //MessageBox.Show(id + name + identity + phone + gender);
            if (!HaveRecord)
                MessageBox.Show("无入住记录。。。");
            return 0;
        }
        public static void Comment(DateTime time, int user_id, string s, int star)//评论
        {
            //***

            ////向evaluate表中插入信息,见参数列表
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                string sql = "Insert into evaluate values('" + time + "','" + user_id + "','"
                    + s + "','" + star + "')";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            conn.Close();
            ////向评论表中插入信息
            ///
            MessageBox.Show("评论成功。");
            return;
        }
        public static void ChangeRoom(int level, int beg_time, int end_time)//给用户更换房间
        {
            int room;
            room = CheckOrder(level, beg_time, end_time);
            if (room != 0)
            {

            }
        }
        public static int AppforSev(int uid, int type)//申请服务                
        {
            //***
            //在ser_order表中插入一列新数据，参见参数列表，ser_order_id自动增加，时间使用系统时间
            //再将ser_order_id返回
            MessageBox.Show("申请成功！", "办理结果");
            return 0;
        }


    }
}

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
        public static double discount = 1;

        static string state;
        static string exMessage;
        /*public static int Id
        {
            get
            {
                return Id;
            }
            set
            {
                Id = value;
            }
        }
        public static string Name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        public static string Gender
        {
            get
            {
                return Gender;
            }
            set
            {
                Gender = value;
            }
        }
        public static string Phone
        {
            get
            {
                return Phone;
            }
            set
            {
                Phone = value;
            }
        }
        public static string Identity
        {
            get
            {
                return Identity;
            }
            set
            {
               Identity = value;
            }
        }*/
        private const String connStr = "server=localhost;database=mydb;uid=root;pwd=123";
        public static void GetReserve(int user_id, int room_id, int beg_time, int end_time) //在reserve表里插入user_id,room_id,beg_time,end_time
        {
            MySqlConnection conn = new MySqlConnection(connStr);
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
        public static void GetOrder(int room_id)//把room表里room_id项的status改为住人状态
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                cmd.Connection = conn;
                string sql = "update order set status =  '已被入住' where room_id = @r_id";
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@r_id", room_id.ToString()));
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
        public static void CheckOutRoom(int room_id)//把Room表中room_id的项的状态改为空闲
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                cmd.Connection = conn;
                string sql = "update room set status = '空闲' where room_id = @r_id";
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("r_id", room_id.ToString()));
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

        public static int CheckVip(int uid)
        {
            int VIPclass = 0;

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from membership where user_id=@user_id";
                    cmd.Parameters.Add(new MySqlParameter("@user_id", uid));
                    MySqlDataReader ord = cmd.ExecuteReader();
                    if (ord.Read())
                    {
                        VIPclass = Convert.ToInt32(ord["class"].ToString());
                    }
                }
            }
            return VIPclass;

            //***
            //在membership表里查是否有user_id=uid项，有则返回class值，无则返回0
        }
        public static void GetVip(int level, int uid)
        {
            //***
            //在membership表里插入level，uid
            int record;
            if (level == 1)
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "insert into membership(user_id, class) values(@user_id,@class)";
                        cmd.Parameters.Add(new MySqlParameter("@user_id", uid));
                        cmd.Parameters.Add(new MySqlParameter("@class", level));
                        record = cmd.ExecuteNonQuery();//返回的是受影响的行数
                    }
                }
            }
            else if (level > 5)
            {
                MessageBox.Show("您已是最高级会员");
            }
            else
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conn;//update room set status = '空闲' where room_id = @r_id
                        cmd.CommandText = "UPDATE membership SET class = @class WHERE user_id = @user_id;";
                        cmd.Parameters.Add(new MySqlParameter("@user_id", uid));
                        cmd.Parameters.Add(new MySqlParameter("@class", level));
                        record = cmd.ExecuteNonQuery();//返回的是受影响的行数
                    }
                }
            }
            User.viplevel = CheckVip(User.id);
            return;
        }
        public static void CancleVip(int uid)
        {
            //***
            //在membership表里插入删除user_id=uid的项
            int record;
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "Delete from membership where user_id=@user_id";
                    cmd.Parameters.Add(new MySqlParameter("@user_id", uid));
                    record = cmd.ExecuteNonQuery();//返回的是受影响的行数
                }
            }
            User.viplevel = CheckVip(User.id);
            return;
        }

        public static int CheckOrder(int type, int beg_time, int end_time)
        {
            //***
            //reserve表和room表做连接，找满足type且在beg_time到end_time之间空闲的房间
            //找到返回房间号，找不到则返回0
            int room_id = 0;
            MySqlConnection conn = new MySqlConnection();
            try
            {
                conn.ConnectionString = connStr;
                conn.Open();
                state = conn.State.ToString();//保存状态信息
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
                exMessage = ex.Message.ToString();
            }
            finally
            {
                conn.Close();
            }

            return room_id;
        }
        public static int SearchUserRoom(int uID)//查询ID为uID的用户目前的住房,并返回房间号
        {
            int room_id2 = 0;
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                cmd.Connection = conn;
                string sql = "select room_id from reserve where user_id = '" + uID + "'";
                cmd.CommandText = sql;
                MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行读命令的对象,但是还没有执行命令
                string room_id1 = "";
                while (reader.Read())//按行执行查询，每次循环查询一行
                {
                    room_id1 = reader.GetString("room_id");
                    room_id2 = int.Parse(room_id1);//转换为int
                }
            }
            conn.Close();
            return room_id2;
        }
        public static string AppforSev(int uid, string type)//申请服务                
        {
            //***
            //在ser_order表中插入一列新数据，参见参数列表，ser_order_id自动增加，时间使用系统时间//ser_id自动添加需要建立个类，
            //再将ser_order_id返回
            string ser_id;
            DateTime t = DateTime.Now;      //获取当前时间，格式为“年/月/日 星期 时/分/秒”

            ser_id = uid.ToString() + t.ToString();
            ser_id = ser_id.Replace(" ","");
            ser_id = ser_id.Replace("/", "");
            ser_id = ser_id.Replace(":", "");
            //MessageBox.Show(ser_id);
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                string sql = "Insert into ser_order values('" + ser_id + "','" + uid + "','"
                    + type + "','" + t + "')";
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
            return ser_id;
        }
        public static void SearchOrder(int uid)//查询房间订单
        {
            int roomId;
            int beg_time;
            int end_time;
            int Type;
            int Price;
            //***
            //order表和reserve表做连接，查出user_id=uid的一项将相关信息写入上面声明的变量里    
            using (MySqlConnection conn = new MySqlConnection(connStr))
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
        }
        public static string PrivilegeForLevel(int uid)//查询某等级的会员的福利
        {
            //***
            //在membership表里查是否有uid项，有则将福利内容赋予s
            string s = "没有特权";
            return s;
        }
        /*public static int CheckVip(int user_id)//检查某位用户是否为会员
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
        }*/
        public static int OrderRoom(int type, int beg_time, int end_time)//预定房间
        {
            int Order_id;
            int user_id;
            int room_id;
            room_id = CheckOrder(type, beg_time, end_time);
            if (room_id != 0)
            {

            }
            return 0;
        }
        /*public static int CheckOrder(int type, int beg_time, int end_time)//查找是否有空闲房间
        {
            //***
            //reserve表和room表做连接，找满足type且在beg_time到end_time之间空闲的房间
            //找到返回房间号，找不到则返回0
            return 0;
        }
        public static void GetReserve(int user_id, int room_id, int beg_time, int end_time)
        {
            //***
            //在reserve表里插入user_id,room_id,beg_time,end_time
        }
        public static void GetOrder(int room_id)
        {
            //***
            //把order表里room_id项的status改为住人状态
        }*/
        public static void CheckOut()//给用户退房
        {
            int RoomNum;
            RoomNum = SearchUserRoom(User.id);
            CheckOutRoom(RoomNum);
        }
        /*public static void CheckOutRoom(int room_id)//把Room表中room_id的项的状态改为空闲
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
            MessageBox.Show(String.Format("房间号：{0}\n", roomId) +
                            String.Format("入住时间：{0}\n", beg_time) +
                            String.Format("退房时间：{0}\n", end_time) +
                            String.Format("房间类型：{0}\n", RoomTypes[Type]) +
                            String.Format("房间价格：{0}", Price));
        }*/
        public static int SearchRecord()//查询入住记录
        {
            MessageBox.Show("无入住记录。。。");
            return 0;
        }
        public static void Comment(DateTime time, int user_id, string s, int star)//评论
        {
            ////向evaluate表中插入信息,见参数列表
            MySqlConnection conn = new MySqlConnection(connStr);
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
        public static void recharge(int money)
        {
            int realMoney;
            realMoney = (searchWallet(id) + money);
            updateWallet(realMoney,id);
            
        }
        public static bool pay(int money)
        {
            int realMoney;
            realMoney = (searchWallet(id) - money);
            if (realMoney < 0)
            {
                MessageBox.Show("余额不足");
                return false;
            }
            else
            {
                updateWallet(realMoney, id);
                MessageBox.Show("支付成功");
                return true;
            }
            
        }
        public static void updateWallet(int money, int uid)
        {
            int record;
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "update user set balance=@b where user_id=@id";
                    cmd.Parameters.Add(new MySqlParameter("@b", money));
                    cmd.Parameters.Add(new MySqlParameter("@id", uid));
                    record = cmd.ExecuteNonQuery();//返回的是受影响的行数
                }
                conn.Close();
            }
        }
        public static int searchWallet(int uid)
        {
            int price = -1;
            MySqlConnection conn = new MySqlConnection();
            try
            {
                conn.ConnectionString = connStr;
                conn.Open();
                state = conn.State.ToString();//保存状态信息
                MySqlCommand cmd = new MySqlCommand();//新建一个SQL执行对象
                cmd.Connection = conn;
                cmd.CommandText = "select balance from user where user_id =@id";
                cmd.Parameters.Add(new MySqlParameter("@id", uid));
                MySqlDataReader ord = cmd.ExecuteReader(); //执行查询操作
                while (ord.Read())
                {
                    string a = ord["balance"].ToString();
                    price = Convert.ToInt32(a);
                }

            }
            catch (Exception ex)
            {
                exMessage = ex.Message.ToString();
                //MessageBox.Show(exMessage);
            }
            finally
            {
                conn.Close();
            }
            return price;
        }
        public static int searchServiceMoney(string type)
        {
            int money = 0;
            MySqlConnection conn = new MySqlConnection();
            try
            {
                conn.ConnectionString = connStr;
                conn.Open();
                state = conn.State.ToString();//保存状态信息
                MySqlCommand cmd = new MySqlCommand();//新建一个SQL执行对象
                cmd.Connection = conn;
                cmd.CommandText = "select ser_money from service where ser_type =@type";
                cmd.Parameters.Add(new MySqlParameter("@type", type));
                MySqlDataReader ord = cmd.ExecuteReader(); //执行查询操作
                while (ord.Read())
                {
                    money = Convert.ToInt32(ord["ser_money"]);
                }

            }
            catch (Exception ex)
            {
                exMessage = ex.Message.ToString();
                MessageBox.Show(exMessage);
            }
            finally
            {
                conn.Close();
            }
            return money;
        }
        public static int searchMembershipCost(int type)
        {
            int cost = 0;
            MySqlConnection conn = new MySqlConnection();
            try
            {
                conn.ConnectionString = connStr;
                conn.Open();
                state = conn.State.ToString();//保存状态信息
                MySqlCommand cmd = new MySqlCommand();//新建一个SQL执行对象
                cmd.Connection = conn;
                cmd.CommandText = "select cost from membership_class where class =@type";
                cmd.Parameters.Add(new MySqlParameter("@type", type));
                MySqlDataReader ord = cmd.ExecuteReader(); //执行查询操作
                while (ord.Read())
                {
                    cost = Convert.ToInt32(ord["cost"]);
                }

            }
            catch (Exception ex)
            {
                exMessage = ex.Message.ToString();
                MessageBox.Show(exMessage);
            }
            finally
            {
                conn.Close();
            }
            return cost;
        }
        public static void setPersonalInfo(String ID)
        {
            String Query = "select name, gender, phone, identity\n" +
                           "from user inner join identity_card\n" +
                           "on user.user_identity=identity_card.identity\n" +
                           "where user.user_id=" + ID + ";";
            using (MySqlConnection conn = new MySqlConnection(connStr))
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
        public static int searchMembershipDiscount(int type)
        {
            int discount = 10;
            MySqlConnection conn = new MySqlConnection();
            try
            {
                conn.ConnectionString = connStr;
                conn.Open();
                state = conn.State.ToString();//保存状态信息
                MySqlCommand cmd = new MySqlCommand();//新建一个SQL执行对象
                cmd.Connection = conn;
                cmd.CommandText = "select discount from membership_class where class =@type";
                cmd.Parameters.Add(new MySqlParameter("@type", type));
                MySqlDataReader ord = cmd.ExecuteReader(); //执行查询操作
                while (ord.Read())
                {
                    discount = Convert.ToInt32(ord["discount"]);
                }

            }
            catch (Exception ex)
            {
                exMessage = ex.Message.ToString();
                MessageBox.Show(exMessage);
            }
            finally
            {
                conn.Close();
            }
            //MessageBox.Show(discount.ToString());
            return discount;
        }
    }
}

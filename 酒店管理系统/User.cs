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
        public static string id = "19946254560";
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
        private const String connStr = "server=localhost;database=mydb;uid=root;pwd=nmb15963.;Allow User Variables=True";
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

        public static int CheckVip(string uid)
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
        public static void GetVip(int level, string uid)
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
        public static void CancleVip(string uid)
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

        public static string CheckOrder(string type, DateTime beg_time, DateTime end_time)
        {
            //***
            //找满足type且在beg_time到end_time之间空闲的房间
            //找到返回房间号，找不到则返回0
            string room_id = "#";
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = connStr;
            conn.Open();
            state = conn.State.ToString();//保存状态信息
            using (MySqlCommand cmd = new MySqlCommand())//新建一个SQL执行对象
            {
                cmd.Connection = conn;
                cmd.CommandText = "select room_id from room natural left join mydb.reserve where type =@type and status=1" +
                    " and (start_time is null or ( @end_time  < start_time or @beg_time > final_time))";
                cmd.Parameters.Add(new MySqlParameter("@type", type));
                cmd.Parameters.Add(new MySqlParameter("@end_time", end_time.ToString()));
                MessageBox.Show(type+" "+end_time.ToString());
                cmd.Parameters.Add(new MySqlParameter("@start_time", beg_time.ToString()));
                MessageBox.Show(beg_time.ToShortDateString());

                MySqlDataReader ord = cmd.ExecuteReader(); //执行查询操作
                if (ord.Read())
                {
                    room_id = ord.GetString("room_id");
                }

            }
            conn.Close();
            MessageBox.Show(room_id.ToString());
            return room_id;
        }
        public static int SearchUserRoom(string uID)//查询ID为uID的用户目前的住房,并返回房间号
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
                if(reader.Read())//按行执行查询，每次循环查询一行
                {
                    room_id1 = reader.GetString("room_id");
                    room_id2 = int.Parse(room_id1);//转换为int
                }
            }
            conn.Close();
            return room_id2;
        }
        public static string AppforSev(string uid, string type)//申请服务                
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
        public static void Searchsss(int uid)//查询房间订单
        {
            string order_id;
            string user_id;
            string order_time;
            string Type;
            int Price;
            //***
            //order表和reserve表做连接，查出user_id=uid的一项将相关信息写入上面声明的变量里    
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from mydb.order where user_id=@user_id";
                    cmd.Parameters.Add(new MySqlParameter("@user_id", uid.ToString()));
                    MySqlDataReader ord = cmd.ExecuteReader();
                    if (ord.Read())
                    {
                        order_id = ord["order_id"].ToString();
                        user_id = ord["user_id"].ToString();
                        order_time = ord["order_time"].ToString();
                        Type = ord["type"].ToString();
                        Price = Convert.ToInt32(ord["all_price"]);
                    }
                }
            }
        }
        public static string PrivilegeForUser(string uid)//查询某等级的会员的福利
        {
            //***
            //在membership表里查是否有uid项，有则将福利内容赋予s
            string s = "没有特权";
            MySqlConnection conn = new MySqlConnection();
            try
            {
                conn.ConnectionString = connStr;
                conn.Open();
                state = conn.State.ToString();//保存状态信息
                MySqlCommand cmd = new MySqlCommand();//新建一个SQL执行对象
                cmd.Connection = conn;
                cmd.CommandText = "select welfare from membership natural join membership_class where user_id=@user_id";
                cmd.Parameters.Add(new MySqlParameter("@user_id", uid));
                MySqlDataReader ord = cmd.ExecuteReader(); //执行查询操作
                while (ord.Read())
                {
                    s = ord["welfare"].ToString();
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
        public static string OrderRoom(string type, DateTime beg_time, DateTime end_time)//预定房间
        {
            string room_id;
            room_id = CheckOrder(type, beg_time, end_time);
            if (room_id.Length > 1)
            {
                insertReserve(id.ToString(),room_id,beg_time.ToLongDateString(),end_time.ToLongDateString());
                //MessageBox.Show(room_id);
            }
            return room_id;
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
        public static List<userOrder> SearchOrder(string uid)//查询入住记录
        {
            List<userOrder> userOrders = new List<userOrder>();
            MySqlConnection conn = new MySqlConnection();
            try
            {
                conn.ConnectionString = connStr;
                conn.Open();
                state = conn.State.ToString();//保存状态信息
                MySqlCommand cmd = new MySqlCommand();//新建一个SQL执行对象
                cmd.Connection = conn;
                cmd.CommandText = "select order.type,order_time,all_price from mydb.order where user_id =@id";//sql语句
                cmd.Parameters.Add(new MySqlParameter("@id", uid));
                MySqlDataReader ord = cmd.ExecuteReader(); //执行查询操作
                while (ord.Read())
                {
                    userOrder userOrder = new userOrder(ord["type"].ToString(), ord["order_time"].ToString(), ord["all_price"].ToString());
                    userOrders.Add(userOrder);
                    //MessageBox.Show(ord["type"].ToString());
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
            
            return userOrders;
        }
        public static void Comment(DateTime time, string user_id, string s, int star)//评论
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
        public static void ChangeRoom(string level, DateTime beg_time, DateTime end_time)//给用户更换房间
        {
            string room;
            room = CheckOrder(level, beg_time, end_time);
            if (room.Length != 0)
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
        public static void updateWallet(int money, string uid)
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
        public static int searchWallet(string uid)
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
                    if (reader.Read())
                    {
                        name = reader.GetString("name");
                        gender = reader.GetUInt16("gender") == 1 ? "男" : "女";
                        phone = reader.GetString("phone");
                        identity = reader.GetString("identity");
                    }
                   
                }
                conn.Close();
            }
            id = ID;
        }
        static void insertReserve(string user_id, string room_id, string start_time, string final_time)
        {
            //以下为根据函数参数在reserve表中插入数据
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                cmd.Connection = conn;
                string sql = "insert into reserve values(@u_id,@r_id,@s_time,@f_time)";
                cmd.Parameters.Add(new MySqlParameter("@u_id", user_id));
                cmd.Parameters.Add(new MySqlParameter("@r_id", room_id));
                cmd.Parameters.Add(new MySqlParameter("@s_time", start_time));
                cmd.Parameters.Add(new MySqlParameter("@f_time", final_time));
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
        public static List<Reserve> GetReserves(string user_id)
        {
            List<Reserve> reserves=new List<Reserve>();
            MySqlConnection conn = new MySqlConnection();
            try
            {
                conn.ConnectionString = connStr;
                conn.Open();
                state = conn.State.ToString();//保存状态信息
                MySqlCommand cmd = new MySqlCommand();//新建一个SQL执行对象
                cmd.Connection = conn;
                cmd.CommandText = "select room_id,start_time,final_time from reserve where user_id=@user_id and start_time>=@start_time";
                cmd.Parameters.Add(new MySqlParameter("@user_id", user_id));
                cmd.Parameters.Add(new MySqlParameter("@start_time", DateTime.Now.ToShortDateString()));
                MySqlDataReader ord = cmd.ExecuteReader(); //执行查询操作
                while (ord.Read())
                {
                    DateTime start_time = Convert.ToDateTime(ord["start_time"].ToString());
                    DateTime end_time= Convert.ToDateTime(ord["final_time"].ToString());
                    Reserve reserve = new Reserve(ord["room_id"].ToString(),start_time.ToShortDateString(), end_time.ToShortDateString());
                    reserves.Add(reserve);
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
            return reserves;
        }
        public static void deleteReserve(string user_id,string room_id,string start_time)
        {
            MySqlConnection conn = new MySqlConnection();
            try
            {
                conn.ConnectionString = connStr;
                conn.Open();
                state = conn.State.ToString();//保存状态信息
                MySqlCommand cmd = new MySqlCommand();//新建一个SQL执行对象
                cmd.Connection = conn;
                cmd.CommandText = "delete  from reserve where user_id=@user_id and room_id=@room_id and start_time>=@start_time";
                cmd.Parameters.Add(new MySqlParameter("@user_id", user_id));
                cmd.Parameters.Add(new MySqlParameter("@room_id", room_id));
                cmd.Parameters.Add(new MySqlParameter("@start_time", start_time));
                cmd.ExecuteNonQuery();
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
        }
        public static bool changPassword(string uid, string password)
        {
            int record = 0;
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                cmd.Connection = conn;
                string sql = "update user set user_password = @password where user_id = @uid";
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@password", password));
                cmd.Parameters.Add(new MySqlParameter("@uid", uid));
                try
                {
                    record = cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            conn.Close();
            if (record == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public static void getInformation()
        {
            MySqlConnection conn = new MySqlConnection();
            try
            {
                conn.ConnectionString = connStr;
                conn.Open();
                state = conn.State.ToString();//保存状态信息
                MySqlCommand cmd = new MySqlCommand();//新建一个SQL执行对象
                cmd.Connection = conn;
                cmd.CommandText = "select * from user natural join identity_card where user_id=@user_id and user_identity=identity";
                cmd.Parameters.Add(new MySqlParameter("@user_id", id));
                MySqlDataReader ord = cmd.ExecuteReader(); //执行查询操作
                while (ord.Read())
                {
                    identity = ord["identity"].ToString();
                    name = ord["name"].ToString();
                    gender = ord["gender"].ToString();
                    phone = ord["phone"].ToString();
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
        }
        public static bool changePhone(string new_phone)
        {
            int record = 0;
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                cmd.Connection = conn;
                string sql = "update identity_card set phone = @phone where identity = @identity";
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@identity", identity));
                cmd.Parameters.Add(new MySqlParameter("@phone", new_phone));
                try
                {
                    record = cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            conn.Close();
            if (record == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

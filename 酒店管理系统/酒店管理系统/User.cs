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
            int Order_id;
            int user_id;
            int room_id;
            room_id = CheckOrder(type, beg_time, end_time);
            if (room_id != 0)
            {

            }
            return 0;
        }
        public static int CheckOrder(int type, int beg_time, int end_time)//查找是否有空闲房间
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
            MessageBox.Show(String.Format("房间号：{0}\n", roomId) +
                            String.Format("入住时间：{0}\n", beg_time) +
                            String.Format("退房时间：{0}\n", end_time) +
                            String.Format("房间类型：{0}\n", RoomTypes[Type]) +
                            String.Format("房间价格：{0}", Price));
        }
        public static int SearchRecord()//查询入住记录
        {
            MessageBox.Show("无入住记录。。。");
            return 0;
        }
        public static void Comment(DateTime time, int user_id, string s, int star)
        {
            //***
            ////向评论表中插入信息
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

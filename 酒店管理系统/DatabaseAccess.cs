using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;


namespace HotelmanageSystem
{

    interface DBAcess
    {
        int CheckVip(int uid);
        void GetVip(int level, int uid);
        void CancleVip(int uid);
        int CheckOrder(int type, int beg_time, int end_time);
        int GetRoomprice(string room_kind);//根据房间种类找到对应的房间价格并返回，若找不到返回-1；
        bool isExistRoom(string room_no);//判断是否存在房间号
        void AddRoom(string room_no, string room_kind, string isNormal, int roomprice);//插入新的房间，如果此时的房间类型不存在，创建新的房价，isNormal的值为是/否

        List<Room> GetRooms();//返回所有房间的房间号，种类，是否正常使用，房间价格，Room类我这边写好了，可以问我要
        void ModifyIsnormal(string room_no, string isNormal);//将房间号为room_no的是否可以使用的属性改为isNormal，isnormal的取值为是/否
        void DeleteRoom(string room_no);//删除房间号为room_no的房间
        void ModifyRoom_no(string room_no, string num);//将房间号为room_no的房间的房间号改为num
        void ModifyRoomkind(string room_no, string str);//将房间号为room_no的房间的房间类型改为str
        void ModifyRoomprice(string room_kind, int price);//将房间类型为room_king的房价改为price
        void AddRoomkind(string room_kind, int price);//新增房间类型为room_kind的房价
        bool isExistRoom_kind(string room_kind);//是否存在该房间类型

        bool isExistEmployee(string employee_id);//判断是否存在员工编号
        bool isExistEmployeeStatus(string employee_status);//是否存在身份证
        void AddEmployee(string employee_id, string employee_name, string employee_sex, string employee_status, string employee_phone, int employee_salary, string employee_time, string employee_position);//插入员工,其中time为2020-06-06这样的字符串

        List<Employee> GetEmployees();//返回所有员工信息，包括员工的编号，姓名，性别，身份证号，手机号，薪水，入职时间，入职岗位，Employee类我已写好，问我要
        void DeleteEmployee(string employee_id,string employee_status);//删除该员工
        void ModifyEmployeesex(string employee_id, string sex);//将employee_id的员工的性别改为sex(男/女）
        void ModifyEmployeeID(string old_id, string new_id);//将old_id的员工的员工编号修改为new_id
        void ModifyEmployeename(string employee_id, string name);//将employee_id的员工的姓名修改为name
        void ModifyEmployeestatus(string employee_id, string status);//修改身份证号为status
        void ModifyEmployeephone(string employee_id, string phone);//修改电话号码为phone
        void ModifyEmployeetime(string employee_id, string time);//修改入职时间为time
        void ModifyEmployeesalary(string employee_id, int salary);//修改薪水为salary
        void ModifyEmployeeposition(string employee_id, string position);//修改职位为position

        bool isExistID(string id, string kind);//kind取值为用户/前台/管理员，判断是否存在该用户/前台/管理员
        void ModifyPassword(string id, string new_pwd, string kind);//修改密码，kind取值为用户/前台/管理员

        List<Complaint> GetComplaints();//返回所有投诉，包括投诉人的ID，投诉的订单编号以及投诉时间，Complaint类我已写好，问我要
        void DeleteComplaint(string ser_order_id);//删除该条投诉
        string GetComplaintContent(string ser_order_id);//获取该投诉的投诉内容
        List<string> GetSer_emp_ids(string ser_order_id);//获取与提供该服务的员工编号

        List<Income> GetIncomes(string start, string end);//获取这段时间内（包括起始时间和终止时间，收入包括房间费用，服务费用，均按照种类划分）的收入，考虑到天即可，Income类我已写好，问我要
        List<Cost> GetCosts(string start,string end);//给出这些时间内支付给员工的工资，按照员工类别划分
    }

    class DBHandler : DBAcess
    {
        public List<String> results;//用来存储结果
        public String state;//用来存储状态
        public String exMessage;//用来存储错误信息
        private const String connStr = "server=localhost;database=mydb;uid=root;pwd=LBJtzbdpxy257890";
        private const String connString = "server=localhost;database=mydb;uid=root;pwd=LBJtzbdpxy257890";//连接数据库的基本信息
        public List<String> Query(String username, String password)
        {
            results = new List<String>();
            MySqlConnection conn = new MySqlConnection();
            //因为要验证是否能登录到数据库，所以使用try,excaption
            try
            {
                conn.ConnectionString = connStr;
                conn.Open();
                state = conn.State.ToString();//保存状态信息
                MySqlCommand cmd = new MySqlCommand();//新建一个SQL执行对象
                cmd.Connection = conn;
                cmd.CommandText = "select * from tab_user";
                MySqlDataReader ord = cmd.ExecuteReader(); //执行查询操作
                while (ord.Read())
                {
                    results.Add(ord["password"].ToString());
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
            return results;
        }
        public int CheckVip(int uid)
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
        public void GetVip(int level, int uid)
        {
            //***
            //在membership表里插入level，uid
            int record;
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
            return;
        }
        public void CancleVip(int uid)
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
            return;
        }

        public int CheckOrder(int type, int beg_time, int end_time)
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
        public int GetRoomprice(string room_kind)
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
                cmd.CommandText = "select price from room_price where type =@type";
                cmd.Parameters.Add(new MySqlParameter("@type", room_kind));
                MySqlDataReader ord = cmd.ExecuteReader(); //执行查询操作
                while (ord.Read())
                {
                    string a = ord["price"].ToString();
                    price = Convert.ToInt32(a);
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
            return price;
        }

        public bool isExistRoom_kind(string room_kind)
        {
            bool result = false;
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from room_price where type=@room_kind";
                    cmd.Parameters.Add(new MySqlParameter("@room_kind", room_kind));
                    MySqlDataReader ord = cmd.ExecuteReader();
                    if (!ord.Read())
                    {
                        result = true;
                    }
                }
            }
            return result;
        }
        public void AddRoomkind(string room_kind, int price)
        {
            int record;
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    bool result = false;
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from room_price where type=@room_kind";
                    cmd.Parameters.Add(new MySqlParameter("@room_kind", room_kind));
                    MySqlDataReader ord = cmd.ExecuteReader();
                    if (!ord.Read())
                    {
                        result = true;
                    }
                    ord.Close();
                    if (result)
                    {
                        cmd.CommandText = "insert into room_price(type, price) values(@type,@price)";
                        cmd.Parameters.Add(new MySqlParameter("@type", room_kind));
                        cmd.Parameters.Add(new MySqlParameter("@price", price));
                        record = cmd.ExecuteNonQuery();//返回的是受影响的行数
                    }
                }
            }
            return;
        }

        public void ModifyRoomprice(string room_kind, int price)
        {
            int record;
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "Update room_price set price=@price where type=@type";
                    cmd.Parameters.Add(new MySqlParameter("@type", room_kind));
                    cmd.Parameters.Add(new MySqlParameter("@price", price));
                    record = cmd.ExecuteNonQuery();//返回的是受影响的行数
                }
            }
        }

        public bool isExistRoom(string room_no)
        {
            bool exist;

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from room where room_id=@room_id";
                    cmd.Parameters.Add(new MySqlParameter("@room_id", room_no));
                    MySqlDataReader ord = cmd.ExecuteReader();
                    if (ord.Read())
                    {
                        exist = true;
                    }
                    else
                    {
                        exist = false;
                    }
                }
            }
            return exist;
        }

        public List<Room> GetRooms()
        {
            List<Room> rooms = new List<Room>();
            MySqlConnection conn = new MySqlConnection();
            try
            {
                conn.ConnectionString = connStr;
                conn.Open();
                state = conn.State.ToString();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from room natural join room_price";
                MySqlDataReader ord = cmd.ExecuteReader(); //执行查询操作
                while (ord.Read())
                {
                    string number = ord["room_id"].ToString();
                    string kind = ord["type"].ToString();
                    string isNormal = ord["status"].ToString();
                    string price = ord["price"].ToString();
                    int p = Convert.ToInt32(price);
                    Room room = new Room(number, kind, isNormal, p);
                    rooms.Add(room);
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
            return rooms;
        }
        public void ModifyIsnormal(string room_no, string isNormal)
        {
            int record;
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "Update room set status=@isN where room_id=@room_id";
                    cmd.Parameters.Add(new MySqlParameter("@isN", isNormal));
                    cmd.Parameters.Add(new MySqlParameter("@room_id", room_no));
                    record = cmd.ExecuteNonQuery();//返回的是受影响的行数
                }
            }
        }

        public void AddRoom(string room_no, string room_kind, string isNormal, int roomprice)
        {
            int record;
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from room_price where type=@room_kind";
                    cmd.Parameters.Add(new MySqlParameter("@room_kind", room_kind));
                    MySqlDataReader ord = cmd.ExecuteReader();
                    if (!ord.Read())
                    {
                        AddRoomkind(room_kind, roomprice);
                    }
                    ord.Close();
                    cmd.CommandText = "insert into room(room_id, type, status) values(@room_id, @type, @status)";
                    cmd.Parameters.Add(new MySqlParameter("@type", room_kind));
                    cmd.Parameters.Add(new MySqlParameter("@room_id", room_no));
                    cmd.Parameters.Add(new MySqlParameter("@status", isNormal));
                    record = cmd.ExecuteNonQuery();//返回的是受影响的行数
                }
            }
            return;
        }

        public void ModifyRoom_no(string room_no, string num)
        {
            int record;
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "Update room set room_id=@nid where room_id=@oid";
                    cmd.Parameters.Add(new MySqlParameter("@nid", num));
                    cmd.Parameters.Add(new MySqlParameter("@oid", room_no));
                    record = cmd.ExecuteNonQuery();//返回的是受影响的行数
                }
            }
        }

        public void ModifyRoomkind(string room_no, string str)
        {
            int record;
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "Update room set type=@type where room_id=@room_id";
                    cmd.Parameters.Add(new MySqlParameter("@type", str));
                    cmd.Parameters.Add(new MySqlParameter("@room_id", room_no));
                    record = cmd.ExecuteNonQuery();//返回的是受影响的行数
                }
            }
        }

        public void DeleteRoom(string room_no)
        {
            int record;
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "Delete from room where room_id=@room_id";
                    cmd.Parameters.Add(new MySqlParameter("@room_id", room_no));
                    record = cmd.ExecuteNonQuery();//返回的是受影响的行数
                }
            }
            return;
        }

        public bool isExistEmployeeStatus(string employee_status)
        {
            bool exist;
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from staff where identity=@identity";
                    cmd.Parameters.Add(new MySqlParameter("@identity", employee_status));
                    MySqlDataReader ord = cmd.ExecuteReader();//执行查询操作
                    if (ord.Read())
                    {   //如果查询到了对应的用户，则用户身份证重复
                        exist = true;
                    }
                    else
                    {   //如果没找到，说明用户不存在，可以注册
                        exist = false;
                    }
                }
            }
            return exist;
        }
        public bool isExistEmployee(string employee_id)
        {
            bool exist;

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from staff where staff_id=@staff_id";
                    cmd.Parameters.Add(new MySqlParameter("@staff_id", employee_id));
                    MySqlDataReader ord = cmd.ExecuteReader();//执行查询操作
                    if (ord.Read())
                    {   //如果查询到了对应的用户，则用户名重复
                        exist = true;
                    }
                    else
                    {   //如果没找到，说明用户不存在，可以注册
                        exist = false;
                    }
                }
            }
            return exist;
        }
        public void ConnectDatabase()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            // MessageBox.Show("连接成功！", "测试结果");
            using (MySqlCommand cmd = new MySqlCommand())
            {
                string sql = "insert into identity_card values('529826200005030010','yj',1,'15185049879')";
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
                sql = "select * from identity_card where name = 'yj'";
                cmd.CommandText = sql;
                MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行读命令的对象,但是还没有执行命令
                string identity = "";
                while (reader.Read())//按行执行查询，每次循环查询一行
                {
                    //此时reader会获取一行的内容，返回一个类似字典的结构，key为列名，value为值
                    //对于不同的数据库字段类型，我们需要用不同的方法获取
                    identity = reader.GetString("identity");
                }
                MessageBox.Show(identity);
            }
            /*using (MySqlCommand cmd = new MySqlCommand())
            {
                string sql = "insert into staff values('123456','522426200005030010','20200815000000','manager',12000)";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }*/
            conn.Close();
        }
        public void AddEmployee(string employee_id, string employee_name,
            string employee_sex, string employee_status, string employee_phone,
            int employee_salary, string employee_time, string employee_position)//插入员工,其中time为2020-06-06这样的字符串
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                string sql = "Insert into identity_card(identity,name,gender,phone) values(@employee_status , @employee_name ," +
                    "@employee_sex ,@employee_phone)";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@employee_status", employee_status));
                cmd.Parameters.Add(new MySqlParameter("@employee_name", employee_name));
                if (employee_sex == "男")
                {
                    cmd.Parameters.Add(new MySqlParameter("@employee_sex", 1));
                }
                else
                {
                    cmd.Parameters.Add(new MySqlParameter("@employee_sex", 0));
                }
                cmd.Parameters.Add(new MySqlParameter("@employee_phone", employee_phone));
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            using (MySqlCommand cmd = new MySqlCommand())
            {
                string sql = "Insert into staff(staff_id,identity,staff_time,staff_satr,staff_salary) values(@employee_id ,@employee_status ," +
                    "@employee_time , @employee_position ,@employee_salary)";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@employee_id", employee_id));
                cmd.Parameters.Add(new MySqlParameter("@employee_status", employee_status));
                cmd.Parameters.Add(new MySqlParameter("@employee_time", employee_time));
                cmd.Parameters.Add(new MySqlParameter("@employee_position", employee_position));
                cmd.Parameters.Add(new MySqlParameter("@employee_salary", employee_salary));
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                if (employee_position == "前台")
                {
                    sql = "insert into front(staff_id,password,front_phone) values(@staff_id,@password,@front_phone)";
                    cmd.CommandText = sql;
                    cmd.Parameters.Add(new MySqlParameter("@staff_id", employee_id));
                    cmd.Parameters.Add(new MySqlParameter("@password", "123456"));
                    cmd.Parameters.Add(new MySqlParameter("@front_phone", employee_phone));
                }
                else
                {
                    sql = "insert into administrator(adm_id,adm_phone,admin_password) values(@staff_id,@adm_phone,@password)";
                    cmd.CommandText = sql;
                    cmd.Parameters.Add(new MySqlParameter("@staff_id", employee_id));
                    cmd.Parameters.Add(new MySqlParameter("@adm_phone", employee_phone));
                    cmd.Parameters.Add(new MySqlParameter("@password", "123456"));
                }
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
        public List<Employee> GetEmployees()//返回所有员工信息，包括员工的编号，姓名，性别，身份证号，手机号，薪水，入职时间，入职岗位
        {
            List<Employee> staff_list = new List<Employee>();
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                cmd.Connection = conn;
                string sql = "select* from staff natural join identity_card";
                cmd.CommandText = sql;
                MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行读命令的对象,但是还没有执行命令
                while (reader.Read())//按行执行查询，每次循环查询一行
                {
                    string staff_id = reader.GetString("staff_id");
                    string name = reader.GetString("name");
                    string gender = "";
                    int x= reader.GetInt32("gender");
                    string identity = reader.GetString("identity");
                    string phone = reader.GetString("phone");
                    int salary = reader.GetInt32("staff_salary");
                    string staff_time = reader.GetString("staff_time").Replace("/","-0");
                    string staff_satr = reader.GetString("staff_satr");
                    if (x == 1) gender = "男";
                    else gender = "女";
                    Employee employee = new Employee(staff_id, name, gender, identity, phone, salary, staff_time, staff_satr);
                    staff_list.Add(employee);
                }
            }
            conn.Close();
            return staff_list;

        }
        public void DeleteEmployee(string employee_id,string employee_status)//删除该员工
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {

                string sql = "delete  from staff where staff_id=@employee_id";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@employee_id", employee_id));
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                sql = "delete from identity_card where identity=@employee_status";
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@employee_status", employee_status));
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
        public void ModifyEmployeesex(string employee_id, string sex)//将employee_id的员工的性别改为sex(男/女）
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                int gender;
                if (sex == "男" || sex == "male") gender = 1;
                else gender = 0;
                string sql = "select identity from staff where staff_id=@employee_id";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@employee_id", employee_id));
                MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行读命令的对象,但是还没有执行命令
                string identity = "";
                while (reader.Read())//按行执行查询，每次循环查询一行
                {
                    identity = reader.GetString("identity");
                }
                reader.Close();
                sql = "update identity_card set gender =@gender where identity=@identity";
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@gender", gender));
                cmd.Parameters.Add(new MySqlParameter("@identity", identity));
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
        public void ModifyEmployeeID(string old_id, string new_id)//将old_id的员工的员工编号修改为new_id
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {

                string sql = "update staff set staff_id = @new_id  where staff_id = @old_id";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@new_id", new_id));
                cmd.Parameters.Add(new MySqlParameter("@old_id", old_id));
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
        public void ModifyEmployeename(string employee_id, string name)//将employee_id的员工的姓名修改为name
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                cmd.Connection = conn;
                string sql = "select identity from staff where staff_id = @employee_id";
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@employee_id", employee_id));
                MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行读命令的对象,但是还没有执行命令
                string identity = "";
                while (reader.Read())//按行执行查询，每次循环查询一行
                {
                    identity = reader.GetString("identity");
                }
                reader.Close();
                sql = "update identity_card set name = @name where identity = @identity";
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@name", name));
                cmd.Parameters.Add(new MySqlParameter("@identity", identity));
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
        public void ModifyEmployeestatus(string employee_id, string status)//修改身份证号为status
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                cmd.Connection = conn;
                string sql = "SET FOREIGN_KEY_CHECKS = 0";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                sql = "select identity from staff where staff_id = @employee_id";
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@employee_id", employee_id));
                MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行读命令的对象,但是还没有执行命令
                string identity = "";
                while (reader.Read())//按行执行查询，每次循环查询一行
                {
                    identity = reader.GetString("identity");
                }
                reader.Close();
                sql = "update identity_card set identity=@status2 where identity=@identity";
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@status2", status));
                cmd.Parameters.Add(new MySqlParameter("@identity", identity));
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                sql = "update staff set identity=@status  where staff_id = @staff_id";
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@status", status));
                cmd.Parameters.Add(new MySqlParameter("@staff_id", employee_id));
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
        public void ModifyEmployeephone(string employee_id, string phone)//修改电话号码为phone
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                cmd.Connection = conn;
                string sql = "select identity from staff where staff_id =@employee_id";
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@employee_id", employee_id));
                MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行读命令的对象,但是还没有执行命令
                string identity = "";
                while (reader.Read())//按行执行查询，每次循环查询一行
                {
                    identity = reader.GetString("identity");
                }
                reader.Close();
                sql = "update identity_card set phone =@phone  where identity = @identity";
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@phone", phone));
                cmd.Parameters.Add(new MySqlParameter("@identity", identity));
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
        public void ModifyEmployeetime(string employee_id, string time)//修改入职时间为time
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                cmd.Connection = conn;
                string sql = "update staff set staff_time =@time where staff_id = @employee_id";
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@time", time));
                cmd.Parameters.Add(new MySqlParameter("@employee_id", employee_id));
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
        public void ModifyEmployeesalary(string employee_id, int salary)//修改薪水为salary
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                cmd.Connection = conn;
                string sql = "update staff set staff_salary = @salary  where staff_id =@employee_id";
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@salary", salary));
                cmd.Parameters.Add(new MySqlParameter("@employee_id", employee_id));
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
        //开始
        public void ModifyEmployeeposition(string employee_id, string position)//修改职位为position
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                cmd.Connection = conn;
                string sql = "update staff set staff_satr =@position  where staff_id =@employee_id";
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@position", position));
                cmd.Parameters.Add(new MySqlParameter("@employee_id",employee_id));
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

        public bool isExistID(string id, string kind)//kind取值为用户/前台/管理员，判断是否存在该用户/前台/管理员
        {
            string user1 = "用户";
            string front1 = "前台";
            string adm1 = "管理员";
            bool exist;

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    if (kind == user1)
                    {
                        cmd.CommandText = "select * from user where user_id = @user_id";
                        cmd.Parameters.Add(new MySqlParameter("@user_id", id));
                    }
                    else if (kind == front1)
                    {
                        cmd.CommandText = "select * from front where staff_id = @staff_id";
                        cmd.Parameters.Add(new MySqlParameter("@staff_id", id));
                    }
                    else if (kind == adm1)
                    {
                        cmd.CommandText = "select * from administrator where adm_id = @adm_id";
                        cmd.Parameters.Add(new MySqlParameter("@adm_id", id));
                    }
                    MySqlDataReader ord = cmd.ExecuteReader();//执行查询操作
                    if (ord.Read())
                    {   //如果查询到了对应的用户，则用户名重复
                        exist = true;
                    }
                    else
                    {   //如果没找到，说明用户不存在，可以注册
                        exist = false;
                    }
                }
            }
            return exist;
        }

        public void ModifyPassword(string id, string new_pwd, string kind)//修改密码，kind取值为用户/前台/管理员
        {
            string user1 = "用户";
            string front1 = "前台";
            string adm1 = "管理员";

            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                cmd.Connection = conn;
                string sql;
                if (kind == user1)
                {
                    sql = "update user set user_password = @new_pwd where user_id = @id";
                }
                else if (kind == front1)
                {
                    sql = "update front set staff_password = @new_pwd where staff_id = @id";
                }
                else
                {
                    sql = "update administrator set adm_password = @new_pwd  where adm_id =@id";
                }
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@new_pwd", new_pwd));
                cmd.Parameters.Add(new MySqlParameter("@id", id));
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

        public List<Complaint> GetComplaints()//返回所有投诉，包括投诉人的ID，投诉的订单编号以及投诉时间，Complaint类我已写好，问我要
        {
            List<Complaint> complaint_list = new List<Complaint>();
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                cmd.Connection = conn;
                string sql = "select* from complaint";
                cmd.CommandText = sql;
                MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行读命令的对象,但是还没有执行命令
                while (reader.Read())//按行执行查询，每次循环查询一行
                {
                    string user_id = reader.GetString("user_id");
                    string ser_order_id = reader.GetString("ser_order_id");
                    string com_time = reader.GetString("com_time");
                    Complaint complaint = new Complaint(user_id, ser_order_id, com_time);
                    complaint_list.Add(complaint);
                }
            }
            conn.Close();
            return complaint_list;
        }
        public void DeleteComplaint(string ser_order_id)//删除该条投诉
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {

                string sql = "delect from comlaint where ser_order_id=@ser_order_id";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@ser_order_id", ser_order_id));
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
        public string GetComplaintContent(string ser_order_id)//获取该投诉的投诉内容
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            string content = "";
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {

                string sql = "select com_content from comlaint where ser_order_id=@ser_order_id";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@ser_order_id", ser_order_id));
                MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行读命令的对象,但是还没有执行命令
                while (reader.Read())
                {
                    content = content + reader.GetString("com_content");
                }
            }
            conn.Close();
            return content;
        }
        public List<string> GetSer_emp_ids(string ser_order_id)//获取与提供该服务的员工编号/////有待检测
        {
            List<string> staff_id_list = new List<string>();
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                cmd.Connection = conn;
                string sql = "select staff_id from pro_service where ser_order_id=@ser_order_id";
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@ser_order_id", ser_order_id));
                MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行读命令的对象,但是还没有执行命令
                while (reader.Read())//按行执行查询，每次循环查询一行
                {
                    string staff_id_list1 = reader.GetString("staff_id");
                    staff_id_list.Add(staff_id_list1);
                }
            }
            conn.Close();
            return staff_id_list;
        }
        public List<Income> GetIncomes(string start, string end)//获取这段时间内（包括起始时间和终止时间，收入包括房间费用，服务费用，均按照种类划分）的收入，考虑到天即可
        {
            List<Income> income_list = new List<Income>();
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                cmd.Connection = conn;
                string sql = "select type,sum(all_price) as sum_price,count(order_id) as count_id " +
                    "from mydb.order " +
                    "where order_time >= @start and order_time <= @end " +
                    "group by type";
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@start", start));
                cmd.Parameters.Add(new MySqlParameter("@end", end));
                cmd.Parameters.Add(new MySqlParameter("@start1", start));
                cmd.Parameters.Add(new MySqlParameter("@end1", end));
                MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行读命令的对象,但是还没有执行命令
                while (reader.Read())//按行执行查询，每次循环查询一行
                {
                    Income income = new Income(reader["type"].ToString(), reader.GetInt32("count_id"), reader.GetInt32("sum_price"), end);
                    income_list.Add(income);
                }
                reader.Close();
                sql = "select ser_type, sum(ser_money) as sum_money ,count(ser_order_id) as count_id " +
                    "from ser_order natural join service " +
                    "where ser_time >= @start2 and  ser_time<=@end2 " +
                    "group by ser_type";
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@start2", start));
                cmd.Parameters.Add(new MySqlParameter("@end2", end));
                cmd.Parameters.Add(new MySqlParameter("@start3", start));
                cmd.Parameters.Add(new MySqlParameter("@end3", end));
                MySqlDataReader reader1 = cmd.ExecuteReader();//创建一个执行读命令的对象,但是还没有执行命令
                while (reader1.Read())//按行执行查询，每次循环查询一行
                {
                    Income income = new Income(reader1["ser_type"].ToString(), reader1.GetInt32("count_id"), reader1.GetInt32("sum_money"), end);
                    income_list.Add(income);
                }
            }
            conn.Close();
            return income_list;
        }
        public List<Cost> GetCosts(string start,string end)//给出这些时间内支付给员工的工资，按照员工类别划分
        {
            string kind1 = "管理员";
            string kind2 = "前台";
            string kind3 = "一级";
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            int count1, count2, count3;
            count1 = count2 = count3 = 0;
            DateTime startTime = Convert.ToDateTime(start);
            DateTime endTime = Convert.ToDateTime(end);//开始结束时间
            List<Cost> cost_list = new List<Cost>();
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                cmd.Connection = conn;
                string sql = "select* from staff";
                cmd.CommandText = sql;
                MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行读命令的对象,但是还没有执行命令
                while (reader.Read())//按行执行查询，每次循环查询一行
                {
                    string staff_satr = reader["staff_satr"].ToString();
                    int staff_salary = reader.GetInt32("staff_salary");
                    DateTime staff_time = Convert.ToDateTime( reader["staff_time"].ToString());
                    if (staff_satr == kind1)
                    {
                        if (startTime.CompareTo(staff_time) >= 0)//早于开始时间
                        {
                            TimeSpan timeSpan = endTime.Subtract(startTime);
                            sum1 += staff_salary * (timeSpan.Days + 1) / 30;
                            count1++;
                        }
                        else if (endTime.CompareTo(staff_time) >= 0)//晚于开始时间
                        {
                            TimeSpan timeSpan = endTime.Subtract(staff_time);
                            sum1 += staff_salary * (timeSpan.Days + 1) / 30 ;    
                            count1++;
                        }
                    }
                    else if (staff_satr == kind2)
                    {
                        if (startTime.CompareTo(staff_time) >= 0)//早于开始时间
                        {
                            TimeSpan timeSpan = endTime.Subtract(startTime);
                            sum2 += staff_salary * (timeSpan.Days + 1) / 30 ;
                            count2++;
                        }
                        else if (endTime.CompareTo(staff_time) >= 0)//晚于开始时间
                        {
                            TimeSpan timeSpan = endTime.Subtract(staff_time);
                            sum2 += staff_salary * (timeSpan.Days + 1) / 30 ;
                            count2++;
                        }
                    }
                    else if (staff_satr == kind3)
                    {
                        if (startTime.CompareTo(staff_time) >= 0)//早于开始时间
                        {
                            TimeSpan timeSpan = endTime.Subtract(startTime);
                            sum3 += staff_salary * (timeSpan.Days + 1) / 30;
                            count3++;
                        }
                        else if (startTime.CompareTo(staff_time) >= 0)//晚于开始时间
                        {
                            TimeSpan timeSpan = endTime.Subtract(staff_time);
                            sum3 += staff_salary * (timeSpan.Days + 1) / 30 ;
                            count3++;
                        }
                    }
                }
                Cost cost = new Cost(kind1, count1, sum1);
                cost_list.Add(cost);
                cost = new Cost(kind2, count2, sum2);
                cost_list.Add(cost);
                cost = new Cost(kind3, count3, sum3);
                cost_list.Add(cost);

            }
            conn.Close();
            return cost_list;
        }
    }
}

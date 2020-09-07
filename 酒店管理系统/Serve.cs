using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

struct ser
{
    public string type;
    public int money;
};

struct ord_ser
{
    public string order_id;
    public string type;
    public string time;
};

namespace WindowsFormsApp1
{
    class Serve
    {  
        public List<ser> sers = new List<ser>();
        public List<ord_ser> ord_sers = new List<ord_ser>();
        public void ReLoad_sers()
        {
            string connString = "server=localhost;database=mydb;uid=root;pwd=123";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                string sql = "select * from service";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行命令的对象,但是还没有执行命令
                while (reader.Read())//按行执行查询，每次循环查询一行
                {
                    //此时reader会获取一行的内容，返回一个类似字典的结构，key为列名，value为值
                    //对于不同的数据库字段类型，我们需要用不同的方法获取
                    ser _ser = new ser();
                    _ser.type = reader.GetString(0);
                    _ser.money = reader.GetInt32(2);
                    this.sers.Add(_ser);
                }
            }
            conn.Close();

        }
        public void ReLoad_ord_sers()
        {
            string connString = "server=localhost;database=mydb;uid=root;pwd=123";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                string sql = "select * from ser_order where user_id = " + User.id.ToString();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行命令的对象,但是还没有执行命令
                while (reader.Read())//按行执行查询，每次循环查询一行
                {
                    //此时reader会获取一行的内容，返回一个类似字典的结构，key为列名，value为值
                    //对于不同的数据库字段类型，我们需要用不同的方法获取
                    ord_ser _ord_ser = new ord_ser();
                    _ord_ser.type = reader.GetString(2);
                    _ord_ser.time = reader.GetString(3);
                    _ord_ser.order_id = reader.GetString(0);
                    this.ord_sers.Add(_ord_ser);
                }
            }
            conn.Close();

        }
    }
}

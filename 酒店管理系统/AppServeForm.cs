using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AppServeForm : Form
    {
        public AppServeForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(userSerReload);
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            User.AppforSev(User.id, type);
        }*/
        //窗体加载事件，为组合框添加值
        private void ComboBox_ser_Load(object sender, EventArgs e)
        {
            comboBox_ser.Items.Clear();
            Serve the_ser = new Serve();
            the_ser.ReLoad_sers();
            foreach (ser s in the_ser.sers)
            {
                comboBox_ser.Items.Add(s.type + "(¥" + s.money + ")");
            }
        }
        //“申请服务”按钮的单击事件，用于向组合框中添加文本框中的值
        private void button1_Click_1(object sender, EventArgs e)
        {
            string s = comboBox_ser.Text;
            if (comboBox_ser.Text.Trim().Length != 0)
            {
                MessageBox.Show("申请了服务:" + s, "提示");
            }
            else
                MessageBox.Show("请选择您的服务", "提示");

        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
        }

        private void listView1_MouseDown(object sender, MouseEventArgs e)//鼠标点击空白处关闭右键菜单
        {
            panel1.SendToBack();
        }

        private void userSerReload(object sender, EventArgs e)//重新加载用户服务列表
        {
            listView1.Items.Clear();
            Serve the_ser = new Serve();
            the_ser.ReLoad_ord_sers();
            foreach (ord_ser s in the_ser.ord_sers)
            {
                ListViewItem a = new ListViewItem(new string[] { s.type, s.time, s.order_id }, -1);
                listView1.Items.Add(a);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginRegisterFrame;
using HotelmanageSystem;

namespace ReceptionSection
{
    public partial class qiantai : Form
    {
        public qiantai()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            处理服务 form5 = new 处理服务();
            form5.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            退房 form7 = new 退房();
            form7.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckIn form2 = new CheckIn();
            form2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            查询会员信息 form3 = new 查询会员信息();
            form3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            查询剩余房间 form6 = new 查询剩余房间();
            form6.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            更换房间 form8 = new 更换房间();
            form8.ShowDialog();
        }

        private void qiantai_Load(object sender, EventArgs e)
        {
            this.label2.Text = "000";
            this.label4.Text = "张三";
        }
    }
}

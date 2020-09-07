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
    public partial class 更换房间 : Form
    {
        public 更换房间()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string from_s = this.textBox1.Text, to_s = this.textBox2.Text;
            MessageBox.Show("成功更换房间", "提示");
/*
            if (isRoom(string < room_id > from_s) && isRoom(string < room_id > to_s))
            {
                if(isNormalRoom(string < room_id > from_s))
                {
                    MessageBox.Show("待更换的房间房间号输入有误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(isNormalRoom(string < room_id > to_s))
                    {
                        //后台换房函数
                        MessageBox.Show("成功更换房间", "提示");
                    }
                    else MessageBox.Show("更换的房间不是能使用的房间", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("查无目标房间", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
*/

        }

        private void 更换房间_Load(object sender, EventArgs e)
        {

        }
    }
}

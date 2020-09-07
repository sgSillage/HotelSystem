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
    public partial class 退房 : Form
    {
        public 退房()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = this.textBox2.Text;
            //AddCheckOut(string <room_id>s);
            MessageBox.Show("退房成功", "提示");
/*
            if (isRoom(string <room_id>s)
            {
                if(isNormalRoom(string <room_id) s)
                {
                    MessageBox.Show("该房间处于可使用状态不可退房", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("退房成功", "提示");
            }
            else MessageBox.Show("查无此房", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void 退房_Load(object sender, EventArgs e)
        {

        }
    }
}

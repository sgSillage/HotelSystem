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
    public partial class CheckIn : Form
    {
        public CheckIn()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string RoomNum = this.textBox1.Text;
            string id1 = this.textBox2.Text;
            string id2 = this.textBox4.Text;
            string id3 = this.textBox6.Text;
            string name1 = this.textBox3.Text;
            string name2 = this.textBox5.Text;
            string name3 = this.textBox7.Text;
/*
            if(isRoomNumber(string < room_id > RoomNumber))
            {
                if(isPerson(id1，name1) && isPerson(id2，name2) && isPerson(id3，name3))
                {
                    MessageBox.Show("办理成功", "提示");
                    AddCheckIn(id1，name1,id2，name2,id3，name3,string room_id);
                    this.Dispose();
                }
                else MessageBox.Show("客户身份信息有误，请核实", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("查无此房间", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
*/
            MessageBox.Show("办理成功", "提示");
                this.Dispose();

        }

        private void CheckIn_Load(object sender, EventArgs e)
        {

        }
    }
}

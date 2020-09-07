using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReceptionSection
{
    public partial class CheckIn : Form
    {
        public CheckIn()
        {
            InitializeComponent();
        }

        private void CheckIn_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string RoomNum = this.textBox2.Text;
            string id1 = this.textBox2.Text;
            string id2 = this.textBox4.Text;
            string name1 = this.textBox3.Text;
            string name2 = this.textBox5.Text;
            if (RoomNum.Equals("0"))
            {
                MessageBox.Show("房间号输入错误", "提示");
            }
            else
            {
                MessageBox.Show("办理成功", "提示");
                //AddCheckIn;
                this.Dispose();
            }
        }
    }
}

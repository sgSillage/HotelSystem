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
    public partial class 处理服务 : Form
    {
        public 处理服务()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string staff_id = this.textBox2.Text;
/*
            if(isStaff(string staff_id))
            {
                //AddService(string staff_id);
                MessageBox.Show("已安排该员工去处理", "提示");
            }
            else MessageBox.Show("查无此员工，请核实", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
*/
            MessageBox.Show("已安排该员工去处理", "提示");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void 处理服务_Load(object sender, EventArgs e)
        {

        }
    }
}

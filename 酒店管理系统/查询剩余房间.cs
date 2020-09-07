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
    public partial class 查询剩余房间 : Form
    {
        public 查询剩余房间()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("请选择有效房间种类","提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                剩余房间 form9 = new 剩余房间();
                form9.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            room.type = this.comboBox1.Text;
        }

        private void 查询剩余房间_Load(object sender, EventArgs e)
        {

        }
    }
}

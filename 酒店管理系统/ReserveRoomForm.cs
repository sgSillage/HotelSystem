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
    public partial class ReserveRoomForm : Form
    {
        public ReserveRoomForm()
        {
            InitializeComponent();
        }

        private void ReserveRoomClicked(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("请选择有效房间种类");
                return;
            }
            DateTime beg_time = dtpStartime.Value;
            DateTime end_time = dtpEndtime.Value;
            if((dtpStartime.Value.CompareTo(dtpEndtime.Value)<0 ))
            {
                if (User.OrderRoom(comboBox1.Text, beg_time, end_time).Length == 1)
                {
                    MessageBox.Show("预定失败：没有可用的房源");
                }
                else
                    MessageBox.Show("预定成功！");
            }
            else
            {
                
                MessageBox.Show("请输入有效时间（结束时间必须晚于开始时间）！");
                return;
            }
        }
    }
}

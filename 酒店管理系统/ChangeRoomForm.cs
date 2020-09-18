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
    public partial class ChangeRoomForm : Form
    {
        public ChangeRoomForm()
        {
            InitializeComponent();
        }

        /*private void ChangeRoomClicked(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("请选择有效房间种类");
                return;
            }
            DateTime beg_time = ;
            DateTime end_time = -1;
            int.TryParse(textBox2.Text, out beg_time);
            int.TryParse(textBox3.Text, out end_time);
            if (beg_time == -1 || end_time == -1)
            {
                MessageBox.Show("请输入有效时间");
                return;
            }
            else
            {
                User.ChangeRoom(comboBox1.Text, beg_time, end_time);
            }
        }*/

        private void ChangeRoomForm_Load(object sender, EventArgs e)
        {

        }
    }
}

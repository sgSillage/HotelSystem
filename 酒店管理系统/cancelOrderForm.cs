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
    public partial class cancelOrderForm : Form
    {
        public cancelOrderForm()
        {
            InitializeComponent();
        }

        private void cancelOrderForm_Load(object sender, EventArgs e)
        {
            List<Reserve> reserves = User.GetReserves(Convert.ToString(User.id));
            int tag=0;
            foreach(Reserve reserve in reserves)
            {
                ListViewItem listViewItem = new ListViewItem(reserve.Room_id);
                listViewItem.SubItems.Add(reserve.Start_time);
                listViewItem.SubItems.Add(reserve.End_time);
                listViewItem.Tag = tag;
                lvwreserve.Items.Add(listViewItem);
                tag += 1;
            }
            
        }

        private void tsmiCancelOrder_Click(object sender, EventArgs e)
        {
            if (lvwreserve.Items.Count <= 0)
            {
                MessageBox.Show("列表中没有任何信息！");
            }
            else if (lvwreserve.SelectedItems.Count == 0)
            {
                MessageBox.Show("你没有选中任何项！");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("确认删除该预定吗？请谨慎操作！", "删除提示",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)//确认删除
                {
                    int tid = (int)lvwreserve.SelectedItems[0].Tag;
                    User.deleteReserve(User.id.ToString(), lvwreserve.SelectedItems[0].SubItems[0].Text, lvwreserve.SelectedItems[0].SubItems[1].Text);
                    lvwreserve.Items.RemoveAt(tid);
                    MessageBox.Show("成功退订！");
                }
            }
        }
    }
}

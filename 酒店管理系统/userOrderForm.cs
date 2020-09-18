using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace 酒店管理系统
{
    public partial class UserOrderForm : Form
    {
        public UserOrderForm()
        {
            InitializeComponent();
        }

        private void userOrderForm_Load(object sender, EventArgs e)
        {
            List<userOrder> userOrders = User.SearchOrder(Convert.ToString(User.id));
            int tag = 0;
            foreach (userOrder userOrder in userOrders)
            {
                ListViewItem listViewItem = new ListViewItem(userOrder.Type);
                listViewItem.SubItems.Add(userOrder.Order_time);
                listViewItem.SubItems.Add(userOrder.All_price);
                listViewItem.Tag = tag;
                userOrder_listView.Items.Add(listViewItem);
                tag += 1;
            }

        }


    }
}

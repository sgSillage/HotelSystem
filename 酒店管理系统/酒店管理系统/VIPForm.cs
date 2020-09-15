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
    public partial class VIPForm : Form
    {
        public VIPForm()
        {
            InitializeComponent();
            label1.Text = User.name;//在label上显示信息
            show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cost;
            cost = User.searchMembershipCost((User.viplevel + 1));
            User.pay(cost);
            User.GetVip((User.viplevel + 1), User.id);
            show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User.CancleVip(User.id);
            show();
        }
        private void show()
        {
            label2.Text = "您是VIP   " + User.viplevel + "   级会员";
            textBox_thegood.Text = User.PrivilegeForLevel(User.id);
        }
    }
}

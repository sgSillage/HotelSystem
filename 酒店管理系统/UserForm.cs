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
using 酒店管理系统;

namespace WindowsFormsApp1
{
    public partial class UserForm : Form
    {



        public UserForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            User.viplevel = User.CheckVip(User.id);
            VIPForm VipForm = new VIPForm();//这两段代码可以生成一个新窗口
            VipForm.Show();                 //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppServeForm ASForm = new AppServeForm();//这两段代码可以生成一个新窗口
            ASForm.Show();
        }

        private void RoomReserveClicked(object sender, EventArgs e)
        {
            ReserveRoomForm RRForm = new ReserveRoomForm();//这两段代码可以生成一个新窗口
            RRForm.Show();
        }

        private void SearchRecordClicked(object sender, EventArgs e)
        {
            UserOrderForm NForm = new UserOrderForm();
            NForm.Show();
            //User.SearchOrder(User.id.ToString());
        }

        private void SearchOrderClicked(object sender, EventArgs e)
        {
            User.SearchOrder(User.id.ToString());
        }

        private void CheckOutClicked(object sender, EventArgs e)
        {
            User.CheckOut();
        }

        private void ChangeRoomClicked(object sender, EventArgs e)
        {
            ChangeRoomForm RRForm = new ChangeRoomForm();//这两段代码可以生成一个新窗口
            RRForm.Show();
        }

        private void CommentClicked(object sender, EventArgs e)
        {
            CommentForm RRForm = new CommentForm();//这两段代码可以生成一个新窗口
            RRForm.Show();
        }

        private void pay_button_Click(object sender, EventArgs e)
        {
            PayForm pForm = new PayForm();//这两段代码可以生成一个新窗口
            pForm.Show();
        }
        private void button_fresh_Click(object sender, EventArgs e)
        {
            this.label_money.Text = User.searchWallet(User.id).ToString() + "元";
        }

        private void panel1_Paint(object sender, MouseEventArgs e)
        {
            this.label_money.Text = User.searchWallet(User.id).ToString() + "元";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.label_money.Text = User.searchWallet(User.id).ToString() + "元";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            cancelOrderForm cancelOrderForm = new cancelOrderForm();
            cancelOrderForm.Show();
            //this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            informationForm NFform = new informationForm();
            User.getInformation();
            NFform.Show();
        }
    }
}

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
    public partial class 会员信息 : Form
    {
        public 会员信息()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string user_id = User.user_id;
            this.label2.Text = user_id;
            /*
             * this.label4.Text=getUserName(string user_id);
             * this.label6.Text=getMembershipClass(string user_id);
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

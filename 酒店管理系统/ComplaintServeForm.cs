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
    public partial class ComplaintServeForm : Form
    {
        public string order_id;
        public ComplaintServeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string comlaintS = textBox3.Text;
            DateTime time = DateTime.Now;
            User.complaint(User.id.ToString(), order_id, comlaintS, time);
            MessageBox.Show("成功投诉！");
            Close();
        }
    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReceptionSection
{
    public partial class CheckOut : Form
    {
        public CheckOut()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!this.textBox2.Text.Equals(0))
            {
                //ChekckOut(this.textBox2.Text);
                MessageBox.Show("退房成功", "提示");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}

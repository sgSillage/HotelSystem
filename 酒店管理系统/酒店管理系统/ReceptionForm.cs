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
    public partial class ReceptionForm : Form
    {
        public ReceptionForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProcessService form5 = new ProcessService();
            form5.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CheckOut form7 = new CheckOut();
            form7.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckIn form2 = new CheckIn();
            form2.ShowDialog();
        }

        private void qiantai_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            QueryVIPInformation form3 = new QueryVIPInformation();
            form3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            QueryRoom form6 = new QueryRoom();
            form6.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangeRoom_Re form8 = new ChangeRoom_Re();
            form8.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelmanageSystem;

namespace ReceptionSection
{
    public partial class QueryVIPInformation : Form
    {
        public QueryVIPInformation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QueryVIPResult form4 = new QueryVIPResult();
            Vipid.vipid = this.textBox2.Text;
            form4.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}

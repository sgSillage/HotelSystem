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
    public partial class QueryVIPResult : Form
    {
        public QueryVIPResult()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string vipid = Vipid.vipid;
            /*var vip = Vip.find(e => e.vipid.Equals(vipid));
             * this.label2.Text=vip.vipid;
             * this.label4.Text=vip.name;
             * this.label6.Text=vip.level;
            */
        }
    }
}

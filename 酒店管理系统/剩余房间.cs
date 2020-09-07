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
    public partial class 剩余房间 : Form
    {
        public 剩余房间()
        {
            InitializeComponent();
        }

        private void 剩余房间_Load(object sender, EventArgs e)
        {
            this.label1.Text = room.type;
//            this.label2.Text = getNormalRoom(string type);
        }
    }
}

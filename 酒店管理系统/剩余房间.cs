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
        private DBLogin dbLogin;
        private int days;
        private string room_type;
        public 剩余房间()
        {
            InitializeComponent();
        }

        public 剩余房间(int ds, string r_type)
        {
            this.days = ds;
            this.room_type = r_type;
            dbLogin = new DBLogin();
            InitializeComponent();
        }

        private void 剩余房间_Load(object sender, EventArgs e)
        {
            System.DateTime currentTime = new DateTime();
            string s_time = currentTime.ToString("yyyy-MM-dd");
            string e_time = currentTime.AddDays(days).ToString("yyyy-MM-dd");
            List<Room> restRooms = dbLogin.GetRooms(s_time, e_time, room_type);
            int tag = 0;
            foreach(Room room in restRooms)
            {
                ListViewItem listViewItem = new ListViewItem(room.Number);
                listViewItem.SubItems.Add(room.Kind);
                listViewItem.SubItems.Add(room.IsNormal);
                listViewItem.Tag = tag;
                listViewRestRoom.Items.Add(listViewItem);
                tag++;
            }
        }
    }
}

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

namespace ReceptionSection
{
    public partial class CheckInRecordForm : Form
    {
        private string start_time;
        private string end_time;
        private DBLogin dbLogin;
        public CheckInRecordForm()
        {
            InitializeComponent();
            dbLogin = new DBLogin();
        }
        public CheckInRecordForm(string st, string en)
        {
            this.start_time = st;
            this.end_time = en;
            InitializeComponent();
            dbLogin = new DBLogin();
        }

        private void CheckInRecord_Load(object sender, EventArgs e)
        {
            List<CheckInRecord> checkins = dbLogin.GetCheckInRecords(start_time, end_time);
            int tag = 0;
            foreach (CheckInRecord checkin in checkins)
            {
                ListViewItem listViewItem = new ListViewItem(checkin.Identity);
                listViewItem.SubItems.Add(checkin.Name);
                listViewItem.SubItems.Add(checkin.Room_id);
                listViewItem.SubItems.Add(checkin.Lodger_time);
                listViewItem.SubItems.Add(checkin.Leave_time);
                listViewItem.Tag = tag;
                listViewCheckIn.Items.Add(listViewItem);
                tag++;
            }
        }


    }
}

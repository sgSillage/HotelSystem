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
    public partial class CheckInTimeForm : Form
    {
        public CheckInTimeForm()
        {
            InitializeComponent();
        }

        private void CheckInTimeForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void skinButtonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void skinButtonSearch_Click(object sender, EventArgs e)
        {
            string start = dateTimePickerStart.Value.ToShortDateString();
            string end = dateTimePickerEnd.Value.ToShortDateString();
            if(dateTimePickerStart.Value.CompareTo(dateTimePickerEnd.Value) > 0)
            {
                MessageBox.Show("起始时间晚于结束时间，请重新输入！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CheckInRecordForm checkInRecord = new CheckInRecordForm(start, end);
            this.Hide();
            checkInRecord.Owner = this.Owner;
            checkInRecord.Show();
        }
    }
}

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
using CCWin;
namespace HotelmanageSystem
{
    public partial class ManagerForm : Skin_Mac
    {
        public ManagerForm()
        {
            InitializeComponent();
        }
        private void tsmiAddroom_Click(object sender, EventArgs e)
        {
            AddroomForm addroomForm = new AddroomForm();
            addroomForm.MdiParent = this;
            addroomForm.Show();
        }

        private void tsbAddroom_Click(object sender, EventArgs e)
        {
            AddroomForm addroomForm = new AddroomForm();
            addroomForm.MdiParent = this;
            addroomForm.Show();
        }

        private void tsbHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void tsbCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tsmiQueryroom_Click(object sender, EventArgs e)
        {
            RoomListForm roomListForm = new RoomListForm();
            roomListForm.MdiParent = this;
            roomListForm.Show();
        }

        private void tsmiModifyroom_Click(object sender, EventArgs e)
        {
            RoomListForm roomListForm = new RoomListForm();
            roomListForm.MdiParent = this;
            roomListForm.Show();
        }

        private void tsmiAddemployee_Click(object sender, EventArgs e)
        {
            AddemployeeForm addemployeeForm = new AddemployeeForm();
            addemployeeForm.MdiParent = this;
            addemployeeForm.Show();
        }

        private void tsbAddemployee_Click(object sender, EventArgs e)
        {
            AddemployeeForm addemployeeForm = new AddemployeeForm();
            addemployeeForm.MdiParent = this;
            addemployeeForm.Show();
        }

        private void tsmiQueryemployee_Click(object sender, EventArgs e)
        {
            EmployeeListForm employeeListForm = new EmployeeListForm();
            employeeListForm.MdiParent = this;
            employeeListForm.Show();
        }

        private void tsmiModifyemployee_Click(object sender, EventArgs e)
        {
            EmployeeListForm employeeListForm = new EmployeeListForm();
            employeeListForm.MdiParent = this;
            employeeListForm.Show();
        }

        private void tsmiModifypassword_Click(object sender, EventArgs e)
        {
            ModifyPasswordForm modifyPasswordForm = new ModifyPasswordForm();
            modifyPasswordForm.MdiParent = this;
            modifyPasswordForm.Show();
        }

        private void tsmiIncost_Click(object sender, EventArgs e)
        {
            IncomeCostForm incomeCostForm = new IncomeCostForm();
            incomeCostForm.MdiParent = this;
            incomeCostForm.Show();
        }

        private void tsmiComplaint_Click(object sender, EventArgs e)
        {
            ComplaintForm complaintForm = new ComplaintForm();
            complaintForm.MdiParent = this;
            complaintForm.Show();
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("确定退出登录吗？", "退出提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.OK)
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelmanageSystem
{
    public partial class AddemployeeForm : Form
    {
        private DBHandler dBHandler;
        public AddemployeeForm()
        {
            InitializeComponent();
            dBHandler = new DBHandler();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtEmployeeID.Text)&& !string.IsNullOrEmpty(txtEmployeename.Text)&&
                cmbEmployeesex.SelectedItem!=null&& !string.IsNullOrWhiteSpace(mtxEmployeestatus.Text.Replace("-",""))&&
               !string.IsNullOrWhiteSpace(mtxEmployeephone.Text.Replace("-",""))&& !string.IsNullOrEmpty(txtEmployeesalary.Text)&& !string.IsNullOrWhiteSpace(mtxEmployeetime.Text.Replace("-",""))&&
                !string.IsNullOrEmpty(txtEmployeeposition.Text))//信息完整
            {
                if (dBHandler.isExistEmployee(txtEmployeeID.Text) || dBHandler.isExistEmployeeStatus(txtEmployeeID.Text))
                {
                    MessageBox.Show("员工编号或者身份证号已经存在，添加失败", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    bool isRight = true;
                    if (txtEmployeeID.Text.Length != 6)//员工编号不满足要求
                    {
                        isRight = false;
                        MessageBox.Show("员工编号的长度必须为6！", "出错提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    if (mtxEmployeestatus.Text.Replace(" ", "").Length != 20)//身份证号不满足要求
                    {
                        isRight = false;
                        MessageBox.Show("身份证号的长度不足18！", "出错提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    if (mtxEmployeephone.Text.Replace(" ", "").Length != 13)//电话号码的长度不满足要求
                    {
                        isRight = false;
                        MessageBox.Show("电话号码的长度不足11！", "出错提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    if (mtxEmployeetime.Text.Replace(" ", "").Length != 10)
                    {
                        isRight = false;
                        MessageBox.Show("入职时间格式为xxxx-xx-xx！", "出错提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    if (isRight)
                    {
                        dBHandler.AddEmployee(txtEmployeeID.Text, txtEmployeename.Text, cmbEmployeesex.SelectedItem.ToString(), mtxEmployeestatus.Text.Replace("-", ""), mtxEmployeephone.Text.Replace("-", ""), Convert.ToInt32(txtEmployeesalary.Text), mtxEmployeetime.Text, txtEmployeeposition.Text);
                        MessageBox.Show("添加成功！");
                    }
                }
            }
            else
            {
                MessageBox.Show("请输入完整的信息！", "出错提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)//清空
        {
            txtEmployeeID.Text = "";
            txtEmployeename.Text = "";
            txtEmployeesalary.Text = "";
            mtxEmployeestatus.Text = "";
            mtxEmployeestatus.Mask = "000000-00000000-000A";
            mtxEmployeephone.Text = "";
            mtxEmployeephone.Mask = "000-0000-0000";
            mtxEmployeetime.Text = "";
            mtxEmployeetime.Mask = "0000-00-00";
            txtEmployeeposition.Text = "";
        }
    }
}

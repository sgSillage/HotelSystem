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
    public partial class EmployeeListForm : Form
    {
        private string attribute;//记录属性名
        public EmployeeListForm()
        {
            InitializeComponent();
            attribute = "";
        }

        private void EmployeeListForm_Load(object sender, EventArgs e)
        {
            List<Employee> employees = new List<Employee>();
            //List<Employee> employees =GetEmployees();//获取员工列表
            int tag = 0;
            employees.Add(new Employee("001", "潘1", "男", "530302200006012416", "18687437921", 12000, "2020-06-06", "管理员"));
            employees.Add(new Employee("002", "潘2", "男", "530302200006012417", "18687437922", 12000, "2020-06-07", "管理员"));
            employees.Add(new Employee("003", "潘3", "男", "530302200006012418", "18687437923", 12000, "2020-06-08", "前台"));
            employees.Add(new Employee("004", "潘4", "男", "530302200006012419", "18687437924", 12000, "2020-06-09", "清洁工"));
            foreach(Employee employee in employees)//遍历，添加到表格中
            {
                ListViewItem listViewItem = new ListViewItem(employee.Number);
                listViewItem.SubItems.Add(employee.Name);
                listViewItem.SubItems.Add(employee.Sex);
                listViewItem.SubItems.Add(employee.Status);
                listViewItem.SubItems.Add(employee.Phone);
                listViewItem.SubItems.Add(employee.Salary.ToString());
                listViewItem.SubItems.Add(employee.Time);
                listViewItem.SubItems.Add(employee.Position);
                listViewItem.Tag = tag;
                lvwEmployee.Items.Add(listViewItem);
                tag++;//方便删除
            }
        }

        private void tsmiDeleteemployee_Click(object sender, EventArgs e)//删除员工
        {
            if (lvwEmployee.Items.Count <= 0)
            {
                MessageBox.Show("列表中没有任何信息！");
            }
            else if (lvwEmployee.SelectedItems.Count == 0)
            {
                MessageBox.Show("你没有选中任何项！");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("确认删除该员工的信息吗？请谨慎操作！", "删除提示",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)//确认删除
                {
                    int tid = (int)lvwEmployee.SelectedItems[0].Tag;
                    //DeleteEmployee(lvwEmployee.SelectedItems[0].SubItems[0].Text);
                    lvwEmployee.Items.RemoveAt(tid);
                    MessageBox.Show("成功删除！");
                }
            }
        }

        private void tsmiMan_Click(object sender, EventArgs e)//修改性别为男
        {
            if (lvwEmployee.Items.Count <= 0)
            {
                MessageBox.Show("列表中没有任何信息！");
            }
            else if (lvwEmployee.SelectedItems.Count == 0)
            {
                MessageBox.Show("你没有选中任何项！");
            }
            else
            {
                if (lvwEmployee.SelectedItems[0].SubItems[2].Text == "女")//女-->男
                {
                    lvwEmployee.SelectedItems[0].SubItems[2].Text = "男";
                    //ModifyEmployeesex(lvwEmployee.SelectedItems[0].SubItems[0].Text,"女");
                    MessageBox.Show("成功修改!");
                }
            }
        }

        private void tsmiWoman_Click(object sender, EventArgs e)//修改性别为女
        {
            if (lvwEmployee.Items.Count <= 0)
            {
                MessageBox.Show("列表中没有任何信息！");
            }
            else if (lvwEmployee.SelectedItems.Count == 0)
            {
                MessageBox.Show("你没有选中任何项！");
            }
            else
            {
                if (lvwEmployee.SelectedItems[0].SubItems[2].Text == "男")//男-->女
                {
                    lvwEmployee.SelectedItems[0].SubItems[2].Text = "女";
                    //ModifyEmployeesex(lvwEmployee.SelectedItems[0].SubItems[0].Text,"男");
                    MessageBox.Show("成功修改!");
                }
            }
        }

        private void tsmiModifyemployeeID_Click(object sender, EventArgs e)//修改员工编号
        {
            attribute = "员工编号";
            lblModifyemployee.Text = "请输入修改后的员工编号:";
            mtxEmployeeinfo.Mask = "";//掩码，下同
        }

        private void tsmiModifyemployeeName_Click(object sender, EventArgs e)//姓名
        {
            attribute = "员工姓名";
            lblModifyemployee.Text = "请输入修改后的员工姓名:";
            mtxEmployeeinfo.Mask = "";
        }

        private void tsmiModifyemployeeStatus_Click(object sender, EventArgs e)//身份证号
        {
            attribute = "身份证号";
            lblModifyemployee.Text = "请输入修改后的身份证号:";
            mtxEmployeeinfo.Mask = "000000-00000000-000A";
        }

        private void tamiModifyemployeePhone_Click(object sender, EventArgs e)//手机号
        {
            attribute = "电话号码";
            lblModifyemployee.Text = "请输入修改后的电话号码:";
            mtxEmployeeinfo.Mask = "000-0000-0000";
        }

        private void tsmiModifyemployeeSalary_Click(object sender, EventArgs e)//薪水
        {
            attribute = "员工薪水";
            lblModifyemployee.Text = "请输入修改后的员工薪水:";
            mtxEmployeeinfo.Mask = "";
        }

        private void tsmiModifyemployeeTime_Click(object sender, EventArgs e)//入职时间
        {
            attribute = "入职时间";
            lblModifyemployee.Text = "请输入修改后的入职时间:";
            mtxEmployeeinfo.Mask = "0000-00-00";
        }

        private void tsmiModifyemployeePosition_Click(object sender, EventArgs e)//岗位
        {
            attribute = "员工职位";
            lblModifyemployee.Text = "请输入修改后的员工职位:";
            mtxEmployeeinfo.Mask = "";
        }

        private void btnOK_Click(object sender, EventArgs e)//确认修改
        {
            if (lvwEmployee.Items.Count <= 0)
            {
                MessageBox.Show("列表中没有任何信息！");
            }
            else if (lvwEmployee.SelectedItems.Count == 0)
            {
                MessageBox.Show("你没有选中任何项！");
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(mtxEmployeeinfo.Text.Replace("-","")))//不为空
                {
                    if (attribute == "员工编号")
                    {
                        bool isExistID = false;
                        foreach (ListViewItem listViewItem in lvwEmployee.Items)//遍历看是否有重复的id
                        {
                            if (listViewItem.SubItems[0].Text ==mtxEmployeeinfo.Text )
                            {
                                isExistID = true;
                                break;
                            }
                        }
                        if (isExistID)
                        {
                            MessageBox.Show("员工编号已经存在，修改失败!");
                        }
                        else
                        {
                            lvwEmployee.SelectedItems[0].SubItems[0].Text = mtxEmployeeinfo.Text;
                            //ModifyEmployeeID(lvwEmployee.SelectedItems[0].SubItems[0].Text,mtxEmployeeinfo.Text);
                            MessageBox.Show("成功修改员工编号!");
                        }
                    }
                    else if (attribute == "员工姓名")
                    {
                        if (lvwEmployee.SelectedItems[0].SubItems[1].Text != mtxEmployeeinfo.Text)
                        {
                            lvwEmployee.SelectedItems[0].SubItems[1].Text = mtxEmployeeinfo.Text;
                            //ModifyEmployeename(lvwEmployee.SelectedItems[0].SubItems[0].Text,mtxEmployeeinfo.Text);
                            MessageBox.Show("成功修改员工姓名!");
                        }
                    }
                    else if (attribute == "身份证号")
                    {
                        bool isExistStatus = false;
                        foreach(ListViewItem listViewItem in lvwEmployee.Items)//有无重复身份证
                        {
                            if (listViewItem.SubItems[3].Text == mtxEmployeeinfo.Text.Replace("-", ""))
                            {
                                isExistStatus = true;
                                break;
                            }
                        }
                        if(!isExistStatus)
                        {
                            lvwEmployee.SelectedItems[0].SubItems[3].Text = mtxEmployeeinfo.Text.Replace("-", "");
                            //ModifyEmployeestatus(lvwEmployee.SelectedItems[0].SubItems[0].Text,mtxEmployeeinfo.Text.Replace("-","");
                            MessageBox.Show("成功修改身份证号!");
                        }
                        else
                        {
                            MessageBox.Show("员工身份证号已存在，修改失败");
                        }
                    }
                    else if (attribute == "电话号码")
                    {
                        bool isExistPhone = false;
                        foreach(ListViewItem listViewItem in lvwEmployee.Items)//有无重复电话
                        {
                            if (listViewItem.SubItems[4].Text == mtxEmployeeinfo.Text.Replace("-", ""))
                            {
                                isExistPhone = true;
                                break;
                            }
                        }
                        if (!isExistPhone)
                        {
                            lvwEmployee.SelectedItems[0].SubItems[4].Text = mtxEmployeeinfo.Text.Replace("-", "");
                            //ModifyEmployeephone(lvwEmployee.SelectedItems[0].SubItems[0].Text,mtxEmployeeinfo.Text.Replace("-","");
                            MessageBox.Show("成功修改电话号码!");
                        }
                        else
                        {
                            MessageBox.Show("电话号码已经存在，修改失败！");
                        }
                    }
                    else if (attribute == "员工薪水")
                    {
                        if (lvwEmployee.SelectedItems[0].SubItems[5].Text != mtxEmployeeinfo.Text)
                        {
                            lvwEmployee.SelectedItems[0].SubItems[5].Text = mtxEmployeeinfo.Text;
                            //ModifyEmployeesalary(lvwEmployee.SelectedItems[0].SubItems[0].Text,Convert.ToInt32(mtxEmployeeinfo.Text));
                            MessageBox.Show("成功修改员工薪水!");
                        }
                    }
                    else if (attribute == "入职时间")
                    {
                        if (lvwEmployee.SelectedItems[0].SubItems[6].Text != mtxEmployeeinfo.Text)
                        {
                            lvwEmployee.SelectedItems[0].SubItems[6].Text = mtxEmployeeinfo.Text;
                            //ModifyEmployeetime(lvwEmployee.SelectedItems[0].SubItems[0].Text,mtxEmployeeinfo.Text);
                            MessageBox.Show("成功修改入职时间!");
                        }
                    }
                    else if (attribute == "员工职位")
                    {
                        if (lvwEmployee.SelectedItems[0].SubItems[7].Text != mtxEmployeeinfo.Text)
                        {
                            lvwEmployee.SelectedItems[0].SubItems[7].Text = mtxEmployeeinfo.Text;
                            //ModifyEmployeeposition(lvwEmployee.SelectedItems[0].SubItems[0].Text,mtxEmployeeinfo.Text);
                            MessageBox.Show("成功修改员工职位!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("请先选定要修改的项目！");
                    }
                }
                else
                {
                    MessageBox.Show("请输入修改后的信息", "出错提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}

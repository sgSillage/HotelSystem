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
    public partial class ComplaintForm : Form
    {
        private DBHandler dBHandler;
        public ComplaintForm()
        {
            InitializeComponent();
            dBHandler = new DBHandler();
        }

        private void ComplaintForm_Load(object sender, EventArgs e)
        {
            int tag = 0;
            //List<Complaint> complaints = new List<Complaint>();
            List<Complaint> complaints = dBHandler.GetComplaints();//获取投诉列表
            //complaints.Add(new Complaint("000001", "100000", "2020-01-01"));
            //complaints.Add(new Complaint("000002", "200000", "2020-01-02"));
            //complaints.Add(new Complaint("000003", "300000", "2020-01-03"));
            foreach(Complaint complaint in complaints)//添加列表项
            {
                ListViewItem listViewItem = new ListViewItem(complaint.Com_id);
                listViewItem.SubItems.Add(complaint.Order_id);
                listViewItem.SubItems.Add(complaint.Com_time);
                listViewItem.Tag = tag;
                tag++;//方便删除
                lvwComplaint.Items.Add(listViewItem);
            }
        }

        private void tsmiViewdetails_Click(object sender, EventArgs e)//查看投诉详情
        {
            if (lvwComplaint.Items.Count <= 0)
            {
                MessageBox.Show("列表中没有任何信息！");
            }
            else if (lvwComplaint.SelectedItems.Count == 0)
            {
                MessageBox.Show("你没有选中任何项！");
            }
            else
            {
                ComplaintDetailsForm complaintDetailsForm = new ComplaintDetailsForm
                    (lvwComplaint.SelectedItems[0].SubItems[0].Text, 
                    lvwComplaint.SelectedItems[0].SubItems[1].Text, 
                    lvwComplaint.SelectedItems[0].SubItems[2].Text);
                complaintDetailsForm.Show();
            }
        }

        private void tsmiDetelecomplaint_Click(object sender, EventArgs e)//删除投诉
        {
            if (lvwComplaint.Items.Count <= 0)
            {
                MessageBox.Show("列表中没有任何信息！");
            }
            else if (lvwComplaint.SelectedItems.Count == 0)
            {
                MessageBox.Show("你没有选中任何项！");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("确认删除该投诉吗？请谨慎操作！", "删除提示",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    int tag = (int)lvwComplaint.SelectedItems[0].Tag;
                    dBHandler.DeleteComplaint(lvwComplaint.SelectedItems[0].SubItems[0].Text);//删除该条投诉
                    lvwComplaint.Items.RemoveAt(tag);
                    MessageBox.Show("删除成功！");
                }
            }
        }
    }
}

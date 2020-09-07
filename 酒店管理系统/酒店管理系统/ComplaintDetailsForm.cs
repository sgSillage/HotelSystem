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
    public partial class ComplaintDetailsForm : Form
    {
        private string com_id;
        private string order_id;
        private string com_time;
        public ComplaintDetailsForm()
        {
            InitializeComponent();
        }
        public ComplaintDetailsForm(string cid,string oid,string ctime)
        {
            InitializeComponent();
            this.com_id = cid;
            this.order_id = oid;
            this.com_time = ctime;
        }

        private void ComplaintDetailsForm_Load(object sender, EventArgs e)
        {
            txtID.Text = com_id;
            txtOrder_id.Text = order_id;
            txtCom_time.Text = com_time;
            List<string> emp_ids = new List<string>();
            txtEmp_ids.Text = "";
            //List<string>emp_ids=GetSer_emp_ids(string com_id);//获取提供相关服务的用户的id
            emp_ids.Add("001");
            emp_ids.Add("002");
            emp_ids.Add("003");
            foreach(string str in emp_ids)
            {
                txtEmp_ids.Text += str + "\r\n";
            }
           // txtCom_content.Text=GetComplaintContent(com_id);//获取投诉内容
        }
    }
}

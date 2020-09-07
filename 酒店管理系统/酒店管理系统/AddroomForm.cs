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
    public partial class AddroomForm : Form
    {
        public AddroomForm()
        {
            InitializeComponent();
        }

        private void txtRoomkind_TextChanged(object sender, EventArgs e)
        {  
            /*int price=GetRoomprice(txtRoomkind.Text);
             * if(price>0)txtRoomprice.Text=price.toString();
             */
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtRoom_no.Text = "";
            txtRoomkind.Text = "";
            cmbIsnormal.SelectedItem = "";
            txtRoomprice.Text = "";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtRoom_no.Text)&& !string.IsNullOrEmpty(txtRoomkind.Text)&&
                cmbIsnormal.SelectedItem!=null && !string.IsNullOrEmpty(txtRoomprice.Text))//信息完整
            {
                //if (IsExistRoom(txtRoom_no.Text))
                //{
                //    MessageBox.Show("房间号" + txtRoom_no.Text + "已经存在，添加失败", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //}
                MessageBox.Show(string.Format("{0},{1},{2},{3}",
                    txtRoom_no.Text, txtRoomkind.Text, cmbIsnormal.SelectedItem, txtRoomprice.Text));
                // else{

                //AddRoom(txtRoom_no.Text, txtRoomkind.Text, cmbIsnormal.SelectedItem.ToString(), txtRoomprice.Text);
                MessageBox.Show("添加成功！", "成功提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
            }
            else
            {
                MessageBox.Show("请输入完整的信息！","出错提示",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void AddroomForm_Load(object sender, EventArgs e)
        {

        }
    }
}

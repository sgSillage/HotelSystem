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
        private DBHandler dBHandler;
        public AddroomForm()
        {
            InitializeComponent();
            dBHandler = new DBHandler();
        }

        private void txtRoomkind_TextChanged(object sender, EventArgs e)
        {  
            int price=dBHandler.GetRoomprice(txtRoomkind.Text);
            if(price>0)txtRoomprice.Text=price.ToString();
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
            if (!string.IsNullOrEmpty(txtRoom_no.Text)&& !string.IsNullOrEmpty(txtRoomkind.Text)&&
                cmbIsnormal.SelectedItem!=null && !string.IsNullOrEmpty(txtRoomprice.Text))//信息完整
            {
                if (dBHandler.isExistRoom(txtRoom_no.Text))
                {
                    MessageBox.Show("房间号" + txtRoom_no.Text + "已经存在，添加失败", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
               
                else
                {
                    bool isRight = true;
                    if (txtRoom_no.Text.Length != 4)//房间号的长度不满足要求
                    {
                        isRight = false;
                        MessageBox.Show("房间号的长度必须为4！", "出错提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    if (isRight)//信息满足要求
                    {
                        dBHandler.AddRoom(txtRoom_no.Text, txtRoomkind.Text, cmbIsnormal.SelectedItem.ToString(), Convert.ToInt32(txtRoomprice.Text));
                        MessageBox.Show("添加成功！", "成功提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("请输入完整的信息！","出错提示",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

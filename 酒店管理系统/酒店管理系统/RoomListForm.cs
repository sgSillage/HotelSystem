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
    public partial class RoomListForm : Form
    {
        private string attribute;//记录属性名
        public RoomListForm()
        {
            InitializeComponent();
            attribute = "";
        }
        
        private void RoomListForm_Load(object sender, EventArgs e)
        {
            List<Room> rooms= rooms = new List<Room>();
            int tag = 0;
                //List<Room> rooms = GetRooms();//获取房间列表
            rooms.Add(new Room("001", "单人间", 1, 100));
            rooms.Add(new Room("002", "双人间", 1, 120));
            rooms.Add(new Room("003", "大床房", 1, 110));
            rooms.Add(new Room("004", "双人间", 0, 120));
            foreach(Room room in rooms)
            {
                ListViewItem listViewItem = new ListViewItem(room.Number);
                listViewItem.SubItems.Add(room.Kind);
                listViewItem.SubItems.Add(room.IsNormal);
                listViewItem.SubItems.Add(room.Price.ToString());
                listViewItem.Tag = tag;
                tag++;
                lvwRoom.Items.Add(listViewItem);
            }
        }

        private void tsmiYes_Click(object sender, EventArgs e)
        {
            if (lvwRoom.Items.Count <= 0)
            {
                MessageBox.Show("列表中没有任何信息！");
            }
            else if(lvwRoom.SelectedItems.Count==0)
            {
                MessageBox.Show("你没有选中任何项！");
            }
            else
            {
                if(lvwRoom.SelectedItems[0].SubItems[2].Text == "否")//否-->是
                {
                    lvwRoom.SelectedItems[0].SubItems[2].Text = "是";
                    //ModifyIsnormal(lvwRoom.SelectedItems[0].SubItems[0].Text,"是");
                    MessageBox.Show("成功修改!");
                }
            }
        }

        private void tsmiNo_Click(object sender, EventArgs e)//是-->否
        {
            if (lvwRoom.Items.Count <= 0)
            {
                MessageBox.Show("列表中没有任何信息！");
            }
            else if (lvwRoom.SelectedItems.Count == 0)
            {
                MessageBox.Show("你没有选中任何项！");
            }
            else
            {
                if (lvwRoom.SelectedItems[0].SubItems[2].Text == "是")
                {
                    lvwRoom.SelectedItems[0].SubItems[2].Text = "否";
                    //ModifyIsnormal(lvwRoom.SelectedItems[0].SubItems[0].Text,"否");
                    MessageBox.Show("成功修改!");
                }
            }
        }

        private void tsmiDeleteroom_Click(object sender, EventArgs e)//删除房间
        {
            if (lvwRoom.Items.Count <= 0)
            {
                MessageBox.Show("列表中没有任何信息！");
            }
            else if (lvwRoom.SelectedItems.Count == 0)
            {
                MessageBox.Show("你没有选中任何项！");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("确认删除该房间的信息吗？请谨慎操作！", "删除提示",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    int tid = (int)lvwRoom.SelectedItems[0].Tag;
                    //DeleteRoom(lvwRoom.SelectedItems[0].SubItems[0].Text);
                    lvwRoom.Items.RemoveAt(tid);
                    MessageBox.Show("成功删除！");
                }
            }
        }

        private void btnModifyroom_Click(object sender, EventArgs e)
        {
            if (lvwRoom.Items.Count <= 0)
            {
                MessageBox.Show("列表中没有任何信息！");
            }
            else if (lvwRoom.SelectedItems.Count == 0)
            {
                MessageBox.Show("你没有选中任何项！");
            }
            else
            {
                if (!string.IsNullOrEmpty(txtRoominfo.Text))//不为空
                {
                    if (attribute == "房间号")
                    {
                        bool IsExistNo = false;
                        foreach (ListViewItem listViewItem in lvwRoom.Items)//是否存在重复的房间号
                        {
                            if (listViewItem.SubItems[0].Text == txtRoominfo.Text)
                            {
                                IsExistNo = true;
                                break;
                            }
                        }
                        if (IsExistNo)
                        {
                            MessageBox.Show("房间号已经存在，修改失败！");
                        }
                        else{
                        //ModifyRoom_no(RoomListForm.lvwRoom.SelectedItems[0].SubItems[0].Text,txtRoominfo.Text);
                        lvwRoom.SelectedItems[0].SubItems[0].Text = txtRoominfo.Text;
                        MessageBox.Show("成功修改房间号！");
                        txtRoominfo.Text = "";
                        }
                    }
                    else if (attribute == "房间类型")//修改房间类型会导致房间价格改变
                    {
                        bool IsExistKind = false;
                        string price="";
                        foreach (ListViewItem listViewItem in lvwRoom.Items)//是否存在该房间类型
                        {
                            if (listViewItem.SubItems[1].Text == txtRoominfo.Text)
                            {
                                IsExistKind = true;
                                price = listViewItem.SubItems[3].Text;
                                break;
                            }
                        }
                        if (IsExistKind)
                        {
                            //ModifyRoomkind(lvwRoom.SelectedItems[0].SubItems[0].Text,txtRoominfo.Text);
                            lvwRoom.SelectedItems[0].SubItems[1].Text = txtRoominfo.Text;
                            lvwRoom.SelectedItems[0].SubItems[3].Text = price;
                            MessageBox.Show("成功修改房间类型！");
                            txtRoominfo.Text = "";
                        }
                        else//新的房间类型
                        {
                            DialogResult dialogResult = MessageBox.Show(txtRoominfo.Text + "为新的房间类型，需给出新的房价",
                                "修改房间类型提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (dialogResult == DialogResult.Yes)
                            {
                                string kind = txtRoominfo.Text;
                                //AddRoomKind(kind,Convert.ToInt32(lvwRoom.SelectedItems[0].SubItems[3].Text));
                                lvwRoom.SelectedItems[0].SubItems[1].Text = kind;
                                MessageBox.Show("需再修改该房间的价格才能成功修改房间类型！");
                                txtRoominfo.Text = "";
                            }
                        }
                    }
                    else if(attribute=="房间价格")//修改房间价格导致同类型的房间价格变化
                    {
                        DialogResult dialogResult = MessageBox.Show("修改该房间的价格会导致同类型的房间价格改变！谨慎修改",
                            "修改房价提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (dialogResult == DialogResult.OK)
                        {
                            string kind = lvwRoom.SelectedItems[0].SubItems[1].Text;
                            //ModifyRoomprice(lvwRoom.SelectedItems[0].SubItems[2].Text,Convert.ToInt32(txtRoominfo.Text));
                            foreach (ListViewItem listViewItem in lvwRoom.Items)
                            {
                                if (listViewItem.SubItems[1].Text == kind)
                                {
                                    listViewItem.SubItems[3].Text = txtRoominfo.Text;
                                }
                            }
                            MessageBox.Show("成功修改房间价格！");
                            txtRoominfo.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("请先选定要修改的项目！");
                    }
                }
                else
                {
                    MessageBox.Show("请输入修改后的信息","出错提示",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
        }

        private void tsmiModifyroom_no_Click(object sender, EventArgs e)//修改房间号
        {
            attribute = "房间号";
            lblModifyRoom.Text = "请输入修改后的房间号:";
            txtRoominfo.Text = "";
        }

        private void tsmiModifyroomkind_Click(object sender, EventArgs e)//修改房间类型
        {
            attribute = "房间类型";
            lblModifyRoom.Text = "请输入修改后的房间类型:";
            txtRoominfo.Text = "";
        }

        private void tsmiModifyroomprice_Click(object sender, EventArgs e)//修改房间价格
        {
            attribute = "房间价格";
            lblModifyRoom.Text = "请输入修改后的房间价格:";
            txtRoominfo.Text = "";
        }
    }
}

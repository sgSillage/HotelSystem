using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace 酒店管理系统
{
    public partial class informationForm : Form
    {
        public informationForm()
        {
            InitializeComponent();
            User.getInformation();
            label_phone.Text = User.phone;
            label_id.Text = User.id.ToString();
        }

        private void button_changPassword_Click(object sender, EventArgs e)
        {
            changPasswordForm NForm = new changPasswordForm();
            NForm.Show();
        }

        private void button_identity_Click(object sender, EventArgs e)
        {
            label_name.Text = User.name;
            label_sex.Text = User.gender;
            label_iden.Text = User.identity;
            panel_iden.Visible = true;
            panel_phone.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel_iden.Visible = false;
        }

        private void label_phone_Click(object sender, EventArgs e)
        {
            panel_phone.Visible = true;
            textBox_phone.Text = label_phone.Text;
            button_phone.Visible = false;
            
        }

        private void informationForm_Load(object sender, EventArgs e)
        {
            panel_phone.Visible = false;
        }

        private void textBox_phone_TextChanged(object sender, EventArgs e)
        {
            button_phone.Visible = true;
        }

        private void button_phone_Click(object sender, EventArgs e)
        {
            if (User.changePhone(textBox_phone.Text))
            {
                label_phone.Text = textBox_phone.Text;
                MessageBox.Show("修改成功");
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }
    }
}

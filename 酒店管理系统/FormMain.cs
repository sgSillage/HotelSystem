using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using HotelmanageSystem;
using WindowsFormsApp1;
using ReceptionSection;

namespace LoginRegisterFrame
{
    public partial class MainForm : Form
    {
        FormRegister register = new FormRegister();
        FindAccount findAccount = new FindAccount();
        FindPassword findPassword = new FindPassword();

        private Button buttonLogin;
        private Label labelPassword;
        private Label labelAccount;
        private Label labelCategory;
        private TextBox textBoxPassword;
        private TextBox textBoxAccount;
        private ComboBox comboBoxCatagory;
        private Label label3;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private Button buttonRegister;
        private DBLogin dbLogin;

        public MainForm()
        {
            InitializeComponent();
            dbLogin = new DBLogin();
        }

        private void InitializeComponent()
        {
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelAccount = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxAccount = new System.Windows.Forms.TextBox();
            this.comboBoxCatagory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(510, 308);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(85, 40);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(675, 308);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(85, 40);
            this.buttonRegister.TabIndex = 1;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(429, 237);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(80, 18);
            this.labelPassword.TabIndex = 13;
            this.labelPassword.Text = "Password";
            // 
            // labelAccount
            // 
            this.labelAccount.AutoSize = true;
            this.labelAccount.Location = new System.Drawing.Point(429, 183);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(71, 18);
            this.labelAccount.TabIndex = 12;
            this.labelAccount.Text = "Account";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(429, 125);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(80, 18);
            this.labelCategory.TabIndex = 11;
            this.labelCategory.Text = "Category";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(550, 234);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(267, 28);
            this.textBoxPassword.TabIndex = 10;
            // 
            // textBoxAccount
            // 
            this.textBoxAccount.Location = new System.Drawing.Point(550, 180);
            this.textBoxAccount.Name = "textBoxAccount";
            this.textBoxAccount.Size = new System.Drawing.Size(267, 28);
            this.textBoxAccount.TabIndex = 9;
            // 
            // comboBoxCatagory
            // 
            this.comboBoxCatagory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCatagory.FormattingEnabled = true;
            this.comboBoxCatagory.Items.AddRange(new object[] {
            "顾客",
            "前台",
            "管理员"});
            this.comboBoxCatagory.Location = new System.Drawing.Point(550, 122);
            this.comboBoxCatagory.Name = "comboBoxCatagory";
            this.comboBoxCatagory.Size = new System.Drawing.Size(267, 26);
            this.comboBoxCatagory.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(666, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "或";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(578, 269);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(98, 18);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "忘记账号？";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(694, 269);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(98, 18);
            this.linkLabel2.TabIndex = 18;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "忘记密码？";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(861, 489);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelAccount);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxAccount);
            this.Controls.Add(this.comboBoxCatagory);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonLogin);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            int category = 0;
            string id = textBoxAccount.Text;
            string password = textBoxPassword.Text;
            switch(comboBoxCatagory.Text)
            {
                case "顾客": category = 1;break;
                case "前台": category = 2;break;
                case "管理员":category = 3;break;
            }

            if(category == 0)
            {
                MessageBox.Show("请选择登陆ID的类别", "");
                return;
            }
            if(id ==""||password=="")
            {
                MessageBox.Show("请输入ID或密码！", "");
                return;
            }
            bool isID = false;
            bool isPassword = false;

            //登录函数调用，并返回int类型数据，其含义如下
            //-1--找不到该用户ID
            //0--密码错误
            //1--登陆成功
            switch(dbLogin.LoginSystem(category,id,password))
            {
                case -1:break;
                case 0:isID = true; break;
                case 1:isID = true;isPassword = true; break;
            }

            if (isID == false)
            {
                MessageBox.Show("无此用户ID,请重试", "");
            }
            else if (isID == true && isPassword == false)
            {
                MessageBox.Show("密码错误，请重试", "");
            }
            else if (isID && isPassword)
            {
                if (comboBoxCatagory.Text == "管理员")
                {
                    ManagerForm managerForm = new ManagerForm();
                    managerForm.Owner = this;
                    this.Hide();
                    managerForm.Show();
                }
                else if (comboBoxCatagory.Text == "顾客")
                {
                    UserForm userForm = new UserForm();
                    userForm.Owner = this;
                    this.Hide();
                    userForm.Show();
                }
                else if (comboBoxCatagory.Text == "前台")
                {
                    qiantai receptionForm = new qiantai();
                    receptionForm.Owner = this;
                    this.Hide();
                    receptionForm.Show();
                }
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            register.Owner = this;
            this.Hide();
            register.Show();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            findAccount.Owner = this;
            this.Hide();
            findAccount.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            findPassword.Owner = this;
            this.Hide();
            findPassword.Show();
        }
    }
}

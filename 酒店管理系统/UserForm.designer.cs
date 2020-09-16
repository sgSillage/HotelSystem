namespace WindowsFormsApp1
{
    partial class UserForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.vip_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pay_button = new System.Windows.Forms.Button();
            this.label_text = new System.Windows.Forms.Label();
            this.label_money = new System.Windows.Forms.Label();
            this.button_fresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-1, 177);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "客房服务";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vip_button
            // 
            this.vip_button.Location = new System.Drawing.Point(143, 2);
            this.vip_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vip_button.Name = "vip_button";
            this.vip_button.Size = new System.Drawing.Size(125, 52);
            this.vip_button.TabIndex = 4;
            this.vip_button.Text = "会员服务";
            this.vip_button.UseVisualStyleBackColor = true;
            this.vip_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(-1, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 55);
            this.button2.TabIndex = 5;
            this.button2.Text = "预定房间";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.RoomReserveClicked);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(143, 176);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 55);
            this.button4.TabIndex = 6;
            this.button4.Text = "查询房间订单";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.SearchOrderClicked);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(143, 90);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 55);
            this.button5.TabIndex = 7;
            this.button5.Text = "查看入住记录";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.SearchRecordClicked);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(145, 335);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(123, 55);
            this.button6.TabIndex = 8;
            this.button6.Text = "退房";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.CheckOutClicked);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(-1, 90);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(123, 55);
            this.button7.TabIndex = 9;
            this.button7.Text = "更换房间";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.ChangeRoomClicked);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(145, 254);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(123, 55);
            this.button8.TabIndex = 10;
            this.button8.Text = "评论酒店";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.CommentClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button_fresh);
            this.panel1.Controls.Add(this.label_money);
            this.panel1.Controls.Add(this.label_text);
            this.panel1.Location = new System.Drawing.Point(289, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 307);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pay_button
            // 
            this.pay_button.Location = new System.Drawing.Point(-1, 254);
            this.pay_button.Name = "pay_button";
            this.pay_button.Size = new System.Drawing.Size(122, 54);
            this.pay_button.TabIndex = 11;
            this.pay_button.Text = "充值";
            this.pay_button.UseVisualStyleBackColor = true;
            this.pay_button.Click += new System.EventHandler(this.pay_button_Click);
            // 
            // label_text
            // 
            this.label_text.AutoSize = true;
            this.label_text.Font = new System.Drawing.Font("华文彩云", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_text.Location = new System.Drawing.Point(6, 39);
            this.label_text.Name = "label_text";
            this.label_text.Size = new System.Drawing.Size(399, 73);
            this.label_text.TabIndex = 0;
            this.label_text.Text = "您的钱包 ：";
            // 
            // label_money
            // 
            this.label_money.AutoSize = true;
            this.label_money.Font = new System.Drawing.Font("华文彩云", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_money.Location = new System.Drawing.Point(26, 137);
            this.label_money.Name = "label_money";
            this.label_money.Size = new System.Drawing.Size(159, 73);
            this.label_money.TabIndex = 1;
            this.label_money.Text = " 0元";
            this.label_money.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_fresh
            // 
            this.button_fresh.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_fresh.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_fresh.Location = new System.Drawing.Point(333, 2);
            this.button_fresh.Name = "button_fresh";
            this.button_fresh.Size = new System.Drawing.Size(71, 34);
            this.button_fresh.TabIndex = 2;
            this.button_fresh.Text = "刷新";
            this.button_fresh.UseVisualStyleBackColor = false;
            this.button_fresh.Click += new System.EventHandler(this.button_fresh_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 410);
            this.Controls.Add(this.pay_button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.vip_button);
            this.Controls.Add(this.button6);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserForm";
            this.Text = "用户程序";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button vip_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button pay_button;
        private System.Windows.Forms.Label label_money;
        private System.Windows.Forms.Label label_text;
        private System.Windows.Forms.Button button_fresh;
    }
}


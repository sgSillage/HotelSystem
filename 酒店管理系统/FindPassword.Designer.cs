namespace LoginRegisterFrame
{
    partial class FindPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonFindPCancel = new System.Windows.Forms.Button();
            this.buttonSet = new System.Windows.Forms.Button();
            this.labelAccount = new System.Windows.Forms.Label();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.labelNewPassword_re = new System.Windows.Forms.Label();
            this.labelIdentity = new System.Windows.Forms.Label();
            this.textBoxAccount = new System.Windows.Forms.TextBox();
            this.textBoxIdentity = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword_re = new System.Windows.Forms.TextBox();
            this.labelRemain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonFindPCancel
            // 
            this.buttonFindPCancel.Location = new System.Drawing.Point(436, 309);
            this.buttonFindPCancel.Name = "buttonFindPCancel";
            this.buttonFindPCancel.Size = new System.Drawing.Size(102, 37);
            this.buttonFindPCancel.TabIndex = 17;
            this.buttonFindPCancel.Text = "取消";
            this.buttonFindPCancel.UseVisualStyleBackColor = true;
            this.buttonFindPCancel.Click += new System.EventHandler(this.buttonFindPCancel_Click);
            // 
            // buttonSet
            // 
            this.buttonSet.Location = new System.Drawing.Point(270, 309);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(102, 37);
            this.buttonSet.TabIndex = 16;
            this.buttonSet.Text = "修改";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // labelAccount
            // 
            this.labelAccount.AutoSize = true;
            this.labelAccount.Location = new System.Drawing.Point(101, 89);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(187, 15);
            this.labelAccount.TabIndex = 18;
            this.labelAccount.Text = "请输入要找回密码的账号：\r\n";
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.Location = new System.Drawing.Point(176, 187);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(112, 15);
            this.labelNewPassword.TabIndex = 19;
            this.labelNewPassword.Text = "重置后的密码：";
            // 
            // labelNewPassword_re
            // 
            this.labelNewPassword_re.AutoSize = true;
            this.labelNewPassword_re.Location = new System.Drawing.Point(161, 239);
            this.labelNewPassword_re.Name = "labelNewPassword_re";
            this.labelNewPassword_re.Size = new System.Drawing.Size(127, 15);
            this.labelNewPassword_re.TabIndex = 20;
            this.labelNewPassword_re.Text = "重新输入新密码：";
            // 
            // labelIdentity
            // 
            this.labelIdentity.AutoSize = true;
            this.labelIdentity.Location = new System.Drawing.Point(191, 138);
            this.labelIdentity.Name = "labelIdentity";
            this.labelIdentity.Size = new System.Drawing.Size(97, 15);
            this.labelIdentity.TabIndex = 21;
            this.labelIdentity.Text = "身份证号码：";
            // 
            // textBoxAccount
            // 
            this.textBoxAccount.Location = new System.Drawing.Point(313, 86);
            this.textBoxAccount.Name = "textBoxAccount";
            this.textBoxAccount.Size = new System.Drawing.Size(260, 25);
            this.textBoxAccount.TabIndex = 22;
            // 
            // textBoxIdentity
            // 
            this.textBoxIdentity.Location = new System.Drawing.Point(313, 135);
            this.textBoxIdentity.Name = "textBoxIdentity";
            this.textBoxIdentity.Size = new System.Drawing.Size(260, 25);
            this.textBoxIdentity.TabIndex = 23;
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(313, 184);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(260, 25);
            this.textBoxNewPassword.TabIndex = 24;
            // 
            // textBoxNewPassword_re
            // 
            this.textBoxNewPassword_re.Location = new System.Drawing.Point(313, 236);
            this.textBoxNewPassword_re.Name = "textBoxNewPassword_re";
            this.textBoxNewPassword_re.Size = new System.Drawing.Size(260, 25);
            this.textBoxNewPassword_re.TabIndex = 25;
            // 
            // labelRemain
            // 
            this.labelRemain.AutoSize = true;
            this.labelRemain.ForeColor = System.Drawing.Color.Red;
            this.labelRemain.Location = new System.Drawing.Point(310, 212);
            this.labelRemain.Name = "labelRemain";
            this.labelRemain.Size = new System.Drawing.Size(175, 15);
            this.labelRemain.TabIndex = 26;
            this.labelRemain.Text = "*:请输入9~20位的密码！";
            // 
            // FindPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelRemain);
            this.Controls.Add(this.textBoxNewPassword_re);
            this.Controls.Add(this.textBoxNewPassword);
            this.Controls.Add(this.textBoxIdentity);
            this.Controls.Add(this.textBoxAccount);
            this.Controls.Add(this.labelIdentity);
            this.Controls.Add(this.labelNewPassword_re);
            this.Controls.Add(this.labelNewPassword);
            this.Controls.Add(this.labelAccount);
            this.Controls.Add(this.buttonFindPCancel);
            this.Controls.Add(this.buttonSet);
            this.Name = "FindPassword";
            this.Text = "找回密码";
            this.Load += new System.EventHandler(this.FindPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFindPCancel;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.Label labelNewPassword_re;
        private System.Windows.Forms.Label labelIdentity;
        private System.Windows.Forms.TextBox textBoxAccount;
        private System.Windows.Forms.TextBox textBoxIdentity;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.TextBox textBoxNewPassword_re;
        private System.Windows.Forms.Label labelRemain;
    }
}
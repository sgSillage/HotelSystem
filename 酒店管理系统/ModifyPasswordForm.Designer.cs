namespace HotelmanageSystem
{
    partial class ModifyPasswordForm
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
            this.rdoUser = new System.Windows.Forms.RadioButton();
            this.rdoFront = new System.Windows.Forms.RadioButton();
            this.rdoManager = new System.Windows.Forms.RadioButton();
            this.lblTips = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblNewpassword = new System.Windows.Forms.Label();
            this.txtNewpassword = new System.Windows.Forms.TextBox();
            this.lblNewpassword1 = new System.Windows.Forms.Label();
            this.txtNewpassword1 = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdoUser
            // 
            this.rdoUser.AutoSize = true;
            this.rdoUser.Location = new System.Drawing.Point(77, 95);
            this.rdoUser.Name = "rdoUser";
            this.rdoUser.Size = new System.Drawing.Size(69, 22);
            this.rdoUser.TabIndex = 0;
            this.rdoUser.TabStop = true;
            this.rdoUser.Text = "用户";
            this.rdoUser.UseVisualStyleBackColor = true;
            this.rdoUser.CheckedChanged += new System.EventHandler(this.rdoUser_CheckedChanged);
            // 
            // rdoFront
            // 
            this.rdoFront.AutoSize = true;
            this.rdoFront.Location = new System.Drawing.Point(246, 95);
            this.rdoFront.Name = "rdoFront";
            this.rdoFront.Size = new System.Drawing.Size(69, 22);
            this.rdoFront.TabIndex = 1;
            this.rdoFront.TabStop = true;
            this.rdoFront.Text = "前台";
            this.rdoFront.UseVisualStyleBackColor = true;
            this.rdoFront.CheckedChanged += new System.EventHandler(this.rdoFront_CheckedChanged);
            // 
            // rdoManager
            // 
            this.rdoManager.AutoSize = true;
            this.rdoManager.Location = new System.Drawing.Point(401, 95);
            this.rdoManager.Name = "rdoManager";
            this.rdoManager.Size = new System.Drawing.Size(87, 22);
            this.rdoManager.TabIndex = 2;
            this.rdoManager.TabStop = true;
            this.rdoManager.Text = "管理员";
            this.rdoManager.UseVisualStyleBackColor = true;
            this.rdoManager.CheckedChanged += new System.EventHandler(this.rdoManager_CheckedChanged);
            // 
            // lblTips
            // 
            this.lblTips.AutoSize = true;
            this.lblTips.Location = new System.Drawing.Point(31, 45);
            this.lblTips.Name = "lblTips";
            this.lblTips.Size = new System.Drawing.Size(269, 18);
            this.lblTips.TabIndex = 3;
            this.lblTips.Text = "请选择将要修改密码的人员类型:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(34, 162);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(53, 18);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "账号:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(197, 162);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(204, 28);
            this.txtID.TabIndex = 5;
            // 
            // lblNewpassword
            // 
            this.lblNewpassword.AutoSize = true;
            this.lblNewpassword.Location = new System.Drawing.Point(31, 235);
            this.lblNewpassword.Name = "lblNewpassword";
            this.lblNewpassword.Size = new System.Drawing.Size(71, 18);
            this.lblNewpassword.TabIndex = 6;
            this.lblNewpassword.Text = "新密码:";
            // 
            // txtNewpassword
            // 
            this.txtNewpassword.Location = new System.Drawing.Point(197, 225);
            this.txtNewpassword.MaxLength = 20;
            this.txtNewpassword.Name = "txtNewpassword";
            this.txtNewpassword.PasswordChar = '*';
            this.txtNewpassword.Size = new System.Drawing.Size(204, 28);
            this.txtNewpassword.TabIndex = 7;
            // 
            // lblNewpassword1
            // 
            this.lblNewpassword1.AutoSize = true;
            this.lblNewpassword1.Location = new System.Drawing.Point(34, 292);
            this.lblNewpassword1.Name = "lblNewpassword1";
            this.lblNewpassword1.Size = new System.Drawing.Size(143, 18);
            this.lblNewpassword1.TabIndex = 8;
            this.lblNewpassword1.Text = "再次输入新密码:";
            // 
            // txtNewpassword1
            // 
            this.txtNewpassword1.Location = new System.Drawing.Point(197, 281);
            this.txtNewpassword1.MaxLength = 20;
            this.txtNewpassword1.Name = "txtNewpassword1";
            this.txtNewpassword1.PasswordChar = '*';
            this.txtNewpassword1.Size = new System.Drawing.Size(204, 28);
            this.txtNewpassword1.TabIndex = 9;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOK.Image = global::酒店管理系统.Properties.Resources.symbol_check_icon;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(246, 359);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(79, 40);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "确定";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.Image = global::酒店管理系统.Properties.Resources.delete_icon;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(475, 359);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 40);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "取消";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // ModifyPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtNewpassword1);
            this.Controls.Add(this.lblNewpassword1);
            this.Controls.Add(this.txtNewpassword);
            this.Controls.Add(this.lblNewpassword);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblTips);
            this.Controls.Add(this.rdoManager);
            this.Controls.Add(this.rdoFront);
            this.Controls.Add(this.rdoUser);
            this.Name = "ModifyPasswordForm";
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoUser;
        private System.Windows.Forms.RadioButton rdoFront;
        private System.Windows.Forms.RadioButton rdoManager;
        private System.Windows.Forms.Label lblTips;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblNewpassword;
        private System.Windows.Forms.TextBox txtNewpassword;
        private System.Windows.Forms.Label lblNewpassword1;
        private System.Windows.Forms.TextBox txtNewpassword1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}
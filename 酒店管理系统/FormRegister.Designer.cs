namespace LoginRegisterFrame
{
    partial class FormRegister
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
            this.components = new System.ComponentModel.Container();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelIdentity = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelPasswordSure = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxIdentityNumber = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxPasswordSure = new System.Windows.Forms.TextBox();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.labelRemain = new System.Windows.Forms.Label();
            this.skinButtonRegister = new CCWin.SkinControl.SkinButton();
            this.skinButtonCancel = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(201, 70);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(37, 15);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "姓名";
            this.labelName.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Location = new System.Drawing.Point(201, 122);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(37, 15);
            this.labelSex.TabIndex = 1;
            this.labelSex.Text = "性别";
            // 
            // labelIdentity
            // 
            this.labelIdentity.AutoSize = true;
            this.labelIdentity.Location = new System.Drawing.Point(201, 174);
            this.labelIdentity.Name = "labelIdentity";
            this.labelIdentity.Size = new System.Drawing.Size(82, 15);
            this.labelIdentity.TabIndex = 2;
            this.labelIdentity.Text = "身份证号码";
            this.labelIdentity.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(201, 230);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(67, 15);
            this.labelPhoneNumber.TabIndex = 3;
            this.labelPhoneNumber.Text = "手机号码";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(201, 281);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(37, 15);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "密码";
            // 
            // labelPasswordSure
            // 
            this.labelPasswordSure.AutoSize = true;
            this.labelPasswordSure.Location = new System.Drawing.Point(201, 337);
            this.labelPasswordSure.Name = "labelPasswordSure";
            this.labelPasswordSure.Size = new System.Drawing.Size(67, 15);
            this.labelPasswordSure.TabIndex = 5;
            this.labelPasswordSure.Text = "确认密码";
            this.labelPasswordSure.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(357, 70);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(304, 25);
            this.textBoxName.TabIndex = 7;
            // 
            // textBoxIdentityNumber
            // 
            this.textBoxIdentityNumber.Location = new System.Drawing.Point(357, 174);
            this.textBoxIdentityNumber.Name = "textBoxIdentityNumber";
            this.textBoxIdentityNumber.Size = new System.Drawing.Size(304, 25);
            this.textBoxIdentityNumber.TabIndex = 8;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(357, 230);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(304, 25);
            this.textBoxPhoneNumber.TabIndex = 9;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(357, 281);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(304, 25);
            this.textBoxPassword.TabIndex = 10;
            // 
            // textBoxPasswordSure
            // 
            this.textBoxPasswordSure.Location = new System.Drawing.Point(357, 337);
            this.textBoxPasswordSure.Name = "textBoxPasswordSure";
            this.textBoxPasswordSure.Size = new System.Drawing.Size(304, 25);
            this.textBoxPasswordSure.TabIndex = 11;
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comboBoxSex.Location = new System.Drawing.Point(357, 122);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(304, 23);
            this.comboBoxSex.TabIndex = 14;
            // 
            // labelRemain
            // 
            this.labelRemain.AutoSize = true;
            this.labelRemain.ForeColor = System.Drawing.Color.Red;
            this.labelRemain.Location = new System.Drawing.Point(354, 309);
            this.labelRemain.Name = "labelRemain";
            this.labelRemain.Size = new System.Drawing.Size(175, 15);
            this.labelRemain.TabIndex = 15;
            this.labelRemain.Text = "*:请输入9~20位的密码！";
            // 
            // skinButtonRegister
            // 
            this.skinButtonRegister.BackColor = System.Drawing.Color.Transparent;
            this.skinButtonRegister.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButtonRegister.DownBack = null;
            this.skinButtonRegister.Location = new System.Drawing.Point(268, 405);
            this.skinButtonRegister.MouseBack = null;
            this.skinButtonRegister.Name = "skinButtonRegister";
            this.skinButtonRegister.NormlBack = null;
            this.skinButtonRegister.Size = new System.Drawing.Size(128, 40);
            this.skinButtonRegister.TabIndex = 16;
            this.skinButtonRegister.Text = "注册";
            this.skinButtonRegister.UseVisualStyleBackColor = false;
            this.skinButtonRegister.Click += new System.EventHandler(this.skinButtonRegister_Click);
            // 
            // skinButtonCancel
            // 
            this.skinButtonCancel.BackColor = System.Drawing.Color.Transparent;
            this.skinButtonCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButtonCancel.DownBack = null;
            this.skinButtonCancel.Location = new System.Drawing.Point(503, 406);
            this.skinButtonCancel.MouseBack = null;
            this.skinButtonCancel.Name = "skinButtonCancel";
            this.skinButtonCancel.NormlBack = null;
            this.skinButtonCancel.Size = new System.Drawing.Size(128, 40);
            this.skinButtonCancel.TabIndex = 17;
            this.skinButtonCancel.Text = "取消";
            this.skinButtonCancel.UseVisualStyleBackColor = false;
            this.skinButtonCancel.Click += new System.EventHandler(this.skinButtonCancel_Click);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 489);
            this.Controls.Add(this.skinButtonCancel);
            this.Controls.Add(this.skinButtonRegister);
            this.Controls.Add(this.labelRemain);
            this.Controls.Add(this.comboBoxSex);
            this.Controls.Add(this.textBoxPasswordSure);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxIdentityNumber);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelPasswordSure);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.labelIdentity);
            this.Controls.Add(this.labelSex);
            this.Controls.Add(this.labelName);
            this.Name = "FormRegister";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelIdentity;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelPasswordSure;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxIdentityNumber;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxPasswordSure;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.Label labelRemain;
        private CCWin.SkinControl.SkinButton skinButtonRegister;
        private CCWin.SkinControl.SkinButton skinButtonCancel;
    }
}
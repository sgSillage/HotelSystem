namespace LoginRegisterFrame
{
    partial class FindAccount
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
            this.labelNotice = new System.Windows.Forms.Label();
            this.textBoxIdentity = new System.Windows.Forms.TextBox();
            this.skinButtonSearch = new CCWin.SkinControl.SkinButton();
            this.skinButtonCancel = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // labelNotice
            // 
            this.labelNotice.AutoSize = true;
            this.labelNotice.Location = new System.Drawing.Point(201, 186);
            this.labelNotice.Name = "labelNotice";
            this.labelNotice.Size = new System.Drawing.Size(112, 15);
            this.labelNotice.TabIndex = 0;
            this.labelNotice.Text = "请输入身份证：";
            // 
            // textBoxIdentity
            // 
            this.textBoxIdentity.Location = new System.Drawing.Point(319, 183);
            this.textBoxIdentity.Name = "textBoxIdentity";
            this.textBoxIdentity.Size = new System.Drawing.Size(272, 25);
            this.textBoxIdentity.TabIndex = 1;
            // 
            // skinButtonSearch
            // 
            this.skinButtonSearch.BackColor = System.Drawing.Color.Transparent;
            this.skinButtonSearch.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButtonSearch.DownBack = null;
            this.skinButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.skinButtonSearch.Location = new System.Drawing.Point(255, 258);
            this.skinButtonSearch.MouseBack = null;
            this.skinButtonSearch.Name = "skinButtonSearch";
            this.skinButtonSearch.NormlBack = null;
            this.skinButtonSearch.Size = new System.Drawing.Size(102, 37);
            this.skinButtonSearch.TabIndex = 16;
            this.skinButtonSearch.Text = "查询";
            this.skinButtonSearch.UseVisualStyleBackColor = false;
            this.skinButtonSearch.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // skinButtonCancel
            // 
            this.skinButtonCancel.BackColor = System.Drawing.Color.Transparent;
            this.skinButtonCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButtonCancel.DownBack = null;
            this.skinButtonCancel.Location = new System.Drawing.Point(455, 258);
            this.skinButtonCancel.MouseBack = null;
            this.skinButtonCancel.Name = "skinButtonCancel";
            this.skinButtonCancel.NormlBack = null;
            this.skinButtonCancel.Size = new System.Drawing.Size(102, 37);
            this.skinButtonCancel.TabIndex = 17;
            this.skinButtonCancel.Text = "取消";
            this.skinButtonCancel.UseVisualStyleBackColor = false;
            this.skinButtonCancel.Click += new System.EventHandler(this.skinButtonCancel_Click);
            // 
            // FindAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.skinButtonCancel);
            this.Controls.Add(this.skinButtonSearch);
            this.Controls.Add(this.textBoxIdentity);
            this.Controls.Add(this.labelNotice);
            this.Name = "FindAccount";
            this.Text = "找回账号";
            this.Load += new System.EventHandler(this.FindAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNotice;
        private System.Windows.Forms.TextBox textBoxIdentity;
        private CCWin.SkinControl.SkinButton skinButtonSearch;
        private CCWin.SkinControl.SkinButton skinButtonCancel;
    }
}
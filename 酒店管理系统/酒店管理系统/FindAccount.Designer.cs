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
            this.labelNotice = new System.Windows.Forms.Label();
            this.textBoxIdentity = new System.Windows.Forms.TextBox();
            this.buttonFindACancel = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNotice
            // 
            this.labelNotice.AutoSize = true;
            this.labelNotice.Location = new System.Drawing.Point(210, 158);
            this.labelNotice.Name = "labelNotice";
            this.labelNotice.Size = new System.Drawing.Size(112, 15);
            this.labelNotice.TabIndex = 0;
            this.labelNotice.Text = "请输入身份证：";
            // 
            // textBoxIdentity
            // 
            this.textBoxIdentity.Location = new System.Drawing.Point(328, 155);
            this.textBoxIdentity.Name = "textBoxIdentity";
            this.textBoxIdentity.Size = new System.Drawing.Size(272, 25);
            this.textBoxIdentity.TabIndex = 1;
            // 
            // buttonFindACancel
            // 
            this.buttonFindACancel.Location = new System.Drawing.Point(449, 210);
            this.buttonFindACancel.Name = "buttonFindACancel";
            this.buttonFindACancel.Size = new System.Drawing.Size(102, 37);
            this.buttonFindACancel.TabIndex = 15;
            this.buttonFindACancel.Text = "取消";
            this.buttonFindACancel.UseVisualStyleBackColor = true;
            this.buttonFindACancel.Click += new System.EventHandler(this.buttonRegisterCancel_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(254, 210);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(102, 37);
            this.buttonSearch.TabIndex = 14;
            this.buttonSearch.Text = "查询";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // FindAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFindACancel);
            this.Controls.Add(this.buttonSearch);
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
        private System.Windows.Forms.Button buttonFindACancel;
        private System.Windows.Forms.Button buttonSearch;
    }
}
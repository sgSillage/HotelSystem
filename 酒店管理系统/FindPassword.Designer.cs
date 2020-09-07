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
            this.buttonSet.Text = "查询";
            this.buttonSet.UseVisualStyleBackColor = true;
            // 
            // FindPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFindPCancel);
            this.Controls.Add(this.buttonSet);
            this.Name = "FindPassword";
            this.Text = "找回密码";
            this.Load += new System.EventHandler(this.FindPassword_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFindPCancel;
        private System.Windows.Forms.Button buttonSet;
    }
}
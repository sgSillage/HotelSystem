namespace 酒店管理系统
{
    partial class changPasswordForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_password1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_password2 = new System.Windows.Forms.TextBox();
            this.button_chang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入您的密码：";
            // 
            // textBox_password1
            // 
            this.textBox_password1.Location = new System.Drawing.Point(179, 14);
            this.textBox_password1.Name = "textBox_password1";
            this.textBox_password1.Size = new System.Drawing.Size(181, 25);
            this.textBox_password1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "请确认您的密码：";
            // 
            // textBox_password2
            // 
            this.textBox_password2.Location = new System.Drawing.Point(179, 66);
            this.textBox_password2.Name = "textBox_password2";
            this.textBox_password2.Size = new System.Drawing.Size(181, 25);
            this.textBox_password2.TabIndex = 3;
            // 
            // button_chang
            // 
            this.button_chang.Location = new System.Drawing.Point(134, 145);
            this.button_chang.Name = "button_chang";
            this.button_chang.Size = new System.Drawing.Size(120, 38);
            this.button_chang.TabIndex = 4;
            this.button_chang.Text = "修改密码";
            this.button_chang.UseVisualStyleBackColor = true;
            this.button_chang.Click += new System.EventHandler(this.button_chang_Click);
            // 
            // changPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 213);
            this.Controls.Add(this.button_chang);
            this.Controls.Add(this.textBox_password2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_password1);
            this.Controls.Add(this.label1);
            this.Name = "changPasswordForm";
            this.Text = "changPasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_password1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_password2;
        private System.Windows.Forms.Button button_chang;
    }
}
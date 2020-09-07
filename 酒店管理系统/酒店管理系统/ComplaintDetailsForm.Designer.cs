namespace HotelmanageSystem
{
    partial class ComplaintDetailsForm
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblOrder_id = new System.Windows.Forms.Label();
            this.lblCom_time = new System.Windows.Forms.Label();
            this.lblEmp_ids = new System.Windows.Forms.Label();
            this.lblCom_content = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtOrder_id = new System.Windows.Forms.TextBox();
            this.txtCom_time = new System.Windows.Forms.TextBox();
            this.txtEmp_ids = new System.Windows.Forms.TextBox();
            this.txtCom_content = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(66, 44);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(89, 18);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "投诉人ID:";
            // 
            // lblOrder_id
            // 
            this.lblOrder_id.AutoSize = true;
            this.lblOrder_id.Location = new System.Drawing.Point(66, 118);
            this.lblOrder_id.Name = "lblOrder_id";
            this.lblOrder_id.Size = new System.Drawing.Size(89, 18);
            this.lblOrder_id.TabIndex = 1;
            this.lblOrder_id.Text = "订单编号:";
            // 
            // lblCom_time
            // 
            this.lblCom_time.AutoSize = true;
            this.lblCom_time.Location = new System.Drawing.Point(69, 183);
            this.lblCom_time.Name = "lblCom_time";
            this.lblCom_time.Size = new System.Drawing.Size(89, 18);
            this.lblCom_time.TabIndex = 2;
            this.lblCom_time.Text = "投诉时间:";
            // 
            // lblEmp_ids
            // 
            this.lblEmp_ids.AutoSize = true;
            this.lblEmp_ids.Location = new System.Drawing.Point(69, 235);
            this.lblEmp_ids.Name = "lblEmp_ids";
            this.lblEmp_ids.Size = new System.Drawing.Size(161, 18);
            this.lblEmp_ids.TabIndex = 3;
            this.lblEmp_ids.Text = "服务的员工的编号:";
            // 
            // lblCom_content
            // 
            this.lblCom_content.AutoSize = true;
            this.lblCom_content.Location = new System.Drawing.Point(69, 328);
            this.lblCom_content.Name = "lblCom_content";
            this.lblCom_content.Size = new System.Drawing.Size(107, 18);
            this.lblCom_content.TabIndex = 4;
            this.lblCom_content.Text = "投诉的内容:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(272, 33);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(248, 28);
            this.txtID.TabIndex = 5;
            // 
            // txtOrder_id
            // 
            this.txtOrder_id.Location = new System.Drawing.Point(272, 107);
            this.txtOrder_id.Name = "txtOrder_id";
            this.txtOrder_id.ReadOnly = true;
            this.txtOrder_id.Size = new System.Drawing.Size(248, 28);
            this.txtOrder_id.TabIndex = 6;
            // 
            // txtCom_time
            // 
            this.txtCom_time.Location = new System.Drawing.Point(272, 173);
            this.txtCom_time.Name = "txtCom_time";
            this.txtCom_time.ReadOnly = true;
            this.txtCom_time.Size = new System.Drawing.Size(248, 28);
            this.txtCom_time.TabIndex = 7;
            // 
            // txtEmp_ids
            // 
            this.txtEmp_ids.AcceptsReturn = true;
            this.txtEmp_ids.Location = new System.Drawing.Point(272, 224);
            this.txtEmp_ids.Multiline = true;
            this.txtEmp_ids.Name = "txtEmp_ids";
            this.txtEmp_ids.ReadOnly = true;
            this.txtEmp_ids.Size = new System.Drawing.Size(248, 80);
            this.txtEmp_ids.TabIndex = 8;
            // 
            // txtCom_content
            // 
            this.txtCom_content.Location = new System.Drawing.Point(272, 328);
            this.txtCom_content.Multiline = true;
            this.txtCom_content.Name = "txtCom_content";
            this.txtCom_content.ReadOnly = true;
            this.txtCom_content.Size = new System.Drawing.Size(248, 110);
            this.txtCom_content.TabIndex = 9;
            // 
            // ComplaintDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCom_content);
            this.Controls.Add(this.txtEmp_ids);
            this.Controls.Add(this.txtCom_time);
            this.Controls.Add(this.txtOrder_id);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblCom_content);
            this.Controls.Add(this.lblEmp_ids);
            this.Controls.Add(this.lblCom_time);
            this.Controls.Add(this.lblOrder_id);
            this.Controls.Add(this.lblID);
            this.Name = "ComplaintDetailsForm";
            this.Text = "查看投诉详情";
            this.Load += new System.EventHandler(this.ComplaintDetailsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblOrder_id;
        private System.Windows.Forms.Label lblCom_time;
        private System.Windows.Forms.Label lblEmp_ids;
        private System.Windows.Forms.Label lblCom_content;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtOrder_id;
        private System.Windows.Forms.TextBox txtCom_time;
        private System.Windows.Forms.TextBox txtEmp_ids;
        private System.Windows.Forms.TextBox txtCom_content;
    }
}
namespace HotelmanageSystem
{
    partial class EmployeeListForm
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
            this.lvwEmployee = new System.Windows.Forms.ListView();
            this.colhEmployeeID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colhEmloyeename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colhEmployeesex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colhEmployeestatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colhEmployeephone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colhEmployeesalary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colhEmployeetime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colhEmployeeposition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsModifyemployee = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiModifyemployeeID = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModifyemployeeName = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModifyemployeeSex = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWoman = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModifyemployeeStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.tamiModifyemployeePhone = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModifyemployeeSalary = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModifyemployeeTime = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModifyemployeePosition = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteemployee = new System.Windows.Forms.ToolStripMenuItem();
            this.lblModifyemployee = new System.Windows.Forms.Label();
            this.mtxEmployeeinfo = new System.Windows.Forms.MaskedTextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.cmsModifyemployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwEmployee
            // 
            this.lvwEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colhEmployeeID,
            this.colhEmloyeename,
            this.colhEmployeesex,
            this.colhEmployeestatus,
            this.colhEmployeephone,
            this.colhEmployeesalary,
            this.colhEmployeetime,
            this.colhEmployeeposition});
            this.lvwEmployee.FullRowSelect = true;
            this.lvwEmployee.HideSelection = false;
            this.lvwEmployee.Location = new System.Drawing.Point(23, 49);
            this.lvwEmployee.Name = "lvwEmployee";
            this.lvwEmployee.Size = new System.Drawing.Size(822, 299);
            this.lvwEmployee.TabIndex = 0;
            this.lvwEmployee.UseCompatibleStateImageBehavior = false;
            this.lvwEmployee.View = System.Windows.Forms.View.Details;
            // 
            // colhEmployeeID
            // 
            this.colhEmployeeID.Text = "员工编号";
            this.colhEmployeeID.Width = 90;
            // 
            // colhEmloyeename
            // 
            this.colhEmloyeename.Text = "姓名";
            this.colhEmloyeename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colhEmloyeename.Width = 90;
            // 
            // colhEmployeesex
            // 
            this.colhEmployeesex.Text = "性别";
            this.colhEmployeesex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colhEmployeestatus
            // 
            this.colhEmployeestatus.Text = "身份证号";
            this.colhEmployeestatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colhEmployeestatus.Width = 140;
            // 
            // colhEmployeephone
            // 
            this.colhEmployeephone.Text = "电话号码";
            this.colhEmployeephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colhEmployeephone.Width = 120;
            // 
            // colhEmployeesalary
            // 
            this.colhEmployeesalary.Text = "薪水";
            this.colhEmployeesalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colhEmployeesalary.Width = 100;
            // 
            // colhEmployeetime
            // 
            this.colhEmployeetime.Text = "入职时间";
            this.colhEmployeetime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colhEmployeetime.Width = 120;
            // 
            // colhEmployeeposition
            // 
            this.colhEmployeeposition.Text = "职位";
            this.colhEmployeeposition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colhEmployeeposition.Width = 90;
            // 
            // cmsModifyemployee
            // 
            this.cmsModifyemployee.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsModifyemployee.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiModifyemployeeID,
            this.tsmiModifyemployeeName,
            this.tsmiModifyemployeeSex,
            this.tsmiModifyemployeeStatus,
            this.tamiModifyemployeePhone,
            this.tsmiModifyemployeeSalary,
            this.tsmiModifyemployeeTime,
            this.tsmiModifyemployeePosition,
            this.tsmiDeleteemployee});
            this.cmsModifyemployee.Name = "cmsModifyemployee";
            this.cmsModifyemployee.Size = new System.Drawing.Size(189, 256);
            // 
            // tsmiModifyemployeeID
            // 
            this.tsmiModifyemployeeID.Name = "tsmiModifyemployeeID";
            this.tsmiModifyemployeeID.Size = new System.Drawing.Size(188, 28);
            this.tsmiModifyemployeeID.Text = "修改员工编号";
            this.tsmiModifyemployeeID.Click += new System.EventHandler(this.tsmiModifyemployeeID_Click);
            // 
            // tsmiModifyemployeeName
            // 
            this.tsmiModifyemployeeName.Name = "tsmiModifyemployeeName";
            this.tsmiModifyemployeeName.Size = new System.Drawing.Size(188, 28);
            this.tsmiModifyemployeeName.Text = "修改员工姓名";
            this.tsmiModifyemployeeName.Click += new System.EventHandler(this.tsmiModifyemployeeName_Click);
            // 
            // tsmiModifyemployeeSex
            // 
            this.tsmiModifyemployeeSex.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMan,
            this.tsmiWoman});
            this.tsmiModifyemployeeSex.Name = "tsmiModifyemployeeSex";
            this.tsmiModifyemployeeSex.Size = new System.Drawing.Size(188, 28);
            this.tsmiModifyemployeeSex.Text = "修改性别";
            // 
            // tsmiMan
            // 
            this.tsmiMan.Name = "tsmiMan";
            this.tsmiMan.Size = new System.Drawing.Size(110, 30);
            this.tsmiMan.Text = "男";
            this.tsmiMan.Click += new System.EventHandler(this.tsmiMan_Click);
            // 
            // tsmiWoman
            // 
            this.tsmiWoman.Name = "tsmiWoman";
            this.tsmiWoman.Size = new System.Drawing.Size(110, 30);
            this.tsmiWoman.Text = "女";
            this.tsmiWoman.Click += new System.EventHandler(this.tsmiWoman_Click);
            // 
            // tsmiModifyemployeeStatus
            // 
            this.tsmiModifyemployeeStatus.Name = "tsmiModifyemployeeStatus";
            this.tsmiModifyemployeeStatus.Size = new System.Drawing.Size(188, 28);
            this.tsmiModifyemployeeStatus.Text = "修改身份证号";
            this.tsmiModifyemployeeStatus.Click += new System.EventHandler(this.tsmiModifyemployeeStatus_Click);
            // 
            // tamiModifyemployeePhone
            // 
            this.tamiModifyemployeePhone.Name = "tamiModifyemployeePhone";
            this.tamiModifyemployeePhone.Size = new System.Drawing.Size(188, 28);
            this.tamiModifyemployeePhone.Text = "修改电话号码";
            this.tamiModifyemployeePhone.Click += new System.EventHandler(this.tamiModifyemployeePhone_Click);
            // 
            // tsmiModifyemployeeSalary
            // 
            this.tsmiModifyemployeeSalary.Name = "tsmiModifyemployeeSalary";
            this.tsmiModifyemployeeSalary.Size = new System.Drawing.Size(188, 28);
            this.tsmiModifyemployeeSalary.Text = "修改薪水";
            this.tsmiModifyemployeeSalary.Click += new System.EventHandler(this.tsmiModifyemployeeSalary_Click);
            // 
            // tsmiModifyemployeeTime
            // 
            this.tsmiModifyemployeeTime.Name = "tsmiModifyemployeeTime";
            this.tsmiModifyemployeeTime.Size = new System.Drawing.Size(188, 28);
            this.tsmiModifyemployeeTime.Text = "修改入职时间";
            this.tsmiModifyemployeeTime.Click += new System.EventHandler(this.tsmiModifyemployeeTime_Click);
            // 
            // tsmiModifyemployeePosition
            // 
            this.tsmiModifyemployeePosition.Name = "tsmiModifyemployeePosition";
            this.tsmiModifyemployeePosition.Size = new System.Drawing.Size(188, 28);
            this.tsmiModifyemployeePosition.Text = "修改员工职位";
            this.tsmiModifyemployeePosition.Click += new System.EventHandler(this.tsmiModifyemployeePosition_Click);
            // 
            // tsmiDeleteemployee
            // 
            this.tsmiDeleteemployee.Name = "tsmiDeleteemployee";
            this.tsmiDeleteemployee.Size = new System.Drawing.Size(188, 28);
            this.tsmiDeleteemployee.Text = "删除员工";
            this.tsmiDeleteemployee.Click += new System.EventHandler(this.tsmiDeleteemployee_Click);
            // 
            // lblModifyemployee
            // 
            this.lblModifyemployee.AutoSize = true;
            this.lblModifyemployee.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblModifyemployee.Location = new System.Drawing.Point(73, 374);
            this.lblModifyemployee.Name = "lblModifyemployee";
            this.lblModifyemployee.Size = new System.Drawing.Size(147, 21);
            this.lblModifyemployee.TabIndex = 2;
            this.lblModifyemployee.Text = "修改提示信息:";
            // 
            // mtxEmployeeinfo
            // 
            this.mtxEmployeeinfo.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mtxEmployeeinfo.Location = new System.Drawing.Point(285, 367);
            this.mtxEmployeeinfo.Name = "mtxEmployeeinfo";
            this.mtxEmployeeinfo.Size = new System.Drawing.Size(242, 28);
            this.mtxEmployeeinfo.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOK.ContextMenuStrip = this.cmsModifyemployee;
            this.btnOK.Image = global::酒店管理系统.Properties.Resources.symbol_check_icon;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(359, 429);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(85, 36);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "修改";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // EmployeeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 477);
            this.ContextMenuStrip = this.cmsModifyemployee;
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.mtxEmployeeinfo);
            this.Controls.Add(this.lblModifyemployee);
            this.Controls.Add(this.lvwEmployee);
            this.Name = "EmployeeListForm";
            this.Text = "员工列表";
            this.Load += new System.EventHandler(this.EmployeeListForm_Load);
            this.cmsModifyemployee.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwEmployee;
        private System.Windows.Forms.ColumnHeader colhEmployeeID;
        private System.Windows.Forms.ColumnHeader colhEmloyeename;
        private System.Windows.Forms.ColumnHeader colhEmployeesex;
        private System.Windows.Forms.ColumnHeader colhEmployeestatus;
        private System.Windows.Forms.ColumnHeader colhEmployeephone;
        private System.Windows.Forms.ColumnHeader colhEmployeesalary;
        private System.Windows.Forms.ColumnHeader colhEmployeetime;
        private System.Windows.Forms.ColumnHeader colhEmployeeposition;
        private System.Windows.Forms.ContextMenuStrip cmsModifyemployee;
        private System.Windows.Forms.ToolStripMenuItem tsmiModifyemployeeID;
        private System.Windows.Forms.ToolStripMenuItem tsmiModifyemployeeName;
        private System.Windows.Forms.ToolStripMenuItem tsmiModifyemployeeSex;
        private System.Windows.Forms.ToolStripMenuItem tsmiMan;
        private System.Windows.Forms.ToolStripMenuItem tsmiWoman;
        private System.Windows.Forms.ToolStripMenuItem tsmiModifyemployeeStatus;
        private System.Windows.Forms.ToolStripMenuItem tamiModifyemployeePhone;
        private System.Windows.Forms.ToolStripMenuItem tsmiModifyemployeeSalary;
        private System.Windows.Forms.ToolStripMenuItem tsmiModifyemployeeTime;
        private System.Windows.Forms.ToolStripMenuItem tsmiModifyemployeePosition;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteemployee;
        private System.Windows.Forms.Label lblModifyemployee;
        private System.Windows.Forms.MaskedTextBox mtxEmployeeinfo;
        private System.Windows.Forms.Button btnOK;
    }
}
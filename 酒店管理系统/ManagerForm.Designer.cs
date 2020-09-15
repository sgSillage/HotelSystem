namespace HotelmanageSystem
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.mnsManager = new System.Windows.Forms.MenuStrip();
            this.tsmiRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddroom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQueryroom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModifyroom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddemployee = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQueryemployee = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModifyemployee = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModifypassword = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIncost = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiComplaint = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrManager = new System.Windows.Forms.ToolStrip();
            this.tsbAddroom = new System.Windows.Forms.ToolStripButton();
            this.tsbAddemployee = new System.Windows.Forms.ToolStripButton();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.ssrManager = new System.Windows.Forms.StatusStrip();
            this.tsslManager = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnsManager.SuspendLayout();
            this.tsrManager.SuspendLayout();
            this.ssrManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsManager
            // 
            this.mnsManager.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnsManager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRoom,
            this.tsmiEmployee,
            this.tsmiIncost,
            this.tsmiComplaint});
            this.mnsManager.Location = new System.Drawing.Point(4, 32);
            this.mnsManager.Name = "mnsManager";
            this.mnsManager.Size = new System.Drawing.Size(1053, 32);
            this.mnsManager.TabIndex = 1;
            this.mnsManager.Text = "菜单栏";
            // 
            // tsmiRoom
            // 
            this.tsmiRoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddroom,
            this.tsmiQueryroom,
            this.tsmiModifyroom});
            this.tsmiRoom.Name = "tsmiRoom";
            this.tsmiRoom.Size = new System.Drawing.Size(94, 28);
            this.tsmiRoom.Text = "房间管理";
            // 
            // tsmiAddroom
            // 
            this.tsmiAddroom.Name = "tsmiAddroom";
            this.tsmiAddroom.Size = new System.Drawing.Size(200, 30);
            this.tsmiAddroom.Text = "新增房间";
            this.tsmiAddroom.Click += new System.EventHandler(this.tsmiAddroom_Click);
            // 
            // tsmiQueryroom
            // 
            this.tsmiQueryroom.Name = "tsmiQueryroom";
            this.tsmiQueryroom.Size = new System.Drawing.Size(200, 30);
            this.tsmiQueryroom.Text = "查询房间信息";
            this.tsmiQueryroom.Click += new System.EventHandler(this.tsmiQueryroom_Click);
            // 
            // tsmiModifyroom
            // 
            this.tsmiModifyroom.Name = "tsmiModifyroom";
            this.tsmiModifyroom.Size = new System.Drawing.Size(200, 30);
            this.tsmiModifyroom.Text = "修改房间信息";
            this.tsmiModifyroom.Click += new System.EventHandler(this.tsmiModifyroom_Click);
            // 
            // tsmiEmployee
            // 
            this.tsmiEmployee.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddemployee,
            this.tsmiQueryemployee,
            this.tsmiModifyemployee,
            this.tsmiModifypassword});
            this.tsmiEmployee.Name = "tsmiEmployee";
            this.tsmiEmployee.Size = new System.Drawing.Size(94, 28);
            this.tsmiEmployee.Text = "员工管理";
            // 
            // tsmiAddemployee
            // 
            this.tsmiAddemployee.Name = "tsmiAddemployee";
            this.tsmiAddemployee.Size = new System.Drawing.Size(200, 30);
            this.tsmiAddemployee.Text = "新增员工";
            this.tsmiAddemployee.Click += new System.EventHandler(this.tsmiAddemployee_Click);
            // 
            // tsmiQueryemployee
            // 
            this.tsmiQueryemployee.Name = "tsmiQueryemployee";
            this.tsmiQueryemployee.Size = new System.Drawing.Size(200, 30);
            this.tsmiQueryemployee.Text = "查询员工信息";
            this.tsmiQueryemployee.Click += new System.EventHandler(this.tsmiQueryemployee_Click);
            // 
            // tsmiModifyemployee
            // 
            this.tsmiModifyemployee.Name = "tsmiModifyemployee";
            this.tsmiModifyemployee.Size = new System.Drawing.Size(200, 30);
            this.tsmiModifyemployee.Text = "修改员工信息";
            this.tsmiModifyemployee.Click += new System.EventHandler(this.tsmiModifyemployee_Click);
            // 
            // tsmiModifypassword
            // 
            this.tsmiModifypassword.Name = "tsmiModifypassword";
            this.tsmiModifypassword.Size = new System.Drawing.Size(200, 30);
            this.tsmiModifypassword.Text = "修改密码";
            this.tsmiModifypassword.Click += new System.EventHandler(this.tsmiModifypassword_Click);
            // 
            // tsmiIncost
            // 
            this.tsmiIncost.Name = "tsmiIncost";
            this.tsmiIncost.Size = new System.Drawing.Size(94, 28);
            this.tsmiIncost.Text = "查看收支";
            this.tsmiIncost.Click += new System.EventHandler(this.tsmiIncost_Click);
            // 
            // tsmiComplaint
            // 
            this.tsmiComplaint.Name = "tsmiComplaint";
            this.tsmiComplaint.Size = new System.Drawing.Size(94, 28);
            this.tsmiComplaint.Text = "查看投诉";
            this.tsmiComplaint.Click += new System.EventHandler(this.tsmiComplaint_Click);
            // 
            // tsrManager
            // 
            this.tsrManager.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsrManager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddroom,
            this.tsbAddemployee,
            this.tsbExit});
            this.tsrManager.Location = new System.Drawing.Point(4, 64);
            this.tsrManager.Name = "tsrManager";
            this.tsrManager.Size = new System.Drawing.Size(1053, 31);
            this.tsrManager.TabIndex = 2;
            this.tsrManager.Text = "工具栏";
            // 
            // tsbAddroom
            // 
            this.tsbAddroom.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddroom.Image")));
            this.tsbAddroom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddroom.Name = "tsbAddroom";
            this.tsbAddroom.Size = new System.Drawing.Size(110, 28);
            this.tsbAddroom.Text = "新增房间";
            this.tsbAddroom.Click += new System.EventHandler(this.tsbAddroom_Click);
            // 
            // tsbAddemployee
            // 
            this.tsbAddemployee.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddemployee.Image")));
            this.tsbAddemployee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddemployee.Name = "tsbAddemployee";
            this.tsbAddemployee.Size = new System.Drawing.Size(110, 28);
            this.tsbAddemployee.Text = "新增员工";
            this.tsbAddemployee.Click += new System.EventHandler(this.tsbAddemployee_Click);
            // 
            // tsbExit
            // 
            this.tsbExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbExit.Image")));
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(110, 28);
            this.tsbExit.Text = "退出登录";
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // ssrManager
            // 
            this.ssrManager.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ssrManager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslManager});
            this.ssrManager.Location = new System.Drawing.Point(4, 623);
            this.ssrManager.Name = "ssrManager";
            this.ssrManager.Size = new System.Drawing.Size(1053, 29);
            this.ssrManager.TabIndex = 3;
            this.ssrManager.Text = "状态栏";
            // 
            // tsslManager
            // 
            this.tsslManager.Name = "tsslManager";
            this.tsslManager.Size = new System.Drawing.Size(100, 24);
            this.tsslManager.Text = "管理员窗口";
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 656);
            this.Controls.Add(this.ssrManager);
            this.Controls.Add(this.tsrManager);
            this.Controls.Add(this.mnsManager);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsManager;
            this.Name = "ManagerForm";
            this.Text = "酒店管理系统-管理员";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.mnsManager.ResumeLayout(false);
            this.mnsManager.PerformLayout();
            this.tsrManager.ResumeLayout(false);
            this.tsrManager.PerformLayout();
            this.ssrManager.ResumeLayout(false);
            this.ssrManager.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsManager;
        private System.Windows.Forms.ToolStripMenuItem tsmiRoom;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmployee;
        private System.Windows.Forms.ToolStripMenuItem tsmiIncost;
        private System.Windows.Forms.ToolStripMenuItem tsmiComplaint;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddroom;
        private System.Windows.Forms.ToolStripMenuItem tsmiQueryroom;
        private System.Windows.Forms.ToolStripMenuItem tsmiModifyroom;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddemployee;
        private System.Windows.Forms.ToolStripMenuItem tsmiQueryemployee;
        private System.Windows.Forms.ToolStripMenuItem tsmiModifyemployee;
        private System.Windows.Forms.ToolStrip tsrManager;
        private System.Windows.Forms.ToolStripButton tsbAddroom;
        private System.Windows.Forms.ToolStripButton tsbAddemployee;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.StatusStrip ssrManager;
        private System.Windows.Forms.ToolStripStatusLabel tsslManager;
        private System.Windows.Forms.ToolStripMenuItem tsmiModifypassword;
    }
}


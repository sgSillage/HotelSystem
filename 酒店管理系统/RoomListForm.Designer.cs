namespace HotelmanageSystem
{
    partial class RoomListForm
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
            this.lvwRoom = new System.Windows.Forms.ListView();
            this.colhRoom_no = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colhRoomkind = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colhIsnormal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colhRoomprice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsModifyroom = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiModifyroom_no = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModifyroomkind = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModifyroomisnormal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiYes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModifyroomprice = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteroom = new System.Windows.Forms.ToolStripMenuItem();
            this.lblModifyRoom = new System.Windows.Forms.Label();
            this.txtRoominfo = new System.Windows.Forms.TextBox();
            this.btnModifyroom = new System.Windows.Forms.Button();
            this.cmsModifyroom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwRoom
            // 
            this.lvwRoom.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colhRoom_no,
            this.colhRoomkind,
            this.colhIsnormal,
            this.colhRoomprice});
            this.lvwRoom.FullRowSelect = true;
            this.lvwRoom.HideSelection = false;
            this.lvwRoom.Location = new System.Drawing.Point(13, 47);
            this.lvwRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvwRoom.Name = "lvwRoom";
            this.lvwRoom.Size = new System.Drawing.Size(656, 322);
            this.lvwRoom.TabIndex = 0;
            this.lvwRoom.UseCompatibleStateImageBehavior = false;
            this.lvwRoom.View = System.Windows.Forms.View.Details;
            // 
            // colhRoom_no
            // 
            this.colhRoom_no.Text = "房间号";
            this.colhRoom_no.Width = 90;
            // 
            // colhRoomkind
            // 
            this.colhRoomkind.Text = "房间种类";
            this.colhRoomkind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colhRoomkind.Width = 100;
            // 
            // colhIsnormal
            // 
            this.colhIsnormal.Text = "是否正常使用";
            this.colhIsnormal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colhIsnormal.Width = 140;
            // 
            // colhRoomprice
            // 
            this.colhRoomprice.Text = "房间价格(/元)";
            this.colhRoomprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colhRoomprice.Width = 130;
            // 
            // cmsModifyroom
            // 
            this.cmsModifyroom.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsModifyroom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiModifyroom_no,
            this.tsmiModifyroomkind,
            this.tsmiModifyroomisnormal,
            this.tsmiModifyroomprice,
            this.tsmiDeleteroom});
            this.cmsModifyroom.Name = "cmsModifyroom";
            this.cmsModifyroom.Size = new System.Drawing.Size(261, 144);
            // 
            // tsmiModifyroom_no
            // 
            this.tsmiModifyroom_no.Name = "tsmiModifyroom_no";
            this.tsmiModifyroom_no.Size = new System.Drawing.Size(260, 28);
            this.tsmiModifyroom_no.Text = "修改房间号";
            this.tsmiModifyroom_no.Click += new System.EventHandler(this.tsmiModifyroom_no_Click);
            // 
            // tsmiModifyroomkind
            // 
            this.tsmiModifyroomkind.Name = "tsmiModifyroomkind";
            this.tsmiModifyroomkind.Size = new System.Drawing.Size(260, 28);
            this.tsmiModifyroomkind.Text = "修改房间类型";
            this.tsmiModifyroomkind.Click += new System.EventHandler(this.tsmiModifyroomkind_Click);
            // 
            // tsmiModifyroomisnormal
            // 
            this.tsmiModifyroomisnormal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiYes,
            this.tsmiNo});
            this.tsmiModifyroomisnormal.Name = "tsmiModifyroomisnormal";
            this.tsmiModifyroomisnormal.Size = new System.Drawing.Size(260, 28);
            this.tsmiModifyroomisnormal.Text = "修改房间是否可以使用";
            // 
            // tsmiYes
            // 
            this.tsmiYes.Name = "tsmiYes";
            this.tsmiYes.Size = new System.Drawing.Size(110, 30);
            this.tsmiYes.Text = "是";
            this.tsmiYes.Click += new System.EventHandler(this.tsmiYes_Click);
            // 
            // tsmiNo
            // 
            this.tsmiNo.Name = "tsmiNo";
            this.tsmiNo.Size = new System.Drawing.Size(110, 30);
            this.tsmiNo.Text = "否";
            this.tsmiNo.Click += new System.EventHandler(this.tsmiNo_Click);
            // 
            // tsmiModifyroomprice
            // 
            this.tsmiModifyroomprice.Name = "tsmiModifyroomprice";
            this.tsmiModifyroomprice.Size = new System.Drawing.Size(260, 28);
            this.tsmiModifyroomprice.Text = "修改房间价格";
            this.tsmiModifyroomprice.Click += new System.EventHandler(this.tsmiModifyroomprice_Click);
            // 
            // tsmiDeleteroom
            // 
            this.tsmiDeleteroom.Name = "tsmiDeleteroom";
            this.tsmiDeleteroom.Size = new System.Drawing.Size(260, 28);
            this.tsmiDeleteroom.Text = "删除房间";
            this.tsmiDeleteroom.Click += new System.EventHandler(this.tsmiDeleteroom_Click);
            // 
            // lblModifyRoom
            // 
            this.lblModifyRoom.AutoSize = true;
            this.lblModifyRoom.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblModifyRoom.Location = new System.Drawing.Point(77, 398);
            this.lblModifyRoom.Name = "lblModifyRoom";
            this.lblModifyRoom.Size = new System.Drawing.Size(157, 21);
            this.lblModifyRoom.TabIndex = 2;
            this.lblModifyRoom.Text = "修改信息提示：";
            // 
            // txtRoominfo
            // 
            this.txtRoominfo.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRoominfo.Location = new System.Drawing.Point(305, 391);
            this.txtRoominfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRoominfo.Name = "txtRoominfo";
            this.txtRoominfo.Size = new System.Drawing.Size(100, 28);
            this.txtRoominfo.TabIndex = 3;
            // 
            // btnModifyroom
            // 
            this.btnModifyroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnModifyroom.Image = global::酒店管理系统.Properties.Resources.symbol_check_icon;
            this.btnModifyroom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifyroom.Location = new System.Drawing.Point(252, 449);
            this.btnModifyroom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModifyroom.Name = "btnModifyroom";
            this.btnModifyroom.Size = new System.Drawing.Size(84, 32);
            this.btnModifyroom.TabIndex = 4;
            this.btnModifyroom.Text = "修改";
            this.btnModifyroom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModifyroom.UseVisualStyleBackColor = false;
            this.btnModifyroom.Click += new System.EventHandler(this.btnModifyroom_Click);
            // 
            // RoomListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 522);
            this.ContextMenuStrip = this.cmsModifyroom;
            this.Controls.Add(this.btnModifyroom);
            this.Controls.Add(this.txtRoominfo);
            this.Controls.Add(this.lblModifyRoom);
            this.Controls.Add(this.lvwRoom);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RoomListForm";
            this.Text = "房间列表";
            this.Load += new System.EventHandler(this.RoomListForm_Load);
            this.cmsModifyroom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwRoom;
        private System.Windows.Forms.ColumnHeader colhRoom_no;
        private System.Windows.Forms.ColumnHeader colhRoomkind;
        private System.Windows.Forms.ColumnHeader colhIsnormal;
        private System.Windows.Forms.ColumnHeader colhRoomprice;
        private System.Windows.Forms.ContextMenuStrip cmsModifyroom;
        private System.Windows.Forms.ToolStripMenuItem tsmiModifyroom_no;
        private System.Windows.Forms.ToolStripMenuItem tsmiModifyroomkind;
        private System.Windows.Forms.ToolStripMenuItem tsmiModifyroomisnormal;
        private System.Windows.Forms.ToolStripMenuItem tsmiModifyroomprice;
        private System.Windows.Forms.ToolStripMenuItem tsmiYes;
        private System.Windows.Forms.ToolStripMenuItem tsmiNo;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteroom;
        private System.Windows.Forms.Label lblModifyRoom;
        private System.Windows.Forms.TextBox txtRoominfo;
        private System.Windows.Forms.Button btnModifyroom;
    }
}
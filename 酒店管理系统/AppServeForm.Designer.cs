namespace WindowsFormsApp1
{
    partial class AppServeForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "配送晚餐",
            "2018-01-23 10:56:21",
            "666"}, -1);
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_ser = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_flash = new System.Windows.Forms.Button();
            this.button_newService = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.complaintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(76, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "申请服务";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "选择您需要的服务";
            // 
            // comboBox_ser
            // 
            this.comboBox_ser.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox_ser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ser.FormattingEnabled = true;
            this.comboBox_ser.Location = new System.Drawing.Point(12, 36);
            this.comboBox_ser.Name = "comboBox_ser";
            this.comboBox_ser.Size = new System.Drawing.Size(262, 23);
            this.comboBox_ser.TabIndex = 5;
            this.comboBox_ser.DropDown += new System.EventHandler(this.ComboBox_ser_Load);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBox_ser);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(137, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 109);
            this.panel1.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(0, 42);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(581, 303);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "服务类型";
            this.columnHeader1.Width = 136;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "申请时间";
            this.columnHeader2.Width = 175;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "服务订单编号";
            this.columnHeader3.Width = 268;
            // 
            // button_flash
            // 
            this.button_flash.Location = new System.Drawing.Point(503, 2);
            this.button_flash.Name = "button_flash";
            this.button_flash.Size = new System.Drawing.Size(78, 43);
            this.button_flash.TabIndex = 8;
            this.button_flash.Text = "刷新";
            this.button_flash.UseVisualStyleBackColor = true;
            this.button_flash.Click += new System.EventHandler(this.userSerReload);
            // 
            // button_newService
            // 
            this.button_newService.Location = new System.Drawing.Point(201, 2);
            this.button_newService.Name = "button_newService";
            this.button_newService.Size = new System.Drawing.Size(105, 43);
            this.button_newService.TabIndex = 9;
            this.button_newService.Text = "申请新服务";
            this.button_newService.UseVisualStyleBackColor = true;
            this.button_newService.Click += new System.EventHandler(this.button_newService_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.complaintToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 28);
            // 
            // complaintToolStripMenuItem
            // 
            this.complaintToolStripMenuItem.Name = "complaintToolStripMenuItem";
            this.complaintToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.complaintToolStripMenuItem.Text = "投诉";
            this.complaintToolStripMenuItem.Click += new System.EventHandler(this.complaintToolStripMenuItem_Click);
            // 
            // AppServeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 347);
            this.Controls.Add(this.button_newService);
            this.Controls.Add(this.button_flash);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Name = "AppServeForm";
            this.Text = "AppServe";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_ser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button_flash;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button_newService;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem complaintToolStripMenuItem;
    }
}
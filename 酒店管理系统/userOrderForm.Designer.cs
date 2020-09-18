namespace 酒店管理系统
{
    partial class UserOrderForm
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
            this.userOrder_listView = new System.Windows.Forms.ListView();
            this.column_type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_beg_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_all_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // userOrder_listView
            // 
            this.userOrder_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_type,
            this.column_beg_time,
            this.column_all_price});
            this.userOrder_listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userOrder_listView.HideSelection = false;
            this.userOrder_listView.Location = new System.Drawing.Point(0, 0);
            this.userOrder_listView.Name = "userOrder_listView";
            this.userOrder_listView.Size = new System.Drawing.Size(517, 354);
            this.userOrder_listView.TabIndex = 0;
            this.userOrder_listView.UseCompatibleStateImageBehavior = false;
            this.userOrder_listView.View = System.Windows.Forms.View.Details;
            // 
            // column_type
            // 
            this.column_type.Text = "房间类型";
            this.column_type.Width = 122;
            // 
            // column_beg_time
            // 
            this.column_beg_time.Text = "订单时间";
            this.column_beg_time.Width = 166;
            // 
            // column_all_price
            // 
            this.column_all_price.Text = "价格";
            this.column_all_price.Width = 86;
            // 
            // UserOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 354);
            this.Controls.Add(this.userOrder_listView);
            this.Name = "UserOrderForm";
            this.Text = "订单信息";
            this.Load += new System.EventHandler(this.userOrderForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView userOrder_listView;
        private System.Windows.Forms.ColumnHeader column_type;
        private System.Windows.Forms.ColumnHeader column_beg_time;
        private System.Windows.Forms.ColumnHeader column_all_price;
    }
}
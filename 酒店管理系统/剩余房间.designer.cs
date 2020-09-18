namespace ReceptionSection
{
    partial class 剩余房间
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
            this.listViewRestRoom = new System.Windows.Forms.ListView();
            this.Room_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.state = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewRestRoom
            // 
            this.listViewRestRoom.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Room_id,
            this.type,
            this.state});
            this.listViewRestRoom.HideSelection = false;
            this.listViewRestRoom.Location = new System.Drawing.Point(0, -1);
            this.listViewRestRoom.Name = "listViewRestRoom";
            this.listViewRestRoom.Size = new System.Drawing.Size(799, 451);
            this.listViewRestRoom.TabIndex = 0;
            this.listViewRestRoom.UseCompatibleStateImageBehavior = false;
            this.listViewRestRoom.View = System.Windows.Forms.View.Details;
            // 
            // Room_id
            // 
            this.Room_id.Text = "房间号";
            this.Room_id.Width = 91;
            // 
            // type
            // 
            this.type.Text = "房间类型";
            this.type.Width = 99;
            // 
            // state
            // 
            this.state.Text = "是否可预定";
            this.state.Width = 94;
            // 
            // 剩余房间
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(314, 450);
            this.Controls.Add(this.listViewRestRoom);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "剩余房间";
            this.Text = "剩余房间展示";
            this.Load += new System.EventHandler(this.剩余房间_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewRestRoom;
        private System.Windows.Forms.ColumnHeader Room_id;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader state;
    }
}
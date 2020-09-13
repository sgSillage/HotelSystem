namespace ReceptionSection
{
    partial class CheckInRecordForm
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
            this.listViewCheckIn = new System.Windows.Forms.ListView();
            this.User_identity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.room_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lodger_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.leave_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewCheckIn
            // 
            this.listViewCheckIn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.User_identity,
            this.name,
            this.room_id,
            this.lodger_time,
            this.leave_time});
            this.listViewCheckIn.HideSelection = false;
            this.listViewCheckIn.Location = new System.Drawing.Point(0, 0);
            this.listViewCheckIn.Name = "listViewCheckIn";
            this.listViewCheckIn.Size = new System.Drawing.Size(799, 451);
            this.listViewCheckIn.TabIndex = 0;
            this.listViewCheckIn.UseCompatibleStateImageBehavior = false;
            this.listViewCheckIn.View = System.Windows.Forms.View.Details;
            // 
            // User_identity
            // 
            this.User_identity.Text = "住客身份证";
            this.User_identity.Width = 211;
            // 
            // room_id
            // 
            this.room_id.Text = "房间号";
            this.room_id.Width = 78;
            // 
            // lodger_time
            // 
            this.lodger_time.Text = "入住时间";
            this.lodger_time.Width = 158;
            // 
            // leave_time
            // 
            this.leave_time.Text = "退房时间";
            this.leave_time.Width = 175;
            // 
            // name
            // 
            this.name.Text = "姓名";
            this.name.Width = 85;
            // 
            // CheckInRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewCheckIn);
            this.Name = "CheckInRecordForm";
            this.Text = "CheckInRecord";
            this.Load += new System.EventHandler(this.CheckInRecord_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewCheckIn;
        private System.Windows.Forms.ColumnHeader User_identity;
        private System.Windows.Forms.ColumnHeader room_id;
        private System.Windows.Forms.ColumnHeader lodger_time;
        private System.Windows.Forms.ColumnHeader leave_time;
        private System.Windows.Forms.ColumnHeader name;
    }
}
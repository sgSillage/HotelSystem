namespace HotelmanageSystem
{
    partial class ComplaintForm
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
            this.lvwComplaint = new System.Windows.Forms.ListView();
            this.colhCom_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colhOrder_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colhCom_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsComplaint = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiViewdetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDetelecomplaint = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsComplaint.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwComplaint
            // 
            this.lvwComplaint.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colhCom_id,
            this.colhOrder_id,
            this.colhCom_time});
            this.lvwComplaint.FullRowSelect = true;
            this.lvwComplaint.HideSelection = false;
            this.lvwComplaint.Location = new System.Drawing.Point(22, 49);
            this.lvwComplaint.Name = "lvwComplaint";
            this.lvwComplaint.Size = new System.Drawing.Size(773, 388);
            this.lvwComplaint.TabIndex = 0;
            this.lvwComplaint.UseCompatibleStateImageBehavior = false;
            this.lvwComplaint.View = System.Windows.Forms.View.Details;
            // 
            // colhCom_id
            // 
            this.colhCom_id.Text = "投诉人ID";
            this.colhCom_id.Width = 150;
            // 
            // colhOrder_id
            // 
            this.colhOrder_id.Text = "订单编号";
            this.colhOrder_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colhOrder_id.Width = 150;
            // 
            // colhCom_time
            // 
            this.colhCom_time.Text = "投诉时间";
            this.colhCom_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colhCom_time.Width = 150;
            // 
            // cmsComplaint
            // 
            this.cmsComplaint.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsComplaint.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiViewdetails,
            this.tsmiDetelecomplaint});
            this.cmsComplaint.Name = "cmsComplaint";
            this.cmsComplaint.Size = new System.Drawing.Size(189, 60);
            // 
            // tsmiViewdetails
            // 
            this.tsmiViewdetails.Name = "tsmiViewdetails";
            this.tsmiViewdetails.Size = new System.Drawing.Size(188, 28);
            this.tsmiViewdetails.Text = "查看投诉详情";
            this.tsmiViewdetails.Click += new System.EventHandler(this.tsmiViewdetails_Click);
            // 
            // tsmiDetelecomplaint
            // 
            this.tsmiDetelecomplaint.Name = "tsmiDetelecomplaint";
            this.tsmiDetelecomplaint.Size = new System.Drawing.Size(188, 28);
            this.tsmiDetelecomplaint.Text = "删除投诉";
            this.tsmiDetelecomplaint.Click += new System.EventHandler(this.tsmiDetelecomplaint_Click);
            // 
            // ComplaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 506);
            this.ContextMenuStrip = this.cmsComplaint;
            this.Controls.Add(this.lvwComplaint);
            this.Name = "ComplaintForm";
            this.Text = "查看投诉";
            this.Load += new System.EventHandler(this.ComplaintForm_Load);
            this.cmsComplaint.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwComplaint;
        private System.Windows.Forms.ColumnHeader colhCom_id;
        private System.Windows.Forms.ColumnHeader colhOrder_id;
        private System.Windows.Forms.ColumnHeader colhCom_time;
        private System.Windows.Forms.ContextMenuStrip cmsComplaint;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewdetails;
        private System.Windows.Forms.ToolStripMenuItem tsmiDetelecomplaint;
    }
}
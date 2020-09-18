namespace WindowsFormsApp1
{
    partial class cancelOrderForm
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
            this.lvwreserve = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsCancelOrder = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCancelOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCancelOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwreserve
            // 
            this.lvwreserve.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvwreserve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwreserve.FullRowSelect = true;
            this.lvwreserve.HideSelection = false;
            this.lvwreserve.Location = new System.Drawing.Point(0, 0);
            this.lvwreserve.Name = "lvwreserve";
            this.lvwreserve.Size = new System.Drawing.Size(520, 377);
            this.lvwreserve.TabIndex = 8;
            this.lvwreserve.UseCompatibleStateImageBehavior = false;
            this.lvwreserve.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "房号";
            this.columnHeader1.Width = 101;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "开始时间";
            this.columnHeader2.Width = 182;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "结束时间";
            this.columnHeader3.Width = 207;
            // 
            // cmsCancelOrder
            // 
            this.cmsCancelOrder.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsCancelOrder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCancelOrder});
            this.cmsCancelOrder.Name = "contextMenuStrip1";
            this.cmsCancelOrder.Size = new System.Drawing.Size(109, 28);
            // 
            // tsmiCancelOrder
            // 
            this.tsmiCancelOrder.Name = "tsmiCancelOrder";
            this.tsmiCancelOrder.Size = new System.Drawing.Size(108, 24);
            this.tsmiCancelOrder.Text = "退订";
            this.tsmiCancelOrder.Click += new System.EventHandler(this.tsmiCancelOrder_Click);
            // 
            // cancelOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 377);
            this.ContextMenuStrip = this.cmsCancelOrder;
            this.Controls.Add(this.lvwreserve);
            this.Name = "cancelOrderForm";
            this.Text = "cancelOrderForm";
            this.Load += new System.EventHandler(this.cancelOrderForm_Load);
            this.cmsCancelOrder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwreserve;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ContextMenuStrip cmsCancelOrder;
        private System.Windows.Forms.ToolStripMenuItem tsmiCancelOrder;
    }
}
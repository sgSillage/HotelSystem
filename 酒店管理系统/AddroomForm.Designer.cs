namespace HotelmanageSystem
{
    partial class AddroomForm
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
            this.lblRoom_no = new System.Windows.Forms.Label();
            this.lblRoom_kind = new System.Windows.Forms.Label();
            this.lblIsnormal = new System.Windows.Forms.Label();
            this.lblRoomprice = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtRoom_no = new System.Windows.Forms.TextBox();
            this.txtRoomkind = new System.Windows.Forms.TextBox();
            this.txtRoomprice = new System.Windows.Forms.TextBox();
            this.cmbIsnormal = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblRoom_no
            // 
            this.lblRoom_no.AutoSize = true;
            this.lblRoom_no.Location = new System.Drawing.Point(46, 69);
            this.lblRoom_no.Name = "lblRoom_no";
            this.lblRoom_no.Size = new System.Drawing.Size(71, 18);
            this.lblRoom_no.TabIndex = 0;
            this.lblRoom_no.Text = "房间号:";
            // 
            // lblRoom_kind
            // 
            this.lblRoom_kind.AutoSize = true;
            this.lblRoom_kind.Location = new System.Drawing.Point(46, 131);
            this.lblRoom_kind.Name = "lblRoom_kind";
            this.lblRoom_kind.Size = new System.Drawing.Size(98, 18);
            this.lblRoom_kind.TabIndex = 1;
            this.lblRoom_kind.Text = "房间类型：";
            // 
            // lblIsnormal
            // 
            this.lblIsnormal.AutoSize = true;
            this.lblIsnormal.Location = new System.Drawing.Point(46, 185);
            this.lblIsnormal.Name = "lblIsnormal";
            this.lblIsnormal.Size = new System.Drawing.Size(125, 18);
            this.lblIsnormal.TabIndex = 2;
            this.lblIsnormal.Text = "是否正常使用:";
            // 
            // lblRoomprice
            // 
            this.lblRoomprice.AutoSize = true;
            this.lblRoomprice.Location = new System.Drawing.Point(46, 257);
            this.lblRoomprice.Name = "lblRoomprice";
            this.lblRoomprice.Size = new System.Drawing.Size(143, 18);
            this.lblRoomprice.TabIndex = 3;
            this.lblRoomprice.Text = "房间价格(/元)：";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOk.Image = global::酒店管理系统.Properties.Resources.symbol_check_icon;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Location = new System.Drawing.Point(207, 336);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(82, 39);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "确认";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.Image = global::酒店管理系统.Properties.Resources.delete_icon;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(447, 336);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 39);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtRoom_no
            // 
            this.txtRoom_no.Location = new System.Drawing.Point(233, 59);
            this.txtRoom_no.Name = "txtRoom_no";
            this.txtRoom_no.Size = new System.Drawing.Size(100, 28);
            this.txtRoom_no.TabIndex = 6;
            // 
            // txtRoomkind
            // 
            this.txtRoomkind.Location = new System.Drawing.Point(233, 120);
            this.txtRoomkind.Name = "txtRoomkind";
            this.txtRoomkind.Size = new System.Drawing.Size(100, 28);
            this.txtRoomkind.TabIndex = 7;
            this.txtRoomkind.TextChanged += new System.EventHandler(this.txtRoomkind_TextChanged);
            // 
            // txtRoomprice
            // 
            this.txtRoomprice.Font = new System.Drawing.Font("宋体", 10.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRoomprice.Location = new System.Drawing.Point(233, 247);
            this.txtRoomprice.Name = "txtRoomprice";
            this.txtRoomprice.Size = new System.Drawing.Size(100, 31);
            this.txtRoomprice.TabIndex = 8;
            // 
            // cmbIsnormal
            // 
            this.cmbIsnormal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIsnormal.FormattingEnabled = true;
            this.cmbIsnormal.Items.AddRange(new object[] {
            "是",
            "否"});
            this.cmbIsnormal.Location = new System.Drawing.Point(233, 176);
            this.cmbIsnormal.Name = "cmbIsnormal";
            this.cmbIsnormal.Size = new System.Drawing.Size(100, 26);
            this.cmbIsnormal.TabIndex = 9;
            // 
            // AddroomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 456);
            this.Controls.Add(this.cmbIsnormal);
            this.Controls.Add(this.txtRoomprice);
            this.Controls.Add(this.txtRoomkind);
            this.Controls.Add(this.txtRoom_no);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblRoomprice);
            this.Controls.Add(this.lblIsnormal);
            this.Controls.Add(this.lblRoom_kind);
            this.Controls.Add(this.lblRoom_no);
            this.Name = "AddroomForm";
            this.Text = "新增房间";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRoom_no;
        private System.Windows.Forms.Label lblRoom_kind;
        private System.Windows.Forms.Label lblIsnormal;
        private System.Windows.Forms.Label lblRoomprice;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtRoom_no;
        private System.Windows.Forms.TextBox txtRoomkind;
        private System.Windows.Forms.TextBox txtRoomprice;
        private System.Windows.Forms.ComboBox cmbIsnormal;
    }
}
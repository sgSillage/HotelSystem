namespace 酒店管理系统
{
    partial class PayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayForm));
            this.textlabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button50 = new System.Windows.Forms.Button();
            this.button100 = new System.Windows.Forms.Button();
            this.button200 = new System.Windows.Forms.Button();
            this.button500 = new System.Windows.Forms.Button();
            this.paybutton = new System.Windows.Forms.Button();
            this.QRcode_pictureBox = new System.Windows.Forms.PictureBox();
            this.QRcode_panel = new System.Windows.Forms.Panel();
            this.succs_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QRcode_pictureBox)).BeginInit();
            this.QRcode_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textlabel
            // 
            this.textlabel.AutoSize = true;
            this.textlabel.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textlabel.Location = new System.Drawing.Point(12, 18);
            this.textlabel.Name = "textlabel";
            this.textlabel.Size = new System.Drawing.Size(226, 38);
            this.textlabel.TabIndex = 0;
            this.textlabel.Text = "充值金额 ：";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(244, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 42);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "0";
            // 
            // button50
            // 
            this.button50.Location = new System.Drawing.Point(42, 94);
            this.button50.Name = "button50";
            this.button50.Size = new System.Drawing.Size(109, 44);
            this.button50.TabIndex = 2;
            this.button50.Text = "50元";
            this.button50.UseVisualStyleBackColor = true;
            this.button50.Click += new System.EventHandler(this.button50_Click);
            // 
            // button100
            // 
            this.button100.Location = new System.Drawing.Point(225, 94);
            this.button100.Name = "button100";
            this.button100.Size = new System.Drawing.Size(110, 44);
            this.button100.TabIndex = 4;
            this.button100.Text = "100元";
            this.button100.UseVisualStyleBackColor = true;
            this.button100.Click += new System.EventHandler(this.button100_Click);
            // 
            // button200
            // 
            this.button200.Location = new System.Drawing.Point(42, 181);
            this.button200.Name = "button200";
            this.button200.Size = new System.Drawing.Size(109, 42);
            this.button200.TabIndex = 5;
            this.button200.Text = "200元";
            this.button200.UseVisualStyleBackColor = true;
            this.button200.Click += new System.EventHandler(this.button200_Click);
            // 
            // button500
            // 
            this.button500.Location = new System.Drawing.Point(225, 181);
            this.button500.Name = "button500";
            this.button500.Size = new System.Drawing.Size(110, 42);
            this.button500.TabIndex = 6;
            this.button500.Text = "500元";
            this.button500.UseVisualStyleBackColor = true;
            this.button500.Click += new System.EventHandler(this.button500_Click);
            // 
            // paybutton
            // 
            this.paybutton.Location = new System.Drawing.Point(126, 253);
            this.paybutton.Name = "paybutton";
            this.paybutton.Size = new System.Drawing.Size(112, 57);
            this.paybutton.TabIndex = 7;
            this.paybutton.Text = "确认充值";
            this.paybutton.UseVisualStyleBackColor = true;
            this.paybutton.Click += new System.EventHandler(this.paybutton_Click);
            // 
            // QRcode_pictureBox
            // 
            this.QRcode_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("QRcode_pictureBox.Image")));
            this.QRcode_pictureBox.Location = new System.Drawing.Point(3, 3);
            this.QRcode_pictureBox.Name = "QRcode_pictureBox";
            this.QRcode_pictureBox.Size = new System.Drawing.Size(341, 288);
            this.QRcode_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.QRcode_pictureBox.TabIndex = 8;
            this.QRcode_pictureBox.TabStop = false;
            // 
            // QRcode_panel
            // 
            this.QRcode_panel.Controls.Add(this.succs_button);
            this.QRcode_panel.Controls.Add(this.QRcode_pictureBox);
            this.QRcode_panel.Location = new System.Drawing.Point(12, 12);
            this.QRcode_panel.Name = "QRcode_panel";
            this.QRcode_panel.Size = new System.Drawing.Size(351, 342);
            this.QRcode_panel.TabIndex = 9;
            this.QRcode_panel.Visible = false;
            // 
            // succs_button
            // 
            this.succs_button.Location = new System.Drawing.Point(114, 297);
            this.succs_button.Name = "succs_button";
            this.succs_button.Size = new System.Drawing.Size(115, 42);
            this.succs_button.TabIndex = 9;
            this.succs_button.Text = "支付成功";
            this.succs_button.UseVisualStyleBackColor = true;
            this.succs_button.Click += new System.EventHandler(this.succs_button_Click);
            // 
            // PayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 366);
            this.Controls.Add(this.QRcode_panel);
            this.Controls.Add(this.paybutton);
            this.Controls.Add(this.button500);
            this.Controls.Add(this.button200);
            this.Controls.Add(this.button100);
            this.Controls.Add(this.button50);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textlabel);
            this.Name = "PayForm";
            this.Text = "payForm";
            ((System.ComponentModel.ISupportInitialize)(this.QRcode_pictureBox)).EndInit();
            this.QRcode_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textlabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button50;
        private System.Windows.Forms.Button button100;
        private System.Windows.Forms.Button button200;
        private System.Windows.Forms.Button button500;
        private System.Windows.Forms.Button paybutton;
        private System.Windows.Forms.PictureBox QRcode_pictureBox;
        private System.Windows.Forms.Panel QRcode_panel;
        private System.Windows.Forms.Button succs_button;
    }
}
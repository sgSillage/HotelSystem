﻿namespace HotelmanageSystem
{
    partial class AddemployeeForm
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
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lblEmployeename = new System.Windows.Forms.Label();
            this.txtEmployeename = new System.Windows.Forms.TextBox();
            this.lblEmployeesex = new System.Windows.Forms.Label();
            this.txtEmployeesalary = new System.Windows.Forms.TextBox();
            this.cmbEmployeesex = new System.Windows.Forms.ComboBox();
            this.lblEmployeesalary = new System.Windows.Forms.Label();
            this.lblEmployeestatus = new System.Windows.Forms.Label();
            this.mtxEmployeestatus = new System.Windows.Forms.MaskedTextBox();
            this.lblEmployeephone = new System.Windows.Forms.Label();
            this.mtxEmployeephone = new System.Windows.Forms.MaskedTextBox();
            this.lblEmployeetime = new System.Windows.Forms.Label();
            this.mtxEmployeetime = new System.Windows.Forms.MaskedTextBox();
            this.lblEmployeeposition = new System.Windows.Forms.Label();
            this.txtEmployeeposition = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(74, 32);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(89, 18);
            this.lblEmployeeID.TabIndex = 0;
            this.lblEmployeeID.Text = "员工编号:";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(214, 22);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(197, 28);
            this.txtEmployeeID.TabIndex = 1;
            // 
            // lblEmployeename
            // 
            this.lblEmployeename.AutoSize = true;
            this.lblEmployeename.Location = new System.Drawing.Point(74, 82);
            this.lblEmployeename.Name = "lblEmployeename";
            this.lblEmployeename.Size = new System.Drawing.Size(89, 18);
            this.lblEmployeename.TabIndex = 2;
            this.lblEmployeename.Text = "员工姓名:";
            // 
            // txtEmployeename
            // 
            this.txtEmployeename.Location = new System.Drawing.Point(214, 72);
            this.txtEmployeename.Name = "txtEmployeename";
            this.txtEmployeename.Size = new System.Drawing.Size(197, 28);
            this.txtEmployeename.TabIndex = 3;
            // 
            // lblEmployeesex
            // 
            this.lblEmployeesex.AutoSize = true;
            this.lblEmployeesex.Location = new System.Drawing.Point(74, 132);
            this.lblEmployeesex.Name = "lblEmployeesex";
            this.lblEmployeesex.Size = new System.Drawing.Size(89, 18);
            this.lblEmployeesex.TabIndex = 4;
            this.lblEmployeesex.Text = "员工性别:";
            // 
            // txtEmployeesalary
            // 
            this.txtEmployeesalary.Location = new System.Drawing.Point(214, 269);
            this.txtEmployeesalary.Name = "txtEmployeesalary";
            this.txtEmployeesalary.Size = new System.Drawing.Size(197, 28);
            this.txtEmployeesalary.TabIndex = 5;
            // 
            // cmbEmployeesex
            // 
            this.cmbEmployeesex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployeesex.FormattingEnabled = true;
            this.cmbEmployeesex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cmbEmployeesex.Location = new System.Drawing.Point(214, 124);
            this.cmbEmployeesex.Name = "cmbEmployeesex";
            this.cmbEmployeesex.Size = new System.Drawing.Size(197, 26);
            this.cmbEmployeesex.TabIndex = 6;
            // 
            // lblEmployeesalary
            // 
            this.lblEmployeesalary.AutoSize = true;
            this.lblEmployeesalary.Location = new System.Drawing.Point(74, 279);
            this.lblEmployeesalary.Name = "lblEmployeesalary";
            this.lblEmployeesalary.Size = new System.Drawing.Size(134, 18);
            this.lblEmployeesalary.TabIndex = 7;
            this.lblEmployeesalary.Text = "员工月薪(/元):";
            // 
            // lblEmployeestatus
            // 
            this.lblEmployeestatus.AutoSize = true;
            this.lblEmployeestatus.Location = new System.Drawing.Point(74, 178);
            this.lblEmployeestatus.Name = "lblEmployeestatus";
            this.lblEmployeestatus.Size = new System.Drawing.Size(89, 18);
            this.lblEmployeestatus.TabIndex = 8;
            this.lblEmployeestatus.Text = "身份证号:";
            // 
            // mtxEmployeestatus
            // 
            this.mtxEmployeestatus.Location = new System.Drawing.Point(214, 168);
            this.mtxEmployeestatus.Mask = "000000-00000000-000A";
            this.mtxEmployeestatus.Name = "mtxEmployeestatus";
            this.mtxEmployeestatus.Size = new System.Drawing.Size(197, 28);
            this.mtxEmployeestatus.TabIndex = 9;
            // 
            // lblEmployeephone
            // 
            this.lblEmployeephone.AutoSize = true;
            this.lblEmployeephone.Location = new System.Drawing.Point(74, 227);
            this.lblEmployeephone.Name = "lblEmployeephone";
            this.lblEmployeephone.Size = new System.Drawing.Size(89, 18);
            this.lblEmployeephone.TabIndex = 10;
            this.lblEmployeephone.Text = "电话号码:";
            // 
            // mtxEmployeephone
            // 
            this.mtxEmployeephone.Location = new System.Drawing.Point(214, 217);
            this.mtxEmployeephone.Mask = "000-0000-0000";
            this.mtxEmployeephone.Name = "mtxEmployeephone";
            this.mtxEmployeephone.Size = new System.Drawing.Size(197, 28);
            this.mtxEmployeephone.TabIndex = 11;
            // 
            // lblEmployeetime
            // 
            this.lblEmployeetime.AutoSize = true;
            this.lblEmployeetime.Location = new System.Drawing.Point(74, 323);
            this.lblEmployeetime.Name = "lblEmployeetime";
            this.lblEmployeetime.Size = new System.Drawing.Size(89, 18);
            this.lblEmployeetime.TabIndex = 12;
            this.lblEmployeetime.Text = "入职时间:";
            // 
            // mtxEmployeetime
            // 
            this.mtxEmployeetime.Location = new System.Drawing.Point(214, 313);
            this.mtxEmployeetime.Mask = "0000-00-00";
            this.mtxEmployeetime.Name = "mtxEmployeetime";
            this.mtxEmployeetime.Size = new System.Drawing.Size(197, 28);
            this.mtxEmployeetime.TabIndex = 13;
            this.mtxEmployeetime.ValidatingType = typeof(System.DateTime);
            // 
            // lblEmployeeposition
            // 
            this.lblEmployeeposition.AutoSize = true;
            this.lblEmployeeposition.Location = new System.Drawing.Point(74, 369);
            this.lblEmployeeposition.Name = "lblEmployeeposition";
            this.lblEmployeeposition.Size = new System.Drawing.Size(89, 18);
            this.lblEmployeeposition.TabIndex = 14;
            this.lblEmployeeposition.Text = "员工职位:";
            // 
            // txtEmployeeposition
            // 
            this.txtEmployeeposition.Location = new System.Drawing.Point(214, 358);
            this.txtEmployeeposition.Name = "txtEmployeeposition";
            this.txtEmployeeposition.Size = new System.Drawing.Size(197, 28);
            this.txtEmployeeposition.TabIndex = 15;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(214, 409);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 29);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "确认";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(457, 409);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddemployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtEmployeeposition);
            this.Controls.Add(this.lblEmployeeposition);
            this.Controls.Add(this.mtxEmployeetime);
            this.Controls.Add(this.lblEmployeetime);
            this.Controls.Add(this.mtxEmployeephone);
            this.Controls.Add(this.lblEmployeephone);
            this.Controls.Add(this.mtxEmployeestatus);
            this.Controls.Add(this.lblEmployeestatus);
            this.Controls.Add(this.lblEmployeesalary);
            this.Controls.Add(this.cmbEmployeesex);
            this.Controls.Add(this.txtEmployeesalary);
            this.Controls.Add(this.lblEmployeesex);
            this.Controls.Add(this.txtEmployeename);
            this.Controls.Add(this.lblEmployeename);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.lblEmployeeID);
            this.Name = "AddemployeeForm";
            this.Text = "新增员工";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lblEmployeename;
        private System.Windows.Forms.TextBox txtEmployeename;
        private System.Windows.Forms.Label lblEmployeesex;
        private System.Windows.Forms.TextBox txtEmployeesalary;
        private System.Windows.Forms.ComboBox cmbEmployeesex;
        private System.Windows.Forms.Label lblEmployeesalary;
        private System.Windows.Forms.Label lblEmployeestatus;
        private System.Windows.Forms.MaskedTextBox mtxEmployeestatus;
        private System.Windows.Forms.Label lblEmployeephone;
        private System.Windows.Forms.MaskedTextBox mtxEmployeephone;
        private System.Windows.Forms.Label lblEmployeetime;
        private System.Windows.Forms.MaskedTextBox mtxEmployeetime;
        private System.Windows.Forms.Label lblEmployeeposition;
        private System.Windows.Forms.TextBox txtEmployeeposition;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}
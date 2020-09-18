namespace ReceptionSection
{
    partial class CheckInTimeForm
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
            this.skinButtonSearch = new CCWin.SkinControl.SkinButton();
            this.skinButtonCancel = new CCWin.SkinControl.SkinButton();
            this.skinLabelStart = new CCWin.SkinControl.SkinLabel();
            this.skinLabelEnd = new CCWin.SkinControl.SkinLabel();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // skinButtonSearch
            // 
            this.skinButtonSearch.BackColor = System.Drawing.Color.Transparent;
            this.skinButtonSearch.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButtonSearch.DownBack = null;
            this.skinButtonSearch.Location = new System.Drawing.Point(161, 199);
            this.skinButtonSearch.MouseBack = null;
            this.skinButtonSearch.Name = "skinButtonSearch";
            this.skinButtonSearch.NormlBack = null;
            this.skinButtonSearch.Size = new System.Drawing.Size(82, 34);
            this.skinButtonSearch.TabIndex = 0;
            this.skinButtonSearch.Text = "查询";
            this.skinButtonSearch.UseVisualStyleBackColor = false;
            this.skinButtonSearch.Click += new System.EventHandler(this.skinButtonSearch_Click);
            // 
            // skinButtonCancel
            // 
            this.skinButtonCancel.BackColor = System.Drawing.Color.Transparent;
            this.skinButtonCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButtonCancel.DownBack = null;
            this.skinButtonCancel.Location = new System.Drawing.Point(336, 199);
            this.skinButtonCancel.MouseBack = null;
            this.skinButtonCancel.Name = "skinButtonCancel";
            this.skinButtonCancel.NormlBack = null;
            this.skinButtonCancel.Size = new System.Drawing.Size(82, 34);
            this.skinButtonCancel.TabIndex = 1;
            this.skinButtonCancel.Text = "取消";
            this.skinButtonCancel.UseVisualStyleBackColor = false;
            this.skinButtonCancel.Click += new System.EventHandler(this.skinButtonCancel_Click);
            // 
            // skinLabelStart
            // 
            this.skinLabelStart.AutoSize = true;
            this.skinLabelStart.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelStart.BorderColor = System.Drawing.Color.White;
            this.skinLabelStart.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelStart.Location = new System.Drawing.Point(127, 68);
            this.skinLabelStart.Name = "skinLabelStart";
            this.skinLabelStart.Size = new System.Drawing.Size(69, 20);
            this.skinLabelStart.TabIndex = 2;
            this.skinLabelStart.Text = "开始时间";
            // 
            // skinLabelEnd
            // 
            this.skinLabelEnd.AutoSize = true;
            this.skinLabelEnd.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelEnd.BorderColor = System.Drawing.Color.White;
            this.skinLabelEnd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelEnd.Location = new System.Drawing.Point(127, 127);
            this.skinLabelEnd.Name = "skinLabelEnd";
            this.skinLabelEnd.Size = new System.Drawing.Size(69, 20);
            this.skinLabelEnd.TabIndex = 3;
            this.skinLabelEnd.Text = "结束时间";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(218, 64);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 25);
            this.dateTimePickerStart.TabIndex = 6;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(218, 123);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 25);
            this.dateTimePickerEnd.TabIndex = 7;
            // 
            // CheckInTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 322);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.skinLabelEnd);
            this.Controls.Add(this.skinLabelStart);
            this.Controls.Add(this.skinButtonCancel);
            this.Controls.Add(this.skinButtonSearch);
            this.Name = "CheckInTimeForm";
            this.Text = "选择查询入住记录的时间";
            this.Load += new System.EventHandler(this.CheckInTimeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton skinButtonSearch;
        private CCWin.SkinControl.SkinButton skinButtonCancel;
        private CCWin.SkinControl.SkinLabel skinLabelStart;
        private CCWin.SkinControl.SkinLabel skinLabelEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
    }
}
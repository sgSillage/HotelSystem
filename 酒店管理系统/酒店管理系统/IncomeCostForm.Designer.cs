﻿namespace HotelmanageSystem
{
    partial class IncomeCostForm
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
            this.dtpStartime = new System.Windows.Forms.DateTimePicker();
            this.lblStartime = new System.Windows.Forms.Label();
            this.lblEndtime = new System.Windows.Forms.Label();
            this.dtpEndtime = new System.Windows.Forms.DateTimePicker();
            this.btnQuery = new System.Windows.Forms.Button();
            this.lvwIncome = new System.Windows.Forms.ListView();
            this.colhIncomekind = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colhCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colhGross = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colhIncomeDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblIncome = new System.Windows.Forms.Label();
            this.lvwCost = new System.Windows.Forms.ListView();
            this.colhCostkind = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colhCostCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colhGrossCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblCost = new System.Windows.Forms.Label();
            this.lblGrossProfit = new System.Windows.Forms.Label();
            this.txtGrossProfit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtpStartime
            // 
            this.dtpStartime.Location = new System.Drawing.Point(114, 23);
            this.dtpStartime.Name = "dtpStartime";
            this.dtpStartime.Size = new System.Drawing.Size(200, 28);
            this.dtpStartime.TabIndex = 1;
            // 
            // lblStartime
            // 
            this.lblStartime.AutoSize = true;
            this.lblStartime.Location = new System.Drawing.Point(3, 33);
            this.lblStartime.Name = "lblStartime";
            this.lblStartime.Size = new System.Drawing.Size(89, 18);
            this.lblStartime.TabIndex = 2;
            this.lblStartime.Text = "起始时间:";
            // 
            // lblEndtime
            // 
            this.lblEndtime.AutoSize = true;
            this.lblEndtime.Location = new System.Drawing.Point(6, 89);
            this.lblEndtime.Name = "lblEndtime";
            this.lblEndtime.Size = new System.Drawing.Size(89, 18);
            this.lblEndtime.TabIndex = 3;
            this.lblEndtime.Text = "结束时间:";
            // 
            // dtpEndtime
            // 
            this.dtpEndtime.Location = new System.Drawing.Point(114, 78);
            this.dtpEndtime.Name = "dtpEndtime";
            this.dtpEndtime.Size = new System.Drawing.Size(200, 28);
            this.dtpEndtime.TabIndex = 4;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(452, 61);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 33);
            this.btnQuery.TabIndex = 5;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // lvwIncome
            // 
            this.lvwIncome.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colhIncomekind,
            this.colhCount,
            this.colhGross,
            this.colhIncomeDate});
            this.lvwIncome.FullRowSelect = true;
            this.lvwIncome.HideSelection = false;
            this.lvwIncome.Location = new System.Drawing.Point(9, 184);
            this.lvwIncome.Name = "lvwIncome";
            this.lvwIncome.Size = new System.Drawing.Size(412, 170);
            this.lvwIncome.TabIndex = 0;
            this.lvwIncome.UseCompatibleStateImageBehavior = false;
            this.lvwIncome.View = System.Windows.Forms.View.Details;
            // 
            // colhIncomekind
            // 
            this.colhIncomekind.Text = "房间/服务类别";
            this.colhIncomekind.Width = 120;
            // 
            // colhCount
            // 
            this.colhCount.Text = "数量";
            this.colhCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colhGross
            // 
            this.colhGross.Text = "总额(/元)";
            this.colhGross.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colhGross.Width = 100;
            // 
            // colhIncomeDate
            // 
            this.colhIncomeDate.Text = "日期";
            this.colhIncomeDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colhIncomeDate.Width = 80;
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Location = new System.Drawing.Point(9, 139);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(53, 18);
            this.lblIncome.TabIndex = 6;
            this.lblIncome.Text = "收入:";
            // 
            // lvwCost
            // 
            this.lvwCost.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colhCostkind,
            this.colhCostCount,
            this.colhGrossCost});
            this.lvwCost.FullRowSelect = true;
            this.lvwCost.HideSelection = false;
            this.lvwCost.Location = new System.Drawing.Point(452, 184);
            this.lvwCost.Name = "lvwCost";
            this.lvwCost.Size = new System.Drawing.Size(347, 170);
            this.lvwCost.TabIndex = 7;
            this.lvwCost.UseCompatibleStateImageBehavior = false;
            this.lvwCost.View = System.Windows.Forms.View.Details;
            // 
            // colhCostkind
            // 
            this.colhCostkind.Text = "员工类别";
            this.colhCostkind.Width = 90;
            // 
            // colhCostCount
            // 
            this.colhCostCount.Text = "数量";
            this.colhCostCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colhGrossCost
            // 
            this.colhGrossCost.Text = "总额(/元)";
            this.colhGrossCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colhGrossCost.Width = 100;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(452, 139);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(53, 18);
            this.lblCost.TabIndex = 8;
            this.lblCost.Text = "支出:";
            // 
            // lblGrossProfit
            // 
            this.lblGrossProfit.AutoSize = true;
            this.lblGrossProfit.Location = new System.Drawing.Point(276, 387);
            this.lblGrossProfit.Name = "lblGrossProfit";
            this.lblGrossProfit.Size = new System.Drawing.Size(71, 18);
            this.lblGrossProfit.TabIndex = 9;
            this.lblGrossProfit.Text = "总盈利:";
            // 
            // txtGrossProfit
            // 
            this.txtGrossProfit.Location = new System.Drawing.Point(415, 377);
            this.txtGrossProfit.Name = "txtGrossProfit";
            this.txtGrossProfit.Size = new System.Drawing.Size(140, 28);
            this.txtGrossProfit.TabIndex = 10;
            // 
            // IncomeCostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtGrossProfit);
            this.Controls.Add(this.lblGrossProfit);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lvwCost);
            this.Controls.Add(this.lblIncome);
            this.Controls.Add(this.lvwIncome);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.dtpEndtime);
            this.Controls.Add(this.lblEndtime);
            this.Controls.Add(this.lblStartime);
            this.Controls.Add(this.dtpStartime);
            this.Name = "IncomeCostForm";
            this.Text = "查询收支页面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpStartime;
        private System.Windows.Forms.Label lblStartime;
        private System.Windows.Forms.Label lblEndtime;
        private System.Windows.Forms.DateTimePicker dtpEndtime;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.ListView lvwIncome;
        private System.Windows.Forms.ColumnHeader colhIncomekind;
        private System.Windows.Forms.ColumnHeader colhCount;
        private System.Windows.Forms.ColumnHeader colhGross;
        private System.Windows.Forms.ColumnHeader colhIncomeDate;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.ListView lvwCost;
        private System.Windows.Forms.ColumnHeader colhCostkind;
        private System.Windows.Forms.ColumnHeader colhCostCount;
        private System.Windows.Forms.ColumnHeader colhGrossCost;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblGrossProfit;
        private System.Windows.Forms.TextBox txtGrossProfit;
    }
}
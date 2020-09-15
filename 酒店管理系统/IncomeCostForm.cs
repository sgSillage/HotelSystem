using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;
namespace HotelmanageSystem
{
    public partial class IncomeCostForm : Skin_Mac
    {
        public IncomeCostForm()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (DateTime.Compare(dtpStartime.Value,dtpEndtime.Value) <1||dtpStartime.Value.ToShortDateString()==dtpEndtime.Value.ToShortDateString())//起始日期比结束日期早
            {
                DBHandler dBHandler = new DBHandler();
                txtGrossProfit.Text = "";//清空
                lvwCost.Items.Clear();
                lvwIncome.Items.Clear();
                int gross_profit = 0;
                //List<Income> incomes = new List<Income>();
                
                List<Income> incomes=dBHandler.GetIncomes(dtpStartime.Value.ToShortDateString(),dtpEndtime.Value.ToShortDateString());//获取收入列表
                //incomes.Add(new Income("单人间", 3, 300, "2020-01-01"));
                //incomes.Add(new Income("双人间", 2, 300, "2020-01-03"));
                //incomes.Add(new Income("大床房", 3, 420, "2020-01-04"));
                foreach(Income income in incomes)//添加列表项
                {
                    gross_profit += income.Gross_income;
                    ListViewItem listViewItem = new ListViewItem(income.Kind);
                    listViewItem.SubItems.Add(income.Count.ToString());
                    listViewItem.SubItems.Add(income.Gross_income.ToString());
                    listViewItem.SubItems.Add(income.Date);
                    lvwIncome.Items.Add(listViewItem);
                }
                //List<Cost> costs = new List<Cost>();
                //TimeSpan timeSpan = dtpEndtime.Value.Subtract(dtpStartime.Value);
                //MessageBox.Show(dtpStartime.Value.ToShortDateString() + "++" + dtpEndtime.Value.Date+"++"+timeSpan.Days);
                List<Cost> costs=dBHandler.GetCosts(dtpStartime.Value.ToShortDateString(), dtpEndtime.Value.ToShortDateString());//获取支出列表
                //costs.Add(new Cost("管理员", 1, 1000));
                //costs.Add(new Cost("前台", 10, 5000));
                //costs.Add(new Cost("清洁工", 3, 1500));
                foreach (Cost cost in costs)//添加列表项
                {
                    gross_profit -= cost.Gross_cost;
                    ListViewItem listViewItem = new ListViewItem(cost.Kind);
                    listViewItem.SubItems.Add(cost.Count.ToString());
                    listViewItem.SubItems.Add(cost.Gross_cost.ToString());
                    lvwCost.Items.Add(listViewItem);
                }
                txtGrossProfit.Text = gross_profit.ToString() + "元";//给出总的盈利
            }
            else
            {
                MessageBox.Show("起始日期晚于结束日期！", "出错提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

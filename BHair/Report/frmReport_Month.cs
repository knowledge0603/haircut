using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BHair.Business.Table;
using BHair.Business;

namespace BHair.Report
{
    public partial class frmReport_Month : WinFormsUI.Docking.DockContent
    {
        bool bRun = false;

        public frmReport_Month()
        {
            InitializeComponent();
        }

        private void frmReport_Month_Load(object sender, EventArgs e)
        {
            this.LoadYearMonth();
            this.LoadMoneyOfMonth();
            this.bRun = true;
        }

        /// <summary>加载年月数据。</summary>
        private void LoadYearMonth()
        {
            for (int y = 2011; y <= DateTime.Now.Year; y++)
            {
                this.cboYear.Items.Add(y.ToString());
            }
            this.cboYear.Text = DateTime.Now.Year.ToString();
            for (int m = 1; m <= 12; m++)
            {
                this.cboMonth.Items.Add(m.ToString());
            }
            this.cboMonth.Text = DateTime.Now.Month.ToString();
        }

        /// <summary>加载每月收支情况</summary>
        private void LoadMoneyOfMonth()
        {
            int iYear = int.Parse(this.cboYear.Text);
            int iMonth = int.Parse(this.cboMonth.Text);
            List<MonthTable> lstMonthTable = MonthTable.SelectList(iYear, iMonth);
            this.dgvMonth.AutoGenerateColumns = false;
            this.dgvMonth.Rows.Clear();
            decimal dIncome = 0;
            decimal dExpend = 0;
            decimal dProfit = 0;
            foreach (MonthTable objMonth in lstMonthTable)
            {
                this.dgvMonth.Rows.Add(new object[] { objMonth.Day, objMonth.Week, objMonth.DepositMoney, objMonth.CashMoney, objMonth.OtherMoney, objMonth.IncomeSum, objMonth.Expend, objMonth.Profit });
                dIncome += objMonth.IncomeSum;
                dExpend += objMonth.Expend;
                dProfit += objMonth.Profit;
            }
            this.lblIncomeSum.Text = "合计收入：￥" + dIncome.ToString("f2");
            this.lblExpendSum.Text = "合计支出：￥" + dExpend.ToString("f2");
            this.lblProfitSum.Text = "本月盈亏：￥" + dProfit.ToString("f2");
        }

        

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.bRun)
            {
                this.LoadMoneyOfMonth();
            }
        }

        private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.bRun)
            {
                this.LoadMoneyOfMonth();
            }
        }

        private void dgvMonth_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            StaticValue.ShowRows_DataGridView_RowPostPaint(this.dgvMonth, sender, e);
        }
    }
}

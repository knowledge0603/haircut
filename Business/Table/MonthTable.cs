using System;
using System.Collections.Generic;
using System.Text;
using XLuSharpLibrary.CommonFunction;

namespace BHair.Business.Table
{
    /// <summary>收支月报表。</summary>
    public class MonthTable
    {
        #region 构造函数...

        public MonthTable()
        { }

        #endregion

        #region 属性...

        private DateTime _Date;

        /// <summary>获取或设置报表日期。</summary>
        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }

        /// <summary>获取日期(日)。</summary>
        public int Day
        {
            get { return this.Date.Day; }
        }

        /// <summary>获取星期几(CN)。</summary>
        public string Week
        {
            get { return DateTimeClass.GetWeekText(this.Date); }
        }

        private decimal _DepositMoney;

        /// <summary>获取或设置充值收入。</summary>
        public decimal DepositMoney
        {
            get { return _DepositMoney; }
            set { _DepositMoney = value; }
        }

        private decimal _CashMoney;

        /// <summary>现金消费收入。</summary>
        public decimal CashMoney
        {
            get { return _CashMoney; }
            set { _CashMoney = value; }
        }

        private decimal _OtherMoney;

        /// <summary>获取或设置其它收入。</summary>
        public decimal OtherMoney
        {
            get { return _OtherMoney; }
            set { _OtherMoney = value; }
        }

        /// <summary>收入合计</summary>
        public decimal IncomeSum
        {
            get { return this.DepositMoney + this.CashMoney + this.OtherMoney; }
        }

        private decimal _Expend;

        /// <summary>支出</summary>
        public decimal Expend
        {
            get { return _Expend; }
            set { _Expend = value; }
        }

        /// <summary>盈亏</summary>
        public decimal Profit
        {
            get { return this.IncomeSum - this.Expend; }
        }

        #endregion

        #region 自定义函数...

        public static List<MonthTable> SelectList(int year, int month)
        {
            int iMaxDays = MonthTable.GetMaxDay(year, month);
            List<MonthTable> lstMonthTable = new List<MonthTable>();
            for (int d = 1; d <= iMaxDays; d++)
            {
                MonthTable objMonth = new MonthTable();
                objMonth.Date = DateTime.Parse(year + "-" + month + "-" + d);
                //计算收入//
                objMonth.DepositMoney += new Deposit().GetMembersMoney(year, month, d);//会员充卡收入
                objMonth.CashMoney += Pays.GetTotalPayForMember("", 0, year, month, d);//现金消费收入
                objMonth.OtherMoney += new WasteBook().GetIncomeMoney(year, month, d);//其它收入
                //计算支出//
                objMonth.Expend += new WasteBook().GetExpendMoney(year, month, d);
                
                lstMonthTable.Add(objMonth);
            }
            return lstMonthTable;
        }

        /// <summary>获取每月最大天数。</summary>
        /// <param name="year">年</param>
        /// <param name="month">月</param>
        /// <returns></returns>
        private static int GetMaxDay(int year, int month)
        {
            return DateTime.DaysInMonth(year, month);
        }

        #endregion
    }
}

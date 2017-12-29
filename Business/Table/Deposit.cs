using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using BHair.Business.BaseData;
using XLuSharpLibrary.DbAccess;

namespace BHair.Business.Table
{
    /// <summary>会员充值信息。</summary>
    public class Deposit
    {
        #region 构造函数...

        /// <summary>会员续费</summary>
        public Deposit()
        { }

        /// <summary>会员续费</summary>
        /// <param name="did">续费记录流水号</param>
        public Deposit(decimal id)
        {
            string strSql = "select * from deposit where did=" + id;
            DataTable objDataTable = StaticValue.SelectTable(strSql);
            DataRow objRow = objDataTable.Rows[0];
            this.ID = decimal.Parse(objRow["did"].ToString());
            this.MemberID = objRow["dmid"].ToString();
            this.Money = decimal.Parse(objRow["dmoney"].ToString());
            this.Date = DateTime.Parse(objRow["ddate"].ToString());
            this.Remark = objRow["dremark"].ToString();
            this.Mode = int.Parse(objRow["dmode"].ToString());
            this.ParentID = decimal.Parse(objRow["dparentid"].ToString());
        }

        #endregion

        #region 属性...

        private decimal _ID;

        /// <summary>获取或设置续费记录流水号。</summary>
        public decimal ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _MemberID;

        /// <summary>获取或设置续费记录会员卡号。</summary>
        public string MemberID
        {
            get { return _MemberID; }
            set { _MemberID = value; }
        }

        private decimal _Money;

        /// <summary>获取或设置续费金额。</summary>
        public decimal Money
        {
            get { return _Money; }
            set { _Money = value; }
        }

        private DateTime _Date = DateTime.Now;

        /// <summary>获取或设置交易时间。</summary>
        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }

        private string _Remark;

        /// <summary>获取或设置续费备注。</summary>
        public string Remark
        {
            get { return _Remark; }
            set { _Remark = value; }
        }

        private int _Mode;

        /// <summary>获取或设置充值方式(0充值，1转出，2转入，3增送，4退卡)。</summary>
        public int Mode
        {
            get { return _Mode; }
            set { _Mode = value; }
        }

        private string _ModeText;

        /// <summary>获取充值方式。</summary>
        public string ModeText
        {
            get
            {
                switch (this.Mode)
                {
                    case 0:
                        _ModeText = "充值";
                        break;
                    case 1:
                        _ModeText = "转出";
                        break;
                    case 2:
                        _ModeText = "转入";
                        break;
                    case 3:
                        _ModeText = "增送";
                        break;
                    case 4:
                        _ModeText = "退卡";
                        break;
                }
                return _ModeText;
            }
        }

        private decimal _ParentID = 0;

        /// <summary>获取或设置所属充值记录（充值增送时使用，默认为0）。</summary>
        public decimal ParentID
        {
            get { return _ParentID; }
            set { _ParentID = value; }
        }

        private Member _MemberInfo = new Member();

        /// <summary>获取会员信息。</summary>
        public Member MemberInfo
        {
            get
            {
                if (this.MemberID != null || this.MemberID != "")
                {
                    _MemberInfo = new Member(this.MemberID);
                }
                return _MemberInfo;
            }
        }

        #endregion

        #region 自定义函数...

        /// <summary>新增充值记录</summary>
        /// <returns></returns>
        public string InsertDeposit()
        {
            string strSql = "insert into deposit(dmid,dmoney,ddate,dremark,dmode,dparentid) values(@dmid,@dmoney,@ddate,@dremark,@dmode,@dparentid); select @@identity";
            SqlParameter[] cmdParameter = { new SqlParameter("@dmid", this.MemberID), new SqlParameter("@dmoney", this.Money), new SqlParameter("@ddate", this.Date), new SqlParameter("@dremark", this.Remark), new SqlParameter("@dmode", this.Mode), new SqlParameter("@dparentid", this.ParentID) };
            DataTable objDataTable = new DataTable();
            try
            {
                new SQLHelper().ExecuteSql(strSql, cmdParameter, out objDataTable);
                new Member().UpdateBalance(this.MemberID);
                return objDataTable.Rows[0][0].ToString();
            }
            catch
            { }
            return "";
        }

        /// <summary>转账</summary>
        /// <param name="deposit">目标账户</param>
        /// <returns></returns>
        public bool Transfer(Deposit deposit)
        {
            string[] strSql = new string[2];
            strSql[0] = "insert into deposit(dmid,dmoney,ddate,dremark,dmode,dparentid) values('" + this.MemberID + "'," + this.Money + ",'" + this.Date + "','" + this.Remark + "',1,0)";//转出
            strSql[1] = "insert into deposit(dmid,dmoney,ddate,dremark,dmode,dparentid) values('" + deposit.MemberID + "'," + deposit.Money + ",'" + deposit.Date + "','" + deposit.Remark + "',2,0)";//转入
            return new SQLHelper().ExecuteTransaction(strSql);
        }

        /// <summary>退卡</summary>
        /// <returns></returns>
        public int BackDeposit()
        {
            string strSql = "insert into deposit(dmid,dmoney,ddate,dmode,dparentid) values('" + this.MemberID + "'," + this.Money + ",'" + this.Date + "',4,0)";
            return new SQLHelper().ExecuteSql(strSql);
        }

        /// <summary>删除充值记录</summary>
        /// <returns></returns>
        public bool DeleteDeposit()
        {
            string[] strSql = new string[2];
            strSql[0] = "delete from deposit where did=" + this.ID;
            strSql[1] = "delete from deposit where dparentid=" + this.ID;
            return new SQLHelper().ExecuteTransaction(strSql);
        }

        /// <summary>查询会员充值记录。</summary>
        /// <param name="memberid">会员编号</param>
        /// <param name="year">年</param>
        /// <param name="month">月</param>
        /// <param name="day">日</param>
        /// <returns></returns>
        public List<Deposit> SelectList(string memberid, int year, int month, int day)
        {
            string strSql = "select * from deposit where 1=1";
            if (memberid != "")
            {
                strSql += " and dmid='" + memberid + "'";
            }
            if (year > 0)
            {
                strSql += " and datepart(year,ddate)=" + year;
            }
            if (month > 0)
            {
                strSql += " and datepart(month,ddate)=" + month;
            }
            if (day > 0)
            {
                strSql += " and datepart(day,ddate)=" + day;
            }
            DataTable objDataTable = StaticValue.SelectTable(strSql);
            List<Deposit> lstDeposit = new List<Deposit>();
            foreach (DataRow objRow in objDataTable.Rows)
            {
                lstDeposit.Add(this.GetDepositForDataRow(objRow));
            }
            return lstDeposit;
        }

        /// <summary>从数据行中获取续费记录。</summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Deposit GetDepositForDataRow(DataRow row)
        {
            Deposit objDeposit = new Deposit();
            objDeposit.ID = decimal.Parse(row["did"].ToString());
            objDeposit.MemberID = row["dmid"].ToString();
            objDeposit.Money = decimal.Parse(row["dmoney"].ToString());
            objDeposit.Date = DateTime.Parse(row["ddate"].ToString());
            objDeposit.Remark = row["dremark"].ToString();
            objDeposit.Mode = int.Parse(row["dmode"].ToString());
            return objDeposit;
        }

        /// <summary>获取会员充值总金额。</summary>
        /// <param name="memberid">会员卡号</param>
        /// <returns></returns>
        public static decimal GetTotalMoneyForMember(string memberid)
        {
            string strSql = "select sum(dmoney) from deposit where 1=1";
            if (memberid != "")
            {
                strSql += " and dmid='" + memberid + "'";
            }
            DataTable objDataTable = StaticValue.SelectTable(strSql);
            decimal dSum = 0;
            try
            {
                dSum = decimal.Parse(objDataTable.Rows[0][0].ToString());
            }
            catch
            { }
            return dSum;
        }

        /// <summary>统计会员充值金额(只计算正常充值金额)。</summary>
        /// <returns></returns>
        public decimal GetMembersMoney(int year, int month, int day)
        {
            string strSql = "select sum(dmoney) from deposit where dmode=0";
            if (year > 0)
            {
                strSql += " and datepart(year,ddate)=" + year;
            }
            if (month > 0)
            {
                strSql += " and datepart(month,ddate)=" + month;
            }
            if (day > 0)
            {
                strSql += " and datepart(day,ddate)=" + day;
            }
            DataTable objDataTable = StaticValue.SelectTable(strSql);
            try
            {
                return decimal.Parse(objDataTable.Rows[0][0].ToString());
            }
            catch
            { }
            return 0;
        }
        

        #endregion
    }
}

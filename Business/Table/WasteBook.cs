using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using XLuSharpLibrary.DbAccess;
using BHair.Business.BaseData;

namespace BHair.Business.Table
{
    /// <summary>收支流水账。</summary>
    public class WasteBook
    {
        #region 构造函数...

        /// <summary>收支流水账。</summary>
        public WasteBook()
        { }

        /// <summary>收支流水账。</summary>
        /// <param name="id">ID流水号</param>
        public WasteBook(decimal id)
        {
            string strSql = "select * from wastebook where wbid=" + id;
            DataRow objRow = StaticValue.SelectTable(strSql).Rows[0];
            this.ID = decimal.Parse(objRow["wbid"].ToString());
            this.SubjectID = int.Parse(objRow["wbsid"].ToString());
            this.Income = decimal.Parse(objRow["wbincome"].ToString());
            this.Expend = decimal.Parse(objRow["wbexpend"].ToString());
            this.Date = DateTime.Parse(objRow["wbdate"].ToString());
            this.Remark = objRow["wbremark"].ToString();
            this.Type = objRow["wbtype"].ToString();
        }

        #endregion

        #region 属性...

        private decimal _ID;

        /// <summary>获取或设置收支流水账ID；</summary>
        public decimal ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private int _SubjectID;

        /// <summary>获取或设置收支科目编号。</summary>
        public int SubjectID
        {
            get { return _SubjectID; }
            set { _SubjectID = value; }
        }

        private decimal _Income;

        /// <summary>获取或设置收支流水账收入金额。</summary>
        public decimal Income
        {
            get { return _Income; }
            set { _Income = value; }
        }

        private decimal _Expend;

        /// <summary>获取或设置收支流水账支出金额。</summary>
        public decimal Expend
        {
            get { return _Expend; }
            set { _Expend = value; }
        }

        private DateTime _Date;

        /// <summary>获取或设置收支流水账记录时间。</summary>
        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }

        private string _Remark;

        /// <summary>获取或设置收支流水账备注。</summary>
        public string Remark
        {
            get { return _Remark; }
            set { _Remark = value; }
        }

        private string _Type;

        /// <summary>获取或设置收支流水账收支类型。</summary>
        public string Type
        {
            get { return _Type; }
            set { _Type = value; }
        }

        private Subject _Subject;

        /// <summary>获取收支科目信息。</summary>
        public Subject Subject
        {
            get
            {
                if (this.SubjectID > 0)
                {
                    _Subject = new Subject(this.SubjectID);
                }
                return _Subject;
            }
        }

        #endregion

        #region 自定义函数...

        /// <summary>查询收支流水账</summary>
        /// <param name="year">年</param>
        /// <param name="month">月</param>
        /// <param name="day">日</param>
        /// <returns></returns>
        public DataTable SelectDataTable(int year, int month, int day)
        {
            string strSql = "select * from wastebook where 1=1";
            if (year > 0)
            {
                strSql += " and datepart(year,wbdate)=" + year;
            }
            if (month > 0)
            {
                strSql += " and datepart(month,wbdate)=" + month;
            }
            if (day > 0)
            {
                strSql += " and datepart(day,wbdate)=" + day;
            }
            strSql += " order by wbdate";
            DataTable objDataTable = StaticValue.SelectTable(strSql);
            return objDataTable;
        }

        /// <summary>查询收支流水账</summary>
        /// <param name="year">年</param>
        /// <param name="month">月</param>
        /// <param name="day">日</param>
        /// <param name="type">收支类型</param>
        /// <returns></returns>
        public List<WasteBook> SelectList(int year, int month, int day)
        {
            DataTable objDataTable = this.SelectDataTable(year, month, day);
            List<WasteBook> lstWasteBook = new List<WasteBook>();
            foreach (DataRow objRow in objDataTable.Rows)
            {
                WasteBook objWasteBook = new WasteBook();
                objWasteBook.ID = decimal.Parse(objRow["wbid"].ToString());
                objWasteBook.SubjectID = int.Parse(objRow["wbsid"].ToString());
                objWasteBook.Income = decimal.Parse(objRow["wbincome"].ToString());
                objWasteBook.Expend = decimal.Parse(objRow["wbexpend"].ToString());
                objWasteBook.Date = DateTime.Parse(objRow["wbdate"].ToString());
                objWasteBook.Remark = objRow["wbremark"].ToString();
                objWasteBook.Type = objRow["wbtype"].ToString();
                lstWasteBook.Add(objWasteBook);
            }
            return lstWasteBook;
        }

        /// <summary>新增收支帐目。</summary>
        /// <returns></returns>
        public int InsertWasteBook()
        {
            string strSql = "insert into wastebook(wbsid,wbincome,wbexpend,wbdate,wbremark,wbtype) values(@wbsid,@wbincome,@wbexpend,@wbdate,@wbremark,@wbtype)";//收入
            SqlParameter[] cmdParameter = { new SqlParameter("@wbsid", this.SubjectID), new SqlParameter("@wbincome", this.Income), new SqlParameter("@wbexpend", this.Expend), new SqlParameter("@wbdate", this.Date), new SqlParameter("@wbremark", this.Remark), new SqlParameter("@wbtype", this.Type) };
            return new SQLHelper().ExecuteSql(strSql, cmdParameter);
        }

        /// <summary>修改收支帐目。</summary>
        /// <returns></returns>
        public int UpdateExpend()
        {
            string strSql = "update wastebook set wbsid=@wbsid,wbincome=@wbincome,wbexpend=@wbexpend,wbdate=@wbdate,wbremark=@wbremark where wbid=@wbid";
            SqlParameter[] cmdParameter = { new SqlParameter("@wbsid", this.SubjectID), new SqlParameter("@wbincome", this.Income), new SqlParameter("@wbexpend", this.Expend), new SqlParameter("@wbdate", this.Date), new SqlParameter("@wbremark", this.Remark), new SqlParameter("@wbid", this.ID) };
            return new SQLHelper().ExecuteSql(strSql, cmdParameter);
        }

        /// <summary>删除记录</summary>
        /// <param name="id">记录编号</param>
        /// <returns></returns>
        public int Delete(decimal id)
        {
            string strSql = "delete from wastebook where wbid=" + id;
            return new SQLHelper().ExecuteSql(strSql);
        }

        /// <summary>支出</summary>
        public decimal GetExpendMoney(int year, int month, int day)
        {
            string strSql = "select sum(wbexpend) from wastebook where datepart(year,wbdate)=" + year + " and datepart(month,wbdate)=" + month + " and wbtype='e'";
            if (day > 0)
            {
                strSql += " and datepart(day,wbdate)=" + day;
            }
            DataTable objTable = StaticValue.SelectTable(strSql);
            try
            {
                return decimal.Parse(objTable.Rows[0][0].ToString());
            }
            catch { }
            return 0;
        }

        /// <summary>收入</summary>
        public decimal GetIncomeMoney(int year, int month, int day)
        {
            string strSql = "select sum(wbincome) from wastebook where datepart(year,wbdate)=" + year + " and datepart(month,wbdate)=" + month + " and wbtype='i'";
            if (day > 0)
            {
                strSql += " and datepart(day,wbdate)=" + day;
            }
            DataTable objTable = StaticValue.SelectTable(strSql);
            try
            {
                return decimal.Parse(objTable.Rows[0][0].ToString());
            }
            catch { }
            return 0;
        }

        #endregion
    }
}

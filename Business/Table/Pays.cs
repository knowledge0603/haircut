using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using XLuSharpLibrary.DbAccess;
using XLuSharpLibrary.CommonFunction;
using BHair.Business.BaseData;

namespace BHair.Business.Table
{
    /// <summary>消费单据。</summary>
    public class Pays
    {
        private SQLHelper objSQLHelper = new SQLHelper();

        #region 构造函数...

        /// <summary>消费单据。</summary>
        public Pays()
        { }

        /// <summary>消费单据。</summary>
        /// <param name="payid"></param>
        public Pays(string payid)
        {
            string strSql = "select * from pays where pid='" + payid + "'";
            DataRow objRow = StaticValue.SelectTable(strSql).Rows[0];
            this.PayID = objRow["pid"].ToString();
            this.MemberId = objRow["pmid"].ToString();
            this.EmpID1 = int.Parse(objRow["peid1"].ToString());
            this.EmpID2 = int.Parse(objRow["peid2"].ToString());
            this.EmpID3 = int.Parse(objRow["peid3"].ToString());
            this.Money = decimal.Parse(objRow["pmoney"].ToString());
            this.Cash = decimal.Parse(objRow["pcash"].ToString());
            this.Zero = decimal.Parse(objRow["pzero"].ToString());
            this.PayType = int.Parse(objRow["ptype"].ToString());
            this.PayDate = DateTime.Parse(objRow["pdate"].ToString());
            this.Remark = objRow["premark"].ToString();
            this.Status = int.Parse(objRow["pstatus"].ToString());
            this.IsCall = int.Parse(objRow["pcall"].ToString());
        }

        #endregion

        #region 属性...

        #region 读写属性...

        private string _PayID;

        /// <summary>获取或设置消费单号。</summary>
        public string PayID
        {
            get { return _PayID; }
            set { _PayID = value; }
        }

        private string _MemberId;

        /// <summary>获取或设置会员卡号(0为非会员)。</summary>
        public string MemberId
        {
            get { return _MemberId; }
            set { _MemberId = value; }
        }

        private int _EmpID1;

        /// <summary>获取或设置洗头助理。</summary>
        public int EmpID1
        {
            get { return _EmpID1; }
            set { _EmpID1 = value; }
        }

        private int _EmpID2;

        /// <summary>获取或设置烫染助理。</summary>
        public int EmpID2
        {
            get { return _EmpID2; }
            set { _EmpID2 = value; }
        }

        private int _EmpID3;

        /// <summary>获取或设置发型师。</summary>
        public int EmpID3
        {
            get { return _EmpID3; }
            set { _EmpID3 = value; }
        }

        private decimal _Money;

        /// <summary>获取或设置消费金额。</summary>
        public decimal Money
        {
            get { return _Money; }
            set { _Money = value; }
        }

        private decimal _Cash;

        /// <summary>获取或设置实收金额。</summary>
        public decimal Cash
        {
            get { return _Cash; }
            set { _Cash = value; }
        }

        private decimal _Zero;

        /// <summary>获取或设置找零金额。</summary>
        public decimal Zero
        {
            get { return _Zero; }
            set { _Zero = value; }
        }

        private int _PayType;

        /// <summary>获取或设置付款(支付)方式。(0现金，1余额，2积分)</summary>
        public int PayType
        {
            get { return _PayType; }
            set { _PayType = value; }
        }

        private DateTime _PayDate = DateTime.Now;

        /// <summary>获取或设置消费日期时间。</summary>
        public DateTime PayDate
        {
            get { return _PayDate; }
            set { _PayDate = value; }
        }

        private string _Remark;

        /// <summary>获取或设置消费单据备注。</summary>
        public string Remark
        {
            get { return _Remark; }
            set { _Remark = value; }
        }

        private int _Status;

        /// <summary>获取或设置消费单据支付状态(0挂单，1已结算)。</summary>
        public int Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        private int _IsCall;

        /// <summary>获取或设置是否点牌(0否，1是)。</summary>
        public int IsCall
        {
            get { return _IsCall; }
            set { _IsCall = value; }
        }

        #endregion

        #region 只读属性...

        private Member _Member = new Member();

        /// <summary>获取会员信息。</summary>
        public Member Member
        {
            get
            {
                if ((this.MemberId != null || this.MemberId != "" || this.MemberId != "0") && NumericClass.IsNumber(this.MemberId))
                {
                    _Member = new Member(this.MemberId);
                }
                return _Member;
            }
        }

        private string _ClientName;

        /// <summary>获取顾客/会员信息。</summary>
        public string ClientName
        {
            get
            {
                if (this.MemberId == "0")
                {
                    _ClientName = "【非会员】普通顾客";
                }
                else
                {
                    _ClientName = "【" + this.Member.ID + "】" + this.Member.Name;
                }
                return _ClientName;
            }
        }

        private List<PayDetail> _PayDetails = new List<PayDetail>();

        /// <summary>获取消费明细。</summary>
        public List<PayDetail> PayDetails
        {
            get
            {
                if (this.PayID != null || this.PayID != "")
                {
                    _PayDetails = PayDetail.SelectList(this.PayID);
                }
                return _PayDetails;
            }
        }

        private string _PayContent;

        /// <summary>获取简明消费内容。</summary>
        public string PayContent
        {
            get
            {
                if (this.PayDetails.Count > 0)
                {
                    foreach (PayDetail objDet in this.PayDetails)
                    {
                        _PayContent += objDet.SPItem.Name + ",";
                    }
                    _PayContent = _PayContent.Substring(0, _PayContent.Length - 1);
                }
                return _PayContent;
            }
        }

        private string _PayTypeText;

        /// <summary>获取支付方式。</summary>
        public string PayTypeText
        {
            get
            {
                switch (this.PayType)
                {
                    case 0:
                        _PayTypeText = "现金";
                        break;
                    case 1:
                        _PayTypeText = "余额";
                        break;
                    case 2:
                        _PayTypeText = "积分";
                        break;
                }
                return _PayTypeText;
            }
        }

        private string _StatusText;

        /// <summary>获取消费单据状态。</summary>
        public string StatusText
        {
            get
            {
                if (this.Status == 0)
                {
                    _StatusText = "挂单";
                }
                else
                {
                    _StatusText = "已结算";
                }
                return _StatusText;
            }
        }


        #endregion

        #endregion

        #region 自定义函数...

        /// <summary>检查消费单号是否存在。</summary>
        /// <param name="payid">消费单号</param>
        /// <returns></returns>
        public string ExistsPayCode(string payid)
        {
            string strSql = "select * from pays where pid=@pid";
            SqlParameter[] cmdParameter = { new SqlParameter("@pid", payid) };
            DataTable objDataTable = new DataTable();
            new SQLHelper().ExecuteSql(strSql, cmdParameter, out objDataTable);
            if (objDataTable.Rows.Count > 0)
            {
                return objDataTable.Rows[0]["pid"].ToString();
            }
            return "";
        }

        /// <summary>获取消费单据。</summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Pays GetPays(DataRow row)
        {
            Pays objPay = new Pays();
            objPay.PayID = row["pid"].ToString();
            objPay.MemberId = row["pmid"].ToString();
            objPay.EmpID1 = int.Parse(row["peid1"].ToString());
            objPay.EmpID2 = int.Parse(row["peid2"].ToString());
            objPay.EmpID3 = int.Parse(row["peid3"].ToString());
            objPay.Money = decimal.Parse(row["pmoney"].ToString());
            objPay.Cash = decimal.Parse(row["pcash"].ToString());
            objPay.Zero = decimal.Parse(row["pzero"].ToString());
            objPay.PayType = int.Parse(row["ptype"].ToString());
            objPay.PayDate = DateTime.Parse(row["pdate"].ToString());
            objPay.Remark = row["premark"].ToString();
            objPay.Status = int.Parse(row["pstatus"].ToString());
            objPay.IsCall = int.Parse(row["pcall"].ToString());
            return objPay;
        }

        /// <summary>获取会员消费总金额。</summary>
        /// <param name="memberid">会员卡号</param>
        /// <param name="type">支付方式(只能输入0现金或1余额)</param>
        /// <param name="year">年</param>
        /// <param name="month">月</param>
        /// <param name="day">日</param>
        /// <returns></returns>
        public static decimal GetTotalPayForMember(string memberid, int type, int year, int month, int day)
        {
            string strSql = "select sum(pmoney) from pays where ptype=" + type;
            if (memberid != "")
            {
                strSql += " and pmid='" + memberid + "'";
            }
            if (year > 0)
            {
                strSql += " and datepart(year,pdate)=" + year;
            }
            if (month > 0)
            {
                strSql += " and datepart(month,pdate)=" + month;
            }
            if (day > 0)
            {
                strSql += " and datepart(day,pdate)=" + day;
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

        /// <summary>查询员工业绩</summary>
        /// <param name="empid">员工编号(ID)</param>
        /// <returns></returns>
        public List<Pays> SelectListForEmployee(int empid, int year, int month)
        {
            string strSql = "select * from pays where (datepart(year, pdate)=@year and datepart(month, pdate)=@month) and (peid1=@empid or peid2=@empid or peid3=@empid) and pstatus=1";
            strSql += " order by pdate";
            SqlParameter[] cmdParameter = { new SqlParameter("@year", year), new SqlParameter("@month", month), new SqlParameter("@empid", empid) };
            DataTable objDataTable = new DataTable();
            new SQLHelper().ExecuteSql(strSql, cmdParameter, out objDataTable);
            List<Pays> lstPay = new List<Pays>();
            foreach(DataRow objRow in objDataTable.Rows)
            {
                lstPay.Add(this.GetPays(objRow));
            }
            return lstPay;
        }

        /// <summary>获取员工业绩数量。</summary>
        /// <param name="empid"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public int GetCountForEmployee(int empid, int year, int month)
        {
            string strSql = "select count(*) from pays where (datepart(year, pdate)=@year and datepart(month, pdate)=@month) and (peid1=@empid or peid2=@empid or peid3=@empid)";
            DataTable objDataTable = new DataTable();
            SqlParameter[] cmdParameter = { new SqlParameter("@year", year), new SqlParameter("@month", month), new SqlParameter("@empid", empid) };
            this.objSQLHelper.ExecuteSql(strSql, cmdParameter, out objDataTable);
            return int.Parse(objDataTable.Rows[0][0].ToString());
        }

        /// <summary>获取员工业绩金额。</summary>
        /// <param name="empid"></param>
        /// <returns></returns>
        public decimal GetMoneyForEmployee(int empid, int year, int month)
        {
            string strSql = "select sum(pmoney) from pays where (datepart(year, pdate)=@year and datepart(month, pdate)=@month) and (peid1=@empid or peid2=@empid or peid3=@empid)";
            DataTable objDataTable = new DataTable();
            SqlParameter[] cmdParameter = { new SqlParameter("@year", year), new SqlParameter("@month", month), new SqlParameter("@empid", empid) };
            this.objSQLHelper.ExecuteSql(strSql, cmdParameter, out objDataTable);
            if (new Employee(empid).Post.Mode == 1)//发型师业绩
            {
                List<Pays> lstPays = new Pays().SelectListForEmployee(empid, year, month);
                decimal dSum = 0;
                foreach (Pays objPay in lstPays)
                {
                    foreach (PayDetail objDetail in objPay.PayDetails)
                    {
                        if (objDetail.SPItem.IsTiCheng == 0)
                        {
                            dSum += objDetail.Sum - objDetail.FatPrice;
                        }
                    }
                }
                return dSum;
            }
            try
            {
                return decimal.Parse(objDataTable.Rows[0][0].ToString());
            }
            catch
            { }
            return 0;
        }

        /// <summary>查询会员消费单据</summary>
        /// <param name="payid">消费单号</param>
        /// <param name="memberid">会员卡号</param>
        /// <param name="year">年</param>
        /// <param name="month">月</param>
        /// <param name="day">日</param>
        /// <param name="type">支付方式</param>
        /// <param name="status">状态</param>
        /// <returns></returns>
        public List<Pays> SelectList(string payid, string memberid, int year, int month, int day, int? type, int? status)
        {
            string strSql = "select * from pays where 1=1";
            if (payid != "")
            {
                strSql += " and pid like '" + payid + "%'";
            }
            if (memberid != "")
            {
                strSql += " and pmid='" + memberid + "'";
            }
            if (year > 0)
            {
                strSql += " and datepart(year, pdate)=" + year;
            }
            if (month > 0)
            {
                strSql += " and datepart(month, pdate)=" + month;
            }
            if (day > 0)
            {
                strSql += " and datepart(day, pdate)=" + day;
            }
            if (type != null)
            {
                strSql += " and ptype=" + type;
            }
            if (status != null)
            {
                strSql += " and pstatus=" + status;
            }
            strSql += " order by pdate";
            DataTable objDataTable = new DataTable();
            new SQLHelper().ExecuteSql(strSql, out objDataTable);
            List<Pays> lstPay = new List<Pays>();
            foreach (DataRow objRow in objDataTable.Rows)
            {
                lstPay.Add(this.GetPays(objRow));
            }
            return lstPay;
        }

        /// <summary>新增消费单据。</summary>
        /// <returns></returns>
        public int InsertPay()
        {
            string strSql = "insert into pays(pid,pmid,peid1,peid2,peid3,pmoney,premark,pdate,pstatus,ptype) values(@pid,@pmid,@peid1,@peid2,@peid3,@pmoney,@premark,@pdate,0,0)";
            SqlParameter[] cmdParameter = { new SqlParameter("@pid", this.PayID), new SqlParameter("@pmid", this.MemberId), new SqlParameter("@peid1", this.EmpID1), new SqlParameter("@peid2", this.EmpID2), new SqlParameter("@peid3", this.EmpID3), new SqlParameter("@pmoney", this.Money), new SqlParameter("@premark", this.Remark), new SqlParameter("@pdate", this.PayDate) };
            return new SQLHelper().ExecuteSql(strSql, cmdParameter);
        }

        /// <summary>更新消费单据</summary>
        /// <returns></returns>
        public int UpdatePay()
        {
            string strSql = "update pays set pmid=@pmid,peid1=@peid1,peid2=@peid2,peid3=@peid3,pmoney=@pmoney,premark=@premark,pdate=@pdate where pid=@ID";
            SqlParameter[] cmdParameter = { new SqlParameter("@pmid", this.MemberId), new SqlParameter("@peid1", this.EmpID1), new SqlParameter("@peid2", this.EmpID2), new SqlParameter("@peid3", this.EmpID3), new SqlParameter("@pmoney", this.Money), new SqlParameter("@premark", this.Remark), new SqlParameter("@pdate", this.PayDate), new SqlParameter("@ID", this.PayID) };
            return this.objSQLHelper.ExecuteSql(strSql, cmdParameter);
        }

        /// <summary>删除消费单据</summary>
        /// <param name="payid">消费单号</param>
        /// <returns></returns>
        public bool DeletePay(string payid)
        {
            string[] strSql = new string[2];
            strSql[0] = "delete from pays where pid='" + payid + "'";
            strSql[1] = "delete from paydetails where pdpid='" + payid + "'";
            return new SQLHelper().ExecuteTransaction(strSql);
        }

        /// <summary>更新消费备注信息。</summary>
        public int UpdatePayRemark()
        {
            string strSql = "update pays set premark=@Remark where pid=@ID";
            SqlParameter[] cmdParameter = { new SqlParameter("@Remark", this.Remark), new SqlParameter("@ID", this.PayID) };
            return new SQLHelper().ExecuteSql(strSql, cmdParameter);
        }

        /// <summary>确认收款</summary>
        /// <returns></returns>
        public int UpdatePaysOK()
        {
            string strSql = "update pays set pcash=@pcash,pzero=@pzero,ptype=@ptype,premark=@premark,pstatus=1 where pid=@pid";
            SqlParameter[] cmdParameter = { new SqlParameter("@pcash", this.Cash), new SqlParameter("@pzero", this.Zero), new SqlParameter("@ptype", this.PayType), new SqlParameter("@premark", this.Remark), new SqlParameter("@pid", this.PayID) };
            return new SQLHelper().ExecuteSql(strSql, cmdParameter);
        }

        /// <summary>更新消费金额</summary>
        /// <param name="payid"></param>
        /// <param name="money"></param>
        /// <returns></returns>
        public int UpdateMoney(string payid, decimal money)
        {
            string strSql = "update pays set pmoney=@pmoney where pid=@pid";
            SqlParameter[] cmdParameter = { new SqlParameter("@pid", payid), new SqlParameter("@pmoney", money) };
            return new SQLHelper().ExecuteSql(strSql, cmdParameter);
        }

        #endregion
    }
}

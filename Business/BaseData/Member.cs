using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using XLuSharpLibrary.DbAccess;
using BHair.Business.Table;

namespace BHair.Business.BaseData
{
    /// <summary>会员信息管理。</summary>
    public class Member
    {
        #region 构造函数...

        /// <summary>会员信息管理。</summary>
        public Member()
        { }

        /// <summary>会员信息管理。</summary>
        /// <param name="mid">会员编号</param>
        public Member(string mid)
        {
            string strSql = "select * from member where mid='" + mid + "'";
            DataRow objRow = StaticValue.SelectTable(strSql).Rows[0];
            this.ID = objRow["mid"].ToString();
            this.Name = objRow["mname"].ToString();
            this.Status = int.Parse(objRow["mstatus"].ToString());
            this.CardID = int.Parse(objRow["mcid"].ToString());
            this.Password = objRow["mpass"].ToString();
            this.Remark = objRow["mremark"].ToString();
            this.Sex = int.Parse(objRow["msex"].ToString());
            this.Month = int.Parse(objRow["mmonth"].ToString());
            this.Day = int.Parse(objRow["mday"].ToString());
            this.Phone = objRow["mphone"].ToString();
            this.Address = objRow["maddress"].ToString();
            this.Other = objRow["mother"].ToString();
            this.JoinDate = DateTime.Parse(objRow["mjoin"].ToString());
            this.IDCard = objRow["midcard"].ToString();
        }

        #endregion

        #region 属性...

        #region 读写属性...

        private string _ID;

        /// <summary>获取或设置会员卡号，会员唯一标识。</summary>
        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _Name;

        /// <summary>获取或设置会员姓名。</summary>
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private int _Status;

        /// <summary>获取或设置会员状态。（0可用；1不可用）</summary>
        public int Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        private int _CardID;

        /// <summary>获取或设置会员卡类型ID。</summary>
        public int CardID
        {
            get { return _CardID; }
            set { _CardID = value; }
        }

        private string _Password;

        /// <summary>获取或设置会员密码。</summary>
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        private string _Remark;

        /// <summary>获取或设置会员备注。</summary>
        public string Remark
        {
            get { return _Remark; }
            set { _Remark = value; }
        }

        private int _Sex;

        /// <summary>获取或设置会员性别。</summary>
        public int Sex
        {
            get { return _Sex; }
            set { _Sex = value; }
        }

        private int _Month;

        /// <summary>获取或设置会员出生日期(月)。</summary>
        public int Month
        {
            get { return _Month; }
            set { _Month = value; }
        }

        private int _Day;

        /// <summary>获取或设置会员出生日期(日)。</summary>
        public int Day
        {
            get { return _Day; }
            set { _Day = value; }
        }

        private string _Phone;

        /// <summary>获取或设置会员联系电话。</summary>
        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }

        private string _Address;

        /// <summary>获取或设置会员联系地址。</summary>
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        private string _Other;

        /// <summary>获取或设置会员其它信息。</summary>
        public string Other
        {
            get { return _Other; }
            set { _Other = value; }
        }

        private DateTime _JoinDate;

        /// <summary>获取或设置会员加入日期。</summary>
        public DateTime JoinDate
        {
            get { return _JoinDate; }
            set { _JoinDate = value; }
        }

        private string _IDCard;

        /// <summary>获取或设置会员身份证号码。</summary>
        public string IDCard
        {
            get { return _IDCard; }
            set { _IDCard = value; }
        }

        #endregion

        #region 只读属性...

        private string _SexText;

        /// <summary>获取会员性别(文本值)。</summary>
        public string SexText
        {
            get
            {
                _SexText = "男";
                if (this.Sex == 0)
                {
                    _SexText = "女";
                }
                return _SexText;
            }
        }

        private string _Birthday;

        /// <summary>获取会员出生日期。</summary>
        public string Birthday
        {
            get
            {
                _Birthday = "";
                if (this.Month > 0)
                {
                    _Birthday = this.Month + "月";
                    if (this.Day > 0)
                    {
                        _Birthday += this.Day + "日";
                    }
                }
                return _Birthday;
            }
        }

        private Card _Card = new Card();

        /// <summary>获取会员类型。</summary>
        public Card Card
        {
            get
            {
                if (this.CardID > 0)
                {
                    _Card = new Card(this.CardID);
                }
                return _Card;
            }
        }

        private decimal _Balance = 0;

        /// <summary>获取会员当前可用余额。</summary>
        public decimal Balance
        {
            get
            {
                if (this.ID != null || this.ID != "")
                {
                    decimal dSumRec = Deposit.GetTotalMoneyForMember(this.ID, 0, 0, 0);//充值总额
                    decimal dSumPay = Pays.GetTotalPayForMember(this.ID, 1, 0, 0, 0);//消费总额
                    _Balance = dSumRec - dSumPay;
                }
                return _Balance;
            }
        }

        private int _Point = 0;

        /// <summary>获取会员当前可用积分。</summary>
        public int Point
        {
            get { return _Point; }
        }

        private DateTime _LastDate = DateTime.Now;

        /// <summary>获取会员最近光顾日期。</summary>
        public DateTime LastDate
        {
            get { return _LastDate; }
        }

        private string _StatusText;

        /// <summary>获取会员当前状态(文本值)。</summary>
        public string StatusText
        {
            get
            {
                if (this.Status == 0)
                {
                    _StatusText = "可用";
                }
                else
                {
                    _StatusText = "不可用";
                }
                return _StatusText;
            }
        }

        #endregion

        #endregion

        #region 自定义函数...

        /// <summary>检查会员卡号是否存在。</summary>
        /// <param name="mid">会员卡号</param>
        /// <returns></returns>
        public string ExistsMemberCard(string mid)
        {
            string strSql = "select * from member where mid=@mid";
            SqlParameter[] cmdParameter = { new SqlParameter("@mid", mid) };
            DataTable objDataTable = new DataTable();
            new SQLHelper().ExecuteSql(strSql, cmdParameter, out objDataTable);
            if (objDataTable.Rows.Count > 0)
            {
                return objDataTable.Rows[0]["mid"].ToString();
            }
            return "";
        }

        /// <summary>查询会员信息。</summary>
        /// <param name="membertext">会员卡号或姓名</param>
        /// <param name="enabled">显示不可用会员</param>
        /// <returns></returns>
        public List<Member> SelectList(string membertext, bool enabled)
        {
            //优先查询生日会员
            string strSql1 = "select *,(select sum(dmoney) from deposit where dmid=member.mid) as sumdep,(select sum(pmoney) from pays where pmid=member.mid and ptype=1) as sumpay from member where (datepart(month,getdate())<=mmonth and datepart(day,getdate())<=mday)";
            string strSql2 = "select * from member where 1=1";
            if (membertext != "")
            {
                strSql1 += " and (mid like '" + membertext + "%' or mname like '%" + membertext + "%')";
                strSql2 += " and (mid like '" + membertext + "%' or mname like '%" + membertext + "%')";
            }
            if (enabled)
            {
                strSql1 += " and mstatus=1";
                strSql2 += " and mstatus=1";
            }
            else
            {
                strSql1 += " and mstatus=0";
                strSql2 += " and mstatus=0";
            }
            strSql1 += " order by mmonth,mday";
            strSql2 += " order by mmonth,mday";
            DataTable objTable1 = StaticValue.SelectTable(strSql1);
            DataTable objTable2 = StaticValue.SelectTable(strSql2);
            //合并表
            objTable1.Merge(objTable2);
            DataTable objTable = StaticValue.GetDistinctTable(objTable1, "mid");
            List<Member> lstMember = new List<Member>();
            foreach (DataRow objRow in objTable.Rows)
            {
                lstMember.Add(this.GetMemberForRow(objRow));
            }
            return lstMember;
        }

        private Member GetMemberForRow(DataRow objRow)
        {
            Member objMember = new Member();
            objMember.ID = objRow["mid"].ToString();
            objMember.Name = objRow["mname"].ToString();
            objMember.Status = int.Parse(objRow["mstatus"].ToString());
            objMember.CardID = int.Parse(objRow["mcid"].ToString());
            objMember.Password = objRow["mpass"].ToString();
            objMember.Remark = objRow["mremark"].ToString();
            objMember.Sex = int.Parse(objRow["msex"].ToString());
            objMember.Month = int.Parse(objRow["mmonth"].ToString());
            objMember.Day = int.Parse(objRow["mday"].ToString());
            objMember.Phone = objRow["mphone"].ToString();
            objMember.Address = objRow["maddress"].ToString();
            objMember.Other = objRow["mother"].ToString();
            objMember.JoinDate = DateTime.Parse(objRow["mjoin"].ToString());
            objMember.IDCard = objRow["midcard"].ToString();
            return objMember;
        }

        /// <summary>获取会员总数量</summary>
        /// <param name="mode">查询方式(0可用，1不可用，2全部)</param>
        /// <param name="cid">会员卡类型(0所有)</param>
        /// <returns></returns>
        public static int GetMemberTotal(int mode, int cid)
        {
            string strSql = "select count(*) from member where 1=1";
            switch (mode)
            {
                case 0://查询可用会员数据
                    strSql += " and mstatus=0";
                    break;
                case 1://查询不可用会员数据
                    strSql += " and mstatus=1";
                    break;
                case 2://查询所有会员
                    break;
            }
            if (cid > 0)
            {
                strSql += " and mcid=" + cid;
            }
            DataTable objDataTable = new DataTable();
            new SQLHelper().ExecuteSql(strSql, out objDataTable);
            return int.Parse(objDataTable.Rows[0][0].ToString());
        }

        /// <summary>新增会员信息。</summary>
        /// <returns></returns>
        public int InsertMember()
        {
            string strSql = "insert member values(@mid,@mname,@mstatus,@mcid,@mpass,@mremark,@msex,@mmonth,@mday,@mphone,@maddress,@mother,@mjoin,@midcard)";
            SqlParameter[] cmdParameter =
                {
                    new SqlParameter("@mid", this.ID),
                    new SqlParameter("@mname", this.Name),
                    new SqlParameter("@mstatus", this.Status),
                    new SqlParameter("@mcid", this.CardID),
                    new SqlParameter("@mpass", this.Password),
                    new SqlParameter("@mremark", this.Remark),
                    new SqlParameter("@msex", this.Sex),
                    new SqlParameter("@mmonth", this.Month),
                    new SqlParameter("@mday", this.Day),
                    new SqlParameter("@mphone", this.Phone),
                    new SqlParameter("@maddress", this.Address),
                    new SqlParameter("@mother", this.Other),
                    new SqlParameter("@mjoin", this.JoinDate),
                    new SqlParameter("@midcard", this.IDCard)
                };
            return new SQLHelper().ExecuteSql(strSql, cmdParameter);
        }

        /// <summary>编辑会员信息。</summary>
        /// <returns></returns>
        public int UpdateMember()
        {
            string strSql = "update member set mname=@mname,mstatus=@mstatus,mcid=@mcid,mpass=@mpass,mremark=@mremark,msex=@msex,mmonth=@mmonth,mday=@mday,mphone=@mphone,maddress=@maddress,mother=@mother,midcard=@midcard where mid=@mid";
            SqlParameter[] cmdParameter =
                {
                    new SqlParameter("@mid", this.ID),
                    new SqlParameter("@mname", this.Name),
                    new SqlParameter("@mstatus", this.Status),
                    new SqlParameter("@mcid", this.CardID),
                    new SqlParameter("@mpass", this.Password),
                    new SqlParameter("@mremark", this.Remark),
                    new SqlParameter("@msex", this.Sex),
                    new SqlParameter("@mmonth", this.Month),
                    new SqlParameter("@mday", this.Day),
                    new SqlParameter("@mphone", this.Phone),
                    new SqlParameter("@maddress", this.Address),
                    new SqlParameter("@mother", this.Other),
                    new SqlParameter("@mjoin", this.JoinDate),
                    new SqlParameter("@midcard", this.IDCard)
                };
            return new SQLHelper().ExecuteSql(strSql, cmdParameter);
        }

        #endregion
    }
}

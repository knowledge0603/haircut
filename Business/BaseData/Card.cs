using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using XLuSharpLibrary.DbAccess;

namespace BHair.Business.BaseData
{
    /// <summary>会员卡类型管理。</summary>
    public class Card
    {
        #region 构造函数...

        /// <summary>会员卡类型管理。</summary>
        public Card()
        { }

        /// <summary>会员卡类型管理。</summary>
        /// <param name="cid">会员类型标识</param>
        public Card(int cid)
        {
            string strSql = "select * from card where cid=" + cid;
            DataRow objRow = StaticValue.SelectTable(strSql).Rows[0];
            this.CardId = int.Parse(objRow["cid"].ToString());
            this.CardName = objRow["cname"].ToString();
            this.Discount = double.Parse(objRow["cdiscount"].ToString());
            this.Money = decimal.Parse(objRow["cmoney"].ToString());
        }

        #endregion

        #region 属性...

        private int _CardId;

        /// <summary>获取或设置会员卡类型标识(ID)。</summary>
        public int CardId
        {
            get { return _CardId; }
            set { _CardId = value; }
        }

        private string _CardName;

        /// <summary>获取或设置会员卡类型名称。</summary>
        public string CardName
        {
            get { return _CardName; }
            set { _CardName = value; }
        }

        private double _Discount;

        /// <summary>获取或设置该类型会员卡消费折扣。</summary>
        public double Discount
        {
            get { return _Discount; }
            set { _Discount = value; }
        }

        private decimal _Money;

        /// <summary>获取或设置该类型会员卡初始金额。</summary>
        public decimal Money
        {
            get { return _Money; }
            set { _Money = value; }
        }

        private int _MemberSum;

        /// <summary>获取会员数量。</summary>
        public int MemberSum
        {
            get
            {
                _MemberSum = Member.GetMemberTotal(0, this.CardId);
                return _MemberSum;
            }
        }

        #endregion

        #region 自定义函数...
        
        /// <summary>检查会员卡类型是否存在。</summary>
        /// <param name="name">会员卡类型名称</param>
        /// <returns></returns>
        public int ExistsCardName(string name)
        {
            string strSql = "select cid from card where cname=@cname";
            DataTable objDataTable = new DataTable();
            SqlParameter[] cmdParameter = { new SqlParameter("@cname", name) };
            new SQLHelper().ExecuteSql(strSql, cmdParameter, out objDataTable);
            if (objDataTable.Rows.Count > 0)
            {
                return int.Parse(objDataTable.Rows[0]["cid"].ToString());
            }
            return 0;
        }

        /// <summary>查询会员卡类型数据。</summary>
        /// <param name="cid">会员卡标识，为0时查询所有数据</param>
        /// <returns></returns>
        public List<Card> SelectList(int cid)
        {
            string strSql = "select * from card";
            if (cid > 0)
            {
                strSql += " where cid=" + cid;
            }
            DataTable objDataTable = StaticValue.SelectTable(strSql);
            List<Card> lstCard = new List<Card>();
            foreach (DataRow row in objDataTable.Rows)
            {
                Card objCard = new Card();
                objCard.CardId = int.Parse(row["cid"].ToString());
                objCard.CardName = row["cname"].ToString();
                objCard.Discount = double.Parse(row["cdiscount"].ToString());
                objCard.Money = decimal.Parse(row["cmoney"].ToString());
                lstCard.Add(objCard);
            }
            return lstCard;
        }

        /// <summary>新增会员卡类型。</summary>
        /// <returns></returns>
        public int InsertCard()
        {
            string strSql = "insert into card(cname,cdiscount,cmoney) values(@cname,@cdiscount,@cmoney)";
            SqlParameter[] cmdParameter = { new SqlParameter("@cname", this.CardName), new SqlParameter("@cdiscount", this.Discount), new SqlParameter("@cmoney", this.Money) };
            return new SQLHelper().ExecuteSql(strSql, cmdParameter);
        }

        /// <summary>修改会员卡类型。</summary>
        /// <returns></returns>
        public int UpdateCard()
        {
            string strSql = "update card set cname=@cname,cdiscount=@cdiscount,cmoney=@cmoney where cid=@cid";
            SqlParameter[] cmdParameter = { new SqlParameter("@cname", this.CardName), new SqlParameter("@cdiscount", this.Discount), new SqlParameter("@cmoney", this.Money), new SqlParameter("@cid", this.CardId) };
            return new SQLHelper().ExecuteSql(strSql, cmdParameter);
        }

        /// <summary>删除会员卡类型。</summary>
        /// <returns></returns>
        public int DeleteCard()
        {
            string strSql = "delete from card where cid=" + this.CardId;
            return new SQLHelper().ExecuteSql(strSql);
        }

        #endregion
    }
}

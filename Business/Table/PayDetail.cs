using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using BHair.Business.BaseData;
using XLuSharpLibrary.DbAccess;

namespace BHair.Business.Table
{
    /// <summary>消费明细。</summary>
    public class PayDetail
    {
        #region 函造函数...

        /// <summary>消费明细。</summary>
        public PayDetail()
        { }

        /// <summary>消费明细。</summary>
        /// <param name="detailid">消费单号</param>
        public PayDetail(decimal detailid)
        {
            string strSql = "select * from paydetails where pdid=" + detailid;
            DataRow objRow = StaticValue.SelectTable(strSql).Rows[0];
            this.DetailID = decimal.Parse(objRow["pdid"].ToString());
            this.PayID = objRow["pdpid"].ToString();
            this.ItemID = int.Parse(objRow["pdiid"].ToString());
            this.Number = int.Parse(objRow["pdnum"].ToString());
            this.Bonus = double.Parse(objRow["pbonus"].ToString());
            this.Money = decimal.Parse(objRow["pmoney"].ToString());
        }

        #endregion

        #region 属性...

        private decimal _DetailID;

        /// <summary>获取或设置消费明细流水号。</summary>
        public decimal DetailID
        {
            get { return _DetailID; }
            set { _DetailID = value; }
        }

        private string _PayID;

        /// <summary>获取或设置消费单号。</summary>
        public string PayID
        {
            get { return _PayID; }
            set { _PayID = value; }
        }

        private int _ItemID;

        /// <summary>获取或设置消费项目(商品编号/商品ID)。</summary>
        public int ItemID
        {
            get { return _ItemID; }
            set { _ItemID = value; }
        }

        private int _Number;

        /// <summary>获取或设置消费数量。</summary>
        public int Number
        {
            get { return _Number; }
            set { _Number = value; }
        }

        private double _Bonus;

        /// <summary>获取或设置消费折扣。</summary>
        public double Bonus
        {
            get { return _Bonus; }
            set { _Bonus = value; }
        }

        private decimal _Money;

        /// <summary>获取或设置折后单价。</summary>
        public decimal Money
        {
            get { return _Money; }
            set { _Money = value; }
        }

        private SPItems _SPItem = new SPItems();

        /// <summary>获取或消费项目(商品信息)。</summary>
        public SPItems SPItem
        {
            get
            {
                if (this.ItemID > 0)
                {
                    _SPItem = new SPItems(this.ItemID);
                }
                return _SPItem;
            }
        }

        /// <summary>获取消费合计金额。</summary>
        public decimal Sum
        {
            get { return this.Number * this.Money; }
        }

        private decimal _FatPrice;

        /// <summary>获取消费成本价。</summary>
        public decimal FatPrice
        {
            get
            {
                if (this.ItemID > 0)
                {
                    _FatPrice = this.Number * this.SPItem.FatPrice;
                }
                return _FatPrice;
            }
        }

        #endregion

        #region 自定义函数...

        //public PayDetail Clone()
        //{
        //    return (PayDetail)MemberwiseClone();
        //}

        /// <summary>检查消费明细中是否存在相同商品。</summary>
        /// <param name="detailid">消费明细流水号</param>
        /// <returns></returns>
        public int ExistsPostSPItems(string payid, int itemid)
        {
            string strSql = "select * from paydetails where pdpid='" + payid + "' and pdiid=" + itemid;
            DataTable objDataTable = StaticValue.SelectTable(strSql);
            return objDataTable.Rows.Count;
        }

        /// <summary>查询消费明细</summary>
        /// <param name="payid">消费单号</param>
        /// <returns></returns>
        public static List<PayDetail> SelectList(string payid)
        {
            string strSql = "select * from paydetails where pdpid='" + payid + "'";
            DataTable objDataTable = StaticValue.SelectTable(strSql);
            List<PayDetail> lstPayDetail = new List<PayDetail>();
            foreach (DataRow objRow in objDataTable.Rows)
            {
                PayDetail objDetail = new PayDetail();
                objDetail.DetailID = decimal.Parse(objRow["pdid"].ToString());
                objDetail.PayID = objRow["pdpid"].ToString();
                objDetail.ItemID = int.Parse(objRow["pdiid"].ToString());
                objDetail.Number = int.Parse(objRow["pdnum"].ToString());
                objDetail.Bonus = double.Parse(objRow["pbonus"].ToString());
                objDetail.Money = decimal.Parse(objRow["pmoney"].ToString());
                lstPayDetail.Add(objDetail);
            }
            return lstPayDetail;
        }

        /// <summary>新增消费明细。</summary>
        /// <returns></returns>
        public int InsertDetail()
        {
            string strSql = "insert into paydetails(pdpid,pdiid,pdnum,pbonus,pmoney) values(@pdpid,@pdiid,@pdnum,@pbonus,@pmoney)";
            SqlParameter[] cmdParameter = { new SqlParameter("@pdpid", this.PayID), new SqlParameter("@pdiid", this.ItemID), new SqlParameter("@pdnum", this.Number), new SqlParameter("@pbonus", this.Bonus), new SqlParameter("@pmoney", this.Money) };
            return new SQLHelper().ExecuteSql(strSql, cmdParameter);
        }

        /// <summary>删除消费明细。</summary>
        /// <param name="detailid">消费明细流水号</param>
        /// <returns></returns>
        public int DeleteDetail(decimal detailid)
        {
            string strSql = "delete from paydetails where pdid=" + detailid;
            return new SQLHelper().ExecuteSql(strSql);
        }

        /// <summary>更新消费折扣。</summary>
        /// <returns></returns>
        public int UpdateDetailBonus()
        {
            string strSql = "update paydetails set pbonus=" + this.Bonus + ",pmoney=" + this.Money + " where pdid=" + this.DetailID;
            return new SQLHelper().ExecuteSql(strSql);
        }

        /// <summary>更新消费明细</summary>
        /// <param name="payid">消费单号</param>
        /// <param name="itemid">商品单号</param>
        /// <returns></returns>
        public int UpdateDetail(string payid, int itemid)
        {
            string strSql = "update paydetails set pdnum=@pdnum,pbonus=@pbonus,pmoney=@pmoney where pdpid=@pdpid and pdiid=@pdiid";
            SqlParameter[] cmdParameter = { new SqlParameter("@pdnum", this.Number), new SqlParameter("@pbonus", this.Bonus), new SqlParameter("@pmoney", this.Money), new SqlParameter("@pdpid", payid), new SqlParameter("@pdiid", itemid) };
            return new SQLHelper().ExecuteSql(strSql, cmdParameter);
        }

        #endregion
    }
}

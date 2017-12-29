using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using XLuSharpLibrary.DbAccess;

namespace BHair.Business.BaseData
{
    /// <summary>商品信息。</summary>
    public class SPItems
    {
        #region 构造函数...

        /// <summary>商品信息。</summary>
        public SPItems()
        { }

        /// <summary>商品信息。</summary>
        /// <param name="itemid">商品编号</param>
        public SPItems(int itemid)
        {
            string strSql = "select * from items where iid=" + itemid.ToString();
            DataTable objDataTable = StaticValue.SelectTable(strSql);
            DataRow objRow = objDataTable.Rows[0];
            this.ID = int.Parse(objRow["iid"].ToString());
            this.Name = objRow["iname"].ToString();
            this.FatPrice = decimal.Parse(objRow["ifprice"].ToString());
            this.UnitPrice = decimal.Parse(objRow["iuprice"].ToString());
            this.NumPrice = decimal.Parse(objRow["inprice"].ToString());
            this.Amount = int.Parse(objRow["iamount"].ToString());
            this.BonusMoney = decimal.Parse(objRow["imoney"].ToString());
            this.CallBonusMoney = decimal.Parse(objRow["icmoney"].ToString());
            this.Type = int.Parse(objRow["itype"].ToString());
            this.Convert = int.Parse(objRow["iconvert"].ToString());
            this.Readme = objRow["ireadme"].ToString();
            this.Status = int.Parse(objRow["istatus"].ToString());
            this.IsBonus = int.Parse(objRow["isbonus"].ToString());
        }

        #endregion

        #region 属性...

        private int _ID;

        /// <summary>获取或设置商品编号。</summary>
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _Name;

        /// <summary>获取或设置商品名称。</summary>
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private decimal _FatPrice;

        /// <summary>获取或设置商品进货(成本)单价。</summary>
        public decimal FatPrice
        {
            get { return _FatPrice; }
            set { _FatPrice = value; }
        }

        private int _Amount;

        /// <summary>获取或设置商品库存数量。</summary>
        public int Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }

        private decimal _UnitPrice;

        /// <summary>获取或设置商品预售单价。</summary>
        public decimal UnitPrice
        {
            get { return _UnitPrice; }
            set { _UnitPrice = value; }
        }

        private decimal _NumPrice;

        /// <summary>获取或设置商品预充次数单价。</summary>
        public decimal NumPrice
        {
            get { return _NumPrice; }
            set { _NumPrice = value; }
        }

        private decimal _BonusMoney;

        /// <summary>获取或设置商品提成金额。</summary>
        public decimal BonusMoney
        {
            get { return _BonusMoney; }
            set { _BonusMoney = value; }
        }

        private decimal _CallBonusMoney;

        /// <summary>获取或设置商品点牌提成金额。</summary>
        public decimal CallBonusMoney
        {
            get { return _CallBonusMoney; }
            set { _CallBonusMoney = value; }
        }

        private int _Convert;

        /// <summary>获取或设置商品可用积分。</summary>
        public int Convert
        {
            get { return _Convert; }
            set { _Convert = value; }
        }

        private string _Readme;

        /// <summary>获取或设置商品说明。</summary>
        public string Readme
        {
            get { return _Readme; }
            set { _Readme = value; }
        }

        private int _Status;

        /// <summary>获取或设置商品状态(0可用，1下架)。</summary>
        public int Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        private int _Type;

        /// <summary>获取或设置商品所属类别(0洗剪吹，1烫发，2染发，3外卖护理)。</summary>
        public int Type
        {
            get { return _Type; }
            set { _Type = value; }
        }

        private int _IsBonus;

        /// <summary>获取或设置该商品不参与打折(0否，1是)。</summary>
        public int IsBonus
        {
            get { return _IsBonus; }
            set { _IsBonus = value; }
        }

        private string _StatusText;

        /// <summary>获取或设置商品状态。</summary>
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
                    _StatusText = "下架";
                }
                return _StatusText;
            }
        }

        private string _TypeText;

        /// <summary>获取或设置商品所属类别。</summary>
        public string TypeText
        {
            get
            {
                switch (this.Type)
                {
                    case 0:
                        _TypeText = "洗剪吹";
                        break;
                    case 1:
                        _TypeText = "烫发";
                        break;
                    case 2:
                        _TypeText = "染发";
                        break;
                    case 3:
                        _TypeText = "外卖护理";
                        break;
                }
                return _TypeText;
            }
        }

        private string _IsBonusText = "是";

        /// <summary>获取商品是否打折。</summary>
        public string IsBonusText
        {
            get
            {
                if (this.IsBonus == 1)
                {
                    _IsBonusText = "否";
                }
                return _IsBonusText;
            }
        }

        #endregion

        #region 自定义函数...

        /// <summary>检查商品名称是否存在。</summary>
        /// <param name="name">商品名称</param>
        /// <returns></returns>
        public int ExistsPostName(string name)
        {
            string strSql = "select * from items where iname='" + name + "'";
            DataTable objDataTable = StaticValue.SelectTable(strSql);
            if (objDataTable.Rows.Count > 0)
            {
                return int.Parse(objDataTable.Rows[0]["iid"].ToString());
            }
            return 0;
        }

        /// <summary>查询商品信息</summary>
        /// <param name="type">商品类型(0为所有类型)</param>
        /// <param name="text"></param>
        /// <param name="status">商品状态(0为所有状态)</param>
        /// <returns></returns>
        public List<SPItems> SelectList(int type, string text, int status)
        {
            string strSql = "select * from items where 1=1";
            if (type > 0)
            {
                strSql += " and itype=" + (type - 1).ToString();
            }
            if (text != "")
            {
                strSql += "and (iid like '%" + text + "%' or iname like '%" + text + "%')";
            }
            if (status > 0)
            {
                strSql += " and istatus=" + (status - 1).ToString();
            }
            DataTable objDataTable = StaticValue.SelectTable(strSql);
            List<SPItems> lstItems = new List<SPItems>();
            foreach (DataRow objRow in objDataTable.Rows)
            {
                SPItems objItem = new SPItems();
                objItem.ID = int.Parse(objRow["iid"].ToString());
                objItem.Name = objRow["iname"].ToString();
                objItem.FatPrice = decimal.Parse(objRow["ifprice"].ToString());
                objItem.UnitPrice = decimal.Parse(objRow["iuprice"].ToString());
                objItem.NumPrice = decimal.Parse(objRow["inprice"].ToString());
                objItem.Amount = int.Parse(objRow["iamount"].ToString());
                objItem.BonusMoney = decimal.Parse(objRow["imoney"].ToString());
                objItem.CallBonusMoney = decimal.Parse(objRow["icmoney"].ToString());
                objItem.Type = int.Parse(objRow["itype"].ToString());
                objItem.Convert = int.Parse(objRow["iconvert"].ToString());
                objItem.Readme = objRow["ireadme"].ToString();
                objItem.Status = int.Parse(objRow["istatus"].ToString());
                objItem.IsBonus = int.Parse(objRow["isbonus"].ToString());
                lstItems.Add(objItem);
            }
            return lstItems;
        }

        /// <summary>新增商品信息。</summary>
        /// <returns></returns>
        public int InsertSPItems()
        {
            string strSql = "insert into items(iname,ifprice,iuprice,inprice,iamount,imoney,icmoney,itype,iconvert,ireadme,istatus,isbonus) values(@iname,@ifprice,@iuprice,@inprice,@iamount,@imoney,@icmoney,@itype,@iconvert,@ireadme,@istatus,@isbonus)";
            SqlParameter[] cmdParameter = { new SqlParameter("@iname", this.Name), new SqlParameter("@ifprice", this.FatPrice), new SqlParameter("@iuprice", this.UnitPrice), new SqlParameter("@inprice", this.NumPrice), new SqlParameter("@iamount", this.Amount), new SqlParameter("@imoney", this.BonusMoney), new SqlParameter("@icmoney", this.CallBonusMoney), new SqlParameter("@itype", this.Type), new SqlParameter("@iconvert", this.Convert), new SqlParameter("@ireadme", this.Readme), new SqlParameter("@istatus", this.Status), new SqlParameter("@isbonus", this.IsBonus) };
            return new SQLHelper().ExecuteSql(strSql, cmdParameter);
        }

        /// <summary>修改商品信息。</summary>
        /// <returns></returns>
        public int UpdateSPItems()
        {
            string strSql = "update items set iname=@iname,ifprice=@ifprice,iuprice=@iuprice,inprice=@inprice,iamount=@iamount,imoney=@imoney,icmoney=@icmoney,itype=@itype,iconvert=@iconvert,ireadme=@ireadme,istatus=@istatus,isbonus=@isbonus where iid=@iid";
            SqlParameter[] cmdParameter = { new SqlParameter("@iname", this.Name), new SqlParameter("@ifprice", this.FatPrice), new SqlParameter("@iuprice", this.UnitPrice), new SqlParameter("@inprice", this.NumPrice), new SqlParameter("@iamount", this.Amount), new SqlParameter("@imoney", this.BonusMoney), new SqlParameter("@icmoney", this.CallBonusMoney), new SqlParameter("@itype", this.Type), new SqlParameter("@iconvert", this.Convert), new SqlParameter("@ireadme", this.Readme), new SqlParameter("@istatus", this.Status), new SqlParameter("@isbonus", this.IsBonus), new SqlParameter("@iid", this.ID) };
            return new SQLHelper().ExecuteSql(strSql, cmdParameter);
        }

        /// <summary>商品下(上)架</summary>
        /// <returns></returns>
        public int DownSPItems()
        {
            string strSql = "update items set istatus=@istatus where iid=@iid";
            SqlParameter[] cmdParameter = { new SqlParameter("@istatus", this.Status), new SqlParameter("@iid", this.ID) };
            return new SQLHelper().ExecuteSql(strSql, cmdParameter);
        }

        #endregion
    }
}

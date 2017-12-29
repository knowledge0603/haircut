using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using XLuSharpLibrary.DbAccess;

namespace BHair.Business
{
    /// <summary>系统参数设置。</summary>
    public class SystemConfig
    {
        private List<SystemConfig> DefaultConfig;

        #region 构造函数...

        /// <summary>系统参数设置。</summary>
        public SystemConfig()
        { }

        /// <summary>系统参数设置。</summary>
        public SystemConfig(int index)
        {
            this.Initialize();
            this.VarIndex = index;
            this.VarName = this.DefaultConfig[index].VarName;
            this.VarType = this.DefaultConfig[index].VarType;
            this.VarValue = this.DefaultConfig[index].VarValue;
            this.VarInfo = this.DefaultConfig[index].VarInfo;
        }

        /// <summary>系统参数设置。</summary>
        /// <param name="varname">参数名</param>
        public SystemConfig(int index, string varname)
        {
            if (!this.IsExist(varname))
            {
                this.Initialize();
                this.Insert(index);
            }
            string strSql = "select * from sysconfig where varname='" + varname + "'";
            DataRow objRow = StaticValue.SelectTable(strSql).Rows[0];
            this.VarIndex = int.Parse(objRow["varindex"].ToString());
            this.VarName = objRow["varname"].ToString();
            this.VarType = objRow["vartype"].ToString();
            this.VarValue = objRow["varvalue"].ToString();
            this.VarInfo = objRow["varinfo"].ToString();
        }

        /// <summary>系统参数设置。</summary>
        /// <param name="varname">参数名</param>
        /// <param name="vartype"></param>
        /// <param name="varvalue"></param>
        /// <param name="varinfo"></param>
        public SystemConfig(string varname, string vartype, string varvalue, string varinfo)
        {
            this.VarName = varname;
            this.VarType = vartype;
            this.VarValue = varvalue;
            this.VarInfo = varinfo;
        }

        #endregion

        #region 属性...

        private int _VarIndex;

        /// <summary>获取或设置参数索引。</summary>
        public int VarIndex
        {
            get { return _VarIndex; }
            set { _VarIndex = value; }
        }

        private string _VarName;

        /// <summary>获取或设置参数名。</summary>
        public string VarName
        {
            get { return _VarName; }
            set { _VarName = value; }
        }

        private string _VarType;

        /// <summary>获取或设置参数值类型。</summary>
        public string VarType
        {
            get { return _VarType; }
            set { _VarType = value; }
        }

        private string _VarValue;

        /// <summary>获取或设置参数值。</summary>
        public string VarValue
        {
            get { return _VarValue; }
            set { _VarValue = value; }
        }

        private string _VarInfo;

        /// <summary>获取或设置参数描述</summary>
        public string VarInfo
        {
            get { return _VarInfo; }
            set { _VarInfo = value; }
        }

        #endregion

        #region 自定义函数...

        /// <summary>初始化默认数据。</summary>
        private void Initialize()
        {
            DefaultConfig = new List<SystemConfig>();
            DefaultConfig.Add(new SystemConfig("cfg_deposit_money", "money", "100", "充值基数金额，最小100元"));//0
            DefaultConfig.Add(new SystemConfig("cfg_deposit_send", "money", "0", "充值增送金额，权限大于有效时间"));//1
            DefaultConfig.Add(new SystemConfig("cfg_deposit_start", "datetime", DateTime.Now.ToShortDateString() + " 00:00:00", "充值增送开始时间"));//2
            DefaultConfig.Add(new SystemConfig("cfg_deposit_finish", "datetime", DateTime.Now.ToShortDateString() + " 23:59:59", "充值增送结束时间"));//3
        }

        /// <summary>参数不存在时执行新增</summary>
        /// <param name="index">索引</param>
        /// <returns></returns>
        private int Insert(int index)
        {
            SystemConfig objConfig = new SystemConfig(index);
            string strSql = "insert sysconfig values(@varindex,@varname,@vartype,@varvalue,@varinfo)";
            SqlParameter[] cmdParameter = { new SqlParameter("@varindex", objConfig.VarIndex), new SqlParameter("@varname", objConfig.VarName), new SqlParameter("@vartype", objConfig.VarType), new SqlParameter("@varvalue", objConfig.VarValue), new SqlParameter("@varinfo", objConfig.VarInfo) };
            return new SQLHelper().ExecuteSql(strSql, cmdParameter);
        }

        /// <summary>检查参数是否存在</summary>
        /// <param name="varname">参数名</param>
        /// <returns></returns>
        private bool IsExist(string varname)
        {
            string strSql = "select * from sysconfig where varname='" + varname + "'";
            int iCount = StaticValue.SelectTable(strSql).Rows.Count;
            if (iCount == 0)
            {
                return false;//不存在
            }
            return true;//存在
        }

        /// <summary>更新参数值</summary>
        /// <returns></returns>
        public int UpdateValue()
        {
            string strSql = "update sysconfig set varvalue=@varvalue where varname=@varname";
            SqlParameter[] cmdParameter = { new SqlParameter("@varvalue", this.VarValue), new SqlParameter("@varname", this.VarName) };
            return new SQLHelper().ExecuteSql(strSql, cmdParameter);
        }

        /// <summary>获取一个布尔值，判断是否执行充值送金额。</summary>
        /// <param name="datetime"></param>
        /// <returns></returns>
        public static bool GetIsDeposit()
        {
            DateTime dtNow = DateTime.Now;
            decimal iSendMoney = decimal.Parse(new SystemConfig(1, "cfg_deposit_send").VarValue);
            DateTime dtStart = DateTime.Parse(new SystemConfig(2, "cfg_deposit_start").VarValue);
            DateTime dtFinish = DateTime.Parse(new SystemConfig(3, "cfg_deposit_finish").VarValue);
            if (dtNow > dtStart && dtNow < dtFinish && iSendMoney > 0)
            {
                return true;
            }
            return false;
        }

        #endregion
    }
}

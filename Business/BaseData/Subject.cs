using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using XLuSharpLibrary.DbAccess;

namespace BHair.Business.BaseData
{
    /// <summary>科目管理。</summary>
    public class Subject
    {
        #region 构造函数...

        /// <summary>科目管理。</summary>
        public Subject()
        { }

        /// <summary>科目管理。</summary>
        /// <param name="subId">科目标识(ID)</param>
        public Subject(int subId)
        {
            string strSql = "select * from subject where sid=" + subId;
            DataRow objRow = StaticValue.SelectTable(strSql).Rows[0];
            this.ID = int.Parse(objRow["sid"].ToString());
            this.Name = objRow["sname"].ToString();
            this.Type = int.Parse(objRow["stype"].ToString());
            this.Readme = objRow["sreadme"].ToString();
            this.IsEnabled = int.Parse(objRow["senabled"].ToString());
        }

        #endregion

        #region 属性...

        private int _ID;

        /// <summary>获取或设置科目标识(ID)。</summary>
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _Name;

        /// <summary>获取或设置科目名称。</summary>
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private int _Type;

        /// <summary>获取或设置科目收支类型(1为收入，0为支出)。</summary>
        public int Type
        {
            get { return _Type; }
            set { _Type = value; }
        }

        private string _TypeText;

        /// <summary>获取科目收支类型。</summary>
        public string TypeText
        {
            get
            {
                if (this.Type == 0)
                {
                    _TypeText = "支出";
                }
                else
                {
                    _TypeText = "收入";
                }
                return _TypeText;
            }
        }

        private string _Readme;

        /// <summary>获取或设置科目说明。</summary>
        public string Readme
        {
            get { return _Readme; }
            set { _Readme = value; }
        }

        private int _IsEnabled;

        /// <summary>获取或设置收支科目禁用状态(0启用，1禁用)。</summary>
        public int IsEnabled
        {
            get { return _IsEnabled; }
            set { _IsEnabled = value; }
        }

        private string _EnabledText;

        /// <summary>获取或设置收支科目禁用状态(0启用，1禁用)。</summary>
        public string EnabledText
        {
            get
            {
                if (this.IsEnabled == 0)
                {
                    _EnabledText = "启用";
                }
                else
                {
                    _EnabledText = "禁用";
                }
                return _EnabledText;
            }
        }

        #endregion

        #region 自定义函数...

        /// <summary>检查科目名称是否存在。</summary>
        /// <param name="name">科目名称</param>
        /// <returns></returns>
        public int ExistsSubjectName(string name)
        {
            string strSql = "select * from subject where sname='" + name + "'";
            DataTable objDataTable = StaticValue.SelectTable(strSql);
            if (objDataTable.Rows.Count > 0)
            {
                return int.Parse(objDataTable.Rows[0]["sid"].ToString());
            }
            return 0;
        }

        /// <summary>添加科目信息。</summary>
        /// <returns></returns>
        public int InsertSubject()
        {
            string strSql = "insert into subject(sname,stype,sreadme,senabled) values(@sname,@stype,@sreadme,0)";
            SqlParameter[] cmdParameter = { new SqlParameter("@sname", this.Name), new SqlParameter("@stype", this.Type), new SqlParameter("@sreadme", this.Readme) };
            return new SQLHelper().ExecuteSql(strSql, cmdParameter);
        }

        /// <summary>修改科目信息。</summary>
        /// <returns></returns>
        public int UpdateSubject()
        {
            string strSql = "update subject set sname=@sname,stype=@stype,sreadme=@sreadme where sid=@sid";
            SqlParameter[] cmdParameter = { new SqlParameter("@sname", this.Name), new SqlParameter("@stype", this.Type), new SqlParameter("@sreadme", this.Readme), new SqlParameter("@sid", this.ID) };
            return new SQLHelper().ExecuteSql(strSql, cmdParameter);
        }

        /// <summary>更新科目状态。</summary>
        /// <returns></returns>
        public int UpdateStatus()
        {
            string strSql = "update subject set senabled=@senabled where sid=@sid";
            SqlParameter[] cmdParameter = { new SqlParameter("@senabled", this.IsEnabled), new SqlParameter("@sid", this.ID) };
            return new SQLHelper().ExecuteSql(strSql, cmdParameter);
        }

        /// <summary>查询科目信息。</summary>
        /// <param name="type">收支类型</param>
        /// <param name="status"></param>
        /// <returns></returns>
        public List<Subject> SelectList(int type, int status)
        {
            string strSql = "select * from subject where senabled=" + status;
            if (type > 0)
            {
                strSql += " and stype=" + (type - 1).ToString();
            }
            strSql += " order by stype";
            DataTable objDataTable = StaticValue.SelectTable(strSql);
            List<Subject> lstSubject = new List<Subject>();
            foreach (DataRow row in objDataTable.Rows)
            {
                Subject objSubject = new Subject();
                objSubject.ID = int.Parse(row["sid"].ToString());
                objSubject.Name = row["sname"].ToString();
                objSubject.Type = int.Parse(row["stype"].ToString());
                objSubject.Readme = row["sreadme"].ToString();
                objSubject.IsEnabled = int.Parse(row["senabled"].ToString());
                lstSubject.Add(objSubject);
            }
            return lstSubject;
        }

        #endregion
    }
}

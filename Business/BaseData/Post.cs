using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using XLuSharpLibrary.DbAccess;

namespace BHair.Business.BaseData
{
    /// <summary>职位信息管理。</summary>
    public class Post
    {
        #region 构造函数...

        /// <summary>职位信息管理。</summary>
        public Post()
        { }

        /// <summary>职位信息管理。</summary>
        /// <param name="pid">职位标识(ID)</param>
        public Post(int pid)
        {
            string strSql = "select * from post where pid=" + pid;
            DataRow objRow = StaticValue.SelectTable(strSql).Rows[0];
            this.ID = int.Parse(objRow["pid"].ToString());
            this.Name = objRow["pname"].ToString();
            this.Readme = objRow["preadme"].ToString();
            this.Mode = int.Parse(objRow["pmode"].ToString());
            this.Sort = int.Parse(objRow["psort"].ToString());
            this.Salary = decimal.Parse(objRow["psalary"].ToString());
            this.Bonus = double.Parse(objRow["pbonus"].ToString());
        }

        #endregion

        #region 属性...

        private int _ID;

        /// <summary>获取或设置职位标识(ID)。</summary>
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _Name;

        /// <summary>获取或设置职位名称。</summary>
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private string _Readme;

        /// <summary>获取或设置职位描述。</summary>
        public string Readme
        {
            get { return _Readme; }
            set { _Readme = value; }
        }

        private int _Sort;

        /// <summary>获取或设置职位排序(数字越小越靠前)。</summary>
        public int Sort
        {
            get { return _Sort; }
            set { _Sort = value; }
        }

        private decimal _Salary;

        /// <summary>获取或设置职位底薪。</summary>
        public decimal Salary
        {
            get { return _Salary; }
            set { _Salary = value; }
        }

        private double _Bonus;

        /// <summary>获取或设置职位提成比例。</summary>
        public double Bonus
        {
            get { return _Bonus; }
            set { _Bonus = value; }
        }

        private int _Mode;

        /// <summary>获取或设置职位薪资结算方式。</summary>
        public int Mode
        {
            get { return _Mode; }
            set { _Mode = value; }
        }

        private string _ModeText;

        /// <summary>获取职位薪资结算方式。</summary>
        public string ModeText
        {
            get
            {
                switch (this.Mode)
                {
                    case 0:
                        _ModeText = "底薪";
                        break;
                    case 1:
                        _ModeText = "提成";
                        break;
                    case 2:
                        _ModeText = "底薪+提成";
                        break;
                }
                return _ModeText;
            }
        }

        #endregion

        #region 自定义函数...

        /// <summary>检查职位名称是否存在。</summary>
        /// <param name="name">职位名称</param>
        /// <returns></returns>
        public int ExistsPostName(string name)
        {
            string strSql = "select * from post where pname='" + name + "'";
            DataTable objDataTable = StaticValue.SelectTable(strSql);
            if (objDataTable.Rows.Count > 0)
            {
                return int.Parse(objDataTable.Rows[0]["pid"].ToString());
            }
            return 0;
        }

        /// <summary>查询所有职位信息。</summary>
        /// <returns></returns>
        public List<Post> SelectList()
        {
            string strSql = "select * from post order by psort";
            DataTable objDataTable = new DataTable();
            new SQLHelper().ExecuteSql(strSql, out objDataTable);
            List<Post> lstPost = new List<Post>();
            foreach (DataRow objRow in objDataTable.Rows)
            {
                Post objPost = new Post();
                objPost.ID = int.Parse(objRow["pid"].ToString());
                objPost.Name = objRow["pname"].ToString();
                objPost.Readme = objRow["preadme"].ToString();
                objPost.Mode = int.Parse(objRow["pmode"].ToString());
                objPost.Sort = int.Parse(objRow["psort"].ToString());
                objPost.Salary = decimal.Parse(objRow["psalary"].ToString());
                objPost.Bonus = double.Parse(objRow["pbonus"].ToString());
                lstPost.Add(objPost);
            }
            return lstPost;
        }

        /// <summary>新增职位信息。</summary>
        /// <returns></returns>
        public int InsertPost()
        {
            string strSql = "insert into post(pname,pbonus,preadme,psort,psalary,pmode) values(@pname,@pbonus,@preadme,@psort,@psalary,@pmode)";
            SqlParameter[] cmdParameter = { new SqlParameter("@pname", this.Name), new SqlParameter("@pbonus", this.Bonus), new SqlParameter("@preadme", this.Readme), new SqlParameter("@psort", this.Sort), new SqlParameter("@psalary", this.Salary), new SqlParameter("@pmode", this.Mode) };
            return new SQLHelper().ExecuteSql(strSql, cmdParameter);
        }

        /// <summary>修改职位信息。</summary>
        /// <returns></returns>
        public int UpdatePost()
        {
            string strSql = "update post set pname=@pname,pbonus=@pbonus,preadme=@preadme,psort=@psort,psalary=@psalary,pmode=@pmode where pid=@pid";
            SqlParameter[] cmdParameter = { new SqlParameter("@pname", this.Name), new SqlParameter("@pbonus", this.Bonus), new SqlParameter("@preadme", this.Readme), new SqlParameter("@psort", this.Sort), new SqlParameter("@psalary", this.Salary), new SqlParameter("@pmode", this.Mode), new SqlParameter("@pid", this.ID) };
            return new SQLHelper().ExecuteSql(strSql, cmdParameter);
        }

        /// <summary>删除职位信息。</summary>
        /// <param name="postid">职位编号</param>
        /// <returns></returns>
        public int DeletePost(int postid)
        {
            string strSql = "delete from post where pid=" + postid;
            return new SQLHelper().ExecuteSql(strSql);
        }

        /// <summary>获取员工数量</summary>
        /// <param name="postid">职位编号</param>
        /// <returns></returns>
        public int GetEmployeeNumber(int postid)
        {
            string strSql = "select count(*) from employee where epid=" + postid;
            DataTable objDataTable = StaticValue.SelectTable(strSql);
            int iCount = int.Parse(objDataTable.Rows[0][0].ToString());
            return iCount;
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using XLuSharpLibrary.DbAccess;

namespace BHair.Business.BaseData
{
    /// <summary>员工信息管理。</summary>
    public class Employee
    {
        #region 构造函数...

        /// <summary>员工信息管理。</summary>
        public Employee()
        { }

        /// <summary>员工信息管理。</summary>
        /// <param name="empid">员工编号(ID)</param>
        public Employee(int empid)
        {
            string strSql = "select * from employee where eid=" + empid;
            DataRow objRow = StaticValue.SelectTable(strSql).Rows[0];
            this.ID = int.Parse(objRow["eid"].ToString());
            this.Code = int.Parse(objRow["ecode"].ToString());
            this.Name = objRow["ename"].ToString();
            this.Sex = int.Parse(objRow["esex"].ToString());
            this.Phone = objRow["ephone"].ToString();
            this.PostId = int.Parse(objRow["epid"].ToString());
            this.Salary = decimal.Parse(objRow["esalary"].ToString());
            this.Bonus = double.Parse(objRow["ebonus"].ToString());
            this.Input = objRow["einput"].ToString();
            this.Output = objRow["eoutput"].ToString();
            this.Status = int.Parse(objRow["estatus"].ToString());
            this.Password = objRow["epassword"].ToString();
            this.Remark = objRow["eremark"].ToString();
            this.Address = objRow["eaddress"].ToString();
            this.CardNumber = objRow["ecard"].ToString();
            this.Mobile = objRow["emobile"].ToString();
        }

        #endregion

        #region 属性...

        private int _ID;

        /// <summary>获取或设置员工编号(ID)。</summary>
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private int _Code;

        /// <summary>获取或设置员工工作编号。</summary>
        public int Code
        {
            get { return _Code; }
            set { _Code = value; }
        }

        private string _Name;

        /// <summary>获取或设置员工姓名。</summary>
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private int _Sex;

        /// <summary>获取或设置员工性别。</summary>
        public int Sex
        {
            get { return _Sex; }
            set { _Sex = value; }
        }

        private string _Phone;

        /// <summary>获取或设置员工联系电话。</summary>
        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }

        private int _PostId;

        /// <summary>获取或设置员工职位编号。</summary>
        public int PostId
        {
            get { return _PostId; }
            set { _PostId = value; }
        }
        private decimal _Salary;

        /// <summary>获取或设置员工底薪。</summary>
        public decimal Salary
        {
            get { return _Salary; }
            set { _Salary = value; }
        }

        private double _Bonus;

        /// <summary>获取或设置员工提成</summary>
        public double Bonus
        {
            get { return _Bonus; }
            set { _Bonus = value; }
        }

        private string _Input;

        /// <summary>获取或设置入职日期。</summary>
        public string Input
        {
            get { return _Input; }
            set { _Input = value; }
        }

        private string _Output;

        /// <summary>获取或设置离职日期。</summary>
        public string Output
        {
            get { return _Output; }
            set { _Output = value; }
        }

        private int _Status;

        /// <summary>获取或设置员工状态。</summary>
        public int Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        private string _Password;

        /// <summary>获取或设置员工登录密码。</summary>
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        private string _Remark;

        /// <summary>获取或设置员工备注。</summary>
        public string Remark
        {
            get { return _Remark; }
            set { _Remark = value; }
        }

        private string _Address;

        /// <summary>获取或设置员工联系地址。</summary>
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        private string _CardNumber;

        /// <summary>获取或设置员工身份证号码。</summary>
        public string CardNumber
        {
            get { return _CardNumber; }
            set { _CardNumber = value; }
        }

        private string _Mobile;

        /// <summary>获取或设置员工手机。</summary>
        public string Mobile
        {
            get { return _Mobile; }
            set { _Mobile = value; }
        }

        private string _SexText;

        /// <summary>获取员工性别。</summary>
        public string SexText
        {
            get
            {
                if (this.Sex == 1)
                {
                    _SexText = "女";
                }
                else
                {
                    _SexText = "男";
                }
                return _SexText;
            }
        }

        private string _StatusText;

        /// <summary>获取员工状态。</summary>
        public string StatusText
        {
            get
            {
                switch (this.Status)
                {
                    case 0:
                        _StatusText = "试用";
                        break;
                    case 1:
                        _StatusText = "学员";
                        break;
                    case 2:
                        _StatusText = "正式";
                        break;
                    case 3:
                        _StatusText = "离职";
                        break;
                }
                return _StatusText;
            }
        }

        private Post _Post;

        /// <summary>获取员工职位信息。</summary>
        public Post Post
        {
            get
            {
                if (this.PostId > 0)
                {
                    _Post = new Post(this.PostId);
                }
                return _Post;
            }
        }

        #endregion

        #region 自定义函数...

        /// <summary>检查员工工号是否存在(除离职外)。</summary>
        /// <param name="code">工号</param>
        /// <returns>员工ID</returns>
        public int ExistsEmployeeCode(int code)
        {
            string strSql = "select * from employee where estatus<>3 and ecode=" + code;
            DataTable objDataTable = StaticValue.SelectTable(strSql);
            if (objDataTable.Rows.Count > 0)
            {
                return int.Parse(objDataTable.Rows[0]["eid"].ToString());
            }
            return 0;
        }

        /// <summary>查询员工信息。</summary>
        /// <param name="postId">职位编号</param>
        /// <param name="i">状态(1为在职，0为所有)</param>
        /// <returns></returns>
        public List<Employee> SelectList(int postId, int i)
        {
            string strSql = "select * from employee where 1=1";
            if (postId > 0)
            {
                strSql += "and epid=" + postId;
            }
            if (i == 1)
            {
                strSql += " and estatus<>3";
            }
            strSql += " order by epid";
            DataTable objTable = StaticValue.SelectTable(strSql);
            List<Employee> lstEmp = new List<Employee>();
            foreach (DataRow objRow in objTable.Rows)
            {
                Employee objEmp = new Employee();
                objEmp.ID = int.Parse(objRow["eid"].ToString());
                objEmp.Code = int.Parse(objRow["ecode"].ToString());
                objEmp.Name = objRow["ename"].ToString();
                objEmp.Sex = int.Parse(objRow["esex"].ToString());
                objEmp.Phone = objRow["ephone"].ToString();
                objEmp.PostId = int.Parse(objRow["epid"].ToString());
                objEmp.Salary = decimal.Parse(objRow["esalary"].ToString());
                objEmp.Bonus = double.Parse(objRow["ebonus"].ToString());
                objEmp.Input = objRow["einput"].ToString();
                objEmp.Output = objRow["eoutput"].ToString();
                objEmp.Status = int.Parse(objRow["estatus"].ToString());
                objEmp.Password = objRow["epassword"].ToString();
                objEmp.Remark = objRow["eremark"].ToString();
                objEmp.Address = objRow["eaddress"].ToString();
                objEmp.CardNumber = objRow["ecard"].ToString();
                objEmp.Mobile = objRow["emobile"].ToString();
                lstEmp.Add(objEmp);
            }
            return lstEmp;
        }

        /// <summary>新增员工信息。</summary>
        /// <returns></returns>
        public int InsertEmployee()
        {
            string strSql = "insert into employee(ecode,ename,esex,ephone,epid,esalary,ebonus,einput,estatus,eremark,eaddress,ecard,emobile) values(@ecode,@ename,@esex,@ephone,@epid,@esalary,@ebonus,@einput,@estatus,@eremark,@eaddress,@ecard,@emobile)";
            SqlParameter[] cmdParameter = { new SqlParameter("@ecode", this.Code), new SqlParameter("@ename", this.Name), new SqlParameter("@esex", this.Sex), new SqlParameter("@ephone", this.Phone), new SqlParameter("@epid", this.PostId), new SqlParameter("@esalary", this.Salary), new SqlParameter("@ebonus", this.Bonus), new SqlParameter("@einput", this.Input), new SqlParameter("@estatus", this.Status), new SqlParameter("@eremark", this.Remark), new SqlParameter("@eaddress", this.Address), new SqlParameter("@ecard", this.CardNumber), new SqlParameter("@emobile", this.Mobile) };
            return new SQLHelper().ExecuteSql(strSql, cmdParameter);
        }

        /// <summary>更新员工信息。</summary>
        /// <returns></returns>
        public int UpdateEmployee()
        {
            string strSql = "update employee set ecode=@ecode,ename=@ename,esex=@esex,ephone=@ephone,epid=@epid,esalary=@esalary,ebonus=@ebonus,einput=@einput,eoutput=@eoutput,estatus=@estatus,eremark=@eremark,eaddress=@eaddress,ecard=@ecard,emobile=@emobile where eid=@eid";
            SqlParameter[] cmdParameter = { new SqlParameter("@ecode", this.Code), new SqlParameter("@ename", this.Name), new SqlParameter("@esex", this.Sex), new SqlParameter("@ephone", this.Phone), new SqlParameter("@epid", this.PostId), new SqlParameter("@esalary", this.Salary), new SqlParameter("@ebonus", this.Bonus), new SqlParameter("@einput", this.Input), new SqlParameter("@eoutput", this.Output), new SqlParameter("@estatus", this.Status), new SqlParameter("@eremark", this.Remark), new SqlParameter("@eaddress", this.Address), new SqlParameter("@ecard", this.CardNumber), new SqlParameter("@emobile", this.Mobile), new SqlParameter("@eid", this.ID) };
            return new SQLHelper().ExecuteSql(strSql, cmdParameter);
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using XLuSharpLibrary.DbAccess;
using BHair.Business.BaseData;

namespace BHair.Business.Table
{
    /// <summary>员工奖扣款记录。</summary>
    public class EmpMoney
    {
        SQLHelper objSQLHelper = new SQLHelper();

        #region 构造函数...

        /// <summary>员工奖扣款记录。</summary>
        public EmpMoney()
        { }

        /// <summary>员工奖扣款记录。</summary>
        public EmpMoney(decimal id)
        {
            string strSql = "select* from emp_money where emid=" + id;
            DataRow objRow = StaticValue.SelectTable(strSql).Rows[0];
            this.ID = decimal.Parse(objRow["emid"].ToString());
            this.Money = decimal.Parse(objRow["emmoney"].ToString());
            this.Type = int.Parse(objRow["emtype"].ToString());
            this.Remark = objRow["emremark"].ToString();
            this.Date = DateTime.Parse(objRow["emtime"].ToString());
            this.EmpId = int.Parse(objRow["empid"].ToString());
        }

        #endregion

        #region 属性...

        private decimal _ID;

        /// <summary>获取或设置奖扣款编号ID(流水号)。</summary>
        public decimal ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private decimal _Money;

        /// <summary>获取或设置奖扣款金额。</summary>
        public decimal Money
        {
            get { return _Money; }
            set { _Money = value; }
        }

        private int _Type;

        /// <summary>获取或设置奖/扣类型(0扣，1奖)。</summary>
        public int Type
        {
            get { return _Type; }
            set { _Type = value; }
        }

        private string _TypeText;

        public string TypeText
        {
            get
            {
                if (this.Type == 1)
                {
                    _TypeText = "奖";
                }
                else
                {
                    _TypeText = "扣";
                }
                return _TypeText;
            }
        }

        private string _Remark;

        /// <summary>获取或设置奖扣款原由。</summary>
        public string Remark
        {
            get { return _Remark; }
            set { _Remark = value; }
        }

        private DateTime _Date = DateTime.Now;

        /// <summary>获取或设置奖扣款日期。</summary>
        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }

        private int _EmpId;

        /// <summary>获取或设置员工编号ID。</summary>
        public int EmpId
        {
            get { return _EmpId; }
            set { _EmpId = value; }
        }

        #endregion

        #region 自定义函数...

        public int Insert()
        {
            string strSql = "insert into emp_money(emmoney,emtype,emremark,emtime,empid) values(@emmoney,@emtype,@emremark,@emtime,@empid)";
            SqlParameter[] cmdParameter = { new SqlParameter("@emmoney", this.Money), new SqlParameter("@emtype", this.Type), new SqlParameter("@emremark", this.Remark), new SqlParameter("@emtime", this.Date), new SqlParameter("@empid", this.EmpId) };
            return this.objSQLHelper.ExecuteSql(strSql, cmdParameter);
        }

        public List<EmpMoney> SelectList(int empid, int year, int month)
        {
            string strSql = "select * from emp_money where empid=" + empid + " and datepart(year,emtime)=" + year + " and datepart(month,emtime)=" + month;
            DataTable objDataTable = StaticValue.SelectTable(strSql);
            List<EmpMoney> lstEmpMoney = new List<EmpMoney>();
            foreach (DataRow objRow in objDataTable.Rows)
            {
                EmpMoney objEmpMoney = new EmpMoney();
                objEmpMoney.ID = decimal.Parse(objRow["emid"].ToString());
                objEmpMoney.Money = decimal.Parse(objRow["emmoney"].ToString());
                objEmpMoney.Type = int.Parse(objRow["emtype"].ToString());
                objEmpMoney.Remark = objRow["emremark"].ToString();
                objEmpMoney.Date = DateTime.Parse(objRow["emtime"].ToString());
                objEmpMoney.EmpId = int.Parse(objRow["empid"].ToString());
                lstEmpMoney.Add(objEmpMoney);
            }
            return lstEmpMoney;
        }

        /// <summary>获取员工奖/扣金额</summary>
        /// <param name="empid"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="type">类型（0扣，1奖）</param>
        /// <returns></returns>
        public decimal GetMoney(int empid, int year, int month, int type)
        {
            string strSql = "select sum(emmoney) from emp_money where empid=" + empid + " and emtype=" + type + " and datepart(year,emtime)=" + year + " and datepart(month,emtime)=" + month;
            try
            {
                return decimal.Parse(StaticValue.SelectTable(strSql).Rows[0][0].ToString());
            }
            catch { }
            return 0;
        }

        public int Update()
        {
            string strSql = "update emp_money set emmoney=@emmoney,emtype=@emtype,emremark=@emremark,@emtime=@emtime,empid=@empid where emid=@id";
            SqlParameter[] cmdParameter = { new SqlParameter("@emmoney", this.Money), new SqlParameter("@emtype", this.Type), new SqlParameter("@emremark", this.Remark), new SqlParameter("@emtime", this.Date), new SqlParameter("@empid", this.EmpId), new SqlParameter("@id", this.ID) };
            return this.objSQLHelper.ExecuteSql(strSql, cmdParameter);
        }

        public int Delete(decimal id)
        {
            string strSql = "delete from emp_money where emid=" + id;
            return this.objSQLHelper.ExecuteSql(strSql);
        }

        /// <summary>获取员工信息</summary>
        /// <param name="empid">员工编号ID</param>
        /// <returns></returns>
        public Employee GetEmployeeInfo()
        {
            Employee objEmp = new Employee();
            if (this.EmpId > 0)
            {
                objEmp = new Employee(this.EmpId);
            }
            return objEmp;
        }

        #endregion
    }
}

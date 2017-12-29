using System;
using System.Collections.Generic;
using System.Text;
using BHair.Business.BaseData;

namespace BHair.Business.Table
{
    /// <summary>员工工资统计。</summary>
    public class SalaryTable
    {
        #region 构造函数...

        public SalaryTable()
        { }

        #endregion

        #region 属性...

        private string _WorkNumber;

        /// <summary>获取或设置员工工号。</summary>
        public string WorkNumber
        {
            get { return _WorkNumber; }
            set { _WorkNumber = value; }
        }

        private string _Name;

        /// <summary>获取或设置员工姓名。</summary>
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private string _PostName;

        /// <summary>获取或设置员工职位。</summary>
        public string PostName
        {
            get { return _PostName; }
            set { _PostName = value; }
        }

        private decimal _MonthTotal;

        /// <summary>获取或设置员工每月业绩。</summary>
        public decimal MonthTotal
        {
            get { return _MonthTotal; }
            set { _MonthTotal = value; }
        }

        private decimal _Salary;

        /// <summary>获取或设置员工底薪。</summary>
        public decimal Salary
        {
            get { return _Salary; }
            set { _Salary = value; }
        }

        private decimal _Bonus;

        /// <summary>获取或设置员工提成金额</summary>
        public decimal Bonus
        {
            get { return _Bonus; }
            set { _Bonus = value; }
        }

        private decimal _Award;

        /// <summary>获取或设置员工奖金额</summary>
        public decimal Award
        {
            get { return _Award; }
            set { _Award = value; }
        }

        private decimal _Deduct;

        /// <summary>获取或设置员工扣款金额</summary>
        public decimal Deduct
        {
            get { return _Deduct; }
            set { _Deduct = value; }
        }

        /// <summary>获取或设置实发工资。</summary>
        public decimal LastTotal
        {
            get { return decimal.Parse((this.Salary + this.Bonus + this.Award - this.Deduct).ToString("f0")); }
        }

        #endregion

        #region 自定义函数...

        public static List<SalaryTable> SelectList(int year, int month)
        {
            List<SalaryTable> lstSalaryTable = new List<SalaryTable>();
            List<Employee> lstEmployee = new Employee().SelectList(0, 0);//获取员工信息列表
            foreach (Employee objEmp in lstEmployee)
            {
                SalaryTable objSalaryTable = new SalaryTable();
                objSalaryTable.WorkNumber = objEmp.Code.ToString();
                objSalaryTable.Name = objEmp.Name;
                objSalaryTable.PostName = objEmp.Post.Name;
                objSalaryTable.Salary = objEmp.Salary;
                objSalaryTable.Deduct = new EmpMoney().GetMoney(objEmp.ID, year, month, 0);//扣
                objSalaryTable.Award = new EmpMoney().GetMoney(objEmp.ID, year, month, 1);//奖
                if (new Pays().GetCountForEmployee(objEmp.ID, year, month) > 0 || (objEmp.Status == 0 || objEmp.Status == 1 || objEmp.Status == 2))
                {
                    objSalaryTable.MonthTotal = new Pays().GetMoneyForEmployee(objEmp.ID, year, month);//业绩
                    List<Pays> lstPay = new Pays().SelectListForEmployee(objEmp.ID, year, month);
                    if (objEmp.Post.Mode == 1)//发型师提成
                    {
                        objSalaryTable.Bonus = objSalaryTable.MonthTotal * decimal.Parse(objEmp.Bonus.ToString());
                    }
                    else if (objEmp.Post.Mode == 2)//助理提成
                    {
                        objSalaryTable.Bonus = SalaryTable.GetBonusMoney(lstPay);
                    }
                    lstSalaryTable.Add(objSalaryTable);
                }
            }
            return lstSalaryTable;
        }

        /// <summary>获取助理提成金额</summary>
        /// <param name="pays">消费单据</param>
        /// <returns></returns>
        private static decimal GetBonusMoney(List<Pays> pays)
        {
            decimal dMoney = 0;
            foreach (Pays objPay in pays)
            {
                foreach (PayDetail objDetail in objPay.PayDetails)
                {
                    if (objPay.IsCall == 1)//老找
                    {
                        dMoney += objDetail.SPItem.CallBonusMoney;
                    }
                    else
                    {
                        dMoney += objDetail.SPItem.BonusMoney;
                    }
                }
            }
            return dMoney;
        }



        #endregion
    }
}

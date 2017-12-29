using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BHair.Business.Table;

namespace BHair.Business
{
    public partial class frmPays_Employee : Form
    {
        private int m_iEmpId = 0;
        private bool bRun = false;

        /// <summary>查看员工业绩。</summary>
        public frmPays_Employee(int empid)
        {
            InitializeComponent();
            this.m_iEmpId = empid;
        }

        private void LoadData()
        {
            for (int y = 2011; y <= DateTime.Now.Year; y++)
            {
                this.cboYear.Items.Add(y.ToString());
            }
            for (int m = 1; m <= 12; m++)
            {
                this.cboMonth.Items.Add(m.ToString());
            }
            this.cboYear.Text = DateTime.Now.Year.ToString();
            this.cboMonth.Text = DateTime.Now.Month.ToString();
        }

        /// <summary>加载员工业绩</summary>
        private void LoadPaysForEmployee()
        {
            int iYear = int.Parse(this.cboYear.Text);
            int iMonth = int.Parse(this.cboMonth.Text);
            List<Pays> lstPays = new Pays().SelectListForEmployee(this.m_iEmpId, iYear, iMonth);
            this.dgvPays.AutoGenerateColumns = false;
            this.dgvPays.Rows.Clear();
            decimal dMoney = 0;
            //decimal dBonus = 0;
            foreach (Pays objPay in lstPays)
            {
                dMoney += objPay.Money;
                this.dgvPays.Rows.Add(new object[] { objPay.PayID, objPay.PayContent, objPay.Money, objPay.PayDate, objPay.Remark });
            }
            this.lblSum.Text = "本月总业绩：￥" + dMoney.ToString("f2");

            //if (this.m_objEmployee.Post.Mode == 1)//提成
            //{
            //    dBonus = dMoney * decimal.Parse(this.m_objEmployee.Post.Bonus);
            //}
            //else if (this.m_objEmployee.Post.Mode == 2)//手工费
            //{ }
            //dBonus = Math.Round(dBonus);
            //this.lblBonus.Text = "本月业绩提成：￥" + dBonus.ToString("f2");
        }


        private void frmPays_Employee_Load(object sender, EventArgs e)
        {
            this.LoadData();
            this.LoadPaysForEmployee();
            this.bRun = true;
        }

        /// <summary>年</summary>
        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.bRun)
            {
                this.LoadPaysForEmployee();
            }
        }

        /// <summary>年</summary>
        private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.bRun)
            {
                this.LoadPaysForEmployee();
            }
        }

        private void dgvPays_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            StaticValue.ShowRows_DataGridView_RowPostPaint(this.dgvPays, sender, e);
        }
    }
}

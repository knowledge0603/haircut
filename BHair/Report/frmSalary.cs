using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BHair.Business;
using BHair.Business.Table;

namespace BHair.Report
{
    public partial class frmSalary : WinFormsUI.Docking.DockContent
    {
        private bool _bRun = false;

        public frmSalary()
        {
            InitializeComponent();
        }

        private void frmSalary_Load(object sender, EventArgs e)
        {
            this.LoadYearAndMonth();
            this.LoadSalaryList();
            this._bRun = true;
        }

        private void dgvSalary_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            StaticValue.ShowRows_DataGridView_RowPostPaint(this.dgvSalary, sender, e);
        }

        /// <summary>加载年月</summary>
        private void LoadYearAndMonth()
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

        /// <summary>加载员工工资信息列表。</summary>
        private void LoadSalaryList()
        {
            int iYear = int.Parse(this.cboYear.Text);
            int iMonth = int.Parse(this.cboMonth.Text);
            List<SalaryTable> lstSalaryTable = SalaryTable.SelectList(iYear, iMonth);
            this.dgvSalary.AutoGenerateColumns = false;
            this.dgvSalary.Rows.Clear();
            decimal dSum = 0;
            foreach (SalaryTable objSalaryTable in lstSalaryTable)
            {
                dSum += objSalaryTable.LastTotal;
                this.dgvSalary.Rows.Add(new object[] { objSalaryTable.WorkNumber, objSalaryTable.Name, objSalaryTable.PostName, objSalaryTable.MonthTotal, objSalaryTable.Salary, objSalaryTable.Bonus, objSalaryTable.Award, objSalaryTable.Deduct, objSalaryTable.LastTotal });
            }
            this.lblSum.Text = "合计实发工资：￥" + dSum.ToString("f2");
            this.lblSum.Top = this.ClientSize.Height - 18;
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this._bRun)
            {
                this.LoadSalaryList();
            }
        }

        private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this._bRun)
            {
                this.LoadSalaryList();
            }
        }
    }
}

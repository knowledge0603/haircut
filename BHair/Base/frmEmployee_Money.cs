using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BHair.Business;
using BHair.Business.Table;

namespace BHair.Base
{
    public partial class frmEmployee_Money : Form
    {
        private int _iEmpId = 0;
        private bool _bRun = false;

        public frmEmployee_Money(int empid)
        {
            InitializeComponent();
            this._iEmpId = empid;
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

        private void frmEmployee_Money_Load(object sender, EventArgs e)
        {
            this.LoadData();
            this.LoadEmployeeMoneyList();
            this._bRun = true;
        }

        private void LoadEmployeeMoneyList()
        {
            int iYear = int.Parse(this.cboYear.Text);
            int iMonth = int.Parse(this.cboMonth.Text);
            List<EmpMoney> lstEmpMoney = new EmpMoney().SelectList(this._iEmpId, iYear, iMonth);
            this.dgvEmpMoney.AutoGenerateColumns = false;
            this.dgvEmpMoney.Rows.Clear();
            decimal dNo = 0;//扣款
            decimal dYes = 0;//奖金
            foreach (EmpMoney objEmpMoney in lstEmpMoney)
            {
                if (objEmpMoney.Type == 0)
                {
                    dNo += objEmpMoney.Money;
                }
                else
                {
                    dYes += objEmpMoney.Money;
                }
                this.dgvEmpMoney.Rows.Add(new object[] { objEmpMoney.ID, objEmpMoney.Date, objEmpMoney.Money, objEmpMoney.TypeText, objEmpMoney.Remark });
            }
            this.lblNo.Text = "扣款总额：￥" + dNo.ToString("f2");
            this.lblYes.Text = "奖金总额：￥" + dYes.ToString("f2");
        }

        /// <summary>行号</summary>
        private void dgvEmpMoney_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            StaticValue.ShowRows_DataGridView_RowPostPaint(this.dgvEmpMoney, sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEmpMoney_Add objAdd = new frmEmpMoney_Add(this._iEmpId);
            if (objAdd.ShowDialog() == DialogResult.OK)
            {
                this.LoadEmployeeMoneyList();
            }
        }

        /// <summary>删除</summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvEmpMoney.CurrentRow != null)
            {
                decimal dId = decimal.Parse(this.dgvEmpMoney.CurrentRow.Cells[0].Value.ToString());
                if (new EmpMoney().Delete(dId) > 0)
                {
                    this.LoadEmployeeMoneyList();
                }
            }
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this._bRun)
            {
                this.LoadEmployeeMoneyList();
            }
        }

        private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this._bRun)
            {
                this.LoadEmployeeMoneyList();
            }
        }

        private void dgvEmpMoney_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            decimal dId = decimal.Parse(this.dgvEmpMoney.CurrentRow.Cells[0].Value.ToString());
            frmEmpMoney_Add objUpdate = new frmEmpMoney_Add(dId);
            if (objUpdate.ShowDialog() == DialogResult.OK)
            {
                this.LoadEmployeeMoneyList();
            }
        }
    }
}

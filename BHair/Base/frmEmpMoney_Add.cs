using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BHair.Business.BaseData;
using BHair.Business.Table;

namespace BHair.Base
{
    public partial class frmEmpMoney_Add : Form
    {
        private int _iEmpId = 0;
        private decimal _Id = 0;
        private EmpMoney _objEmpMoney = new EmpMoney();

        public frmEmpMoney_Add(int empid)
        {
            InitializeComponent();
            this._iEmpId = empid;
        }

        public frmEmpMoney_Add(decimal id)
        {
            InitializeComponent();
            this._Id = id;
            this._objEmpMoney = new EmpMoney(this._Id);
            this._iEmpId = this._objEmpMoney.EmpId;
        }

        private void frmEmpMoney_Add_Load(object sender, EventArgs e)
        {
            this.dtpDate.Value = DateTime.Now;
            Employee objEmpLoyee = new Employee(this._iEmpId);
            this.lblEmpInfo.Text = "员工信息：[" + objEmpLoyee.Code + "]" + objEmpLoyee.Name + " " + objEmpLoyee.Post.Name;
            if (this._Id > 0)
            {
                this.dtpDate.Value = this._objEmpMoney.Date;
                this.numMoney.Value = this._objEmpMoney.Money;
                this.txtRemark.Text = this._objEmpMoney.Remark;
                if (this._objEmpMoney.Type == 0)
                {
                    this.radNO.Checked = true;
                }
                else
                {
                    this.radYes.Checked = true;
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            EmpMoney objEmpMoney = new EmpMoney();
            objEmpMoney.EmpId = this._iEmpId;
            objEmpMoney.Date = this.dtpDate.Value;
            objEmpMoney.Money = this.numMoney.Value;
            objEmpMoney.Remark = this.txtRemark.Text.Trim();
            objEmpMoney.Type = 0;//扣
            if (this.radYes.Checked)
            {
                objEmpMoney.Type = 1;
            }
            if (objEmpMoney.Money > 0)
            {
                if (this._Id > 0)
                {
                    objEmpMoney.ID = this._Id;
                    objEmpMoney.Update();
                }
                else
                {
                    objEmpMoney.Insert();
                }
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

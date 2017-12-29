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
    public partial class frmDeposit : WinFormsUI.Docking.DockContent
    {
        private bool _bRun = false;

        public frmDeposit()
        {
            InitializeComponent();
        }

        /// <summary>显示行号</summary>
        private void dgvDeposit_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            StaticValue.ShowRows_DataGridView_RowPostPaint(this.dgvDeposit, sender, e);
        }

        private void frmDeposit_Load(object sender, EventArgs e)
        {
            this.LoadDepositList();
            this._bRun = true;
        }

        /// <summary>加载充值记录列表。</summary>
        private void LoadDepositList()
        {
            List<Deposit> lstDeposit = new Deposit().SelectList("", this.cboDate.Year, this.cboDate.Month, this.cboDate.Day);
            this.dgvDeposit.AutoGenerateColumns = false;
            this.dgvDeposit.Rows.Clear();
            decimal dSum = 0;
            decimal dMoney = 0;
            foreach (Deposit objDep in lstDeposit)
            {
                if (objDep.Money < 0)
                {
                    dSum += 0 - objDep.Money;
                }
                else
                {
                    dSum += objDep.Money;
                }
                if (objDep.Mode == 0)
                {
                    dMoney += objDep.Money;
                }
                this.dgvDeposit.Rows.Add(new object[] { objDep.ID, "[" + objDep.MemberInfo.ID + "]" + objDep.MemberInfo.Name, objDep.Money, objDep.Date, objDep.ModeText, objDep.Remark });
            }
            this.lblSum.Text = "交易总金额：￥" + dSum.ToString("f2");
            this.lblSum.Top = this.ClientSize.Height - 18;
            this.lblMoney.Text = "实际收入金额：￥" + dMoney.ToString("f2");
            this.lblMoney.Top = this.ClientSize.Height - 18;
        }

        private void cboDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this._bRun)
            {
                this.LoadDepositList();
            }
        }
    }
}

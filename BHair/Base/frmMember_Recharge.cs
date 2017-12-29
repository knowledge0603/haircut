using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BHair.Business.BaseData;
using BHair.Business.Table;
using BHair.Business;
using XLuSharpLibrary.CommonFunction;

namespace BHair.Base
{
    public partial class frmMember_Recharge : Form
    {
        private string m_strMemberId = "";
        private bool bRun = false;

        public frmMember_Recharge(string memberid)
        {
            InitializeComponent();
            this.m_strMemberId = memberid;
        }

        private void frmMember_Recharge_Load(object sender, EventArgs e)
        {
            this.LoadMemberInfo();
            this.LoadRechargeList();
            this.bRun = true;
        }

        /// <summary>加载会员信息</summary>
        private void LoadMemberInfo()
        {
            Member objMember = new Member(this.m_strMemberId);
            this.lblMemberID.Text = objMember.ID;
            this.lblName.Text = objMember.Name;
            this.lblCardName.Text = objMember.Card.CardName;
            this.lblBalance.Text = "￥" + objMember.Balance.ToString("f2");
            this.lblPoint.Text = objMember.Point.ToString();
            this.lblStatus.Text = objMember.StatusText;
            if (objMember.Status == 1)
            {
                this.btnRecharge.Visible = false;
                this.cmnuDeposit_Recharge.Enabled = false;
            }
        }

        /// <summary>加载会员充值记录</summary>
        private void LoadRechargeList()
        {
            List<Deposit> lstDeposit = new Deposit().SelectList(this.m_strMemberId, this.cboDate.Year, this.cboDate.Month, this.cboDate.Day);
            this.dgvDeposit.AutoGenerateColumns = false;
            this.dgvDeposit.Rows.Clear();
            decimal dSum = 0;
            foreach (Deposit objDep in lstDeposit)
            {
                dSum += objDep.Money;
                this.dgvDeposit.Rows.Add(new object[] { objDep.ID, objDep.Money, objDep.Date, objDep.ModeText, objDep.Remark });
            }
            this.lblSum.Text = "￥" + dSum.ToString("f2");
        }

        #region 会员充值...

        /// <summary>会员充值</summary>
        private void btnRecharge_Click(object sender, EventArgs e)
        {
            frmDeposit_Add objfrmDepositAdd = new frmDeposit_Add(this.m_strMemberId);
            if (objfrmDepositAdd.ShowDialog() == DialogResult.OK)
            {
                this.LoadMemberInfo();
                this.LoadRechargeList();
            }
        }

        /// <summary>会员充值</summary>
        private void cmnuDeposit_Recharge_Click(object sender, EventArgs e)
        {
            frmDeposit_Add objfrmDepositAdd = new frmDeposit_Add(this.m_strMemberId);
            if (objfrmDepositAdd.ShowDialog() == DialogResult.OK)
            {
                this.LoadMemberInfo();
                this.LoadRechargeList();
            }
        }

        #endregion

        /// <summary>按日期过滤</summary>
        private void cboDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.bRun)
            {
                this.LoadRechargeList();
            }
        }

        #region 删除会员充值记录...

        /// <summary>删除会员充值记录</summary>
        private void cmnuDeposit_Delete_Click(object sender, EventArgs e)
        {
            if (this.dgvDeposit.CurrentRow != null)
            {
                string iDepositId = this.dgvDeposit.CurrentRow.Cells[0].Value.ToString();
                if (MessageBox.Show("确实要删除当前记录吗，删除后将不能恢复。", "消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Deposit objDeposit = new Deposit(decimal.Parse(iDepositId));
                    if (objDeposit.DeleteDeposit())
                    {
                        this.LoadMemberInfo();
                        this.LoadRechargeList();
                    }
                }
            }
        }

        #endregion

        private void dgvDeposit_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo rows = this.dgvDeposit.HitTest(e.X, e.Y);
            if (e.Button == MouseButtons.Right)
            {
                if (rows.RowIndex > -1 && rows.ColumnIndex > -1)
                {
                    //定位
                    this.dgvDeposit.ClearSelection();
                    this.dgvDeposit.Rows[rows.RowIndex].Selected = true;
                    this.dgvDeposit.CurrentCell = this.dgvDeposit.Rows[rows.RowIndex].Cells[rows.ColumnIndex];

                    Deposit objDeposit = new Deposit(int.Parse(this.dgvDeposit.CurrentRow.Cells[0].Value.ToString()));
                    if (objDeposit.Mode == 0)
                    {
                        this.cmnuDeposit_Delete.Enabled = true;
                    }
                    else
                    {
                        this.cmnuDeposit_Delete.Enabled = false;
                    }
                }
                else
                {
                    this.cmnuDeposit_Delete.Enabled = false;
                }
            }
        }

        private void dgvDeposit_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            StaticValue.ShowRows_DataGridView_RowPostPaint(this.dgvDeposit, sender, e);
        }

        /// <summary>刷新</summary>
        private void cmnuDeposit_Refresh_Click(object sender, EventArgs e)
        {
            new Member().UpdateBalance(this.m_strMemberId);
            this.LoadMemberInfo();
            this.LoadRechargeList();
        }
    }
}

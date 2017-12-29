using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BHair.Business.Table;
using BHair.Business.BaseData;

namespace BHair.Business
{
    public partial class frmRecharge : Form
    {
        private string m_strMemberId = "";//会员卡号
        private int m_iDepositId = 0;//充值流水号

        /// <summary>会员充值</summary>
        /// <param name="memberid">会员卡号</param>
        public frmRecharge(string memberid)
        {
            InitializeComponent();
            this.m_strMemberId = memberid;
        }

        /// <summary>会员充值(修改)</summary>
        /// <param name="depid">充值流水号</param>
        public frmRecharge(int depid)
        {
            InitializeComponent();
            this.m_iDepositId = depid;
        }

        private void frmRecharge_Load(object sender, EventArgs e)
        {
            Member objMember = new Member();
            if (this.m_iDepositId > 0)
            {
                Deposit objDeposit = new Deposit(this.m_iDepositId);
                objMember = objDeposit.MemberInfo;
            }
            else
            {
                objMember = new Member(this.m_strMemberId);
            }
            this.lblMemberID.Text = objMember.ID;
            this.lblName.Text = objMember.Name;
            this.lblCardName.Text = objMember.Card.CardName;
            this.lblBalance.Text = "￥" + objMember.Balance.ToString("f2");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Deposit objDeposit = new Deposit();
            objDeposit.MemberID = this.m_strMemberId;
            objDeposit.Money = this.numMoney.Value;
            objDeposit.Remark = this.txtRemark.Text.Trim();
            objDeposit.Date = DateTime.Now;
            objDeposit.Mode = 0;//充值
            if (this.m_iDepositId > 0)
            {
                objDeposit.ID = this.m_iDepositId;
                if (objDeposit.Money > 0)
                {
                    objDeposit.UpdateDeposit();
                }
            }
            else
            {
                if (objDeposit.Money > 0)
                {
                    objDeposit.InsertDeposit();
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

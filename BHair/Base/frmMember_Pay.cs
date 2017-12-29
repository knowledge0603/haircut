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

namespace BHair.Base
{
    public partial class frmMember_Pay : Form
    {
        private string _strMemberId = "";
        private bool bRun = false;

        /// <summary>消费单据</summary>
        public frmMember_Pay()
        {
            InitializeComponent();
        }

        /// <summary>消费单据</summary>
        /// <param name="memberid">会员卡号</param>
        public frmMember_Pay(string memberid)
        {
            InitializeComponent();
            this._strMemberId = memberid;
        }

        private void frmMember_Pay_Load(object sender, EventArgs e)
        {
            this.LoadMemberInfo();
            this.LoadMemberPayList();
            this.bRun = true;
        }

        /// <summary>加载会员信息</summary>
        private void LoadMemberInfo()
        {
            Member objMember = new Member(this._strMemberId);
            this.lblMemberID.Text = objMember.ID;
            this.lblName.Text = objMember.Name;
            this.lblCardName.Text = objMember.Card.CardName;
            this.lblPhone.Text = objMember.Phone;
            this.lblBalance.Text = "￥" + objMember.Balance.ToString("f2");
            //this.lblPoint.Text = objMember.Point.ToString();
            this.lblStatus.Text = objMember.StatusText;
        }

        /// <summary>加载会员消费记录。</summary>
        private void LoadMemberPayList()
        {
            List<Pays> lstPays = new Pays().SelectList("", this._strMemberId, this.cboDate.Year, this.cboDate.Month, 0, null, null);
            this.dgvPays.AutoGenerateColumns = false;
            this.dgvPays.Rows.Clear();
            decimal dSum = 0;//合计
            decimal dBalance = 0;//余额消费
            decimal dCash = 0;//现金消费
            foreach (Pays objPay in lstPays)
            {
                if (objPay.Status == 1)
                {
                    dSum += objPay.Money;
                    if (objPay.PayType == 1)
                    {
                        dBalance += objPay.Money;
                    }
                    else
                    {
                        dCash += objPay.Money;
                    }
                }
                this.dgvPays.Rows.Add(new object[] { objPay.PayID, objPay.Money, objPay.PayContent, objPay.PayDate, objPay.PayTypeText, objPay.Remark });
            }
            this.lblSum.Text = "消费合计：￥" + dSum.ToString("f2");
            this.lblPayBalance.Text = "余额消费：￥" + dBalance.ToString("f2");
            this.lblCash.Text = "现金消费：￥" + dCash.ToString("f2");
        }

        /// <summary>按日期过滤</summary>
        private void cboDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.bRun)
            {
                this.LoadMemberPayList();
            }
        }

        private void dgvPays_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            StaticValue.ShowRows_DataGridView_RowPostPaint(this.dgvPays, sender, e);
        }

        /// <summary>查看消费单据</summary>
        private void dgvPays_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (this.dgvPays.CurrentRow != null)
                {
                    string strPayId = this.dgvPays.CurrentRow.Cells[0].Value.ToString();
                    frmPays_Modify objfrmPaysModify = new frmPays_Modify(strPayId);
                    objfrmPaysModify.ShowDialog();
                }
            }
        }
    }
}

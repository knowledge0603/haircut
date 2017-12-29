using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BHair.Business.BaseData;
using BHair.Business;
using BHair.Business.Table;

namespace BHair.Base
{
    public partial class frmMember_List : WinFormsUI.Docking.DockContent
    {
        public frmMember_List()
        {
            InitializeComponent();
        }

        private void frmMember_List_Load(object sender, EventArgs e)
        {
            this.LoadMemberList();
            this.LoadMemberNum();
        }

        /// <summary>加载会员信息列表。</summary>
        public void LoadMemberList()
        {
            string strMember = this.txtMember.Text;
            bool bEnabled = this.chkEnabled.Checked;
            List<Member> lstMember = new Member().SelectList(strMember, bEnabled);
            this.dgvMember.AutoGenerateColumns = false;
            this.dgvMember.Rows.Clear();
            decimal dSum = 0;//合计余额
            foreach (Member objMember in lstMember)
            {
                dSum += objMember.Balance;
                this.dgvMember.Rows.Add(new object[] { objMember.ID, objMember.Card.CardName, objMember.Name, objMember.SexText, objMember.Birthday, objMember.Balance, objMember.Point, objMember.Phone, objMember.LastTime, objMember.StatusText, objMember.Other, objMember.Remark });
            }
            this.lblSumBalance.Text = "会员余额合计：￥" + dSum.ToString("f2");
            
            this.lblSumBalance.Top = this.ClientSize.Height - 18;
        }

        /// <summary>加载会员数统计。</summary>
        public void LoadMemberNum()
        {
            //会员总数
            string strNum = Member.GetMemberTotal(0, 0).ToString();
            strNum += "|" + Member.GetMemberTotal(1, 0).ToString();
            strNum += "|" + Member.GetMemberTotal(2, 0).ToString();//5+1+a+s+p+x
            this.lblTotal.Text = "会员数统计：" + strNum;
            this.lblTotal.Top = this.ClientSize.Height - 18;

            //会员类型
            List<Card> lstCard = new Card().SelectList(0);
            this.lblType.Text = "";
            foreach (Card objCard in lstCard)
            {
                this.lblType.Text += objCard.CardName + "：" + objCard.MemberSum.ToString() + "   ";
            }
            this.lblType.Top = this.ClientSize.Height - 18;
        }

        /// <summary>显示不可用会员</summary>
        private void chkEnabled_CheckedChanged(object sender, EventArgs e)
        {
            this.LoadMemberList();
        }

        private void txtMember_TextChanged(object sender, EventArgs e)
        {
            this.LoadMemberList();
        }

        /// <summary>新增会员</summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMember objfrmMember = new frmMember();
            if (objfrmMember.ShowDialog() == DialogResult.OK)
            {
                this.LoadMemberList();
                this.LoadMemberNum();
            }
        }

        #region 编辑会员信息...

        /// <summary>编辑会员</summary>
        private void btnModify_Click(object sender, EventArgs e)
        {
            this.ShowMember();
        }

        /// <summary>双击编辑会员信息</summary>
        private void dgvMember_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                this.ShowMember();
            }
        }

        private void ShowMember()
        {
            if (this.dgvMember.CurrentRow != null)
            {
                string strMemberId = this.dgvMember.CurrentRow.Cells[0].Value.ToString();
                frmMember objfrmMember = new frmMember(strMemberId);
                if (objfrmMember.ShowDialog() == DialogResult.OK)
                {
                    this.LoadMemberList();
                }
            }
        }

        #endregion

        #region 会员充值...

        /// <summary>会员充值</summary>
        private void btnRecharge_Click(object sender, EventArgs e)
        {
            this.MemberRecharge();
        }

        /// <summary>会员充值</summary>
        private void cmnuMember_Recharge_Click(object sender, EventArgs e)
        {
            this.MemberRecharge();
        }

        /// <summary>会员充值</summary>
        private void MemberRecharge()
        {
            if (this.dgvMember.CurrentRow != null)
            {
                string strMemberId = this.dgvMember.CurrentRow.Cells[0].Value.ToString();
                if (new Member(strMemberId).Status == 1)
                {
                    MessageBox.Show("当前会员状态不可用，不能进行充值操作！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    frmDeposit_Add objfrmDepositAdd = new frmDeposit_Add(strMemberId);
                    if (objfrmDepositAdd.ShowDialog() == DialogResult.OK)
                    {
                        this.LoadMemberList();
                    }
                }
            }
        }

        /// <summary>查看充值记录</summary>
        private void cmnuMember_RechargeLog_Click(object sender, EventArgs e)
        {
            if (this.dgvMember.CurrentRow != null)
            {
                string strMemberId = this.dgvMember.CurrentRow.Cells[0].Value.ToString();
                frmMember_Recharge objMemberRecharge = new frmMember_Recharge(strMemberId);
                objMemberRecharge.ShowDialog();
            }
        }

        #endregion

        /// <summary>右键选取</summary>
        private void dgvMember_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo rows = this.dgvMember.HitTest(e.X, e.Y);
            if (e.Button == MouseButtons.Right)
            {
                if (rows.RowIndex > -1 && rows.ColumnIndex > -1)
                {
                    //定位
                    this.dgvMember.ClearSelection();
                    this.dgvMember.Rows[rows.RowIndex].Selected = true;
                    this.dgvMember.CurrentCell = this.dgvMember.Rows[rows.RowIndex].Cells[rows.ColumnIndex];

                    string strMemberID = this.dgvMember.CurrentRow.Cells[0].Value.ToString();
                    Member objMember = new Member(strMemberID);
                    if (objMember.Status == 0)
                    {
                        //正常
                        this.cmnuMember_Recharge.Enabled = true;

                        this.cmnuMember_Exchange.Enabled = true;//换卡
                        this.cmnuMember_Back.Enabled = true;//退卡
                    }
                    else
                    {
                        //停用
                        this.cmnuMember_Recharge.Enabled = false;

                        this.cmnuMember_Exchange.Enabled = false;//换卡
                        this.cmnuMember_Back.Enabled = false;//退卡
                    }
                    this.cmnuMember_Transfer.Enabled = true;
                    this.cmnuMember_PaysLog.Enabled = true;
                    this.cmnuMember_RechargeLog.Enabled = true;
                }
                else
                {
                    this.cmnuMember_Recharge.Enabled = false;//充值
                    this.cmnuMember_Transfer.Enabled = false;//转账
                    this.cmnuMember_PaysLog.Enabled = false;//消费记录
                    this.cmnuMember_RechargeLog.Enabled = false;//充值记录
                    this.cmnuMember_Exchange.Enabled = false;//换卡
                    this.cmnuMember_Back.Enabled = false;//退卡
                }
            }
        }

        /// <summary>新增消费</summary>
        private void cmnuMember_Pays_Click(object sender, EventArgs e)
        {
            if (this.dgvMember.CurrentRow != null)
            {
                string strMemberId = this.dgvMember.CurrentRow.Cells[0].Value.ToString();
                frmMember_Pay objMemberPay = new frmMember_Pay(strMemberId);
                objMemberPay.ShowDialog();
            }
        }
        /// <summary>余额转帐</summary>
        private void cmnuMember_Transfer_Click(object sender, EventArgs e)
        {
            if (this.dgvMember.CurrentRow != null)
            {
                string strMemberId = this.dgvMember.CurrentRow.Cells[0].Value.ToString();
                frmMember_Transfer objfrmMemberTransfer = new frmMember_Transfer(strMemberId);
                if (objfrmMemberTransfer.ShowDialog() == DialogResult.OK)
                {
                    this.LoadMemberList();
                }
            }
        }

        /// <summary>查看消费记录</summary>
        private void cmnuMember_PaysLog_Click(object sender, EventArgs e)
        {
            if (this.dgvMember.CurrentRow != null)
            {
                string strMemberId = this.dgvMember.CurrentRow.Cells[0].Value.ToString();
                frmMember_Pay objMemberPay = new frmMember_Pay(strMemberId);
                objMemberPay.ShowDialog();
            }
        }

        /// <summary>会员换卡</summary>
        private void cmnuMember_Exchange_Click(object sender, EventArgs e)
        {
            if (this.dgvMember.CurrentRow != null)
            {
                string strMemberId = this.dgvMember.CurrentRow.Cells[0].Value.ToString();
                frmMember_Exchange objMemberExchange = new frmMember_Exchange(strMemberId);
                if (objMemberExchange.ShowDialog() == DialogResult.OK)
                {
                    this.LoadMemberList();
                }
            }
        }

        /// <summary>刷新</summary>
        private void cmnuMember_Refresh_Click(object sender, EventArgs e)
        {
            this.LoadMemberList();
            this.LoadMemberNum();
        }

        /// <summary>会员退卡</summary>
        private void cmnuMember_Back_Click(object sender, EventArgs e)
        {
            if (this.dgvMember.CurrentRow != null)
            {
                string strMemberId = this.dgvMember.CurrentRow.Cells[0].Value.ToString();
                Member objMember = new Member(strMemberId);
                if (MessageBox.Show("会员【" + objMember.ID + "】" + objMember.Name + "\n当前余额：￥" + objMember.Balance.ToString("f2") + "\n确实要退卡吗？", "消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Deposit objDeposit = new Deposit();
                    objDeposit.Mode = 4;
                    objDeposit.MemberID = objMember.ID;
                    objDeposit.Money = 0 - objMember.Balance;
                    objDeposit.Date = DateTime.Now;
                    if (objDeposit.BackDeposit() > 0)
                    {
                        objMember.Remark = objDeposit.Date.ToShortDateString() + "退卡";
                        objMember.UpdateStatus();//更新会员状态
                        objMember.UpdateBalance(objMember.ID);//更新会员余额

                        //新增支出
                        Subject objSubject = new Subject();
                        objSubject.ID = objSubject.ExistsSubjectName("退卡");
                        if (objSubject.ID == 0)
                        {
                            objSubject.Name = "退卡";
                            objSubject.Readme = "会员退卡";
                            objSubject.Type = 0;
                            objSubject.ID = objSubject.InsertSubject();
                        }

                        WasteBook objWasteBook = new WasteBook();
                        objWasteBook.SubjectID = objSubject.ID;
                        objWasteBook.Income = 0;
                        objWasteBook.Expend = objMember.Balance;
                        objWasteBook.Date = objDeposit.Date;
                        objWasteBook.Remark = "会员卡号【" + objMember.ID + "】" + objMember.Name;
                        objWasteBook.Type = "e";
                        objWasteBook.InsertWasteBook();

                        this.LoadMemberList();
                        this.LoadMemberNum();
                    }
                }
            }
        }

        private void dgvMember_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            StaticValue.ShowRows_DataGridView_RowPostPaint(this.dgvMember, sender, e);
        }
    }
}

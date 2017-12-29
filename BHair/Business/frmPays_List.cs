using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using XLuSharpLibrary.CommonFunction;
using BHair.Business.Table;

namespace BHair.Business
{
    public partial class frmPays_List : WinFormsUI.Docking.DockContent
    {
        public bool bRun = false;

        public frmPays_List()
        {
            InitializeComponent();
        }

        #region 加载消费单据列表...

        /// <summary>加载消费单据列表。</summary>
        public void LoadPaysList()
        {
            string strPayId = this.txtID.Text;//消费单号
            List<Pays> lstPays = new Pays().SelectList(strPayId, "", this.cboDate.Year, this.cboDate.Month, this.cboDate.Day, null, null);
            this.dgvPays.AutoGenerateColumns = false;
            this.dgvPays.Rows.Clear();
            decimal dSum = 0;//合计
            decimal dMember = 0;//会员
            decimal dCash = 0;//现金
            decimal dNotPay = 0;//未结算
            foreach (Pays objPay in lstPays)
            {
                dSum += objPay.Money;//合计
                if (objPay.Status == 1)
                {
                    if (objPay.MemberId != "0" && objPay.PayType == 1)
                    {
                        dMember += objPay.Money;
                    }
                    else
                    {
                        dCash += objPay.Money;
                    }
                }
                else
                {
                    dNotPay += objPay.Money;//未结算金额
                }
                this.dgvPays.Rows.Add(new object[] { objPay.PayID, objPay.ClientName, objPay.PayContent, objPay.Money, objPay.Cash, objPay.Zero, objPay.PayDate, objPay.PayTypeText, objPay.StatusText, objPay.Remark });
            }
            this.lblSum.Text = "营业额：￥" + dSum.ToString("f2");
            this.lblSum.Top = this.ClientSize.Height - 18;

            this.lblCashMoney.Text = "现金消费：￥" + dCash.ToString("f2");
            this.lblCashMoney.Top = this.ClientSize.Height - 18;
            
            this.lblMember.Text = "余额消费：￥" + dMember.ToString("f2");
            this.lblMember.Top = this.ClientSize.Height - 18;
            
            this.lblNotPay.Text = "未结算金额：￥" + dNotPay.ToString("f2");
            this.lblNotPay.Top = this.ClientSize.Height - 18;
        }

        #endregion

        private void frmPays_List_Load(object sender, EventArgs e)
        {
            this.LoadPaysList();
            this.bRun = true;
        }

        #region 新增消费...

        /// <summary>新增消费</summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Pays_Add_Click();
        }

        /// <summary>新增消费</summary>
        private void cmnuPays_Add_Click(object sender, EventArgs e)
        {
            this.Pays_Add_Click();
        }

        /// <summary>新增消费单据</summary>
        private void Pays_Add_Click()
        {
            frmPays_Add objPaysAdd = new frmPays_Add();
            if (objPaysAdd.ShowDialog() == DialogResult.OK)
            {
                this.LoadPaysList();
            }
        }

        #endregion

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericClass.NumberAccpter(sender, e, false);
        }

        /// <summary>按消费单号查询</summary>
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            this.LoadPaysList();
        }

        /// <summary>按日期过滤查询。</summary>
        private void cboDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.bRun)
            {
                this.LoadPaysList();
            }
        }

        private void dgvPays_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            StaticValue.ShowRows_DataGridView_RowPostPaint(this.dgvPays, sender, e);
        }

        /// <summary>消费结算</summary>
        private void cmnuPays_OK_Click(object sender, EventArgs e)
        {
            string strPayId = this.dgvPays.CurrentRow.Cells[0].Value.ToString();
            frmPay_OK objfrmPaysOK = new frmPay_OK(strPayId);
            if (objfrmPaysOK.ShowDialog() == DialogResult.OK)
            {
                this.LoadPaysList();
            }
        }

        private void dgvPays_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo rows = this.dgvPays.HitTest(e.X, e.Y);
            if (e.Button == MouseButtons.Right)
            {
                if (rows.RowIndex > -1 && rows.ColumnIndex > -1)
                {
                    //定位
                    this.dgvPays.ClearSelection();
                    this.dgvPays.Rows[rows.RowIndex].Selected = true;
                    this.dgvPays.CurrentCell = this.dgvPays.Rows[rows.RowIndex].Cells[rows.ColumnIndex];

                    string strPayId = this.dgvPays.CurrentRow.Cells[0].Value.ToString();
                    Pays objPay = new Pays(strPayId);
                    if (objPay.Status == 0)
                    {
                        this.cmnuPays_Delete.Enabled = true;
                        this.cmnuPays_OK.Enabled = true;
                    }
                    else
                    {
                        this.cmnuPays_Delete.Enabled = false;
                        this.cmnuPays_OK.Enabled = false;
                    }
                    this.cmnuPays_Remark.Enabled = true;
                }
                else
                {
                    this.cmnuPays_Delete.Enabled = false;
                    this.cmnuPays_OK.Enabled = false;
                    this.cmnuPays_Remark.Enabled = false;
                }
            }
        }

        /// <summary>删除消费单据</summary>
        private void cmnuPays_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确实要删除消费记录，删除后将不可恢复！", "消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (this.dgvPays.CurrentRow != null)
                {
                    string strPayId = this.dgvPays.CurrentRow.Cells[0].Value.ToString();
                    if (new Pays().DeletePay(strPayId))
                    {
                        this.LoadPaysList();
                    }
                }
            }
        }

        /// <summary>刷新</summary>
        private void cmnuPays_Refresh_Click(object sender, EventArgs e)
        {
            this.LoadPaysList();
        }

        /// <summary>填写备注</summary>
        private void cmnuPays_Remark_Click(object sender, EventArgs e)
        {
            string strPayId = this.dgvPays.CurrentRow.Cells[0].Value.ToString();
            frmPays_Remark objfrmPayRemark = new frmPays_Remark(strPayId);
            if (objfrmPayRemark.ShowDialog() == DialogResult.OK)
            {
                this.LoadPaysList();
            }
        }

        private void dgvPays_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                this.ShowPays();
            }
        }

        private void ShowPays()
        {
            if (this.dgvPays.CurrentRow != null)
            {
                string strPayId = this.dgvPays.CurrentRow.Cells[0].Value.ToString();
                frmPays_Modify objfrmPaysModify = new frmPays_Modify(strPayId);
                if (objfrmPaysModify.ShowDialog() == DialogResult.OK)
                {
                    this.LoadPaysList();
                }
            }
        }
    }
}

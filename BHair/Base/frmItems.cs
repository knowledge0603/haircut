using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BHair.Business.BaseData;

namespace BHair.Base
{
    public partial class frmItems : Form
    {
        private int m_iItemId = 0;

        /// <summary>商品信息</summary>
        public frmItems()
        {
            InitializeComponent();
        }

        /// <summary>商品信息</summary>
        /// <param name="itemid">商品编号</param>
        public frmItems(int itemid)
        {
            InitializeComponent();
            this.m_iItemId = itemid;
        }

        private void frmItems_Load(object sender, EventArgs e)
        {
            this.cboType.SelectedIndex = 0;
            this.cboStatus.SelectedIndex = 0;

            if (this.m_iItemId > 0)
            {
                SPItems objItem = new SPItems(this.m_iItemId);
                this.cboType.SelectedIndex = objItem.Type;
                this.txtName.Text = objItem.Name;
                this.numFPrice.Value = objItem.FatPrice;
                this.numAmount.Value = decimal.Parse(objItem.Amount.ToString());
                this.cboStatus.SelectedIndex = objItem.Status;
                this.numUPrice.Value = objItem.UnitPrice;
                this.numNPrice.Value = objItem.NumPrice;
                this.numMoney.Value = objItem.BonusMoney;
                this.numCMoney.Value = objItem.CallBonusMoney;
                this.numConvert.Value = decimal.Parse(objItem.Convert.ToString());
                this.txtReadme.Text = objItem.Readme;
                if (objItem.IsBonus == 1)//不打折
                {
                    this.chkNoBonus.Checked = true;
                }
                if (objItem.IsTiCheng == 1)
                {
                    this.chkTiCheng.Checked = true;
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SPItems objItem = new SPItems();
            objItem.Type = this.cboType.SelectedIndex;
            objItem.Name = this.txtName.Text.Trim();
            objItem.FatPrice = this.numFPrice.Value;
            objItem.Amount = int.Parse(this.numAmount.Value.ToString());
            objItem.Status = this.cboStatus.SelectedIndex;
            objItem.UnitPrice = this.numUPrice.Value;
            objItem.NumPrice = this.numNPrice.Value;
            objItem.BonusMoney = this.numMoney.Value;
            objItem.CallBonusMoney = this.numCMoney.Value;
            objItem.Convert = int.Parse(this.numConvert.Value.ToString());
            objItem.Readme = this.txtReadme.Text.Trim();
            objItem.IsBonus = 0;//打折
            if (this.chkNoBonus.Checked)
            {
                objItem.IsBonus = 1;//不打折
            }
            objItem.IsTiCheng = 0;//提成
            if (this.chkTiCheng.Checked)
            {
                objItem.IsTiCheng = 1;//不提成
            }
            if (objItem.Name == "")
            {
                MessageBox.Show("商品名称不能为空，请为该商品指定一个唯一名称。", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtName.Focus();
                return;
            }
            int iTempId = objItem.ExistsPostName(objItem.Name);
            if (this.m_iItemId > 0)
            {
                objItem.ID = this.m_iItemId;
                if (iTempId > 0 && iTempId != this.m_iItemId)
                {
                    MessageBox.Show("商品列表中已经存在同名商品，请为该商品指定一个唯一名称。", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtName.Focus();
                    return;
                }
                objItem.UpdateSPItems();
            }
            else
            {
                if (iTempId > 0)
                {
                    MessageBox.Show("商品列表中已经存在同名商品，请为该商品指定一个唯一名称。", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtName.Focus();
                    return;
                }
                objItem.InsertSPItems();
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

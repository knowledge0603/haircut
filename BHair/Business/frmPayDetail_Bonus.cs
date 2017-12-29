using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BHair.Business.Table;

namespace BHair.Business
{
    public partial class frmPayDetail_Bonus : Form
    {
        private int _iIndex = -1;
        private decimal _iDetailId = 0;

        public frmPayDetail_Bonus(int index)
        {
            InitializeComponent();
            this._iIndex = index;
        }

        public frmPayDetail_Bonus(decimal detailid)
        {
            InitializeComponent();
            this._iDetailId = detailid;
        }

        private void frmPayDetail_Bonus_Load(object sender, EventArgs e)
        {
            PayDetail objDetail = new PayDetail();
            if (this._iIndex > -1)
            {
                objDetail = StaticValue.g_lstTempPayDetails[this._iIndex];
            }
            else if (this._iDetailId > 0)
            {
                objDetail = new PayDetail(this._iDetailId);
            }
            this.lblName.Text = objDetail.SPItem.Name;
            this.lblPrice.Text = "￥" + objDetail.SPItem.UnitPrice.ToString("f2");
            this.numBonus.Value = decimal.Parse(objDetail.Bonus.ToString());
            this.numBonused.Value = objDetail.Money;
        }

        /// <summary>确定按钮</summary>
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this._iDetailId == 0)
            {
                StaticValue.g_lstTempPayDetails[this._iIndex].Bonus = double.Parse(this.numBonus.Value.ToString());
                StaticValue.g_lstTempPayDetails[this._iIndex].Money = this.numBonused.Value;
            }
            else
            {
                PayDetail objDetail = new PayDetail();
                objDetail.DetailID = this._iDetailId;
                objDetail.Bonus = double.Parse(this.numBonus.Value.ToString());
                objDetail.Money = this.numBonused.Value;
                objDetail.UpdateDetailBonus();
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>取消按钮</summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region 计算折后金额...

        private void numBonus_ValueChanged(object sender, EventArgs e)
        {
            this.CalculateBonused();
        }

        private void numBonus_KeyUp(object sender, KeyEventArgs e)
        {
            this.CalculateBonused();
        }

        /// <summary>计算折后金额。</summary>
        private void CalculateBonused()
        {
            decimal dPrice = 0;
            decimal dBonus = this.numBonus.Value;
            if (this._iDetailId == 0)
            {
                dPrice = StaticValue.g_lstTempPayDetails[this._iIndex].SPItem.UnitPrice;
            }
            else
            {
                PayDetail objDetail = new PayDetail(this._iDetailId);
                dPrice = objDetail.SPItem.UnitPrice;
            }
            this.numBonused.Value = decimal.Parse((dPrice * dBonus).ToString("f0"));
        }

        #endregion
    }
}

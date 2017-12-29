using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using XLuSharpLibrary.CommonFunction;
using BHair.Business.Table;
using BHair.Business.BaseData;

namespace BHair.Business
{
    public partial class frmPay_OK : Form
    {
        private Pays _objPay = new Pays();//消费单据信息
        private decimal _dZero = 0;

        public frmPay_OK(string payid)
        {
            InitializeComponent();
            this._objPay = new Pays(payid);//保存消费单据
        }

        private void frmPay_OK_Load(object sender, EventArgs e)
        {
            if (this._objPay.MemberId == "0")
            {
                this.lblName.Text += "非会员(散客)";
                this.lblBalance.Text += "￥0.00";
                this.rbtnBalance.Enabled = false;
                this.rbtnAnd.Enabled = false;
                this.LoadCashPay();//初始化现金支付数据
            }
            else //会员
            {
                this.lblName.Text += this._objPay.ClientName;
                this.lblBalance.Text += this._objPay.Member.Balance.ToString("f2");
                if (this._objPay.Member.Balance >= this._objPay.Money)
                {
                    //余额大于等于消费金额
                    this.rbtnBalance.Checked = true;
                    this.rbtnAnd.Enabled = true;
                    this.LoadBalancePay();
                }
                else if (this._objPay.Member.Balance < this._objPay.Money)
                {
                    //余额小于消费金额
                    this.rbtnBalance.Enabled = false;
                    this.LoadCashPay();
                }
            }
            this.lblPayID.Text += this._objPay.PayID;
            this.lblMoney.Text += "￥" + this._objPay.Money.ToString("f2");//消费金额
        }


        #region 支付方式...

        /// <summary>现金</summary>
        private void rbtnCash_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbtnCash.Checked)
            {
                this.LoadCashPay();
            }
        }

        /// <summary>初始化现金支付数据</summary>
        private void LoadCashPay()
        {
            this.numPayBalance.Value = 0;
            this.numPayMoney.Value = this._objPay.Money;
            this.txtCash.Text = this._objPay.Money.ToString("f2");

            this.numPayMoney.Minimum = 0;

            this.numPayBalance.Enabled = false;
            this.numPayMoney.Enabled = false;
            this.txtCash.ReadOnly = false;
        }

        /// <summary>余额</summary>
        private void rbtnBalance_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbtnBalance.Checked)
            {
                this.LoadBalancePay();
            }
        }

        /// <summary>初始化余额支付数据</summary>
        private void LoadBalancePay()
        {
            this.numPayBalance.Value = this._objPay.Money;
            this.numPayMoney.Value = 0;
            this.txtCash.Text = "0.00";

            this.numPayMoney.Minimum = 0;

            this.numPayBalance.Enabled = false;
            this.numPayMoney.Enabled = false;
            this.txtCash.ReadOnly = true;
        }

        /// <summary>现金+余额</summary>
        private void rbtnAnd_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbtnAnd.Checked)
            {
                this.LoadCashPay();
                this.numPayBalance.Enabled = true;
                this.numPayMoney.Enabled = true;
                this.txtCash.ReadOnly = false;

                if (this._objPay.Member.Balance < this._objPay.Money)
                {
                    this.numPayBalance.Maximum = this._objPay.Member.Balance;
                    this.numPayMoney.Minimum = this._objPay.Money - this._objPay.Member.Balance;
                }
                else
                {
                    this.numPayBalance.Maximum = this._objPay.Money;
                }
                this.numPayMoney.Maximum = this._objPay.Money;
            }
        }

        #endregion

        /// <summary>确定</summary>
        private void btnOK_Click(object sender, EventArgs e)
        {
            Pays objPay = new Pays();
            objPay.PayID = this._objPay.PayID;
            objPay.Cash = decimal.Parse(this.txtCash.Text.Trim());//实收金额
            objPay.Zero = this._dZero;// (decimal.Parse(this.txtCash.Text.Trim()) - this.numPayMoney.Value).ToString("f2");
            objPay.Remark = "";
            if (this.rbtnCash.Checked)
            {
                objPay.PayType = 0;//现金
            }
            else if (this.rbtnBalance.Checked || this.rbtnAnd.Checked)
            {
                objPay.PayType = 1;//余额
            }
            //判断现金消费
            if (objPay.Cash < this.numPayMoney.Value)
            {
                MessageBox.Show("【实收金额】必须大于等于【应收金额】", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtCash.Focus();
                return;
            }
            if (this.rbtnAnd.Checked)
            {
                objPay.Remark = "\n[现金+余额]现金：" + this.numPayMoney.Value.ToString("f2") + "；刷卡：" + this.numPayBalance.Value.ToString("f2") + "；";
                Deposit objDeposit = new Deposit();
                objDeposit.Remark = "[现金+余额]现金：" + this.numPayMoney.Value.ToString("f2") + "；刷卡：" + this.numPayBalance.Value.ToString("f2") + "；消费单号：" + this._objPay.PayID;
                objDeposit.Mode = 0;
                objDeposit.MemberID = this._objPay.MemberId;
                objDeposit.Money = this.numPayMoney.Value;
                objDeposit.Date = this._objPay.PayDate;
                objDeposit.InsertDeposit();
            }
            if (objPay.UpdatePaysOK() > 0)
            {
                new Member().UpdateBalance(this._objPay.MemberId);
                new Member().UpdateLastTime(this._objPay.MemberId, this._objPay.PayDate);
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        #region 计算找零金额...

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            this.FindZeroCash();
        }

        private void txtCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericClass.NumberAccpter(sender, e, true);
        }

        /// <summary>计算找零。</summary>
        private void FindZeroCash()
        {
            decimal dCash = 0;
            if (this.txtCash.Text.Trim() != "")
            {
                dCash = decimal.Parse(this.txtCash.Text.Trim());
            }
            else
            {
                this.txtCash.Text = "0";
                this.txtCash.SelectionStart = this.txtCash.Text.Length;
            }
            this._dZero = dCash - this.numPayMoney.Value;
            if (this.rbtnBalance.Checked)
            {
                this._dZero = 0;
            }
            this.lblZero.Text = "￥" + this._dZero.ToString("f2");
        }

        #endregion

        /// <summary>取消关闭窗体。</summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numPayBalance_ValueChanged(object sender, EventArgs e)
        {
            this.numPayMoney.Value = this._objPay.Money - this.numPayBalance.Value;
            this.txtCash.Text = this.numPayMoney.Value.ToString("f2");
            this.FindZeroCash();
        }
        
        ///// <summary>变更刷卡金额</summary>
        //private void numPayBalance_KeyUp(object sender, KeyEventArgs e)
        //{
        //    this.numPayMoney.Value = this._objPay.Money - this.numPayBalance.Value;
        //    this.FindZeroCash();
        //}

        private void numPayMoney_ValueChanged(object sender, EventArgs e)
        {
            this.numPayBalance.Value = this._objPay.Money - this.numPayMoney.Value;
            this.FindZeroCash();
        }

        private void numPayMoney_KeyUp(object sender, KeyEventArgs e)
        {
            this.numPayBalance.Value = this._objPay.Money - this.numPayMoney.Value;
            this.FindZeroCash();
        }
    }
}

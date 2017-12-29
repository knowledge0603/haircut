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
    public partial class frmCard : Form
    {
        private int m_cardId = 0;

        public frmCard()
        {
            InitializeComponent();
            this.Text = "新增会员卡类型";
        }

        public frmCard(int cardid)
        {
            InitializeComponent();
            this.Text = "修改会员卡类型";
            this.m_cardId = cardid;
        }

        private void frmCard_Load(object sender, EventArgs e)
        {
            if (this.m_cardId > 0)
            {
                Card objCard = new Card(this.m_cardId);
                this.txtName.Text = objCard.CardName;
                this.numDiscount.Value = decimal.Parse(objCard.Discount.ToString());
                this.numMoney.Value = decimal.Parse(objCard.Money.ToString());
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Card objCard = new Card();
            objCard.CardName = this.txtName.Text.Trim();
            objCard.Discount = double.Parse(this.numDiscount.Value.ToString());
            objCard.Money = this.numMoney.Value;

            int iTempId = objCard.ExistsCardName(objCard.CardName);
            if (this.m_cardId > 0)
            {
                objCard.CardId = this.m_cardId;
                if (iTempId > 0 && iTempId != this.m_cardId)
                {
                    MessageBox.Show("已经存在同名会员卡类型，请重新输入！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtName.Focus();
                    return;
                }
                objCard.UpdateCard();
            }
            else
            {
                if (iTempId > 0)
                {
                    MessageBox.Show("已经存在同名会员卡类型，请重新输入！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtName.Focus();
                    return;
                }
                objCard.InsertCard();//添加
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

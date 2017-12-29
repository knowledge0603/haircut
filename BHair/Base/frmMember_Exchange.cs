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
    public partial class frmMember_Exchange : Form
    {
        private string _strMemberId = "";
        private Member _objMember = null;

        public frmMember_Exchange(string memberid)
        {
            InitializeComponent();
            this._strMemberId = memberid;
            this._objMember = new Member(this._strMemberId);
        }

        private void frmMember_Exchange_Load(object sender, EventArgs e)
        {
            Member objMember = this._objMember;
            this.lblOldID.Text = objMember.ID;
            this.lblName.Text = objMember.Name;
            this.lblCardID.Text = objMember.Card.CardName;
            this.lblBalance.Text = "￥" + objMember.Balance.ToString("f2");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strNewId = this.txtNewID.Text.Trim();
            if (strNewId == "")
            {
                MessageBox.Show("【新卡号】不能为空，请输入。", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtNewID.Focus();
                return;
            }
            if (strNewId == this._strMemberId)
            {
                MessageBox.Show("【新卡号】与当前卡号一致，请重新输入。", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtNewID.Focus();
                return;
            }
            if (this._objMember.ExistsMemberCard(strNewId) != "")
            {
                MessageBox.Show("已经存在相同会员卡号，请输重新输入！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtNewID.Focus();
                return;
            }
            if (this._objMember.UpdateExchange(this._objMember, strNewId))
            {
                DialogResult = DialogResult.OK;
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

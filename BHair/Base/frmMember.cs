using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BHair.Business.BaseData;
using BHair.Business;
using XLuSharpLibrary.CommonFunction;

namespace BHair.Base
{
    public partial class frmMember : Form
    {
        private string m_strMemberId = "";
        private bool m_bRun = false;

        /// <summary>新增会员信息。</summary>
        public frmMember()
        {
            InitializeComponent();
            this.Text = "新增会员信息";
        }

        /// <summary>编辑会员信息。</summary>
        /// <param name="memberid">会员编号(ID)</param>
        public frmMember(string memberid)
        {
            InitializeComponent();
            this.Text = "编辑会员信息";
            this.lblBalance.Text = "卡内余额：";
            this.numBalance.Enabled = false;
            this.numBalance.BackColor = Color.White;
            this.m_strMemberId = memberid;
        }

        #region 初化基础数据。

        /// <summary>初始化基础数据。</summary>
        private void LoadData()
        {
            this.cboStatus.SelectedIndex = 0;//状态
            this.LoadCard();//会员等级
            this.cboSex.SelectedIndex = 0;//性别
            this.LoadMonth();//生日
            this.dtpJoin.Value = DateTime.Now.Date;//加入日期
        }

        /// <summary>加载会员卡类型。</summary>
        private void LoadCard()
        {
            List<Card> lstCard = new Card().SelectList(0);
            this.cboLevel.DataSource = lstCard;
            this.cboLevel.ValueMember = "CardId";
            this.cboLevel.DisplayMember = "CardName";
            this.cboLevel.SelectedIndex = 0;
        }

        #region 加载生日...

        /// <summary>加载月份</summary>
        private void LoadMonth()
        {
            this.cboMonth.Items.Clear();
            this.cboMonth.Items.Add("");
            for (int i = 1; i <= 12; i++)
            {
                this.cboMonth.Items.Add(i.ToString());
            }
            this.cboMonth.SelectedIndex = 0;
        }

        /// <summary>加载日</summary>
        /// <param name="m">月</param>
        private void LoadDay(int m)
        {
            this.cboDay.Items.Clear();
            int d = 31;
            if (m == 2)
            {
                d = 29;
            }
            else if (m == 4 || m == 6 || m == 9 || m == 11)
            {
                d = 30;
            }
            for (int i = 1; i <= d; i++)
            {
                this.cboDay.Items.Add(i.ToString());
            }
        }

        #endregion

        /// <summary>加载会员生日(日)</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboMonth.Text == "")
            {
                this.cboDay.Items.Clear();
                return;
            }
            this.LoadDay(int.Parse(this.cboMonth.Text));
            this.cboDay.SelectedIndex = 0;
        }

        /// <summary>加载初始金额</summary>
        private void cboLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.m_bRun)
            {
                Card objCard = new Card(int.Parse(this.cboLevel.SelectedValue.ToString()));
                this.numBalance.Value = objCard.Money;
            }
        }

        #endregion

        private void frmMember_Load(object sender, EventArgs e)
        {
            this.LoadData();//初始化基础数据
            if (this.m_strMemberId != "")
            {
                this.LoadMember();//加载会员信息
            }
            this.m_bRun = true;
        }

        /// <summary>加载会员信息。</summary>
        private void LoadMember()
        {
            Member objMember = new Member(this.m_strMemberId);
            this.txtCard.Text = objMember.ID;
            this.txtName.Text = objMember.Name;
            this.cboStatus.SelectedIndex = objMember.Status;
            this.cboLevel.SelectedValue = objMember.CardID;
            this.numBalance.Value = objMember.Balance;
            this.txtPassword.Text = "0";
            this.txtRemark.Text = objMember.Remark;
            this.cboSex.SelectedIndex = objMember.Sex;
            this.cboMonth.Text = objMember.Month.ToString();
            this.cboDay.Text = objMember.Day.ToString();
            this.txtPhone.Text = objMember.Phone;
            this.txtAddress.Text = objMember.Address;
            this.txtOther.Text = objMember.Other;
            this.dtpJoin.Value = objMember.JoinDate;
            this.numBalance.Value = objMember.Balance;
            this.txtIDCard.Text = objMember.IDCard;
        }

        /// <summary>保存会员信息</summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtCard.Text.Trim() == "")
            {
                MessageBox.Show("【会员卡号】不能为空，请输入！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtCard.Focus();
                return;
            }

            Member objMember = new Member();
            objMember.ID = this.txtCard.Text;
            objMember.Name = this.txtName.Text.Trim();
            if (objMember.Name == "")
            {
                objMember.Name = "散客会员";
            }
            objMember.Status = this.cboStatus.SelectedIndex;
            objMember.CardID = int.Parse(this.cboLevel.SelectedValue.ToString());
            objMember.Password = PasswordClass.EncryptMD5(this.txtPassword.Text.Trim());
            objMember.Remark = this.txtRemark.Text.Trim();
            objMember.Sex = this.cboSex.SelectedIndex;
            if (this.cboMonth.Text == "")
            {
                objMember.Month = 0;
            }
            else
            {
                objMember.Month = int.Parse(this.cboMonth.Text);
            }
            if (this.cboDay.Text == "")
            {
                objMember.Day = 0;
            }
            else
            {
                objMember.Day = int.Parse(this.cboDay.Text);
            }
            objMember.Phone = this.txtPhone.Text;
            objMember.Address = this.txtAddress.Text.Trim();
            objMember.Other = this.txtOther.Text.Trim();
            objMember.JoinDate = this.dtpJoin.Value;
            objMember.IDCard = this.txtIDCard.Text.Trim();
            string strTempId = objMember.ExistsMemberCard(objMember.ID);
            if (this.m_strMemberId != "")
            {
                objMember.ID = this.m_strMemberId;
                if (strTempId != "" && strTempId != this.m_strMemberId)
                {
                    MessageBox.Show("已经存在相同会员卡号，请输重新输入！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtCard.Focus();
                    return;
                }
                objMember.UpdateMember();
            }
            else
            {
                if (strTempId != "")
                {
                    MessageBox.Show("已经存在相同会员卡号，请输重新输入！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtCard.Focus();
                    return;
                }
                objMember.InsertMember();
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>取消</summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericClass.NumberAccpter(sender, e, false);
        }

        private void txtIDCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericClass.NumberAccpter(sender, e, false);
        }
    }
}

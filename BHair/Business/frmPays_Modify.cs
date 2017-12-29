using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BHair.Business;
using BHair.Business.Table;
using XLuSharpLibrary.CommonFunction;
using BHair.Business.BaseData;

namespace BHair.Business
{
    public partial class frmPays_Modify : Form
    {
        private string _strPayId = "";
        private Pays _objPay = null;

        public frmPays_Modify(string payid)
        {
            InitializeComponent();
            this._strPayId = payid;
            StaticValue.g_dBonus = 1;
            StaticValue.g_lstTempPayDetails = new List<PayDetail>();
        }

        private void frmPays_Modify_Load(object sender, EventArgs e)
        {
            this.LoadAllEmployee();

            this._objPay = new Pays(this._strPayId);
            this.txtCode.Text = this._objPay.PayID;
            if (this._objPay.MemberId != "0")//获取会员信息
            {
                this.txtClient.Text = this._objPay.MemberId;
                StaticValue.g_dBonus = this._objPay.Member.Card.Discount;//获取该会员消费折扣
            }
            this.cboEmp1.SelectedValue = this._objPay.EmpID1;
            this.cboEmp2.SelectedValue = this._objPay.EmpID2;
            this.cboEmp3.SelectedValue = this._objPay.EmpID3;
            this.txtRemark.Text = this._objPay.Remark;
            this.dtpPayDate.Value = this._objPay.PayDate;

            if (this._objPay.Status == 1)
            {
                this.Text += " - 已结算";
                this.txtClient.ReadOnly = true;
                this.txtClient.BackColor = Color.White;
                this.btnAdd.Enabled = false;
                this.btnDelete.Enabled = false;
                this.cmnuDetails_Bonus.Enabled = false;
                this.btnOk.Visible = false;
            }

            StaticValue.g_lstTempPayDetails.AddRange(this._objPay.PayDetails);

            this.LoadPayDetails();
        }

        #region 加载员工信息...

        private void LoadAllEmployee()
        {
            this.LoadEmployee1();
            this.LoadEmployee2();
            this.LoadEmployee3();
        }

        /// <summary>加载员工信息</summary>
        private void LoadEmployee1()
        {
            List<Employee> lstEmployee = new Employee().SelectList(0, 1);
            foreach (Employee obj in lstEmployee)
            {
                obj.Name = obj.Code + "." + obj.Name + " [" + obj.Post.Name + "]";
            }
            Employee objEmp = new Employee();
            objEmp.ID = 0;
            objEmp.Name = "";
            lstEmployee.Insert(0, objEmp);
            this.cboEmp1.DataSource = lstEmployee;
            this.cboEmp1.ValueMember = "ID";
            this.cboEmp1.DisplayMember = "Name";
            this.cboEmp1.SelectedIndex = 0;
        }

        /// <summary>加载员工信息</summary>
        private void LoadEmployee2()
        {
            List<Employee> lstEmployee = new Employee().SelectList(0, 1);
            foreach (Employee obj in lstEmployee)
            {
                obj.Name = obj.Code + "." + obj.Name + " [" + obj.Post.Name + "]";
            }
            Employee objEmp = new Employee();
            objEmp.ID = 0;
            objEmp.Name = "";
            lstEmployee.Insert(0, objEmp);
            this.cboEmp2.DataSource = lstEmployee;
            this.cboEmp2.ValueMember = "ID";
            this.cboEmp2.DisplayMember = "Name";
            this.cboEmp2.SelectedIndex = 0;
        }

        /// <summary>加载员工信息</summary>
        private void LoadEmployee3()
        {
            List<Employee> lstEmployee = new Employee().SelectList(0, 1);
            foreach (Employee obj in lstEmployee)
            {
                obj.Name = obj.Code + "." + obj.Name + " [" + obj.Post.Name + "]";
            }
            Employee objEmp = new Employee();
            objEmp.ID = 0;
            objEmp.Name = "";
            lstEmployee.Insert(0, objEmp);
            this.cboEmp3.DataSource = lstEmployee;
            this.cboEmp3.ValueMember = "ID";
            this.cboEmp3.DisplayMember = "Name";
            this.cboEmp3.SelectedIndex = 0;
        }

        #endregion

        #region 加载消费明细...

        /// <summary>加载消费明细</summary>
        private void LoadPayDetails()
        {
            List<PayDetail> lstPayDetail = StaticValue.g_lstTempPayDetails;
            this.dgvPayDetails.AutoGenerateColumns = false;
            this.dgvPayDetails.Rows.Clear();
            decimal dSum = 0;
            decimal dSubtract = 0;//优惠
            foreach (PayDetail objDetail in lstPayDetail)
            {
                dSum += objDetail.Sum;
                dSubtract += (objDetail.SPItem.UnitPrice - objDetail.Money) * objDetail.Number;
                this.dgvPayDetails.Rows.Add(new object[] { objDetail.DetailID, objDetail.SPItem.ID, objDetail.SPItem.Name, objDetail.SPItem.UnitPrice, objDetail.Bonus, objDetail.Money, objDetail.Number, objDetail.Sum });
            }
            this.lblSum.Text = dSum.ToString("f2");
            this.lblSubtract.Text = dSubtract.ToString("f2");
            this.label17.Text = "本次消费应收金额：￥" + dSum.ToString("f2");
            this.numMoney.Value = dSum;
        }

        #endregion

        private void txtClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericClass.NumberAccpter(sender, e, false);
        }

        

        /// <summary>显示行号</summary>
        private void dgvPayDetails_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            StaticValue.ShowRows_DataGridView_RowPostPaint(this.dgvPayDetails, sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dgvPayDetails_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo rows = this.dgvPayDetails.HitTest(e.X, e.Y);
            if (e.Button == MouseButtons.Right)
            {
                if (rows.RowIndex > -1 && rows.ColumnIndex > -1)
                {
                    //定位
                    this.dgvPayDetails.ClearSelection();
                    this.dgvPayDetails.Rows[rows.RowIndex].Selected = true;
                    this.dgvPayDetails.CurrentCell = this.dgvPayDetails.Rows[rows.RowIndex].Cells[rows.ColumnIndex];
                    if (this._objPay.Status == 1 || StaticValue.g_lstTempPayDetails[rows.RowIndex].SPItem.IsBonus == 1)
                    {
                        this.cmnuDetails_Bonus.Enabled = false;
                    }
                    else if (this._objPay.Status == 0)
                    {
                        this.cmnuDetails_Bonus.Enabled = true;
                    }
                }
                else
                {
                    this.cmnuDetails_Bonus.Enabled = false;
                }
            }
        }

        /// <summary>新增消费商品</summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmSelectItems objfrmSelectItems = new frmSelectItems(this._strPayId);
            if (objfrmSelectItems.ShowDialog() == DialogResult.OK)
            {
                this.LoadPayDetails();
            }
        }

        /// <summary>删除已选择商品</summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvPayDetails.CurrentRow != null)
            {
                int iIndex = this.dgvPayDetails.CurrentRow.Index;
                StaticValue.g_lstTempPayDetails.RemoveAt(iIndex);
                this.LoadPayDetails();
            }
        }

        #region 验证数据...

        /// <summary>验证数据</summary>
        private bool ValidateData()
        {
            if (this.txtCode.Text.Trim() == "")
            {
                MessageBox.Show("消费单号不能为空，请输入！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtCode.Focus();
                return false;
            }

            if (this.txtClient.Text.Trim() != "" && StaticValue.ValidateMember(this.txtClient.Text.Trim()) == "")
            {
                MessageBox.Show("会员卡号不正确，该卡号不存在。", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtClient.Focus();
                return false;
            }
            if (this.txtClient.Text.Trim() != "" && new Member(this.txtClient.Text.Trim()).Status == 1)
            {
                MessageBox.Show("当前会员卡已停用，请重新指定。", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtClient.Focus();
                return false;
            }

            if (this.cboEmp1.SelectedIndex == 0 && this.cboEmp2.SelectedIndex == 0 && this.cboEmp3.SelectedIndex == 0)
            {
                MessageBox.Show("未指派服务人员！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cboEmp1.Focus();
                return false;
            }
            if (this.dgvPayDetails.RowCount == 0)
            {
                MessageBox.Show("未选择消费项目！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.btnAdd.Focus();
                return false;
            }
            return true;
        }

        #endregion

        /// <summary>保存消费单据，</summary>
        private void Save_Click()
        {
            this._objPay.MemberId = this.txtClient.Text.Trim();
            if (this._objPay.MemberId == "")
            {
                this._objPay.MemberId = "0";
            }
            this._objPay.EmpID1 = int.Parse(this.cboEmp1.SelectedValue.ToString());
            this._objPay.EmpID2 = int.Parse(this.cboEmp2.SelectedValue.ToString());
            this._objPay.EmpID3 = int.Parse(this.cboEmp3.SelectedValue.ToString());
            this._objPay.Money = this.numMoney.Value;
            this._objPay.Remark = this.txtRemark.Text.Trim();
            DateTime dtTemp = DateTime.Parse(this.dtpPayDate.Value.Date.ToShortDateString() + " " + DateTime.Now.ToLongTimeString());
            if (this._objPay.PayDate != dtTemp)
            {
                this._objPay.PayDate = dtTemp;
            }
            if (this._objPay.UpdatePay() > 0)
            {
                if (this._objPay.PayDetails.Count == 0)
                {
                    foreach (PayDetail objDetail in StaticValue.g_lstTempPayDetails)
                    {
                        objDetail.InsertDetail();
                    }
                }
                else if (this._objPay.PayDetails.Count > 0)
                {
                    foreach (PayDetail objOldDetail in this._objPay.PayDetails)
                    {
                        objOldDetail.DeleteDetail(objOldDetail.DetailID);
                    }
                    foreach (PayDetail objNewDetail in StaticValue.g_lstTempPayDetails)
                    {
                        objNewDetail.InsertDetail();
                    }
                }
            }
        }

        private bool ContrastNewToOld(int itemid)
        {
            foreach (PayDetail objOldDetail in this._objPay.PayDetails)
            {
                if (itemid == objOldDetail.ItemID)
                {
                    return true;//存在
                }
            }
            return false;//不存在
        }

        private bool ContrastOldToNew(int itemid)
        {
            foreach (PayDetail objOldDetail in this._objPay.PayDetails)
            {
                if (itemid == objOldDetail.ItemID)
                {
                    return true;//存在
                }
            }
            return false;//不存在
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!this.ValidateData())
            {
                return;
            }
            this.Save_Click();
            new frmPay_OK(this._strPayId).ShowDialog();
            DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>获取会员信息</summary>
        private void txtClient_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Member objMember = new Member(this.txtClient.Text.Trim());
                this.lblMemName.Text = objMember.Name + "[" + objMember.Card.CardName + "]";
                if (objMember.Status == 1)
                {
                    this.lblMemName.Text += "(" + objMember.StatusText + ")";
                }
                this.lblMemBalance.Text = "￥" + objMember.Balance.ToString("f2");
                this.lblLastTime.Text = objMember.LastDeposit;
                StaticValue.g_dBonus = objMember.Card.Discount;//会员折扣
            }
            catch
            {
                this.lblMemName.Text = "【非会员】散客";
                this.lblMemBalance.Text = "￥0.00";
                this.lblLastTime.Text = "无记录";
                StaticValue.g_dBonus = 1;//还原折扣
            }
            this.UpdatePayBonus(StaticValue.g_dBonus);
            this.LoadPayDetails();
        }

        /// <summary>更新消费折扣</summary>
        /// <param name="bonus"></param>
        private void UpdatePayBonus(double bonus)
        {
            for (int i = 0; i < StaticValue.g_lstTempPayDetails.Count; i++)
            {
                if (StaticValue.g_lstTempPayDetails[i].SPItem.IsBonus == 1)
                {
                    StaticValue.g_lstTempPayDetails[i].Bonus = 1;
                    StaticValue.g_lstTempPayDetails[i].Money = StaticValue.g_lstTempPayDetails[i].SPItem.UnitPrice;
                }
                else
                {
                    StaticValue.g_lstTempPayDetails[i].Bonus = bonus;
                    //计算折后单价(四舍五入)
                    StaticValue.g_lstTempPayDetails[i].Money = decimal.Parse((StaticValue.g_lstTempPayDetails[i].SPItem.UnitPrice * decimal.Parse(bonus.ToString())).ToString("f0"));
                }
            }
        }

        private void cmnuDetails_Bonus_Click(object sender, EventArgs e)
        {
            int iIndex = this.dgvPayDetails.CurrentRow.Index;
            frmPayDetail_Bonus objfrmPayDetailBonus = new frmPayDetail_Bonus(iIndex);
            if (objfrmPayDetailBonus.ShowDialog() == DialogResult.OK)
            {
                this.LoadPayDetails();
            }
        }
    }
}

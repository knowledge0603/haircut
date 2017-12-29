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
    public partial class frmPays_Add : Form
    {
        public frmPays_Add()
        {
            InitializeComponent();

            StaticValue.g_lstTempPayDetails = new List<PayDetail>();
            StaticValue.g_dBonus = 1;
            StaticValue.g_strNewPayId = "";
        }

        /// <summary>只能输入数字</summary>
        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericClass.NumberAccpter(sender, e, false);
        }

        /// <summary>只能输入数字</summary>
        private void txtClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericClass.NumberAccpter(sender, e, false);
        }

        /// <summary>显示行号</summary>
        private void dgvPayDetails_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            StaticValue.ShowRows_DataGridView_RowPostPaint(this.dgvPayDetails, sender, e);
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
            decimal dSum = 0;//合计
            decimal dSubtract = 0;//优惠
            foreach (PayDetail objDetail in lstPayDetail)
            {
                dSum += objDetail.Sum;
                dSubtract += (objDetail.SPItem.UnitPrice - objDetail.Money) * objDetail.Number;
                this.dgvPayDetails.Rows.Add(new object[] { objDetail.SPItem.ID, objDetail.SPItem.Name, objDetail.SPItem.UnitPrice, objDetail.Bonus, objDetail.Money, objDetail.Number, objDetail.Sum });
            }
            this.lblSum.Text = dSum.ToString("f2");
            this.lblSubtract.Text = dSubtract.ToString("f2");
            this.label17.Text = "本次消费应收金额：￥" + dSum.ToString("f2");
            this.numMoney.Value = dSum;
        }

        #endregion

        private void frmPays_Add_Load(object sender, EventArgs e)
        {
            this.dtpPayDate.Value = DateTime.Now;
            this.LoadAllEmployee();
            this.LoadPayDetails();
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

        /// <summary>选择消费商品</summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmSelectItems objfrmSelectItems = new frmSelectItems();
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
            if (new Pays().ExistsPayCode(this.txtCode.Text.Trim()) != "")
            {
                MessageBox.Show("消费单号【" + this.txtCode.Text.Trim() + "】已经存在，请重新输入！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private string Save_Click()
        {
            Pays objPay = new Pays();
            if (this.ValidateData())
            {
                objPay.PayID = this.txtCode.Text.Trim();
                objPay.MemberId = this.txtClient.Text.Trim();
                if (objPay.MemberId == "")
                {
                    objPay.MemberId = "0";
                }
                objPay.EmpID1 = int.Parse(this.cboEmp1.SelectedValue.ToString());
                objPay.EmpID2 = int.Parse(this.cboEmp2.SelectedValue.ToString());
                objPay.EmpID3 = int.Parse(this.cboEmp3.SelectedValue.ToString());
                objPay.Money = this.numMoney.Value;
                objPay.Remark = this.txtRemark.Text.Trim();
                objPay.PayDate = DateTime.Parse(this.dtpPayDate.Value.Date.ToShortDateString() + " " + DateTime.Now.ToLongTimeString());
                if (objPay.InsertPay() > 0)//新增消费单据
                {
                    foreach (PayDetail objDetail in StaticValue.g_lstTempPayDetails)
                    {
                        objDetail.PayID = objPay.PayID;
                        objDetail.InsertDetail();
                    }
                }
                return objPay.PayID;
            }
            return "";
        }

        /// <summary>保存单据，挂单</summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Save_Click();//保存数据
            DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>保存单据，结算</summary>
        private void btnOk_Click(object sender, EventArgs e)
        {
            string strPayId = this.Save_Click();//保存数据
            if (strPayId != "")
            {
                frmPay_OK objfrmPayOK = new frmPay_OK(strPayId);
                objfrmPayOK.ShowDialog();
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>修改折扣/价格</summary>
        private void cmnuDetails_Bonus_Click(object sender, EventArgs e)
        {
            int iIndex = this.dgvPayDetails.CurrentRow.Index;
            frmPayDetail_Bonus objfrmPayDetailBonus = new frmPayDetail_Bonus(iIndex);
            if (objfrmPayDetailBonus.ShowDialog() == DialogResult.OK)
            {
                this.LoadPayDetails();
            }
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

                    if (StaticValue.g_lstTempPayDetails[rows.RowIndex].SPItem.IsBonus == 1)
                    {
                        this.cmnuDetails_Bonus.Enabled = false;
                    }
                    else
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
    }
}

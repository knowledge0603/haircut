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
    public partial class frmEmployee : Form
    {
        private int m_iEmpId = 0;
        private string m_strDoPost = "NewAdd";
        private bool m_bRun = false;

        public frmEmployee()
        {
            InitializeComponent();
        }

        /// <summary>员工信息</summary>
        /// <param name="empid">员工编号(ID)</param>
        public frmEmployee(int empid)
        {
            InitializeComponent();
            this.m_iEmpId = empid;
            this.Text = "修改员工信息";
            this.m_strDoPost = "Modify";
            this.cboStatus.Items.Add("离职");
        }

        /// <summary>初始数据。</summary>
        private void LoadData()
        {
            this.LoadPostList();
            this.cboStatus.SelectedIndex = 0;
            this.dtpInput.Value = DateTime.Now.Date;
            this.dtpOutput.Value = DateTime.Now.Date;
            this.cboSex.SelectedIndex = 0;
        }

        /// <summary>加载职位信息列表。</summary>
        private void LoadPostList()
        {
            List<Post> lstPost = new Post().SelectList();
            Post objPost = new Post();
            objPost.ID = 0;
            objPost.Name = "";
            lstPost.Insert(0, objPost);
            this.cboPost.DataSource = lstPost;
            this.cboPost.ValueMember = "ID";
            this.cboPost.DisplayMember = "Name";
            //this.cboPost.SelectedIndex = 0;
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            this.LoadData();
            if (this.m_iEmpId > 0)
            {
                Employee objEmp = new Employee(this.m_iEmpId);
                
                this.txtCode.Text = objEmp.Code.ToString();
                this.txtName.Text = objEmp.Name;
                this.cboSex.SelectedIndex = objEmp.Sex;
                this.txtPhone.Text = objEmp.Phone;
                this.cboPost.SelectedValue = objEmp.PostId;
                this.numSalary.Value = objEmp.Salary;
                this.numBonus.Value = decimal.Parse(objEmp.Bonus.ToString());
                this.dtpInput.Value = DateTime.Parse(objEmp.Input);
                this.cboStatus.SelectedIndex = objEmp.Status;
                this.txtRemark.Text = objEmp.Remark;
                this.txtAddress.Text = objEmp.Address;
                this.txtCard.Text = objEmp.CardNumber;
                this.txtMobile.Text = objEmp.Mobile;
                
                //员工状态为3离职时禁止修改
                if (objEmp.Status == 3)
                {
                    this.btnOk.Visible = false;
                    this.btnReset.Visible = false;
                    this.Text = "员工信息";
                    this.btnCancel.Text = "关闭(&C)";

                    this.dtpOutput.Visible = true;
                    this.dtpOutput.Value = DateTime.Parse(objEmp.Output);
                }
            }
            this.m_bRun = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.txtCode.Text == "")
            {
                MessageBox.Show("员工工号不能为空，请输入！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtCode.Focus();
                return;
            }
            if (this.txtName.Text == "")
            {
                MessageBox.Show("员工姓名不能为空，请输入！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtName.Focus();
                return;
            }

            if (this.cboPost.SelectedIndex == 0)
            {
                MessageBox.Show("必须为员工指定一个职位！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.cboPost.Focus();
                return;
            }
            if (this.txtMobile.Text == "")
            {
                MessageBox.Show("手机不能为空，请输入！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtMobile.Focus();
                return;
            }
            Employee objEmp = new Employee();
            objEmp.Code = int.Parse(this.txtCode.Text);
            objEmp.Name = this.txtName.Text.Trim();
            objEmp.Sex = this.cboSex.SelectedIndex;
            objEmp.Phone = this.txtPhone.Text.Trim();
            objEmp.PostId = int.Parse(this.cboPost.SelectedValue.ToString());
            objEmp.Salary = this.numSalary.Value;
            objEmp.Bonus = double.Parse(this.numBonus.Value.ToString());
            objEmp.Input = this.dtpInput.Value.ToShortDateString();
            if (this.m_strDoPost == "Modify" && this.m_bRun)
            {
                objEmp.Output = this.dtpOutput.Value.ToShortDateString();
            }
            else
            {
                objEmp.Output = "";
            }
            objEmp.Status = this.cboStatus.SelectedIndex;
            objEmp.Remark = this.txtRemark.Text.Trim();
            objEmp.Address = this.txtAddress.Text.Trim();
            objEmp.Mobile = this.txtMobile.Text.Trim();
            objEmp.CardNumber = this.txtCard.Text.Trim();

            int iTempId = objEmp.ExistsEmployeeCode(objEmp.Code);
            if (this.m_iEmpId > 0)
            {
                //更新数据
                objEmp.ID = this.m_iEmpId;
                if (iTempId > 0 && iTempId != this.m_iEmpId)
                {
                    MessageBox.Show("在职员工列表中已经存在相同工号。\n请为该员工指定一个唯一工号。", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtCode.Focus();
                    return;
                }
                objEmp.UpdateEmployee();
            }
            else
            {
                if (iTempId > 0)
                {
                    MessageBox.Show("在职员工列表中已经存在相同工号。\n请为该员工指定一个唯一工号。", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtCode.Focus();
                    return;
                }
                objEmp.InsertEmployee();
            }

            DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>取消/关闭</summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>获取职位初始值</summary>
        private void cboPost_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.m_strDoPost == "NewAdd" && this.m_bRun)
            {
                int iPostId = int.Parse(this.cboPost.SelectedValue.ToString());
                Post objPost = new Post(iPostId);
                this.numSalary.Value = objPost.Salary;
                this.numBonus.Value = decimal.Parse(objPost.Bonus.ToString());
            }
        }

        /// <summary>状态</summary>
        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.m_strDoPost == "Modify" && this.m_bRun)
            {
                //离职
                if (this.cboStatus.SelectedIndex == 3)
                {
                    this.dtpOutput.Visible = true;
                }
                else
                {
                    this.dtpOutput.Visible = false;
                }
            }
        }
    }
}

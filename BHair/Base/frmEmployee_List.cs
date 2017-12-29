using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BHair.Business.BaseData;
using BHair.Business;

namespace BHair.Base
{
    public partial class frmEmployee_List : WinFormsUI.Docking.DockContent
    {
        public frmEmployee_List()
        {
            InitializeComponent();
        }

        private void frmEmployee_List_Load(object sender, EventArgs e)
        {
            this.LoadPostList();//加载职位列表
            this.LoadEmployeeList();//加载员工信息
        }

        #region 职位操作...

        /// <summary>加载职位列表</summary>
        private void LoadPostList()
        {
            this.tvwPost.Nodes.Clear();
            List<Post> lstPost = new Post().SelectList();
            TreeNode objTreeNode = new TreeNode();
            objTreeNode.Name = "0";
            objTreeNode.Text = "显示全部";
            foreach (Post obj in lstPost)
            {
                objTreeNode.Nodes.Add(obj.ID.ToString(), obj.Name);
            }
            this.tvwPost.Nodes.Add(objTreeNode);
            this.tvwPost.ExpandAll();
        }

        /// <summary>新增职位</summary>
        private void cmnuPost_Add_Click(object sender, EventArgs e)
        {
            frmPost objfrmPost = new frmPost();
            if (objfrmPost.ShowDialog() == DialogResult.OK)
            {
                this.LoadPostList();
            }
        }

        /// <summary>修改职位</summary>
        private void cmnuPost_Modify_Click(object sender, EventArgs e)
        {
            int iPostId = int.Parse(this.tvwPost.SelectedNode.Name);
            frmPost objfrmPost = new frmPost(iPostId);
            if (objfrmPost.ShowDialog() == DialogResult.OK)
            {
                this.LoadPostList();
            }
        }

        /// <summary>删除职位</summary>
        private void cmnuPost_Delete_Click(object sender, EventArgs e)
        {
            Post objPost = new Post();
            int iPostId = int.Parse(this.tvwPost.SelectedNode.Name);
            if (MessageBox.Show("确实要删除选定的职位吗？", "消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (objPost.GetEmployeeNumber(iPostId) > 0)
                {
                    MessageBox.Show("删除失败，该职位下已经存在员工信息。", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    objPost.DeletePost(iPostId);
                    this.LoadPostList();
                }
            }
        }

        /// <summary>根据职位选择加载员工信息</summary>
        private void tvwPost_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.LoadEmployeeList();
        }

        private void tvwPost_MouseDown(object sender, MouseEventArgs e)
        {
            this.tvwPost.SelectedNode = this.tvwPost.GetNodeAt(e.X, e.Y);
            if (this.tvwPost.SelectedNode == null || this.tvwPost.SelectedNode.Name == "0")
            {
                this.cmnuPost_Modify.Enabled = false;
                this.cmnuPost_Delete.Enabled = false;
                return;
            }
            this.cmnuPost_Modify.Enabled = true;
            this.cmnuPost_Delete.Enabled = true;
        }

        #endregion

        #region 员工信息操作...

        /// <summary>加载员工信息</summary>
        private void LoadEmployeeList()
        {
            int postId = 0;
            if (this.tvwPost.SelectedNode != null)
            {
                postId = int.Parse(this.tvwPost.SelectedNode.Name);
            }
            int i = 1;//在职员工
            if (this.chkAll.Checked)
            {
                i = 0;//所有员工
            }
            List<Employee> lstEmployee = new Employee().SelectList(postId, i);
            this.dgvEmployee.AutoGenerateColumns = false;
            this.dgvEmployee.Rows.Clear();
            foreach (Employee objEmp in lstEmployee)
            {
                this.dgvEmployee.Rows.Add(new object[] { objEmp.ID, objEmp.Code, objEmp.Name, objEmp.SexText, objEmp.Post.Name, objEmp.Mobile, objEmp.Input, objEmp.StatusText, objEmp.Remark });
            }
        }

        private void dgvEmployee_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo rows = this.dgvEmployee.HitTest(e.X, e.Y);
            if (e.Button == MouseButtons.Right)
            {
                if (rows.RowIndex > -1 && rows.ColumnIndex > -1)
                {
                    //定位
                    this.dgvEmployee.ClearSelection();
                    this.dgvEmployee.Rows[rows.RowIndex].Selected = true;
                    this.dgvEmployee.CurrentCell = this.dgvEmployee.Rows[rows.RowIndex].Cells[rows.ColumnIndex];

                    this.cmnuEmployee_Modify.Enabled = true;
                    this.cmnuEmployee_Score.Enabled = true;
                }
                else
                {
                    this.cmnuEmployee_Modify.Enabled = false;
                    this.cmnuEmployee_Score.Enabled = false;
                }
            }
        }

        /// <summary>显示所有员工</summary>
        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            this.LoadEmployeeList();
        }

        /// <summary>新增</summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Emeloyee_Add_Click();
        }

        /// <summary>新增</summary>
        private void cmnuEmployee_Add_Click(object sender, EventArgs e)
        {
            this.Emeloyee_Add_Click();
        }

        /// <summary>新增</summary>
        private void Emeloyee_Add_Click()
        {
            frmEmployee objfrmEmployee = new frmEmployee();
            if (objfrmEmployee.ShowDialog() == DialogResult.OK)
            {
                this.LoadEmployeeList();
            }
        }

        /// <summary>修改</summary>
        private void ShowEmployee()
        {
            if (this.dgvEmployee.CurrentRow != null)
            {
                int iEmpId = int.Parse(this.dgvEmployee.CurrentRow.Cells[0].Value.ToString());
                frmEmployee objfrmEmployee = new frmEmployee(iEmpId);
                if (objfrmEmployee.ShowDialog() == DialogResult.OK)
                {
                    this.LoadEmployeeList();
                }
            }
        }

        /// <summary>修改</summary>
        private void btnModify_Click(object sender, EventArgs e)
        {
            this.ShowEmployee();
        }

        /// <summary>修改</summary>
        private void cmnuEmployee_Modify_Click(object sender, EventArgs e)
        {
            this.ShowEmployee();
        }

        /// <summary>修改</summary>
        private void dgvEmployee_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.ShowEmployee();
        }

        #endregion

        /// <summary>查看业绩</summary>
        private void cmnuEmployee_Score_Click(object sender, EventArgs e)
        {
            int iEmpId = int.Parse(this.dgvEmployee.CurrentRow.Cells[0].Value.ToString());
            frmPays_Employee objfrmPaysEmployee = new frmPays_Employee(iEmpId);
            objfrmPaysEmployee.ShowDialog();
        }

        private void dgvEmployee_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            StaticValue.ShowRows_DataGridView_RowPostPaint(this.dgvEmployee, sender, e);
        }

        /// <summary>奖扣款记录</summary>
        private void cmnuEmployee_Log_Click(object sender, EventArgs e)
        {
            int iEmpId = int.Parse(this.dgvEmployee.CurrentRow.Cells[0].Value.ToString());
            frmEmployee_Money objfrmEmployeeMoney = new frmEmployee_Money(iEmpId);
            objfrmEmployeeMoney.ShowDialog();
        }
    }
}

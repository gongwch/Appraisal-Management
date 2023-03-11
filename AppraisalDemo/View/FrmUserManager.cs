using AppraisalDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppraisalDemo
{
    public partial class FrmUserManager : Form
    {

        
        public FrmUserManager()
        {
            InitializeComponent();
        }

        private void FrmUserManager_Load(object sender, EventArgs e)
        {

            BindAppraisalBase();

            BindUserAppraisals();

            //cmbIdentity.

            /*            cmbIdentity.Items.Add("----Query----");
                        foreach (var item in appraisalBases)
                        {
                            cmbIdentity.Items.Add(item.BaseType);
                        }*/
        }

        private void BindUserAppraisals()
        {
            string userName = txtUserName.Text.Trim();
            int baseTypeId = (int)cmbIdentity.SelectedIndex;
            bool isSupend = chkSuspend.Checked;
            List<UserAppraisalBases> userAppraisalBases = UserAppraisalBases.GetUserAppraisalsTest();
            if (baseTypeId == 0)
            {
                dgvUserAppraisal.DataSource = userAppraisalBases.FindAll(m => m.UserName.Contains(userName) && m.IsDel == isSupend);

            }
            else
            {
                dgvUserAppraisal.DataSource = userAppraisalBases.FindAll(m => m.UserName.Contains(userName) && m.BaseTypeId == baseTypeId && m.IsDel == isSupend);

            }
        }

        private void BindAppraisalBase()
        {
            List<AppraisalBases> appraisalBases = new List<AppraisalBases>();
            appraisalBases.Add(new AppraisalBases() { Id = 0, BaseType = "--Query--", AppraisalBase = 0, IsDel = false });
            appraisalBases.AddRange(AppraisalBases.GetAllTest());
            cmbIdentity.DataSource = appraisalBases;
            cmbIdentity.DisplayMember = "BaseType";
            cmbIdentity.ValueMember = "Id";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindUserAppraisals();
        }

        private void dgvUserAppraisal_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                tsmiCreate.Visible = true;
                tsmiEdit.Visible = false;
                tsmiActivate.Visible = false;
                tsmiSuspend.Visible = false; 
            }
            

        }

        private void dgvUserAppraisal_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right)
            {
                if(e.RowIndex>-1)
                {
                    dgvUserAppraisal.Rows[e.RowIndex].Selected = true;
                    tsmiCreate.Visible = true;
                    bool isDel = (bool)dgvUserAppraisal.SelectedRows[0].Cells["IsDel"].Value;
                    if(isDel)
                    {
                        tsmiActivate.Visible = true;
                        tsmiSuspend.Visible = false;
                          
                    }
                    else
                    {
                        tsmiActivate.Visible = false;
                        tsmiSuspend.Visible = true;
                    }
                    tsmiEdit.Visible = true;
                   
                }
            }
        }

        private void cmsUserManager_Click(object sender, EventArgs e)
        {
            FrmSetUser frmSetUser = new FrmSetUser();
            frmSetUser.saveAction += BindUserAppraisals;
            frmSetUser.ShowDialog();
        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            int id=(int)dgvUserAppraisal.SelectedRows[0].Cells["Id"].Value;
            FrmSetUser frmSetUser = new FrmSetUser(id);
            frmSetUser.saveAction += BindUserAppraisals;
            frmSetUser.ShowDialog();
        }
    }
}

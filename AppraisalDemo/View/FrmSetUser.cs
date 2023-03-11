using AppraisalDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppraisalDemo
{
    public partial class FrmSetUser : Form
    {
        public Action saveAction;
        public FrmSetUser()
        {
            InitializeComponent();
        }

        public FrmSetUser(int id)
        {
            InitializeComponent();
            User aUser= User.GetList().Find(u=>u.Id == id);
            txtUserName.Text = aUser.UserName;
            cmbIdentity.SelectedValue = aUser.BaseTypeId;
            cmbSex.Text= aUser.Sex;
            chkIsSupend.Checked = aUser.IsDel;
        }

        private void FrmSetUser_Load(object sender, EventArgs e)
        {
            List<AppraisalBases> appraisalBases = new List<AppraisalBases>();
            appraisalBases.Add(new AppraisalBases() { Id = 0, BaseType = "--Query--", AppraisalBase = 0, IsDel = false });
            appraisalBases.AddRange(AppraisalBases.GetAllTest());
            cmbIdentity.DataSource = appraisalBases;
            cmbIdentity.DisplayMember = "BaseType";
            cmbIdentity.ValueMember = "Id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();
            int baseTypeId = (int)cmbIdentity.SelectedValue;
            string sex = cmbSex.Text;
            bool isDel = chkIsSupend.Checked;
            User aUser = new User()
            {
                UserName = userName,
                BaseTypeId = baseTypeId,
                Password = "1111",
                Sex = sex,
                IsDel = isDel,
            };
            User.Insert(aUser);
            if (saveAction != null)
            {
                saveAction();
            }
            
        }
    }
}

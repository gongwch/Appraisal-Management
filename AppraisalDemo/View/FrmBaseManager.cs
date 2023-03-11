using AppraisalDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppraisalDemo
{
    public partial class FrmBaseManager : Form
    {
        public FrmBaseManager()
        {
            InitializeComponent();
        }

        private void FrmBaseManager_Load(object sender, EventArgs e)
        {
            dgvAppraisalBases.DataSource = AppraisalBases.GetAllTest();
        }
    }
}

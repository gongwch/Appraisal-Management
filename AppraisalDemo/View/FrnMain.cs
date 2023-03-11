using AppraisalDemo.Common;
using AppraisalDemo.Models;

namespace AppraisalDemo
{
    public partial class Frnmain : Form
    {
        private Form _form;
        public Frnmain()
        {
            InitializeComponent();
        }

        private void Frnmain_Load(object sender, EventArgs e)
        {
            Form form=FormFactory.CreateFormFactory("FrmUserManager");
            trvMenu.Nodes[0].BackColor = SystemColors.Highlight;
            trvMenu.Nodes[0].ForeColor=Color.White;
            form.MdiParent =this;
            form.Parent = splitContainer1.Panel2;
            form.Dock = DockStyle.Fill;
            form.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            form.Show();
        }

        private void trvMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            foreach (TreeNode item in trvMenu.Nodes)
            {
                item.BackColor = Color.White;
                item.ForeColor = Color.Black;
            }
            //var b1= ((TreeView)sender).SelectedNode == trvMenu.SelectedNode;
            e.Node.BackColor = SystemColors.Highlight;
            e.Node.ForeColor = Color.White;
            _form =FormFactory.CreateFormFactory((string)e.Node.Tag);
            
            //_form.ShowDialog();
            _form.MdiParent = this;
            _form.Parent = splitContainer1.Panel2;
            _form.Dock = DockStyle.Fill;
            _form.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            _form.Show();

            //switch (e.Node.Index)
            // {
            //     case 0:
            //         FrmUserManager frmUserManager = new FrmUserManager();
            //         frmUserManager.MdiParent = this;
            //         frmUserManager.Parent = splitContainer1.Panel2;
            //         frmUserManager.Dock = DockStyle.Fill;
            //         //frmUserManager.Anchor= AnchorStyles.Right | AnchorStyles.Left;
            //         frmUserManager.Show();
            //          break;
            //     case 1:
            //         FrmBaseManager frmBaseManager = new FrmBaseManager();
            //         frmBaseManager.MdiParent = this;
            //         frmBaseManager.Parent = splitContainer1.Panel2;
            //         frmBaseManager.Show();
            //         break;
            //     default:
            //         break;
            // }


        }
    }
}
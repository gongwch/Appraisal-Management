namespace AppraisalDemo
{
    partial class FrmUserManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Filter = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.chkSuspend = new System.Windows.Forms.CheckBox();
            this.cmbIdentity = new System.Windows.Forms.ComboBox();
            this.labIdentity = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.labUserName = new System.Windows.Forms.Label();
            this.dgvUserAppraisal = new System.Windows.Forms.DataGridView();
            this.cmsUserManager = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiActivate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSuspend = new System.Windows.Forms.ToolStripMenuItem();
            this.Filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserAppraisal)).BeginInit();
            this.cmsUserManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // Filter
            // 
            this.Filter.AutoSize = true;
            this.Filter.Controls.Add(this.btnSearch);
            this.Filter.Controls.Add(this.chkSuspend);
            this.Filter.Controls.Add(this.cmbIdentity);
            this.Filter.Controls.Add(this.labIdentity);
            this.Filter.Controls.Add(this.txtUserName);
            this.Filter.Controls.Add(this.labUserName);
            this.Filter.Dock = System.Windows.Forms.DockStyle.Top;
            this.Filter.Location = new System.Drawing.Point(0, 0);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(1442, 118);
            this.Filter.TabIndex = 0;
            this.Filter.TabStop = false;
            this.Filter.Text = "Filter";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1182, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(166, 46);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // chkSuspend
            // 
            this.chkSuspend.Location = new System.Drawing.Point(884, 39);
            this.chkSuspend.Name = "chkSuspend";
            this.chkSuspend.Size = new System.Drawing.Size(166, 36);
            this.chkSuspend.TabIndex = 4;
            this.chkSuspend.Text = "Suspend";
            this.chkSuspend.UseVisualStyleBackColor = false;
            // 
            // cmbIdentity
            // 
            this.cmbIdentity.FormattingEnabled = true;
            this.cmbIdentity.Location = new System.Drawing.Point(534, 37);
            this.cmbIdentity.Name = "cmbIdentity";
            this.cmbIdentity.Size = new System.Drawing.Size(166, 40);
            this.cmbIdentity.TabIndex = 3;
            // 
            // labIdentity
            // 
            this.labIdentity.AutoSize = true;
            this.labIdentity.ForeColor = System.Drawing.Color.Black;
            this.labIdentity.Location = new System.Drawing.Point(436, 36);
            this.labIdentity.Name = "labIdentity";
            this.labIdentity.Size = new System.Drawing.Size(95, 32);
            this.labIdentity.TabIndex = 2;
            this.labIdentity.Text = "Identity";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(177, 36);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(166, 39);
            this.txtUserName.TabIndex = 1;
            // 
            // labUserName
            // 
            this.labUserName.AutoSize = true;
            this.labUserName.Location = new System.Drawing.Point(46, 36);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(125, 32);
            this.labUserName.TabIndex = 0;
            this.labUserName.Text = "UserName";
            // 
            // dgvUserAppraisal
            // 
            this.dgvUserAppraisal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUserAppraisal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserAppraisal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUserAppraisal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserAppraisal.ContextMenuStrip = this.cmsUserManager;
            this.dgvUserAppraisal.Location = new System.Drawing.Point(0, 124);
            this.dgvUserAppraisal.MultiSelect = false;
            this.dgvUserAppraisal.Name = "dgvUserAppraisal";
            this.dgvUserAppraisal.RowHeadersWidth = 82;
            this.dgvUserAppraisal.RowTemplate.Height = 41;
            this.dgvUserAppraisal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserAppraisal.Size = new System.Drawing.Size(1442, 410);
            this.dgvUserAppraisal.TabIndex = 1;
            this.dgvUserAppraisal.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUserAppraisal_CellMouseDown);
            this.dgvUserAppraisal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvUserAppraisal_MouseDown);
            // 
            // cmsUserManager
            // 
            this.cmsUserManager.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsUserManager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCreate,
            this.tsmiEdit,
            this.tsmiActivate,
            this.tsmiSuspend});
            this.cmsUserManager.Name = "cmsUserManager";
            this.cmsUserManager.Size = new System.Drawing.Size(178, 156);
            this.cmsUserManager.Click += new System.EventHandler(this.cmsUserManager_Click);
            // 
            // tsmiCreate
            // 
            this.tsmiCreate.Name = "tsmiCreate";
            this.tsmiCreate.Size = new System.Drawing.Size(177, 38);
            this.tsmiCreate.Text = "create";
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(177, 38);
            this.tsmiEdit.Text = "edit";
            this.tsmiEdit.Click += new System.EventHandler(this.tsmiEdit_Click);
            // 
            // tsmiActivate
            // 
            this.tsmiActivate.Name = "tsmiActivate";
            this.tsmiActivate.Size = new System.Drawing.Size(177, 38);
            this.tsmiActivate.Text = "activate";
            // 
            // tsmiSuspend
            // 
            this.tsmiSuspend.Name = "tsmiSuspend";
            this.tsmiSuspend.Size = new System.Drawing.Size(177, 38);
            this.tsmiSuspend.Text = "suspend";
            // 
            // FrmUserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 534);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.dgvUserAppraisal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUserManager";
            this.Text = "FrmUserManager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmUserManager_Load);
            this.Filter.ResumeLayout(false);
            this.Filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserAppraisal)).EndInit();
            this.cmsUserManager.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox Filter;
        private DataGridView dgvUserAppraisal;
        private Button btnSearch;
        private CheckBox chkSuspend;
        private ComboBox cmbIdentity;
        private Label labIdentity;
        private TextBox txtUserName;
        private Label labUserName;
        private ContextMenuStrip cmsUserManager;
        private ToolStripMenuItem tsmiCreate;
        private ToolStripMenuItem tsmiEdit;
        private ToolStripMenuItem tsmiActivate;
        private ToolStripMenuItem tsmiSuspend;
    }
}
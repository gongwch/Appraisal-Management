namespace AppraisalDemo
{
    partial class FrmSetUser
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkIsSupend = new System.Windows.Forms.CheckBox();
            this.labSuspend = new System.Windows.Forms.Label();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.labSex = new System.Windows.Forms.Label();
            this.cmbIdentity = new System.Windows.Forms.ComboBox();
            this.labIdentity = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.labUserName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkIsSupend);
            this.groupBox1.Controls.Add(this.labSuspend);
            this.groupBox1.Controls.Add(this.cmbSex);
            this.groupBox1.Controls.Add(this.labSex);
            this.groupBox1.Controls.Add(this.cmbIdentity);
            this.groupBox1.Controls.Add(this.labIdentity);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.labUserName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 469);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // chkIsSupend
            // 
            this.chkIsSupend.AutoSize = true;
            this.chkIsSupend.Location = new System.Drawing.Point(66, 385);
            this.chkIsSupend.Name = "chkIsSupend";
            this.chkIsSupend.Size = new System.Drawing.Size(154, 36);
            this.chkIsSupend.TabIndex = 7;
            this.chkIsSupend.Text = "IsSuspend";
            this.chkIsSupend.UseVisualStyleBackColor = true;
            // 
            // labSuspend
            // 
            this.labSuspend.AutoSize = true;
            this.labSuspend.Location = new System.Drawing.Point(554, 178);
            this.labSuspend.Name = "labSuspend";
            this.labSuspend.Size = new System.Drawing.Size(0, 32);
            this.labSuspend.TabIndex = 6;
            // 
            // cmbSex
            // 
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbSex.Location = new System.Drawing.Point(210, 168);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(242, 40);
            this.cmbSex.TabIndex = 5;
            // 
            // labSex
            // 
            this.labSex.AutoSize = true;
            this.labSex.Location = new System.Drawing.Point(66, 172);
            this.labSex.Name = "labSex";
            this.labSex.Size = new System.Drawing.Size(51, 32);
            this.labSex.TabIndex = 4;
            this.labSex.Text = "Sex";
            // 
            // cmbIdentity
            // 
            this.cmbIdentity.FormattingEnabled = true;
            this.cmbIdentity.Location = new System.Drawing.Point(210, 277);
            this.cmbIdentity.Name = "cmbIdentity";
            this.cmbIdentity.Size = new System.Drawing.Size(242, 40);
            this.cmbIdentity.TabIndex = 3;
            // 
            // labIdentity
            // 
            this.labIdentity.AutoSize = true;
            this.labIdentity.Location = new System.Drawing.Point(66, 281);
            this.labIdentity.Name = "labIdentity";
            this.labIdentity.Size = new System.Drawing.Size(95, 32);
            this.labIdentity.TabIndex = 2;
            this.labIdentity.Text = "Identity";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(210, 70);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(242, 39);
            this.txtUserName.TabIndex = 1;
            // 
            // labUserName
            // 
            this.labUserName.AutoSize = true;
            this.labUserName.Location = new System.Drawing.Point(66, 73);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(125, 32);
            this.labUserName.TabIndex = 0;
            this.labUserName.Text = "UserName";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 468);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(537, 129);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Location = new System.Drawing.Point(302, 56);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 46);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmSetUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 597);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmSetUser";
            this.Text = "User Editor";
            this.Load += new System.EventHandler(this.FrmSetUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnSave;
        private CheckBox chkIsSupend;
        private Label labSuspend;
        private ComboBox cmbSex;
        private Label labSex;
        private ComboBox cmbIdentity;
        private Label labIdentity;
        private TextBox txtUserName;
        private Label labUserName;
    }
}
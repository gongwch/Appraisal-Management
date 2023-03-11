namespace AppraisalDemo.View
{
    partial class FrmUserAppraisalFormEdit
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
            this.upperGbx = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lowGbx = new System.Windows.Forms.GroupBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.upperGbx.SuspendLayout();
            this.lowGbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // upperGbx
            // 
            this.upperGbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.upperGbx.Controls.Add(this.flowLayoutPanel);
            this.upperGbx.Location = new System.Drawing.Point(12, 25);
            this.upperGbx.Name = "upperGbx";
            this.upperGbx.Size = new System.Drawing.Size(1306, 410);
            this.upperGbx.TabIndex = 0;
            this.upperGbx.TabStop = false;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 38);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(1303, 382);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // lowGbx
            // 
            this.lowGbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lowGbx.Controls.Add(this.cancelBtn);
            this.lowGbx.Controls.Add(this.saveBtn);
            this.lowGbx.Location = new System.Drawing.Point(16, 449);
            this.lowGbx.Name = "lowGbx";
            this.lowGbx.Size = new System.Drawing.Size(1294, 124);
            this.lowGbx.TabIndex = 1;
            this.lowGbx.TabStop = false;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(1080, 53);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(150, 46);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(838, 53);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(150, 46);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // FrmUserAppraisalFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 584);
            this.Controls.Add(this.lowGbx);
            this.Controls.Add(this.upperGbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmUserAppraisalFormEdit";
            this.Text = "UserAppraisalEdit";
            this.Load += new System.EventHandler(this.FrmUserAppraisalFormEdit_Load);
            this.upperGbx.ResumeLayout(false);
            this.lowGbx.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox upperGbx;
        private GroupBox lowGbx;
        private FlowLayoutPanel flowLayoutPanel;
        private Button cancelBtn;
        private Button saveBtn;
    }
}
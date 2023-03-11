namespace AppraisalDemo
{
    partial class FrmUserAppraisal
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
            this.dgvUserAppraisal = new System.Windows.Forms.DataGridView();
            this.cmsUserAppraisal = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editTsm = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserAppraisal)).BeginInit();
            this.cmsUserAppraisal.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUserAppraisal
            // 
            this.dgvUserAppraisal.AllowUserToAddRows = false;
            this.dgvUserAppraisal.AllowUserToDeleteRows = false;
            this.dgvUserAppraisal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserAppraisal.ColumnHeadersHeight = 46;
            this.dgvUserAppraisal.ContextMenuStrip = this.cmsUserAppraisal;
            this.dgvUserAppraisal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUserAppraisal.Location = new System.Drawing.Point(0, 0);
            this.dgvUserAppraisal.MultiSelect = false;
            this.dgvUserAppraisal.Name = "dgvUserAppraisal";
            this.dgvUserAppraisal.ReadOnly = true;
            this.dgvUserAppraisal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvUserAppraisal.RowHeadersVisible = false;
            this.dgvUserAppraisal.RowHeadersWidth = 82;
            this.dgvUserAppraisal.RowTemplate.Height = 41;
            this.dgvUserAppraisal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserAppraisal.Size = new System.Drawing.Size(1807, 873);
            this.dgvUserAppraisal.TabIndex = 1;
            this.dgvUserAppraisal.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUserAppraisal_CellMouseDown);
            this.dgvUserAppraisal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvUserAppraisal_MouseDown);
            // 
            // cmsUserAppraisal
            // 
            this.cmsUserAppraisal.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsUserAppraisal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editTsm});
            this.cmsUserAppraisal.Name = "cmsUserAppraisal";
            this.cmsUserAppraisal.Size = new System.Drawing.Size(129, 42);
            // 
            // editTsm
            // 
            this.editTsm.Name = "editTsm";
            this.editTsm.Size = new System.Drawing.Size(128, 38);
            this.editTsm.Text = "Edit";
            this.editTsm.Click += new System.EventHandler(this.editTsm_Click);
            // 
            // FrmUserAppraisal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1807, 873);
            this.Controls.Add(this.dgvUserAppraisal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUserAppraisal";
            this.Text = "FrmUserAppraisal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmUserAppraisal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserAppraisal)).EndInit();
            this.cmsUserAppraisal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dgvUserAppraisal;
        private ContextMenuStrip cmsUserAppraisal;
        private ToolStripMenuItem editTsm;
    }
}
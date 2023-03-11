namespace AppraisalDemo
{
    partial class FrmBaseManager
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
            this.dgvAppraisalBases = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppraisalBases)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAppraisalBases
            // 
            this.dgvAppraisalBases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppraisalBases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppraisalBases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAppraisalBases.Location = new System.Drawing.Point(0, 0);
            this.dgvAppraisalBases.Name = "dgvAppraisalBases";
            this.dgvAppraisalBases.RowHeadersWidth = 82;
            this.dgvAppraisalBases.RowTemplate.Height = 41;
            this.dgvAppraisalBases.Size = new System.Drawing.Size(1009, 640);
            this.dgvAppraisalBases.TabIndex = 0;
            // 
            // FrmBaseManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 640);
            this.Controls.Add(this.dgvAppraisalBases);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBaseManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBaseManager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmBaseManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppraisalBases)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvAppraisalBases;
    }
}
using SampleDataModel;

namespace AccountApplication
{
    partial class frmPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrint));
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            resources.ApplyResources(this.reportViewer, "reportViewer");
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            // 
            // frmPrint
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportViewer);
            this.Name = "frmPrint";
            this.Load += new System.EventHandler(this.frmPrint_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn arefDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aChinaCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aHKCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMrCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aHKNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMrNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDeptCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLedgerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aParenetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCompDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aParentRefDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aAccTypeDataGridViewTextBoxColumn;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
    }
}
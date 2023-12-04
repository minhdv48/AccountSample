
namespace AccountApplication
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeingBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processUnpostDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exchangeDifferentTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nSDGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chineseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStrip1
            // 
            this.mnuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.setupToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.exitToolStripMenuItem});
            resources.ApplyResources(this.mnuStrip1, "mnuStrip1");
            this.mnuStrip1.Name = "mnuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.nSDGToolStripMenuItem});
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.closeingBalanceToolStripMenuItem,
            this.processUnpostDataToolStripMenuItem,
            this.exchangeDifferentTransactionToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            resources.ApplyResources(this.masterToolStripMenuItem, "masterToolStripMenuItem");
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountsToolStripMenuItem,
            this.vendorInformationToolStripMenuItem,
            this.customerInformationToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            // 
            // accountsToolStripMenuItem
            // 
            this.accountsToolStripMenuItem.Name = "accountsToolStripMenuItem";
            resources.ApplyResources(this.accountsToolStripMenuItem, "accountsToolStripMenuItem");
            this.accountsToolStripMenuItem.Click += new System.EventHandler(this.accountsToolStripMenuItem_Click);
            // 
            // vendorInformationToolStripMenuItem
            // 
            this.vendorInformationToolStripMenuItem.Name = "vendorInformationToolStripMenuItem";
            resources.ApplyResources(this.vendorInformationToolStripMenuItem, "vendorInformationToolStripMenuItem");
            // 
            // customerInformationToolStripMenuItem
            // 
            this.customerInformationToolStripMenuItem.Name = "customerInformationToolStripMenuItem";
            resources.ApplyResources(this.customerInformationToolStripMenuItem, "customerInformationToolStripMenuItem");
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            resources.ApplyResources(this.transactionToolStripMenuItem, "transactionToolStripMenuItem");
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            resources.ApplyResources(this.reportToolStripMenuItem, "reportToolStripMenuItem");
            // 
            // closeingBalanceToolStripMenuItem
            // 
            this.closeingBalanceToolStripMenuItem.Name = "closeingBalanceToolStripMenuItem";
            resources.ApplyResources(this.closeingBalanceToolStripMenuItem, "closeingBalanceToolStripMenuItem");
            // 
            // processUnpostDataToolStripMenuItem
            // 
            this.processUnpostDataToolStripMenuItem.Name = "processUnpostDataToolStripMenuItem";
            resources.ApplyResources(this.processUnpostDataToolStripMenuItem, "processUnpostDataToolStripMenuItem");
            // 
            // exchangeDifferentTransactionToolStripMenuItem
            // 
            this.exchangeDifferentTransactionToolStripMenuItem.Name = "exchangeDifferentTransactionToolStripMenuItem";
            resources.ApplyResources(this.exchangeDifferentTransactionToolStripMenuItem, "exchangeDifferentTransactionToolStripMenuItem");
            // 
            // nSDGToolStripMenuItem
            // 
            this.nSDGToolStripMenuItem.Name = "nSDGToolStripMenuItem";
            resources.ApplyResources(this.nSDGToolStripMenuItem, "nSDGToolStripMenuItem");
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem});
            resources.ApplyResources(this.setupToolStripMenuItem, "setupToolStripMenuItem");
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.chineseToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // chineseToolStripMenuItem
            // 
            this.chineseToolStripMenuItem.Name = "chineseToolStripMenuItem";
            resources.ApplyResources(this.chineseToolStripMenuItem, "chineseToolStripMenuItem");
            this.chineseToolStripMenuItem.Click += new System.EventHandler(this.chineseToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            resources.ApplyResources(this.historyToolStripMenuItem, "historyToolStripMenuItem");
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            // 
            // exitToolStripMenuItem
            // 
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.mnuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuStrip1;
            this.Name = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuStrip1.ResumeLayout(false);
            this.mnuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nSDGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendorInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeingBalanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processUnpostDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exchangeDifferentTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chineseToolStripMenuItem;
    }
}



namespace AccountApplication
{
    partial class frmAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccounts));
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelDept = new System.Windows.Forms.FlowLayoutPanel();
            this.tbId = new System.Windows.Forms.TextBox();
            this.btnPick = new System.Windows.Forms.Button();
            this.txtAsset = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCurrentAccounts = new System.Windows.Forms.TextBox();
            this.txtCurrentAssets = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.grbIncome = new System.Windows.Forms.GroupBox();
            this.radNull = new System.Windows.Forms.RadioButton();
            this.radExpense = new System.Windows.Forms.RadioButton();
            this.radIncome = new System.Windows.Forms.RadioButton();
            this.lblIncome = new System.Windows.Forms.Label();
            this.grbLedger = new System.Windows.Forms.GroupBox();
            this.radOL = new System.Windows.Forms.RadioButton();
            this.radJS = new System.Windows.Forms.RadioButton();
            this.lblLedger = new System.Windows.Forms.Label();
            this.grbmold = new System.Windows.Forms.GroupBox();
            this.radNothing = new System.Windows.Forms.RadioButton();
            this.radMachine = new System.Windows.Forms.RadioButton();
            this.radMold = new System.Windows.Forms.RadioButton();
            this.lblMold = new System.Windows.Forms.Label();
            this.txtMRCodeName = new System.Windows.Forms.TextBox();
            this.txtHKCodeName = new System.Windows.Forms.TextBox();
            this.txtChinaCodeName = new System.Windows.Forms.TextBox();
            this.lblMrcode = new System.Windows.Forms.Label();
            this.lblHKCode = new System.Windows.Forms.Label();
            this.lblChinaCode = new System.Windows.Forms.Label();
            this.txtMRCode = new System.Windows.Forms.TextBox();
            this.txtHKCode = new System.Windows.Forms.TextBox();
            this.txtChinaCode = new System.Windows.Forms.TextBox();
            this.lblmrcodename = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblChinaCodeName = new System.Windows.Forms.Label();
            this.lblAccountCode = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grbIncome.SuspendLayout();
            this.grbLedger.SuspendLayout();
            this.grbmold.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // treeView1
            // 
            resources.ApplyResources(this.treeView1, "treeView1");
            this.treeView1.Name = "treeView1";
            this.treeView1.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCollapse);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.flowLayoutPanelDept);
            this.groupBox1.Controls.Add(this.tbId);
            this.groupBox1.Controls.Add(this.btnPick);
            this.groupBox1.Controls.Add(this.txtAsset);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtCurrentAccounts);
            this.groupBox1.Controls.Add(this.txtCurrentAssets);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.grbIncome);
            this.groupBox1.Controls.Add(this.lblIncome);
            this.groupBox1.Controls.Add(this.grbLedger);
            this.groupBox1.Controls.Add(this.lblLedger);
            this.groupBox1.Controls.Add(this.grbmold);
            this.groupBox1.Controls.Add(this.lblMold);
            this.groupBox1.Controls.Add(this.txtMRCodeName);
            this.groupBox1.Controls.Add(this.txtHKCodeName);
            this.groupBox1.Controls.Add(this.txtChinaCodeName);
            this.groupBox1.Controls.Add(this.lblMrcode);
            this.groupBox1.Controls.Add(this.lblHKCode);
            this.groupBox1.Controls.Add(this.lblChinaCode);
            this.groupBox1.Controls.Add(this.txtMRCode);
            this.groupBox1.Controls.Add(this.txtHKCode);
            this.groupBox1.Controls.Add(this.txtChinaCode);
            this.groupBox1.Controls.Add(this.lblmrcodename);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblChinaCodeName);
            this.groupBox1.Controls.Add(this.lblAccountCode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // flowLayoutPanelDept
            // 
            resources.ApplyResources(this.flowLayoutPanelDept, "flowLayoutPanelDept");
            this.flowLayoutPanelDept.Name = "flowLayoutPanelDept";
            // 
            // tbId
            // 
            resources.ApplyResources(this.tbId, "tbId");
            this.tbId.Name = "tbId";
            // 
            // btnPick
            // 
            resources.ApplyResources(this.btnPick, "btnPick");
            this.btnPick.Name = "btnPick";
            this.btnPick.UseVisualStyleBackColor = true;
            this.btnPick.Click += new System.EventHandler(this.btnPick_Click);
            // 
            // txtAsset
            // 
            resources.ApplyResources(this.txtAsset, "txtAsset");
            this.txtAsset.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtAsset.Name = "txtAsset";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // txtCurrentAccounts
            // 
            resources.ApplyResources(this.txtCurrentAccounts, "txtCurrentAccounts");
            this.txtCurrentAccounts.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCurrentAccounts.Name = "txtCurrentAccounts";
            // 
            // txtCurrentAssets
            // 
            resources.ApplyResources(this.txtCurrentAssets, "txtCurrentAssets");
            this.txtCurrentAssets.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCurrentAssets.Name = "txtCurrentAssets";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // grbIncome
            // 
            this.grbIncome.Controls.Add(this.radNull);
            this.grbIncome.Controls.Add(this.radExpense);
            this.grbIncome.Controls.Add(this.radIncome);
            resources.ApplyResources(this.grbIncome, "grbIncome");
            this.grbIncome.Name = "grbIncome";
            this.grbIncome.TabStop = false;
            // 
            // radNull
            // 
            resources.ApplyResources(this.radNull, "radNull");
            this.radNull.Name = "radNull";
            this.radNull.UseVisualStyleBackColor = true;
            // 
            // radExpense
            // 
            resources.ApplyResources(this.radExpense, "radExpense");
            this.radExpense.Checked = true;
            this.radExpense.Name = "radExpense";
            this.radExpense.TabStop = true;
            this.radExpense.UseVisualStyleBackColor = true;
            // 
            // radIncome
            // 
            resources.ApplyResources(this.radIncome, "radIncome");
            this.radIncome.Name = "radIncome";
            this.radIncome.UseVisualStyleBackColor = true;
            // 
            // lblIncome
            // 
            resources.ApplyResources(this.lblIncome, "lblIncome");
            this.lblIncome.Name = "lblIncome";
            // 
            // grbLedger
            // 
            this.grbLedger.Controls.Add(this.radOL);
            this.grbLedger.Controls.Add(this.radJS);
            resources.ApplyResources(this.grbLedger, "grbLedger");
            this.grbLedger.Name = "grbLedger";
            this.grbLedger.TabStop = false;
            // 
            // radOL
            // 
            resources.ApplyResources(this.radOL, "radOL");
            this.radOL.Checked = true;
            this.radOL.Name = "radOL";
            this.radOL.TabStop = true;
            this.radOL.UseVisualStyleBackColor = true;
            // 
            // radJS
            // 
            resources.ApplyResources(this.radJS, "radJS");
            this.radJS.Name = "radJS";
            this.radJS.UseVisualStyleBackColor = true;
            // 
            // lblLedger
            // 
            resources.ApplyResources(this.lblLedger, "lblLedger");
            this.lblLedger.Name = "lblLedger";
            // 
            // grbmold
            // 
            this.grbmold.Controls.Add(this.radNothing);
            this.grbmold.Controls.Add(this.radMachine);
            this.grbmold.Controls.Add(this.radMold);
            resources.ApplyResources(this.grbmold, "grbmold");
            this.grbmold.Name = "grbmold";
            this.grbmold.TabStop = false;
            // 
            // radNothing
            // 
            resources.ApplyResources(this.radNothing, "radNothing");
            this.radNothing.Checked = true;
            this.radNothing.Name = "radNothing";
            this.radNothing.TabStop = true;
            this.radNothing.UseVisualStyleBackColor = true;
            // 
            // radMachine
            // 
            resources.ApplyResources(this.radMachine, "radMachine");
            this.radMachine.Name = "radMachine";
            this.radMachine.UseVisualStyleBackColor = true;
            // 
            // radMold
            // 
            resources.ApplyResources(this.radMold, "radMold");
            this.radMold.Name = "radMold";
            this.radMold.UseVisualStyleBackColor = true;
            // 
            // lblMold
            // 
            resources.ApplyResources(this.lblMold, "lblMold");
            this.lblMold.Name = "lblMold";
            // 
            // txtMRCodeName
            // 
            resources.ApplyResources(this.txtMRCodeName, "txtMRCodeName");
            this.txtMRCodeName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMRCodeName.Name = "txtMRCodeName";
            // 
            // txtHKCodeName
            // 
            resources.ApplyResources(this.txtHKCodeName, "txtHKCodeName");
            this.txtHKCodeName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtHKCodeName.Name = "txtHKCodeName";
            // 
            // txtChinaCodeName
            // 
            resources.ApplyResources(this.txtChinaCodeName, "txtChinaCodeName");
            this.txtChinaCodeName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtChinaCodeName.Name = "txtChinaCodeName";
            // 
            // lblMrcode
            // 
            resources.ApplyResources(this.lblMrcode, "lblMrcode");
            this.lblMrcode.Name = "lblMrcode";
            // 
            // lblHKCode
            // 
            resources.ApplyResources(this.lblHKCode, "lblHKCode");
            this.lblHKCode.Name = "lblHKCode";
            // 
            // lblChinaCode
            // 
            resources.ApplyResources(this.lblChinaCode, "lblChinaCode");
            this.lblChinaCode.Name = "lblChinaCode";
            // 
            // txtMRCode
            // 
            this.txtMRCode.ForeColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.txtMRCode, "txtMRCode");
            this.txtMRCode.Name = "txtMRCode";
            // 
            // txtHKCode
            // 
            this.txtHKCode.ForeColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.txtHKCode, "txtHKCode");
            this.txtHKCode.Name = "txtHKCode";
            // 
            // txtChinaCode
            // 
            this.txtChinaCode.ForeColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.txtChinaCode, "txtChinaCode");
            this.txtChinaCode.Name = "txtChinaCode";
            // 
            // lblmrcodename
            // 
            resources.ApplyResources(this.lblmrcodename, "lblmrcodename");
            this.lblmrcodename.Name = "lblmrcodename";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // lblChinaCodeName
            // 
            resources.ApplyResources(this.lblChinaCodeName, "lblChinaCodeName");
            this.lblChinaCodeName.Name = "lblChinaCodeName";
            // 
            // lblAccountCode
            // 
            resources.ApplyResources(this.lblAccountCode, "lblAccountCode");
            this.lblAccountCode.Name = "lblAccountCode";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnNew
            // 
            resources.ApplyResources(this.btnNew, "btnNew");
            this.btnNew.Name = "btnNew";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFind
            // 
            resources.ApplyResources(this.btnFind, "btnFind");
            this.btnFind.Name = "btnFind";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPrint
            // 
            resources.ApplyResources(this.btnPrint, "btnPrint");
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnQuit
            // 
            resources.ApplyResources(this.btnQuit, "btnQuit");
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnFirst
            // 
            resources.ApplyResources(this.btnFirst, "btnFirst");
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrev
            // 
            resources.ApplyResources(this.btnPrev, "btnPrev");
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            resources.ApplyResources(this.btnNext, "btnNext");
            this.btnNext.Name = "btnNext";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            resources.ApplyResources(this.btnLast, "btnLast");
            this.btnLast.Name = "btnLast";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // frmAccounts
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAccounts";
            this.SizeChanged += new System.EventHandler(this.frmAccounts_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbIncome.ResumeLayout(false);
            this.grbIncome.PerformLayout();
            this.grbLedger.ResumeLayout(false);
            this.grbLedger.PerformLayout();
            this.grbmold.ResumeLayout(false);
            this.grbmold.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblChinaCodeName;
        private System.Windows.Forms.Label lblAccountCode;
        private System.Windows.Forms.Label lblmrcodename;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtChinaCode;
        private System.Windows.Forms.Label lblChinaCode;
        private System.Windows.Forms.TextBox txtMRCode;
        private System.Windows.Forms.TextBox txtHKCode;
        private System.Windows.Forms.TextBox txtChinaCodeName;
        private System.Windows.Forms.Label lblMrcode;
        private System.Windows.Forms.Label lblHKCode;
        private System.Windows.Forms.TextBox txtMRCodeName;
        private System.Windows.Forms.TextBox txtHKCodeName;
        private System.Windows.Forms.GroupBox grbmold;
        private System.Windows.Forms.Label lblMold;
        private System.Windows.Forms.RadioButton radMold;
        private System.Windows.Forms.RadioButton radMachine;
        private System.Windows.Forms.RadioButton radNothing;
        private System.Windows.Forms.GroupBox grbLedger;
        private System.Windows.Forms.RadioButton radOL;
        private System.Windows.Forms.RadioButton radJS;
        private System.Windows.Forms.Label lblLedger;
        private System.Windows.Forms.GroupBox grbIncome;
        private System.Windows.Forms.RadioButton radExpense;
        private System.Windows.Forms.RadioButton radIncome;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.RadioButton radNull;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCurrentAssets;
        private System.Windows.Forms.TextBox txtCurrentAccounts;
        private System.Windows.Forms.TextBox txtAsset;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnPick;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDept;
    }
}
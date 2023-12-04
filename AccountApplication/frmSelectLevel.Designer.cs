
namespace AccountApplication
{
    partial class frmSelectLevel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectLevel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radLvl3 = new System.Windows.Forms.RadioButton();
            this.radLvl2 = new System.Windows.Forms.RadioButton();
            this.radLvl1 = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.radLvl3);
            this.groupBox1.Controls.Add(this.radLvl2);
            this.groupBox1.Controls.Add(this.radLvl1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // radLvl3
            // 
            resources.ApplyResources(this.radLvl3, "radLvl3");
            this.radLvl3.Checked = true;
            this.radLvl3.Name = "radLvl3";
            this.radLvl3.TabStop = true;
            this.radLvl3.UseVisualStyleBackColor = true;
            // 
            // radLvl2
            // 
            resources.ApplyResources(this.radLvl2, "radLvl2");
            this.radLvl2.Name = "radLvl2";
            this.radLvl2.UseVisualStyleBackColor = true;
            // 
            // radLvl1
            // 
            resources.ApplyResources(this.radLvl1, "radLvl1");
            this.radLvl1.Name = "radLvl1";
            this.radLvl1.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.Name = "btnOk";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmSelectLevel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectLevel";
            this.ShowIcon = false;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radLvl3;
        private System.Windows.Forms.RadioButton radLvl2;
        private System.Windows.Forms.RadioButton radLvl1;
        private System.Windows.Forms.Button btnOk;
    }
}
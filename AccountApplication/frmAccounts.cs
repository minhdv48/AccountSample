using AccountApplication.SampleDataModel;
using SampleDataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace AccountApplication
{
    public partial class frmAccounts : Form
    {
        private static int level;
        private static int parent;
        SampleDbContext db = new SampleDbContext("sampleDb");
        string msg = string.Empty;
        CultureInfo currentCulture;
        public frmAccounts()
        {
            currentCulture = Thread.CurrentThread.CurrentCulture;
            InitializeComponent();
            LoadTree();
            var listDept = db.tDepts.Where(x => x.xDelFlag == "0");
            foreach (var item in listDept)
            {
                CheckBox cb = new CheckBox();
                cb.Text = item.xDeptCode;
                cb.Checked = true;
                cb.ForeColor = Color.DarkGray;
                flowLayoutPanelDept.Controls.Add(cb);
            }
        }

        public void LoadTree()
        {
            treeView1.Nodes.Clear();
            // start off by adding a base treeview node
            TreeNode mainNode = new TreeNode();
            mainNode.Name = "Root";
            mainNode.Text = "Root";
            this.treeView1.Nodes.Add(mainNode);
            // Add child node
            Work(ref mainNode, 0);
            // Expand all nodes
            treeView1.ExpandAll();
        }

        public void Work(ref TreeNode parentNode, int parentId)
        {
            try
            {
                var list = db.AccCharts.Where(x => x.aParentRef == parentId);
                foreach (var accChart in list)
                {
                    TreeNode node;
                    if (accChart.aLevel == 3 && string.IsNullOrEmpty(accChart.aChinaCode))
                    {
                        node = parentNode.Nodes.Add(accChart.aHKName, "          " + accChart.aHKName);
                    }
                    else
                    {
                        node = parentNode.Nodes.Add(accChart.aHKName, accChart.aChinaCode + " " + accChart.aHKName);
                    }
                    Work(ref node, accChart.Id);
                }
            }
            catch { }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                using (frmSelectLevel selectLevel = new frmSelectLevel())
                {
                    selectLevel.IdentityUpdated += new frmSelectLevel.IdentityUpdateHandler(OKForm_ButtonClicked);
                    selectLevel.StartPosition = FormStartPosition.CenterParent;
                    selectLevel.ShowDialog();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void OKForm_ButtonClicked(object sender, frmSelectLevel.IdentityUpdateEventArgs e)
        {
            string lblLvl = "Three)";
            string labelLvl = "(Level ";
            if (currentCulture.Name.Equals("zh"))
            {
                labelLvl = "(等级 ";
            }
            tbId.Text = "";
            level = e.Level;
            switch (level)
            {
                case 1:
                    if (currentCulture.Name.Equals("zh"))
                    {
                        lblLvl = "一)";
                    }
                    else
                    {
                        lblLvl = "One)";
                    }
                    lblHKCode.Location = new Point(6, 144);
                    txtHKCode.Location = new Point(154, 144);
                    HideShowControl(false);
                    break;
                case 2:
                    if (currentCulture.Name.Equals("zh"))
                    {
                        lblLvl = "二)";
                    }
                    else
                    {
                        lblLvl = "Two)";
                    }
                    lblHKCode.Location = new Point(330, 62);
                    txtHKCode.Location = new Point(333, 92);
                    HideShowControl(true);
                    break;
                case 3:
                    if (currentCulture.Name.Equals("zh"))
                    {
                        lblLvl = "三)";
                    }
                    else
                    {
                        lblLvl = "Three)";
                    }
                    lblHKCode.Location = new Point(330, 62);
                    txtHKCode.Location = new Point(333, 92);
                    HideShowControl(true);
                    break;
                default:
                    if (currentCulture.Name.Equals("zh"))
                    {
                        lblLvl = "三)";
                    }
                    else
                    {
                        lblLvl = "Three)";
                    }
                    break;
            }
            label2.Text = labelLvl + lblLvl;
            if (e.Level > 1)
            {
                btnPick.Enabled = true;
                txtCurrentAssets.Text = string.Empty;
                txtCurrentAccounts.Text = string.Empty;
                txtAsset.Text = string.Empty;
                txtCurrentAssets.Enabled = true;
                txtAsset.Enabled = true;
                txtCurrentAccounts.Enabled = true;
            }
            else
            {
                txtCurrentAssets.Text = "";
                txtCurrentAccounts.Text = "Root";
            }
            txtChinaCode.Text = string.Empty;
            txtChinaCode.ForeColor = Color.Black;
            txtHKCode.Text = string.Empty;
            txtHKCode.ForeColor = Color.Black;
            txtMRCode.Text = string.Empty;
            txtMRCode.ForeColor = Color.Black;
            txtChinaCodeName.Text = string.Empty;
            txtChinaCodeName.ForeColor = Color.Black;
            txtHKCodeName.Text = string.Empty;
            txtHKCodeName.ForeColor = Color.Black;
            txtMRCodeName.Text = string.Empty;
            txtMRCodeName.ForeColor = Color.Black;
            radMachine.Enabled = true;
            radMold.Enabled = true;
            radNothing.Enabled = true;
            radJS.Enabled = true;
            radOL.Enabled = true;
            radIncome.Enabled = true;
            radExpense.Enabled = true;
            radNull.Enabled = true;
            btnNew.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnFind.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnPrint.Enabled = false;
            btnQuit.Enabled = false;
            btnNext.Enabled = false;
            btnPrev.Enabled = false;
            btnFirst.Enabled = false;
            btnLast.Enabled = false;
            var listDept = db.tDepts.Where(x => x.xDelFlag == "0");
            flowLayoutPanelDept.Controls.Clear();
            foreach (var item in listDept)
            {
                CheckBox cb = new CheckBox();
                cb.Text = item.xDeptCode;
                cb.Checked = true;
                flowLayoutPanelDept.Controls.Add(cb);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string msg = "Please enter complete information";
            if (currentCulture.Name.Equals("zh"))
            {
                msg = "请输入完整信息";
            }
            if (level == 1)
            {
                if (string.IsNullOrEmpty(txtHKCode.Text))
                {
                    txtHKCode.Focus();
                    MessageBox.Show(msg);
                }
                else if (string.IsNullOrEmpty(txtHKCodeName.Text))
                {
                    txtHKCodeName.Focus();
                    MessageBox.Show(msg);
                }
                else
                {
                    txtCurrentAccounts.Text = "Root";
                    SaveAccChart(sender, e);
                }
            }
            else if (level == 2)
            {
                if (string.IsNullOrEmpty(txtHKCode.Text))
                {
                    txtHKCode.Focus();
                    MessageBox.Show(msg);
                }
                else if (string.IsNullOrEmpty(txtHKCodeName.Text))
                {
                    txtHKCodeName.Focus();
                    MessageBox.Show(msg);
                }
                else if (string.IsNullOrEmpty(txtCurrentAccounts.Text))
                {
                    txtCurrentAccounts.Focus();
                    MessageBox.Show(msg);
                }
                else if (string.IsNullOrEmpty(txtAsset.Text))
                {
                    txtAsset.Focus();
                    MessageBox.Show(msg);
                }
                else
                {
                    SaveAccChart(sender, e);
                }
            }
            else if (level == 3)
            {
                if (string.IsNullOrEmpty(txtHKCode.Text))
                {
                    txtHKCode.Focus();
                    MessageBox.Show(msg);
                }
                else if (string.IsNullOrEmpty(txtChinaCodeName.Text))
                {
                    txtChinaCodeName.Focus();
                    MessageBox.Show(msg);
                }
                else if (string.IsNullOrEmpty(txtHKCodeName.Text))
                {
                    txtHKCodeName.Focus();
                    MessageBox.Show(msg);
                }
                else if (string.IsNullOrEmpty(txtCurrentAccounts.Text))
                {
                    txtCurrentAccounts.Focus();
                    MessageBox.Show(msg);
                }
                else if (string.IsNullOrEmpty(txtAsset.Text))
                {
                    txtAsset.Focus();
                    MessageBox.Show(msg);
                }
                else
                {
                    SaveAccChart(sender, e);
                }
            }
        }

        public void SaveAccChart(object sender, EventArgs e)
        {
            string msg = "HK Code already exists";
            if (currentCulture.Name.Equals("zh"))
            {
                msg = "HK 代码已存在";
            }
          
            var accChart = db.AccCharts.Where(x => x.aHKCode.Trim() == txtHKCode.Text.Trim()).FirstOrDefault();
            if (accChart != null)
            {
                if (tbId.Text != null && tbId.Text != "")
                {
                    if (accChart.Id != int.Parse(tbId.Text))
                    {
                        txtHKCode.Focus();
                        MessageBox.Show(msg);
                        return;
                    }
                }
                else
                {
                    txtHKCode.Focus();
                    MessageBox.Show(msg);
                    return;
                }
            }
            string ledger = "";
            if (radJS.Checked)
            {
                ledger = "JS";
            }
            else if (radOL.Checked)
            {
                ledger = "OL";
            }
            var accInfoByCurrentAccount = db.AccCharts.Where(x => x.aChinaCode.Trim() == txtCurrentAccounts.Text.Trim() || x.aHKName.Trim() == txtCurrentAccounts.Text.Trim()).FirstOrDefault();
            var listCB = flowLayoutPanelDept.Controls;
            string deptCode = "";
            foreach (var item in listCB)
            {
                var cb = (CheckBox)item;
                if (cb.Checked == true)
                {
                    deptCode += cb.Text + ",";
                }
            }
            if (deptCode != "")
            {
                deptCode = deptCode.Remove(deptCode.Length - 1);
            }
            var n = new AccCharts()
            {
                //aref = 0,
                aChinaCode = txtChinaCode.Text,
                aHKCode = txtHKCode.Text,
                aMrCode = txtMRCode.Text,
                aName = txtChinaCodeName.Text,
                aHKName = txtHKCodeName.Text,
                aMrName = txtMRCodeName.Text,
                aDeptCode = deptCode,
                aLedger = ledger,
                //aType =,
                aLevel = level,
                aParenet = txtCurrentAccounts.Text,
                aGroup = txtAsset.Text,
                //aComp =,
                aParentRef = txtCurrentAccounts.Text == "Root" ? 0 : (accInfoByCurrentAccount != null ? accInfoByCurrentAccount.Id : 0),
                //aAccType =,
            };
            if (tbId.Text != null && tbId.Text != "")
            {
                n.Id = int.Parse(tbId.Text);
            }
            db.AccCharts.AddOrUpdate(n);
            db.SaveChanges();
            LoadTree();
            treeView1.SelectedNode = treeView1.Nodes.Find(n.aHKName, true)[0];
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode = null;
            lblHKCode.Location = new Point(330, 62);
            txtHKCode.Location = new Point(333, 92);
            HideShowControl(true);
            if (currentCulture.Name.Equals("zh"))
            {
                label2.Text = "(等级 三)";
            }
            else
            {
                label2.Text = "(Level Three)";
            }

            tbId.Text = string.Empty;
            txtChinaCode.Text = "33X01";
            txtChinaCode.ForeColor = Color.Gray;
            txtHKCode.Text = "33X01";
            txtHKCode.ForeColor = Color.Gray;
            txtMRCode.Text = string.Empty;
            txtMRCode.ForeColor = Color.Gray;
            txtChinaCodeName.Text = "Xin Heng C/A";
            txtChinaCodeName.ForeColor = Color.Gray;
            txtHKCodeName.Text = "Xin Heng C/A";
            txtHKCodeName.ForeColor = Color.Gray;
            txtMRCodeName.Text = string.Empty;
            txtMRCodeName.ForeColor = Color.Gray;
            radMachine.Enabled = false;
            radMold.Enabled = false;
            radNothing.Enabled = false;
            radJS.Enabled = false;
            radOL.Enabled = false;
            radIncome.Enabled = false;
            radExpense.Enabled = false;
            radNull.Enabled = false;
            txtCurrentAssets.Text = " Current Assets";
            txtCurrentAccounts.Text = " Current Accounts";
            txtAsset.Text = "Asset";
            btnPick.Enabled = false;
            btnNew.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnFind.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnPrint.Enabled = true;
            btnQuit.Enabled = true;
            btnNext.Enabled = true;
            btnPrev.Enabled = true;
            btnFirst.Enabled = true;
            btnLast.Enabled = true;
            txtCurrentAssets.Enabled = false;
            txtAsset.Enabled = false;
            txtCurrentAccounts.Enabled = false;
            var listDept = db.tDepts.Where(x => x.xDelFlag == "0");
            flowLayoutPanelDept.Controls.Clear();
            foreach (var item in listDept)
            {
                CheckBox cb = new CheckBox();
                cb.Text = item.xDeptCode;
                cb.ForeColor = Color.DarkGray;
                cb.Checked = true;
                flowLayoutPanelDept.Controls.Add(cb);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                string lblLvl = "Three)";
                string labelLvl = "(Level ";
                if (currentCulture.Name.Equals("zh"))
                {
                    labelLvl = "(等级 ";
                }
                AccCharts accChart = db.AccCharts.Where(x => x.aHKName == treeView1.SelectedNode.Name).FirstOrDefault();
                if (accChart != null)
                {
                    level = accChart.aLevel;
                    switch (level)
                    {
                        case 1:
                            if (currentCulture.Name.Equals("zh"))
                            {
                                lblLvl = "一)";
                            }
                            else
                            {
                                lblLvl = "One)";
                            }
                            lblHKCode.Location = new Point(6, 144);
                            txtHKCode.Location = new Point(154, 144);
                            HideShowControl(false);
                            break;
                        case 2:
                            if (currentCulture.Name.Equals("zh"))
                            {
                                lblLvl = "二)";
                            }
                            else
                            {
                                lblLvl = "Two)";
                            }
                            lblHKCode.Location = new Point(330, 62);
                            txtHKCode.Location = new Point(333, 92);
                            HideShowControl(true);
                            break;
                        case 3:
                            if (currentCulture.Name.Equals("zh"))
                            {
                                lblLvl = "三)";
                            }
                            else
                            {
                                lblLvl = "Three)";
                            }
                            lblHKCode.Location = new Point(330, 62);
                            txtHKCode.Location = new Point(333, 92);
                            HideShowControl(true);
                            break;
                        default:
                            if (currentCulture.Name.Equals("zh"))
                            {
                                lblLvl = "三)";
                            }
                            else
                            {
                                lblLvl = "Three)";
                            }
                            break;
                    }
                    label2.Text = labelLvl + lblLvl;
                    if (accChart.aLevel > 1)
                    {
                        btnPick.Enabled = true;
                        txtCurrentAssets.Text = string.Empty;
                        txtCurrentAccounts.Text = string.Empty;
                        txtAsset.Text = string.Empty;
                        txtCurrentAssets.Enabled = true;
                        txtAsset.Enabled = true;
                        txtCurrentAccounts.Enabled = true;
                        var temp = db.AccCharts.Where(x => x.Id == accChart.aParentRef).FirstOrDefault();
                        var temp1 = db.AccCharts.Where(x => x.Id == temp.aParentRef).FirstOrDefault();
                        if (temp1 != null)
                        {
                            txtCurrentAssets.Text = temp1.aHKName;
                        }
                        else
                        {
                            txtCurrentAssets.Text = "Root";
                        }
                    }
                    else
                    {
                        txtCurrentAssets.Text = "";
                    }
                    btnNew.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnFind.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnPrint.Enabled = true;
                    btnQuit.Enabled = true;
                    btnNext.Enabled = true;
                    btnPrev.Enabled = true;
                    btnFirst.Enabled = true;
                    btnLast.Enabled = true;
                    tbId.Text = accChart.Id.ToString();
                    //aref = 0,
                    txtChinaCode.Text = accChart.aChinaCode;
                    txtHKCode.Text = accChart.aHKCode;
                    txtMRCode.Text = accChart.aMrCode;
                    txtChinaCodeName.Text = accChart.aName;
                    txtHKCodeName.Text = accChart.aHKName;
                    txtMRCodeName.Text = accChart.aMrName;
                    string[] listDeptChecked = new string[1];
                    if (!string.IsNullOrEmpty(accChart.aDeptCode))
                    {
                        listDeptChecked = accChart.aDeptCode.Split(',');
                    }
                    var listDept = db.tDepts.Where(x => x.xDelFlag == "0");
                    flowLayoutPanelDept.Controls.Clear();
                    foreach (var item in listDept)
                    {
                        CheckBox cb = new CheckBox();
                        cb.Text = item.xDeptCode;
                        if (listDeptChecked.Contains(item.xDeptCode))
                        {
                            cb.Checked = true;
                        }
                        cb.ForeColor = Color.DarkGray;
                        flowLayoutPanelDept.Controls.Add(cb);
                    }
                    if (accChart.aLedger == "OL")
                    {
                        radOL.Checked = true;
                        radJS.Checked = false;
                    }
                    else if (accChart.aLedger == "JS")
                    {
                        radOL.Checked = false;
                        radJS.Checked = true;
                    }
                    else
                    {
                        radOL.Checked = false;
                        radJS.Checked = false;
                    }
                    //aType =,
                    txtCurrentAccounts.Text = accChart.aParenet;
                    txtAsset.Text = accChart.aGroup;
                    //aComp =,
                    //aAccType =,
                    txtChinaCode.ForeColor = Color.Gray;
                    txtHKCode.ForeColor = Color.Gray;
                    txtMRCode.ForeColor = Color.Gray;
                    txtChinaCodeName.ForeColor = Color.Gray;
                    txtHKCodeName.ForeColor = Color.Gray;
                    txtMRCodeName.ForeColor = Color.Gray;
                    radMachine.Enabled = false;
                    radMold.Enabled = false;
                    radNothing.Enabled = false;
                    radJS.Enabled = false;
                    radOL.Enabled = false;
                    radIncome.Enabled = false;
                    radExpense.Enabled = false;
                    radNull.Enabled = false;
                    btnPick.Enabled = false;
                    txtCurrentAssets.Enabled = false;
                    txtAsset.Enabled = false;
                    txtCurrentAccounts.Enabled = false;
                }
            }
            catch { }
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            try
            {
                using (frmPickParent selectLevel = new frmPickParent(level))
                {
                    selectLevel.IdentityUpdated += new frmPickParent.IdentityUpdateHandler(PickParent_ButtonClicked);
                    selectLevel.StartPosition = FormStartPosition.CenterParent;
                    selectLevel.ShowDialog();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void PickParent_ButtonClicked(object sender, frmPickParent.IdentityUpdateEventArgs e)
        {
            txtCurrentAccounts.Text = e.Level;
            txtCurrentAssets.Text = e.Parent;
            txtAsset.Text = "Asset";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                using (frmSelectPrint selectLevel = new frmSelectPrint())
                {
                    //selectLevel.IdentityUpdated += new frmPickParent.IdentityUpdateHandler(PickParent_ButtonClicked);
                    selectLevel.StartPosition = FormStartPosition.CenterParent;
                    selectLevel.ShowDialog();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                using (frmFind selectLevel = new frmFind())
                {
                    selectLevel.IdentityUpdated += new frmFind.IdentityUpdateHandler(Find_ButtonClicked);
                    selectLevel.StartPosition = FormStartPosition.CenterParent;
                    selectLevel.ShowDialog();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void Find_ButtonClicked(object sender, frmFind.IdentityUpdateEventArgs e)
        {
            string lblLvl = "Three)";
            string labelLvl = "(Level ";
            if (currentCulture.Name.Equals("zh"))
            {
                labelLvl = "(等级 ";
            }
            AccCharts accChart = e.AccChart;
            level = accChart.aLevel;

            switch (level)
            {
                case 1:
                    if (currentCulture.Name.Equals("zh"))
                    {
                        lblLvl = "一)";
                    }
                    else
                    {
                        lblLvl = "One)";
                    }

                    lblHKCode.Location = new Point(6, 144);
                    txtHKCode.Location = new Point(154, 144);
                    HideShowControl(false);
                    break;
                case 2:
                    if (currentCulture.Name.Equals("zh"))
                    {
                        lblLvl = "二)";
                    }
                    else
                    {
                        lblLvl = "Two)";
                    }

                    lblHKCode.Location = new Point(330, 62);
                    txtHKCode.Location = new Point(333, 92);
                    HideShowControl(true);
                    break;
                case 3:
                    if (currentCulture.Name.Equals("zh"))
                    {
                        lblLvl = "三)";
                    }
                    else
                    {
                        lblLvl = "Three)";
                    }

                    lblHKCode.Location = new Point(330, 62);
                    txtHKCode.Location = new Point(333, 92);
                    HideShowControl(true);
                    break;
                default:
                    if (currentCulture.Name.Equals("zh"))
                    {
                        lblLvl = "三)";
                    }
                    else
                    {
                        lblLvl = "Three)";
                    }
                    break;
            }
            label2.Text = labelLvl + lblLvl;
            if (accChart.aLevel > 1)
            {
                btnPick.Enabled = true;
                txtCurrentAssets.Text = string.Empty;
                txtCurrentAccounts.Text = string.Empty;
                txtAsset.Text = string.Empty;
                txtCurrentAssets.Enabled = true;
                txtAsset.Enabled = true;
                txtCurrentAccounts.Enabled = true;
                var temp = db.AccCharts.Where(x => x.Id == accChart.aParentRef).FirstOrDefault();
                var temp1 = db.AccCharts.Where(x => x.Id == temp.aParentRef).FirstOrDefault();
                if (temp1 != null)
                {
                    txtCurrentAssets.Text = temp1.aHKName;
                }
                else
                {
                    txtCurrentAssets.Text = "Root";
                }
            }
            else
            {
                txtCurrentAssets.Text = "";
            }
            btnNew.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnFind.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnPrint.Enabled = true;
            btnQuit.Enabled = true;
            btnNext.Enabled = true;
            btnPrev.Enabled = true;
            btnFirst.Enabled = true;
            btnLast.Enabled = true;
            tbId.Text = accChart.Id.ToString();
            //aref = 0,
            txtChinaCode.Text = accChart.aChinaCode;
            txtHKCode.Text = accChart.aHKCode;
            txtMRCode.Text = accChart.aMrCode;
            txtChinaCodeName.Text = accChart.aName;
            txtHKCodeName.Text = accChart.aHKName;
            txtMRCodeName.Text = accChart.aMrName;
            string[] listDeptChecked = new string[1];
            if (!string.IsNullOrEmpty(accChart.aDeptCode))
            {
                listDeptChecked = accChart.aDeptCode.Split(',');
            }
            var listDept = db.tDepts.Where(x => x.xDelFlag == "0");
            flowLayoutPanelDept.Controls.Clear();
            foreach (var item in listDept)
            {
                CheckBox cb = new CheckBox();
                cb.Text = item.xDeptCode;
                if (listDeptChecked.Contains(item.xDeptCode))
                {
                    cb.Checked = true;
                }
                cb.ForeColor = Color.DarkGray;
                flowLayoutPanelDept.Controls.Add(cb);
            }
            if (accChart.aLedger == "OL")
            {
                radOL.Checked = true;
                radJS.Checked = false;
            }
            else if (accChart.aLedger == "JS")
            {
                radOL.Checked = false;
                radJS.Checked = true;
            }
            else
            {
                radOL.Checked = false;
                radJS.Checked = false;
            }
            //aType =,
            txtCurrentAccounts.Text = accChart.aParenet;
            txtAsset.Text = accChart.aGroup;
            //aComp =,
            //aAccType =,
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbId.Text))
            {
                btnPick.Enabled = true;
                txtCurrentAssets.Enabled = true;
                txtAsset.Enabled = true;
                txtCurrentAccounts.Enabled = true;
                txtChinaCode.ForeColor = Color.Black;
                txtHKCode.ForeColor = Color.Black;
                txtMRCode.ForeColor = Color.Black;
                txtChinaCodeName.ForeColor = Color.Black;
                txtHKCodeName.ForeColor = Color.Black;
                txtMRCodeName.ForeColor = Color.Black;
                radMachine.Enabled = true;
                radMold.Enabled = true;
                radNothing.Enabled = true;
                radJS.Enabled = true;
                radOL.Enabled = true;
                radIncome.Enabled = true;
                radExpense.Enabled = true;
                radNull.Enabled = true;
                btnNew.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnFind.Enabled = false;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                btnPrint.Enabled = false;
                btnQuit.Enabled = false;
                btnNext.Enabled = false;
                btnPrev.Enabled = false;
                btnFirst.Enabled = false;
                btnLast.Enabled = false;
                var listCB = flowLayoutPanelDept.Controls;
                foreach (var item in listCB)
                {
                    var cb = (CheckBox)item;
                    cb.ForeColor = Color.Black;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string msgConfirm = "Do you really want to delete ";
            if (currentCulture.Name.Equals("zh"))
            {
                msgConfirm = "你真的要删除吗 ";
            }
            if (tbId.Text != "" && tbId.Text != null)
            {
                int id = int.Parse(tbId.Text);
                AccCharts accChart = db.AccCharts.Where(x => x.Id == id).FirstOrDefault();
                if (accChart != null)
                {
                    DialogResult result = MessageBox.Show(msgConfirm + accChart.aChinaCode + " " + accChart.aHKName + " ?", "AccountApp", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        treeView1.Nodes.Remove(treeView1.Nodes.Find(accChart.aHKName, true)[0]);
                        db.AccCharts.Remove(accChart);
                        db.SaveChanges();
                        btnCancel_Click(sender, e);
                    }
                }
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            string msgConfirm = "Do you really want to quit?";
            if (currentCulture.Name.Equals("zh"))
            {
                msgConfirm = "你真的想戒烟吗?";
            }
            DialogResult result = MessageBox.Show(msgConfirm, "AccountApp", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void treeView1_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            string lblLvl = "One)";
            string labelLvl = "(Level ";
            if (currentCulture.Name.Equals("zh"))
            {
                lblLvl = "一)";
                labelLvl = "(等级 ";
            }
            var accChart = db.AccCharts.Where(x => x.aHKName == e.Node.Name).FirstOrDefault();
            if (accChart != null && accChart.aLevel == 1)
            {
                tbId.Text = "";
                level = 1;
                lblHKCode.Location = new Point(6, 144);
                txtHKCode.Location = new Point(154, 144);
                HideShowControl(false);
                label2.Text = labelLvl + lblLvl;
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            msg = "No Prev record";
            if (currentCulture.Name.Equals("zh"))
            {
                msg = "无回溯记录";
            }
            if (treeView1.SelectedNode != null && treeView1.SelectedNode.PrevVisibleNode != null && treeView1.SelectedNode.PrevVisibleNode.Text != "Root")
            {
                var selectedItem = treeView1.SelectedNode;
                {
                    if (selectedItem.Text.Equals(treeView1.SelectedNode.PrevVisibleNode.Text))
                    {
                        MessageBox.Show(msg);
                    }
                    else
                    {
                        treeView1.SelectedNode = treeView1.SelectedNode.PrevVisibleNode;
                    }
                }
            }
            else
            {
                MessageBox.Show(msg);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            msg = "No Next record";
            if (currentCulture.Name.Equals("zh"))
            {
                msg = "没有下一条记录";
            }
            if (treeView1.SelectedNode != null && treeView1.SelectedNode.NextVisibleNode != null)
            {
                var selectedItem = treeView1.SelectedNode;
                {
                    if (selectedItem.Text.Equals(treeView1.SelectedNode.NextVisibleNode.Text))
                    {
                        MessageBox.Show(msg);
                    }
                    else
                    {
                        treeView1.SelectedNode = treeView1.SelectedNode.NextVisibleNode;
                    }
                }
            }
            else
            {
                MessageBox.Show(msg);
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            msg = "No First record";
            try
            {
                if (currentCulture.Name.Equals("zh"))
                {
                    msg = "无首条记录";
                }
                if (treeView1.SelectedNode != null && treeView1.SelectedNode.Text != "Root")
                {
                    var selectedItem = treeView1.SelectedNode;
                    {
                        if (selectedItem.Text.Equals(treeView1.SelectedNode.Parent.FirstNode.Text))
                        {
                            MessageBox.Show(msg);
                        }
                        else
                        {
                            treeView1.SelectedNode = treeView1.SelectedNode.Parent.FirstNode;
                        }
                    }
                }
                else
                {
                    MessageBox.Show(msg);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(msg);
            }

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            msg = "No Last record";
            try
            {
                if (currentCulture.Name.Equals("zh"))
                {
                    msg = "没有最后记录";
                }

                if (treeView1.SelectedNode != null && treeView1.SelectedNode.Text != "Root")
                {
                    var selectedItem = treeView1.SelectedNode;
                    if (selectedItem.Text.Equals(treeView1.SelectedNode.Parent.LastNode.Text))
                    {
                        MessageBox.Show(msg);
                    }
                    else
                    {
                        treeView1.SelectedNode = treeView1.SelectedNode.Parent.LastNode;
                    }
                }
                else
                {
                    MessageBox.Show(msg);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(msg);
            }

        }
        private void HideShowControl(bool status)
        {
            lblAccountCode.Visible = status;
            lblChinaCode.Visible = status;
            txtChinaCode.Visible = status;
            lblChinaCodeName.Visible = status;
            txtChinaCodeName.Visible = status;
            lblMrcode.Visible = status;
            txtMRCode.Visible = status;
            lblmrcodename.Visible = status;
            txtMRCodeName.Visible = status;
            flowLayoutPanelDept.Visible = status;
            lblMold.Visible = status;
            grbmold.Visible = status;
            lblLedger.Visible = status;
            grbLedger.Visible = status;
            lblIncome.Visible = status;
            grbIncome.Visible = status;
            label13.Visible = status;
            label14.Visible = status;
            txtAsset.Visible = status;
            txtCurrentAccounts.Visible = status;
            txtCurrentAssets.Visible = status;
            btnPick.Visible = status;
        }
/*        int sizeOld = 1171;*/
        private void frmAccounts_SizeChanged(object sender, EventArgs e)
        {
           /* if (this.Width > 1171 && sizeOld <= 1171)
            {
                *//*                if (this.Width < sizeOld)
                                {
                                    this.treeView1.MaximumSize = new System.Drawing.Size((int)(628 * 0.75172413793), (int)(754 * 0.8092175777));
                                    groupBox1.Anchor = AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
                                }
                                else
                                {
                                    this.treeView1.MaximumSize = new System.Drawing.Size((int)(628 * 0.75172413793), (int)(754 * 0.8092175777));
                                    groupBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
                                }*//*
                int w = this.Width;
                int h = this.Height;
                InitializeComponent();
                treeView1.Anchor = AnchorStyles.Left | AnchorStyles.Top;
                groupBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                txtChinaCodeName.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                txtHKCodeName.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                txtMRCodeName.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                flowLayoutPanelDept.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                this.Width = w;
                this.Height = h;

*//*                this.treeView1.Location = new System.Drawing.Point((int)(23 * 0.75172413793), (int)(73 * 0.8092175777));
                this.treeView1.Size = new System.Drawing.Size((int)(628 * 0.75172413793), (int)(754 * 0.8092175777));
                this.groupBox1.Location = new System.Drawing.Point((int)(691 * 0.75172413793), (int)(64 * 0.8092175777));
                this.groupBox1.Size = new System.Drawing.Size((int)(856 * 0.75172413793), (int)(679 * 0.8092175777));
                this.txtChinaCodeName.Location = new System.Drawing.Point((int)(205 * 0.75172413793), (int)(177 * 0.8092175777));
                this.txtChinaCodeName.Size = new System.Drawing.Size((int)(596 * 0.75172413793), (int)(26 * 0.8092175777));
                this.txtHKCodeName.Location = new System.Drawing.Point((int)(205 * 0.75172413793), (int)(225 * 0.8092175777));
                this.txtHKCodeName.Size = new System.Drawing.Size((int)(596 * 0.75172413793), (int)(26 * 0.8092175777));
                this.txtMRCodeName.Location = new System.Drawing.Point((int)(205 * 0.75172413793), (int)(271 * 0.8092175777));
                this.txtMRCodeName.Size = new System.Drawing.Size((int)(596 * 0.75172413793), (int)(26 * 0.8092175777));
                this.flowLayoutPanelDept.Location = new System.Drawing.Point((int)(12 * 0.75172413793), (int)(320 * 0.8092175777));
                this.flowLayoutPanelDept.Size = new System.Drawing.Size((int)(821 * 0.75172413793), (int)(111 * 0.8092175777));
                this.treeView1.Location = new System.Drawing.Point(23, 73);
                this.treeView1.Size = new System.Drawing.Size(628, 754);
                this.groupBox1.Location = new System.Drawing.Point(691, 64);
                this.groupBox1.Size = new System.Drawing.Size(856, 679);
                this.txtChinaCodeName.Location = new System.Drawing.Point(205, 177);
                this.txtChinaCodeName.Size = new System.Drawing.Size(596, 26);
                this.txtHKCodeName.Location = new System.Drawing.Point(205, 225);
                this.txtHKCodeName.Size = new System.Drawing.Size(596, 26);
                this.txtMRCodeName.Location = new System.Drawing.Point(205, 271);
                this.txtMRCodeName.Size = new System.Drawing.Size(596, 26);
                this.flowLayoutPanelDept.Location = new System.Drawing.Point(12, 320);
                this.flowLayoutPanelDept.Size = new System.Drawing.Size(821, 111);*//*
                sizeOld = this.Width;
            }
            else if (this.Width < 1171 && sizeOld >= 1171)
            {
                *//*                this.treeView1.MaximumSize = new System.Drawing.Size(0, 0);*//*
                int w = this.Width;
                int h = this.Height;
                InitializeComponent();
                treeView1.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
                groupBox1.Anchor = AnchorStyles.Right | AnchorStyles.Top;
                txtChinaCodeName.Anchor = AnchorStyles.Right | AnchorStyles.Top;
                txtHKCodeName.Anchor = AnchorStyles.Right | AnchorStyles.Top;
                txtMRCodeName.Anchor = AnchorStyles.Right | AnchorStyles.Top;
                flowLayoutPanelDept.Anchor = AnchorStyles.Right | AnchorStyles.Top;
                this.Width = w;
                this.Height = h;
                *//*                this.groupBox1.Location = new System.Drawing.Point((int)(691 * 0.75172413793), (int)(64 * 0.8092175777));
                                this.groupBox1.Size = new System.Drawing.Size((int)(856 * 0.75172413793), (int)(679 * 0.8092175777));
                                this.treeView1.Location = new System.Drawing.Point((int)(23 * 0.75172413793), (int)(73 * 0.8092175777));
                                this.treeView1.Size = new System.Drawing.Size((int)(628 * 0.75172413793), (int)(754 * 0.8092175777));

                                this.txtChinaCodeName.Location = new System.Drawing.Point((int)(205 * 0.75172413793), (int)(177 * 0.8092175777));
                                this.txtChinaCodeName.Size = new System.Drawing.Size((int)(596 * 0.75172413793), (int)(26 * 0.8092175777));
                                this.txtHKCodeName.Location = new System.Drawing.Point((int)(205 * 0.75172413793), (int)(225 * 0.8092175777));
                                this.txtHKCodeName.Size = new System.Drawing.Size((int)(596 * 0.75172413793), (int)(26 * 0.8092175777));
                                this.txtMRCodeName.Location = new System.Drawing.Point((int)(205 * 0.75172413793), (int)(271 * 0.8092175777));
                                this.txtMRCodeName.Size = new System.Drawing.Size((int)(596 * 0.75172413793), (int)(26 * 0.8092175777));
                                this.flowLayoutPanelDept.Location = new System.Drawing.Point((int)(12 * 0.75172413793), (int)(320 * 0.8092175777));
                                this.flowLayoutPanelDept.Size = new System.Drawing.Size((int)(821 * 0.75172413793), (int)(111 * 0.8092175777));*//*
                sizeOld = this.Width;
            }*/
        }
    }
}

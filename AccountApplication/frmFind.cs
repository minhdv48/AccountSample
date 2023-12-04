using AccountApplication.SampleDataModel;
using SampleDataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace AccountApplication
{
    public partial class frmFind : Form
    {
        SampleDbContext db = new SampleDbContext("sampleDb");
        public delegate void IdentityUpdateHandler(object sender, IdentityUpdateEventArgs e);
        public event IdentityUpdateHandler IdentityUpdated;
        public frmFind()
        {
            InitializeComponent();
            var listDept = db.tDepts.Where(x => x.xDelFlag == "0");
            flowLayoutPanelDept.Controls.Clear();
            foreach (var item in listDept)
            {
                CheckBox cb = new CheckBox();
                cb.Text = item.xDeptCode;
                cb.Checked = false;
                flowLayoutPanelDept.Controls.Add(cb);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
        public class IdentityUpdateEventArgs : System.EventArgs
        {
            private AccCharts accChart;
            public IdentityUpdateEventArgs(AccCharts accChart)
            {
                this.accChart = accChart;
            }
            public AccCharts AccChart
            {
                get
                {
                    return accChart;
                }
            }
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            string ledger = "";
            if (radJS.Checked)
            {
                ledger = "JS";
            }
            else if (radOL.Checked)
            {
                ledger = "OL";
            }
            var listCB = flowLayoutPanelDept.Controls;
            List<string> list = new List<string>();
            foreach (var item in listCB)
            {
                var cb = (CheckBox)item;
                if (cb.Checked == true)
                {
                    list.Add(cb.Text);
                }
            }
            AccCharts res = new AccCharts();
            if (list != null && list.Count > 0)
            {
                var listRes = db.AccCharts.Where(x => (x.aChinaCode.Contains(txtChinaCode.Text) || txtChinaCode.Text == "")
&& (x.aHKCode.Contains(txtHKCode.Text) || txtHKCode.Text == "")
&& (x.aMrCode.Contains(txtMRCode.Text) || txtMRCode.Text == "")
&& (x.aName.Contains(txtChinaCodeName.Text) || txtChinaCodeName.Text == "")
&& (x.aHKName.Contains(txtHKCodeName.Text) || txtHKCodeName.Text == "")
&& (x.aMrName.Contains(txtMRCodeName.Text) || txtMRCodeName.Text == "")
&& (x.aLedger == ledger || ledger == ""));
                foreach (var item in listRes)
                {
                    bool check = true;
                    foreach(var item1 in list)
                    {
                        if (string.IsNullOrEmpty(item.aDeptCode) || !item.aDeptCode.Contains(item1))
                        {
                            check = false;
                            break;
                        }
                    }
                    if (check)
                    {
                        res = item;
                        break;
                    }
                }
            }
            else
            {
                res = db.AccCharts.Where(x => (x.aChinaCode.Contains(txtChinaCode.Text) || txtChinaCode.Text == "")
&& (x.aHKCode.Contains(txtHKCode.Text) || txtHKCode.Text == "")
&& (x.aMrCode.Contains(txtMRCode.Text) || txtMRCode.Text == "")
&& (x.aName.Contains(txtChinaCodeName.Text) || txtChinaCodeName.Text == "")
&& (x.aHKName.Contains(txtHKCodeName.Text) || txtHKCodeName.Text == "")
&& (x.aMrName.Contains(txtMRCodeName.Text) || txtMRCodeName.Text == "")
&& (x.aLedger == ledger || ledger == "")).FirstOrDefault();
            }
            //&& x. == groupBox4.Text || groupBox4.Text == ""
            if (res != null)
            {
                IdentityUpdateEventArgs args = new IdentityUpdateEventArgs(res);
                IdentityUpdated(this, args);
                this.Dispose();
                this.Close();
            }
            else
            {
                MessageBox.Show("No matching values");
            }
        }
    }
}

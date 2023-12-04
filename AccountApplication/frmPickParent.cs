using SampleDataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountApplication
{
    public partial class frmPickParent : Form
    {
        SampleDbContext db = new SampleDbContext("sampleDb");
        // add a delegate
        public delegate void IdentityUpdateHandler(object sender, IdentityUpdateEventArgs e);

        // add an event of the delegate type
        public event IdentityUpdateHandler IdentityUpdated;
        public int lv;
        public frmPickParent(int level)
        {
            InitializeComponent();
            // start off by adding a base treeview node
            TreeNode mainNode = new TreeNode();
            mainNode.Name = "Root";
            mainNode.Text = "Root";
            this.treeView1.Nodes.Add(mainNode);
            // Add child node
            Work(ref mainNode, 0, level);
            // Expand all nodes
            treeView1.ExpandAll();
            lv = level - 1;
        }
        public void Work(ref TreeNode parentNode, int parentId, int level)
        {
            try
            {
                var list = db.AccCharts.Where(x => x.aParentRef == parentId);
                foreach (var accChart in list)
                {
                    if (accChart.aLevel < level)
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
                        Work(ref node, accChart.Id, level);
                    }
                }
            }
            catch { }
        }
        public class IdentityUpdateEventArgs : System.EventArgs
        {
            private string level;
            private string parent;
            public IdentityUpdateEventArgs(string level, string parent)
            {
                this.level = level;
                this.parent = parent;
            }
            public string Level
            {
                get
                {
                    return level;
                }
            }
            public string Parent
            {
                get
                {
                    return parent;
                }
            }
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            var a = treeView1.SelectedNode.Name;
            if (a != "Root")
            {
                var parent = treeView1.SelectedNode.Parent.Name;
                var _parentInfo = db.AccCharts.Where(x => x.aHKName == a).FirstOrDefault();
                if (_parentInfo != null && _parentInfo.aLevel == lv)
                {
                    IdentityUpdateEventArgs args = new IdentityUpdateEventArgs(a, parent);
                    IdentityUpdated(this, args);
                    this.Dispose();
                    this.Close();
                }
            }
        }
    }
}

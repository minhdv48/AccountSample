using AccountApplication.SampleDataModel;
using SampleDataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountApplication
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            StartDemoUseFile();
        }

        private void accountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccounts accForm = new frmAccounts();
            accForm.MdiParent = this;
            //accForm.Dock = DockStyle.Fill;
            accForm.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            accForm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.FileInfo fileInfo = new System.IO.FileInfo(assembly.Location);
            DateTime lastModified = fileInfo.LastWriteTime;
            CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
            if (currentCulture.Name.Equals("zh"))
            {
                this.Text = "程序版本 " + Assembly.GetExecutingAssembly().GetName().Version.ToString() + "\t\t 调整 " + lastModified.ToLongDateString();
            }
            else
            {
                this.Text = "Program Version " + Assembly.GetExecutingAssembly().GetName().Version.ToString() + "\t\t Modify in " + lastModified.ToLongDateString();
            }

        }
        private static void StartDemoUseFile()
        {
            System.Console.WriteLine("DB Application (File)");
            System.Console.WriteLine(string.Empty);

            using (var context = new SampleDbContext("sampleDb"))
            {
                CreateAndSeedDatabase(context);
                //DisplaySeededData(context);
            }
        }
        private static void CreateAndSeedDatabase(DbContext context)
        {
            System.Console.WriteLine("Create and seed the database.");

            if (context.Set<AccCharts>().Count() == 0)
            {
                context.Set<AccCharts>().Add(new AccCharts
                {
                    aChinaCode = "",
                    aHKCode = "",
                    aName = "Fixed Assets",
                    aHKName = "Fixed Assets",
                    aLevel = 1,
                    aParentRef = 0,
                });
                context.Set<AccCharts>().Add(new AccCharts
                {
                    aChinaCode = "",
                    aHKCode = "",
                    aName = "Non-Current Assets",
                    aHKName = "Non-Current Assets",
                    aLevel = 1,
                    aParentRef = 0,
                });
                context.Set<AccCharts>().Add(new AccCharts
                {
                    aChinaCode = "",
                    aHKCode = "",
                    aName = "Current Assets",
                    aHKName = "Current Assets",
                    aLevel = 1,
                    aParentRef = 0,
                });
                context.SaveChanges();
            }
            if (context.Set<tDepts>().Count() == 0)
            {
                context.Set<tDepts>().Add(new tDepts
                {
                    xDeptCode = "OL",
                    xFullName = "OL",
                    xOrd = 0,
                    xDelFlag = "0",
                });
                context.Set<tDepts>().Add(new tDepts
                {
                    xDeptCode = "MD",
                    xFullName = "MD",
                    xOrd = 0,
                    xDelFlag = "0",
                });
                context.Set<tDepts>().Add(new tDepts
                {
                    xDeptCode = "EP",
                    xFullName = "EP",
                    xOrd = 0,
                    xDelFlag = "0",
                });
                context.Set<tDepts>().Add(new tDepts
                {
                    xDeptCode = "CC",
                    xFullName = "CC",
                    xOrd = 0,
                    xDelFlag = "0",
                });
                context.Set<tDepts>().Add(new tDepts
                {
                    xDeptCode = "DC",
                    xFullName = "DC",
                    xOrd = 0,
                    xDelFlag = "0",
                });
                context.Set<tDepts>().Add(new tDepts
                {
                    xDeptCode = "WK",
                    xFullName = "WK",
                    xOrd = 0,
                    xDelFlag = "0",
                });
                context.Set<tDepts>().Add(new tDepts
                {
                    xDeptCode = "WR",
                    xFullName = "WR",
                    xOrd = 0,
                    xDelFlag = "0",
                });
                context.Set<tDepts>().Add(new tDepts
                {
                    xDeptCode = "CE",
                    xFullName = "CE",
                    xOrd = 0,
                    xDelFlag = "0",
                });
                context.Set<tDepts>().Add(new tDepts
                {
                    xDeptCode = "TR",
                    xFullName = "TR",
                    xOrd = 0,
                    xDelFlag = "0",
                });
                context.Set<tDepts>().Add(new tDepts
                {
                    xDeptCode = "PO",
                    xFullName = "PO",
                    xOrd = 0,
                    xDelFlag = "0",
                });
                context.Set<tDepts>().Add(new tDepts
                {
                    xDeptCode = "DS",
                    xFullName = "DS",
                    xOrd = 0,
                    xDelFlag = "0",
                });
                context.Set<tDepts>().Add(new tDepts
                {
                    xDeptCode = "ME",
                    xFullName = "ME",
                    xOrd = 0,
                    xDelFlag = "0",
                });
                context.Set<tDepts>().Add(new tDepts
                {
                    xDeptCode = "QX",
                    xFullName = "QX",
                    xOrd = 0,
                    xDelFlag = "0",
                });
                context.Set<tDepts>().Add(new tDepts
                {
                    xDeptCode = "ST",
                    xFullName = "ST",
                    xOrd = 0,
                    xDelFlag = "0",
                });
                context.Set<tDepts>().Add(new tDepts
                {
                    xDeptCode = "VP",
                    xFullName = "VP",
                    xOrd = 0,
                    xDelFlag = "0",
                });
                context.Set<tDepts>().Add(new tDepts
                {
                    xDeptCode = "YS",
                    xFullName = "YS",
                    xOrd = 0,
                    xDelFlag = "0",
                });
                context.Set<tDepts>().Add(new tDepts
                {
                    xDeptCode = "DG",
                    xFullName = "DG",
                    xOrd = 0,
                    xDelFlag = "0",
                });
                context.SaveChanges();
            }
            return;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
            string msg = "Do you really want to quit application?";
            if (currentCulture.Name.Equals("zh"))
            {
                msg = "您真的要退出应用程序吗？";
            }
           
            DialogResult result = MessageBox.Show(msg, "AccountApp", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void chineseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("zh");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh");
            this.Controls.Clear();
            InitializeComponent();
            frmMain_Load(sender, e);
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            this.Controls.Clear();
            InitializeComponent();
            frmMain_Load(sender, e);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountApplication
{
    public partial class frmSelectPrint : Form
    {
        public frmSelectPrint()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(radChinaCode.Checked == true)
            {
                frmPrint frm = new frmPrint("ChinaCode");
                frm.Show();
            }
            else if(radHKCode.Checked == true)
            {
                frmPrint frm = new frmPrint("HKCode");
                frm.Show();
            }
        }
    }
}

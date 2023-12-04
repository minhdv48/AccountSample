using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountApplication
{
    public partial class frmSelectLevel : Form
    {

        // add a delegate
        public delegate void IdentityUpdateHandler(object sender, IdentityUpdateEventArgs e);

        // add an event of the delegate type
        public event IdentityUpdateHandler IdentityUpdated;

        public frmSelectLevel()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int lvlChecked = 0;
            if (radLvl1.Checked)
                lvlChecked = 1;
            if (radLvl2.Checked)
                lvlChecked = 2;
            if (radLvl3.Checked)
                lvlChecked = 3;
            IdentityUpdateEventArgs args = new IdentityUpdateEventArgs(lvlChecked);
            IdentityUpdated(this, args);
            this.Dispose();
            this.Close();
        }
        public class IdentityUpdateEventArgs : System.EventArgs
        {
            private int level;
            public IdentityUpdateEventArgs(int level)
            {
                this.level = level;
            }
            public int Level
            {
                get
                {
                    return level;
                }
            }
        }
    }
}

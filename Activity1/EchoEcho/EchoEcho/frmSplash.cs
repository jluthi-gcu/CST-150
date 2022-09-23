using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EchoEcho
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void stMain_Tick(object sender, EventArgs e)
        {
            //Stop timer.
            stMain.Stop();

            //Hide current form.
            this.Hide();

            //Open main form.
            Form frm = new frmMain();
            frm.ShowDialog();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuckyNumber
{
    public partial class frmLuckNumberOutput : Form
    {
        public frmLuckNumberOutput(int luckyNumber)
        {
            InitializeComponent();

            lblLuckyNumber.Text = "\U0001fa84 " + luckyNumber.ToString() + "!";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}

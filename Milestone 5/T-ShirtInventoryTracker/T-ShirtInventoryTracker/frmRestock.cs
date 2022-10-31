using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_ShirtInventoryTracker
{
    public partial class frmRestock : Form
    {
        public int RestockAmount { get; set; }

        public frmRestock()
        {
            InitializeComponent();
        }

       

        private void btnRestock_Click(object sender, EventArgs e)
        {
            //If user types non-numeric or clears textbox, default qty to 0
            RestockAmount = int.TryParse(txtQty.Text, out _) ? int.Parse(txtQty.Text) : 0; 

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

//Solution: Pounds2Kilograms
//Author: Joel Luthi
//Date: 9/12/2022
//Purpose: Demonstrate converting values using controls.

namespace Pounds2Kilograms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //If pounds is blank and can convert to a numeric then get kilograms.
            if (!string.IsNullOrEmpty(txtPounds.Text) && double.TryParse(txtPounds.Text, out _))
            {
                double pounds = Convert.ToDouble(txtPounds.Text);
                double kilograms = pounds * 0.453592;

                txtKilograms.Text = kilograms.ToString();
            }
        }

   
    }
}
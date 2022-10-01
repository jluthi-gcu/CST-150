//Solution: Pounds2Kilograms
//Author: Joel Luthi
//Date: 9/12/2022
//Purpose: Demonstrate converting values using controls.
//Citation: I used code from the following websites to solve defaulted rounding in case the user does not want rounding.
//https://stackoverflow.com/questions/11744264/c-sharp-how-to-format-a-double-to-one-decimal-place-without-rounding

namespace Pounds2Kilograms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void btnConvert_Click(object sender, EventArgs e)
        {
            //Exception handling for empty or non-numeric value.
            //If pounds is not blank and can convert to a numeric then get kilograms.
            if (!string.IsNullOrEmpty(txtPounds.Text) && double.TryParse(txtPounds.Text, out _))
            {
                //Extra exception handling in case something goes wrong.
                try
                {
                    double pounds = Convert.ToDouble(txtPounds.Text);
                    double kilograms = pounds * 0.453592;

                    if (chxRound.Checked)
                    {
                        //Default behavior of ToString's format overload rounds up returns a rounded up value
                        txtKilograms.Text = kilograms.ToString("0.000");

                    }
                    else
                    {
                        //This does not round hundreths place
                        txtKilograms.Text = string.Format("{0:0.000}", Math.Truncate(kilograms * 1000) / 1000);

                    }



                }
                catch (Exception ex)
                {   
                    MessageBox.Show(ex.Message);   
                }
             
            }



        }

       
    }
}
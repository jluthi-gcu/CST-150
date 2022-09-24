//Solution: SecondsConverter
//Author: Joel Luthi
//Date: 9/24/2022
//Purpose: A Windows Forms Application that prompts the user to enter the number of seconds elapsed, and converts 
//to minutes, hours, and days.

using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondsConverter
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {

            //Check entered value is numeric.
            if (!int.TryParse(txtSeconds.Text.ToString(), out _))
            {
                //Tell user the value entered is not numeric.
                lbOutput.Items.Add("\"" + txtSeconds.Text.ToString() + "\" is not a numeric value. Unable to Convert.");
                
                //Escape method.
                return;
            }
            
            //Convert entered text value to int.
            int value = int.Parse(txtSeconds.Text.ToString());

            //Convert to Days if possible.
            //Example of relational operators.
            if (value >= 86400)
            {
                lbOutput.Items.Add("\"" + value + "\" seconds converts to " + (value / 86400) + " day(s).");
            }
            //Convert to Hours if possible.
            //Example of relational operators and a logical operator.
            else if (value > 3600 || value == 3600)
            {
                lbOutput.Items.Add("\"" + value + "\" seconds converts to " + (value / 3600) + " hour(s).");
            }
            //Convert to Minutes if possible.
            else if (value >= 60)
            {
                lbOutput.Items.Add("\"" + value + "\" seconds converts to " + (value / 60) + " minute(s).");
            }
            //To small to convert.
            else
            {
                lbOutput.Items.Add("\"" + value + "\" is to small of a value to convert.");
            }

            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear output listbox.
            lbOutput.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close program.
            this.Close();
        }
    }
}

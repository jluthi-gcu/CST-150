using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIApproximation
{
    //Solution: PIApproximation
    //Author: Joel Luthi
    //Date: 10/02/2022
    //Purpose: Calculates the value of the sequence for the specified number of terms entered by the user.

    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //Get user's entered term value and check if numeric value.
                int terms = 0;
                if (int.TryParse(txtTerms.Text.ToString(), out terms))
                {
                    //Used to calculate than output final result.
                    double answer = 0;

                    int denominator = 3;
                    bool opperatorAdd = false;

                    //If user just enters zero default to 4.
                    if (terms == 0)
                    {
                        answer = 4;
                    }


                    for (int i = 0; i < terms; i++)
                    {
                        if (i == 0)
                        {
                            answer = 4;
                        }
                        else
                        {
                            if (opperatorAdd)
                            {
                                answer += (4f / (double)denominator);
                            }
                            else
                            {
                                answer -= (4f / (double)denominator);
                            }

                            //Flip operator every time.
                            opperatorAdd = !opperatorAdd;
                            denominator += 2;
                        }
                    }

                    //Display to user.
                    lblOutput.Text = "Approximate value of pi after " + terms + " is: " + answer.ToString();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error. Unable to process. \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

     
    }
}

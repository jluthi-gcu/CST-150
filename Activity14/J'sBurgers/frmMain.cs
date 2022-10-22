//Solution: J's Burgers
//Author: Joel Luthi
//Date: 10/22/2022
//Purpose: A WinForms application demoing the usage of RadioButton, CheckBox, and ListBox controls.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace J_sBurgers
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAddBurger_Click(object sender, EventArgs e)
        {
            btnCheckOut.Enabled = true;

            lbCart.Items.Add("1x Burger");
        }

        private void btnAddFry_Click(object sender, EventArgs e)
        {
            btnCheckOut.Enabled = true;

            lbCart.Items.Add("1x Fry");
        }

        private void btnAddDrink_Click(object sender, EventArgs e)
        {
            btnCheckOut.Enabled = true;

            lbCart.Items.Add("1x Drink");
        }


        private void btnCheckOut_Click(object sender, EventArgs e)
        {

            //Show dipping sauce message to order status if user had selcted any dipping suaces.
            string dippingSauceMessage = "";

            if (chxHotSauce.Checked || chxMediumSauce.Checked || chxHotSauce.Checked)
            {
                dippingSauceMessage = "\n\nThe following dipping sauces will be included: \n" ;


                if (chxMildSauce.Checked)
                {
                    dippingSauceMessage += "\n" + chxMildSauce.Text;
                }

                if (chxMediumSauce.Checked)
                {
                    dippingSauceMessage += "\n" + chxMediumSauce.Text;
                }

                if (chxHotSauce.Checked)
                {
                    dippingSauceMessage += "\n" + chxHotSauce.Text;
                }

            }

            //Show Order Status
            if (rdbDineIn.Checked)
            {
                MessageBox.Show($"Your meal of {lbCart.Items.Count} items is being prepared for - Dine In." + dippingSauceMessage, "Order Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Your meal of {lbCart.Items.Count} items is being prepared - To Go." + dippingSauceMessage, "Order Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            //Thank for tip and wish a good day!
            if (!rdbNoTip.Checked)
            {
                int tipPercent = 0;

                if (rdbTip10.Checked)
                {
                    tipPercent = 10;
                }
                else if (rdbTip15.Checked)
                {
                    tipPercent = 15;
                }
                else
                {
                    tipPercent = 20;
                }


                MessageBox.Show($"Thank you for the generous tip of {tipPercent}%! \n\nHave a great day!", "Complete");
            }
            else
            {

                MessageBox.Show("Have a great day!", "Complete");
            }


            //Clear
            lbCart.Items.Clear();
            btnCheckOut.Enabled = false;

        }


    }
}

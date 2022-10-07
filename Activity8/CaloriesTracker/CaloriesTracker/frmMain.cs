using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CaloriesTracker
{
    //Solution: CaloriesTracker
    //Author: Joel Luthi
    //Date: 10/07/2022
    //Purpose: Calculates from the user's entered number of fat grams and carbohydrate grams consumed in a day
    //and returns their respective caloric values.
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        //Calculates the fat calories form the passed in fat grams.
        public int FatCalories(int fatGrams)
        {
            int fatCalories = fatGrams * 9;

            return fatCalories;
        }


        //Calculates the carb calories form the passed in carb grams.
        public int CarbCalories(int carbGrams)
        {
            int carbCalcories = carbGrams * 4;

            return carbCalcories;
        }


        //Calculate the total calories consumed from the passed in fat calories and carb calories.
        public int TotalCalories(int fatCalories, int carbCalories)
        {
            int totalCalories = fatCalories + carbCalories;

            return totalCalories;
        }


        //Gets fat calories and displays value to the GUI.
        private void btnCalcFatCalories_Click(object sender, EventArgs e)
        {   
            //Check for valid int.
            if (int.TryParse(txtFatGrams.Text, out _))
            {
                lblOutputFatCalories.Text = FatCalories(int.Parse(txtFatGrams.Text)).ToString();
            }
            else
            {
                lblOutputFatCalories.Text = "-";
            }

        }


        //Gets carb calories and displays value to the GUI.
        private void btnCalcCarbCalories_Click(object sender, EventArgs e)
        {
            //Check for valid int.
            if (int.TryParse(txtCarbGrams.Text, out _))
            {
                lblOutputCarbCalories.Text = CarbCalories(int.Parse(txtCarbGrams.Text)).ToString();
            }
            else
            {
                lblOutputCarbCalories.Text = "-";
            }

        }


        //Gets total calories consumed and displays value to the GUI.
        private void btnCalcTotal_Click(object sender, EventArgs e)
        {
            int fatCalories = 0;
            int carbCalories = 0;

            //Check for valid int.
            if (int.TryParse(txtFatGrams.Text, out _))
            {
                fatCalories = FatCalories(int.Parse(txtFatGrams.Text));
            }

            //Check for valid int.
            if (int.TryParse(txtCarbGrams.Text, out _))
            {
                carbCalories = CarbCalories(int.Parse(txtCarbGrams.Text));
            }

            int totalCalories = TotalCalories(fatCalories, carbCalories);


            lblOutputTotalCalories.Text = totalCalories.ToString();


        }




    }
}

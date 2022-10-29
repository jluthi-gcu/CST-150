//Solution: LuckyNumber
//Author: Joel Luthi
//Date: 10/29/2022
//Purpose: A small program to find lucky number based on user's birthday & favorite color.


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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadYearDropDown();

            LoadFavoriteColor();
        }


        private void LoadYearDropDown()
        {
            cboBirthYear.Items.Clear();

            //Add years from 1900 to 3000; 
            for (int i = 1900; i <= 3000; i++)
            {
                cboBirthYear.Items.Add(i);

            }

            //Default selected year to current year.
            cboBirthYear.SelectedItem = DateTime.Today.Year;

        }


        private void LoadMonthDropDown()
        {
            cboBirthMonth.Items.Clear();

            cboBirthMonth.Items.Add("January");
            cboBirthMonth.Items.Add("Febuary");
            cboBirthMonth.Items.Add("March");
            cboBirthMonth.Items.Add("April");
            cboBirthMonth.Items.Add("May");
            cboBirthMonth.Items.Add("June");
            cboBirthMonth.Items.Add("July");
            cboBirthMonth.Items.Add("Auguest");
            cboBirthMonth.Items.Add("September");
            cboBirthMonth.Items.Add("October");
            cboBirthMonth.Items.Add("November");
            cboBirthMonth.Items.Add("December");

        }

        private void LoadDayDropDown()
        {
            cboBirthDay.Items.Clear();
            
            if (cboBirthYear.SelectedItem != null && cboBirthMonth.SelectedIndex >= 0)
            {
                int daysInMonth = DateTime.DaysInMonth(int.Parse(cboBirthYear.SelectedItem.ToString()), (cboBirthMonth.SelectedIndex + 1));
                for (int i = 1; i <= daysInMonth; i++)
                {
                    cboBirthDay.Items.Add(i);
                }
            }
          

        }


        private void LoadFavoriteColor()
        {
            cboFavoriteColor.Items.Clear();

            cboFavoriteColor.Items.Add("Black");
            cboFavoriteColor.Items.Add("Blue");
            cboFavoriteColor.Items.Add("Brown");
            cboFavoriteColor.Items.Add("Green");
            cboFavoriteColor.Items.Add("Orange");
            cboFavoriteColor.Items.Add("Purple");
            cboFavoriteColor.Items.Add("Red");
            cboFavoriteColor.Items.Add("White");
            cboFavoriteColor.Items.Add("Yellow");

        }

        //Load month dropdown once user selects year.
        private void cboBirthYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMonthDropDown();
        }

        //Load day dropdown once user selects month since number of days in month are based on year & month.
        private void cboBirthMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDayDropDown();
        }

      

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //Calculate lucky number only if all ComboxBoxes are selected.
            if (cboBirthYear.SelectedIndex >= 0 && cboBirthMonth.SelectedIndex >= 0 && cboBirthDay.SelectedIndex >= 0 && cboFavoriteColor.SelectedIndex >= 0)
            {
                string year = cboBirthYear.SelectedItem.ToString();
                int month = cboBirthMonth.SelectedIndex + 1;
                int day = int.Parse(cboBirthDay.SelectedItem.ToString());
                string favoriteColor = cboFavoriteColor.Items.ToString();

                //Calculates lucky number
                int luckyNuber = (year.Length + month + day) * favoriteColor.Length;

                //Displays lucky number to user.
                Form frm = new frmLuckNumberOutput(luckyNuber);
                frm.ShowDialog();


                //Reset UI
                cboBirthDay.Items.Clear();
                cboBirthMonth.Items.Clear();
                LoadYearDropDown();
                LoadFavoriteColor();

            }
            else
            {
                //If not all comboboxes selected, tell user.
                MessageBox.Show("Select all ComboBoxes to find your lucky number.");
            }

           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

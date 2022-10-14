//Solution: Roll2Die
//Author: Joel Luthi
//Date: 10/13/2022
//Purpose: A small game where the user rolls two dice and tries to get snake eyes in the lowest number of roles.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roll2Die
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnRollDie_Click(object sender, EventArgs e)
        {
            //Prevents user from spamming clicks and queing up games.
            btnRollDie.Enabled = false;

            Dice dice1 = new Dice(6);
            Dice dice2 = new Dice(6);

            int dice1Roll = 0;
            int dice2Roll = 0;

            int rollCount = 0;

            do
            {
                //Update roll count.
                rollCount++;

                dice1Roll = dice1.rollDie();
                dice2Roll = dice2.rollDie();

                lblDie1.Text = dice1Roll.ToString();
                lblDie2.Text = dice2Roll.ToString();
                
                //This helps update the UI while in loop.
                Application.DoEvents();

                //Slows down between rolls so user has time to read.
                Thread.Sleep(100);


              
            } while ((dice1Roll == 1 && dice2Roll == 1) == false);



            MessageBox.Show("You rolled snake eyes in " + rollCount.ToString() + " rolls!", "Snake Eyes Rolled", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);


            //Allow game to be played again.
            btnRollDie.Enabled = true;
        }

       
    }
}

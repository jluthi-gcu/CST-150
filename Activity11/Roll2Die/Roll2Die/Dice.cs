using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roll2Die
{
    public class Dice
    {
        private Random _Random = new Random();

        private int _NumberOfSides = 0;

        public Dice(int numberOfSides)
        {
            if (numberOfSides < 4 || numberOfSides > 20)
            {
                MessageBox.Show("The number of sides must be between 4 and 20 inclusively.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _NumberOfSides = numberOfSides;
            }

        }

        public int rollDie()
        {
            //Return 
            return _Random.Next(1, _NumberOfSides);

        }


    }
}

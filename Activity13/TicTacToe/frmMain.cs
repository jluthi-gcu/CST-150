//Solution: TicTacToe
//Author: Joel Luthi
//Date: 10/22/2022
//Purpose: A small game of Tic Tac Toe demonstrating the usage of a 2d array.


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

namespace TicTacToe
{
    public partial class frmMain : Form
    {
        Random _Random = new Random();
        char[,] _BoardArray = new char[3, 3];

        char _CurrentPlayersTurn = 'X';

        int _TurnsLeft = 9;

        public frmMain()
        {
            InitializeComponent();
        }


        private void btnNewGame_Click(object sender, EventArgs e)
        {
            lblOutput.Text = String.Empty;

            ClearBoard();

            //Reset number of turns.
            _TurnsLeft = 9;

            //Player x always goes first.
            _CurrentPlayersTurn = 'X';


            PlayGame();


        }

        public void PlayGame()
        {
            //Game loop
            while (true)
            {
                Spot randomSpot = GetRandomAvailableSpot();

                //Place current players mark
                _BoardArray[randomSpot.Row, randomSpot.Column] = _CurrentPlayersTurn;

                UpdateBoard();
                //This makes UI changes show.
                Application.DoEvents();


                _TurnsLeft--;

                //Check if current player just won.
                if (CheckWin())
                {
                    lblOutput.Text = $"Player {_CurrentPlayersTurn} Wins!";
                    break;
                }

                //Check if turns are over.
                if (_TurnsLeft == 0)
                {
                    lblOutput.Text = "Game Ended in a Tie";
                    break;
                }


                //Switch players for next turn.
                if (_CurrentPlayersTurn == 'X')
                {
                    _CurrentPlayersTurn = 'O';
                }
                else
                {
                    _CurrentPlayersTurn = 'X';
                }

                //Add delay between turns so user can seem game played out on ui.
                Thread.Sleep(250);


            }


        }

        //Resets the game board.
        public void ClearBoard()
        {
            for (int row = 0; row < _BoardArray.GetLength(0); row++)
            {
                for (int column = 0; column < _BoardArray.GetLength(1); column++)
                {
                    _BoardArray[row, column] = ' ';
                }
            }
        }

        //Returns a random 
        public Spot GetRandomAvailableSpot()
        {
            int randomRow = 0;
            int randomColumn = 0;

            do
            {
                //Returns a random number 0 - 2
                randomRow = _Random.Next(3);
                randomColumn = _Random.Next(3);

            } while (IsSpotAvailable(randomRow, randomColumn) == false);

            return new Spot(randomRow, randomColumn);
        }


        //Returns if passed in row & column already has a value. Returns false otherwise.
        public bool IsSpotAvailable(int row, int column)
        {
            if (_BoardArray[row, column] == ' ')
            {
                return true;
            }

            return false;

        }



        //Updates the UI board with the contents of the 2d array.
        public void UpdateBoard()
        {
            for (int row = 0; row < _BoardArray.GetLength(0); row++)
            {
                for (int column = 0; column < _BoardArray.GetLength(1); column++)
                {
                    Label lbl = (Label)this.Controls.Find("lbl" + row + "_" + column, false)[0];
                    lbl.Text = _BoardArray[row, column].ToString();
                }
            }

        }

       //Checks if current player won.
        public bool CheckWin()
        {
            char? previousValue = null;
            bool match = false;

            //Check for row win.
            for (int row = 0; row < _BoardArray.GetLength(0); row++)
            {
                for (int column = 0; column < _BoardArray.GetLength(1); column++)
                {
                    if (previousValue == null)
                    {
                        previousValue = _BoardArray[row, column];
                    }
                    else
                    {
                        if (_BoardArray[row, column] != ' ' && _BoardArray[row,column] == previousValue)
                        {
                            match = true;
                        }
                        else
                        {
                            match = false; 
                            previousValue = null;

                            //Move on to next row
                            break;
                        }

                    }

                    //If match and on last cell then this equals win!
                    if (match && column == _BoardArray.GetLength(1) - 1)
                    {
                        return true;
                    }
                }

           
           
            }


            previousValue = null;
            match = false;

            //Check for column win.
            for (int column = 0; column < _BoardArray.GetLength(1); column++)
            {
                for (int row = 0; row < _BoardArray.GetLength(0); row++)
                {
                    if (previousValue == null)
                    {
                        previousValue = _BoardArray[row, column];
                    }
                    else
                    {
                        if (_BoardArray[row, column] != ' ' && _BoardArray[row, column] == previousValue)
                        {
                            match = true;
                        }
                        else
                        {
                            match = false;
                            previousValue = null;
                            //Move on to next column
                            break;
                        }

                    }

                    //If match and on last cell then this equals win!
                    if (match && row == _BoardArray.GetLength(0) - 1)
                    {
                        return true;
                    }
                }


            }


           
            //Check for diagonal left to right win.
            if (_BoardArray[0,0] != ' ')
            {
                if (_BoardArray[0, 0] == _BoardArray[1, 1] && _BoardArray[0, 0] == _BoardArray[2, 2])
                    return true;

            }

            //Check diagonal right to left win.
            if (_BoardArray[0, 2] != ' ')
            {
                if (_BoardArray[0, 2] == _BoardArray[1, 1] && _BoardArray[0, 2] == _BoardArray[2, 0])
                    return true;
            }


            return false;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }

    //A class to represent the row and column spot of the game board.
    public class Spot
    {
        public int Row { get; set; }

        public int Column { get; set; }

        public Spot(int row, int column)
        {
            Row = row;
            Column = column;
        }

    }


}

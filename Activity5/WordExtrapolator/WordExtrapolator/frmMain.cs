using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordExtrapolator
{
    //Solution: WordExtrapolator
    //Author: Joel Luthi
    //Date: 10/01/2022
    //Purpose: A Windows Forms Application allows the user to select a file with a list of words and displays the stats to a textbox and file.
    //Sources Used to Help Complete:
    //https://www.c-sharpcorner.com/UploadFile/mahesh/compare-strings-in-C-Sharp/
    //https://zetcode.com/csharp/filestream/
    //https://learn.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-save-files-using-the-savefiledialog-component?view=netframeworkdesktop-4.8

    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //Allows user to select a file, processes the file, and outputs results to both a textbox and a file called output.txt
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.Title = "Read File";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;


                    Stream fileStream = openFileDialog.OpenFile();

                    try
                    {
                        using (StreamReader reader = new StreamReader(fileStream))
                        {
                            List<string> words = new List<string>();

                            string line = "";
                            while ((line = reader.ReadLine()) != null)
                            {
                                words.Add(line);

                            }

                            //If less than two words, do not process.
                            if (words.Count < 2)
                            {
                                MessageBox.Show("Not enough words in file to process.", "Processing Stopped", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }

                            //Make all words lower-case first before processing comparisions since c# is case-senstive.
                            words = MakeLowerCase(words);


                            string stats = ProcessWords(words);


                            //Output stats to text box
                            txtOutput.Text = stats;


                            //Output to file. 
                            if (MessageBox.Show("Would you like to save stats to the default location below? \n\n" + System.IO.Path.GetDirectoryName(Application.ExecutablePath), "File Processed", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {

                                //Overwrites current file if already there. Else it will create it.
                                using (FileStream fs = File.Open("output.txt", FileMode.Create))
                                {
                                    byte[] bytes = Encoding.UTF8.GetBytes(stats);

                                    fs.Write(bytes, 0, bytes.Length);

                                }

                                MessageBox.Show("File Saved");

                            }
                            else
                            {
                                SaveFileDialog saveFileDialog = new SaveFileDialog();
                                saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                                saveFileDialog.Title = "Save To File";
                                saveFileDialog.FileName = "output.txt";
                                saveFileDialog.ShowDialog();


                                if (saveFileDialog.FileName != "")
                                {

                                    using (FileStream fs = (System.IO.FileStream)saveFileDialog.OpenFile())
                                    {
                                        byte[] bytes = Encoding.UTF8.GetBytes(stats);

                                        fs.Write(bytes, 0, bytes.Length);

                                    }


                                    MessageBox.Show("File Saved");

                                }
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                }
            }
        }


        public List<string> MakeLowerCase(List<string> words)
        {
            List<string> newList = new List<string>();

            foreach (var word in words)
            {
                newList.Add(word.ToLower());
            }

            return newList;
        }



        public string ProcessWords(List<string> words)
        {
            string stats = string.Empty;

            string firstAlphabetically = words[0];
            string lastAlphabetically = words[0];

            string shortest = words[0];
            int shortestLength = words[0].Length;

            string longest = words[0];
            int longestLength = words[0].Length;

            string mostVowels = words[0];
            int vowelCount = NumberOfVowels(words[0]);

            foreach (var word in words)
            {
                //Check for first Alphabetically
                if (string.Compare(word, firstAlphabetically) < 0)
                {
                    firstAlphabetically = word;
                }

                //Check for last Alphabetically
                if (string.Compare(word, lastAlphabetically) > 0)
                {
                    lastAlphabetically = word;
                }


                //Check for shortest word
                if (word.Length < shortestLength)
                {
                    shortest = word;
                    shortestLength = word.Length;

                }
                //If equal in length and not existing already (i.e first word pass through), append it to variable.
                else if (word.Length == shortestLength && !shortest.Contains(word))
                {
                    shortest += " " + word;
                }


                //Check for longest word
                if (word.Length > longestLength)
                {
                    longest = word;
                    longestLength = word.Length;

                }
                //If equal in length and not existing already (i.e first word pass through), append it to variable.
                else if (word.Length == longestLength && !longest.Contains(word))
                {
                    longest += " " + word;
                }


                //Check for most vowels
                int currentWordVowelCount = NumberOfVowels(word);
                if (currentWordVowelCount > vowelCount)
                {
                    mostVowels = word;
                    vowelCount = currentWordVowelCount;

                }
                // If equal in length and not existing already(i.e first word pass through), append it to variable.
                else if (currentWordVowelCount == vowelCount && !mostVowels.Contains(word))
                {
                    mostVowels += " " + word;
                }


            }


            stats += $"First Word Alphabetically: {firstAlphabetically}";
            stats += $"{Environment.NewLine}Last Word Alphabetically: {lastAlphabetically}";
            stats += $"{Environment.NewLine}Shortest Word(s): {shortest}";
            stats += $"{Environment.NewLine}Longest Word(s): {longest}";
            stats += $"{Environment.NewLine}Word(s) with most vowels: {mostVowels}";
            return stats;
        }


        public int NumberOfVowels(string word)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

            int count = 0;
            foreach (var letter in word.ToCharArray())
            {
                foreach (var vowel in vowels)
                {
                    if (letter == vowel)
                    {
                        count++;
                    }
                }
            }

            return count;

        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutput.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

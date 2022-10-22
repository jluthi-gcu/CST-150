//Solution: Activity12
//Author: Joel Luthi
//Date: 10/22/2022
//Purpose: 
//Sources Used to Help Complete:
//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-read-a-text-file-one-line-at-a-time
//https://stackoverflow.com/questions/14899422/how-to-navigate-a-few-folders-up


using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Activity12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string words = "";

            string path = System.IO.Directory.GetCurrentDirectory();

            //Navigates up to project root folder were input file resides. 
            path = Path.GetFullPath(Path.Combine(path, @"..\..\..\"));

            //Gets all lines from specified file and puts them into one string variable.
            foreach (string line in System.IO.File.ReadLines(path + "input.txt"))
            {
                words += line.ToLower();
            }

            //Split string of words from file into an array.
            string[] wordArray = words.Split(' ');


            //Keeps track of words ending with t or e.
            int matchCount = 0;
            
            foreach (string word in wordArray)
            {
                for (int i = word.Length-1; i >= 0; i--)
                {
                    char c = word[i];
                    //Checks if last character is a letter. If not move to next character back.
                    if (char.IsLetter(c))
                    {
                        //Checks letter character if it matches t or e.
                        if (c == 't'|| c == 'e')
                        {
                            matchCount++;
                        }

                        break;
                    }
                   
                }
            }


            System.Console.WriteLine($"There were {wordArray.Length} words read from the following input: ");

            System.Console.WriteLine("\n\"" + words + "\"");


            System.Console.WriteLine($"\nFrom these words, {matchCount} were found to end in t or e.");

            Console.WriteLine("\n\nPress any key to quit...");
            System.Console.ReadKey();


        }
    }
}

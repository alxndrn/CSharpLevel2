/* 
 * Write a program that reads a text file and prints on the console its
 * odd lines.
*/

using System;
using System.IO;

namespace CSharpLevel2_Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "test.txt";

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                int linenumber = 0;
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    linenumber++;
                    if (linenumber % 2 != 0)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
        }
    }
}

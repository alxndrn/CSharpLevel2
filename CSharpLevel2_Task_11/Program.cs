/*
 * Write a program that deletes from a text file all words that start
 * with the prefix "test". Words contain only the symbols 0...9, a...z,
 * A...Z, _.
*/

using System;
using System.IO;
using System.Text.RegularExpressions;

namespace CSharpLevel2_Task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter("output.txt");
            StreamReader reader = new StreamReader("test.txt");

            using (writer)
            {
                using (reader)
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        line = Regex.Replace(line, @"(\b)test((\d|\w|_)*)(\b)", "");
                        writer.WriteLine(Regex.Replace(line, @"(\s){2,}", " "));
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}

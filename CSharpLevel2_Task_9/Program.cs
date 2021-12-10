/*
 * Write a program that reads a text file and inserts line numbers in
 * front of each of its lines. The result should be written to another
 * text file.
*/

using System;
using System.IO;
using System.Text;

namespace CSharpLevel2_Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "test.txt";
            string newFilePath = "newfile.txt";

            StreamReader sr = File.OpenText(path);

            string s = "";
            int counter = 1;
            StringBuilder sb = new StringBuilder();

            while ((s = sr.ReadLine()) != null)
            {
                var lineOutput = counter++ + " " + s + "\n";
                sb.Append(lineOutput);
            }

            sr.Close();

            if (!File.Exists(newFilePath))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.AppendText(newFilePath))
                {
                    sw.Write(sb);
                    sw.Close();
                }
            }
        }
    }
}

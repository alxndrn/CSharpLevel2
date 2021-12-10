/* 
 * Write a program that concatenates two text files into another text
 * file.
*/

using System;
using System.IO;

namespace CSharpLevel2_Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = "test.txt";
            string path2 = "append.txt";
            string newFilePath = "newfile.txt";

            string allText = File.ReadAllText(path1);
            allText += "\r\n";
            allText += File.ReadAllText(path2);

            if (!File.Exists(newFilePath))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(newFilePath))
                {
                    sw.Write(allText);
                }
            }
        }
    }
}

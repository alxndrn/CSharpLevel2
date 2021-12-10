/* 
 * Write a program that compares two text files line by line and prints
 * the number of lines that are the same and the number of lines that
 * are different. Assume the files have equal number of lines.
*/


using System;
using System.IO;
using System.Text;

namespace CSharp_Level2_Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = "test_1.txt";
            string path2 = "test_2.txt";

            StreamReader sr1 = File.OpenText(path1);
            StreamReader sr2 = File.OpenText(path2);

            string s1 = "", s2 = "";
            int counterEquals = 0, counterDifferent = 0;

            StringBuilder sb = new StringBuilder();

            while ((s1 = sr1.ReadLine()) != null && (s2 = sr2.ReadLine()) != null)
            {
                if (s1.Equals(s2))
                {
                    counterEquals++;
                }
                else
                {
                    counterDifferent++;
                }
            }

            sr1.Close();
            sr2.Close();

            Console.WriteLine($"Eqaul lines: {counterEquals}, different lines: {counterDifferent}");
        }
    }
}

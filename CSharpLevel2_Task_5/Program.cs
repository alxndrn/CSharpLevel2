/*
 * Implement an extension method Substring(int index, int length)
 * for the class StringBuilder that returns new StringBuilder and has
 * the same functionality as Substring in the class String.
*/

using System;
using System.Text;
using CSharpLevel2_Task_5.Data;

namespace CSharpLevel2_Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("My name is Alexandrina!");
            StringBuilder result = sb.Substring(11, sb.Length - 11);
            Console.WriteLine(result.ToString());
        }
    }
}

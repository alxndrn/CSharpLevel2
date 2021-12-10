/* 
 * Write a program that counts in a given array of double values the
 * number of occurrences of each value. Use Dictionary<TKey,TValue>.
*/

using System;
using System.Collections.Generic;

namespace CSharpLevel2_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToDouble(arrTemp));
            Dictionary<double, int> occurances = new Dictionary<double, int>(arr.Length);

            for (int i = 0; i < arr.Length; i++)
            {
                if (!occurances.ContainsKey(arr[i]))
                {
                    occurances.Add(arr[i], 0);
                }

                occurances[arr[i]]++;
            }

            foreach (KeyValuePair<double, int> pair in occurances)
            {
                Console.WriteLine($"Number {pair.Key} occured {pair.Value} times.");
            }

        }
    }
}

/*
 * Implement a set of extension methods for IEnumerable<T> that
 * implement the following group functions: sum, product, min, max,
 * average.
*/

using System;
using System.Collections.Generic;

namespace CSharpLevel2_Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(list.Sum<int>());
            Console.WriteLine(list.Product<int>());
            Console.WriteLine(list.Min<int>());
            Console.WriteLine(list.Max<int>());
            Console.WriteLine(list.Average<int>());
        }
    }
}

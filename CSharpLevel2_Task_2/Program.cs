/*
 * Implement the data structure "hash table" in a class HashTable<K, T>.
 * Keep the data in array of lists of key-value pairs
 * LinkedList<KeyValuePair<K, T>>[] with initial capacity of 16. When the
 * hash table load runs over 75%, perform resizing to 2 times larger
 * capacity. Implement the following methods and properties: Add(key,
 * value), Find(key) -> value, Remove(key), Count, Clear(), this[], Keys. Try
 * to make the hash table to support iterating over its elements with foreach.
*/

using System;
using System.Drawing;

namespace CSharpLevel2_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTable<Point, int> dict = new HashTable<Point, int>(3, 0.9f);

            dict[new Point(1, 2)] = 1; // Put a key-value pair
            Console.WriteLine(dict[new Point(1, 2)]); // Get value

            // Overwrite the previous value for the same key
            dict[new Point(1, 2)] += 1;
            Console.WriteLine(dict[new Point(1, 2)]);

            // Now this point will cause a collision with the
            // previous one and the elements will be chained
            dict[new Point(3, 2)] = 42;

            Console.WriteLine(dict[new Point(3, 2)]);

            // Test if the chaining works as expected, i.e.
            // elements with equal hash-codes are not overwritten
            Console.WriteLine(dict[new Point(1, 2)]);

            // Creation of another entry in the internal table
            // This will cause the internal table to expand
            dict[new Point(4, 5)] = 1111;
            Console.WriteLine(dict[new Point(4, 5)]);

            // Delete an existing by its key
            dict.Remove(new Point(3, 2));

            // Iterate through the dictionary entries and print them
            foreach (KeyValuePair<Point, int> entry in dict)
            {
                Console.WriteLine("Key: " + entry.Key + "; Value: " + entry.Value);
            }
        }
    }
}

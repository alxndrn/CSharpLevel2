/*
 * Write a program that removes from a text file all words listed in
 * given another text file. Handle all possible exceptions in your
 * methods.
*/

using System;
using System.Collections.Generic;
using System.IO;

namespace CSharpLevel2_Task_12
{
    class Program
    {
        static List<string> BannedWords()
        {
            StreamReader readwords = new StreamReader("bannedwords.txt");
            string word = readwords.ReadLine();
            List<string> words = new List<string>();

            using (readwords)
            {
                while (word != null)
                {
                    words.Add(word);
                    word = readwords.ReadLine();
                }
            }
            return words;

        }
        static void Main(string[] args)
        {
            try
            {
                StreamReader reader = new StreamReader("test.txt");
                string line = reader.ReadLine();

                List<string> words = BannedWords();
                List<string> modifiedLines = new List<string>();
                using (reader)
                {
                    while (line != null)
                    {
                        for (int i = 0; i < words.Count; i++)
                        {
                            string word = words[i];
                            line = line.Replace(word, "");
                        }
                        modifiedLines.Add(line);
                        line = reader.ReadLine();
                    }
                }
                using (StreamWriter writer = new StreamWriter("test.txt"))
                {
                    foreach (string item in modifiedLines)
                    { writer.WriteLine(item); }
                }
            }
            
            catch (FileNotFoundException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch (DirectoryNotFoundException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch (ArgumentNullException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch (ArgumentException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch (OutOfMemoryException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

        }
    }
}

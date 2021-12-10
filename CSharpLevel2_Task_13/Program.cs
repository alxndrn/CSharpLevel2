using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace CSharpLevel2_Task_13
{
    class Program
    {
        static List<string> BannedWords()
        {
            StreamReader readwords = new StreamReader("words.txt");
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
        static void Main()
        {
            try
            {
                StreamReader reader = new StreamReader("test.txt");
                string line = reader.ReadLine();

                List<string> words = BannedWords();
                int[] hits = new int[words.Count];
                using (reader)
                {
                    while (line != null)
                    {
                        for (int i = 0; i < words.Count; i++)
                        {
                            string word = words[i];
                            hits[i] += Regex.Matches(line, @"\b" + words[i] + @"\b").Count;
                        }
                        line = reader.ReadLine();
                    }
                }

                int tempindex = 0;
                int tempvalue = -1;
                using (StreamWriter writer = new StreamWriter("result.txt"))
                {
                    for (int t = 0; t < words.Count(); t++)
                    {
                        for (int j = 0; j < words.Count(); j++)
                        {
                            if (hits[j] > tempvalue)
                            {
                                tempindex = j;
                                tempvalue = hits[j];
                            }
                        }
                        writer.WriteLine(hits[tempindex] + " " + words[tempindex]);
                        hits[tempindex] = -1;
                        tempindex = 0;
                        tempvalue = -1;
                    }
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

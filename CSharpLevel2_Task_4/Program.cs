/*
 * Read in MSDN about the keyword event in C# and how to
 * publish events. Re-implement the above using .NET events and
 * following the best practices.
*/

using System;
using System.Threading;

namespace CSharpLevel2_Task_4
{
    class Program
    {
        static event EventHandler<ConsoleKey> HandleEnter;

        static void CaptureKeyPressed(ConsoleKey key)
        {
            if (key == ConsoleKey.Enter)
            {
                HandleEnter(null, ConsoleKey.Enter);
            }
        }

        static void HandleKeyPress(object sender, ConsoleKey key)
        {
            Console.Clear();
            Timer.Seconds = 0;
        }

        static void TickerCount(object sender, ConsoleKey key)
        {
            Console.WriteLine("Enter number of seconds at which to skip the timer:");
            int seconds = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nPress [ENTER] to reset the Timer.\n");

            var action = Timer.Action;

            while (!Console.KeyAvailable || Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Thread.Sleep(seconds*1000);
                action();
            }
        }

        static void Main()
        {
            Console.WriteLine("Press [ENTER] to start the Stopwatch!");

            HandleEnter = HandleKeyPress;

            HandleEnter += TickerCount;

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    CaptureKeyPressed(Console.ReadKey().Key);
                }
            }
        }
    }
}

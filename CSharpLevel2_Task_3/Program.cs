/*
 * Using delegates write a class Timer that has can execute certain
 * method at each t seconds.
*/

using System;
using System.Threading;

namespace CSharpLevel2_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticker ticker = new Ticker(Timer.Action);

            Console.WriteLine("Please enter number of seconds:");
            int seconds = Int32.Parse(Console.ReadLine());

            while (true)
            {
                Thread.Sleep(seconds*1000);
                ticker();
            }
        }
    }
}

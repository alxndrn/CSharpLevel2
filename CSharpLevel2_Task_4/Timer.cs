using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLevel2_Task_4
{
    public delegate void Ticker();
    public static class Timer
    {
        public static readonly Action Action = new Action(() => Console.WriteLine(++Seconds));
        public static int Seconds { get; set; }
    }
}

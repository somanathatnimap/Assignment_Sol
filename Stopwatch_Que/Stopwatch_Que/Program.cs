using System;
using System.Diagnostics;
using System.Threading;

namespace Stopwatch_Que
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stopwatch, Press Enter to Start!");
            Console.ReadLine();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            bool isRunning = true;

            Thread timerThread = new Thread(() =>
            {
                while (isRunning)
                {
                    TimeSpan elapsed = stopwatch.Elapsed;
                    Console.CursorLeft = 0;
                    Console.Write("Elapsed time: " + elapsed);
                    Thread.Sleep(10); 
                }
            });
            timerThread.Start();

            Console.WriteLine("Press Enter to Stop!");
            Console.ReadLine();

            stopwatch.Stop();
            isRunning = false;
            timerThread.Join();
            TimeSpan totalElapsed = stopwatch.Elapsed;
            Console.WriteLine("Total elapsed time: " + totalElapsed);
            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }
    }
}

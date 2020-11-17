using System;
using System.Dynamic;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            while(true)
            {
                Console.WriteLine("Start or Stop Stopwatch?");
                Console.WriteLine("quit to exit");
                string input = Console.ReadLine();
                if (input.ToLower()== "quit")
                {
                    Console.WriteLine("Stopwatch exited!");
                    break;
                }
                if (input.ToLower() == "start")

                {

                    stopwatch.Start();

                    continue;

                }

                if (input.ToLower() == "stop")

                {

                    stopwatch.Stop();

                    Console.WriteLine("Duration - {0}", stopwatch.Duration());

                    continue;

                }
            }
        }
    }
}

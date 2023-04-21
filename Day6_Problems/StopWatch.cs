using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Problems
{
     class StopWatch
    {
        public void time()
        {
            Console.WriteLine("Enter to start the StopWatch");
            Console.ReadLine();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Console.WriteLine("press enter to stop watch");
            Console.ReadLine();
            stopwatch.Stop();

            Console.WriteLine(stopwatch.Elapsed);

        }
    }
}

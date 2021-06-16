using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;


namespace RefrigtzW
{
     static class Program
    {
        public static long SomeExtremelyLargeNumber { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        static void Log(Exception ex)
        {
            try
            {
                string stackTrace = ex.ToString();
                File.AppendAllText(FormRefrigtz.Root + "\\ErrorProgramRun.txt", stackTrace + ": On" + DateTime.Now.ToString()); // path of file where stack trace will be stored.
            }
            catch (Exception t) { Log(t); }
        }
        public static void IncreasingThreadPerformance()
        {
            Process.GetCurrentProcess().PriorityBoostEnabled = true;
            Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.RealTime;

            // Of course this only affects the main thread rather than child threads.
            Thread.CurrentThread.Priority = ThreadPriority.Highest;

            Int64 seed = SomeExtremelyLargeNumber; // Millions of digits.
            int[] nums = Enumerable.Range(0, 1000000).ToArray();
            long total = 0;

            // Use type parameter to make subtotal a long, not an int
            Parallel.For<long>(0, nums.Length, () => 0, (j, loop, subtotal) =>
            {
                subtotal += nums[j];
                return subtotal;
            },
                (x) => Interlocked.Add(ref total, x)
            );


        }
        public class StackOverflowDetector
        {
            static void CheckStackDepth()
            {
                if (new StackTrace().FrameCount > 60) // some arbitrary limit
                {
                    throw new StackOverflowException("Bad thread.");
                }
            }

            public static int Recur()
            {
                CheckStackDepth();
                return 0;
            }
        }

            
        //Main Programm.
        
    }
}
//End of Documents.
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refrigtz
{
    [Serializable]
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
                Object a = new Object();
                lock (a)
                {
                    string stackTrace = ex.ToString();
                    File.AppendAllText(FormRefrigtz.Root + "\\ErrorProgramRun.txt", stackTrace + ": On" + DateTime.Now.ToString()); // path of file where stack trace will be stored.
                }
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
        [STAThreadAttribute]
        public static void Main()
        {
            // IncreasingThreadPerformance();
            //Intiate  Program Load and Calling.
            Application.EnableVisualStyles();
            Load t = null;
            try
            {
                //https://blogs.msdn.microsoft.com/pfxteam/2011/09/17/whats-new-for-parallelism-in-net-4-5/
                //Task tt = new Task(new Action(TaskParallelLibrary));
                //tt.Start();
                //Task ttt = new Task(new Action(CoordinationDataStructures));
                //ttt.Start();
                Application.SetCompatibleTextRenderingDefault(false);
                t = new Load();

                Application.Run(t);/*
//#pragma warning disable CS0197 // Using 'FormRefrigtz.LoadTree' as a ref or out value or taking its address may cause a runtime exception because it is a field of a marshal-by-reference class
                (new TakeRoot()).Save(t.ttt.Quantum, t.ttt, ref t.ttt.LoadTree, t.ttt.MovementsAStarGreedyHeuristicFound, t.ttt.IInoreSelfObjects, t.ttt.UsePenaltyRegardMechnisam, t.ttt.BestMovments, t.ttt.PredictHeuristic, t.ttt.OnlySelf, t.ttt.AStarGreedyHeuristic, t.ttt.ArrangmentsChanged);
//#pragma warning restore CS0197 // Using 'FormRefrigtz.LoadTree' as a ref or out value or taking its address may cause a runtime exception because it is a field of a marshal-by-reference class
           */
            }
            catch (Exception tt)
            {
                /*//#pragma warning disable CS0197 // Using 'FormRefrigtz.LoadTree' as a ref or out value or taking its address may cause a runtime exception because it is a field of a marshal-by-reference class
                                (new TakeRoot()).Save(t.ttt.Quantum, t.ttt, ref t.ttt.LoadTree, t.ttt.MovementsAStarGreedyHeuristicFound, t.ttt.IInoreSelfObjects, t.ttt.UsePenaltyRegardMechnisam, t.ttt.BestMovments, t.ttt.PredictHeuristic, t.ttt.OnlySelf, t.ttt.AStarGreedyHeuristic, t.ttt.ArrangmentsChanged);
                //#pragma warning restore CS0197 // Using 'FormRefrigtz.LoadTree' as a ref or out value or taking its address may cause a runtime exception because it is a field of a marshal-by-reference class

                */
                Log(tt);
            }

        }





        static void CoordinationDataStructures()
        {
            /*Not to be outshined, our concurrent collections and synchronization
             primitives have also been improved.This again follows the principle
             that you don’t need to make any code changes: you just upgrade and
             your code becomes more efficient.A good example of this is with updating
             the contents of a ConcurrentDictionary<TKey, TValue>.We’ve optimized some 
             common cases to involve less allocation and synchronization.Consider 
             the following code, which continually updates the same entry in the 
             dictionary to have a new value:
             After upgrading my machine to .NET 4.5, this runs 15% faster than it did with .NET 4.*/
            while (true)

            {
                do { Thread.Sleep(1); } while (!RefrigtzDLL.AllDraw.ThinkingRunInBothSide);

                var cd = new ConcurrentDictionary<int, int>();

                var sw = Stopwatch.StartNew();

                cd.TryAdd(42, 0);

                for (int i = 1; i < 10000000; i++)

                {
                    int k = i - 1;
                    cd.TryUpdate(42, i, k);

                }

                Console.WriteLine(sw.Elapsed);

            }

        }
        static void TaskParallelLibrary()

        {
            /*Just by upgrading from .NET 4 to.NET 4.5, on the machine on which I’m 
             writing this blog post, this code runs 400 % faster!This is of course 
             a microbenchmark that’s purely measuring a particular kind of overhead, 
             but nevertheless it should give you a glimpse into the kind of improvements
             that exist in the runtime.*/
            var sw = new Stopwatch();

            while (true)

            {
                if (!Refrigtz.FormRefrigtz.Quantum)
                {
                    do { Thread.Sleep(1); } while (!RefrigtzDLL.AllDraw.ThinkingRunInBothSide);

                }
                else
                {
                    do { Thread.Sleep(1); } while (!QuantumRefrigiz.AllDraw.ThinkingQuantumRunInBothSide);
                }
                GC.Collect();

                GC.WaitForPendingFinalizers();

                GC.Collect();



                var tcs = new TaskCompletionSource<object>();

                var t = tcs.Task;

                sw.Restart();

                for (int i = 0; i < 1000000; i++)

                    t = t.ContinueWith(_ => (object)null);

                var elapsed = sw.Elapsed;

                GC.KeepAlive(tcs);



                Console.WriteLine(elapsed);

            }

        }


    }
}
//End of Documents.
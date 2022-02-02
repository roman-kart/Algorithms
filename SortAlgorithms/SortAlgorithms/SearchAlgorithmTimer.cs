using System;
using System.Diagnostics;

namespace SortAndSearchAlgorithms
{
    public class SearchAlgorithmTimer
    {
        public delegate type SearchAlgorihm<type>(type[] items, type item);

        public static void TimeOfExecution<type>(SearchAlgorihm<type> searchAlgorihm, type[] items, type item)
        {
            CollectGarbage();
            var timer = new Stopwatch();
            timer.Start();
            searchAlgorihm?.Invoke(items, item);
            timer.Stop();
            Console.WriteLine($"{searchAlgorihm.GetType().Name}: {timer.Elapsed}");
            CollectGarbage();
        }
        public static void CollectGarbage()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}

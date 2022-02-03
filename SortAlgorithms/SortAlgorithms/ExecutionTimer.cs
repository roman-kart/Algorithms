using System;
using System.Diagnostics;

namespace SortAndSearchAlgorithms
{
    public abstract class ExecutionTimer
    {
        /// <summary>
        /// Определяет время выполнения алгоритма.
        /// Принимает один аргумент - объект, реализующий интерфейс IAlgorithm
        /// </summary>
        /// <param name="algorithm"></param>
        public static void TimeOfExecution(IAlgorithm algorithm)
        {
            CollectGarbage();
            var timer = new Stopwatch();
            timer.Start();
            algorithm.Execute();
            timer.Stop();
            Console.WriteLine($"Time of execution: {timer.Elapsed}");
            CollectGarbage(); 
        }
        public static void CollectGarbage()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}

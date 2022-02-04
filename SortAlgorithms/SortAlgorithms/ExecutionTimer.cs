using System;
using System.Diagnostics;

namespace SortAndSearchAlgorithms
{
    public abstract class ExecutionTimer
    {
        /// <summary>
        /// Возвращает время выполнения алгоритма.
        /// Принимает один аргумент - объект, реализующий интерфейс IAlgorithm
        /// </summary>
        /// <param name="algorithm"></param>
        public static TimeSpan TimeOfExecution(IAlgorithm algorithm)
        {
            CollectGarbage();
            var timer = new Stopwatch();
            timer.Start();
            algorithm.Execute();
            timer.Stop();
            CollectGarbage();
            return timer.Elapsed;
        }
        public static void CollectGarbage()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}

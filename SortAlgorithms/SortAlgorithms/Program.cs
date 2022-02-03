using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SortAndSearchAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var itemsSortedList = new List<int>();
            for (int i = 0; i < 214700000; i++)
            {
                itemsSortedList.Add(i);
            }
            var itemsSorted = itemsSortedList.ToArray();

            var timer = new Stopwatch();

            var simpleSearchInt = new SearchAlgorithm<int>(
                SearchAlgorithms.SimpleSearch<int>,
                itemsSorted,
                678000
            );
            var binarySearchInt = new SearchAlgorithm<int>(
                SearchAlgorithms.BinarySeacrhAlgorithm<int>,
                itemsSorted,
                678000
            );
            ExecutionTimer.TimeOfExecution(simpleSearchInt);
            ExecutionTimer.TimeOfExecution(binarySearchInt);
        }
    }
}

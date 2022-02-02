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


            SearchAlgorithmTimer.TimeOfExecution<int>(SearchAlgorithms.SimpleSearch, itemsSorted, 234900);
            SearchAlgorithmTimer.TimeOfExecution<int>(SearchAlgorithms.BinarySeacrhAlgorithm, itemsSorted, 234900);
        }
    }
}

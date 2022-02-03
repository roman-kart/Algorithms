using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SortAndSearchAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            var randomItems = new int[2000];
            for (int i = 0; i < randomItems.Length; i++)
            {
                randomItems[i] = rand.Next(-1000, 1000);
            }

            var bubbleSort = new SortAlgorithm<int>(
                BubbleSortAlgorithm.SortAscending<int>,
                randomItems
            );

            ExecutionTimer.TimeOfExecution(bubbleSort);
            int[] itemsSorted = new int[bubbleSort.items.Length];
            Array.Copy(bubbleSort.items, itemsSorted, itemsSorted.Length);

            var simpleSearchInt = new SearchAlgorithm<int>(
                SearchAlgorithms.SimpleSearch<int>,
                itemsSorted,
                100
            );
            var binarySearchInt = new SearchAlgorithm<int>(
                SearchAlgorithms.BinarySeacrhAlgorithm<int>,
                itemsSorted,
                100
            );
            ExecutionTimer.TimeOfExecution(simpleSearchInt);
            ExecutionTimer.TimeOfExecution(binarySearchInt);
        }
    }
}

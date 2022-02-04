using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SortAndSearchAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Генерирование списка случайных элементов
            var randomItems = new int[2000];
            randomItems.InsertRandomInt(-1000, 1000);
            #endregion

            var bubbleSort = new SortAlgorithm<int>(
                BubbleSortAlgorithm.SortAscending<int>,
                randomItems.GetCopy()
            );

            var shakerSort = new SortAlgorithm<int>(
                ShakerSortAlgorithm.SortAscending<int>,
                randomItems.GetCopy()
            );

            ExecutionTimer.TimeOfExecution(bubbleSort);
            ExecutionTimer.TimeOfExecution(shakerSort);
            int[] itemsSorted = shakerSort.items.GetCopy();

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

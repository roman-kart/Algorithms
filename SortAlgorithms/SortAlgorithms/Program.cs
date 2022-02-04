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
            var randomItems = new int[5000];
            randomItems.InsertRandomInt(-1000, 1000);
            #endregion

            var searchSort = new SortAlgorithm<int>(
                SearchSortAlgorithm.SortAscending<int>,
                randomItems.GetCopy()
            );

            var searchShakerSort = new SortAlgorithm<int>(
                SearchShakerSortAlgorithm.SortAscending<int>,
                randomItems.GetCopy()
            );

            var insertionSort = new SortAlgorithm<int>(
                InsertionSortAlgorithm.SortAscending<int>,
                randomItems.GetCopy()
            );

            var bubbleSort = new SortAlgorithm<int>(
                BubbleSortAlgorithm.SortAscending<int>,
                randomItems.GetCopy()
            );

            var shakeSort = new SortAlgorithm<int>(
                SearchShakerSortAlgorithm.SortAscending<int>,
                randomItems.GetCopy()
            );

            Console.WriteLine($"{ExecutionTimer.TimeOfExecution(searchSort)} : searchSort");
            Console.WriteLine($"{ExecutionTimer.TimeOfExecution(searchShakerSort)} : searchShakerSort");
            Console.WriteLine($"{ExecutionTimer.TimeOfExecution(insertionSort)} : insertionSort");
            Console.WriteLine($"{ExecutionTimer.TimeOfExecution(bubbleSort)} : bubbleSort");
            Console.WriteLine($"{ExecutionTimer.TimeOfExecution(shakeSort)} : shakeSort");


            int[] itemsSorted = searchShakerSort.items.GetCopy();

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

            Console.WriteLine($"{ExecutionTimer.TimeOfExecution(simpleSearchInt)} : simpleSearchInt");
            Console.WriteLine($"{ExecutionTimer.TimeOfExecution(binarySearchInt)} : binarySearchInt");
        }
    }
}

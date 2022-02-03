using System;
namespace SortAndSearchAlgorithms
{
    public class BubbleSortAlgorithm
    {
        public static void SortAscending<type>(type[] items) where type : IComparable<type>
        {
            type tmp; // хранение временного результата
            for (int i = 0; i < (items.Length - 1); i++)
            {
                type min = items[i]; // минимальный элемент изначально самый левый элемент
                int iMin = i; // индекс минимального элемента
                // сортируем от самого левого элемента неотсортированного массива
                for (int j = i; j < items.Length; j++)
                {
                    // если минимальный элемент больше элемента массива
                    if (min.CompareTo(items[j]) > 0)
                    {
                        min = items[j]; // меняем значение минимального элемента
                        iMin = j;
                    }
                }
                // меняем элементы местами
                items[iMin] = items[i];
                items[i] = min;
            }
        }
    }
}

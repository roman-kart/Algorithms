using System;
namespace SortAndSearchAlgorithms
{
    public class ShakerSortAlgorithm
    {
        public static void SortAscending<type>(type[] items) where type: IComparable<type>, IEquatable<type>
        {
            int leftIndex = 0;
            int rightIndex = items.Length - 1;
            for (int i = 0; i < (items.Length / 2) + 1; i++)
            {
                type min = items[leftIndex];
                int minIndex = leftIndex;
                type max = items[rightIndex];
                int maxIndex = rightIndex;
                for (int j = leftIndex; j < rightIndex; j++)
                {
                    // если min больше, чем текущий элемент
                    if (min.CompareTo(items[j]) > 0)
                    {
                        min = items[j];
                        minIndex = j;
                    }
                    // если max меньше, чем текущий элемент
                    if (max.CompareTo(items[j]) < 0)
                    {
                        max = items[j];
                        maxIndex = j;
                    }
                }
                // перемещаем минимальный элемент
                items[minIndex] = items[leftIndex];
                items[leftIndex] = min;
                // перемещаем максимальный элемент
                items[maxIndex] = items[rightIndex];
                items[rightIndex] = max;

                // сужаем границы
                leftIndex++;
                rightIndex--;
            }
        }
    }
}

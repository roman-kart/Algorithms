using System;
namespace SortAndSearchAlgorithms.SortAlgorithms.ShakeSort
{
    public class ShakeSortAlgorithm
    {
        public static void SortAscending<type>(type[] items) where type: IComparable<type>, IEquatable<type>
        {
            type tmp;
            int leftIndex = 0;
            int rightIndex = items.Length;
            for (int i = 0; i < items.Length; i++)
            {
                // "тяжелый" пузырек идет в конец
                for (int j = leftIndex; j < rightIndex; j++)
                {
                    // если текущий элемент больше следующего элемента
                    if (items[j].CompareTo(items[j + 1]) > 0)
                    {
                        //меняем элементы местами
                        tmp = items[j];
                        items[j] = items[j + 1];
                        items[j + 1] = tmp;
                    }
                }
                for (int j = rightIndex - 1; j > leftIndex; j--)
                {
                    // если текущий элемент меньше элемента спереди
                    if (items[j].CompareTo(items[j - 1]) < 0)
                    {
                        //меняем элементы местами
                        tmp = items[j];
                        items[j] = items[j - 1];
                        items[j - 1] = tmp;
                    }
                }
                leftIndex++;
                rightIndex--;
            }
        }
    }
}

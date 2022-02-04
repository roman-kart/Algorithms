using System;
namespace SortAndSearchAlgorithms
{
    public class BubbleSortAlgorithm
    {
        public static void SortAscending<type>(type[] items) where type: IEquatable<type>, IComparable<type> 
        {
            int rightIndex = items.Length;
            type tmp;
            // перебираем каждый элемент
            for (int i = 0; i < items.Length; i++)
            {
                // на каждой итерации перемещаем наибольший элемент в конец списка.
                // Граница - предпоследний элемент
                for (int j = 0; j < rightIndex - 1; j++)
                {
                    // если текущий элемент больше следующего элемента
                    if (items[i].CompareTo(items[i + 1]) > 0)
                    {
                        //меняем элементы местами
                        tmp = items[i];
                        items[i] = items[i + 1];
                        items[i + 1] = tmp;
                    }
                }
                rightIndex--;
            }
        }
    }
}

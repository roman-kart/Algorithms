using System;
namespace SortAndSearchAlgorithms
{
    public class InsertionSortAlgorithm
    {
        public static void SortAscending<type>(type[] items) where type: IComparable<type>, IEquatable<type>
        {
            // если данные невалидны - завершаем выполнение
            if (items == null || items.Length < 2)
            {
                return;
            }
            // i - элемент перед сортируемым элементом
            for (int i = 0; i < items.Length - 1; i++)
            {
                int j = i;
                type tmp;
                // пока элемент из неотсортированной части массива меньше, чем текущий элемент отсортированного массива
                while (j >= 0 && ( items[j].CompareTo(items[j + 1]) > 0 ))
                {
                    // меняем элементы местами
                    tmp = items[j + 1];
                    items[j + 1] = items[j];
                    items[j] = tmp;
                    j--;
                }
            }
        }
    }
}

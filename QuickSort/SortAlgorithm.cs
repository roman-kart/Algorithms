using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace QuickSort
{
    internal class SortAlgorithm
    {
        public static int[] SortAscending(int[] items)
        {
            return SortAscendingRecursion(items);
        }
        private static int[] SortAscendingRecursion(int[] items)
        {
            // если массив состоит из одного или менее элементов, то возвращаем массив без изменений
            if (items.Length <= 1 )
            {
                return items;
            }
            // если массив состоит из 2-х элементов, то сравниваем их и выводим в определенной последовательности
            else if (items.Length == 2)
            {
                // если первый элемент меньше второго элемента, то не меняем первоначальный массив, в противном случае, меняем элементы местами
                return items[0] < items[1] ? new int[] { items[0], items[1] } : new int[] { items[1], items[0] };
            }
            // если массив состоит более чем из 2-х элементов, то рекурсивно вызываем данную функцию
            else
            {
                var centerIndex = items.Length / 2; // индекс центра текущего массива
                var centerItem = items[centerIndex];

                List<int> centerItems = new List<int>();
                List<int> lessThanCenter = new List<int>();
                List<int> moreThanCenter = new List<int>();
                foreach (var item in items)
                {
                    if (item < centerItem)
                    {
                        lessThanCenter.Add(item);
                    }
                    else if (item == centerItem)
                    {
                        centerItems.Add(item);
                    }
                    else
                    {
                        moreThanCenter.Add(item);
                    }
                }

                return SortAscendingRecursion(lessThanCenter.ToArray()).Concat(centerItems.ToArray()).Concat(SortAscendingRecursion(moreThanCenter.ToArray())).ToArray();
            }
        }
    }
}

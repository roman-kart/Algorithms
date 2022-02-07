using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class BinarySearchClass
    {
        public static int Search(int[] elements, int searched)
        {
            if (elements.Length == 1)
            {
                return elements[0];
            }
            return BinarySearch(elements, searched, 0, elements.Length - 1); // правая граница включена в диапазон
        }
        private static int BinarySearch(int[] elements, int searched, int leftIndex, int rightIndex)
        {
            int centreIndex = ((rightIndex - leftIndex) / 2) + leftIndex; // текущий элемент по центру
            if (elements[centreIndex] == searched)
            {
                return centreIndex;
            }
            else if (leftIndex >= rightIndex)
            {
                return rightIndex;
            }
            else if (elements[centreIndex] > searched)
            {
                return BinarySearch(elements, searched, leftIndex, centreIndex - 1);
            }
            else if (elements[centreIndex] < searched)
            {
                return BinarySearch(elements, searched, centreIndex + 1, rightIndex);
            }
            else
            {
                return 0;
            }
        }
    }
}

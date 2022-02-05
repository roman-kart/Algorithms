using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class BiggestInArray
    {
        public static int Get(int[] elements)
        {
            return FindBiggest(elements, 0, 0);
        }
        private static int FindBiggest(int[] elements, int biggestIndex, int currentIndex)
        {
            if (elements.Length == 0)
            {
                return 0;
            }
            if (currentIndex >= elements.Length)
            {
                return elements[biggestIndex];
            }
            else if (elements[biggestIndex] < elements[currentIndex])
            {
                return FindBiggest(elements, currentIndex, currentIndex + 1);
            }
            else
            {
                return FindBiggest(elements, biggestIndex, currentIndex + 1);
            }
        }
    }
}

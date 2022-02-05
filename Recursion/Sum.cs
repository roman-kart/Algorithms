using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class Sum
    {
        public static int GetSum(int[] elements)
        {
            if (elements.Length == 0)
            {
                return 0;
            }
            else if (elements.Length == 1)
            {
                return elements[0];
            }
            else
            {
                int[] nextElements = new int[elements.Length - 1];
                Array.Copy(elements, 0, nextElements, 0, elements.Length - 1);
                return elements[elements.Length - 1] + GetSum(nextElements);
            }
        }
    }
}

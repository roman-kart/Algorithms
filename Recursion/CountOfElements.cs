using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class CountOfElements
    {
        public static int Get<type>(type[] elements)
        {
            if (elements.Length == 0)
            {
                return 0;
            }
            else if (elements.Length == 1)
            {
                return 1;
            }
            else
            {
                type[] nextElements = new type[elements.Length - 1];
                Array.Copy(elements, 0, nextElements, 0, elements.Length - 1);
                return 1 + Get(nextElements);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class Factorial
    {
        public static int Recursion(int i)
        {
            if (i <= 1)
            {
                return 1;
            }
            else
            {
                return i * Recursion(i - 1);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class Field
    {
        public static void PrintMinSquare(int x, int y)
        {
            if (x % y == 0)
            {
                Console.WriteLine(y + "*" + y);
            }
            else if (y % x == 1)
            {
                Console.WriteLine(x + "*" + x);
            }
            else
            {
                int min = x < y ? x : y;
                int max = x < y ? y : x;
                int remain = max % min;
                PrintMinSquare(min, remain);
            }
        }
    }
}

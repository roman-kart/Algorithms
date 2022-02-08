using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBackpackProblem
{
    internal static class Extensions
    {
        public static Combination GetCopy(this Combination source)
        {
            return new Combination
            {
                TotalWeight = source.TotalWeight,
                TotalCost = source.TotalCost,
                Items = source.Items.GetCopy(),
            };
        }
        public static List<Item> GetCopy(this List<Item> source)
        {
            var copy = new List<Item>();
            foreach (var item in source)
            {
                copy.Add(item);
            }
            return copy;
        }
    }
}

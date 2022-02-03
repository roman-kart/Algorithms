using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SortAndSearchAlgorithms
{
    public class SearchAlgorithms
    {
        #region Simple Search Algorithm
        ///<summary>
        ///<para>
        /// Search element in sequence by element.Equals(searchable). 
        ///</para>
        ///<para>
        /// If sequence contains searchable element, return index,
        /// Else return -1.
        ///</para>
        ///</summary>
        public static int SimpleSearch<type>(type[] items, type item) where type : IEquatable<type>, IComparable<type>
        {
            var length = items.Length;
            int i = 0;
            while (i < length && !(items[i].Equals(item)))
            {
                i++;
            }
            if (i < length)
            {
                return i;
            }
            else
            {
                return -1;
            }
        }
        #endregion
        /// <summary>
        /// <para>
        ///     Search element in sequence by binary search.
        /// </para>
        /// <para>
        ///     If searchable item is in sequence, returns index,
        ///     else returns -1.
        /// </para>
        /// </summary>
        /// <typeparam name="type"></typeparam>
        /// <param name="items"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        #region Binary Search Algorithm
        public static int BinarySeacrhAlgorithm<type>(type[] items, type item) where type : IEquatable<type>, IComparable<type>
        {
            //Console.WriteLine($"Binary search algorithm start : {new TimeSpan(DateTime.Now.Ticks)}");
            int m = 0;
            int left = 0;
            int right = items.Length - 1;
            do
            {
                m = (left + right) / 2;
                // если искомый элемент меньше, чем элемент посередине
                if (item.CompareTo(items[m]) > 0)
                {
                    left = m + 1;
                }
                else
                {
                    right = m - 1;
                }
            } while ((!items[m].Equals(item)) && left <= right);
            //Console.WriteLine($"Binary search algorithm end : {new TimeSpan(DateTime.Now.Ticks)}");
            if (items[m].Equals(item))
            {
                return m;
            }
            else
            {
                return -1;
            }
        }
        #endregion
    }
}

using System;
namespace SortAndSearchAlgorithms
{
    public static class ArrayExtensions
    {
        /// <summary>
        /// Возвращает копию массива. Удобно применять для алгоритмов сортировки
        /// </summary>
        /// <typeparam name="type"></typeparam>
        /// <param name="sourceArr"></param>
        /// <returns></returns>
        public static type[] GetCopy<type>(this type[] sourceArr)
        {
            var copyArr = new type[sourceArr.Length];
            Array.Copy(sourceArr, copyArr, sourceArr.Length);
            return copyArr;
        }
        /// <summary>
        /// Заполняет целочисленный массив случайными значениями
        /// </summary>
        /// <param name="sourceArr"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public static void InsertRandomInt(this int[] sourceArr, int min, int max)
        {
            Random rand = new Random();
            for (int i = 0; i < sourceArr.Length; i++)
            {
                sourceArr[i] = rand.Next(min, max);
            }
        }
    }
}

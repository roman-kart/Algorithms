using System;
namespace SortAndSearchAlgorithms
{
    /// <summary>
    /// Класс для хранения информации об алгоритме сортировки.
    /// Реализует интерфейс IAlgorithm
    /// </summary>
    /// <typeparam name="type"></typeparam>
    public class SortAlgorithm<type> : IAlgorithm where type: IComparable<type>, IEquatable<type>
    {
        public type[] items { get; set; }
        public delegate void Algorithm(type[] items);
        public Algorithm algorithm;
        /// <summary>
        /// Принимает 2 аргумента: алгоритм для сортировки
        /// и данные, которые необходимо отсортировать.
        /// </summary>
        /// <param name="algorithm"></param>
        /// <param name="items"></param>
        public SortAlgorithm(Algorithm algorithm, type[] items)
        {
            this.algorithm = algorithm;
            this.items = items;

            // вызываем алгоритм для предварительной компиляции (влияет на быстродействие)
            this.algorithm?.Invoke(new type[1] { default(type)});
        }
        public void Execute()
        {
            this.algorithm?.Invoke(items);
        }
    }
}

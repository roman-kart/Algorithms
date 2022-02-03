using System;
namespace SortAndSearchAlgorithms
{
    /// <summary>
    /// Предназначен для хранения метода алгоритма сортировки и его аргументов.
    /// Реализует интерфейс IAlgorithm.
    /// </summary>
    /// <typeparam name="type"></typeparam>
    public class SearchAlgorithm<type> : IAlgorithm where type: IEquatable<type> ,IComparable<type>
    {
        public type[] items;
        public type itemForSearch;
        /// <summary>
        /// Делегат для хранения алгоритма поиска.
        /// Возвращает индекс найденного элемента или -1, если элемент не найден.
        /// Принимает 2 аргумента: элементы, в которых происходит поиск,
        /// и элемент, который необходимо найти.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="itemForSerch"></param>
        /// <returns></returns>
        public delegate int AlgorithmFunc(type[] items, type itemForSerch);
        public AlgorithmFunc algorithm;

        public SearchAlgorithm(AlgorithmFunc algorithm)
        {
            this.algorithm = algorithm;
        }

        public SearchAlgorithm(AlgorithmFunc algorithm, type[] items, type itemForSearch)
        {
            this.algorithm = algorithm;
            this.items = items;
            this.itemForSearch = itemForSearch;
        }
        /// <summary>
        /// Выполняет алгоритм вместе с указанными данными
        /// </summary>
        public virtual void Execute()
        {
            this.algorithm?.Invoke(items, itemForSearch);
        }
    }
}

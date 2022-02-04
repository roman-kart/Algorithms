using System;
namespace SortAndSearchAlgorithms
{
    public class ShellSortAlgorithm
    {
        public static void SortAscending<type>(type[] items) where type : IComparable<type>, IEquatable<type>
        {
            // если данные невалидны - завершаем выполнение
            if (items == null || items.Length < 2)
            {
                return;
            }

            var steps = new StepForShellSort(items.Length);
            var step = steps.GetCurrentStep();
            while (step >= 1)
            {
                step = 1;
                step = steps.GetCurrentStep();
            }
        }
    }
}

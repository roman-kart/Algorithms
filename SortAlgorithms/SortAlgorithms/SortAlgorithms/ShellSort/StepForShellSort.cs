using System;
using System.Collections.Generic;

namespace SortAndSearchAlgorithms
{
    public class StepForShellSort
    {
        private int currentStepNumber = 0;
        private readonly int _count;
        private readonly int[] _stepsValues;
        /// <summary>
        /// Конструктор получает на вход количество элементов в массиве, который будет отсортирован
        /// </summary>
        /// <param name="count"></param>
        public StepForShellSort(int count)
        {
            this._count = count;
            this._stepsValues = GetNewStepsValues(count);
        }
        public int GetCurrentStep()
        {
            // если номер шага превышает размер массива
            if (this.currentStepNumber >= this._stepsValues.Length)
            {
                return 1; // возвращаем 1
            }
            // в противном случае возвращаем текущий шаг и инкрементируем переменную, отвучающую за номер шага
            return this._stepsValues[this.currentStepNumber++];
        }
        /// <summary>
        /// Возвращает шаги для сортировки Шелла
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public int[] GetNewStepsValues(int count)
        {
            var stepsValues = new List<int>();
            int newStep = 1;
            while (newStep <= count)
            {
                stepsValues.Add(newStep);
                newStep = GetNewStepValue(newStep);
            }
            stepsValues.Reverse(); // разворачиваем массив, чтобы он начинался с наибольшего
            return stepsValues.ToArray();
        }
        /// <summary>
        /// Возвращаем новое значение для шага (вроде бы такую формулу предлагал Дональд Кнут),
        /// а мне с его мнением спорить не положено :)
        /// </summary>
        /// <param name="currentStep"></param>
        /// <returns></returns>
        public int GetNewStepValue(int currentStep)
        {
            return (2 * currentStep) + 1;
        }
    }
}

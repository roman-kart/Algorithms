using System;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;

namespace TestAlgorithm
{
    class Program
    {
        static void CreateManyOpbjects()
        {
            var list = new List<string>();
            Random rand = new Random();

            var clock = new Stopwatch();
            clock.Start();

            // количество слов
            for (int i = 0; i < 10000; i++)
            {
                StringBuilder stringBuilder = new StringBuilder();
                // состав слов
                for (int j = 0; j < 100; j++)
                {
                    char symbol = (char)rand.Next(65, 90);
                    stringBuilder.Append(symbol);
                }
                list.Add(stringBuilder.ToString());
            }

            clock.Stop();
            Console.WriteLine($"Creating list: {clock.Elapsed}");
        }
        static void Main(string[] args)
        {
            CreateManyOpbjects();

            var finalizeClock = new Stopwatch();
            finalizeClock.Start();
            GC.Collect(); // вызывает сорщик мусора
            GC.WaitForPendingFinalizers(); // ожидаем, пока завершатся все финализаторы
            finalizeClock.Stop();
            Console.WriteLine($"Finalizing: {finalizeClock.Elapsed}");

            var clock = new Stopwatch();
            clock.Start();

            Random rand = new Random();
            var nums = new int[(1000 * 1000)];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(-500, 500);
            }
            var max = nums[0];
            var iMax = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (max < nums[i])
                {
                    max = nums[i];
                    iMax = i;
                }
            }

            clock.Stop();
            Console.WriteLine($"Doing algorithm: {clock.Elapsed.ToString()}");
            Console.WriteLine($"Max: {max}, max index: {iMax}");
        }
    }
}

// заполняем массив случайными значениями
using System.Diagnostics;

var arr = new int[1000000];
arr.InsertRandomInt();

var timer = new Stopwatch();
timer.Start();
arr = QuickSort.SortAlgorithm.SortAscending(arr);
timer.Stop();
Console.WriteLine(timer.Elapsed);
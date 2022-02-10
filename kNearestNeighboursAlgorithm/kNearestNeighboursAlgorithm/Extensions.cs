using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kNearestNeighboursAlgorithm
{
    public static class Extensions
    {
        public static Point GetCopy(this Point source)
        {
            var copyCoordinates = new List<int>();
            foreach (var item in source.Coordinates)
            {
                copyCoordinates.Add(item);
            }
            return new Point { Coordinates = copyCoordinates };
        }
        public static List<Point> GetCopy(this List<Point> source)
        {
            var copy = new List<Point>();
            foreach (var point in source)
            {
                copy.Add(point.GetCopy());
            }
            return copy;
        }
        public static void InsertRandomPoints(this List<Point> source, int count, int demensions, int min = 0, int max = 5) 
        {
            max++; // чтобы указанное пользователем максимальное значение было включено в диапазон чисел, которые генерирует Random
            if (demensions < 1)
            {
                throw new ArgumentOutOfRangeException("Количество измерений должно быть больше 0!");
            }
            var rand = new Random();
            for (int i = 0; i < count; i++)
            {
                var newPoint = new Point();
                for (int j = 0; j < demensions; j++)
                {
                    newPoint.Coordinates.Add(rand.Next(min, max));
                }
                source.Add(newPoint);
            }
        }
        public static void SortAscending(this List<Point> source)
        {
            var result = sortAscendingRecursion(source);
            source.Clear();
            source.AddRange(result);
        }
        private static List<Point> sortAscendingRecursion(List<Point> pointsArg)
        {
            var points = pointsArg.GetCopy();
            // если данные можно не сортировать
            if (points == null || points.Count < 2)
            {
                return points;
            }
            // если 2 элемента - возвращаем упорядоченный массив
            else if(points.Count == 2)
            {
                // если первый элемент меньше чем второй, значит список упорядочен
                if (points[0].Compare(points[0], points[1]) <= 0)
                {
                    return points;
                }
                var tmp = points[0];
                points[0] = points[1];
                points[1] = tmp;
                return points;
            }
            else
            {
                var centreIndex = points.Count / 2;
                var centre = points[centreIndex];
                var lessThanCentre = new List<Point>();
                var moreThanCentre = new List<Point>();
                for (int i = 0; i < points.Count; i++)
                {
                    if (centreIndex == i)
                    {
                        continue;
                    }
                    if (centre.Compare(centre, points[i]) > 0)
                    {
                        lessThanCentre.Add(points[i]);
                    }
                    else
                    {
                        moreThanCentre.Add(points[i]);
                    }
                }
                lessThanCentre = sortAscendingRecursion(lessThanCentre);
                moreThanCentre = sortAscendingRecursion(moreThanCentre);
                var result = new List<Point>();
                result.AddRange(lessThanCentre);
                result.Add(points[centreIndex]);
                result.AddRange(moreThanCentre);
                
                return result;
            }
        }
    }
}

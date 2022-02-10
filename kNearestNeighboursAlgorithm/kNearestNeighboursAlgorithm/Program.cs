using System;
using System.Collections.Generic;

namespace kNearestNeighboursAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Point> users = new List<Point>();
            users.InsertRandomPoints(100, 3, 0, 5);

            users.SortAscending();

            var Angela = new Point(2, 1, 3);
			foreach (var user in users)
			{
                string point = "";
                double length = 0;
                double distance = 0;
                for (int i = 0; i < user.Coordinates.Count; i++)
                {
                    point += $"{user.Coordinates[i]}, ";
                    length += Math.Pow(user.Coordinates[i], 2);
                    distance += Math.Pow((user.Coordinates[i] - Angela.Coordinates[i]), 2);
                }

				Console.WriteLine($"({point}): Length - {Math.Sqrt(length)}, Distance - {Math.Sqrt(distance)}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kNearestNeighboursAlgorithm
{
    public class Point : IComparer<Point>
    {
        public List<int> Coordinates { get; set; } = new List<int>();
        /// <summary>
        /// Возвращает положение точки на оси определенного измерения.
        /// Номер первого измерения - 1
        /// </summary>
        /// <param name="demension"></param>
        /// <returns></returns>
        public int GetValue(int demension)
        {
            demension = demension - 1; // для получения корректного значения из списка (для 1 измерения 0 элемент)
            // если номер измерения больше, чем кол-во измерений, в которых находится точка, а также если измерение больше 0 
            if (demension >= Coordinates.Count && demension < 0)
            {
                // генерируем исключение
                throw new ArgumentException("Неверный номер измерения");
            }
            return Coordinates[demension];
        }
      private int isGreaterRecursion(Point current, Point other, int demension)
	    {
            // если измерения закончились, значит элементы одинаковые
		    if (current.Coordinates.Count < demension)
		    {
                return 0;
		    }
            // если в текущем измерении величины совпадают - сравниваем рекурсивно следующие уровни
		    else if (current.GetValue(demension) == other.GetValue(demension))
		    {
                return isGreaterRecursion(current, other, demension + 1);
            }
            // если же больше, значит текущий элемент больше
		    else if(current.GetValue(demension) > other.GetValue(demension))
		    {
                return 1;
            }
            // в противном случае он меньше
		    else
		    {
                return -1;
		    }
         
	    }

		public int Compare(Point x, Point y)
		{
         if (x.Coordinates.Count != x.Coordinates.Count)
         {
            throw new ArgumentException("Кол-во измерений у сравниваемых точек не одинаково");
         }
         // сравниваем точки в различных измерениях
         return isGreaterRecursion(x, y, 1);
      }

		public Point()
        {
            Coordinates = new List<int>();
        }
        /// <summary>
        /// Конструктор принимает координаты. 
        /// Координаты должны располагаются в порядке возрастания номера измерения
        /// </summary>
        /// <param name="coordinates"></param>
        public Point(params int[] coordinates)
        {
            if (coordinates == null)
            {
                throw new ArgumentNullException("Координаты не могут быть null!");
            }
            foreach (var coordinate in coordinates)
            {
                this.Coordinates.Add(coordinate);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целые координаты вершин прямоугольника");
            int x1, y1, x2, y2, x3, y3, x4, y4;
            double side1, side2, side3;

            Console.WriteLine("Введите x1:");
            x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите y1:");
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите x2:");
            x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите y2:");
            y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите x3:");
            x3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите y3:");
            y3 = Convert.ToInt32(Console.ReadLine());

            side1 = Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2);
            side2 = Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2);
            side3 = Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2);

            x4 = 0;
            y4 = 0;

            if (side1 == side2 + side3)
            {
                if (y1 == y2)
                {
                    y4 = y3;
                    x4 = x1;
                }
                else
                {
                    y4 = y1;
                    x4 = x3;
                }
                Console.WriteLine("Координаты четвертой вершины: ({0}; {1})", x4, y4);
            }

            else if (side2 == side1 + side3)
            {
                if (y1 == y3)
                {
                    y4 = y2;
                    x4 = x3;
                }
                else
                {
                    y4 = y3;
                    x4 = x2;
                }
                Console.WriteLine("Координаты четвертой вершины: ({0}; {1})", x4, y4);
            }
            else if (side3 == side1 + side2)
            {
                if (y3 == y2)
                {
                    y4 = y1;
                    x4 = x2;
                }
                else
                {
                    y4 = y2;
                    x4 = x1;
                }
                Console.WriteLine("Координаты четвертой вершины: ({0}; {1})", x4, y4);
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
        Console.WriteLine("Для продолжения нажмите любую клавишу");
        Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, deltaAB, deltaAC, deltaBC;

            Console.WriteLine("Введите координату A");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите координату B");
            b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите координату C");
            c = Convert.ToInt16(Console.ReadLine());
            
            deltaAB = Math.Abs(a - b);
            deltaAC = Math.Abs(a - c);
            deltaBC = Math.Abs(b - c);

            if (deltaAB > deltaAC && deltaAC != 0)
            {
                Console.WriteLine("Точка C ближе. Расстояние составляет {0}", deltaAC);
            }

            else if (deltaAC > deltaAB && deltaAB != 0)
            {
                Console.WriteLine("Точка В ближе. Расстояние составляет {0}", deltaAB);
            }
            
            else if (deltaAC == deltaAB && deltaAC != 0)
            {
                Console.WriteLine("Точки B и C равностоящие от А");
            }

            else if (deltaBC == 0 | deltaAB == 0 | deltaAC == 0)
            {
                Console.WriteLine("Точки совпадают");
            }

            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}

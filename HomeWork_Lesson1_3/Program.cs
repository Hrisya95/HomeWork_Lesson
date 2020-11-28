using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Lesson1_3
//    Хрисанфов
//    а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
//    по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
//        Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
//б) * Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Определение расстояния между двумя точками.");

            Console.Write("Введите координату X1:");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координату Y1:");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координату X2:");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координату Y2:");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Distance(x1, y1, x2, y2);
        }

        private static void Distance(double x1, double y1, double x2, double y2)
        {
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("Расстояние между заданными точками равно:{0:f2}", r);
            Console.ReadKey();
        }
    }
}

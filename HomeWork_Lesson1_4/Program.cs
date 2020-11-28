using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Lesson1_4
//    Хрисанфов
//    Написать программу обмена значениями двух переменных:
//а) с использованием третьей переменной;
//б) * без использования третьей переменной.

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Обмен значениями двух переменных.");
            Console.Write("Введите первое число а:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите первое число б:");
            int b = Convert.ToInt32(Console.ReadLine());
            int c;

            #region a)
            //c = b;
            //b= a;
            //a = c;
            #endregion

            #region б)

            a = a + b;
            b = a - b;
            a = a - b;

            #endregion


            Console.WriteLine($"теперь б = {b} , а  а= {a}");
            Console.ReadKey();
        }
    }
}

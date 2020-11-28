using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Lesson1_2
// Хрисанфов
//Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h* h); 
//где m — масса тела в килограммах, h — рост в метрах.

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Рассчет индекса массы тела(ИМТ)");

            Console.Write("Ввведите массу тела в килограммах:");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите рост в метрах:");
            double growth = Convert.ToDouble(Console.ReadLine());

            double imt = weight / (growth * growth);

            Console.WriteLine($"Индекс массы тела равен : {imt}" );
            Console.ReadKey();

        }
    }
}

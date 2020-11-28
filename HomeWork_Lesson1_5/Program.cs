using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Lesson1_5
//    Хрисанфов
//    а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
//б) * Сделать задание, только вывод организовать в центре экрана.
// в) ** Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).

{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Николай";
            string secondName = "Хрисанфов";
            string homeLand = "Химки";
            PrintCenter(name, secondName, homeLand);
        }

        private static void PrintCenter(string name, string secondName, string homeLand)
        {
            int x = Console.WindowHeight / 2;
            int y = Console.WindowWidth / 2;
            Console.SetCursorPosition(x, y);
            Console.WriteLine($"Имя: {name} Фамилия: {secondName} Город проживания: {homeLand}");
            Console.ReadKey();
        }
    }
}

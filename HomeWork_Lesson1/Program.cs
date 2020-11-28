using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Lesson1

//Хрисанфов
//Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).
//В результате вся информация выводится в одну строчку:
//а) используя склеивание;
//б) используя форматированный вывод;
//в) используя вывод со знаком $.

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Анкета.Пожадуйста запоните все поля.");
            Console.Write("Введите ваше имя:");
            string name = Console.ReadLine();

            Console.Write("Введите вашу фамилию:");
            string secondName = Console.ReadLine();

            Console.Write("Введите ваш возраст:");
            string age = Console.ReadLine();

            Console.Write("Введите ваш рост:");
            string growth = Console.ReadLine();

            Console.Write("Введите ваш вес :");
            string weight = Console.ReadLine();

            #region a)

            Console.WriteLine(name +  secondName +  age +  growth +  weight);
            Console.ReadKey();
            #endregion
            #region б)
            Console.WriteLine("{0} {1} {2} лет {3} см  {4} кг",name, secondName,age,growth,weight);
            Console.ReadKey();
            #endregion
            #region в)
            Console.WriteLine($"{name} {secondName} {age} лет {growth} см {weight} кг");
            Console.ReadKey();
            #endregion
        }
    }
}

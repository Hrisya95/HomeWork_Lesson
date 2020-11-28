using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Lesson1_6
{
    class Help
    {
        public static void Pause ()
        {
            Console.ReadKey();
        }

        public static void Print(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}

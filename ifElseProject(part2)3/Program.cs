using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElseProject_part2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1, y1; // обьявление

            Console.WriteLine("Козырский Илья 24ИС"); // вывод на экран

            Console.WriteLine("Введите x1= "); // вывод на экран

            x1 = Convert.ToDouble(Console.ReadLine()); // присваивание значения переменной

            Console.WriteLine("Введите y1 = "); // вывод на экран

            y1 = Convert.ToDouble(Console.ReadLine()); // присваивание значения переменной

            // проверка условия

            if (x1 > 0 && y1 > 0)

                Console.WriteLine("I четверть");

            else if (x1 < 0 && y1 > 0)

                Console.WriteLine("II четверть");

            else if (x1 < 0 && y1 < 0)

                Console.WriteLine("III четверть");

            else if (x1 > 0 && y1 < 0)

                Console.WriteLine("IV четверть");

            else

                Console.WriteLine("Точка лежит не на оси"); // вывод на экран

            Console.ReadKey(); // закрытие программы по нажатию на клавишу

        }
    }
}

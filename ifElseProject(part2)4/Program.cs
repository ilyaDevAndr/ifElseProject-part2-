using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElseProject_part2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x; // обьявление на экран

            Console.WriteLine("Козырский Илья 24ИС"); // вывод на экран

            Console.WriteLine("Принадлежит ли точка x промежутку [0,1]? "); // вывод на экран

            x = Convert.ToDouble(Console.ReadLine()); // присваивание значение переменной

            // проверка условия

            if (x >= 0 && x <= 1)

            {

                Console.WriteLine("Да принадлежит");

            }

            else

            {

                Console.WriteLine("Не принадлежит");

            }

            Console.ReadKey(); // закрытие программы по нажатию на клавишу

        }
    }
}

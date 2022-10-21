using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElseProject_part2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Козырский Илья"); // вывод на экран

            // обьявление переменных

            double x, y;

            // вывод на экран

            Console.Write("Введите x = ");

            x = Convert.ToDouble(Console.ReadLine()); // присваивание значения x

            // проверка условия

            if (x < -2)

            {

                y = 2 * Math.Log(x + 2);

                Console.Write($"y={y}");

            }

            else if (-2 <= x && x < 5)

            {

                y = Math.Sqrt(x + 2 * Math.Sqrt(x + 3));

                Console.Write($"y={y}");

            }

            else if (x >= 5)

            {

                y = 3 * Math.Pow(x, 2) - 5 * x - 3;

                Console.Write($"y={y}");

            }

        }
    }
}

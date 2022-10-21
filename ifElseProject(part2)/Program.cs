using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElseProject_part2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y; // обьявляем переменные

            Console.Write("Введите x = "); // вывод на экран

            x = Convert.ToInt32(Console.ReadLine()); // присваиваем значение x

            // проверка условия

            if (x % 4 == 0) // если x делится на 4 нацело

            {

                y = x / 4;

                Console.WriteLine($" y = {y}");

            }

            else

            {

                Console.WriteLine("Введенное число не делится нацело ");

            }

            // закрытие программы по нажатию на клавишу
            Console.WriteLine("Козырского Ильи");
            Console.ReadKey();


        }
    }
}

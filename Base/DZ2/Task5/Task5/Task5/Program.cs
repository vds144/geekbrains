using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Запросить у пользователя порядковый номер текущего месяца и вывести его название.


            //Зачача 1. Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.

            // Запрашиваем минимальную температуру у пользователя

            Console.WriteLine("Укажите минимальную температуру за сутки:");
            string mintemp = Console.ReadLine();

            //Конвектируем минимальную температуру в число с плавающей число (строку в число)
            double z = double.Parse(mintemp);

            // Запрашиваем максимальную температуру у пользователя
            Console.WriteLine("Укажите максимальную температуру за сутки:");
            string maxtemp = Console.ReadLine();

            //Конвектируем минмаксимальную имальную температуру в число с плавающей число (строку в число)
            double y = double.Parse(maxtemp);

            // производим расчет среднего знакчения
            double a = (z + y) / 2;
            Console.WriteLine($"Средняя температура за сутки:  {a}");

            Console.WriteLine("Укажите номер текущего месяца");
            string month = Console.ReadLine();
            int i = Convert.ToInt32(month);
            if (i == 1)
            {
                Console.WriteLine("Название месяца: Январь");

                if (a >= 0)
                {
                    Console.WriteLine("Дождливая зима");
                }

                Console.ReadLine();
            }
            else if (i == 2)
            {
                Console.WriteLine("Название месяца: Февраль");

                if (a >= 0)
                {
                    Console.WriteLine("Дождливая зима");
                }

                Console.ReadLine();
            }
            else if (i == 3)
            {
                Console.WriteLine("Название месяца: Март");
                Console.ReadLine();
            }
            else if (i == 4)
            {
                Console.WriteLine("Название месяца: Апрель");
                Console.ReadLine();
            }
            else if (i == 5)
            {
                Console.WriteLine("Название месяца: Май");
                Console.ReadLine();
            }
            else if (i == 6)
            {
                Console.WriteLine("Название месяца: Июнь");
                Console.ReadLine();
            }
            else if (i == 7)
            {
                Console.WriteLine("Название месяца: Июль");
                Console.ReadLine();
            }
            else if (i == 8)
            {
                Console.WriteLine("Название месяца: Август");
                Console.ReadLine();
            }
            else if (i == 9)
            {
                Console.WriteLine("Название месяца: Сентябрь");
                Console.ReadLine();
            }
            else if (i == 10)
            {
                Console.WriteLine("Название месяца: Октябрь");
                Console.ReadLine();
            }
            else if (i == 11)
            {
                Console.WriteLine("Название месяца: Ноябрь");
                Console.ReadLine();
            }
            else if (i == 12)
            {
                Console.WriteLine("Название месяца: Декабрь");

                if (a >= 0)
                {
                    Console.WriteLine("Дождливая зима");
                }

                Console.ReadLine();
            }
        }
    }
}

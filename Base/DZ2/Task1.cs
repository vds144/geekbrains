using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job1
{
    class Task1

    {
        static void Main(string[] args)
        {
             
            //Зачача 1. Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.

            // Запрашиваем минимальную температуру у пользователя
            Console.WriteLine("Укажите минимальную температуру за сутки:");
            string mintemp = Console.ReadLine();

            //Конвектируем минимальную температуру в число с плавающей число (строку в число)
            double i = double.Parse(mintemp);

            // Запрашиваем максимальную температуру у пользователя
            Console.WriteLine("Укажите максимальную температуру за сутки:");
            string maxtemp = Console.ReadLine();

            //Конвектируем минмаксимальную имальную температуру в число с плавающей число (строку в число)
            double y = double.Parse(maxtemp);

            // производим расчет среднего знакчения
            double a = (i + y) /2;
            Console.WriteLine($"Средняя температура за сутки:  {a}");
            Console.ReadLine();

        }
    }
}

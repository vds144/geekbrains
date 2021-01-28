using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4_Task3
{
    class Program
    {

        //Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца. 
        //На выходе — значение из перечисления (enum) — Winter, Spring, Summer, Autumn. 
        //Написать метод, принимающий на вход значение из этого перечисления и возвращающий название 
        //времени года (зима, весна, лето, осень). Используя эти методы, 
        //ввести с клавиатуры номер месяца и вывести название времени года. 
        //Если введено некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».

        enum Season
        {
            Winter,
            Spring,
            Summer,
            Autumn

        }


        static void Main(string[] args)
        {

            string name1 = MonthYearth();
            Console.ReadLine();
        }

        static string MonthYearth()
        {
            Console.WriteLine("Укажите номер текущего месяца");
            string month = Console.ReadLine();
            int i = Convert.ToInt32(month);
            if (i == 12 || i == 1 || i == 2)
            {
                Console.WriteLine($"Время года: {Season.Winter}");
                Console.ReadLine();
            }
            else if (i == 3 || i == 4 || i == 5)
            {
                Console.WriteLine($"Время года: {Season.Spring}");
                Console.ReadLine();
            }
            else if (i == 6 || i == 7 || i == 8)
            {
                Console.WriteLine($"Время года: {Season.Summer}");
                Console.ReadLine();
            }
            else if (i == 9 || i == 10 || i == 11)
            {
                Console.WriteLine($"Время года: {Season.Autumn}");
                Console.ReadLine();
            }
            if (i >= 13 || i <= 0 )
            {
                Console.WriteLine("Ошибка: введите число от 1 до 12");
            }

            return month;
        }

       
        
    }
}

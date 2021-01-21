using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job2
{
    class Task2
    {


        static void Main(string[] args)
        {

            //Запросить у пользователя порядковый номер текущего месяца и вывести его название.


            Console.WriteLine("Укажите номер текущего месяца");
            string month = Console.ReadLine();
            int i = Convert.ToInt32(month);
            if (i == 1)
            {
                Console.WriteLine("Название месяца: Январь");
                Console.ReadLine();
            }
            else if (i == 2)
            {
                Console.WriteLine("Название месяца: Февраль");
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
                Console.ReadLine();
            }
        }
    }
}

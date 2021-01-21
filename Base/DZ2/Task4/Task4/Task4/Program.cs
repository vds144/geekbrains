using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Для полного закрепления понимания простых типов найдите любой чек,
            // либо фотографию этого чека в интернете и схематично нарисуйте его в консоли, 
            //только за место динамических, по вашему мнению, данных (это может быть дата, название магазина, 
            //сумма покупок) подставляйте переменные, которые были заранее заготовлены до вывода на консоль.

            string OOO = "ИП Рога и копыта";
            string Magazin = "Магазин Звезда";
            int index = 620050;
            string street = "Екатерибург, Ленина 1";
            string terminal = "Терминал";
            int numberterminal = 27670101;
            string chek = "Чек";
            int numberchek = 6400;
            string result = "Итог операции";
            string resultpayments = "Оплачено";
            string sum = "Сумма";
            double price = 881.54;
            string valuta = "RUB";
            string nimbersilki = "Номер ссылки RRN";
            long RRN = 1011010101010101010;
            string date = "Дата";
            DateTime numberdate = new DateTime(2020, 8, 4, 16, 23, 42);


            Console.WriteLine(OOO);
            Console.WriteLine(Magazin);
            Console.WriteLine($"{index}, {street}");
            Console.WriteLine($"{terminal}: {numberterminal}");
            Console.WriteLine($"{chek}: {numberchek}");
            Console.WriteLine($"{result}: {resultpayments}");
            Console.WriteLine($"{sum}: {price} {valuta}");
            Console.WriteLine($"{nimbersilki}: {RRN}");
            Console.WriteLine($"{date}: {numberdate}");
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job3
{
    class Task3
    {
        static void Main(string[] args)
        {

            // Определить, является ли введённое пользователем число чётным.

            Console.WriteLine("Введие число");
            string number = Console.ReadLine();
            int i = Convert.ToInt32(number);

            if (i % 2 == 1)

            {
                Console.WriteLine("Нечетное");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Четное");
                Console.ReadLine();
            }

        }
    }
}

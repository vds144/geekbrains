using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string name1 = Text();
            Console.ReadLine();
        }


        static string Text()
        {
            Console.WriteLine("Добрый день!");
            Console.WriteLine("До какого числа считать ряд Фибоначчи?");
            int number = Convert.ToInt32(Console.ReadLine());

            int perv = 0;
            Console.Write("{0} ", perv);
            int vtor = 1;
            Console.Write("{0} ", vtor);
            int sum = 0;

            while (number >= sum) 
            {
                sum = perv + vtor;
                Console.Write("{0} ", sum);
                perv = vtor;
                vtor = sum;
            }
            return Text();

        }

    }
}

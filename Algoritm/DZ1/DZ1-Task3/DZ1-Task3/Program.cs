using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1_Task3
{
    class Program
    {
        public static int Main()
        {
            Console.Write("Введите конец диапазона от 1 до : ");
            int end = int.Parse(Console.ReadLine());
            int j = 1;
            for (int i = 1; i <= end; i += j)
            {
                Console.Write("{0} ", i);
                j = i - j;
            }
            Console.ReadKey();
            return 0;
        }
    }

}

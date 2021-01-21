using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как к вам можно обращаться?");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}, сегодня {DateTime.Today.ToShortDateString()}.");
            Console.ReadLine();
        }
    }
}

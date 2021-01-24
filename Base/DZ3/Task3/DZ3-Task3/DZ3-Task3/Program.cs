using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;

            while ((s = Console.ReadLine()) != null)
                Console.WriteLine(new string(s.Reverse().ToArray()));
        }
        }
}

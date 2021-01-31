using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        //Написать программу, которая при старте дописывает текущее время в файл «startup.txt».
        public static DateTime Now { get; set; }

        static void Main(string[] args)
        {
            DateTime time = DateTime.Now;

            string timeconvert = Convert.ToString(time);
            string filename = "startup.txt";
            File.AppendAllText(filename, timeconvert);
            File.AppendAllText(filename, Environment.NewLine);
         
        }
    }
}

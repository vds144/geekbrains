using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4_Task2
{
    class Program
    {
        //Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом, 
        //и возвращающую число — сумму всех чисел в строке.
        //Ввести данные с клавиатуры и вывести результат на экран.

        static void Main(string[] args)
        {
          
            Console.WriteLine("Введите набор чисел через пробел");
            string text1 = Console.ReadLine();
            Console.WriteLine($"Сумма чисел равна: {Sum(text1)}");
            Console.ReadLine();
        }


        static int Sum(string text1)
        {
            return text1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).Sum();
        }


    }
}



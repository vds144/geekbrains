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

            //Написать программу, выводящую введенную пользователем строку в обратном порядке (olleH вместо Hello).


            //Варинт первый

            //string s;

            //while ((s = Console.ReadLine()) != null)
            //    Console.WriteLine(new string(s.Reverse().ToArray()));


            //Варинт второй

            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            char[] TextRev = text.Reverse().ToArray();
         
            for (int i = 0; i < text.Length; i++)
            {
                if (i >= 0)
                {

                    System.Console.Write($"{TextRev[i]}");
                    Console.ReadLine();
                }
            }
        }
    }
}

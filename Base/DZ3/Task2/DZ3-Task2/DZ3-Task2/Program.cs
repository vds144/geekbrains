using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3_Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            //2. Написать программу «Телефонный справочник»: создать двумерный массив 5х2, 
            //хранящий список телефонных контактов: первый элемент хранит имя контакта,
            //второй — номер телефона/email.



            string[,] matrix = new string[5, 2];
            matrix[0, 0] = "valov";
            matrix[0, 1] = "vdsekb@gmail.com";
            matrix[1, 0] = "ivanov";
            matrix[1, 1] = "ivanovb@mail.com";
            matrix[2, 0] = "stepanov";
            matrix[2, 1] = "89222233888";
            matrix[3, 0] = "Рябков";
            matrix[3, 1] = "ryabkov@mail.ru / 89222233889";
            matrix[4, 0] = "Аня";
            matrix[4, 1] = "89222233890 / Anna@mail.ru";


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)

                {
                    System.Console.Write($"{' '}{matrix[i, j]}");
                }
                System.Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}

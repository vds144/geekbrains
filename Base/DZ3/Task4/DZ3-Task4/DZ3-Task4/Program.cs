using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3_Task4
{
    class Program
    {
        static void Main(string[] args)
        {

            //«Морской бой» — вывести на экран массив 10х10, состоящий из символов X и O, 
            //где Х — элементы кораблей, а О — свободные клетки.


            string[,] matrix = new string[10, 10];

            matrix[0, 0] = "X";
            matrix[0, 8] = "X";
            matrix[1, 2] = "X";
            matrix[1, 3] = "X";
            matrix[1, 4] = "X";
            matrix[1, 8] = "X";
            matrix[2, 8] = "X";
            matrix[3, 1] = "X";
            matrix[3, 6] = "X";
            matrix[3, 8] = "X";
            matrix[4, 1] = "X";
            matrix[4, 6] = "X";
            matrix[4, 8] = "X";
            matrix[5, 1] = "X";
            matrix[5, 4] = "X";
            matrix[6, 4] = "X";
            matrix[7, 2] = "X";
            matrix[8, 2] = "X";
            matrix[9, 0] = "X";
            matrix[9, 9] = "X";


            string ch1 = "O";
            string ch2 = "X";


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == matrix[0, 1])
                    {
                        System.Console.Write($"{ch1}   " );
                    }
                    else 
                      {
                        System.Console.Write($"{ch2}   ");
                    }
                }
                System.Console.WriteLine();
                Console.ReadLine();
            }



        }
    }
}
    



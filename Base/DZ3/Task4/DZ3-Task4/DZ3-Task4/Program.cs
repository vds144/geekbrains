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


            char[,] seabatle = new char[5, 5];
            char element1 = 'Х';
            char element2 = 'О';

            for (int i = 0; i < seabatle.GetLength(0); i++)
            {
                for (int j = 0; j < seabatle.GetLength(1); j++)
                {
                    if (seabatle[i, j] == seabatle[i, i])
                    {
                        seabatle[i, j] = element1;
                    }
                    else
                        seabatle[i, j] = element2;

                    System.Console.Write(seabatle[i, j]);


                }
                System.Console.WriteLine();
                Console.ReadLine();
            }

        }
    }
}

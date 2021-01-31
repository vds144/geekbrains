using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    {
        //Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 0 до 255");
            string number = Console.ReadLine();
            int q = Convert.ToInt32(number);

            if (q >= 0  &&  q <= 255)
            {
               
                byte i = (byte) q;
                byte[] array = { i };

                File.WriteAllBytes("NumberBytes.bin", array);
                byte[] fromFile = File.ReadAllBytes("NumberBytes.bin");

                Console.WriteLine($"Число {i} успешно сохранено в файле NumberBytes.bin");
                Console.ReadLine();
            }
             if (q < 0 || q > 255)
            {
                Console.WriteLine("Ошибка. Введите число от 0 до 255");
                Console.ReadLine();
            }
        }
    }
}

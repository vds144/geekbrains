using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{

    //Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите данные для сохранения и их в тестовый файл");
            string text = Console.ReadLine();

            string filename = "text.txt";
            File.WriteAllText(filename, text);
            File.AppendAllText(filename, Environment.NewLine);

        }
    }
}

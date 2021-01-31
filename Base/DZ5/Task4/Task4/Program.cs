using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {

        //Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без

        static void Main(string[] args)
        {
            string catalogManager = CatalogManager();
            Console.ReadLine();
        }

        static string CatalogManager()
        {
            Console.WriteLine("Укажите каталог или файл. Пример: C:\\Program Files ");
            string text = Console.ReadLine();

            if (Directory.Exists(text))
            {
                Console.WriteLine("Подкаталоги:");
                string[] dirs = Directory.GetDirectories(text);
                foreach (string s in dirs)
                {
                    string filename = "Catolog.txt";
                    File.AppendAllText(filename, s);

                    File.AppendAllText(filename, Environment.NewLine);
                    string filetext = File.ReadAllText(filename);
                    Console.WriteLine(filetext);
                }

                Console.WriteLine();
                Console.WriteLine("Файлы");
                string[] files = Directory.GetFiles(text);
                foreach (string s in files)
                {
                    string filename = "Catolog.txt";
                    File.AppendAllText(filename, s);

                    File.AppendAllText(filename, Environment.NewLine);
                    string filetext = File.ReadAllText(filename);
                    Console.WriteLine(filetext);
                }

               
            }
            return CatalogManager();

        }
    }
}

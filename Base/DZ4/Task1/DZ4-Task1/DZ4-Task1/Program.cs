using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4_Task1
{
    class Program
    {

        //Написать метод GetFullName(string firstName, string lastName, string patronymic), 
        //принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО.
        //Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.

        static void Main(string[] args)
        {

            string name1 = FullName();
            Console.ReadLine();

        }

        static string GetFullName()
            {
            // Тело запроса ФИО
            Console.WriteLine("Введите фамилию");
            string lastName = Console.ReadLine();
            Console.WriteLine("Введите имя");
            string firstname = Console.ReadLine();
            Console.WriteLine("Введите Отчество");
            string patronymic = Console.ReadLine();

            // Полный вывод ФИО
            Console.WriteLine($"Привет, {lastName} {firstname} {patronymic}");

            return patronymic;
            }



        static string FullName()

        {
            // Цикл запроса ФИО из 4, удобно выставить нужное значение например 3(как указано в описании задачи)

            for (int i = 0; i < 3; i++)
            {
                string name1 = GetFullName();
            }
            
            // Конвертация для вывода return 0.
            int q = 0;
            string s1 = q.ToString();
            return s1;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrainsTests
{
    class Program
    {

        static void Main(string[] args)
        {

            var duplexList = new DuplexLinkedList<int>();
            Console.WriteLine("добавляет новый элемент списка ");
            duplexList.AddNode(1);
            duplexList.AddNode(2);
            duplexList.AddNode(3);
            duplexList.AddNode(4);
            duplexList.AddNode(5);

            foreach (var item in duplexList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("возвращает количество элементов в списке");

            duplexList.GetCount(1);

            Console.WriteLine("удаляет элемент по порядковому номеру");

            duplexList.RemoveNode(3);

            foreach (var item in duplexList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("удаляет указанный элемент");
            

            duplexList.RemoveNode(2);
            foreach (var item in duplexList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();


        }

    }
}



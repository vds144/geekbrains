using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;


namespace Task5
{
    class Program
    {

        // (*) Список задач(ToDo-list) :
        // написать приложение для ввода списка задач;
        // задачу описать классом ToDo с полями Title и IsDone;
        // на старте, если есть файл tasks.json/xml/bin(выбрать формат), загрузить из него массив имеющихся задач и вывести их на экран;
        // если задача выполнена, вывести перед её названием строку «[x]»;
        // вывести порядковый номер для каждой задачи;
        // при вводе пользователем порядкового номера задачи отметить задачу с этим порядковым номером как выполненную;
        // записать актуальный массив задач в файл tasks.json/xml/bin.



        static void Main(string[] args)
        {
            ToDo todo = new ToDo(" ", 2);
            string json = File.ReadAllText("task.json");
            ToDo task = JsonSerializer.Deserialize<ToDo>(json);
            //System.Console.WriteLine(task.Title);
            //System.Console.WriteLine(task.IsDone);
            //Console.ReadLine();

            //if (task.IsDone == 0)
            //{
            //    Console.WriteLine($"[x] {task.Title} - Выполнено");
            //}
            //else
            //{
            //    Console.WriteLine($"{task.Title} - В процессе");
            //}

        }


    }
}

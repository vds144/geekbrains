using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using Task5._1;

namespace Task5
{
    class Program
    {
        private static int i;


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
            Console.WriteLine("Добрый день! Нажмите Enter для выгрузки списка задач из Json файла");
            Console.ReadLine();

            var ToDoArray = new ToDo[3];
            ToDo todo = new ToDo();

            var json = File.ReadAllText("task.json");
            ToDoArray = JsonSerializer.Deserialize<ToDo[]>(json);

            todo.number  = 1;

            for (int i = 0; i < ToDoArray.Length; i++)
            {
                if (ToDoArray[i].IsDone == true)
                {
                   Console.WriteLine($"{todo.number++}[+]{ToDoArray[i].Title}  {ToDoArray[i].IsDone}");
                }
                else
                {
                    Console.WriteLine($"{todo.number++} {ToDoArray[i].Title}  {ToDoArray[i].IsDone}");
                }
            }

            Console.WriteLine("Чтобы изменить статус задачи на выполнено введите порядковый номер задачи");
            string changestatus = Console.ReadLine();

            int edc = Convert.ToInt32(changestatus);
                if (edc == 1)
                {
                    ToDoArray[0].IsDone = true;
                }
                if (edc == 2)
                {
                    ToDoArray[1].IsDone = true;
                }
                if (edc == 3)
                {
                    ToDoArray[2].IsDone = true;
                }
            
            Console.WriteLine("Нажмите Enter для выгрузки списка задач в формат Json");
            Console.ReadLine();

            ToDo[] todo1 = new ToDo[3];

            todo1[0] = new ToDo();
            todo1[0].Title = ToDoArray[i].Title;
            todo1[0].IsDone = ToDoArray[0].IsDone;
            todo1[0].Number = 1;

            todo1[1] = new ToDo();
            todo1[1].Title = ToDoArray[i].Title;
            todo1[1].IsDone = ToDoArray[1].IsDone;
            todo1[1].Number = 2;

            todo1[2] = new ToDo();
            todo1[2].Title = ToDoArray[i].Title;
            todo1[2].IsDone = ToDoArray[2].IsDone;
            todo1[2].Number = 3;

            string json1 = JsonSerializer.Serialize(todo1);
            File.WriteAllText("Task2.json", json1);



        }


    }
}

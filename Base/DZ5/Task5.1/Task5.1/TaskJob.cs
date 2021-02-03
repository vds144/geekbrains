using System;
using System.Collections.Generic;
using System.Text;

namespace Task5._1
{
    class TaskJob
    {

        public static string task { get; internal set; }

        public TaskJob()
        {

            Console.WriteLine("Введит описание задачи");
            string task = Console.ReadLine();
            Console.WriteLine("Введите 1 в процессе, 0 выполнено, 2 ожидание");
            string process = Console.ReadLine();
            int i = Convert.ToInt32(process);

            if (i == 1)
            {
                string progress = process;
                Console.WriteLine($"Статус задачи {progress} - в процессе");
                Console.ReadLine();
            }
            if (i == 0)
            {
                string done = process;
                Console.WriteLine($"Статус задачи {done} - выполнено [x]");
                Console.ReadLine();
            }

            if (i == 2)
            {
                string ojidanie = process;
                Console.WriteLine($"Статус задачи {ojidanie} - Ожидание");
                Console.ReadLine();
            }
        }

    }
}

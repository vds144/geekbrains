using System;
using System.Diagnostics;

namespace TaskManager
{
    class Program
    {
        static void Main(string[] args)
        {

            //Написать консольное приложение Task Manager, которое выводит на экран запущенные процессы и позволяет завершить
            //указанный процесс.Предусмотреть возможность завершения процессов с помощью указания его ID или имени процесса. 
            //В качестве примера можно использовать консольные утилиты Windows tasklist и taskkill.

             Process[] procs = Process.GetProcesses();

            foreach (Process proc in procs)
            {
                Console.WriteLine($"{ proc.Id} {proc.ProcessName}");
            }
                Console.WriteLine("Введите ID или названия процесса");
                 string procid = Console.ReadLine();
                

            foreach (Process proc in procs)
            {
                if (procid == procid)
                {

                    foreach (var process in Process.GetProcessesByName(procid))
                    {
                        process.Kill();
                    }

                    Console.WriteLine($"Процесс {procid}  успешно завершен");
                    Console.ReadLine();

                }
                if (procid != proc.ProcessName)
                {
                    try
                    {
                        int procidint = Convert.ToInt32(procid);
                        Process localById = Process.GetProcessById(procidint);
                        localById.Kill();
                    }
                    catch
                    {

                        Console.WriteLine($"Процесс {procid}  успешно завершен");
                        Console.ReadLine();
                    }
                }
                break;
            }
            
        }
    }
}

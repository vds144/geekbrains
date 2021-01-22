using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {

        [Flags]
        public enum JobDay
        {
            // Для читаемости разряды можно разделять знаком подчёркивания.
            // Они никак не влияют на значение.

            none =            0b_0000_0001,
            Понедельник =     0b_0000_0001,
            Вторник =         0b_0000_0010,
            Среда =           0b_0000_0100,
            Четверг =         0b_0000_1000,
            Пятница =         0b_0001_0000,
            Суббота =         0b_0010_0000,
            Воскресенье =     0b_0100_0000,
        }

        static void Main(string[] args)
        {
            

            //(*) Для полного закрепления битовых масок, попытайтесь создать универсальную структуру расписания недели, 
            //к примеру, чтобы описать работу какого либо офиса. 
            //Явный пример - офис номер 1 работает со вторника до пятницы, офис номер 2 работает с понедельника до воскресенья.

            JobDay Office1 = JobDay.Вторник | JobDay.Среда | JobDay.Четверг | JobDay.Пятница;
            JobDay Office2 = JobDay.Понедельник | JobDay.Вторник | JobDay.Среда | JobDay.Четверг | JobDay.Пятница | JobDay.Суббота | JobDay.Воскресенье;


            Console.WriteLine("Какой день недели вас интересует?");
            string dayweek = Console.ReadLine();
            int day = Convert.ToInt32(dayweek);

            JobDay d = (JobDay)Enum.GetValues(typeof(JobDay)).GetValue(day);

            string s = Enum.GetName(typeof(JobDay), d);

            JobDay time1 = Office1 & d;
            JobDay time2 = Office2 & d;

            bool open1 = time1 == d;
            bool open2 = time2 == d;

            string openoffice1;
            string openoffice2;

            if (open1)
            {
                openoffice1 = "Офис1 открыт";
            }
            else
            {
                openoffice1 = "Офис1 закрыт";
            }


            if (open2)
            {
                openoffice2 = "Офис2 открыт";
            }
            else
            {
                openoffice2 = "Офис2 закрыт";
            }


            Console.WriteLine($"Сегодня {s}, {openoffice1}, {openoffice2}");
            Console.ReadLine();


        }
    }
}

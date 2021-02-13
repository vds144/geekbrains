using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ8
{
    class Program
    {
        public static object UserName { get; set; }
        public static object Job { get;  set; }

        //Создать консольное приложение, которое при старте выводит приветствие, 
        //записанное в настройках приложения(application-scope). Запросить у пользователя имя, 
        //возраст и род деятельности, а затем сохранить данные в настройках.
        //При следующем запуске отобразить эти сведения.Задать приложению версию и описание.

        static void Main(string[] args)
        {

            string greeting = Properties.Settings.Default.Greeting;
            Console.WriteLine($"{ greeting}");
            Console.ReadLine();

            Console.WriteLine("Как к вам можно обращаться?");
            Properties.Settings.Default.UserName = Console.ReadLine();
            Properties.Settings.Default.Save();
            string userName = Properties.Settings.Default.UserName;

            Console.WriteLine("Сколько вам лет?");
            string userAge = Console.ReadLine();
            byte userAgeConvert = (byte)Convert.ToSByte(userAge);
            Properties.Settings.Default.Age = userAgeConvert;
            Properties.Settings.Default.Save();
            byte age = Properties.Settings.Default.Age;

            Console.WriteLine("Какая у вас сфера деятельности?");
            Properties.Settings.Default.Job = Console.ReadLine();
            Properties.Settings.Default.Save();
            string job = Properties.Settings.Default.Job;


            Console.WriteLine($"{greeting} {userName}, вам {userAgeConvert} и вы занимаетесь {job}");
            Console.ReadLine();
        }
    }
}

using System;

namespace GeekBrainsAlgos
{
   public class Program
    {

        public static decimal Reverse(int n)
        {
            int d = 0;
            int i = 2;
    
           while (i < n)
            {
                if (n % i == 0)
                {
                    d++;
                    i++;
                }
                else
                {
                    i++;
                }
            }

           if(d == 0)
            {
                Console.WriteLine("Простое");
            }
             else
            {
                Console.WriteLine("Не простое");
            }
            return n;
        }


       static void Main(string[] args)
        {
            try
            {
                
                Console.WriteLine("Введите чисило");
                string number = Console.ReadLine();
                int numberstr = Convert.ToInt32(number);
                if (numberstr > 1)
                {
                    Reverse(numberstr);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Число должно быть положительным и больше 2");
                    Console.ReadLine();

                }
            }
            catch
            {
                Console.WriteLine("Вы ввели недопустимое значение, введите от 2 до 2147483647");
                Console.ReadLine();
            }
        }
    }
}

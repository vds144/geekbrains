using System;

namespace GeekBrainsAlgos
{
    class Program
    {

        public static decimal Reverse(int n) //В данном случае ввод — это просто аргумент функции. Просто входной параметр.
        {
            int d = 0;
            int i = 2;
    
           while (i < n)
            {
                if(n % i == 0)
                {
                    d++;
                } 
                    i++;
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

                Console.WriteLine($"Output: {Reverse(numberstr)}");
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Вы ввели недопустимое значение");
                Console.ReadLine();
            }

            //Проверки

            for (int test1 = 0; test1 <1000; test1++)
            {
                Console.WriteLine($"Output: {Reverse(test1)}");
                Console.WriteLine($" ");


            }
            Console.ReadLine();
        }
    }
}

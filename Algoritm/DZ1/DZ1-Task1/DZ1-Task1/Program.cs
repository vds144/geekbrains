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

            //Проверки

            var testDate = new TestCase[2];
            testDate[0] = new TestCase()
            {
                Expected = "Простое",
                Expectedfalse = "Не простое"
            };

            foreach (var testCase in testDate)
            {
         

                int numberstr = 5;
                Reverse(numberstr);

                Console.WriteLine($"Проверка числа {numberstr} Ожидаемый результат {testCase.Expected}");
                Console.ReadLine();

                int numberstr2 = 9;
                Reverse(numberstr2);

                Console.WriteLine($"Проверка числа {numberstr2} Ожидаемый результат {testCase.Expectedfalse}");
                Console.ReadLine();

                int numberstr3 = 199;
                Reverse(numberstr3);

                Console.WriteLine($"Проверка числа {numberstr3} Ожидаемый результат {testCase.Expected}");
                Console.ReadLine();

                break;
            }
            Console.ReadLine();
        }
    }
}

using System;
using GeekBrainsTests;

namespace HW2
{
    class TestCaseTask1
    {
        public int[] InputNumbers { get; set; }
        public int RemoveId { get; set; }
        public int Find { get; set; }

        public void exec()
        {
            var resultList = new Task1();

            for (int i = 0; i < InputNumbers.Length; i++)
            {
                resultList.AddNode(InputNumbers[i]);
            }
            Console.WriteLine("Проверка добавления значений");
            Console.Write("Результат:");
            resultList.PrintList();
            Console.WriteLine($"Ожидание: {String.Join(" ", InputNumbers)}");
            Console.WriteLine();

            Console.WriteLine("Проверка подсчета длина");
            Console.WriteLine($"Результат: {resultList.GetCount()}");
            Console.WriteLine($"Ожидание: {InputNumbers.Length}");
            Console.WriteLine();

            Console.WriteLine($"Проверка поиска по значению {Find} / удаления узла по значению / вставка узла после указанного");
            try
            {
                var findNode = resultList.FindNode(Find);
                var prevNode = findNode.PrevNode;

                Console.WriteLine($"Результат поиска: {findNode.Value}");
                resultList.RemoveNode(findNode);

                Console.Write("Результат удаления:");
                resultList.PrintList();

                resultList.AddNodeAfter(prevNode, Find);
                Console.Write("Результат добавления:");
                resultList.PrintList();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Результат: ошибка: {e.Message}");
            }

            var ExpectedIndex = Array.IndexOf(InputNumbers, Find);
            if (ExpectedIndex != -1)
            {
                Console.WriteLine($"Ожидание поиска: {InputNumbers[ExpectedIndex]}");

                Console.Write("Ожидание удаления:");
                for (int i = 0; i < InputNumbers.Length; i++)
                {
                    if (i != ExpectedIndex)
                    {
                        Console.Write($" {InputNumbers[i]}");
                    }
                }
                Console.Write("\n");


                Console.WriteLine($"Ожидание вставки: {String.Join(" ", InputNumbers)}");
            }
            else
            {
                Console.WriteLine("Ожидание: ошибка");
            }
            Console.WriteLine();


            Console.WriteLine($"Проверка удаления по индексу: {RemoveId}");
            try
            {
                resultList.RemoveNode(RemoveId);
                Console.Write("Результат удаления:");
                resultList.PrintList();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Результат: {e.Message}");
            }

            if (RemoveId < InputNumbers.Length)
            {
                Console.Write("Ожидание удаления:");
                for (int i = 0; i < InputNumbers.Length; i++)
                {
                    if (i != RemoveId)
                    {
                        Console.Write($" {InputNumbers[i]}");
                    }
                }
                Console.Write("\n");
            }
            else
            {
                Console.WriteLine("Ожидание: ошибка");
            }

            Console.WriteLine();
        }
    }


    class TestCaseTest2
    {
        public int[] InputNumbers { get; set; }
        public int Search { get; set; }

        public void exec()
        {
            Console.WriteLine("Бинарный поиск");
            Console.WriteLine($"Список: {String.Join(" ", InputNumbers)}");

            var result = Task2.BinarySearch(InputNumbers, Search);
            var resultExpected = Array.BinarySearch(InputNumbers, Search);
            resultExpected = resultExpected >= 0 ? resultExpected : -1;

            Console.WriteLine($"Поиск: {Search}");
            Console.WriteLine($"Результат: {result}; Ожидание: {resultExpected}");
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TestCaseTask1[] testCaseTask1 =
            {
                new TestCaseTask1
                {
                    InputNumbers = new int[]{324, 23, -3, 12, 56},
                    RemoveId = 2,
                    Find = 12,
                },
                new TestCaseTask1
                {
                    InputNumbers = new int[]{3, 10, 2, 67, 100, 34},
                    RemoveId = 10,
                    Find = 1000,
                },
                new TestCaseTask1
                {
                    InputNumbers = new int[]{3, 10, 2, 67, 100, 34},
                    RemoveId = 0,
                    Find = 1000,
                },
            };

            foreach (var testCase in testCaseTask1)
            {
                testCase.exec();
                Console.WriteLine();
            }

            Console.WriteLine();
            TestCaseTest2[] testCaseTask2 =
            {
                new TestCaseTest2
                {
                    InputNumbers = new int[]{324, 23, -3, 12, 56, 364, 4564, 456, 5686, 456, -10},
                    Search = 4564,
                },
                new TestCaseTest2
                {
                    InputNumbers = new int[]{324, 23, -3, 12, 56, 364, 4564, 456, 5686, 456, -10},
                    Search = 10,
                },
            };

            foreach (var testCase in testCaseTask2)
            {
                testCase.exec();
                Console.WriteLine();
            }
            Console.ReadLine();
        }
                
    }
}
using System;

namespace HW2
{
    public class Task2
    {
        protected static void SortBubble(ref int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        var temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
        }

        public static int BinarySearch(int[] numbers, int search)
        {
            int min = 0;
            int max = numbers.Length;
            if (max == 0)
            {
                return -1;
            }

            SortBubble(ref numbers); // O(N^2)

            while (min <= max) // O(log2(N))
            {
                int mid = min + (max - min) / 2; // защита от переполнения

                if (search == numbers[mid])
                {
                    return mid;
                }

                if (search < numbers[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }

            return -1;
        }
    }
}

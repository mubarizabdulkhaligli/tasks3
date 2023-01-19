using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 56, 89, 76, 550, 976 };

            int max = FindMax(numbers);

            Console.WriteLine(max);
        }


        // Task 5. Verilmis ededler siyahisindaki en boyuk ededi tapan metod

        static int FindMax(int[] nums)
        {
            int max = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i]>max)
                {
                    max = nums[i];
                }
            }
            return max;
        }
    }
}


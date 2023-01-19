using System;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 56, 89, 76, 550, 976 };

            int max = FindMin(numbers);

            Console.WriteLine(max);
        }


        // Task 6. Verilmis ededler siyahisindaki ededlerden en kicik ededi tapan metod

        static int FindMin(int[] nums)
        {
            int min = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }
            return min;
        }
    }
}


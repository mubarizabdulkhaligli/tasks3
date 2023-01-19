using System;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 13, 34, 55, 60, 125 };
            int num1 = 35;

            var check = FindIndex(numbers, num1);
            Console.WriteLine(check);
        }



        // Task 8. Verilmis ededler siyahisinda verilmis ededin yerlesdiyi indexi tapan metod
        // (eger hemin eded siyahida yoxdursa -1 qaytarsin, varsa ilk yerlesiyi indexi)


        static int FindIndex(int[] numbers, int num1)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]==num1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}


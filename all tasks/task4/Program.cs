using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int pow = Convert.ToInt32(Console.ReadLine());

            int quvvet = power(num, pow);
            Console.WriteLine(quvvet);
        }


        // Task 4. Verilmis ededi verilmis quvvete yukselden metod

        static int power(int num, int pow)
        {
            int result = 1;

            for (int i = 0; i < pow; i++)
            {
                result = result * num;
            }
            return result;
        }
    }
}


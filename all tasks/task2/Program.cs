using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            char cr = Convert.ToChar(Console.ReadLine());

            var check = isNumber(cr);
            Console.WriteLine(check);
        }

        // Task 2. Verilmis charin reqem olub olmadigini tapan metod

        static bool isNumber(char cr)
        {
            string str = "0123456789";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == cr)
                {
                    return true;
                }
            }
            return false;
        }
    }
}


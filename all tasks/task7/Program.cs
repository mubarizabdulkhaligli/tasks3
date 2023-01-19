using System;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            char cr = Convert.ToChar(Console.ReadLine());

            int count = counter(word, cr);

            Console.WriteLine(count);
        }


        // Task 7. Verilmis yazida verilmis chardan nece eded oldugunu tapan metod

        static int counter(string word, char c)
        {
            int count = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == c)
                {
                    count++;
                }
            }
            return count;
        }
    }
}


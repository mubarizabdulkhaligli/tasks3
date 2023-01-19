using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            char cr = Convert.ToChar(Console.ReadLine());

            var check = hasWantedChar(word, cr);
            Console.WriteLine(check);
        }


        // Task 3. Verilmis yazida verilmis charin olub-olmadigini tapan metod

        static bool hasWantedChar(string word, char cr)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i]==cr)
                {
                    return true;
                }
            }
            return false;
        }
    }
}


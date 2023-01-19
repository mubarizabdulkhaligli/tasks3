using System;

namespace task10
{
    class Program
    {
         static void Main(string[] args)
        {
            string word = Console.ReadLine();

            var check = HasNumber(word);
            Console.WriteLine(check);
        }

        // Task 10. Verilmis yazida reqem olub olmadigini tapan metod

        static bool HasNumber(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i]>= 48 && word[i]<=57)
                {
                    return true;
                }
            }
            return false;
        }
    }
}


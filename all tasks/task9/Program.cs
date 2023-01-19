using System;

namespace task9
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            var result = Reverse(word);

            Console.WriteLine(result);
        }


        // Task 9. Verilmis yazini eksine ceviren metod

        static string Reverse(string word)
        {
            var result = " ";

            for (int i = word.Length-1; i >= 0; i--)
            {
                result = result + word[i];
            }

            return result;
        }
    }
}


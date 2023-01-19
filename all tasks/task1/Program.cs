using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string surname = Console.ReadLine();

            var FullName = makeFullName(name, surname);
            Console.WriteLine(FullName);
        }


        // Task 1. Make Full Name

        static string makeFullName(string name, string surname)
        {
            var FullName = name + " " + surname;
            return FullName;
        }
    }
}


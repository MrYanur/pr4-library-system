using System;

namespace LibrarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter two integers: ");
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);

            Console.WriteLine($"You entered: {a} and {b}");
            Console.ReadKey(); // чтобы окно не закрывалось сразу
        }
    }
}
using System;

namespace LibrarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter two integers: ");
            string[] input = Console.ReadLine().Split();

            if (input.Length < 2)
            {
                Console.WriteLine("Error: Please enter two numbers separated by space.");
                Console.ReadKey();
                return;
            }

            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);

            Console.WriteLine($"Sum: {a + b}");
            Console.ReadKey();
        }
    }
}
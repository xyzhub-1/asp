using System;

namespace square
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            Console.WriteLine("entrr your name :");
            string name = Console.ReadLine();
            Console.WriteLine("Enter 'quit' to exit the testing loop.");
            while (true)
            {
                Console.Write("Enter a number to square (or 'quit' to exit): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                if (int.TryParse(input, out int number))
                {
                    int result = number * number;
                    Console.WriteLine("The square of " + number + " is " + result + ".");
                }

                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number or 'quit'.");
                }
            }

            Console.WriteLine("\nTesting complete. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
    


using System;

namespace LabTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Pleased to meet you, {name}!");

            string repeat = "Y";

            while (repeat == "Y")
            {
                int number = GetNumber("Please enter a positive integer value between 1 and 100: ");
                if (number % 2 == 0 && number > 60)
                {
                    Console.WriteLine($"{number}: Even.");
                }
                else if (number % 2 == 0 && number >= 26 && number <= 60)
                {
                    Console.WriteLine("Even.");
                }
                else if (number % 2 == 0)
                {
                    Console.WriteLine("Even and less than 25.");
                }
                else if (number > 60)
                {
                    Console.WriteLine($"{number}: Odd.");
                }
                else
                {
                    Console.WriteLine("Odd.");
                }
                repeat = TryAgain($"Would you like to continue, {name}? (Y or N): ");
            }

            Console.WriteLine($"Goodbye, {name}.");
            Console.ReadLine();
        }    

        private static int GetNumber(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            bool success = int.TryParse(input, out int number);
            if (!success || number < 1 || number > 100)
            {
                Console.Write("Invalid entry. ");
                return GetNumber(message);
            }
            return number;
        }

        private static string TryAgain(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine().ToUpper();
            if (input == "Y" || input == "N")
            {
                return input;
            }
            else
            {
                Console.Write("Invalid input. ");
                return TryAgain(message);
            }
        }
    }
}

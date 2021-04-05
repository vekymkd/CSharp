using System;

namespace Substrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string userInput = Console.ReadLine();

            bool isValidNumber = int.TryParse(userInput, out int number);

            if (isValidNumber)
            {
                string result = Substring("Hello from SEDC Code Academy", number);
                Console.WriteLine(result);
                Console.WriteLine($"The number of characters of the new string is {result.Length}");
            }
        }
        static string Substring(string input, int numberOfWords)
        {
            return input.Substring(0, numberOfWords);
        }
    }
}

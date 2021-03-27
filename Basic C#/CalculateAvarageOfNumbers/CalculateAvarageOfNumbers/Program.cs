using System;

namespace CalculateAvarageOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number:");
            string numberOne = Console.ReadLine();

            Console.WriteLine("Please enter the second number:");
            string numberTwo = Console.ReadLine();

            Console.WriteLine("Please enter the third number:");
            string numberThree = Console.ReadLine();

            Console.WriteLine("Please enter the fourth number:");
            string numberFour = Console.ReadLine();

            bool convertNumberOne = int.TryParse(numberOne, out int num1);
            bool convertNumberTwo = int.TryParse(numberTwo, out int num2);
            bool convertNumberThree = int.TryParse(numberThree, out int num3);
            bool convertNumberFour = int.TryParse(numberFour, out int num4);

            if (convertNumberOne && convertNumberTwo && convertNumberThree && convertNumberFour)
            {
                int result = num1 + num2 + num3 + num4;
                Console.WriteLine($"The sum of the imput values is {result}, calculating average...");
                int averageNumber = result / 4;
                Console.WriteLine($"The average value of the numbers {num1}, {num2}, {num3} and {num4} is {averageNumber}");
            }
            else
            {
                Console.WriteLine("Wrong input values, please enter valid numbers!");
            }
        }
    }
}

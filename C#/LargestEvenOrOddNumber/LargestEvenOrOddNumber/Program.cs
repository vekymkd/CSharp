using System;

namespace LargestEvenOrOddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number:");
            string numberOne = Console.ReadLine();

            Console.WriteLine("Please enter the second number:");
            string numberTwo = Console.ReadLine();

            bool converNumberOne = int.TryParse(numberOne, out int num1);
            bool convertNumberTwo = int.TryParse(numberTwo, out int num2);

            if (converNumberOne && convertNumberTwo)
            {
                if (num1 > num2)
                {
                    if (num1 % 2 == 0)
                    {
                        Console.WriteLine($"Number {num1} is greater than the second number and is an even number");
                    }
                    else
                    {
                        Console.WriteLine($"Number {num1} is greater than the second number and is an odd number");
                    }
                }
                else if (num1 == num2)
                {
                    if (num1 % 2 == 0)
                    {
                        Console.WriteLine($"Number {num1} and number {num2} are both equal numbers and they are even numbers");
                    }
                    else
                    {
                        Console.WriteLine($"Number ${num1} and number {num2} are both equal numbers and they are odd numbers");
                    }
                }
                else
                {
                    if (num2 % 2 == 0)
                    {
                        Console.WriteLine($"Number {num2} is greater than the second number and is an even number");
                    }
                    else
                    {
                        Console.WriteLine($"Number {num2} is greater than the second number and is an odd number");
                    }
                }


            }
            else
            {
                Console.WriteLine("Wrong input values, please enter valid values and try again!");
            }
        }
    }
}

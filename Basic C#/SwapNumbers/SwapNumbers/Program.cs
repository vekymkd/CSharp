using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number:");
            string numberOne = Console.ReadLine();

            Console.WriteLine("Please enter second number:");
            string numberTwo = Console.ReadLine();

            bool convertNumberOne = int.TryParse(numberOne, out int num1);
            bool convertNumberTwo = int.TryParse(numberTwo, out int num2);

            if(convertNumberOne && convertNumberTwo)
            {
                int swapNumberOne = num2;
                int swapNumberTwo = num1;

                Console.WriteLine($"Before the swap process num1 = {num1} num2 = {num2}");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine($"After the swap process num1 = {swapNumberOne} num2 = {swapNumberTwo}");
            }
            else
            {
                Console.WriteLine("Wrong inputs, please enter valid numbers!");
            }
        }
    }
}

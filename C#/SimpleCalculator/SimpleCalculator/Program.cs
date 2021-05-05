using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number:");
            string numberOne = Console.ReadLine();

            Console.WriteLine("Please enter second number:");
            string numberTwo = Console.ReadLine();

            Console.WriteLine("Please enter an operator ( + , - , * , / , % ):");
            string selectedOperator = Console.ReadLine();

            bool convertNumberOne = int.TryParse(numberOne, out int num1);
            bool convertNumberTwo = int.TryParse(numberTwo, out int num2);

            if (convertNumberOne && convertNumberTwo)
            {

                switch (selectedOperator)
                {
                    case "+":
                        Console.WriteLine($"The result after the following calculation is: {num1} + {num2} = {num1 + num2}");
                        break;
                    case "-":
                        Console.WriteLine($"The result after the following calculation is: {num1} - {num2} = {num1 - num2}");
                        break;
                    case "*":
                        Console.WriteLine($"The result after the following calculation is: {num1} * {num2} = {num1 * num2}");
                        break;
                    case "/":
                        Console.WriteLine($"The result after the following calculation is: {num1} / {num2} = {num1 / num2}");
                        break;
                    case "%":
                        Console.WriteLine($"The result after the following calculation is: {num1} % {num2} = {num1 % num2}");
                        break;
                    default:
                        Console.WriteLine("Wrong or none operator has been selected, please select an operator to perform a calculation!");
                        break;
                }

            }
            else
            {
                Console.WriteLine("Wrong input values, please enter correct input values and try again!");
            }
        }
    }
}

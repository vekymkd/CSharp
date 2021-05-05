using System;

namespace SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integerArray = new int[6];
            int sum = 0;

            for (int i = 0; i < integerArray.Length; i++)
            {
                Console.Write("Enter integer: "); string numberInput = Console.ReadLine();
                bool conversionToNumber = int.TryParse(numberInput, out int num);

                if (!conversionToNumber)
                {
                    i--;
                    continue;
                }

                integerArray[i] = num;
            }

            foreach (int number in integerArray)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
            }

            Console.WriteLine($"The result is: {sum}.");
        }
    }
}

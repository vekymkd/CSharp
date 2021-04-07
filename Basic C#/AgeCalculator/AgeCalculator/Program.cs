using System;

namespace AgeCalculator
{
    class Program
    {
        static int AgeCalculator(string dateOfBirth)
        {
            bool parseDate = DateTime.TryParse(dateOfBirth, out DateTime dob);

            if (parseDate)
            {
                int age = (DateTime.Now.Year - dob.Year) - 1;

                int month = dob.Month;
                int day = dob.Day;

                int currentMonth = DateTime.Now.Month;
                int currentDay = DateTime.Now.Day;

                if (currentMonth > month)
                {
                    age++;
                }
                else if (currentMonth == month && currentDay > day)
                {
                    age++;
                }
                return age;
            }
            else
            {
                Console.WriteLine("Wrong input value, please enter correct values!");
            }
            return 0;
        }
            static void Main(string[] args)
            {
                Console.WriteLine("Enter your date of birth: ex. 01/01/2001 ");
                string birthday = Console.ReadLine();

                if (AgeCalculator(birthday) != 0)
                Console.WriteLine($"You are {AgeCalculator(birthday)} years old");
                
            }
    }
}

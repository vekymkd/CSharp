using System;

namespace StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {

                string[] studentsG1 = new string[] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
                string[] studentsG2 = new string[] { "Velimir", "Slave", "Aleksandar", "Goran", "Vlatko" };

                Console.WriteLine("Press 1 for Group 1, press 2 for Group 2"); string selectedGroup = Console.ReadLine();

                if (selectedGroup == "1")
                {
                    Console.WriteLine("The students of Group 1 are: ");
                    foreach (string student in studentsG1)
                    {
                        Console.WriteLine(student);
                    }
                }
                else if (selectedGroup == "2")
                {
                    Console.WriteLine("The students of Group 2 are: ");
                    foreach (string student in studentsG2)
                    {
                        Console.WriteLine(student);
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input value, please try again!");
                }

            }
        }
    }
}

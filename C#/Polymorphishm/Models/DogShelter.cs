using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public static class DogShelter
    {
        public static List<Dog> Dogs { get; set; }

        static DogShelter()
        {
            Dogs = new List<Dog>
            {
                new Dog(1, "Lucy", "Yellow"),
                new Dog(2, "Aron", "Gray"),
                new Dog(3, "Jerry Lee", "Black")
            };
        }

        public static string PrintAll()
        {
            if (Dogs.Count == 0)
            {
                Console.WriteLine("No dogs to be found!");
            }

            string names = "";
            int count = 1;

            foreach (Dog dog in Dogs)
            {
                names += $"{count}. {dog.Name}";
                count++;
            }

            return names;
        }
    }
}
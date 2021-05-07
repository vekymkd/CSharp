using Models;
using System;
using System.Collections.Generic;

namespace Polymorphishm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>
            {
                new Dog(1, "Lessi", "Brown"),
                new Dog(5, "Bak", "White"),
                new Dog(-2, "Rex", "Yellow"),
                new Dog(4, "Badi", "Black"),
            };

            foreach (Dog dog in dogs)
            {
                if (Dog.Validate(dog))
                {
                    DogShelter.Dogs.Add(dog);
                }
                else
                {
                    Console.WriteLine("No dogs to add!");
                }
            }

            Console.WriteLine(DogShelter.PrintAll());
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Dog : Pet
    {
        public bool GoodBoi { get; set; }
        public string FavoriteFood { get; set; }
        public override void PrintInfo()
        {
            Console.WriteLine($"Favourite food of {Name} is {FavoriteFood}");
        }
    }
}
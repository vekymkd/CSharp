using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public string Size { get; set; }
        public override void PrintInfo()
        {
            Console.WriteLine($"Color and size of the fish are: {Color} and  {Size}");
        }
    }
}

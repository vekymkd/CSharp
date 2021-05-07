using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Dog
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public Dog(int id, string name, string color)
        {
            Id = id;
            Name = name;
            Color = color;
        }
        
        public static bool Validate(Dog dog)
        {
            if (dog.Id == 0 || dog.Name == null || dog.Color == null)
            {
                return false;
            }

            if (dog.Id < 0)
            {
                return false;
            }

            if (dog.Name.Length < 2)
            {
                return false;
            }

            return true;
        }

        public string Bark()
        {
            return $"Woof,wooof,bark,bark";
        }
    }
}

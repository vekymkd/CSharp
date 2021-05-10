using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Models
{
    public class PetStore<T> where T : Pet
    {
        private List<T> Base { get; set; }

        public PetStore()
        {
            Base = new List<T>();
        }

        public void Insert(T item)
        {
            Base.Add(item);
            Console.WriteLine("Pet added into database!");
        }

        public void PrintPets()
        {
            foreach (T animal in Base)
            {
                animal.PrintInfo();
            }
        }

        public void BuyPet(string name)
        {
            T pet = Base.FirstOrDefault(x => x.Name == name);
            if (pet == null)
            {
                Console.WriteLine("The wanted pet does not exist.");
                return;
            }
            Base.Remove(pet);
            Console.WriteLine("Congrats! You have bought a pet!");
        }
    }
}

using System;
using Models;

namespace Generics
{
    class Program
    {
        public static PetStore<Dog> DogStore = new PetStore<Dog>();
        public static PetStore<Cat> CatStore = new PetStore<Cat>();
        public static PetStore<Fish> FishStore = new PetStore<Fish>();
        static void Main(string[] args)
        {
            DogStore.Insert(new Dog() { Name = "Rex", Age = 5, Type = "german sheperd", GoodBoi = true, FavoriteFood = "Meat" });
            DogStore.Insert(new Dog() { Name = "Bak", Age = 2, Type = "husky", GoodBoi = false, FavoriteFood = "Vegetables" });
            DogStore.PrintPets();

            DogStore.BuyPet("Bak");
            CatStore.BuyPet("Test");
            DogStore.PrintPets();

            CatStore.Insert(new Cat() { Name = "Garefield", Age = 2, Type = "domestic", Lazy = true, LivesLeft = 6 });
            CatStore.Insert(new Cat() { Name = "Tom", Age = 12, Type = "wild", Lazy = false, LivesLeft = 1 });
            CatStore.PrintPets();

            CatStore.BuyPet("Tom");
            CatStore.BuyPet("Simba");
            CatStore.PrintPets();

            FishStore.Insert(new Fish() { Name = "Nemo", Age = 2, Type = "clown fish", Color = "Orange", Size = "xs" });
            FishStore.Insert(new Fish() { Name = "Sharky", Age = 12, Type = "shark", Color = "White", Size = "xxl" });
            FishStore.PrintPets();

            FishStore.BuyPet("Nemo");
            FishStore.BuyPet("Sharky");
            FishStore.PrintPets();

            Console.ReadLine();
        }
    }
}

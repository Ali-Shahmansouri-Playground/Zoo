using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Zoo.Animals;
using Zoo.Animals.Interfaces;

namespace Zoo
{
    public sealed class MyZoo
    {
        private readonly List<Animal> animals;

        public MyZoo()
        {
            animals = new List<Animal>();
        }

        public void AddAnimal(Animal[] args)
        {
            foreach (var animal in args)
            {
                animals.Add(animal);
            }
        }

        public void GetAnimalDetails()
        {
            Console.WriteLine("Animals in this zoo are: ");
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.GetType().Name);
            }

        }

        public void GetAdoptableAnimals()
        {
            Console.WriteLine("\nAnd you can adopt: ");

            var type = typeof(IPet);
            var t = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p)).ToArray();
            for (int i = 0; i < t.Length - 1; i++)
            {
                Console.WriteLine(t[i].Name);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Animals;

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
            //TODO: Implement
        }
    }
}

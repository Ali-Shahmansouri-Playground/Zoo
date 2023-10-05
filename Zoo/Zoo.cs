using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Animals;

namespace Zoo
{
    public sealed class Zoo
    {
        private readonly List<Animal> animals;

        public Zoo()
        {
            animals = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public void GetAnimalDetails()
        {
            //TODO: Implement
        }
    }
}

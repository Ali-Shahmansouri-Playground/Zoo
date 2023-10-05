using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Animals.Interfaces;

namespace Zoo.Animals
{
    public sealed class Crocodile : Animal, ISwimmable, IWalkable, IWild
    {
        public Crocodile(DateTime dateOfBirth) : base(dateOfBirth)
        {
        }

        public void Hunt(Animal animal)
        {
            Console.WriteLine($"Crocodile is to tried of hunting a {animal.Age.Days / 365} years old animal. Let him rest now :D");
        }

        public void Swim()
        {
            Console.WriteLine("Crocodile swims... fish fish fish");
        }

        public void Walk()
        {
            Console.WriteLine("Crocodile tries his best to walk. Slowly, but surely :)) ");
        }
    }
}

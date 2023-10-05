using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Animals.Interfaces;

namespace Zoo.Animals
{
    public sealed class Lion : Animal, IWild, IWalkable
    {
        public Lion(DateTime dateOfBirth) : base(dateOfBirth)
        {
        }

        public void Hunt(Animal animal)
        {
            Console.WriteLine($"Lion hunted a {animal.Age.Days / 365} years old animal");
        }

        public void Walk()
        {
            Console.WriteLine("Lion walks");
        }
    }
}

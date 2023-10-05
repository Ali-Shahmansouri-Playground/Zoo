using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Animals.Interfaces;

namespace Zoo.Animals
{
    public sealed class Fish : Animal, ISwimmable
    {
        public Fish(DateTime dateOfBirth) : base(dateOfBirth)
        {
        }

        public void Swim()
        {
            Console.WriteLine("The Fishy swims hooooo");
        }
    }
}

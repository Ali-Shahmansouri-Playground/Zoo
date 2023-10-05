using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Animals.Interfaces;

namespace Zoo.Animals
{
    public sealed class Cat : Animal, IWalkable, IPet
    {
        public Cat(DateTime dateOfBirth) : base(dateOfBirth) { }

        public void Eat()
        {
            Console.WriteLine("Cat eats meat.");
        }

        public void Play()
        {
            Console.WriteLine("Cat plays with Sisalbals");
        }

        public void Walk()
        {
            Console.WriteLine("Cat walks");
        }
    }
}

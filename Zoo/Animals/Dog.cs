using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Animals.Interfaces;

namespace Zoo.Animals
{
    public sealed class Dog : Animal, IPet, IWalkable
    {
        public Dog(DateTime dateOfBirth) : base(dateOfBirth)
        {
        }

        public void Eat()
        {
            Console.WriteLine("The Dog almost east anything ...");
        }

        public void Play()
        {
            Console.WriteLine("MR.Doggy loves to play catch ...");
        }

        public void Walk()
        {
            Console.WriteLine("Walk Walk Walk");
        }
    }
}

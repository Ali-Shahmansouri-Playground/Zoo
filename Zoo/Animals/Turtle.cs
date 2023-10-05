using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Animals.Interfaces;

namespace Zoo.Animals
{
    public sealed class Turtle : Animal, ISwimmable, IWalkable
    {
        public Turtle(DateTime dateOfBirth) : base(dateOfBirth)
        {
        }

        public void Swim()
        {
            Console.WriteLine("Mr.Turtule swims like it's his last day.");
        }

        public void Walk()
        {
            Console.WriteLine("Turtle Walks");
        }
    }
}

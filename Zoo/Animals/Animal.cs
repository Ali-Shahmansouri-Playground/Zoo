using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Animals
{
    public abstract class Animal
    {
        private readonly DateTime dateOfBirth;

        public Animal(DateTime dateOfBirth)
        {
            this.dateOfBirth = dateOfBirth;
        }

        public TimeSpan Age
        {
            get
            {
                return DateTime.Today - dateOfBirth;
            }
        }

        public static implicit operator Animal(List<Animal> v)
        {
            throw new NotImplementedException();
        }
    }
}

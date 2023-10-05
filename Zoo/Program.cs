using Zoo;
using Zoo.Animals;

var myZoo = new MyZoo();


myZoo.AddAnimal(new Animal[]
{
 new Cat(new DateTime(2000, 1, 2)),
 new Crocodile(new DateTime(2001, 2, 3)),
 new Fish(new DateTime(2002, 3, 4)),
 new Lion(new DateTime(2003, 5, 6)),
 new Turtle(new DateTime(2004, 6, 7)),
 new Dog(new DateTime(2005, 7, 8)),
}); ;

myZoo.GetAnimalDetails();

myZoo.GetAdoptableAnimals();
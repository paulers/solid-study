/*
 *  Dependency Inversion Principle
 *  "Higher level modules should not depend on lower level modules. Both should depend on abstractions.
 *  Abstractions should not depend on details, but details should depend on on abstractions."
 */

using System;

namespace SolidStudy.DependencyInversionPrinciple
{
    public interface IAnimal
    {
        string MakeSound(string aSound);
    }
    public class Duck : IAnimal
    {
        public string MakeSound(string aSound)
        {
            return "Duck says " + aSound + "!";
        }
    }

    public class Dog : IAnimal
    {
        public string MakeSound(string aSound)
        {
            return "Dog says " + aSound + "!";
        }
    }

    public class Cat : IAnimal
    {
        public string MakeSound(string aSound)
        {
            return "Cat says " + aSound + "!";
        }
    }

    public class AnimalSoundMaker
    {
        public string MakeSound(IAnimal animal, string sound)
        {
            return animal.MakeSound(sound);
        }
    }
}

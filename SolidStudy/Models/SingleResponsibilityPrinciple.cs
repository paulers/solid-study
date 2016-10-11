/*
 *  Single Responsibility Principle
 *  "There should never be more than one reason for a class to change."
 *  Each class should only be responsible for relevant methods and properties
 */

namespace SolidStudy.SingleResponsibilityPrinciple
{
    public class Animal
    {
        public Dog _dog { get; set; }
        public Cat _cat { get; set; }

        public Animal(Dog dog, Cat cat)
        {
            _dog = dog;
            _cat = cat;
        }

        public string MakeSounds()
        {
            return "Dog says " + _dog.Sound + " and cat says " + _cat.Sound;
        }
    }

    public class Cat
    {
        public string Sound = "Meow";
    }

    public class Dog
    {
        public string Sound = "Woof";
    }
}

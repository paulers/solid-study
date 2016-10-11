/*
 *  Open Closed Principle
 *  "Entities should be open for extension, but closed for modification."
 *  Once tested and working, classes, methods and other entities should only be adjusted to correct bugs.
 *  If they need to be changed, they should be extended instead.
 */

namespace SolidStudy.OpenClosedPrinciple
{
    public abstract class Animal
    {
        public abstract string MakeSound();
    }
    public class Cat : Animal
    {
        public string Sound = "Meow";
        public override string MakeSound()
        {
            return "The cat meows: " + Sound;
        }
    }

    public class Dog : Animal
    {
        public string Sound = "Woof";
        public override string MakeSound()
        {
            return "The dog barks: " + Sound;
        }
    }
}

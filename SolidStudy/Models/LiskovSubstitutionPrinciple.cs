/*
 *  Liskov Substitution Principle
 *  "Child class should be able to substitute the class it inherits from without conflict."
 */

namespace SolidStudy.LiskovSubstitutionPrinciple
{
    public interface Aerial
    {
        void Fly();
    }

    public interface Aquatic
    {
        void Swim();
    }

    public interface Terrestrial
    {
        void Run();
    }

    public class Cheetah : Terrestrial, Aquatic
    {
        public void Run()
        {
            // ... code to make cheetah run
        }

        public void Swim()
        {
            // ... code to make cheetah swim
        }
    }

    public class Duck : Aquatic, Aerial
    {
        public void Fly()
        {
            // ... code to make duck fly
        }

        public void Swim()
        {
            // ... code to make duck swim
        }
    }

    public class Colibri : Aerial
    {
        public void Fly()
        {
            // ... code to make colibri fly
        }
    }

    public class Animal
    {
        public void Fly(Aerial animal)
        {
            animal.Fly();
        }

        public void Run(Terrestrial animal)
        {
            animal.Run();
        }

        public void Swim(Aquatic animal)
        {
            animal.Swim();
        }
    }
}

/*
 *  Interface Segregation Principle
 *  "Classes implement an interface should not be forced to depend on interfaces they can't use."
 */

namespace SolidStudy.InterfaceSegregationPrinciple
{
    public interface IPup
    {
        void AskForFood();
    }

    public interface IDenMother
    {
        void FeedPups();
        void DefendDen();
    }

    public interface IAlphaWolf
    {
        void HuntForFood();
    }

    public class Pup : IPup
    {
        public void AskForFood()
        {
            // ... pups ask for food, and also play with other pups!
        }
    }

    public class DenMother : IDenMother
    {
        public void FeedPups()
        {
            // ... den mother can feed pups
        }

        public void DefendDen()
        {
            // ... den mother also defends the den when the Alpha is out hunting
        }
    }

    public class AlphaWolf : IAlphaWolf, IDenMother
    {
        public void DefendDen()
        {
            // ... When Alpha is home, he can defend the den!
        }

        public void FeedPups()
        {
            // ... Alpha wolf can also feed the pups, right?
        }

        public void HuntForFood()
        {
            // ... Alpha wolf is responsible for hunting for food
        }
    }
}

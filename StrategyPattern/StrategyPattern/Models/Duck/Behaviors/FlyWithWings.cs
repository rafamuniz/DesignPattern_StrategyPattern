using System;

namespace StrategyPattern.Models.Duck
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying");
        }
    }
}

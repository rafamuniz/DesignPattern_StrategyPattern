using System;

namespace StrategyPattern.Models.Duck
{
    public class Squeak : IQuackBehavior
    {
        public void QuackSound()
        {
            Console.WriteLine("Squeak Squeak Squeak");
        }
    }
}

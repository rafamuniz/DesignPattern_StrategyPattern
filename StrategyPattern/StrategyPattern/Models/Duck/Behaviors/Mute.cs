using System;

namespace StrategyPattern.Models.Duck
{
    public class Mute : IQuackBehavior
    {
        public void QuackSound()
        {
            Console.WriteLine("No Quack");
        }
    }
}

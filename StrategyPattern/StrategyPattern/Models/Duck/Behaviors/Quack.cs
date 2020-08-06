using System;

namespace StrategyPattern.Models.Duck
{
    public class Quack : IQuackBehavior
    {
        public void QuackSound()
        {
            Console.WriteLine("Quack Quack Quack");         
        }
    }
}

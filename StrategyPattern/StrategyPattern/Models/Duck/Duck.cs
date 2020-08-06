using System;

namespace StrategyPattern.Models.Duck
{
    public abstract class Duck
    {
        private IFlyBehavior flyBehavior;
        private IQuackBehavior quackBehavior;

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

        public virtual void Display()
        {

        }

        public void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            this.flyBehavior = flyBehavior;
        }

        public void SetQuackBehavior(IQuackBehavior quackBehavior)
        {
            this.quackBehavior = quackBehavior;
        }

        public void PerformQuack()
        {
            quackBehavior.QuackSound();
        }

        public void PerformFly()
        {
            flyBehavior.Fly();
        }
    }
}

using System;

namespace StrategyPattern.Models.Duck
{
    public class MallardDuck : Duck, IDuckDisplay
    {
        public MallardDuck()
        {
            this.SetQuackBehavior(new Quack());
            this.SetFlyBehavior(new FlyWithWings());
        }

        public override void Display()
        {
            Console.WriteLine("Mallard Duck");
        }
    }
}

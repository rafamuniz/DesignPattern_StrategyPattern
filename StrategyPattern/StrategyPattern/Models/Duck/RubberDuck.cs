using System;

namespace StrategyPattern.Models.Duck
{
    public class RubberDuck : Duck, IDuckDisplay
    {
        public RubberDuck()
        {
            this.SetQuackBehavior(new Squeak());
            this.SetFlyBehavior(new FlyNoWay());
        }

        public override void Display()
        {
            Console.WriteLine("Rubber Duck");
        }
    }
}

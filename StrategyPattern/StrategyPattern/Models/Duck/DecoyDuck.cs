using System;

namespace StrategyPattern.Models.Duck
{
    public class DecoyDuck : Duck, IDuckDisplay
    {
        public DecoyDuck()
        {
            this.SetQuackBehavior(new Quack());
            this.SetFlyBehavior(new FlyNoWay());
        }

        public override void Display()
        {
            Console.WriteLine("Decoy Duck");
        }
    }
}

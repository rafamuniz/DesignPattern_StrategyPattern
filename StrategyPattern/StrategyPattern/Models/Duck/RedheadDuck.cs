using System;

namespace StrategyPattern.Models.Duck
{
    public class RedheadDuck : Duck, IDuckDisplay
    {
        public RedheadDuck()
        {
            this.SetQuackBehavior(new Quack());
            this.SetFlyBehavior(new FlyWithWings());
        }

        public override void Display()
        {
            Console.WriteLine("Redhead Duck");
        }
    }
}

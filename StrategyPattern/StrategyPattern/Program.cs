using StrategyPattern.Models.Duck;
using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var mallardDuck = new MallardDuck();
            mallardDuck.Display();
            mallardDuck.PerformQuack();
            mallardDuck.PerformFly();

            Console.WriteLine();
            var redheadDuck = new RedheadDuck();
            redheadDuck.Display();
            redheadDuck.PerformQuack();
            redheadDuck.PerformFly();

            Console.WriteLine();
            var rubberDuck = new RubberDuck();
            rubberDuck.Display();
            rubberDuck.PerformQuack();
            rubberDuck.PerformFly();

            Console.WriteLine();
            var decoyDuck = new DecoyDuck();
            decoyDuck.Display();
            decoyDuck.PerformQuack();
            decoyDuck.PerformFly();

            Console.ReadKey();
        }
    }
}

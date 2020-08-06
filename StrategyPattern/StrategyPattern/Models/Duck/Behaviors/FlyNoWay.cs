﻿using System;

namespace StrategyPattern.Models.Duck
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I cannot fly");
        }
    }
}

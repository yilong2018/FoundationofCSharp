﻿using System;

namespace M06L07MethodOverridingDemo
{
    public class Tesla : Car
    {
        public override void StartCar()
        {
            Console.WriteLine("Think about your destinatin");
        }
        public override void SetClock()
        {
            Console.WriteLine("It sets itself");
        }
    }

}

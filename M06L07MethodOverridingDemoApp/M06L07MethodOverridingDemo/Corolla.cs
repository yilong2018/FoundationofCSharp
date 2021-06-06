using System;

namespace M06L07MethodOverridingDemo
{
    public class Corolla : Car
    {
        public override void SetClock()
        {
            Console.WriteLine("FIddle with the Corolla Clock") ;
        }
    }

}

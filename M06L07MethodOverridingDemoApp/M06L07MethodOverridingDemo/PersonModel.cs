﻿namespace M06L07MethodOverridingDemo
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public override string ToString()
        {
            return $"{ FirstName } { LastName }";
        }
    }
}

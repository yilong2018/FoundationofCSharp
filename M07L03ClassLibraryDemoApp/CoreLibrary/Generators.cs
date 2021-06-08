﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CoreLibrary
{
    public class Generators
    {
        public string WelcomeMessage(string prefix, string lastName)
        {
            return $"Welcome to our demo application { prefix } { lastName }";
        }

        public string FarewellMessage(string prefix, string lastName)
        {
            return $"I hope you enjoy your time with us { prefix } { lastName }. Please come back soon.";
        }
    }
}

﻿using System;

namespace M03L02Breakpints
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"The value of i is {i}");
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine($"The value of j is {j}");
                }
            }
            Console.ReadLine();
        }
    }
}

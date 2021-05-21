using System;

namespace M03L02Breakpints
{
  class Program
  {
    static void Main(string[] args)
    {
      // for (int i = 0; i < 20; i++)
      // {
      //     Console.WriteLine($"The value of i is {i}");
      //     for (int j = 0; j < 10; j++)
      //     {
      //         Console.WriteLine($"The value of j is {j}");
      //     }
      // }

      // Homework
      // Create a Console Application with a for loop that multiplies a number by five and adds it to the total each time. Step through the code.

      int total = 0;
      for (int i = 0; i < 100; i += 5)
      {
        total += i;
        Console.WriteLine($"i is {i}, total is {total}");

      }
      Console.ReadLine();
    }
  }
}

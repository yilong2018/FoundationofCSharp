using System;

namespace M03L05AdvancedBreakpoints
{
  class Program
  {
    static void Main(string[] args)
    {
      //   RunsAlog();

      //Home work
      // Create a Console Application that loops from 1 to 100. Throw an exception on 73. Use breakpoint to break before the breaking situation.
      try
      {
        for (int i = 1; i < 101; i++)
        {
          if (i == 73)
          {
            throw new FormatException("User error, the i is 73.");
          }
        }
      }
      catch (System.Exception ex)
      {

        Console.WriteLine(ex.Message);
      }


      Console.ReadLine();
    }
    private static void RunsAlog()
    {
      long total = 0;
      int test = 0;
      for (int i = -1000; i <= 1000; i++)
      {
        total += i;
        try
        {
          test = 5 / i;
        }
        catch
        {
          System.Console.WriteLine("There was an exception.");
        }
      }
      Console.WriteLine($"The total is {total}");
    }
  }
}

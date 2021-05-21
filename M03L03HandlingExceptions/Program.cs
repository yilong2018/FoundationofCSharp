using System;

namespace M03L03HandlingExceptions
{
  class Program
  {
    static void Main(string[] args)
    {
      //   try
      //   {
      //     BadCall();
      //   }
      //   catch (System.Exception ex)
      //   {
      //     Console.WriteLine("There was an exception thrown in our app");
      //     Console.WriteLine(ex.Message);
      //   }

      //Homework
      // Create a Console Application with a for loop that throws and exception after five iterations. Catch the exception.
      string[] firstNames = new string[] { "Bob", "Sue", "Tim", "Ken", "John" };
      try
      {
        for (int i = 0; i <= firstNames.Length; i++)
        {
          Console.WriteLine($"Hello { firstNames[i] }");
        }
      }
      catch (System.Exception ex)
      {
        Console.WriteLine("We had some error in ForLoop");
        System.Console.WriteLine(ex.Message);
      }

      Console.ReadLine();
    }
    // private static void BadCall()
    // {
    //   int[] ages = new int[] { 1, 3, 5 };
    //   for (int i = 0; i <= ages.Length; i++)
    //   {
    //     try
    //     {
    //       Console.WriteLine(ages[i]);
    //     }
    //     catch (System.Exception ex)
    //     {
    //       throw new Exception("There was an error handling our array", ex);
    //     }
    //   }
    // }
  }
}

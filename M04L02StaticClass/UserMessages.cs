using System;

namespace M04L02StaticClass
{
  public class UserMessages
  {
    public static void PrintResultMessage(string message)
    {
      Console.WriteLine(message);
      Console.WriteLine();
      Console.WriteLine("Thank you for using our app to calculate for you.");
    }
    public static void ApplicationStartMessage(string firstName)
    {
      System.Console.WriteLine("Welcome to the static class Demo App.");

      int hourOfDay = DateTime.Now.Hour;
      if (hourOfDay < 12)
      {
        Console.WriteLine($"Good Morning, {firstName}!");
      }
      else if (hourOfDay < 19)
      {
        Console.WriteLine($"Good afternoon, {firstName}!");
      }
      else
      {
        Console.WriteLine($"Good night, {firstName}!");
      }
    }
  }
}
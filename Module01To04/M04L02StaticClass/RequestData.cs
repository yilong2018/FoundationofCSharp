using System;

namespace M04L02StaticClass
{
  public class RequestData
  {
    public static string GetAString(string message)
    {
      Console.Write(message);
      string output = Console.ReadLine();
      return output;
    }
    public static double GetDouble(string message)
    {
      Console.Write(message);
      string numberText = Console.ReadLine();
      double output;

      bool isValidDouble = double.TryParse(numberText, out output);
      while (isValidDouble == false)
      {
        Console.WriteLine("That was not a valid number, please try again.");
        Console.Write(message);
        numberText = Console.ReadLine();
        isValidDouble = double.TryParse(numberText, out output);
      }
      return output;
    }
  }
}
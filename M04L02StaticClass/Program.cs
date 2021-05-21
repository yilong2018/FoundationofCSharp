using System;

namespace M04L02StaticClass
{
  class Program
  {
    static void Main(string[] args)
    {
      CalculateData.myAge = 4;
      string firstName = RequestData.GetAString("What is your first name: ");
      UserMessages.ApplicationStartMessage(firstName);

      double x = RequestData.GetDouble("Please enter your first number: ");
      double y = RequestData.GetDouble("Please enter your second number: ");

      double result = CalculateData.Add(x, y);
      UserMessages.PrintResultMessage($"The sum of {x} and {y} is {result}");

      Console.ReadLine();
    }

  }
}

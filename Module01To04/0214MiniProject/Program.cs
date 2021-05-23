using System;

namespace _0214MiniProject
{
  class Program
  {
    static void Main(string[] args)
    {
      //Plan and build a Console application that ask a user for their name and their age. If their name is Bob or Sue, address them as professor. If the person is under 21, recommend they wait X years to start this class.
      // Ask for the user's first name.
      // Ask the user for their age(numeric value)
      // Convert agetText to age(string to int)
      // if name == Bob || name == Sue, formattedName = Professor {name}
      // else formattedName = { name }
      // 
      // if age < 21, i reccomend you wait {21-age} years to start this class { formattedName }
      // else, welcome to class { formattedName }


      // Ask for the user's first name.
      Console.Write("What is your first name?  ");
      string firstName = Console.ReadLine();
      // Ask the user for their age(numeric value)
      Console.Write("What is your age? ");
      string ageText = Console.ReadLine();
      // Convert agetText to age(string to int)
      bool isValidAge = int.TryParse(ageText, out int age);
      if (isValidAge == false)
      {
        Console.WriteLine("This is not a valid age.");
        Console.ReadLine();
        return;
      }
      // if name == Bob || name == Sue, formattedName = Professor {name}
      string formattedName = "";
      if (firstName.ToLower() == "bob" || firstName.ToLower() == "sue")
      {
        formattedName = $"Professor { firstName }";
        // Console.WriteLine(formattedName);
      }
      // else formattedName = { name }
      else
      {
        formattedName = firstName;
      }
      // if age < 21, i reccomend you wait {21-age} years to start this class { formattedName }
      // else, welcome to class { formattedName }
      if (age < 21)
      {
        Console.WriteLine($"I recommend you wait {21 - age} year(s) to start this class, {formattedName}.");
      }
      else
      {
        Console.WriteLine($"Welcome to class {formattedName}.");
      }
      Console.ReadLine();
    }
  }
}

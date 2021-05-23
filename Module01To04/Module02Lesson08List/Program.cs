using System;
using System.Collections.Generic;

namespace Module02Lesson08List
{
  class Program
  {
    static void Main(string[] args)
    {
      // List<string> firstNames = new List<string>();
      // firstNames.Add("Tim");
      // firstNames.Add("Sue");
      // firstNames.Add("Bob");

      // Console.WriteLine($"The second element is { firstNames[1] }");

      // firstNames.Remove("Sue");
      // Console.WriteLine($"The second element is { firstNames[1] }");

      // firstNames[1] = firstNames[1].ToUpper();
      // Console.WriteLine($"The second element is { firstNames[1] }");

      // Homework
      // Add students to a class roster until there are no more students. Then print out the count of the sutdents to the Console.

      int studentsCount = 0;
      string studentName = "";
      string quitInput = "";
      List<string> roster = new List<string>();
      //add students to roster
      while (quitInput.ToUpper() != "NO")
      {
        System.Console.Write("Input a student name: ");
        studentName = Console.ReadLine();
        roster.Add(studentName);
        studentsCount++;
        System.Console.Write("Do you want add mrore student? [yes/no]: ");
        quitInput = Console.ReadLine();
      }

      // print count of students
      System.Console.WriteLine($"We have { studentsCount } students in roster.");
      Console.ReadLine();
    }
  }
}

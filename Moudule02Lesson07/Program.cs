using System;

namespace Moudule02Lesson07
{
    class Program
    {
        // Mainapp.exe /p /r /t /text /23 /34
        static void Main(string[] args)
        {
            // string[] firstNames = new string[5]; // 0, 1, 2, 3, 4

            // firstNames[0] = "Tim";
            // firstNames[1] = "Sue";
            // firstNames[2] = "Bod";
            // firstNames[4] = "Carl";

            // System.Console.WriteLine($"My array has {firstNames[0]}, {firstNames[1]}, {firstNames[2]}, {firstNames[4]}.");

            // string data = "Tim,Sue,Bob,Frank,Sandra,Molly";
            // string[] firstNames = data.Split(',');

            // Console.WriteLine($"The third first name is { firstNames[2] }.");
            // Console.WriteLine($"The third first name is { firstNames[6] }.");

            // int[] ages = new int[3];
            // ages[0] = 4;
            // ages[1] = 5;
            // ages[2] = 54;

            // string[] lastNames = new string[]{ "Corey,", "Smith", "Jones" };

            // lastNames[1] = "Malcome";


            // Homework, Create an array of 3 names. Ask the user which number to select. When the user gives you a number, return that name.
            string[] userNames = new string[] { "Bob", "Sue", "Smith"};
            Console.WriteLine("We have three names, pick up one using number:")

            Console.ReadLine();
        }
    }
}

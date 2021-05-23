using System;

namespace Module02Lesson12Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // SayAuthor();

            // WelcomeUser("Bob");
            // string firstName = GetUsersName("What is your first name: ");
            // string lastName = GetUsersName("What is your last name: ");

            // WelcomeUser(firstName, lastName);


            //Home work
            // Craete a welcome method, a method to ask for the user's name, and another to tell that user " Hello __"
            string userName = GetUsersName();
            SayHello(userName);
            
            Console.ReadLine();

        }
        private static string GetUsersName(){
            System.Console.Write("What's your name? ");
            string output = Console.ReadLine();
            return output;
        }
        private static void SayHello(string userName){
            Console.WriteLine($"Hello {userName}.");
        }

        // private static void SayAuthor()
        // {
        //     Console.WriteLine("************************");
        //     Console.WriteLine("Writen by: Yi Long");
        //     Console.WriteLine("for the Foundation in C# course. ");
        //     Console.WriteLine("************************");
        // }
        // private static void WelcomeUser(string firstName, string lastName)
        // {
        //     System.Console.WriteLine($"Hello { firstName } { lastName }.");
        // }
        // private static string GetUsersName(string message)
        // {
        //     Console.Write(message);
        //     string output = Console.ReadLine();
        //     return output;

        // }

    }
}

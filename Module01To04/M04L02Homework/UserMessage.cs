using System;

namespace M04L02Homework
{
    public class UserMessage{
        public static void Appload(){
            System.Console.WriteLine($"Welcome to Homework App.");
            string lastName = RequestData.GetString("What's your name: ");
            int hour = DateTime.Now.Hour;
            if ( hour < 12 )
            {
                Console.WriteLine($"Good Morning, {lastName}");
            }else if ( hour < 17 )
            {
                System.Console.WriteLine($"Good Afternoon, {lastName} ");
            }else{
                System.Console.WriteLine($"Good Night, {lastName}");
            }

        }
        public static void PrintResult(string message){
            Console.WriteLine(message);
        }
    }
}
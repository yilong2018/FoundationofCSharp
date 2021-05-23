using System;

namespace M04L02Homework
{
    public class RequestData{
        public static string GetString(string message){
            Console.Write(message);
            string output = Console.ReadLine();
            return output;
        }
        public static double GetDouble(string message){
            string numberText = "";
            double number = 0;
            bool isValidDouble = true;
            do
            {
                Console.Write(message);
                numberText = Console.ReadLine();
                isValidDouble = double.TryParse(numberText, out number);
            } while (isValidDouble == false);
            return number;
        }
    }
}
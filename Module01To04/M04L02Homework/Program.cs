using System;

namespace M04L02Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            UserMessage.Appload();
            double x = RequestData.GetDouble("Input first double number: ");
            double y = RequestData.GetDouble("Input second double number: ");
            double resultAdd = CalculateData.Add(x,y);
            UserMessage.PrintResult($"{x} + {y} is {resultAdd}");
            
            double resultSub = CalculateData.Sub(x,y);
            UserMessage.PrintResult($"{x} - {y} is {resultSub}");

            double resultMul = CalculateData.Multiply(x,y);
            UserMessage.PrintResult($"{x} * {y} is {resultMul}");

            double resultDiv = CalculateData.Divide(x,y);
            UserMessage.PrintResult($"{x} / {y} is {resultDiv}");

            Console.ReadLine();
        }
    }
}

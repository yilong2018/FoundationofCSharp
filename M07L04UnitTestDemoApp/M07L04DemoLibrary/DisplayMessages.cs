using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Red, Green, Refactor

namespace M07L04DemoLibrary
{
    public class DisplayMessages
    {
        public string Greeting(string firstName, int hourOfTheDay)
        {
            string output = "";

            // DataAccess da = new DataAccess();
            // da.WriteToDB("MyData");

            if(hourOfTheDay < 5)
            {
                output = $"Go to bed { firstName }";
            }
            else if (hourOfTheDay < 12)
            {
                output = $"Good morning { firstName }";
            }
            else if (hourOfTheDay < 18)
            {
                output = $"Good afternoon { firstName }";
            }
            else
            {
                output = $"Good evening { firstName }";
            }

            return output;
        }
    }

    // Homework: build a simple unit test project. Don't worry about testing any code yet.
    // Just get the flow down(Arrange, Act, Assert)
}

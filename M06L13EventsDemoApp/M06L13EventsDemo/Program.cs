using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M06L13EventsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //CollegeClassModel history = new CollegeClassModel("History 101", 3);
            //CollegeClassModel math = new CollegeClassModel("Calculus 201", 2);

            //history.EnrollmentFull += History_EnrollmentFull;

            //history.SignUpStudent("Tim Corey").PrintToConsole();
            //history.SignUpStudent("Sue Storm").PrintToConsole();
            //history.SignUpStudent("Tom Smith").PrintToConsole();
            //history.SignUpStudent("Mary Jones").PrintToConsole();
            //history.SignUpStudent("Sandy Patty").PrintToConsole();
            //Console.WriteLine();

            //math.EnrollmentFull += Math_EnrollmentFull;

            //math.SignUpStudent("Tim Corey").PrintToConsole();
            //math.SignUpStudent("Sue Storm").PrintToConsole();
            //math.SignUpStudent("Tom Smith").PrintToConsole();

            ShipClassModel ship = new ShipClassModel();

            ship.BoardEvent += Ship_BoardEvent;


            ship.BordShip("Yi long").PrintMessage();
            ship.BordShip("Sue Smith").PrintMessage();
            ship.BordShip("CoCo Peng").PrintMessage();
            ship.BordShip("Tim Corey").PrintMessage();
            ship.BordShip("Sandy Patty").PrintMessage();



            Console.ReadLine();
        }

        private static void Ship_BoardEvent(object sender, string e)
        {
            Console.WriteLine();
            Console.WriteLine("The ship is full");
            Console.WriteLine();
        }

        private static void Math_EnrollmentFull(object sender, string e)
        {
            Console.WriteLine();
            Console.WriteLine("The enrollment is full for math.");
            Console.WriteLine();
        }

        private static void History_EnrollmentFull(object sender, string e)
        {
            Console.WriteLine();
            Console.WriteLine("The enrollment is full for history.");
            Console.WriteLine();
        }
    }

    public static class ConsoleHelpers
    {
        public static void PrintToConsole(this string message)
        {
            Console.WriteLine(message);
        }
    }

    public static class PrintHelper
    {
        public static void PrintMessage(this string message)
        {
            Console.WriteLine(message);
        }
    }
    public class CollegeClassModel
    {
        public event EventHandler<string> EnrollmentFull;

        private List<string> enrolledStudents = new List<string>();
        private List<string> waitingList = new List<string>();

        public string CourseTitle { get; private set; }
        public int MaximunStudents { get; private set; }

        public CollegeClassModel(string courseTile, int maximumStudents)
        {
            CourseTitle = courseTile;
            MaximunStudents = maximumStudents;
        }

        public string SignUpStudent(string studentName)
        {
            string output = "";
            if ( enrolledStudents.Count < MaximunStudents )
            {
                enrolledStudents.Add(studentName);
                output = $"{ studentName } was enrolled in { CourseTitle }";
                // Check to see if we are maxed out
                if( enrolledStudents.Count == MaximunStudents)
                {
                    EnrollmentFull?.Invoke(this, $"{ CourseTitle } enrollment is now full."); //comsume the class
                }
            }
            else
            {
                waitingList.Add(studentName);
                output = $"{ studentName } was added to the wait list in { CourseTitle }";
            }
            return output;
        }
    }


    public class ShipClassModel
    {
        public event EventHandler<string> BoardEvent;
        public List<string> boardedPeople { get; set; } = new List<string>();
        public List<string> waitingPeople { get; set; } = new List<string>();

        public string BordShip(string personName)
        {
            string output = "";
            if ( boardedPeople.Count < 3 )
            {
                boardedPeople.Add(personName);
                output = $"{ personName } boarded";
                if ( boardedPeople.Count == 3)
                {
                    BoardEvent?.Invoke(this, output);
                }
            }
            else
            {
                waitingPeople.Add(personName);
                output = $"{ personName } didn't board";
            }

            return output;
        }
    }
    // Homework: Create an even in a class and then consume that class.
    // Attach a listener to the event and have it write to the console.
}

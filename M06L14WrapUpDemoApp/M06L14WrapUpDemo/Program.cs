using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M06L14WrapUpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> people = new List<PersonModel>()
            {
                new PersonModel{ FirstName = "Tim", LastName="Coreydarnit", Email="tim@qq.com"},
                new PersonModel{ FirstName = "Sue", LastName="Storm", Email="Sue@qq.com"},
                new PersonModel{ FirstName = "Yi", LastName="Kind", Email = "yi@qq.com" }
            };

            List<CarModel> cars = new List<CarModel>() { 
                new CarModel{ Manufacturer="Toyota", Model="DARNCorolla"},
                new CarModel{ Manufacturer="Toyota", Model="HIghlander"},
                new CarModel{ Manufacturer="Ford", Model="heckMustang"}
            };


            DataAccess<PersonModel> peopleData = new DataAccess<PersonModel>();

            peopleData.BadEntryFound += PeopleData_BadEntryFound;
            peopleData.SaveToCSV(people, @"E:\VmwareShared\Coding\github\TEMP\people.csv");


            DataAccess<CarModel> carData = new DataAccess<CarModel>();

            carData.BadEntryFound += CarData_BadEntryFound;
            carData.SaveToCSV(cars, @"E:\VmwareShared\Coding\github\TEMP\cars.csv");

            Console.ReadLine();
        }

        private static void CarData_BadEntryFound(object sender, CarModel e)
        {
            Console.WriteLine($"Bad Entry found for {e.Manufacturer} {e.Model} ");
        }

        private static void PeopleData_BadEntryFound(object sender, PersonModel e)
        {
            Console.WriteLine($"Bad Entry found for {e.FirstName} {e.LastName} ");
        }
    }

    public class DataAccess<T> where T : new() //33:50 Change static class to Generic Class
    {
        public event EventHandler<T> BadEntryFound;
        public void SaveToCSV(List<T> items, string filePath) 
        {
            List<string> rows = new List<string>();
            // Reflection
            T entry = new T();
            var cols = entry.GetType().GetProperties();

            string row = "";
            foreach (var col in cols)
            {
                row += $",{ col.Name }";
            }
            row = row.Substring(1); //FirstName,LastName,Email
            rows.Add(row);

            foreach (var item in items)
            {
                row = "";
                bool badWorldDetected = false;

                foreach (var col in cols)
                {
                    string val = col.GetValue(item, null).ToString();

                    badWorldDetected = BadWordDetector(val);

                    if ( badWorldDetected == true )
                    {
                        BadEntryFound?.Invoke(this, item);
                        break;
                    }

                    row += $",{ val }";
                }

                if ( badWorldDetected == false)
                {
                    row = row.Substring(1);
                    rows.Add(row);
                }

            }

            File.WriteAllLines(filePath, rows);
        }
        private bool BadWordDetector(string stringToTest)
        {
            bool output = false;

            string lowerCaseTest = stringToTest.ToLower();
            if (lowerCaseTest.Contains("darn") || lowerCaseTest.Contains("heck"))
            {
                output = true;
            }

            return output;
        }
    }

    // Homework: Recreate the project we just did without looking back the video. Make sure to make small tweaks.
}

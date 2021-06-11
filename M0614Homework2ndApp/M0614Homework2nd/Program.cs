using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M0614Homework2nd
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> people = new List<PersonModel>()
            {
                new PersonModel{ FirstName = "Tim", LastName="Coreydbad", Email="tim@qq.com"},
                new PersonModel{ FirstName = "Sue", LastName="Storm", Email="Sue@qq.com"},
                new PersonModel{ FirstName = "Yi", LastName="Kind", Email = "yi@qq.com" }
            };

            List<CarModel> cars = new List<CarModel>() {
                new CarModel{ Manufacturer="Toyota", Model="GoodCorolla"},
                new CarModel{ Manufacturer="Toyota", Model="HIghlander"},
                new CarModel{ Manufacturer="Ford", Model="badMustang"}
            };

            string location = @"E:\VmwareShared\Coding\github\TEMP\";

            ConsoleHelper<PersonModel> personHelper = new ConsoleHelper<PersonModel>();

            personHelper.NameCheckEvent += PersonHelper_NameCheckEvent;
            personHelper.SaveToCsv(people, location + "people.csv");

            ConsoleHelper<CarModel> carHelper = new ConsoleHelper<CarModel>();
            carHelper.NameCheckEvent += CarHelper_NameCheckEvent;
            carHelper.SaveToCsv(cars, location + "cars.csv");



            Console.ReadLine();
        }

        private static void CarHelper_NameCheckEvent(object sender, CarModel e)
        {
            Console.WriteLine($"{ e.Manufacturer } { e.Model } has error in name.");
        }

        private static void PersonHelper_NameCheckEvent(object sender, PersonModel e)
        {
            Console.WriteLine($"{ e.FirstName } { e.LastName }:{ e.Email } has error in name.");
        }

    }

    public class ConsoleHelper<T> where T: new()
    {
        public event EventHandler<T> NameCheckEvent;
        public void SaveToCsv(List<T> items, string fileLocation)
        {
            List<string> rows = new List<string>();
            string row = "";

            T tempT = new T();
            var cols = tempT.GetType().GetProperties();
            foreach (var col in cols)
            {
                row += $",{col.Name}";
            }
            row = row.Substring(1);
            rows.Add(row);

            foreach (var item in items)
            {
                row = "";
                bool isBadName = false;
                foreach (var col in cols)
                {
                    string val = col.GetValue(item, null).ToString();
                    isBadName = CheckBadNames(val);
                    if ( isBadName == true )
                    {
                        NameCheckEvent?.Invoke(this, item);
                        break;
                    }
                    row += $",{ val }";
                }

                if (isBadName == false)
                {
                    row = row.Substring(1);
                    rows.Add(row);
                }
                
            }

            File.WriteAllLines(fileLocation, rows);
        }
        private static bool CheckBadNames(string name)
        {
            bool output = false;

            string checkName = name.ToLower();

            if (checkName.Contains("bad") || checkName.Contains("good") )
            {
                output = true;
            }

            return output;
        }
    }

    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
    public class CarModel
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
    }
}

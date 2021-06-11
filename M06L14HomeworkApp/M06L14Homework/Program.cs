using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M06L14Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> people = new List<PersonModel> { 
                new PersonModel{ FirstName = "Yi", LastName = "Long", Email="yi@long.com"},
                new PersonModel{ FirstName = "Sue", LastName = "Storm", Email="sue@storm.com"},
                new PersonModel{ FirstName = "Tim", LastName = "Corey", Email="tim@corey.com"},
            };
            List<CarModel> cars = new List<CarModel>
            {
                new CarModel{ Manufacturer="Toyota", Model="Carolla"},
                new CarModel{ Manufacturer="Toyota", Model="Highland"},
                new CarModel{ Manufacturer="Ford", Model="Mustash"}
            };

            people.PrintList().ConsolePrint();
            cars.PrintList().ConsolePrint();

            Console.ReadLine();
        }
    }

    public static class ClassHelper
    {
        public static List<string> PrintList<T>(this List<T> items) where T: new()  // Error (this <T> items) -> (this T items)
        {
            List<string> rows = new List<string>();  // 怎麽才能只打印一行標題呢？新建一個對象來獲取propertyname
            string row = "";

            T tempT = new T();    //不能創建對象時，需在method第一行后加入：where T: new(),表示Generic只有默認空構造函數

            var cols = tempT.GetType().GetProperties();
            foreach (var col in cols)
            {
                row += $",{ col.Name }";
            }
            row = row.Substring(1);
            rows.Add(row);

            foreach (var item in items) //每次增加行的時候，前面的内容，都在當前行。因爲沒有清空row内容，增加 row=""
            {
                row = "";
                foreach (var col in cols)
                {
                    row += $",{ col.GetValue(item, null) }";
                }
                row = row.Substring(1);
                rows.Add(row);
            }

            return rows;
        }

        public static void ConsolePrint(this List<string> listString)
        {
            foreach (var str in listString)
            {
                Console.WriteLine(str);
            }
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

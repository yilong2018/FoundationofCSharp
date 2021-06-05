using System;
using System.Collections.Generic;

namespace M0604MiniProjectInandIn
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRentable> rentables = new List<IRentable>();
            List<IPurchasable> purchasables = new List<IPurchasable>();

            var vehicle = new VehicleModel { DealerFee = 25, PorductName = "Kia Optima" };
            var book = new BookModel { PorductName = "A Tale of Two Cities", NumberOfPages = 350 };
            var excavator = new ExcavatorModel { PorductName = "Bulldozer", QuantityInStock = 2 };

            rentables.Add(vehicle);
            rentables.Add(excavator);

            purchasables.Add(vehicle);
            purchasables.Add(book);

            Console.Write("Do you want to rent or purchase something: (rent, purchase)");
            string rentalDecision = Console.ReadLine();

            if (rentalDecision.ToLower() == "rent")
            {
                foreach (var item in rentables)
                {
                    System.Console.WriteLine($"Item: {item.PorductName}");
                    Console.Write("Do you want to rent this item (yes/no)");
                    string wantToRent = Console.ReadLine();

                    if (wantToRent.ToLower() == "yes")
                    {
                        item.Rent();
                    }

                    Console.Write("Do you want to return this item (yes/no)");
                    string wantToReturn = Console.ReadLine();

                    if (wantToRent.ToLower() == "yes")
                    {
                        item.ReturnRental();
                    }
                }
            }else
            {
                foreach (var item in purchasables)
                {
                    System.Console.WriteLine($"Item: {item.PorductName}");
                    Console.Write("Do you want to purchases this product (yes/no): ");
                    string wantToPurchase = Console.ReadLine();

                    if (wantToPurchase.ToLower() == "yes")
                    {
                        item.Purchase();
                    }
                }
            }

            Console.WriteLine("We're done.");

            Console.ReadLine();
        }
    }

    public interface IInventoryItem
    {
        string PorductName { get; set; }
        int QuantityInStock { get; set; }
    }
    public interface IPurchasable : IInventoryItem
    {
        void Purchase();
    }
    public interface IRentable : IInventoryItem
    {
        void Rent();
        void ReturnRental();
    }
    public class InventoryItemModel
    {
        public string PorductName { get; set; }
        public int QuantityInStock { get; set; }
    }
    public class VehicleModel : InventoryItemModel, IPurchasable, IRentable
    {
        public decimal DealerFee { get; set; }

        public void Purchase()
        {
            QuantityInStock -= 1;
            System.Console.WriteLine("This vehicle has been purchased.");
        }

        public void Rent()
        {
            QuantityInStock -= 1;
            System.Console.WriteLine("This vehicle has been rented");
        }

        public void ReturnRental()
        {
            QuantityInStock += 1;
            System.Console.WriteLine("This vehicle has been returned");
        }
    }
    public class BookModel : InventoryItemModel, IPurchasable
    {
        public int NumberOfPages { get; set; }

        public void Purchase()
        {
            QuantityInStock -= 1;
            System.Console.WriteLine("This book has been purchased.");
        }
    }
    public class ExcavatorModel : InventoryItemModel, IRentable
    {
        public void Dig()
        {
            System.Console.WriteLine("Iam digging");
        }

        public void Rent()
        {
            QuantityInStock -= 1;
            System.Console.WriteLine("This excavator has been rented");
        }

        public void ReturnRental()
        {
            QuantityInStock += 1;
            System.Console.WriteLine("The excavator has been returned");
        }
    }

    //Homework: Build a similar project to what we did here but change
    // it just a bit so you are sure you understand it.
}

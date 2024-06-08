using System.Security.Cryptography.X509Certificates;

namespace Engle_Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShippable Bicycles = new Bicycles();
            IShippable Mowers = new Lawn_Mowers();
            IShippable Phones = new Cell_Phones();
            IShippable Gloves = new Baseball_Gloves();
            IShippable Crackers = new Crackers();
            Shipper Supplier = new Shipper();
            ConsoleKeyInfo Input;
            int Selected = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Choose from the following options:" +
                    "\n1. Add a Bicycle to the shipment" +
                    "\n2. Add a Lawn Mower to the shipment" +
                    "\n3. Add a Cell Phone to the shipment" +
                    "\n4. Add a Baseball Glove to the shipment" +
                    "\n5. Add Crackers to the shipment" +
                    "\n6. List Shipment Items" +
                    "\n7. Compute Shipping Charges");
                Input = Console.ReadKey();
                switch (Input.Key)
                {
                    case ConsoleKey.D1:
                        Selected = 1;
                        break;
                    case ConsoleKey.D2:
                        Selected = 2;
                        break;
                    case ConsoleKey.D3:
                        Selected = 3;
                        break;
                    case ConsoleKey.D4:
                        Selected = 4;
                        break;
                    case ConsoleKey.D5:
                        Selected = 5;
                        break;
                    case ConsoleKey.D6:
                        Selected = 6;
                        break;
                    case ConsoleKey.D7:
                        Selected = 7;
                        break;
                }
                switch (Selected)
                {
                    case 1:
                        Supplier.Add(Bicycles);
                        Console.Clear();
                        Console.WriteLine("1 " + Bicycles.Product + " has been added." +
                            "\n\nPress any key to return to the menu");
                        Console.ReadKey();
                        break;
                    case 2:
                        Supplier.Add(Mowers);
                        Console.Clear();
                        Console.WriteLine("1 " + Mowers.Product + " has been added." +
                            "\n\nPress any key to return to the menu");
                        Console.ReadKey();
                        break;
                    case 3:
                        Supplier.Add(Phones);
                        Console.Clear();
                        Console.WriteLine("1 " + Phones.Product + " has been added." +
                            "\n\nPress any key to return to the menu");
                        Console.ReadKey();
                        break;
                    case 4:
                        Supplier.Add(Gloves);
                        Console.Clear();
                        Console.WriteLine("1 " + Gloves.Product + " has been added." +
                            "\n\nPress any key to return to the menu");
                        Console.ReadKey();
                        break;
                    case 5:
                        Supplier.Add(Crackers);
                        Console.Clear();
                        Console.WriteLine("1 " + Crackers.Product + " has been added." +
                            "\n\nPress any key to return to the menu");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine(Supplier.Products());
                        Console.WriteLine("\nPress any key to continue.");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine(Supplier.Charges());
                        Console.WriteLine("\nPress any key to finish.");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                }
            }while (true);
        }
    }
}

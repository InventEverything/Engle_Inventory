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
            int Selected;
            do
            {
                Menu();
                Input = Console.ReadKey();
                Selected = Selection(Input);
                switch (Selected)
                {
                    case 1:
                        Supplier.Add(Bicycles);
                        Message(Bicycles);
                        break;
                    case 2:
                        Supplier.Add(Mowers);
                        Message(Mowers);
                        break;
                    case 3:
                        Supplier.Add(Phones);
                        Message(Phones);
                        break;
                    case 4:
                        Supplier.Add(Gloves);
                        Message(Gloves);
                        break;
                    case 5:
                        Supplier.Add(Crackers);
                        Message(Crackers);
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
            //Console.WriteLine(supplier.Products());
        }
        static void Menu()
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
        }
        static int Selection(ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.D1:
                    return 1;
                    break;
                case ConsoleKey.D2:
                    return 2;
                    break;
                case ConsoleKey.D3:
                    return 3;
                    break;
                case ConsoleKey.D4:
                    return 4;
                    break;
                case ConsoleKey.D5:
                    return 5;
                    break;
                case ConsoleKey.D6:
                    return 6;
                    break;
                case ConsoleKey.D7:
                    return 7;
                    break;
                default: return 0;
            }
        }
        static void Message(IShippable product)
        {
            Console.Clear();
            Console.WriteLine("1 "+product.Product+" has been added." +
                "\n\nPress any key to return to the menu");
            Console.ReadKey();
        }
    }
}

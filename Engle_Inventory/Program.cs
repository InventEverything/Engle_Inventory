using System.Security.Cryptography.X509Certificates;

namespace Engle_Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShippable customer = new Bicycles();
            Shipper supplier = new Shipper();
            supplier.Add(customer);
            supplier.Add(customer);
            Console.WriteLine(supplier.Products());
        }
    }
}

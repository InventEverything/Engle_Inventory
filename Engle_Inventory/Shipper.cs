using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engle_Inventory
{
    public class Shipper
    {
        private string[] _cart = new string[10];
        private int _counter = 0;
        public void Add(IShippable product)
        {
            if (_counter <= 10)
            {
                _cart[_counter] = product.Product;
                _counter++;
            }
        }
        public string Products()
        {
            int[] products = new int[5];
            string[] names = ["Bicycle", "Lawn Mower", "Cell Phone", "Baseball Glove", "Crackers"];
            for (int i = 0; i < 10; i++)
            {
                if (_cart[i] == names[0])
                {
                    products[0]++;
                }
                else if (_cart[i] == names[1])
                {
                    products[1]++;
                }
                else if (_cart[i] == names[2])
                {
                    products[2]++;
                }
                else if (_cart[i] == names[3])
                {
                    products[3]++;
                }
                else if (_cart[i] == names[4])
                {
                    products[4]++;
                }
            }
            for(int i  = 0; i < 4; i++)
            {
                if (products[i] > 1 || products[i] == 0)
                {
                    names[i] += "s";
                }
            }
            return products[0] + " " + names[0] +
                "\n" + products[1] + " " + names[1] +
                "\n" + products[2] + " " + names[2] +
                "\n" + products[3] + " " + names[3] +
                "\n" + products[4] + " " + names[4];
        }
    }
}

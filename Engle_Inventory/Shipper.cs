using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engle_Inventory
{
    public class Shipper
    {
        private IShippable[] _cart = new IShippable[10];
        private int _counter = 0;
        public void Add(IShippable product)
        {
            if (_counter < 10)
            {
                _cart[_counter] = product;
                _counter++;
            }
        }
        public string Charges()
        {
            decimal[] charges = new decimal[5];
            string[] names = ["Bicycle", "Lawn Mower", "Cell Phone", "Baseball Glove", "Crackers"];
            decimal totalCharges = 0;
            for (int i = 0; i < _counter; i++)
            {
                //Bicycle
                if (_cart[i].Product == names[0])
                {
                    charges[0]+=_cart[i].ShipCost;
                }
                //Lawn Mower
                else if (_cart[i].Product == names[1])
                {
                    charges[1] += _cart[i].ShipCost;
                }
                //Cell Phone
                else if (_cart[i].Product == names[2])
                {
                    charges[2] += _cart[i].ShipCost;
                }
                //Baseball Glove
                else if (_cart[i].Product == names[3])
                {
                    charges[3] += _cart[i].ShipCost;
                }
                //Crackers
                else if (_cart[i].Product == names[4])
                {
                    charges[4] += _cart[i].ShipCost;
                }
            }
            //Totals shipping costs
            for (int i = 0;i < charges.Length; i++)
            {
                totalCharges += charges[i];
            }
            return "Total shipping cost " + totalCharges.ToString("c");
        }
        public string Products()
        {
            int[] products = new int[5];
            string[] names = ["Bicycle", "Lawn Mower", "Cell Phone", "Baseball Glove", "Crackers"];
            for (int i = 0; i < _counter; i++)
            {
                //Bicycle
                if (_cart[i].Product == names[0])
                {
                    products[0]++;
                }
                //Lawn Mower
                else if (_cart[i].Product == names[1])
                {
                    products[1]++;
                }
                //Cell Phone
                else if (_cart[i].Product == names[2])
                {
                    products[2]++;
                }
                //Baseball Glove
                else if (_cart[i].Product == names[3])
                {
                    products[3]++;
                }
                //Crackers
                else if (_cart[i].Product == names[4])
                {
                    products[4]++;
                }
            }
            //Pluralizes
            for (int i = 0; i < 4; i++)
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

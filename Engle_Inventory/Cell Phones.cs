using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engle_Inventory
{
    internal class Cell_Phones : IShippable
    {
        decimal IShippable.ShipCost { get { return 5.95m; } }
        string IShippable.Product { get { return "Cell Phone"; } }
    }
}

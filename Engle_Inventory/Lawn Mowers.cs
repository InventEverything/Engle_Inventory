using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engle_Inventory
{
    internal class Lawn_Mowers : IShippable
    {
        decimal IShippable.ShipCost { get { return 25m; } }
        string IShippable.Product { get { return "Lawn Mower"; } }
    }
}

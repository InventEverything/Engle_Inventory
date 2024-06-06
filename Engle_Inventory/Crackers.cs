using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engle_Inventory
{
    internal class Crackers : IShippable
    {
        decimal IShippable.ShipCost { get { return 0.57m; } }
        string IShippable.Product { get { return "Crackers"; } }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    public class Inventory
    {
        List<Item> myInventoryList;
        int myInventorySize;

        public Inventory (int aInventorySize)
        {
            myInventorySize = aInventorySize;
            myInventoryList = new List<Item>();
        }

        public List<Item> AccessInvetory { get => myInventoryList; set => myInventoryList = value; }

    }
}

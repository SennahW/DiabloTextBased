using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    public class Inventory
    {
        public List<Item> myInventoryList;

        public Inventory ()
        {   myInventoryList = new List<Item>();
            PrintInventory();
            Console.ReadKey();
        }

        public void PrintInventory()
        {
            for (int i = 0; i < myInventoryList.Count; i++)
            {
                myInventoryList[i].PrintItem();
            }
        }

        public void CreateItem (int aTypeOfItem, int aDamage, int aHealing, int aDurability, string aNameOfItem)
        {
            myInventoryList.Add(new Item(aTypeOfItem, aDamage, aHealing, aDurability, aNameOfItem));
        }
    }
}

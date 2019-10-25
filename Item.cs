﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    public class Item
    {
        string myName;
        int myTypeOfItem;
        int myDamage;
        int myHealing;
        int myDurability;

        public Item (int aTypeOfItem, int aDamage, int aHealing, int aDurability, string aNameOfItem)
        {
            myName = aNameOfItem;
            myDamage = aDamage;
            myHealing = aHealing;
            myDurability = aDurability;
            myTypeOfItem = aTypeOfItem;
        }

        public void PrintItem()
        {
            Console.WriteLine(myName);
            switch (myTypeOfItem)
            {
                case 0:
                    Console.WriteLine("Weapon");
                    break;
                case 1:
                    Console.WriteLine("Armor");
                    break;
                case 2:
                    Console.WriteLine("Potion");
                    break;
            }
        }
    }
}
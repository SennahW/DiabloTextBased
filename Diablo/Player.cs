using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    public class Player
    {

        int myHealth;
        int myDamage;
        string myName;
        Inventory myInventory;

        private static Player myInstance;

        public Player (int someHealth, int someDamage, string aName)
        {
            myHealth = someHealth;
            myDamage = someDamage;
            myName = aName;
            myInventory = new Inventory();

            myInstance = this;
        }

        public int AccessHealth { get => myHealth; set => myHealth = value; } 
        public int AccessDamage { get => myDamage; set => myDamage = value; }
        public static Player GetInstance() { return myInstance; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    public class Player
    {
        public int myHealth;
        public int myDamage;
        public string myName;
        public int myAbilityCooldown;
        public int myAbilityDamage;
        public Inventory myInventory;

        private static Player myInstance;

        public Player (int someHealth, int someDamage, string aName, int anAbilityCooldown, int anAbilityDamage)
        {
            myHealth = someHealth;
            myDamage = someDamage;
            myName = aName;
            myAbilityCooldown = anAbilityCooldown;
            myAbilityDamage = anAbilityDamage;
            myInventory = new Inventory();

            myInstance = this;
        }

        public static Player Get() { return myInstance; }
    }
}

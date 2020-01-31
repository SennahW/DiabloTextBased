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
        int myXP = 0;
        Inventory myInventory;

        private static Player myInstance;
         
        public Player ()
        {
            myInstance = this;
            myHealth = 100;
            myDamage = 120;
            myName = CreatePlayerName();
            myInventory = new Inventory(10);
        }

        private string CreatePlayerName()
        {
            return "Zelda";
        }

        public int AccessHealth { get => myHealth; set => myHealth = value; } 
        public int AccessDamage { get => myDamage; set => myDamage = value; }
        public string AccessName { get => myName; set => myName = value; }
        public int AccessXP { get => myXP; set => myXP = value; }
        public Inventory AccessInventory { get => myInventory; set => myInventory = value; }
        public static Player GetInstance() { return myInstance; }
    }
}

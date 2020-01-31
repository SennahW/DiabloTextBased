using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    class Enemy
    {
        string myName;
        int myDamage;
        int myHealingPerRound;
        int myHealth;
        int myXPValue = 200;

        public Enemy(int aDamage, int aHealingPerRound, int aHealth, string aNameOfEnemy)
        {
            myDamage = aDamage;
            myHealingPerRound = aHealingPerRound;
            myHealth = aHealth;
            myName = aNameOfEnemy;
        }

        public void PrintEnemy (Enemy aEnemy)
        {
            Console.WriteLine(aEnemy.myName);
            Console.WriteLine(aEnemy.myDamage);
            Console.WriteLine(aEnemy.myName);
            Console.WriteLine(aEnemy.myHealingPerRound);
        }

        public void Update()
        {

        }

        public int AccessDamage { get => myDamage; set => myDamage = value; }
        public string AccessName { get => myName; set => myName = value; }
        public int AccessHealth { get => myHealth; set => myHealth = value; }
        public int AccessXPAmount { get => myXPValue; set => myXPValue = value; }

    }
}

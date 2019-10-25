using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    class Enemy
    {
        public string myName;
        public int myDamage;
        public int myHealingPerRound;
        public int myHealth;

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

    }
}

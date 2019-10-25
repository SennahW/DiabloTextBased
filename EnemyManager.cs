using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    static class EnemyManager
    {
        static public List<Enemy> myEnemies;
        static public int myCurrentIndex = 0;
            
        static public void Init()
        {
            myEnemies = new List<Enemy>();
        }

        static public int AddEnemy(int aDamage, int aHealingPerRound, int aHealth, string aNameOfEnemy)
        {
            myEnemies.Add(new Enemy (aDamage, aHealingPerRound, aHealth, aNameOfEnemy));
            Console.WriteLine("Enemy added");
            return ++myCurrentIndex;
        }
        static public void Update()
        {
            for (int i = 0; i < myEnemies.Count; i++)
            {
                myEnemies[i].Update();
            }
        }

        static public void PrintEnemy(int aID)
        {
            Console.WriteLine(aID + myEnemies[aID].myName);
            //Console.WriteLine(myEnemies[aID].myDamage);
            //Console.WriteLine(myEnemies[aID].myHealingPerRound);
        }

        static public void DeleteEnemy(int anID)
        {
            myEnemies.RemoveAt(anID);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    static class EnemyAndPlayerManager
    {
        static List<Enemy> myEnemies;
        static List<Player> myPlayers;
        static int myCurrentEnemyIndex = 0;
        static int myCurrentPlayerIndex = 0;

        static public void Init()
        {
            myEnemies = new List<Enemy>();
            myPlayers = new List<Player>();
        }

        static public int AddEnemy(int aDamage, int aHealingPerRound, int aHealth, string aNameOfEnemy)
        {
            myEnemies.Add(new Enemy (aDamage, aHealingPerRound, aHealth, aNameOfEnemy));
            Console.WriteLine("Enemy added");
            return myCurrentEnemyIndex++;
        }

        static public int AddPlayer ()
        {
            myPlayers.Add(new Player());
            return myCurrentPlayerIndex++;
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
            Console.WriteLine(aID + myEnemies[aID].AccessName);
            Console.WriteLine(myEnemies[aID].AccessDamage);
            Console.WriteLine(myEnemies[aID].AccessHealth);
        }

        static public void EnemyIsDead(int anID)
        {
            myPlayers[0].AccessXP = myPlayers[0].AccessXP + myEnemies[anID].AccessXPAmount;
            myEnemies.RemoveAt(anID);

        }

        public static List<Enemy> AccessEnemyList { get => myEnemies; set => myEnemies = value; }
        public static List<Player> AccessPlayerList { get => myPlayers; set => myPlayers = value; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Diablo
{
    class Fight
    {
        public bool Initialize (int aEnemyID)
        {
            do
            {
                PlayerMove();
                EnemyMove(aEnemyID);
            } while (EnemyAndPlayerManager.AccessPlayerList[0].AccessHealth > 0 && EnemyAndPlayerManager.AccessEnemyList[aEnemyID].AccessHealth > 0);

            if (EnemyAndPlayerManager.AccessPlayerList[0].AccessHealth <= 0)
            {
                Console.WriteLine("You lost the battle");
                return false;
            }

            else if (EnemyAndPlayerManager.AccessEnemyList[aEnemyID].AccessHealth <= 0)
            {
                Console.WriteLine("You won the battle!");
                return true;
            }

            return false;
        }

        public bool Initialize(int aEnemyID, int aEnemyID2)
        {
            do
            {
                PlayerMove();
                EnemyMove(aEnemyID);
            } while (EnemyAndPlayerManager.AccessPlayerList[0].AccessHealth > 0 && EnemyAndPlayerManager.AccessEnemyList[aEnemyID].AccessHealth > 0);

            if (EnemyAndPlayerManager.AccessPlayerList[0].AccessHealth <= 0)
            {
                Console.WriteLine("You lost the battle");
                return false;
            }

            else if (EnemyAndPlayerManager.AccessEnemyList[aEnemyID].AccessHealth <= 0)
            {
                Console.WriteLine("You won the battle!");
                return true;
            }

            return false;
        }


        public void EnemyMove(int aEnenmyID)
        {
            EnemyAndPlayerManager.AccessEnemyList[aEnenmyID].AccessHealth -= 10;
            Console.WriteLine("oaskoskds");
        }

        public void PlayerMove()
        {

        }
    }
}
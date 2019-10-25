using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    class Room
    {                                                                                       
        public Random myRNG;
        public List<int> myRoomEnemies;

        public Room(int aXCoordinate, int aYCoordinate)
        {
            myRNG = new Random();
            myRoomEnemies = new List<int>();
            int tempRoomLevel = aXCoordinate + aYCoordinate / 2;
        }   

        public void CreateEnemy(int aDamage, int aHealingPerRound, int aHealth, string aNameOfEnemy)
        {
            myRoomEnemies.Add(EnemyManager.AddEnemy(aDamage, aHealingPerRound, aHealth, aNameOfEnemy));
        }

        public void RemoveEnemy (int anID)
        {
            EnemyManager.DeleteEnemy(anID);
            myRoomEnemies.RemoveAt(anID);
            for (int i = myRoomEnemies.Count-1; i != anID-1; i--)
            {
                myRoomEnemies[i]--;
            }
        }
    }
}

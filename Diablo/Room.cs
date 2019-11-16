﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    class Room
    {
        int myXCoordinate;
        int myYCoordinate;
        Random myRNG;
        List<int> myRoomEnemies;
        int myRoomLevel;

        bool myRoomIsLooted;
        bool myRoomContatinsKey;

        

        public Room(int aXCoordinate, int aYCoordinate)
        {
            myRNG = new Random();
            myRoomEnemies = new List<int>();
            myRoomLevel = aXCoordinate + aYCoordinate / 2 - 3;
        }   

        public void CreateEnemy(int aDamage, int aHealingPerRound, int aHealth, string aNameOfEnemy)
        {
            myRoomEnemies.Add(EnemyManager.AddEnemy(aDamage, aHealingPerRound, aHealth, aNameOfEnemy));
        }

        public bool PlayRoom()
        {
            return true;
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

        public int AccessMyXCoordinate { get => myXCoordinate; set => myXCoordinate = value; }
        public int AccessMyYCoordinate { get => myYCoordinate; set => myYCoordinate  = value; }
        public bool AccessLootStatus { get => myRoomIsLooted; set => myRoomIsLooted = value; }
        public bool AccessKeyStatus { get => myRoomContatinsKey; set => myRoomContatinsKey = value; }
    }
}

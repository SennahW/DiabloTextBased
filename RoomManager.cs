﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    static class RoomManager
    {
        static List<Room> myRooms;
        static Random myRNG;
        static public int myCurrentIndex = 0;

        static public void Init()
        {
            myRooms = new List<Room>();
        }

        static public int CreateRoom (int aXCoordinate, int aYCoordinate)
        {
            //myRooms[myCurrentIndex] = new Room(aXCoordinate, aYCoordinate);
            Room myroom = new Room(aXCoordinate, aYCoordinate);
            return myCurrentIndex++;
        }
    }
}

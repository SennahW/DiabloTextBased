using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    static class RoomManager
    {
        static public List<Room> myRooms;
        static Random myRNG;
        static public int myCurrentIndex = 1;

        static public void Init()
        {
            myRooms = new List<Room>();
        }

        static public int CreateRoom (int aXCoordinate, int aYCoordinate)
        {
            myRooms.Add(new Room(aXCoordinate, aYCoordinate));
            return myCurrentIndex++;
        }
    }
}
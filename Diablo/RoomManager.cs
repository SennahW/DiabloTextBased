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
        static public int myCurrentIndex = 0;

        static public void Init()
        {
            myRooms = new List<Room>();
        }

        static public int CreateRoom (int aXCoordinate, int aYCoordinate)
        {
            for (int i = 0; i < myRooms.Count; i++)
            {
                if (myRooms[i].AccessMyXCoordinate != aXCoordinate && myRooms[i].AccessMyYCoordinate != aYCoordinate)
                {
                    myRooms.Add(new Room(aXCoordinate, aYCoordinate));
                    return myCurrentIndex++;
                }
                else
                {
                    return 0;
                }
            }
            return 0;
        }
    }
}
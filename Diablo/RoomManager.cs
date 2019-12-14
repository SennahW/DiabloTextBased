using System;
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
        static int myCurrentIndex = 0;
        

        static public void Init()
        {
            myRNG = new Random();
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
            if (myRooms.Count == 0)
            {
                myRooms.Add(new Room(aXCoordinate, aYCoordinate));
            }
            KeyMethod(aXCoordinate, aYCoordinate);

            return 0;
        }

        static private void KeyMethod(int aXCoordinate, int aYCoordinate)
        {
            int tempKeyCounter;
            if (aXCoordinate == 0 || aXCoordinate == 4 || aYCoordinate == 0 || aYCoordinate == 4)
            {
                if (myRNG.Next(0, 10) == 1)
                {
                    if ()
                    {

                    }
                }
            }
        }

        public static List<Room> AccessRoomList { get => myRooms; set => myRooms = value; }

    }
}
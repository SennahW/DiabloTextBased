using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    class Diablo
    {
        static int[,] myRooms = new int[5, 5];
        Player myPlayer;

        public Diablo ()
        {
            int myCurrentXCoordinate = 3;
            int myCurrentYCoordinate = 3;
            Console.WriteLine("Welcome Zelda to this terryfing world");
            myPlayer = new Player(100, 100, "Zelda");
            myRooms[3,3] = RoomManager.CreateRoom(3, 3);

            
            {
                Room(RoomManager.myRooms[myRooms[myCurrentXCoordinate, myCurrentYCoordinate]]);
            } while (myPlayer.AccessHealth > 0);
        }

        public void Room (Room aRoom)
        {
            
        }
    }
}

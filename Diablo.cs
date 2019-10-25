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

        public Diablo()
        {
            Player tempPlayer = new Player(100, 100, "Zelda", 7, 300);
            myRooms[3,3] = RoomManager.CreateRoom(3, 3);
            Console.Read();
        }
    }
}

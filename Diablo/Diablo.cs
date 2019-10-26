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

            //Actual game
            {
                if(PlayRoom(RoomManager.myRooms[myRooms[myCurrentXCoordinate, myCurrentYCoordinate]]))
                {
                    Console.WriteLine("Where do you want to go next?");
                    Console.WriteLine("1: North");
                    Console.WriteLine("2: South");
                    Console.WriteLine("3: East");
                    Console.WriteLine("4: West");
                    string tempUserInput = Console.ReadLine();
                    if (tempUserInput == "1")
                    {

                    }
                }
                
            } while (myPlayer.AccessHealth > 0);
        }

        public bool PlayRoom (Room aRoom)
        {
            if (myPlayer.AccessHealth > 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

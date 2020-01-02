using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    class Diablo
    {
        static int[,] myRooms = { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };
        Player myPlayer;

        int myCurrentXCoordinate = 2;
        int myCurrentYCoordinate = 2;

        public Diablo ()
        {
            myPlayer = new Player();
            Console.WriteLine("Welcome " + myPlayer.AccessName + " to this terryfing world");

            Graphics.PrintMap(myCurrentXCoordinate, myCurrentYCoordinate);

            //Actual game
            do
            {
                    myRooms[myCurrentXCoordinate, myCurrentYCoordinate] = RoomManager.CreateRoom(myCurrentXCoordinate, myCurrentXCoordinate);
                    if (RoomManager.AccessRoomList[myRooms[myCurrentXCoordinate, myCurrentYCoordinate]].PlayRoom())
                    {
                        Move();
                    }

                Graphics.ClearGraphics(myCurrentXCoordinate, myCurrentYCoordinate);
            } while (myPlayer.AccessHealth > 0);
        }

        public void Move()
        {
            bool tempCorrectInput = false;
            do
            {
                string tempUserInput = Console.ReadLine();
                Console.WriteLine("Where do you want to go next?");
                Console.WriteLine("1: North");
                Console.WriteLine("2: South");
                Console.WriteLine("3: East");
                Console.WriteLine("4: West");

                for (int i = 0; i < EnemyAndPlayerManager.AccessPlayerList[0].AccessInventory.AccessInvetory.Count; i++)
                {

                }            

                else if (tempUserInput == "2" && myCurrentYCoordinate < 4)
                {
                    tempCorrectInput = true;
                    myCurrentYCoordinate++;
                }
                else if (tempUserInput == "1" && myCurrentYCoordinate > 0)
                {
                    tempCorrectInput = true;
                    myCurrentYCoordinate--;
                }
                else if (tempUserInput == "3" && myCurrentXCoordinate < 4)
                {
                    tempCorrectInput = true;
                    myCurrentXCoordinate++;
                }
                else if (tempUserInput == "4" && myCurrentXCoordinate > 0)
                {
                    tempCorrectInput = true;
                    myCurrentXCoordinate--;
                }
                else
                {
                    Graphics.ClearGraphics(myCurrentXCoordinate, myCurrentYCoordinate);
                    Console.WriteLine("Invalid input!");
                }
            }
            while (tempCorrectInput == false);
        }
    }
}
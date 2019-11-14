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

        int myCurrentXCoordinate = 2;
        int myCurrentYCoordinate = 2;

        public Diablo ()
        {
            
            Console.WriteLine("Welcome Zelda to this terryfing world");
            myPlayer = new Player(100, 100, "Zelda");
            myRooms[myCurrentXCoordinate, myCurrentYCoordinate] = RoomManager.CreateRoom(myCurrentXCoordinate, myCurrentYCoordinate);
            Graphics.UpdateMap(myCurrentXCoordinate, myCurrentYCoordinate);

            //Actual game
            do
            {
                if (myRooms[myCurrentXCoordinate, myCurrentYCoordinate] == null)
                {
                    myRooms[myCurrentXCoordinate, myCurrentYCoordinate] = RoomManager.CreateRoom(myCurrentXCoordinate, myCurrentXCoordinate);
                    if (RoomManager.myRooms[myRooms[myCurrentXCoordinate, myCurrentYCoordinate]].PlayRoom())
                    {
                        Move();
                    }
                }
                else
                {
                    if (RoomManager.myRooms[myRooms[myCurrentXCoordinate, myCurrentYCoordinate]].PlayRoom())
                    {
                        Move();
                    }
                }

                Graphics.ClearGraphics(myCurrentXCoordinate, myCurrentYCoordinate);
            } while (myPlayer.AccessHealth > 0);
        }

        public void Move ()
        {
            Console.WriteLine("Where do you want to go next?");
            Console.WriteLine("1: North");
            Console.WriteLine("2: South");
            Console.WriteLine("3: East");
            Console.WriteLine("4: West");
            string tempUserInput = Console.ReadLine();

            if (tempUserInput == "2" && myCurrentYCoordinate < 4)
            {
                myCurrentYCoordinate++;
            }
            else if (tempUserInput == "1" && myCurrentYCoordinate > 0)
            {
                myCurrentYCoordinate--;
            }
            else if (tempUserInput == "3" && myCurrentXCoordinate < 4)
            {
                myCurrentXCoordinate++;
            }
            else if (tempUserInput == "4" && myCurrentXCoordinate > 0)
            {
                myCurrentXCoordinate--;
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
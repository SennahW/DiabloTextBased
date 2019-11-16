using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    

    static class Graphics
    {
        static public void PrintMap(int myCurrentXCoordinate, int myCurrentYCoordinate)
        {
         

            int tempStartLineTop = Console.CursorTop;
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    if (x == 0)
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            Console.SetCursorPosition(176 + x * 7 - 1, y * 3 + k);
                            Console.Write("|");
                        }
                    }
                    //Draws a box
                    for (int k = 0; k < 3; k++)
                    {
                        if (k == 2)
                        {
                            Console.SetCursorPosition(176 + x * 7, y * 3 + k);
                            Console.Write("______|");
                        }
                        else
                        {
                            Console.SetCursorPosition(176 + x * 7, y * 3 + k);
                            Console.CursorLeft += 6;
                            Console.Write("|");
                        }
                        if (k == 1)
                        {
                            Console.SetCursorPosition(176 + x * 7, y * 3 + k);
                            if (myCurrentXCoordinate == x && myCurrentYCoordinate == y)
                            {
                                Console.SetCursorPosition(176 + x * 7 + 2, y * 3 + k);
                                Console.Write("[]");
                            }
                            for (int i = 0; i < RoomManager.myRooms.Count; i++)
                            {
                                if (RoomManager.myRooms[i].AccessMyXCoordinate == x && RoomManager.myRooms[i].AccessMyYCoordinate == y)
                                {
                                    Console.SetCursorPosition(176 + x * 7, y * 3 + k);

                                    Console.Write("o¬");
                                }
                            }

                        }
                    }
                }
                Console.SetCursorPosition(0, tempStartLineTop);
            }
        }

        static public void ClearGraphics(int myCurrentXCoordinate, int myCurrentYCoordinate)
        {
            Console.Clear();
            PrintMap(myCurrentXCoordinate, myCurrentYCoordinate);
        }

        static public void PrintPlayer ()
        {
            int tempStartLineTop = Console.CursorTop;



            Console.SetCursorPosition(0, tempStartLineTop);
        }

        static public void PrintEnemy ()
        {

        }
    }
}


//    |      |      |      |      |      |
//    |      |      |      |      |      |
//    |______|______|______|______|______|
//    |      |      |      |      |      |
//    |      |      |      |      |      |
//    |______|______|______|______|______|
//    |      |      |      |      |      | 
//    |      |      |      |      |      |
//    |______|______|______|______|______|
//    |      |      |      |      |      |
//    |      |      |      |      |      |
//    |______|______|______|______|______|
//    |      |      |      |      |      |
//    |o¬    |      |      |      |      |
//    |______|______|______|______|______|
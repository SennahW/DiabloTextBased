using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    

    static class Graphics
    {
        static public void UpdateMap(int myCurrentXCoordinate, int myCurrentYCoordinate)
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
                            if(4 == x && 3 == y)
                            {
                            Console.SetCursorPosition(176 + x * 7, y * 3 + k);
                                Console.Write("o¬");
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
            UpdateMap(myCurrentXCoordinate, myCurrentYCoordinate);
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
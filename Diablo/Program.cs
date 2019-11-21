                  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    class Program
    {

        static void Main(string[] args)
        {
            bool tempGameIsRunning = true;
            EnemyAndPlayerManager.Init();
            RoomManager.Init();
            Console.WindowHeight = 50;
            Console.WindowWidth = 213;


            Console.WriteLine("Welcome to another world!");

            do
            {
                Console.WriteLine("1: Start game");
                Console.WriteLine("2: Exit game");
                string tempInput = Console.ReadLine();
                if (tempInput == "1")
                {
                    Diablo tempGame = new Diablo();
                }
                else if (tempInput == "2")
                {
                    tempGameIsRunning = false;
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Wrong Input");
                }
            }
            while (tempGameIsRunning);
        }
    }
}

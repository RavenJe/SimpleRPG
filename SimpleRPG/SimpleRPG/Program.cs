using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Map2D traverseTown = new Map2D(6, "Traverse Town");

            int playerX = 0;
            int playerY = 0;

            traverseTown.SetPlayerPosition(playerX, playerY);


            while (true)
            {
                traverseTown.Show();
                Console.WriteLine();
                Console.WriteLine("Where you want to go? (WASD): ");

                var input = Convert.ToChar(Console.ReadLine());

                switch (input)
                {
                    case 'w':
                        playerX--;
                        break;
                    case 's':
                        playerX++;
                        break;
                    case 'a':
                        playerY--;
                        break;
                    case 'd':
                        playerY++;
                        break;
                    default:
                        Console.WriteLine("Unknown Command!");
                        break;
                }

                traverseTown.SetPlayerPosition(playerX, playerY);
                Console.Clear();
            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDB.Landmines
{
    class Program
    {
        private const int size = 8;

        private static int[,] chessboard;
        private static int[,] playerPosition;
        private static int xPosition = 0;
        private static int yPosition = 7;


        private static void Main()
        {

            Game(null);
        }

        private static void Game(char? move)
        {
            Console.Clear();

            if (move.HasValue)
            {
                if (move.Value == 'w')
                {
                    if(yPosition > 0) 
                        yPosition--;

                }
                if (move.Value == 'a')
                {
                    if (xPosition > 0)
                        xPosition--;
                }

                if (move.Value == 's')
                {
                    if (yPosition < 7)
                        yPosition++;
                }

                if (move.Value == 'd')
                {
                    if (xPosition < 7)
                        xPosition++;
                }
            }

            //init chessboard
            chessboard = new int[size, size];

            playerPosition = new int[xPosition, yPosition];


            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    Console.Write("|{0}", xPosition == x && yPosition == y ? 'X' : ' ');
                }

                Console.WriteLine("|");
            }

            if (yPosition == 0)
            {
                Console.WriteLine("You Win!");
            }

            Console.WriteLine("");
            Console.WriteLine("Landmines hit: 0");
            var myMove = Console.ReadKey();

            Game(myMove.KeyChar);
        }
    }
}

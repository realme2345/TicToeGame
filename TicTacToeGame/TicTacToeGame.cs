using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacGame
{
    internal class TicTacToeGame
    {
        int playerOne;
        int playerTwo;
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public static void DispalyTicTacToeGame()
        {
            foreach(char c in arr)
            {
                Console.WriteLine(c);
            }
        }
    }
}

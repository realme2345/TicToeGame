using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacGame
{
    internal class TicTacToeGame
    {
        public string Player1 {get;set;}
        public  string player2 { get;set;}
        
        public void DispalyTicTacToeGame()
        {
            this.Player1 = "X";
            this.player2 = "O";
            Console.WriteLine(this.Player1, this.player2);
        }
    }
}

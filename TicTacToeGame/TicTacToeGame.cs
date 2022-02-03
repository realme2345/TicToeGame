using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacGame
{
    internal class TicTacToeGame
    {
        public char Player1 {get;set;}
        public  char player2 { get;set;}
        
        public void DispalyTicTacToeGame()
        {
            Console.WriteLine("Enter the player characcter X or O");
            char s=Convert.ToChar(Console.ReadLine());
            switch (s)
            {
                case 'X':
                    this.Player1 = s;
                    break;
                case 'O':
                    this.player2 = s;
                    break ;
            }
            Console.WriteLine(this.Player1+" "+this.player2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacGame
{
    internal class TicTacToeGame
    {
        char[] arr = new char[10];
        public void DispalyTicTacToeGame()
        {
            for (int i = 1; i < 10; i++)
            {
                foreach (char c in arr)
                {
                    Console.WriteLine(c);
                }
            }
        }
        public char player1 {get;set;}
        public  char computer { get;set;}
        
        public void DispalyPlayer()
        {
            Console.WriteLine("Enter the player character X or O");
            char s=Convert.ToChar(Console.ReadLine());
            switch (s)
            {
                case 'X':
                    this.player1 = s;
                    break;
                case 'O':
                    this.computer = s;
                    break ;
            }
            Console.WriteLine(this.player1+" "+this.computer);
        }
    }
}

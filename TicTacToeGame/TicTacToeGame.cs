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
                arr[i] = ' ';
            }

        }
        public char player1 {get;set;}
        public  char computer { get;set;}
        
        public void DispalyPlayer()
        {
            Console.WriteLine("Enter the player character X or O");
            char s=Convert.ToChar(Console.ReadLine());
            if (s == 'X')
            {
                this.player1 = s;
            }
            else
            {
                this.computer = s;
            }
            Console.WriteLine(this.player1+" "+this.computer);
        }
        public void DispalyBoard()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");
        }
    }
}

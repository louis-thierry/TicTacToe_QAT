using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_QAandT
{
    public class TicTacToeMethods
    {

        public int[,] gameBoard;
        public int currentTurn = 1;
        public char currentPlayer = 'X';

        public void CreateBoard()
        {
            this.gameBoard = new int[3, 3];

            for (int i = 0; i < this.gameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < this.gameBoard.GetLength(1); j++)
                {
                    this.gameBoard[i, j] = 0;
                    
                }

            }
        }
        public char CurrentPlayer(int currentTurn)
        {
            if (currentTurn % 2 == 0)
            {
                return this.currentPlayer = 'O';
            }
            else
                return this.currentPlayer = 'X';
        }
        public void ChangePlayer()
        {
            if (this.currentPlayer == 'X')
                this. currentPlayer = 'O';
            else
                this.currentPlayer = 'X';
        }
        public int MakeMove(int positionOnBoardX, int positionOnBoardY, char currentPlayer)
        {
            this.currentTurn++;

            if (currentPlayer == 'X')
            {
                gameBoard[positionOnBoardX, positionOnBoardY] = 1;
                CurrentPlayer(currentTurn);
                return 1;
            }
            else
            {
                gameBoard[positionOnBoardX, positionOnBoardY] = 2;
                CurrentPlayer(currentTurn);
                return 2;
            }
        }
        public Boolean SpaceInUse(int positionOnBoardX, int positionOnBoardY)
        {
            if (gameBoard[positionOnBoardX, positionOnBoardY] > 0)
                return true;
            return false;
        }
    }
}

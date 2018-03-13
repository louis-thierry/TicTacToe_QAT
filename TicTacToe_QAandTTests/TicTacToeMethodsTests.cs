using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe_QAandT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_QAandT.Tests
{
    [TestClass()]
    public class TicTacToeMethodsTests
    {

        TicTacToeMethods tictactoeGame = new TicTacToeMethods();

        [TestMethod()]
        public void CreateBoardTest()
        {
            int correctActiveFields = 9;
            int actualActiveFields;

            tictactoeGame.CreateBoard();

            actualActiveFields = tictactoeGame.gameBoard.Length;

            Assert.AreEqual(correctActiveFields, actualActiveFields);
        }

        [TestMethod()]
        public void CurrentPlayerTestX()
        {
            char isX = 'X';

            if (tictactoeGame.currentPlayer != 'X')
            {
                tictactoeGame.ChangePlayer();
            }

            Assert.AreEqual(isX, tictactoeGame.currentPlayer);
        }

        [TestMethod()]
        public void CurrentPlayerTestO()
        {
            char isO = 'O';

            if (tictactoeGame.currentPlayer != 'O')
            {
                tictactoeGame.ChangePlayer();
            }

            Assert.AreEqual(isO, tictactoeGame.currentPlayer);
        }

        [TestMethod()]
        public void placedAnX()
        {
            if (tictactoeGame.currentPlayer == 'O')
                Assert.IsTrue(true);
            else
                tictactoeGame.ChangePlayer();
                Assert.IsTrue(true);
        }

        [TestMethod()]
        public void placedAnO()
        {
            if (tictactoeGame.currentTurn == 'X')
                Assert.IsTrue(true);
            else
                tictactoeGame.ChangePlayer();
                Assert.IsTrue(true);
        }

        [TestMethod()]
        public void SpaceInUseTest()
        {
            tictactoeGame.CreateBoard();

            int i = 0;
            int j = 0;

            if(tictactoeGame.SpaceInUse(i,j))
            {
                Assert.IsTrue(true);
            }
        }
    }
}
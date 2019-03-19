using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe;

namespace TicTacToe
{
    [TestClass()]
    public class TicTacToeTests
    {
        [TestMethod()]
        public void Has9ActiveFields()
        {

            TicTacToe controller = new TicTacToe();
            int[,] boardArray = controller.CreateBoard();
            int activeField = 0;
            for (int i = 0; i < boardArray.Length; i++)
            {
                activeField++;
            }
            activeField = activeField / 2;
            Assert.AreEqual(9, activeField);
        }
        [TestMethod()]
        public void CurrentPlayerIsX()
        {
            TicTacToe controller = new TicTacToe();
            string player = controller.CurrentPlayer(3, "X", "O");
            Assert.AreEqual("X", player);
        }

        [TestMethod()]
        public void CurentPlayerIsO()
        {
            TicTacToe controller = new TicTacToe();
            string player = controller.CurrentPlayer(2, "X", "O");
            Assert.AreEqual("O", player);
        }

        [TestMethod()]
        public void CurrentPlayerPlaceXOnBoard()
        {
            TicTacToe controller = new TicTacToe();
            int[,] boardArray = controller.CreateBoard();
            controller.MakeMove("X", "O", "X", boardArray, 0);
            Assert.AreEqual(1, boardArray[0, 1]);
        }

        [TestMethod()]
        public void CurrentPlayerPlaceOOnBoard()
        {
            TicTacToe controller = new TicTacToe();
            int[,] boardArray = controller.CreateBoard();
            controller.MakeMove("X", "O", "O", boardArray, 1);
            Assert.AreEqual(2, boardArray[1, 1]);
        }

        [TestMethod()]
        public void PlacementIsUnoccupied()
        {
            TicTacToe controller = new TicTacToe();
            int[,] boardArray = controller.CreateBoard();
            Boolean inUse = controller.SpaceInUse(boardArray, 0);
            Assert.AreEqual(false, inUse);
        }
    }
}

using NUnit.Framework;
using Kryziukai;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Kryziukai.Tests
{
    [TestFixture()]
    public class ProgramTests
    {
        [Test()]
        public void BoardTest_IsResultCorrect()
        {
            // Arrange
            Program p = new Program();
            string[] arr = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25" };

            // Act
            Program.InitArr(arr);
            int result = Program.CheckWin(3);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result);
        }

        [Test()]
        public void IsFieldFreeTest_ExpectingFalse()
        {
            // Arrange
            Program p = new Program();
            string[] arr = { "0", "1", "2", "X", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25" };

            // Act
            Program.InitArr(arr);

            var textReader = new StringReader("3");
            Console.SetIn(textReader);

            bool result = Program.IsFieldFree();

            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(false, result);
        }

        [Test()]
        public void IsFieldFreeTest_ExpectingTrue()
        {
            // Arrange
            Program p = new Program();
            string[] arr = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25" };

            // Act
            Program.InitArr(arr);

            var textReader = new StringReader("3");
            Console.SetIn(textReader);

            bool result = Program.IsFieldFree();

            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");


            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(true, result);
        }

        [Test()]
        public void BoardTest_3x3FullBoardDraw()
        {
            // Arrange
            Program p = new Program();
            string[] arr = { "0", "O", "X", "X", "X", "X", "O", "O", "O", "X", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25" };

            // Act
            Program.InitArr(arr);
            int result = Program.CheckWin(3);

            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(-1, result);
        }

        [Test()]
        public void BoardTest_3x3FullBoardXWon()
        {
            // Arrange
            Program p = new Program();
            string[] arr = { "0", "X", "X", "X", "X", "O", "O", "O", "O", "X", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25" };

            // Act
            Program.InitArr(arr);
            int result = Program.CheckWin(3);

            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result);
        }

        [Test()]
        public void BoardTest_3x3FullBoardOWon()
        {
            // Arrange
            Program p = new Program();
            string[] arr = { "0", "O", "2", "X", "O", "x", "6", "O", "x", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25" };

            // Act
            Program.InitArr(arr);
            int result = Program.CheckWin(3);

            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result);
        }

        [Test()]
        public void IsBoardSizeCorrect_Test()
        {
            // Arrange
            Program p = new Program();
      
            // Act
            var textReader = new StringReader("2");
            Console.SetIn(textReader);

            int result = Program.ChooseBoard();


            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(4, result);
        }

        [Test()]
        public void BoardTest_4x4FullBoardDraw()
        {
            // Arrange
            Program p = new Program();
            string[] arr = { "0", "X", "O", "X", "O", "X", "O", "O", "X", "O", "O", "X", "X", "X", "O", "X", "O", "17", "18", "19", "20", "21", "22", "23", "24", "25" };


            // Act
            Program.InitArr(arr);
            int result = Program.CheckWin(4);

            Console.WriteLine("     |     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  |  {3}", arr[1], arr[2], arr[3], arr[10]);
            Console.WriteLine("_____|_____|_____|_____ ");
            Console.WriteLine("     |     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  |  {3}", arr[4], arr[5], arr[6], arr[11]);
            Console.WriteLine("_____|_____|_____|_____ ");
            Console.WriteLine("     |     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  |  {3}", arr[7], arr[8], arr[9], arr[12]);
            Console.WriteLine("_____|_____|_____|_____ ");
            Console.WriteLine("     |     |     |      ");
            Console.WriteLine(" {0}  | {1}  | {2}  | {3}", arr[13], arr[14], arr[15], arr[16]);
            Console.WriteLine("     |     |     |      ");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(-1, result);
        }

        [Test()]
        public void BoardTest_4x4FullBoardXWon()
        {
            // Arrange
            Program p = new Program();
            string[] arr = { "0", "1", "O", "X", "X", "O", "6", "7", "X", "O", "10", "11", "12", "13", "14", "X", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25" };


            // Act
            Program.InitArr(arr);
            int result = Program.CheckWin(4);

            Console.WriteLine("     |     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  |  {3}", arr[1], arr[2], arr[3], arr[10]);
            Console.WriteLine("_____|_____|_____|_____ ");
            Console.WriteLine("     |     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  |  {3}", arr[4], arr[5], arr[6], arr[11]);
            Console.WriteLine("_____|_____|_____|_____ ");
            Console.WriteLine("     |     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  |  {3}", arr[7], arr[8], arr[9], arr[12]);
            Console.WriteLine("_____|_____|_____|_____ ");
            Console.WriteLine("     |     |     |      ");
            Console.WriteLine(" {0}  | {1}  | {2}  | {3}", arr[13], arr[14], arr[15], arr[16]);
            Console.WriteLine("     |     |     |      ");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result);
        }

        [Test()]
        public void BoardTest_4x4FullBoardOWon()
        {
            // Arrange
            Program p = new Program();
            string[] arr = { "0", "1", "2", "3", "X", "O", "6", "7", "X", "9", "O", "O", "O", "X", "X", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25" };


            // Act
            Program.InitArr(arr);
            int result = Program.CheckWin(4);

            Console.WriteLine("     |     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  |  {3}", arr[1], arr[2], arr[3], arr[10]);
            Console.WriteLine("_____|_____|_____|_____ ");
            Console.WriteLine("     |     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  |  {3}", arr[4], arr[5], arr[6], arr[11]);
            Console.WriteLine("_____|_____|_____|_____ ");
            Console.WriteLine("     |     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  |  {3}", arr[7], arr[8], arr[9], arr[12]);
            Console.WriteLine("_____|_____|_____|_____ ");
            Console.WriteLine("     |     |     |      ");
            Console.WriteLine(" {0}  | {1}  | {2}  | {3}", arr[13], arr[14], arr[15], arr[16]);
            Console.WriteLine("     |     |     |      ");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result);
        }

        [Test()]
        public void BoardTest_5x5FullBoardDraw()
        {
            // Arrange
            Program p = new Program();
            string[] arr = { "0", "X", "O", "X", "X", "O", "X", "O", "X", "O", "O", "O", "X", "O", "X", "O", "X", "X", "X", "O", "O", "X", "O", "X", "O", "X" };


            // Act
            Program.InitArr(arr);
            int result = Program.CheckWin(4);

            Console.WriteLine("     |     |     |     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  |  {3} |  {4}  |", arr[1], arr[2], arr[3], arr[10], arr[17]);
            Console.WriteLine("_____|_____|_____|__________| ");
            Console.WriteLine("     |     |     |     |       |");
            Console.WriteLine("  {0}  |  {1}  |  {2}  |  {3}  |  {4}  |", arr[4], arr[5], arr[6], arr[11], arr[18]);
            Console.WriteLine("_____|_____|_____|_____|_____| ");
            Console.WriteLine("     |     |     |     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}  |  {3}  |  {4}  |", arr[7], arr[8], arr[9], arr[12], arr[19]);
            Console.WriteLine("_____|_____|_____|_____|_____| ");
            Console.WriteLine("     |     |     |     |     | ");
            Console.WriteLine(" {0}  | {1}  | {2}  | {3}  |  {4}  |", arr[13], arr[14], arr[15], arr[16], arr[20]);
            Console.WriteLine("_____|_____|_____|_____|_____| ");
            Console.WriteLine("     |     |     |     |     | ");
            Console.WriteLine(" {0}  | {1}  | {2}  | {3}  |  {4}  |", arr[21], arr[22], arr[23], arr[24], arr[25]);
            Console.WriteLine("     |     |     |     |     |      ");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(-1, result);
        }

        [Test()]
        public void BoardTest_5x5FullBoardXWon()
        {
            // Arrange
            Program p = new Program();
            string[] arr = { "0", "O", "2", "X", "4", "X", "6", "7", "O", "9", "10", "11", "12", "13", "14", "15", "X", "17", "18", "X", "20", "O", "22", "X", "24", "O" };


            // Act
            Program.InitArr(arr);
            int result = Program.CheckWin(4);

            Console.WriteLine("     |     |     |     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  |  {3} |  {4}  |", arr[1], arr[2], arr[3], arr[10], arr[17]);
            Console.WriteLine("_____|_____|_____|__________| ");
            Console.WriteLine("     |     |     |     |       |");
            Console.WriteLine("  {0}  |  {1}  |  {2}  |  {3}  |  {4}  |", arr[4], arr[5], arr[6], arr[11], arr[18]);
            Console.WriteLine("_____|_____|_____|_____|_____| ");
            Console.WriteLine("     |     |     |     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}  |  {3}  |  {4}  |", arr[7], arr[8], arr[9], arr[12], arr[19]);
            Console.WriteLine("_____|_____|_____|_____|_____| ");
            Console.WriteLine("     |     |     |     |     | ");
            Console.WriteLine(" {0}  | {1}  | {2}  | {3}  |  {4}  |", arr[13], arr[14], arr[15], arr[16], arr[20]);
            Console.WriteLine("_____|_____|_____|_____|_____| ");
            Console.WriteLine("     |     |     |     |     | ");
            Console.WriteLine(" {0}  | {1}  | {2}  | {3}  |  {4}  |", arr[21], arr[22], arr[23], arr[24], arr[25]);
            Console.WriteLine("     |     |     |     |     |      ");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result);
        }

        [Test()]
        public void BoardTest_5x5FullBoardoWon()
        {
            // Arrange
            Program p = new Program();
            string[] arr = { "0", "O", "2", "X", "4", "X", "X", "7", "O", "9", "10", "11", "12", "13", "14", "15", "X", "17", "X", "X", "20", "O", "22", "O", "O", "O" };


            // Act
            Program.InitArr(arr);
            int result = Program.CheckWin(4);

            Console.WriteLine("     |     |     |     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  |  {3} |  {4}  |", arr[1], arr[2], arr[3], arr[10], arr[17]);
            Console.WriteLine("_____|_____|_____|__________| ");
            Console.WriteLine("     |     |     |     |       |");
            Console.WriteLine("  {0}  |  {1}  |  {2}  |  {3}  |  {4}  |", arr[4], arr[5], arr[6], arr[11], arr[18]);
            Console.WriteLine("_____|_____|_____|_____|_____| ");
            Console.WriteLine("     |     |     |     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}  |  {3}  |  {4}  |", arr[7], arr[8], arr[9], arr[12], arr[19]);
            Console.WriteLine("_____|_____|_____|_____|_____| ");
            Console.WriteLine("     |     |     |     |     | ");
            Console.WriteLine(" {0}  | {1}  | {2}  | {3}  |  {4}  |", arr[13], arr[14], arr[15], arr[16], arr[20]);
            Console.WriteLine("_____|_____|_____|_____|_____| ");
            Console.WriteLine("     |     |     |     |     | ");
            Console.WriteLine(" {0}  | {1}  | {2}  | {3}  |  {4}  |", arr[21], arr[22], arr[23], arr[24], arr[25]);
            Console.WriteLine("     |     |     |     |     |      ");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result);
        }
    }
}
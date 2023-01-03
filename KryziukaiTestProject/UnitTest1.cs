using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Kryziukai;

namespace KryziukaiTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ChooseBoardTest()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            Program p = new Program();

            // Act

            Program.ChooseBoard();

            // Assert
            var sb = writer.GetStringBuilder();
            Assert.Equals("Please choose board size/n", sb.ToString().Trim());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Deck_Of_Cards.UnitTest
{
    [TestClass]
    public class FileWriterTests
    {
        [TestMethod]
        public void WriterToFile_WriteFile()
        {
            // Arrange
            var mockFileWriter = new FileWriter();
            var mockInput = new List<Player>();
            mockInput.Add(new Player("Test", 0));
            mockInput.Add(new Player("Test2", 1));
            mockInput.Add(new Player("Test3", 2));
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Act & Assert
            mockFileWriter.WriterToFile(mockInput);
            using (StreamReader sr = new StreamReader(Path.Combine(docPath, "Deck_Of_Cards.txt")))
            {
                string line = sr.ReadToEnd();
                Assert.IsTrue(line.Length > 0);
            }

        }
    }
}

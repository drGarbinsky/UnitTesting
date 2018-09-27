using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrintStuff;
using DataSource;

namespace TestStuff
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void GiveProcessInfoOutputIsFormatted()
        {
            // arrange
            var target = new Formatter();
            var src = new ProcessIdSource();
            var expected = "Current Process ID: 200";

            // act
            var actual = target.GetFormatedOutput(src);

            // assert
            Assert.AreEqual<string>(expected, actual);
        }


        [TestMethod]
        public void GivenEvenProcessIdOutputIsWrittenToFile()
        {
            // arrange
            var data = new ProcessIdSource();
            var frmt = new Formatter();

            var target = new Printer(frmt, data);

            // act
            target.Print();

            // Assert
            // How do we know 

        }

        [TestMethod]
        public void GivenOddProcessIdOutputIsNotWrittenToFile()
        {
            // arrange
            var data = new ProcessIdSource();
            var frmt = new Formatter();

            var target = new Printer(frmt, data);

            // act
            target.Print();

            // Assert
            // How do we know 

        }
    }
}

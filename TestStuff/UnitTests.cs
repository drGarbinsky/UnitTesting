using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrintStuff;

namespace TestStuff
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestGetFormatedOutput()
        {
            // arrange
            var target = new Formatter();
            var src = new DataSource();
            var expected = "Current Process ID: 200";

            // act
            var actual = target.GetFormatedOutput(src);

            // assert
            Assert.AreEqual<string>(expected, actual);
        }


        [TestMethod]
        public void TestPrint()
        {
            // arrange
            var data = new DataSource();
            var frmt = new Formatter();

            var target = new Printer(frmt, data);

            // act
            target.Print();

            // Assert
            // what goes here??

        }
    }
}

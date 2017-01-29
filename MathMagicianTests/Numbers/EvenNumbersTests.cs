using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class EvenNumberWithInterfaceTests
    {
        [TestMethod]
        public void EnsureICanCrestInstance()
        {
            EvenNumberWithInterface evenNumber = new EvenNumberWithInterface();

            Assert.IsNotNull(evenNumber);
        }

        [TestMethod]
        public void EnsureOneIsTheFirstNumber()
        {
            // Arrange (Where you set stuff up)
            EvenNumberWithInterface evenNumber = new EvenNumberWithInterface();

            // Act (Call the method you're testing)
            int expectedResult = 2;
            int actualResult = evenNumber.GetFirst();

            // Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void EnsureICanGetNext()
        {
            // Arrange
            EvenNumberWithInterface evenNumber = new EvenNumberWithInterface();

            // Act
            int expectedResult = 8;
            //int myNum; this is zero "0"
            int actualResult = evenNumber.GetNext(6);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanGetSequence()
        {
            // Arrange
            EvenNumberWithInterface evenNumber = new EvenNumberWithInterface();

            // Act
            int[] expectedResult = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

            int[] actualResult = evenNumber.GetSequence(10);

            // Assert
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanPrintSequence()
        {
            // Arrange
            EvenNumberWithInterface evenNumber = new EvenNumberWithInterface();

            // Act
            string expectedResult = "2 4 6 8 10";
            int[] inputArray = new[] { 2, 4, 6, 8, 10 };
            string actualResult = evenNumber.printNumbers(inputArray);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
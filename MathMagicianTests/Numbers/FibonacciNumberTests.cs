using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class FibonacciNumberTests
    {
        // Recursive Definition of Fibonacci
        // F3 = F2 + F1
        // F7 = F6 + F5
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            FibonacciNumber fiboNumber = new FibonacciNumber();
            Assert.IsNotNull(fiboNumber);
        }

        [TestMethod]
        public void EnsureOneIsTheFirst()
        {
            // Arrange (Where you set stuff up)
            FibonacciNumber fiboNumber = new FibonacciNumber();

            // Act (Call the method you're testing)
            int expectedResult = 1;
            int actualResult = fiboNumber.GetFirst();

            // Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanGetNext()
        {
            // Arrange
            FibonacciNumber fiboNumber = new FibonacciNumber();

            // Act
            int expectedResult = 8;
            //int myNum; this is zero "0"
            int actualResult = fiboNumber.GetNext(6);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanGetSequence()
        {
            // Arrange
            FibonacciNumber fiboNumber = new FibonacciNumber();

            // Act
            int[] expectedResult = { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };            //int myNum; this is zero "0"
            int[] actualResult = fiboNumber.GetSequence(10);

            // Assert
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanPrintSequence()
        {
            // Arrange
            FibonacciNumber fiboNumber = new FibonacciNumber();

            // Act
            string expectedResult = "1 1 2 3 5";
            int[] inputArray = new[] { 1, 1, 2, 3, 5 };
            string actualResult = fiboNumber.printNumbers(inputArray);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class NaturalNumberTests
    {
        //This is a sanity check
        //Ensures everything is hooked up correctly and that the permissions are correct.
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            NaturalNumber naturalNumber = new NaturalNumber();

            //Assert
            Assert.IsNotNull(naturalNumber);
        }

        [TestMethod]
        public void EnsureOneIsTheFirst()
        {
            //Arrange (Where you set stuff up)

            NaturalNumber naturalNumber = new NaturalNumber();

            //Act (call the method you're testing)

            int actualResult = naturalNumber.GetFirst();
            int expectedResult = 1;

            //Assert (check the output from your method)

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureGettingTheNextNumer()
        {
            //Arrange (Where you set stuff up)

            NaturalNumber getNext = new NaturalNumber();

            //Act (call the method you're testing)

            int actualResult = getNext.GetNext(1);
            int expectedResult = 2;

            //Assert (check the output from your method)

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanGetSequence()
        {
            // Arrange
            NaturalNumber naturalNumber = new NaturalNumber();

            // Act
            int[] expectedResult = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int myNum; this is zero "0"
            int[] actualResult = naturalNumber.GetSequence(10);

            // Assert
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanPrintSequence()
        {
            // Arrange
            NaturalNumber naturalNumber = new NaturalNumber();

            // Act
            string expectedResult = "1 2 3 4 5";
            int[] inputArray = new[] { 1, 2, 3, 4, 5 };
            string actualResult = naturalNumber.printNumbers(inputArray);
            //string actualResult = naturalNumber.PrintNumbers(new[] { 1, 2, 3, 4, 5 });

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

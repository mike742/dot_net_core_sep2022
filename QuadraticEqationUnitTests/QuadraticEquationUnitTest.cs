using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp_don_net_6;
using System;

namespace QuadraticEqationUnitTests
{
    [TestClass]
    public class QuadraticEquationUnitTest
    {
        private int _a;
        private int _b;
        private int _c;
        private string? expectedResult;
        private string? actualResult;

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Calculate_a_is_outOfRange()
        {
            // Arrange
            _a = -100; // [-99..99]
            _b = 1;
            _c = 2;
            // Act
            QuadraticEqation.Calculate(_a, _b, _c);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Calculate_b_is_outOfRange()
        {
            // Arrange
            _a = 1;
            _b = 100; // [-99..99]
            _c = 2;
            // Act
            QuadraticEqation.Calculate(_a, _b, _c);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Calculate_c_is_outOfRange()
        {
            _a = 1;
            _b = 1;
            _c = 100; // [-99..99]
            QuadraticEqation.Calculate(_a, _b, _c);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Calculate_a_is_zero()
        {
            _a = 0;
            _b = 1;
            _c = 1;
            QuadraticEqation.Calculate(_a, _b, _c);
        }

        [TestMethod]
        public void Calculate_Imaginary_Roots()
        {
            _a = 2;
            _b = 1;
            _c = 2;

            expectedResult = "x's roots are imaginary";
            actualResult = QuadraticEqation.Calculate(_a, _b, _c);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Calculate_One_Root()
        {
            _a = 1;
            _b = -2;
            _c = 1;

            expectedResult = "x = 1.000";
            actualResult = QuadraticEqation.Calculate(_a, _b, _c);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Calculate_Two_Roots()
        {
            _a = -5;
            _b = 5;
            _c = 5;

            expectedResult = "x = -0.618, x = 1.618";
            actualResult = QuadraticEqation.Calculate(_a, _b, _c);

            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}
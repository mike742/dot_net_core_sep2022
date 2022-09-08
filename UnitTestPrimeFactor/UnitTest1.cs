using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestPrimeFactor
{
    [TestClass]
    public class UnitTest1
    {
        private int _param;
        [TestMethod]
        public void TestMethod_PrimeFactor_4()
        {
            // AAA
            // A - Arrange
            _param = 4;

            // A - Act
            var actualResult = Team_B.PrimeFactors.Get(_param);

            // A - Accert
            var expectedResult = "2 x 2";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod_PrimeFactor_7()
        {
            _param = 7;
            var actualResult = Team_B.PrimeFactors.Get(_param);
            var expectedResult = "7";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod_PrimeFactor_30()
        {
            _param = 30;
            var actualResult = Team_B.PrimeFactors.Get(_param);
            var expectedResult = "2 x 3 x 5";
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
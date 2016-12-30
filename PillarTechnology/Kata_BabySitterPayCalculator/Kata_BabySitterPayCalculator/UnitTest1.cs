using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PayCalculator;
namespace PayCalculatorTestCases
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void basicFailedTest()
        {
            double pay = Program.WageCalc();

            Assert.AreEqual(0, pay);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PayCalculator;
namespace PayCalculatorTestCases
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void basicFailedTest()
        //{
        //    double pay = Program.WageCalc();

        //    Assert.AreEqual(0, pay);
        //}

        [TestMethod]
        public void WageTest_BeforeBedtime()
        {
            // 5 hours worked at a rate of 12/hr = 60

            int pay = Program.WageCalc(5);

            Assert.AreEqual(60, pay);
        }

        [TestMethod]
        public void Wage_AFterBedtime()
        {
            //5 hours worked
            // hours from start time to bedTime. example startTime is 7pm, and bedtime at 9pm. Value would be 2. 
            // pay equals $42

            int pay = Program.WageCalc(5);

            Assert.AreEqual(44, pay);
        }
    }
}

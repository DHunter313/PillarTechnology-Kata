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

        //[TestMethod]
        //public void WageTest_BeforeBedtime()
        //{
        //    // 5 hours worked at a rate of 12/hr = 60

        //    int pay = Program.WageCalc(5);

        //    Assert.AreEqual(60, pay);
        //}

        [TestMethod]
        public void Wage_AFterBedtime()
        {
            //5 hours worked
            // hours from start time to bedTime. example startTime is 7pm, and bedtime at 9pm. Value would be 2. 
            // pay equals $48

            int pay1 = Program.WageCalc(5,2);
            Assert.AreEqual(48, pay1);

            // 2 hour shift, 1 hour worked before bedtime. 
            // pay should equal  20
            int pay2 = Program.WageCalc(2, 1);
            Assert.AreEqual(20, pay2);

        }

        [TestMethod]
        public void AfterBedtime_BeforeMidnite()
        {
            // 3 hours of work
            // started at 7pm, and ends at 10pm.
            // bedtime is 8pm, which is 1 hour after start time.
            // Wage should equal 28

            double pay = Program.WageCalc(3, 1);

            Assert.AreEqual(28, pay);
        }
    }
}

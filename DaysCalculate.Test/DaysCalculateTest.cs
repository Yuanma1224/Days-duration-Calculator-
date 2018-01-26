using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DaysCalculate.Test
{
    [TestClass]
    public class DaysCalculateTest
    {
        DaysCalculate DaysCalculator = new DaysCalculate();

        [TestMethod]
        public void Test_IsLeapYear()
        {
            //Arrange
            int iTestYear = 2008;

            bool bExpected = true;

            //Act
            bool bActual = DaysCalculator.IsLeapYear(iTestYear);

            //Assert
            Assert.AreEqual(bExpected, bActual);

        }

        [TestMethod]
        public void Test_TotaldaysinCurrentMonth()
        {
            //Arrange
            int iTestYear = 2017;
            int iTestMonth = 2;

            int iExpectedMothdays = 28;

            //Act
            int iActualMonthDays = DaysCalculator.TotaldaysinCurrentMonth(iTestYear, iTestMonth);

            //Assert
            Assert.AreEqual(iExpectedMothdays, iActualMonthDays);
        }

        [TestMethod]
        public void Test_ConvertToDays()
        { //Arrange
            int iTestYear = 2018;
            int iTestMonth = 1;
            int iTestDay = 9;
            int iTestBaselineYear = 2018;

            int iExpectedDays = 9;

            //Act
            int iActualDays = DaysCalculator.ConvertToDays(iTestYear, iTestMonth, iTestDay, iTestBaselineYear);

            //Assert
            Assert.AreEqual(iExpectedDays, iActualDays);
        }

        [TestMethod]
        public void Test_CalculateDurationinDays()
        { //Arrange
            int iTestStartYear = 2018;
            int iTestStartMonth = 1;
            int iTestStartDay = 9;

            int iTestEndYear = 2018;
            int iTestEndMonth = 1;
            int iTestEndDay = 19;


            int iExpectedDurationDays = 10;

            //Act
            int iActualDurationDays = DaysCalculator.CalculateDurationinDays(iTestStartYear, iTestStartMonth, iTestStartDay,
                                                                    iTestEndYear, iTestEndMonth, iTestEndDay);

            //Assert
            Assert.AreEqual(iExpectedDurationDays, iActualDurationDays);
        }

    }
}

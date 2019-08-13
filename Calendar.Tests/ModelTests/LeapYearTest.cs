using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calendar;

namespace Calendar.Test
{
    [TestClass]
    public class LeapYearTest
    {
        [TestMethod]
        public void isLeapYear_DivisibleByFour_True()
        {
            LeapYear testLeapYear = new LeapYear();
            Assert.AreEqual(true, testLeapYear.IsLeapYear(2008));
        }

        [TestMethod]
        public void isLeapYear_NotDivisibleByFour_False()
        {
            LeapYear testLeapYear = new LeapYear();
            Assert.AreEqual(false, testLeapYear.IsLeapYear(2003));
        }

        [TestMethod]
        public void isLeapYear_NotDivisibleByHundred_False()
        {
            LeapYear testLeapYear = new LeapYear();
            Assert.AreEqual(false, testLeapYear.IsLeapYear(2003));
        }
        
        [TestMethod]
        public void isLeapYear_DivisibleByFourHundred_True()
        {
            LeapYear testLeapYear = new LeapYear();
            Assert.AreEqual(true, testLeapYear.IsLeapYear(2000));
        }
    }

}
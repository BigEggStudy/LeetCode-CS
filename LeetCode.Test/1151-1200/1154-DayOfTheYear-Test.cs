using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1154_DayOfTheYear_Test
    {
        [TestMethod]
        public void DayOfYear_1()
        {
            var solution = new _1154_DayOfTheYear();
            var result = solution.DayOfYear("2019-01-09");
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void DayOfYear_2()
        {
            var solution = new _1154_DayOfTheYear();
            var result = solution.DayOfYear("2019-02-10");
            Assert.AreEqual(41, result);
        }

        [TestMethod]
        public void DayOfYear_3()
        {
            var solution = new _1154_DayOfTheYear();
            var result = solution.DayOfYear("2003-03-01");
            Assert.AreEqual(60, result);
        }

        [TestMethod]
        public void DayOfYear_4()
        {
            var solution = new _1154_DayOfTheYear();
            var result = solution.DayOfYear("2004-03-01");
            Assert.AreEqual(61, result);
        }

        [TestMethod]
        public void DayOfYear_5()
        {
            var solution = new _1154_DayOfTheYear();
            var result = solution.DayOfYear("2016-02-29");
            Assert.AreEqual(60, result);
        }
    }
}

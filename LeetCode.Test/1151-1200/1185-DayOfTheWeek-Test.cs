using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1185_DayOfTheWeek_Test
    {
        [TestMethod]
        public void DayOfTheWeek_1()
        {
            var solution = new _1185_DayOfTheWeek();
            var result = solution.DayOfTheWeek(31, 8, 2019);
            Assert.AreEqual("Saturday", result);
        }

        [TestMethod]
        public void DayOfTheWeek_2()
        {
            var solution = new _1185_DayOfTheWeek();
            var result = solution.DayOfTheWeek(18, 7, 1999);
            Assert.AreEqual("Sunday", result);
        }

        [TestMethod]
        public void DayOfTheWeek_3()
        {
            var solution = new _1185_DayOfTheWeek();
            var result = solution.DayOfTheWeek(15, 8, 1993);
            Assert.AreEqual("Sunday", result);
        }
    }
}

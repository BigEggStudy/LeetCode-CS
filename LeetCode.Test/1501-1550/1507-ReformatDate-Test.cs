using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1507_ReformatDate_Test
    {
        [TestMethod]
        public void ReformatDate_1()
        {
            var solution = new _1507_ReformatDate();
            var result = solution.ReformatDate("20th Oct 2052");
            Assert.AreEqual("2052-10-20", result);
        }

        [TestMethod]
        public void ReformatDate_2()
        {
            var solution = new _1507_ReformatDate();
            var result = solution.ReformatDate("6th Jun 1933");
            Assert.AreEqual("1933-06-06", result);
        }

        [TestMethod]
        public void ReformatDate_3()
        {
            var solution = new _1507_ReformatDate();
            var result = solution.ReformatDate("26th May 1960");
            Assert.AreEqual("1960-05-26", result);
        }
    }
}

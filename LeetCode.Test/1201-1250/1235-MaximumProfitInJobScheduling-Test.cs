using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1235_MaximumProfitInJobScheduling_Test
    {
        [TestMethod]
        public void JobScheduling_1()
        {
            var solution = new _1235_MaximumProfitInJobScheduling();
            var result = solution.JobScheduling(new int[] { 1, 2, 3, 3 }, new int[] { 3, 4, 5, 6 }, new int[] { 50, 10, 40, 70 });
            Assert.AreEqual(120, result);
        }

        [TestMethod]
        public void JobScheduling_2()
        {
            var solution = new _1235_MaximumProfitInJobScheduling();
            var result = solution.JobScheduling(new int[] { 1, 2, 3, 4, 6 }, new int[] { 3, 5, 10, 6, 9 }, new int[] { 20, 20, 100, 70, 60 });
            Assert.AreEqual(150, result);
        }

        [TestMethod]
        public void JobScheduling_3()
        {
            var solution = new _1235_MaximumProfitInJobScheduling();
            var result = solution.JobScheduling(new int[] { 1, 1, 1 }, new int[] { 2, 3, 4 }, new int[] { 5, 6, 4 });
            Assert.AreEqual(6, result);
        }
    }
}

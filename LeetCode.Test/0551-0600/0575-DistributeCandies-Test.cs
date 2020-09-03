using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0575_DistributeCandies_Test
    {
        [TestMethod]
        public void DistributeCandies_1()
        {
            var solution = new _0575_DistributeCandies();
            var result = solution.DistributeCandies(new int[] { 1, 1, 2, 2, 3, 3 });
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void DistributeCandies_2()
        {
            var solution = new _0575_DistributeCandies();
            var result = solution.DistributeCandies(new int[] { 1, 1, 2, 3 });
            Assert.AreEqual(2, result);
        }
    }
}

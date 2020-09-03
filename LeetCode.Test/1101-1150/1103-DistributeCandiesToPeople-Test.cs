using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1103_DistributeCandiesToPeople_Test
    {
        [TestMethod]
        public void DistributeCandies_1()
        {
            var solution = new _1103_DistributeCandiesToPeople();
            var result = solution.DistributeCandies(7, 4);
            AssertHelper.AssertArray(new int[] { 1, 2, 3, 1 }, result);
        }

        [TestMethod]
        public void DistributeCandies_2()
        {
            var solution = new _1103_DistributeCandiesToPeople();
            var result = solution.DistributeCandies(10, 3);
            AssertHelper.AssertArray(new int[] { 5, 2, 3 }, result);
        }
    }
}

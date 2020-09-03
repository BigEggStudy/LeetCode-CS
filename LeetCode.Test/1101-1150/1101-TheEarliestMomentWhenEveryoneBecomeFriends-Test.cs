using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1101_TheEarliestMomentWhenEveryoneBecomeFriends_Test
    {
        [TestMethod]
        public void EarliestAcq_1()
        {
            var solution = new _1101_TheEarliestMomentWhenEveryoneBecomeFriends();
            var result = solution.EarliestAcq(new int[][] {
                new int[] { 20190101, 0, 1 },
                new int[] { 20190104, 3, 4 },
                new int[] { 20190107, 2, 3 },
                new int[] { 20190211, 1, 5 },
                new int[] { 20190224, 2, 4 },
                new int[] { 20190301, 0, 3 },
                new int[] { 20190312, 1, 2 },
                new int[] { 20190322, 4, 5 },
            }, 6);
            Assert.AreEqual(20190301, result);
        }

        [TestMethod]
        public void EarliestAcq_2()
        {
            var solution = new _1101_TheEarliestMomentWhenEveryoneBecomeFriends();
            var result = solution.EarliestAcq(new int[][] {
                new int[] { 3, 0, 3 },
                new int[] { 4, 1, 2 },
                new int[] { 0, 2, 0 },
                new int[] { 2, 0, 2 },
                new int[] { 8, 0, 3 },
                new int[] { 1, 0, 1 },
                new int[] { 5, 1, 2 },
                new int[] { 7, 3, 1 },
                new int[] { 6, 1, 0 },
                new int[] { 9, 3, 0 },
            }, 4);
            Assert.AreEqual(3, result);
        }
    }
}
